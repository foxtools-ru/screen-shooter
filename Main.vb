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

Public Class Main

  Private Sub btnNew_Click(sender As Object, e As System.EventArgs) Handles btnNew.Click
    'New button is pushed, exit
    'если снимок уже делается, выходим
    If btnNew.Pushed Then Return

    If btnNew.ButtonPressed Then
      'search selected screen capture mode
      'смотрим, выбран режим создания снимка экрана или нет
      For Each itm As ToolStripMenuItem In btnNew.DropDownItems
        If itm.Checked Then
          'successfully, call it
          'выбран, запускаем процесс создания снимка экрана
          btnNewMode_Click(itm, e)
          Exit For
        End If
      Next
    End If

    'screen capture mode not found, show mode list
    'если режим не выбран, показываем список режимов
    If Not btnNew.Pushed Then
      btnNew.ShowDropDown()
    End If
  End Sub

  Private Sub btnNewMode_Click(sender As System.Object, e As System.EventArgs) Handles btnFullScreen.Click, btnWindow.Click, btnRectangle.Click, btnCustomForm.Click
    'uncheck all / снимаем чеки с других элементов
    For Each itm2 As ToolStripMenuItem In btnNew.DropDownItems
      itm2.Checked = False
    Next

    'cancel screen capture mode / закрываем открытые окна создания снимков
    btnCancel_Click(sender, e)

    'sender as FoxToolStripMenuItem
    'для удобства делаем явную ссылку на нажатый элемент
    Dim itm As FoxToolStripMenuItem = CType(sender, FoxToolStripMenuItem)

    'checked / чекеним нажатый элемент
    itm.Checked = True
    Call New ScreenContainer(Me, itm.Mode).Show()

    'enable Cancel button / активируем кнопку "Отмена"
    btnCancel.Enabled = True
    'push New button / выбираем кнопку "Создать"
    btnNew.Pushed = True

    'set help information to Label / мини-справка
    Label1.Text = itm.Info

    'save selected screen capture mode / запоминаем выбор, чтобы потом вспомнить
    If Not itm.Mode = Enums.ScreenMode.Full Then 'excluding the Fullscreen mode / исключая весь экран, а то у пользователя нервная система может пострадать, немножко
      My.Settings.Mode = CType(itm.Mode, Integer)
    End If

    'set focus to current form
    'возвращаем фокус текущему окну
    Me.Focus()
  End Sub

  Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
    'kill screen capture forms
    'если есть открытые формы ScreenContainer, закрываем нафиг
    If Me.Owner IsNot Nothing Then
      Dim f As Form = Me.Owner
      Me.Owner = Nothing 'отлепляем себя от открытой формы ScreenContainer
      f.Close()
    End If
    'uset TopMost mode
    'отключаем расположение себя выше остальных окон
    Me.TopMost = False
    'disable Cancel button
    'деактивируем кнопку "Отмена"
    btnCancel.Enabled = False
    'unpush New button
    'отменяем выбор кнопки "Создать"
    btnNew.Pushed = False
    'set help information
    'мини-справка
    Label1.Text = btnNew.Info
  End Sub

  Private Sub btnSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
    CancelSelect()
    Call New Settings() With {.Owner = Me, .TopMost = Me.Owner IsNot Nothing}.ShowDialog()
  End Sub

  Private Sub Main_Load(sender As Object, e As System.EventArgs) Handles Me.Load
    For Each itm As FoxToolStripMenuItem In btnNew.DropDownItems
      If My.Settings.Mode = itm.Mode Then
        btnNewMode_Click(itm, e)
        Exit For
      End If
    Next
  End Sub

  Private Sub Main_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    'draw a gradient background
    'рисуем градиентный фон хитрого цвета
    Dim g As Graphics = e.Graphics
    Dim r As Rectangle = New Rectangle(0, Label1.Top, Label1.Width, Label1.Height)
    Dim b As New LinearGradientBrush(r, Color.FromArgb(255, 255, 250, 241), Color.FromArgb(255, 255, 235, 196), LinearGradientMode.Vertical)
    g.FillRectangle(b, r)
  End Sub

  Private Sub Main_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    'close screen capture form
    'если есть открытое окно выделения экрана, закрываем и его
    If Me.Owner IsNot Nothing Then
      Dim f As Form = Me.Owner
      Me.Owner = Nothing 'отлепляем себя, иначе будут БУМ!
      f.Close()
    End If
  End Sub

  ''' <summary>
  ''' Cancel screen capture mode / Отключает режим создания снимка
  ''' </summary>
  Public Sub CancelSelect()
    btnCancel_Click(btnCancel, Nothing)
  End Sub

  Private Sub Main_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
    If e.KeyCode = Keys.Escape Then
      btnCancel_Click(btnCancel, Nothing)
    End If
  End Sub

End Class
