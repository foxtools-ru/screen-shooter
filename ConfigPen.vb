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
Public Class ConfigPen

  ''' <summary>
  ''' Pen color / Цвет пера
  ''' </summary>
  Public Property Color() As Color
    Get
      Return btnColor.BackColor
    End Get
    Set(value As Color)
      btnColor.BackColor = value
    End Set
  End Property

  Private _Depth As Integer = 3

  ''' <summary>
  ''' Pen depth / Толщина пера
  ''' </summary>
  Public Property Depth() As Integer
    Get
      Return _Depth
    End Get
    Set(value As Integer)
      _Depth = value
    End Set
  End Property

  Private Sub btnColor_Click(sender As System.Object, e As System.EventArgs) Handles btnColor.Click
    ColorDialog1.Color = btnColor.BackColor 'set current color to the ColorDialog / передаем в окно выбора цветов текущий цвет
    If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then 'open ColorDialog and wait Ok button pushing / показываем окно выбора цветов и если в конце юзер нажмет Ok
      'set selected color / назначаем выбранный цвет
      btnColor.BackColor = ColorDialog1.Color
      'set focus to parent form / возвращаем фокус родителю, чтобы юзеру не пришлось делать пустой клик по форме для этого
      Me.Owner.Focus()
    End If
  End Sub

  Private Sub ConfigPen_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'save pen properties / запоминаем выбранные параметры пера, чтобы потом вспомнить
    My.Settings.PenColor = Me.Color
    My.Settings.PenWidth = Me.Depth
  End Sub

  Private Sub ConfigPen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    For Each c As Control In Panel1.Controls 'each RadioButton's / листаем все radiobutton
      If CType(c.Tag, Integer) = Me.Depth Then 'found Depth info / если найдена нужная толщина
        CType(c, RadioButton).Checked = True 'checked / выбираем
      End If
    Next
  End Sub

  Private Sub rbWidth_CheckedChange(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
    Dim rb As RadioButton = CType(sender, RadioButton)
    If rb.Checked AndAlso rb.Tag IsNot Nothing Then
      Me.Depth = CType(rb.Tag, Integer)
      'set focus to parent form
      'возвращаем фокус родителю, чтобы юзеру не пришлось делать пустой клик по форме для этого
      Me.Owner.Focus()
    End If
  End Sub

End Class
