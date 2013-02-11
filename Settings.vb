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
Imports System.Resources
Imports System.Globalization

Public Class Settings

  Private Sub Settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    chkAllowOverlay.Checked = My.Settings.AllowOverlay
    tbFoxId.Text = My.Settings.FoxId.ToString()
    tbFoxKey.Text = My.Settings.FoxKey.ToString()
    tbOverlayAlpha.Value = My.Settings.OverlayAlpha
    btnOverlayColor.BackColor = My.Settings.OverlayColor
    btnSelectColor.BackColor = My.Settings.SelectColor
    tbProxyAddress.Text = My.Settings.ProxyAddress
    tbProxyPort.Text = My.Settings.ProxyPort.ToString()
    chkProxyAuth.Checked = My.Settings.ProxyAuth
    tbProxyLogin.Text = My.Settings.ProxyLogin
    tbProxyPassword.Text = My.Settings.ProxyPwd
    chkUseProxy.Checked = My.Settings.UserProxy
    chkZzWebAuth.Checked = My.Settings.ZzWebAuth
    tbZzWebEmail.Text = My.Settings.ZzWebEmail
    tbZzWebPassword.Text = My.Settings.ZzWebPwd
    chkPromptToSave.Checked = My.Settings.PromptToSave
    chkAlwaysCopy.Checked = My.Settings.AlwaysCopy

    'languages / языки
    cmbLanguage.Items.Clear()
    Dim rm As New ResourceManager(GetType(Settings))
    'Dim cultures As string = CultureInfo.GetCultures(CultureTypes.UserCustomCulture)
    Dim cultures() As String = {"ru-RU", "en-US"}
    For Each culture As String In cultures 'For Each culture As CultureInfo In cultures
      Try
        Dim c As New CultureInfo(culture)
        Dim rs As ResourceSet = rm.GetResourceSet(c, True, False)
        If rs IsNot Nothing Then
          'If String.IsNullOrEmpty(c.Name) Then
          'cmbLanguage.Items.Add(New CultureInfo("ru-RU"))
          'Else
          'cmbLanguage.Items.Add(c)
          'End If
          cmbLanguage.Items.Add(c)
        ElseIf rs Is Nothing AndAlso culture = "ru-RU" Then
          cmbLanguage.Items.Add(New CultureInfo("ru-RU"))
        End If
      Catch
      End Try
    Next
    cmbLanguage.DisplayMember = "NativeName" '"DisplayName"
    cmbLanguage.ValueMember = "Name"
    cmbLanguage.SelectedItem = CultureInfo.CurrentUICulture

    'обновляем элементы формы
    chkAllowOverlay_CheckedChanged(chkAllowOverlay, e)
    chkUseProxy_CheckedChanged(chkUseProxy, e)
    chkProxyAuth_CheckedChanged(chkProxyAuth, e)
    chkZzWebAuth_CheckedChanged(chkZzWebAuth, e)
    tbFoxId_Leave(tbFoxId, e)
  End Sub

  Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
    Try
      My.Settings.AllowOverlay = chkAllowOverlay.Checked
      Integer.TryParse(tbFoxId.Text, My.Settings.FoxId)
      My.Settings.FoxKey = New Guid(tbFoxKey.Text)
      My.Settings.OverlayAlpha = tbOverlayAlpha.Value
      My.Settings.OverlayColor = btnOverlayColor.BackColor
      My.Settings.SelectColor = btnSelectColor.BackColor
      My.Settings.ProxyAddress = tbProxyAddress.Text
      Integer.TryParse(tbProxyPort.Text, My.Settings.ProxyPort)
      My.Settings.ProxyAuth = chkProxyAuth.Checked
      My.Settings.ProxyLogin = tbProxyLogin.Text
      My.Settings.ProxyPwd = tbProxyPassword.Text
      My.Settings.UserProxy = chkUseProxy.Checked
      My.Settings.ZzWebAuth = chkZzWebAuth.Checked
      My.Settings.ZzWebEmail = tbZzWebEmail.Text
      My.Settings.ZzWebPwd = tbZzWebPassword.Text
      My.Settings.PromptToSave = chkPromptToSave.Checked
      My.Settings.AlwaysCopy = chkAlwaysCopy.Checked
      If Not My.Settings.Language = CType(cmbLanguage.SelectedItem, CultureInfo).Name AndAlso Not (String.IsNullOrEmpty(My.Settings.Language) AndAlso CType(cmbLanguage.SelectedItem, CultureInfo).Name = "ru-RU") Then
        If CType(cmbLanguage.SelectedItem, CultureInfo).Name = "ru-RU" Then
          MessageBox.Show("Чтобы изменения языка вступили в силу, необходимо перезапустить программу.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("Please restart the program.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If
      My.Settings.Language = CType(cmbLanguage.SelectedItem, CultureInfo).Name
      My.Settings.Save()
      'ставим язык приложению
      If Not String.IsNullOrEmpty(My.Settings.Language) Then
        'это поможет избежать неправильной установки языка при повторном открытии этой формы до перезапуска приложения
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(My.Settings.Language)
      End If
      'убиваемся ап стенку :)
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, My.Resources.Strings.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
    Me.Close()
  End Sub

  Private Sub btnSelectColor_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectColor.Click, btnOverlayColor.Click
    ColorDialog1.Color = CType(sender, Button).BackColor
    If Not ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
    CType(sender, Button).BackColor = ColorDialog1.Color
  End Sub

  Private Sub chkAllowOverlay_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAllowOverlay.CheckedChanged
    GroupBox1.Enabled = chkAllowOverlay.Checked
  End Sub

  Private Sub chkUseProxy_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUseProxy.CheckedChanged
    'I like C# / ну что я могу сказать, C# в этом месте выглядел бы гораздо лучше
    GroupBox5.Enabled = chkUseProxy.Checked
    chkProxyAuth.Enabled = chkUseProxy.Checked
    GroupBox6.Enabled = chkUseProxy.Checked AndAlso chkProxyAuth.Checked
  End Sub

  Private Sub chkProxyAuth_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkProxyAuth.CheckedChanged
    GroupBox6.Enabled = chkUseProxy.Checked AndAlso chkProxyAuth.Checked
  End Sub

  Private Sub chkZzWebAuth_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkZzWebAuth.CheckedChanged
    GroupBox9.Enabled = chkZzWebAuth.Checked
  End Sub

  Private Sub RichTextBox1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked, RichTextBox2.LinkClicked
    Dim url As String = e.LinkText
    If Not e.LinkText.ToLower().IndexOf("zzweb.ru") = -1 Then
      url &= "#zz-user-auth;"
    End If
    Process.Start(url)
  End Sub

  Private Sub btnRestoreFoxToolsAccessData_Click(sender As System.Object, e As System.EventArgs) Handles btnRestoreFoxToolsAccessData.Click
    tbFoxId.Text = tbFoxId.Tag.ToString()
    tbFoxKey.Text = tbFoxKey.Tag.ToString()
    btnRestoreFoxToolsAccessData.Enabled = False
  End Sub

  Private Sub tbOnlyNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProxyPort.KeyPress, tbFoxId.KeyPress
    If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
  End Sub

  Private Sub tbFoxId_Leave(sender As System.Object, e As System.EventArgs) Handles tbFoxKey.Leave, tbFoxId.Leave
    btnRestoreFoxToolsAccessData.Enabled = Not (tbFoxId.Text = tbFoxId.Tag.ToString() AndAlso tbFoxKey.Text = tbFoxKey.Tag.ToString())
  End Sub

End Class
