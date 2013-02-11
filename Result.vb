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
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Threading
Imports System.Runtime.InteropServices

Public Class Result

  Private _bmp As Bitmap = Nothing
  Private _paddingHorizontal As Integer = 380
  Private _paddingVertical As Integer = 380

  Private _shapes As New FoxShapeCollection()
  Private _currentShape As FoxShape = Nothing
  Private _drawing As Boolean = False
  Private _shapeType As Enums.ShapeType = Enums.ShapeType.Pen
  Private _shapeConfig As ConfigShapeForm = Nothing

  Private _Progress As Progress = Nothing
  Private _CancelSend As Boolean = False

  Private _CursorPen As Cursor = Nothing
  Private _CursorMarker As Cursor = Nothing

  Private _Saved As Boolean = False 'sign of the saved image / признак сохраненности изображения

  Public Sub New(bmp As Bitmap)
    'This call is required by the Windows Form Designer
    'Этот вызов является обязательным для конструктора.
    InitializeComponent()

    _bmp = bmp
  End Sub

  Private Sub Result_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    If _bmp Is Nothing Then
      If MessageBox.Show(My.Resources.Strings.HaveNotScreen, My.Resources.Strings.ErrorTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Retry Then
        btnNew_Click(btnNew, e)
      Else
        Me.Close()
      End If
      Return
    End If

    'set custom cursors / курсоры
    'note: only black&white suppored without WinAPI
    _CursorPen = New Cursor(New MemoryStream(My.Resources.cur_pen16px)) 'note: только чб, цветные не поддерживаются и это не моя вина :)
    _CursorMarker = New Cursor(New MemoryStream(My.Resources.cur_marker16px))

    'set PictureBox position and size
    'устанавливаем размер и расположение PictureBox
    PictureBox1.Left = 0
    PictureBox1.Top = 0
    PictureBox1.Width = _bmp.Width + _paddingHorizontal
    PictureBox1.Height = _bmp.Height + _paddingVertical
    'set form size
    'подгоняем размер формы, под размер изображения, если можно
    If PictureBox1.Width - (_paddingHorizontal / 2) < Screen.PrimaryScreen.WorkingArea.Width Then
      Me.Width = PictureBox1.Width - (_paddingHorizontal / 2)
    Else
      Me.Left = 0
      Me.Width = Screen.PrimaryScreen.WorkingArea.Width
    End If
    If PictureBox1.Height - (_paddingVertical / 2) < Screen.PrimaryScreen.WorkingArea.Height Then
      Me.Height = PictureBox1.Height - (_paddingVertical / 2)
    Else
      Me.Top = 0
      Me.Height = Screen.PrimaryScreen.WorkingArea.Height
    End If

    'set maximum form size / максимальный размер формы
    Me.MaximumSize = New Size(PictureBox1.Width + (Me.Width - Me.ClientSize.Width), (PictureBox1.Height + MenuStrip1.Height + ToolStrip1.Height + (Me.Height - Me.ClientSize.Height)))

    'set scrolls / позиция линий прокрутки
    If PictureBox1.Width - (_paddingHorizontal / 2) < Screen.PrimaryScreen.WorkingArea.Width Then
      'by center / линия прокрутки по центру
      Panel1.HorizontalScroll.Value = (PictureBox1.Width - Panel1.Width) / 2
    Else
      Panel1.HorizontalScroll.Value = _paddingHorizontal / 4
    End If
    If PictureBox1.Height - (_paddingVertical / 2) < Screen.PrimaryScreen.WorkingArea.Height Then
      'by center / линия прокрутки по центру
      Panel1.VerticalScroll.Value = (PictureBox1.Height - Panel1.Height) / 2
    Else
      Panel1.VerticalScroll.Value = _paddingVertical / 4
    End If

    'call the Pen Shape / активируем перо
    btnShapeType_Click(btnPen, Nothing)

    If My.Settings.SendTo = 1 Then
      btnSend.Image = My.Resources.shareft24px
      btnSendToFoxTools.Checked = True
    ElseIf My.Settings.SendTo = 2 Then
      btnSend.Image = My.Resources.sharezz24px
      btnSendToZzWeb.Checked = True
    End If

    If My.Settings.AlwaysCopy Then
      'copy image to clipboard
      'если разрешено автоматическое копирование снимка в буфер
      'копируем
      btnCopy_Click(btnCopy, e)
    End If
  End Sub

  Private Sub Result_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If Not _Saved AndAlso My.Settings.PromptToSave Then
      'show alert window
      'показываем окно с предупрежедением
      Dim p As New PromptToSave()
      p.Owner = Me
      Dim pr As DialogResult = p.ShowDialog()
      If pr = Windows.Forms.DialogResult.Yes Then
        'show save dialog
        'показываем окно сохранения
        btnSave_Click(btnSave, e)
        If Not _Saved Then
          'save dialog was not used / юзер не захотел воспользоваться окном сохранения
          'cancel the cancel :) / отменяем выход
          e.Cancel = True
          Return
        End If
        'а если изображение было сохранено, то продолжаем выход из программы
      ElseIf pr = Windows.Forms.DialogResult.Cancel Then
        ''cancel the cancel / отменяем выход
        e.Cancel = True
        Return
      End If
    End If

    Try
      'remove temporary files / удаляем временные файлы
      If String.IsNullOrEmpty(My.Settings.TempFolderName) Then
        My.Settings.TempFolderName = "FoxTools.Shooter.tmp"
        My.Settings.Save()
      End If

      If Directory.Exists(Path.Combine(Path.GetTempPath(), My.Settings.TempFolderName)) Then
        Directory.Delete(Path.Combine(Path.GetTempPath(), My.Settings.TempFolderName), True)
      End If
    Catch ex As Exception
    End Try

    'save settings / сохраняем настройки
    My.Settings.Save()
  End Sub

  Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Left Then

      If _shapeType = Enums.ShapeType.Eraser Then
        'kill all configuration forms / для ластика рисовать ничего не нужно
        CloseConfig()

        'remove shapes by mouse position / удаляем фигуры под курсором
        _shapes.RemoveByPoint(e.Location)
      Else
        'для остальных типов фигур
        _currentShape = _shapes.AddShape(New FoxShape() With {.ShapeType = _shapeType})

        Select Case _shapeType
          Case Enums.ShapeType.Pen
            If _shapeConfig IsNot Nothing Then
              With CType(_shapeConfig, ConfigPen)
                _currentShape.Color = .Color
                _currentShape.Depth = .Depth
              End With
            Else
              'и такое бывает, делаем так, чтобы все было как нужно, а не как-то так, вот так вот :)
              _currentShape.Color = My.Settings.PenColor
              _currentShape.Depth = My.Settings.PenWidth
            End If

          Case Enums.ShapeType.Marker
            _currentShape.Depth = 15 'default marker depth / толщина маркера

          Case Enums.ShapeType.Pixelate
            _currentShape.X = e.Location.X
            _currentShape.Y = e.Location.Y
            _currentShape.Depth = My.Settings.PixelateSize '4

            'for Pixelate Shape, kill configuration form
            'закрываем окно конфигурации фигуры,
            'т.к. конфигурация данного типа фигуры
            'будет делаться после завершения рисования
            CloseConfig()
        End Select

      End If

      _drawing = True
    End If
  End Sub

  Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
    If _drawing Then
      If _currentShape Is Nothing Then _drawing = False : Return 'всяко бывает

      If _shapeType = Enums.ShapeType.Pen OrElse _shapeType = Enums.ShapeType.Marker Then
        _currentShape.Points.Add(New Point(e.X, e.Y))

      ElseIf _shapeType = Enums.ShapeType.Pixelate Then
        _currentShape.Width = e.Location.X - _currentShape.X
        _currentShape.Height = e.Location.Y - _currentShape.Y

      ElseIf _shapeType = Enums.ShapeType.Eraser Then
        'remove shapes by mouse position / удаляем фигуры под курсором
        _shapes.RemoveByPoint(e.Location)

      End If

      Me.UpdateResult()
    End If
  End Sub

  Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
    If _currentShape Is Nothing Then _drawing = False : Return 'shape not set, exit / всяко бывает

    If e.Button = Windows.Forms.MouseButtons.Left Then

      Dim needConfig As Boolean = False
      Select Case _shapeType
        Case Enums.ShapeType.Pixelate
          'check shape size / проверяем, чтобы размер фигуры не был равен нулю
          If _currentShape.AbsWidth = 0 OrElse _currentShape.AbsHeight = 0 Then
            'shape size is null, remove the Shape from Collection / размер выбранной области равен нулю, делаем харакири
            _shapes.Remove(_currentShape)
          Else
            'has size, use it / есть размер, можно использовать
            _shapeConfig = New ConfigPixelate(_currentShape)
            needConfig = True
          End If

      End Select

      'show configuration form (now it's only for Pixelate Shape type)
      'показываем окно изменения параметров фигуры, если нужно
      If needConfig AndAlso _shapeConfig IsNot Nothing Then
        _shapeConfig.Owner = Me
        _shapeConfig.Show()
        _shapeConfig.Left = Me.Left + (Me.Width - Me.ClientSize.Width) + 10
        _shapeConfig.Top = Me.Top + MenuStrip1.Height + ToolStrip1.Height + (Me.Height - Me.ClientSize.Height) + 10
      End If

      'set is completed to the shape
      'ставим признак завершенности создания фигруры
      _currentShape.IsCompleted = True
      _drawing = False

      Me.UpdateResult()
    End If

  End Sub

  Private Sub PictureBox1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
    Dim g As Graphics = e.Graphics
    'g.CompositingQuality = CompositingQuality.HighQuality
    g.SmoothingMode = SmoothingMode.AntiAlias

    'рисуем
    DrawShapes(g)
  End Sub

  ''' <summary>
  ''' Draws the Shapes / Рисует фигуры
  ''' </summary>
  Private Sub DrawShapes(g As Graphics)
    g.DrawImage(_bmp, (PictureBox1.Width - _bmp.Width) \ 2, (PictureBox1.Height - _bmp.Height) \ 2, _bmp.Width, _bmp.Height)

    For Each itm As FoxShape In _shapes
      If itm.ShapeType = Enums.ShapeType.Pen Then 'перо
        If itm.Points.Count > 1 Then
          g.DrawCurve(itm.GetPen(), itm.Points.ToArray())
        End If

      ElseIf itm.ShapeType = Enums.ShapeType.Marker Then 'маркер

        If itm.Points.Count > 1 Then
          'create marker pen / создаем кисть
          'TODO: Need color mix.
          'TODO: нужно не накладывать цвет, а смешивать желтый с фрагментом снимка экрана.
          'Скорей всего без ColorMatrix не обойтись.
          'Но как это лучше всего сделать (в плане производительности), пока неясно.
          Dim pn As New Pen(Color.FromArgb(100, Color.Yellow), itm.Depth) 'Brushes.Yellow
          pn.StartCap = LineCap.Square
          pn.EndCap = LineCap.Square
          pn.DashStyle = DashStyle.Solid
          pn.LineJoin = LineJoin.Bevel

          g.DrawCurve(pn, itm.Points.ToArray())
        End If

      ElseIf itm.ShapeType = Enums.ShapeType.Rectangle Then 'прямоугольник
        'TODO: Drawing rectangle for next time
        'TODO: просто лень было делать и проверять :)
        g.DrawRectangle(itm.GetPen(), itm.X, itm.Y, itm.Width, itm.Height)

      ElseIf itm.ShapeType = Enums.ShapeType.Pixelate Then 'деформация

        'искажение области
        If itm.IsCompleted Then 'shape is completed / если прорисовка завершена
          If itm.ImageCache Is Nothing Then 'image cache is empty / если кеш пуст
            Pixelate(g, itm) 'draws pixelate image and set to cache / создаем искаженный фрагмент в кеше (так быстрее будет работать, чем постоянно рисовать множество "пикселей")
          End If
          'draw pixelate image / рисуем картинку
          g.DrawImage(itm.ImageCache, itm.AbsX, itm.AbsY, itm.AbsWidth, itm.AbsHeight)
          'draw border / рисуем рамку
          'g.DrawRectangle(Pens.Red, itm.AbsX, itm.AbsY, itm.AbsWidth, itm.AbsHeight)
        Else
          'draw border / рисуем рамку
          g.DrawRectangle(Pens.Red, itm.AbsX, itm.AbsY, itm.AbsWidth, itm.AbsHeight)
        End If

      End If
    Next
  End Sub

  ''' <summary>
  ''' Pixelate image fragment / Метод пикселизирует фрагмент изображения
  ''' </summary>
  Private Sub Pixelate(g As Graphics, itm As FoxShape)
    Try
      Dim tmp As New Bitmap(itm.AbsWidth, itm.AbsHeight)
      Dim g2 As Graphics = Graphics.FromImage(tmp)
      g2.FillRectangle(Brushes.White, 0, 0, itm.AbsWidth, itm.AbsHeight)

      'пикселизируем, или пикселипируем, или пикселепипуруем, в общем проводим процедуру пикселизации
      Dim pixWidth As Integer = itm.Depth
      Dim pixHeight As Integer = itm.Depth

      If pixWidth > itm.AbsWidth Then
        pixWidth = itm.AbsWidth
      End If
      If pixHeight > itm.AbsHeight Then
        pixHeight = itm.AbsHeight
      End If

      For x As Integer = itm.AbsX To itm.AbsX + itm.AbsWidth Step pixWidth

        'If x - itm.AbsX > (itm.AbsX + itm.AbsWidth) - x Then
        'pixWidth = (itm.AbsX + itm.AbsWidth) - x
        'End If

        For y As Integer = itm.AbsY To itm.AbsY + itm.AbsHeight Step pixHeight

          'If y - itm.AbsY > (itm.AbsY + itm.AbsHeight) - y Then
          'pixHeight = (itm.AbsY + itm.AbsHeight) - y
          'End If

          'get red, green and blue colors
          'считаем количество красного, зеленого и, не побоюсь этого слова, голубого цветов
          Dim ir As Integer? = Nothing, ig As Integer? = Nothing, ib As Integer? = Nothing 'нужно обнулить, иначе в будущем могут остаться следы от прошлого :)
          For x2 As Integer = x To x + pixWidth - 1
            For y2 As Integer = y To y + pixHeight - 1

              Dim x3 As Integer = x2 - ((PictureBox1.Width - _bmp.Width) / 2)
              If x3 < 0 OrElse x3 >= _bmp.Width Then Exit For 'x3 = 0
              'If x3 >= _bmp.Width Then x3 = _bmp.Width - pixWidth

              Dim y3 As Integer = y2 - ((PictureBox1.Height - _bmp.Height) / 2)
              If y3 < 0 OrElse y3 >= _bmp.Height Then Exit For 'y3 = 0
              'If y3 >= _bmp.Height Then y3 = _bmp.Height - pixHeight

              Dim clr As Color = _bmp.GetPixel(x3, y3)

              If Not ir.HasValue Then
                ir = 0 : ig = 0 : ib = 0
              End If

              ir += clr.R
              ig += clr.G
              ib += clr.B

            Next
          Next
          '//--

          'has color / если есть цвет
          If ir.HasValue Then
            'calculate average color of the square / определяем средний цвет квадрата
            ir \= pixWidth * pixHeight
            ig \= pixWidth * pixHeight
            ib \= pixWidth * pixHeight
            If ir > 255 Then ir = 255
            If ig > 255 Then ig = 255
            If ib > 255 Then ib = 255

            'draw square (big pixel)
            'рисуем квадрат, ну типа большой пиксель
            'при условии, что x и y находятся в области изображения
            'If x - ((PictureBox1.Width - _bmp.Width) / 2) >= 0 AndAlso y - ((PictureBox1.Height - _bmp.Height) / 2) >= 0 Then ' AndAlso x - ((PictureBox1.Width - _bmp.Width) / 2) <= itm.AbsWidth AndAlso y - ((PictureBox1.Height - _bmp.Height) / 2) <= itm.AbsHeight
            'g.FillRectangle(New SolidBrush(Color.FromArgb(255, ir, ig, ib)), x, y, pixWidth, pixHeight)
            'End If

            'If x - itm.AbsX >= 0 AndAlso y - itm.AbsY >= 0 Then
            g2.FillRectangle(New SolidBrush(Color.FromArgb(255, ir, ig, ib)), x - itm.AbsX, y - itm.AbsY, pixWidth, pixHeight)
            'End If
          End If

        Next
      Next

      itm.ImageCache = tmp
    Catch ex As Exception
    End Try
  End Sub

  ''' <summary>
  ''' Returns complete image / Возвращает конечное изображение
  ''' </summary>
  Private Function GetImage() As Image
    'draws screen capture with shapes / рисуем снимок с фигурами
    Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
    Dim g As Graphics = Graphics.FromImage(bmp)
    g.SmoothingMode = SmoothingMode.AntiAlias
    DrawShapes(g)

    'координаты вывода снимка в PictureBox
    Dim scrX As Integer = (PictureBox1.Width - _bmp.Width) \ 2
    Dim scrY As Integer = (PictureBox1.Height - _bmp.Height) \ 2

    'get bound of shapes
    'определяем рабочую область
    'и создаем объект для конечного изображения
    Dim b As Rectangle = _shapes.GetBound()
    Dim bmp2 As Bitmap = Nothing
    Dim rec As Rectangle = Rectangle.Empty
    If b.IsEmpty Then
      bmp2 = New Bitmap(_bmp.Width, _bmp.Height)
    Else
      Dim x, y, w, h As Integer
      If b.X < scrX Then
        x = b.X
        w = scrX - b.X
      Else
        x = scrX
        w = 0
      End If
      If b.Y < scrY Then
        y = b.Y
        h = scrY - b.Y
      Else
        y = scrY
        h = 0
      End If
      If b.Width > _bmp.Width Then
        w = b.Width
      Else
        w += _bmp.Width
      End If
      If b.Height > _bmp.Height Then
        h = b.Height
      Else
        h += _bmp.Height
      End If
      bmp2 = New Bitmap(w, h)
      rec = New Rectangle(x, y, w, h)
    End If

    Dim g2 As Graphics = Graphics.FromImage(bmp2)

    'background / фон
    g2.FillRectangle(Brushes.White, 0, 0, bmp2.Width, bmp2.Height)

    If b.IsEmpty Then
      'without shapes / без фигур
      g2.DrawImage(bmp, New Rectangle(0, 0, bmp2.Width, bmp2.Height), New Rectangle((bmp.Width - bmp2.Width) \ 2, (bmp.Height - bmp2.Height) \ 2, bmp2.Width, bmp2.Height), GraphicsUnit.Pixel)
      'g2.DrawImage(_bmp, (bmp.Width - bmp2.Width) \ 2, (bmp.Height - bmp2.Height) \ 2, bmp2.Width, bmp2.Height)
    Else
      'with shapes
      g2.DrawImage(bmp, New Rectangle(0, 0, bmp2.Width, bmp2.Height), rec, GraphicsUnit.Pixel)
    End If

    Return CType(bmp2, Image)
  End Function

  ''' <summary>
  ''' Returns complete image as byte array / Возвращает изображение в виде массива байт
  ''' </summary>
  Private Function GetImageBuffer() As Byte()
    Using m As New MemoryStream()
      GetImage().Save(m, Imaging.ImageFormat.Png)
      Return m.ToArray()
    End Using
  End Function

  Private Sub Result_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
    'Для этого используется MaximumSize
    'If Me.WindowState = FormWindowState.Maximized Then
    'Dim needNormalize As Boolean = False
    'If Me.Width > PictureBox1.Width + (Me.Width - Me.ClientSize.Width) Then
    'needNormalize = True
    'Me.Width = PictureBox1.Width + (Me.Width - Me.ClientSize.Width)
    'End If
    'If Me.Height > (PictureBox1.Height + MenuStrip1.Height + ToolStrip1.Height + (Me.Height - Me.ClientSize.Height)) Then
    'needNormalize = True
    'Me.Height = PictureBox1.Height + MenuStrip1.Height + ToolStrip1.Height + (Me.Height - Me.ClientSize.Height)
    'End If
    'If needNormalize Then
    ' 'Me.Left = 0 : Me.Top = 0
    'Me.WindowState = FormWindowState.Normal
    'End If
    'End If
    Me.UpdateResult()
  End Sub

  Private Sub Result_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
    'kill configuration window
    'прячим окошко конфигурации фигуры, если пользователь нажал на клавишу Escape
    If e.KeyCode = Keys.Escape AndAlso _shapeConfig IsNot Nothing AndAlso _shapeConfig.Visible Then
      _shapeConfig.Close()
      _shapeConfig = Nothing
    End If
  End Sub

  Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click, mnuNew.Click
    If _shapeConfig IsNot Nothing Then
      _shapeConfig.Close()
      _shapeConfig.Left = -Screen.PrimaryScreen.Bounds.Width * 2
    End If
    Me.Left = -Screen.PrimaryScreen.Bounds.Width * 2 'hide form / нужно спрятаться, иначе форма может попасть на скрин (дело в анимации Windows Vista/7, пока ничего нормальней не придумал для решения этой проблемы)
    Me.Visible = False
    Call New Main().Show() 'show main form / показываем форму управления режимом создания снимка
    _Saved = True 'приказываем тараканам думать, что снимок был сохранен
    Me.Close() 'убиваемся ап стену
  End Sub

  Private Sub btnShapeType_Click(sender As System.Object, e As System.EventArgs) Handles btnPen.Click, btnMarker.Click, btnDegradation.Click, btnClear.Click
    Dim btn As FoxToolStripButton = CType(sender, FoxToolStripButton) 'sender as FoxToolStripButton
    For Each itm As ToolStripItem In btn.Owner.Items
      If itm.GetType() Is GetType(FoxToolStripButton) AndAlso CType(itm, FoxToolStripButton).Checked Then
        CType(itm, FoxToolStripButton).Checked = False
      End If
    Next
    'kill configuration window
    'если открыта форма конфигурации, закрываем
    CloseConfig()
    'selected button / выбираем кнопку
    btn.Checked = Not btn.Checked
    'set shape type / тип фигуры
    _shapeType = btn.ShapeType

    'set window configuration
    'определям первичные параметры окна конфигурации фигуры
    Select Case btn.ShapeType
      Case Enums.ShapeType.Pen 'перо
        _shapeConfig = New ConfigPen() 'создаем окно конфигурации пера
        'set properties / передаем настройки пера в окно конфигурации
        CType(_shapeConfig, ConfigPen).Color = My.Settings.PenColor
        CType(_shapeConfig, ConfigPen).Depth = My.Settings.PenWidth

        PictureBox1.Cursor = _CursorPen 'New Cursor(My.Resources.cur_pen.Handle)'с иконками проще, но у них нет "носа" (hot spot), что при рисовании критично, в плане позиционирования

      Case Enums.ShapeType.Marker
        PictureBox1.Cursor = _CursorMarker 'New Cursor(My.Resources.cur_marker.Handle)

      Case Enums.ShapeType.Pixelate 'пикселизация
        ' _shapeConfig = New ConfigPixelate()
        PictureBox1.Cursor = Cursors.Cross

      Case Enums.ShapeType.Eraser
        PictureBox1.Cursor = New Cursor(My.Resources.cur_eraser.Handle)

    End Select

    'show configuration window / если есть окно кофигурации, показываем его
    If _shapeConfig IsNot Nothing Then
      _shapeConfig.Owner = Me
      _shapeConfig.Show()
      _shapeConfig.Left = Me.Left + (Me.Width - Me.ClientSize.Width) + 10
      _shapeConfig.Top = Me.Top + MenuStrip1.Height + ToolStrip1.Height + (Me.Height - Me.ClientSize.Height) + 10
    End If

    'set focus / фокус на себя
    Me.Focus()
  End Sub

  ''' <summary>
  ''' Kill configuration window / Метод закрывает окно конфигурации фигуры
  ''' </summary>
  ''' <remarks></remarks>
  Private Sub CloseConfig()
    If _shapeConfig IsNot Nothing Then
      _shapeConfig.Close()
      _shapeConfig = Nothing
    End If
  End Sub

  ''' <summary>
  ''' Redraw screen capture and shapes / Метод принудительно вызывает прорисовку снимка экрана
  ''' </summary>
  Public Sub UpdateResult()
    PictureBox1.Refresh()
  End Sub

  Private Sub mnuHomePage_Click(sender As System.Object, e As System.EventArgs) Handles mnuHomePage.Click
    Process.Start("http://foxtools.ru/Shooter") 'open url / открываем ссылку в браузере
  End Sub

  Private Sub mnuSourceCode_Click(sender As System.Object, e As System.EventArgs) Handles mnuSourceCode.Click
    Process.Start("http://kbyte.ru/ru/Groups/Show.aspx?id=24") 'open url / открываем ссылку в браузере, если есть, а если нет, то не открываем :)
  End Sub

  Private Sub mnuAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuAbout.Click
    Call New AboutBox() With {.Owner = Me}.ShowDialog() 'show about form / показываем окно "О программе"
  End Sub

  Private Sub mnuSettings_Click(sender As System.Object, e As System.EventArgs) Handles mnuSettings.Click
    Call New Settings() With {.Owner = Me, .TopMost = Me.Owner IsNot Nothing}.ShowDialog() 'show settings form / показываем окно настроек программы
  End Sub

  Private Sub mnuExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuExit.Click
    Me.Close()
  End Sub

  Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click, mnuSaveAs.Click
    SaveFileDialog1.FileName = My.Resources.Strings.DefaultFileName
    If Not SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then Return 'если нажата кнопка отличная от OK, выходим

    Dim FI As New FileInfo(SaveFileDialog1.FileName) 'создаем FileInfo на основе выбранного для сохранения имени файла
    Dim img As Image = GetImage() 'get image / получаем конечное (не путать с конченным) изображение

    Select Case FI.Extension.ToLower() 'по расширению файла определям формат сохранения изображения
      Case ".gif"
        img.Save(FI.FullName, ImageFormat.Gif)

      Case ".jpg", ".jpeg"
        Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
        Dim myEncoderParameter As System.Drawing.Imaging.EncoderParameter
        Dim myEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)
        Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
        myImageCodecInfo = GetEncoderInfo(System.Drawing.Imaging.ImageFormat.Jpeg)
        myEncoderParameter = New System.Drawing.Imaging.EncoderParameter(myEncoder, CType(75L, Integer)) '75 - качество изображение, от 0 до 100
        myEncoderParameters.Param(0) = myEncoderParameter
        img.Save(FI.FullName, myImageCodecInfo, myEncoderParameters)

      Case Else
        img.Save(FI.FullName, ImageFormat.Png)

    End Select

    _Saved = True 'ставим отметку, что изображение было сохранено, чтобы не предлагать пользователю сохраниться при выходе из программы
  End Sub

  Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click, mnuCopy.Click
    Clipboard.SetImage(GetImage()) 'копируем изображение в буфер
  End Sub

  ''' <summary>
  ''' Returns JPEG codec / Создает кодек для сохранения JPEG
  ''' </summary>
  Private Function GetEncoderInfo(ByVal format As System.Drawing.Imaging.ImageFormat) As System.Drawing.Imaging.ImageCodecInfo
    Dim j As Integer = 0
    Dim encoders() As System.Drawing.Imaging.ImageCodecInfo
    encoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
    While j < encoders.Length
      If encoders(j).FormatID = format.Guid Then
        Return encoders(j)
      End If
      j += 1
    End While
    Return Nothing
  End Function

  Private Sub mnuPen_Click(sender As System.Object, e As System.EventArgs) Handles mnuPen.Click
    btnShapeType_Click(btnPen, e)
  End Sub

  Private Sub mnuMarker_Click(sender As System.Object, e As System.EventArgs) Handles mnuMarker.Click
    btnShapeType_Click(btnMarker, e)
  End Sub

  Private Sub mnuPixelate_Click(sender As System.Object, e As System.EventArgs) Handles mnuPixelate.Click
    btnShapeType_Click(btnDegradation, e)
  End Sub

  Private Sub mnuEraser_Click(sender As System.Object, e As System.EventArgs) Handles mnuEraser.Click
    btnShapeType_Click(btnClear, e)
  End Sub

  'Private Sub PictureBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
  'excluded / отключено, т.к. не удобно это как-то все
  'Panel1.Focus() 'фокус панели, чтобы мог работать скролинг колесиком мышки
  'End Sub

  Private Sub btnSend_ButtonClick(sender As System.Object, e As System.EventArgs) Handles btnSend.ButtonClick
    'send image to server
    'если ранее юзер уже отправлял картинку куда-то, отправляем сразу туда
    If My.Settings.SendTo = 1 Then 'в FoxTools.ru
      btnSendToFoxTools_Click(btnSendToFoxTools, e)
    ElseIf My.Settings.SendTo = 2 Then 'в ZzWeb.ru
      btnSendToZzWeb_Click(btnSendToZzWeb, e)
    Else 'or show send list / а если не отправлял, показываем, куда можно отправить
      btnSend.ShowDropDown()
    End If
  End Sub

  Private Sub btnSendToFoxTools_Click(sender As System.Object, e As System.EventArgs) Handles btnSendToFoxTools.Click, mnuSendToFoxTools.Click
    'create progress form
    'создаем окно прогресса, нет, не научно-технического,
    'а окошко, которое поможет пользователю скоротать время
    'в процессе отправки данных на сервер
    _CancelSend = False
    _Progress = New Progress()
    _Progress.Owner = Me

    'create thread
    'создаем поток, чтобы не было тупников при получении массива байт конечного изображения
    Dim t As New Thread(AddressOf SendToFoxTools_Start)
    t.IsBackground = True
    t.Start() 'start thread

    'show progress form
    'показываем окно прогресса
    If _Progress.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
      _CancelSend = True
      _Progress = Nothing
    End If

    My.Settings.SendTo = 1 'set selected method of send as default / делаем этот метод отправки, методом по умолчанию
    btnSend.Image = My.Resources.shareft24px 'change button image / меняем на кнопке в ToolStrip картинку, чтобы было понятно, куда в следующей раз будет делаться отправка по умолчанию

    'ставим чекбокс выбранному элементу меню
    UncheckedSendMenu()
    btnSendToFoxTools.Checked = True
  End Sub

  ''' <summary>
  ''' Start the process of sending the image to FoxTools.ru /
  ''' Метод запускает процесс отправки снимка в FoxTools.ru.
  ''' Этот метод создан для запуска из отдельного потока.
  ''' </summary>
  Private Sub SendToFoxTools_Start()
    'create FoxTools.Lib.Api and set application ID and access key
    'создаем экземпляр класса для доступа к хитрому API
    Dim myApi As New FoxTools.Lib.Api(My.Settings.FoxId, My.Settings.FoxKey)

    'set proxy server properties
    'передаем в API параметры прокси-сервера, если есть
    If My.Settings.UserProxy Then
      myApi.UseProxy = My.Settings.UserProxy
      myApi.ProxyAddress = My.Settings.ProxyAddress
      myApi.ProxyPort = My.Settings.ProxyPort
      If My.Settings.ProxyAuth Then
        myApi.ProxyCredential = New System.Net.NetworkCredential(My.Settings.ProxyLogin, My.Settings.ProxyPwd)
      End If
    End If

    'start process / запускаем отправку снимка асинхронным методом
    myApi.ScreenAsync(GetImageBuffer(), [Lib].Enums.ImageFormat.Png, 0, AddressOf SendToFoxTools_Result)
    'учитывая, что мы уже находимся в отдельном потке, использовать асинхронный метод API смысла нет,
    'но менять код мне лень, так что пускай будет так, как есть :)
  End Sub

  ''' <summary>
  ''' Result of sending the image to FoxTools.ru /
  ''' В этот метод передается результат отправки снимка в FoxTools.ru асинхронным методом.
  ''' Не используйте этот метод отдельно.
  ''' </summary>
  Private Sub SendToFoxTools_Result(sender As Object, result As String, [error] As FoxTools.Lib.ErrorEventArgs)
    If _CancelSend Then Return 'user is canceled sending / если пользователь отменил отправку, то нам тут делать нечего, уходим по грибы да по ягоды
    KillProgress() 'kill progress form / убиваем прогресс

    If [error] IsNot Nothing Then
      'server error
      'случилась ошибка, какая жаль
      '"Не удалось отправить изображение на хитрый сервер. Причина: {0}"
      If MessageBox.Show(String.Format(My.Resources.Strings.FoxToolsError, [error].Message), My.Resources.Strings.ErrorTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Retry Then
        RetrySendToFoxTools()
      End If
    Else
      'successfully / все пучком
      ShowResultOfSending(result)
    End If
  End Sub

  Private Sub btnSendToZzWeb_Click(sender As System.Object, e As System.EventArgs) Handles btnSendToZzWeb.Click, mnuSendToZzWeb.Click
    'show zz-form / показываем форму с параметрами отправки в ZzWeb
    Dim zz As New ZzWebStart()
    zz.Owner = Me 'говорим zz-форме, кто тут хозяин
    zz.ShowDialog()
    My.Settings.SendTo = 2 'set selected method of send as default / делаем этот метод отправки, методом по умолчанию
    btnSend.Image = My.Resources.sharezz24px 'change button image / меняем на кнопке в ToolStrip картинку, чтобы было понятно, куда в следующей раз будет делаться отправка по умолчанию
    'ставим чекбокс выбранному элементу меню
    UncheckedSendMenu()
    btnSendToZzWeb.Checked = True
  End Sub

  ''' <summary>
  ''' Send image to ZzWeb.ru / Отправляет данные в zzweb.ru
  ''' </summary>
  ''' <param name="description">ZZ-Page description / Описание</param>
  ''' <param name="disableComments">Disable zz-page comments / Запретить комментарии</param>
  ''' <param name="disableRss">Disable RSS / Запретить rss-канал</param>
  ''' <param name="lepota">Stylish look / Стильный вид</param>
  ''' <param name="auth">Use auth / Отправить под учетной записью</param>
  ''' <param name="email">zz-email / Майл</param>
  ''' <param name="password">zz-password / Пароль</param>
  ''' <remarks></remarks>
  Public Sub SendToZzWeb(description As String, disableComments As Boolean, disableRss As Boolean, lepota As Boolean, auth As Boolean, email As String, password As String)
    'create progress form
    'создаем окно прогресса, нет, не научно-технического,
    'а окошко, которое поможет пользователю скоротать время
    'в процессе отправки данных на сервер
    _CancelSend = False
    _Progress = New Progress()
    _Progress.Owner = Me

    'set parameters
    'готовим параметры для передачи в поток
    '(можно сделать отдельный класс, но мне лень)
    Dim parameters As New Dictionary(Of String, Object)
    parameters.Add("description", description)
    parameters.Add("disableCommens", disableComments)
    parameters.Add("disableRss", disableRss)
    parameters.Add("lepota", lepota)
    parameters.Add("auth", auth)
    parameters.Add("email", email)
    parameters.Add("password", password)

    'create thread
    'создаем поток, чтобы не было тупников при получении массива байт конечного изображения
    Dim t As New Thread(AddressOf SendToZzWeb_Start)
    t.IsBackground = True
    t.Start(parameters) 'start thread with parameters

    'show progress form
    'показываем окно прогресса
    If _Progress.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
      _CancelSend = True
      _Progress = Nothing
    End If
  End Sub

  ''' <summary>
  ''' Start the process of sending the image to ZzWeb.ru /
  ''' Метод начинает процесс отправки в ZzWeb.ru.
  ''' Этот метод используется для потоков.
  ''' </summary>
  Private Sub SendToZzWeb_Start(arg As Object)
    'get parameters / получаем параметры отправки в zzweb
    Dim parameters As Dictionary(Of String, Object) = CType(arg, Dictionary(Of String, Object))

    'создаем экземпляр класса для доступа к хитрому API
    Dim myApi As New FoxTools.Lib.Api(My.Settings.FoxId, My.Settings.FoxKey)

    'set proxy server properties
    'если нужно, прикручиваем прокси-сервер
    If My.Settings.UserProxy Then
      myApi.UseProxy = My.Settings.UserProxy
      myApi.ProxyAddress = My.Settings.ProxyAddress
      myApi.ProxyPort = My.Settings.ProxyPort
      If My.Settings.ProxyAuth Then
        myApi.ProxyCredential = New System.Net.NetworkCredential(My.Settings.ProxyLogin, My.Settings.ProxyPwd)
      End If
    End If

    'create file list for API method /
    'для метода ZzWeb, хитрый API требуется наличие реального файла
    'да, мне лень было делать иначе, там свои замуты, посему будет так, пока
    Dim img As New List(Of System.IO.FileInfo)

    'checking temporary folder /
    'проверяем, чтобы было имя временной папки
    If String.IsNullOrEmpty(My.Settings.TempFolderName) Then
      My.Settings.TempFolderName = "FoxTools.Shooter.tmp" 'set default temporary folder name /если нет, ставим значение по умолчанию
      My.Settings.Save()
    End If

    Dim fp As String = Path.Combine(Path.GetTempPath(), My.Settings.TempFolderName) 'каталог сохранения временного файла
    If Not Directory.Exists(fp) Then Directory.CreateDirectory(fp) 'created temporary folder / если каталога нет, создаем
    'get temporary file name / подбираем имя для временного файла
    Dim fn As String = My.Resources.Strings.ScreenFileName 'FileName.png / Хитрый снимок.png
    Dim rnd As New Random(Now.Millisecond)
    While File.Exists(Path.Combine(fp, fn))
      fn = String.Format(My.Resources.Strings.ScreenFileName2, rnd.Next(0, Int32.MaxValue)) '"Хитрый снимок {0}.png"
    End While

    'temporary file / временный файл
    Dim f As New FileInfo(Path.Combine(fp, fn))

    'save image to temporary file / сохраняем снимок во временный файл
    GetImage().Save(f.FullName, Imaging.ImageFormat.Png)

    'add file to list / добавляем файл в коллекцию для отправки на сервер ZzWeb
    img.Add(f)

    'set zzweb credentials / учетные данные ZzWeb, если есть
    Dim email As String = String.Empty, password As String = String.Empty
    If CType(parameters("auth"), Boolean) Then
      email = parameters("email").ToString()
      password = parameters("password").ToString()
    End If

    'send data / отправляем данные на сервер ZzWeb
    myApi.ZzWebAsync(img, String.Empty,
                     parameters("description").ToString(),
                     email, password, String.Empty,
                     CType(parameters("disableCommens"), Boolean),
                     False,
                     CType(parameters("disableRss"), Boolean),
                     CType(parameters("lepota"), Boolean),
                     AddressOf SendToZzWeb_Result)
    'как и в случае с FoxTools.ru, асинхронный метод использовать не обяхательно,
    'мы и так в отдельном потоке находимся
  End Sub

  Private Sub SendToZzWeb_Result(sender As Object, result As String, [error] As FoxTools.Lib.ErrorEventArgs)
    If _CancelSend Then Return 'user is canceled sending / пользователь отменил отправку, вот наглец, ну ладно, выходим отсюда
    KillProgress() 'kill progress form / убиваем прогресс, нет, не технический, а вообще весь :)

    If [error] IsNot Nothing Then
      'server error
      'случилась ошибка
      '"Не удалось отправить изображение на сервер ZzWeb. Причина: {0}"
      If MessageBox.Show(String.Format(My.Resources.Strings.ZzWebError, [error].Message), My.Resources.Strings.ErrorTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Retry Then
        RetrySendToZzWeb()
      End If
    Else
      'successfully / все пучком
      ShowResultOfSending(result)
    End If
  End Sub

  ''' <summary>
  ''' Start the process of sending the image to FoxTools.ru via thread / Метод отправляет из потока повторный запрос на отправку снимка на сервер FoxTools.ru
  ''' </summary>
  Private Sub RetrySendToFoxTools()
    If Me.InvokeRequired Then
      Me.Invoke(New Action(AddressOf RetrySendToFoxTools))
      Return
    End If
    btnSendToFoxTools_Click(btnSendToFoxTools, Nothing)
  End Sub

  ''' <summary>
  ''' Start the process of sending the image to ZzWeb.ru via thread / Метод отправляет из потока повторный запрос на отправку снимка на сервер ZzWeb.ru
  ''' </summary>
  Private Sub RetrySendToZzWeb()
    If Me.InvokeRequired Then
      Me.Invoke(New Action(AddressOf RetrySendToZzWeb))
      Return
    End If
    btnSendToZzWeb_Click(btnSendToZzWeb, Nothing)
  End Sub

  ''' <summary>
  ''' Show sending result / Показывает окно с результатом отправки картинки на сервер
  ''' </summary>
  Private Sub ShowResultOfSending(url As String)
    If Me.InvokeRequired Then
      Me.Invoke(New Action(Of String)(AddressOf ShowResultOfSending), url)
      Return
    End If
    Dim r As New ResultOfSending(url)
    r.Owner = Me
    r.ShowDialog()
    _Saved = True 'считаем, что снимок был сохранен
  End Sub

  ''' <summary>
  ''' Kill progress form / Закрывает прогресс, даже если запрос идет из другого потока
  ''' </summary>
  Private Sub KillProgress()
    If Me.InvokeRequired Then
      Me.Invoke(New Action(AddressOf KillProgress))
      Return
    End If
    _Progress.Close()
    _Progress = Nothing
  End Sub

  ''' <summary>
  ''' Снимает выбор у всех элементов меню "Отправить фрагмент"
  ''' </summary>
  Private Sub UncheckedSendMenu()
    For Each b As ToolStripMenuItem In btnSend.DropDownItems
      b.Checked = False
    Next
  End Sub

End Class
