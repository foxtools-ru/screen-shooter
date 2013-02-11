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
Public Class Progress

  Private _CancelTimer As Integer = 10

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub Progress_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    _CancelTimer = 10
    Button1.Text = String.Format(My.Resources.Strings.CancelIn, _CancelTimer) '"Cancel (in {0} sec.)" / "Отмена (через {0} сек.)"
    Timer1.Interval = 1000
    Timer1.Enabled = True
  End Sub

  Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
    _CancelTimer -= 1
    If _CancelTimer <= 0 Then
      Button1.Text = My.Resources.Strings.Cancel '"Cancel" / "Отмена"
      Button1.Enabled = True
      Timer1.Enabled = False
    Else
      Button1.Text = String.Format(My.Resources.Strings.CancelIn, _CancelTimer) '"Cancel (in {0} sec.)" / "Отмена (через {0} сек.)"
    End If
  End Sub

End Class
