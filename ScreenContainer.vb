'--------------------------------------------------------------------------------
'FOXTOOLS SCREEN SHOOTER
'Software for screen capture.
'Copyright (c) Aleksey Nemiro, 2013
'
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License version 3
'as published by the Free Software Foundation.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
'Home page:
'<http://foxtools.ru/Shooter>  (sorry, only Russian)
'Community:
'<http://kbyte.ru/ru/Groups/Show.aspx?id=24> (sorry, only Russian)
'English thread:
'<http://kbyte.ru/en/Forums/Show2.aspx?id=24&mid=13936>
'
'ХИТРЫЙ СТРЕЛОК ЭКРАНОВ
'Программа для создания, редактирования и отправки в Интернет снимков экранов.
'Copyright (c) Aleksey Nemiro, 2013
'
'Это свободная программа: вы можете повторно распространять её и/или модифицировать
'в соответствии со Стандартной Общественной Лицензий GNU версии 3, опубликованной Фондом Свободного ПО.
'Эта программа распространяется в надежде, что она будет полезной, но БЕЗ КАКИХ-ЛИБО ГАРАНТИЙ;
'даже без подразумеваемых гарантий КОММЕРЧЕСКОЙ ЦЕННОСТИ или ПРИГОДНОСТИ ДЛЯ КОНКРЕТНОЙ ЦЕЛИ.
'Для получения подробных сведений смотрите Стандартную Общественную Лицензию GNU.
'Вы должны были получить копию Стандартной Общественной Лицензии GNU вместе с этой
'программой; если нет, смотрите <http://www.gnu.org/licenses/gpl-3.0.html>
'
'Официальная страничка программы:
'<http://foxtools.ru/Shooter>
'Сообщество:
'<http://kbyte.ru/ru/Groups/Show.aspx?id=24>
'Ветка проекта:
'<http://kbyte.ru/ru/Forums/Show2.aspx?id=24&mid=13935>
'--------------------------------------------------------------------------------
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text

Public Class ScreenContainer

#Region "WinAPI"

  'TODO: To create snapshots of windows need to use WinAPI.
  'I tried to do, but not find suitable methods.
  'You can see other WinAPI function in the API.md file.

  'TODO:
  'Это API, которые я опробовал для решения задачи по снятию снимков окон,
  'точнее главным образом поиска видимых окон.
  'Есть и другие методы, см. API.md в корне проекта.

  'Private Delegate Function EnumDelegate(hWnd As IntPtr, lParam As Integer) As Boolean

  '<DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
  'Private Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
  'End Function

  '<DllImport("user32.dll")> _
  'Private Shared Function EnumWindows(lpEnumCallbackFunction As EnumDelegate, lParam As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
  'End Function

  '<DllImport("user32.dll", SetLastError:=True)> _
  'Private Shared Function GetWindowRect(ByVal hWnd As IntPtr, <Out()> ByRef lpRect As RECT) As <MarshalAs(UnmanagedType.Bool)> Boolean
  'End Function

  '<StructLayoutAttribute(LayoutKind.Sequential)> _
  'Private Structure RECT
  ' Public left As Integer
  ' Public top As Integer
  ' Public right As Integer
  ' Public bottom As Integer
  ' End Structure

  '<DllImport("user32.dll", SetLastError:=True)> _
  'Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
  'End Function

