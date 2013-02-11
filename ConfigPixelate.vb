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
Public Class ConfigPixelate

  Private _Shape As FoxShape = Nothing

  Public Sub New(shape As FoxShape)
    InitializeComponent()
    _Shape = shape
    TrackBar1.Value = _Shape.Depth
  End Sub

  Private Sub ConfigPixelate_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    My.Settings.PixelateSize = _Shape.Depth 'save pixelate size / запоминаем, какой размер был выбран, чтобы потом вспомнить
  End Sub

  Private Sub ConfigDegradation_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
    'call TrackBar1_Scroll event handler
    'init и load для этого не годится, ну совсем никак
    TrackBar1_Scroll(TrackBar1, Nothing)
  End Sub

  Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
    If _Shape Is Nothing Then Return
    _Shape.Depth = TrackBar1.Value
    _Shape.ImageCache = Nothing 'clear image cache / очищаем кеш
    Me.Text = String.Format(My.Resources.Strings.PixelateValue, _Shape.Depth) '"Pixelate {0}px" / "Пикселизация {0}px"
    CType(Me.Owner, Result).UpdateResult()
    'set focus to parent form
    'возвращаем фокус родителю, чтобы юзеру не пришлось делать пустой клик по форме для этого
    Me.Owner.Focus()
  End Sub

End Class
