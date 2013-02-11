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
Imports System.Web

Public Class SocialButtons

  Public Property Url As String

  Private Sub btnSocial_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click
    Dim url As String = ""
    Select Case CType(CType(sender, Button).Tag, Integer)
      Case 0 'twitter
        url = String.Format("http://twitter.com/share?url={0}&counturl={0}", HttpUtility.UrlEncode(Me.Url))
      Case 1 'facebook
        url = String.Format("http://www.facebook.com/sharer.php?s=100&p[url]={0}", HttpUtility.UrlEncode(Me.Url))
      Case 2 'g+
        url = String.Format("https://plus.google.com/share?url={0}", HttpUtility.UrlEncode(Me.Url))
      Case 3 'vk
        url = String.Format("http://vk.com/share.php?url={0}", HttpUtility.UrlEncode(Me.Url))
      Case 4 'ok
        url = String.Format("http://www.odnoklassniki.ru/dk?st.cmd=addShare&st._surl={0}", HttpUtility.UrlEncode(Me.Url))
      Case 5 'mail.ru
        url = String.Format("http://connect.mail.ru/share?url={0}", HttpUtility.UrlEncode(Me.Url))
    End Select
    Process.Start(url)
  End Sub

End Class