#End Region

  Private _bmp As Bitmap = Nothing
  Private _mf As Main = Nothing
  Private _mode As Enums.ScreenMode = Enums.ScreenMode.Full

  Private _selecting As Boolean = False

  'for rectangle
  'переменные для выделения прямоугольной области экрана
  Private _start As Point = Point.Empty

  Private _end As Point = Point.Empty

  'for free form
  'коллекция точек для произвольного выделения области экрана
  Private _points As List(Of Point)

  'todo: for windows
  'коллекция координат и размеров видимых окон для выделения окон
  Private _windows As List(Of Rectangle)

  Public Sub New(mf As Main, mode As Enums.ScreenMode)
    InitializeComponent()
    _mf = mf 'set main form / запоминаем ссылку на главную форму
    _mode = mode 'set screen capture mode / запоминаем режим выделения экрана

    'hide main form
    'прячем главную форму, чтобы её не было на скрине
    Dim l As Integer = _mf.Left
    _mf.Left = -Screen.PrimaryScreen.Bounds.Width * 2
    '_mf.Visible = False ' форма почему-то все равно попадает в снимок экрана..
    'думаю, дело в анимации Windows 7, окно просто не успевает исчезнуть (Windows 7 x64 Pro SP1)
    'Problem with Windows 7 animation

    'screen capture / получаем основной экран
    Dim s As Screen = Screen.PrimaryScreen
    'create bitmap / создаем Bitmap
    _bmp = New Bitmap(s.Bounds.Width, s.Bounds.Height, PixelFormat.Format32bppArgb)
    Dim g As Graphics = Graphics.FromImage(_bmp)
    'copy screen to bitmap / копируем экран в Bitmap
    g.CopyFromScreen(s.Bounds.X, s.Bounds.Y, 0, 0, s.Bounds.Size, CopyPixelOperation.SourceCopy)

    'show main form / возвращает главную форму в исходное положении
    _mf.Left = l

    'set TopMost / делаем формы поверх всех окон
    'ATTENTION: comment this line to debug / ВНИМАНИЕ: При отладке, лучше закомментировать эти две строчки кода!
    Me.TopMost = True : _mf.TopMost = True 'I like C# / C# рулит, определенно :)

    'link the main form with the current / прилепляем главную форму к текущей, чтобы она всегда была выше текущей формы
    _mf.Owner = Me
  End Sub

  Private Sub ScreenContainer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    'определяем действие в зависимости от выбранного пользователем режима
    Select Case _mode
      Case Enums.ScreenMode.Window 'окна
        'TODO: get all visible windows position and size

        'получаем список координат открытых окон, исключая себя
        'TODO : пока не ясно, как это лучше сделать

        'Dim openWindows As New List(Of IntPtr)

        'Dim filter As EnumDelegate = Function(hWnd As IntPtr, lParam As Integer)
        ''исключаем невидимые окна, свернутые окна
        'If IsWindowVisible(hWnd) AndAlso Not (GetWindowLong(hWnd, -16) And &H20000000L) = &H20000000L Then
        ' openWindows.Add(hWnd)
        ' End If
        ' Return True
        'End function

        'If EnumWindows(filter, 0) Then ' EnumDesktopWindows(IntPtr.Zero, filter, IntPtr.Zero)
        'For Each h As IntPtr In openWindows
        ' Dim rec As RECT
        ' If GetWindowRect(h, rec) Then
        ' 'If WindowFromPoint(New SPOINT(rec.left, rec.top)) = IntPtr.Zero Then
        ' 'Console.WriteLine("{0}: {1} - НЕДОСТУПНО", h, GetWindowTitle(h))
        ' 'Else
        ' Console.WriteLine("{4} - {5}; x = {0}; y = {1}; w = {2}; h = {3}", rec.left, rec.top, rec.right - rec.left, rec.bottom - rec.top, h, "GetWindowTitle(h)")
        ' 'End If
        ' End If
        ' Next
        ' End If

        '' For Each p As Process In Process.GetProcesses()
        '' If Not p.MainWindowHandle = IntPtr.Zero Then
        '' Dim rec As RECT
        '' If IsWindowVisible(p.MainWindowHandle) AndAlso GetWindowRect(p.MainWindowHandle, rec) Then
        '' Console.WriteLine("{4}; x = {0}; y = {1}; w = {2}; h = {3}", rec.left, rec.top, rec.right - rec.left, rec.bottom - rec.top, p.ProcessName)
        '' End If
        '' End If
        '' Next

      Case Enums.ScreenMode.Rectangle 'прямоугольник
        Me.Cursor = Cursors.Cross

      Case Enums.ScreenMode.Custom 'произвольная форма

      Case Else 'full screen / весь экран
        'передаем изображение экрана как есть для дальнейшей обработке
        _selecting = True
        ScreenContainer_MouseUp(Nothing, Nothing)

    End Select
  End Sub

  Private Sub ScreenContainer_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim g As Graphics = e.Graphics
    g.DrawImage(_bmp, 0, 0)

    ' g.FillRectangle(b, 0, 0, _bmp.Width, _bmp.Height)

    Dim r As New Region(New Rectangle(0, 0, _bmp.Width, _bmp.Height))

    'create pen / создаем карандаш нужного цвета
    Dim p As New Pen(My.Settings.SelectColor)

    If _mode = Enums.ScreenMode.Rectangle Then '*

      'rectangle / прямоугольник
      Dim exclude As Rectangle = Rectangle.Empty
      'If Not _start = Point.Empty AndAlso Not _end = Point.Empty Then
      Dim x, y, w, h As Integer
      If _end.X - _start.X < 0 Then
        x = _end.X
        w = _start.X - _end.X
      Else
        x = _start.X
        w = _end.X - _start.X
      End If
      If _end.Y - _start.Y < 0 Then
        y = _end.Y
        h = _start.Y - _end.Y
      Else
        y = _start.Y
        h = _end.Y - _start.Y
      End If
      exclude = New Rectangle(x, y, w, h)
      'End If

      If Not exclude = Rectangle.Empty Then
        r.Exclude(exclude)
        g.DrawRectangle(p, exclude)
      End If

    ElseIf _mode = Enums.ScreenMode.Custom Then '*

      'free form / произвольное выделение
      If _points IsNot Nothing AndAlso _points.Count > 1 Then

        Dim gp As New GraphicsPath()

        'gp.StartFigure()
        gp.AddCurve(_points.ToArray())
        'gp.CloseFigure()

        'r.Exclude(gp)'если убрать комментарий, то наложение со скрина в месте выделения будет удалена

        g.DrawPath(p, gp)
      End If

    End If '*

    If My.Settings.AllowOverlay Then
      'draw overlay with hole / рисуем наложение с дыркой
      Dim b As SolidBrush = New SolidBrush(Color.FromArgb(My.Settings.OverlayAlpha, My.Settings.OverlayColor))
      g.FillRegion(b, r)
    End If
  End Sub

  Private Sub ScreenContainer_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Left Then
      'start selection / начало выделения области экрана
      _mf.Visible = False
      _selecting = True

      If _mode = Enums.ScreenMode.Rectangle Then
        _start = e.Location
        _end = e.Location
      ElseIf _mode = Enums.ScreenMode.Custom Then
        _points = New List(Of Point)
        _points.Add(e.Location)
      End If

      Me.Refresh()
    Else
      'remove points
      'если нажата любая другая кнопка
      'удаляем выбранную область
      _points = Nothing
      _start = Point.Empty
      _end = Point.Empty
      'update image / обновляем рисунок
      Me.Refresh()
      'end selection / отключаем режим выбора фрагмента
      _selecting = False
      'show main form / показываем главную форму
      If Not _mf.Visible Then _mf.Show()
    End If
  End Sub

  Private Sub ScreenContainer_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
    If _selecting Then
      'end selection / завершение выделение области экрана
      _selecting = False

      'crop image
      'вырезаем фрагмент снимка экрана и передаем в результатирующее окно
      Dim bmp As Bitmap = Nothing
      Dim g As Graphics = Nothing

      Select Case _mode
        Case Enums.ScreenMode.Window 'окна
          'TODO:
          'здесь должно быть все примерно как у прямоугольника

        Case Enums.ScreenMode.Rectangle 'прямоугольник

          'If Not _start = Point.Empty AndAlso Not _end = Point.Empty Then
          Dim x, y, w, h As Integer
          If _end.X - _start.X < 0 Then
            x = _end.X
            w = _start.X - _end.X
          Else
            x = _start.X
            w = _end.X - _start.X
          End If
          If _end.Y - _start.Y < 0 Then
            y = _end.Y
            h = _start.Y - _end.Y
          Else
            y = _start.Y
            h = _end.Y - _start.Y
          End If
          If w = 0 OrElse h = 0 Then
            _mf.Show()
            Return
          End If
          bmp = New Bitmap(w, h)
          g = Graphics.FromImage(bmp)
          g.DrawImage(_bmp, bmp.GetBounds(GraphicsUnit.Pixel), New Rectangle(x, y, w, h), GraphicsUnit.Pixel)
          'End If

        Case Enums.ScreenMode.Custom 'произвольная форма

          If _points IsNot Nothing AndAlso _points.Count > 1 Then

            Dim gp As New GraphicsPath()
            gp.AddCurve(_points.ToArray())

            'get postion and size / определяем координаты ввод и размер конечного изображения
            Dim x As Integer = _bmp.Width, y As Integer = _bmp.Height
            Dim w, h As Integer

            For Each p As Point In _points
              If p.X < x Then
                x = p.X
              End If
              If p.X > w Then
                w = p.X
              End If
              If p.Y < y Then
                y = p.Y
              End If
              If p.Y > h Then
                h = p.Y
              End If
            Next

            w -= x : h -= y

            'создаем матрицу преобразования
            Dim m As New Matrix(1, 0, 0, 1, -x, -y)
            gp.Transform(m)

            'создаем конечный bitmap
            bmp = New Bitmap(w, h)
            g = Graphics.FromImage(bmp)

            'crop image / вырезка
            g.SetClip(gp)

            'draw image / рисуем
            g.DrawImage(_bmp, -x, -y)
          End If

        Case Else 'full screen / весь экран
          bmp = _bmp

      End Select

      If bmp Is Nothing Then
        'считаем, что процесс не завершен
        _mf.Show()
        Return
      End If

      'show result / показываем результат
      Call New Result(bmp).Show()

      'отлепляем главную форму от текущей
      _mf.Owner = Nothing
      'закрываем текущую форму
      Me.Close()
      'kill main form / закрываем главную форму
      _mf.Close()
    End If
  End Sub

  Private Sub ScreenContainer_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    If _selecting Then
      'изменение выделения области экрана
      If _mode = Enums.ScreenMode.Rectangle Then
        'меняем конец (не путать с концом ;) ) прямоугольника
        _end = e.Location
      ElseIf _mode = Enums.ScreenMode.Custom Then
        'добавляем пользовательскую точку в коллекцию
        _points.Add(e.Location)
      ElseIf _mode = Enums.ScreenMode.Window Then
        'TODO:
        '1. Проверяем, находится курсор в области открытого окна или нет
        '2. Команда на прорисовку контура окна, если курсор находится в его области

      End If

      'обновляем картинку
      Me.Refresh()
    End If
  End Sub

  Private Sub ScreenContainer_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
    If e.KeyCode = Keys.Escape Then
      'show main form / показываем главную форму
      _mf.Show()
      'выключаем режим создания снимка
      _mf.CancelSelect()
    End If
  End Sub

End Class
