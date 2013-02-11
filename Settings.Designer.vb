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
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
  Inherits System.Windows.Forms.Form

  'Форма переопределяет dispose для очистки списка компонентов.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Является обязательной для конструктора форм Windows Forms
  Private components As System.ComponentModel.IContainer

  'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
  'Для ее изменения используйте конструктор форм Windows Form.  
  'Не изменяйте ее в редакторе исходного кода.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.btnSelectColor = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.chkAllowOverlay = New System.Windows.Forms.CheckBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.tbOverlayAlpha = New System.Windows.Forms.TrackBar()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnOverlayColor = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.chkPromptToSave = New System.Windows.Forms.CheckBox()
    Me.chkAlwaysCopy = New System.Windows.Forms.CheckBox()
    Me.cmbLanguage = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.GroupBox6 = New System.Windows.Forms.GroupBox()
    Me.tbProxyPassword = New System.Windows.Forms.TextBox()
    Me.tbProxyLogin = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.GroupBox5 = New System.Windows.Forms.GroupBox()
    Me.tbProxyPort = New System.Windows.Forms.TextBox()
    Me.tbProxyAddress = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.chkProxyAuth = New System.Windows.Forms.CheckBox()
    Me.chkUseProxy = New System.Windows.Forms.CheckBox()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.GroupBox8 = New System.Windows.Forms.GroupBox()
    Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
    Me.chkZzWebAuth = New System.Windows.Forms.CheckBox()
    Me.GroupBox9 = New System.Windows.Forms.GroupBox()
    Me.tbZzWebPassword = New System.Windows.Forms.TextBox()
    Me.tbZzWebEmail = New System.Windows.Forms.TextBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.GroupBox7 = New System.Windows.Forms.GroupBox()
    Me.btnRestoreFoxToolsAccessData = New System.Windows.Forms.Button()
    Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
    Me.tbFoxKey = New System.Windows.Forms.TextBox()
    Me.tbFoxId = New System.Windows.Forms.TextBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnSave = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.tbOverlayAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox3.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox6.SuspendLayout()
    Me.GroupBox5.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.GroupBox8.SuspendLayout()
    Me.GroupBox9.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.GroupBox7.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    resources.ApplyResources(Me.TabControl1, "TabControl1")
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage4)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    '
    'TabPage1
    '
    resources.ApplyResources(Me.TabPage1, "TabPage1")
    Me.TabPage1.Controls.Add(Me.GroupBox2)
    Me.TabPage1.Controls.Add(Me.chkAllowOverlay)
    Me.TabPage1.Controls.Add(Me.GroupBox1)
    Me.TabPage1.Controls.Add(Me.GroupBox3)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    resources.ApplyResources(Me.GroupBox2, "GroupBox2")
    Me.GroupBox2.Controls.Add(Me.btnSelectColor)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.TabStop = False
    '
    'btnSelectColor
    '
    resources.ApplyResources(Me.btnSelectColor, "btnSelectColor")
    Me.btnSelectColor.BackColor = System.Drawing.Color.Red
    Me.btnSelectColor.ForeColor = System.Drawing.Color.Black
    Me.btnSelectColor.Name = "btnSelectColor"
    Me.btnSelectColor.UseVisualStyleBackColor = False
    '
    'Label5
    '
    resources.ApplyResources(Me.Label5, "Label5")
    Me.Label5.Name = "Label5"
    '
    'chkAllowOverlay
    '
    resources.ApplyResources(Me.chkAllowOverlay, "chkAllowOverlay")
    Me.chkAllowOverlay.Name = "chkAllowOverlay"
    Me.chkAllowOverlay.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Controls.Add(Me.tbOverlayAlpha)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.btnOverlayColor)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'tbOverlayAlpha
    '
    resources.ApplyResources(Me.tbOverlayAlpha, "tbOverlayAlpha")
    Me.tbOverlayAlpha.LargeChange = 10
    Me.tbOverlayAlpha.Maximum = 200
    Me.tbOverlayAlpha.Minimum = 10
    Me.tbOverlayAlpha.Name = "tbOverlayAlpha"
    Me.tbOverlayAlpha.TickStyle = System.Windows.Forms.TickStyle.None
    Me.tbOverlayAlpha.Value = 50
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'btnOverlayColor
    '
    resources.ApplyResources(Me.btnOverlayColor, "btnOverlayColor")
    Me.btnOverlayColor.BackColor = System.Drawing.Color.White
    Me.btnOverlayColor.ForeColor = System.Drawing.Color.White
    Me.btnOverlayColor.Name = "btnOverlayColor"
    Me.btnOverlayColor.UseVisualStyleBackColor = False
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'GroupBox3
    '
    resources.ApplyResources(Me.GroupBox3, "GroupBox3")
    Me.GroupBox3.Controls.Add(Me.chkPromptToSave)
    Me.GroupBox3.Controls.Add(Me.chkAlwaysCopy)
    Me.GroupBox3.Controls.Add(Me.cmbLanguage)
    Me.GroupBox3.Controls.Add(Me.Label6)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.TabStop = False
    '
    'chkPromptToSave
    '
    resources.ApplyResources(Me.chkPromptToSave, "chkPromptToSave")
    Me.chkPromptToSave.Name = "chkPromptToSave"
    Me.chkPromptToSave.UseVisualStyleBackColor = True
    '
    'chkAlwaysCopy
    '
    resources.ApplyResources(Me.chkAlwaysCopy, "chkAlwaysCopy")
    Me.chkAlwaysCopy.Name = "chkAlwaysCopy"
    Me.chkAlwaysCopy.UseVisualStyleBackColor = True
    '
    'cmbLanguage
    '
    resources.ApplyResources(Me.cmbLanguage, "cmbLanguage")
    Me.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbLanguage.FormattingEnabled = True
    Me.cmbLanguage.Items.AddRange(New Object() {resources.GetString("cmbLanguage.Items")})
    Me.cmbLanguage.Name = "cmbLanguage"
    '
    'Label6
    '
    resources.ApplyResources(Me.Label6, "Label6")
    Me.Label6.Name = "Label6"
    '
    'TabPage2
    '
    resources.ApplyResources(Me.TabPage2, "TabPage2")
    Me.TabPage2.Controls.Add(Me.GroupBox4)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'GroupBox4
    '
    resources.ApplyResources(Me.GroupBox4, "GroupBox4")
    Me.GroupBox4.Controls.Add(Me.GroupBox6)
    Me.GroupBox4.Controls.Add(Me.GroupBox5)
    Me.GroupBox4.Controls.Add(Me.chkProxyAuth)
    Me.GroupBox4.Controls.Add(Me.chkUseProxy)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.TabStop = False
    '
    'GroupBox6
    '
    resources.ApplyResources(Me.GroupBox6, "GroupBox6")
    Me.GroupBox6.Controls.Add(Me.tbProxyPassword)
    Me.GroupBox6.Controls.Add(Me.tbProxyLogin)
    Me.GroupBox6.Controls.Add(Me.Label9)
    Me.GroupBox6.Controls.Add(Me.Label10)
    Me.GroupBox6.Name = "GroupBox6"
    Me.GroupBox6.TabStop = False
    '
    'tbProxyPassword
    '
    resources.ApplyResources(Me.tbProxyPassword, "tbProxyPassword")
    Me.tbProxyPassword.Name = "tbProxyPassword"
    '
    'tbProxyLogin
    '
    resources.ApplyResources(Me.tbProxyLogin, "tbProxyLogin")
    Me.tbProxyLogin.Name = "tbProxyLogin"
    '
    'Label9
    '
    resources.ApplyResources(Me.Label9, "Label9")
    Me.Label9.Name = "Label9"
    '
    'Label10
    '
    resources.ApplyResources(Me.Label10, "Label10")
    Me.Label10.Name = "Label10"
    '
    'GroupBox5
    '
    resources.ApplyResources(Me.GroupBox5, "GroupBox5")
    Me.GroupBox5.Controls.Add(Me.tbProxyPort)
    Me.GroupBox5.Controls.Add(Me.tbProxyAddress)
    Me.GroupBox5.Controls.Add(Me.Label8)
    Me.GroupBox5.Controls.Add(Me.Label7)
    Me.GroupBox5.Name = "GroupBox5"
    Me.GroupBox5.TabStop = False
    '
    'tbProxyPort
    '
    resources.ApplyResources(Me.tbProxyPort, "tbProxyPort")
    Me.tbProxyPort.Name = "tbProxyPort"
    '
    'tbProxyAddress
    '
    resources.ApplyResources(Me.tbProxyAddress, "tbProxyAddress")
    Me.tbProxyAddress.Name = "tbProxyAddress"
    '
    'Label8
    '
    resources.ApplyResources(Me.Label8, "Label8")
    Me.Label8.Name = "Label8"
    '
    'Label7
    '
    resources.ApplyResources(Me.Label7, "Label7")
    Me.Label7.Name = "Label7"
    '
    'chkProxyAuth
    '
    resources.ApplyResources(Me.chkProxyAuth, "chkProxyAuth")
    Me.chkProxyAuth.Name = "chkProxyAuth"
    Me.chkProxyAuth.UseVisualStyleBackColor = True
    '
    'chkUseProxy
    '
    resources.ApplyResources(Me.chkUseProxy, "chkUseProxy")
    Me.chkUseProxy.Name = "chkUseProxy"
    Me.chkUseProxy.UseVisualStyleBackColor = True
    '
    'TabPage4
    '
    resources.ApplyResources(Me.TabPage4, "TabPage4")
    Me.TabPage4.Controls.Add(Me.GroupBox8)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'GroupBox8
    '
    resources.ApplyResources(Me.GroupBox8, "GroupBox8")
    Me.GroupBox8.Controls.Add(Me.RichTextBox2)
    Me.GroupBox8.Controls.Add(Me.chkZzWebAuth)
    Me.GroupBox8.Controls.Add(Me.GroupBox9)
    Me.GroupBox8.Name = "GroupBox8"
    Me.GroupBox8.TabStop = False
    '
    'RichTextBox2
    '
    resources.ApplyResources(Me.RichTextBox2, "RichTextBox2")
    Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
    Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.RichTextBox2.Name = "RichTextBox2"
    Me.RichTextBox2.ReadOnly = True
    Me.RichTextBox2.TabStop = False
    '
    'chkZzWebAuth
    '
    resources.ApplyResources(Me.chkZzWebAuth, "chkZzWebAuth")
    Me.chkZzWebAuth.Name = "chkZzWebAuth"
    Me.chkZzWebAuth.UseVisualStyleBackColor = True
    '
    'GroupBox9
    '
    resources.ApplyResources(Me.GroupBox9, "GroupBox9")
    Me.GroupBox9.Controls.Add(Me.tbZzWebPassword)
    Me.GroupBox9.Controls.Add(Me.tbZzWebEmail)
    Me.GroupBox9.Controls.Add(Me.Label15)
    Me.GroupBox9.Controls.Add(Me.Label16)
    Me.GroupBox9.Name = "GroupBox9"
    Me.GroupBox9.TabStop = False
    '
    'tbZzWebPassword
    '
    resources.ApplyResources(Me.tbZzWebPassword, "tbZzWebPassword")
    Me.tbZzWebPassword.Name = "tbZzWebPassword"
    '
    'tbZzWebEmail
    '
    resources.ApplyResources(Me.tbZzWebEmail, "tbZzWebEmail")
    Me.tbZzWebEmail.Name = "tbZzWebEmail"
    '
    'Label15
    '
    resources.ApplyResources(Me.Label15, "Label15")
    Me.Label15.Name = "Label15"
    '
    'Label16
    '
    resources.ApplyResources(Me.Label16, "Label16")
    Me.Label16.Name = "Label16"
    '
    'TabPage3
    '
    resources.ApplyResources(Me.TabPage3, "TabPage3")
    Me.TabPage3.Controls.Add(Me.GroupBox7)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'GroupBox7
    '
    resources.ApplyResources(Me.GroupBox7, "GroupBox7")
    Me.GroupBox7.Controls.Add(Me.btnRestoreFoxToolsAccessData)
    Me.GroupBox7.Controls.Add(Me.RichTextBox1)
    Me.GroupBox7.Controls.Add(Me.tbFoxKey)
    Me.GroupBox7.Controls.Add(Me.tbFoxId)
    Me.GroupBox7.Controls.Add(Me.Label12)
    Me.GroupBox7.Controls.Add(Me.Label11)
    Me.GroupBox7.Name = "GroupBox7"
    Me.GroupBox7.TabStop = False
    '
    'btnRestoreFoxToolsAccessData
    '
    resources.ApplyResources(Me.btnRestoreFoxToolsAccessData, "btnRestoreFoxToolsAccessData")
    Me.btnRestoreFoxToolsAccessData.Name = "btnRestoreFoxToolsAccessData"
    Me.btnRestoreFoxToolsAccessData.UseVisualStyleBackColor = True
    '
    'RichTextBox1
    '
    resources.ApplyResources(Me.RichTextBox1, "RichTextBox1")
    Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
    Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.RichTextBox1.Name = "RichTextBox1"
    Me.RichTextBox1.ReadOnly = True
    Me.RichTextBox1.TabStop = False
    '
    'tbFoxKey
    '
    resources.ApplyResources(Me.tbFoxKey, "tbFoxKey")
    Me.tbFoxKey.Name = "tbFoxKey"
    Me.tbFoxKey.Tag = "60f6f2d9-0280-4d8a-b9ed-6cba8b49ecec"
    '
    'tbFoxId
    '
    resources.ApplyResources(Me.tbFoxId, "tbFoxId")
    Me.tbFoxId.Name = "tbFoxId"
    Me.tbFoxId.Tag = "6"
    '
    'Label12
    '
    resources.ApplyResources(Me.Label12, "Label12")
    Me.Label12.Name = "Label12"
    '
    'Label11
    '
    resources.ApplyResources(Me.Label11, "Label11")
    Me.Label11.Name = "Label11"
    '
    'TableLayoutPanel1
    '
    resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
    Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    '
    'btnSave
    '
    resources.ApplyResources(Me.btnSave, "btnSave")
    Me.btnSave.Name = "btnSave"
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    resources.ApplyResources(Me.btnCancel, "btnCancel")
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'Settings
    '
    Me.AcceptButton = Me.btnSave
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancel
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Settings"
    Me.ShowInTaskbar = False
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.tbOverlayAlpha, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox4.PerformLayout()
    Me.GroupBox6.ResumeLayout(False)
    Me.GroupBox6.PerformLayout()
    Me.GroupBox5.ResumeLayout(False)
    Me.GroupBox5.PerformLayout()
    Me.TabPage4.ResumeLayout(False)
    Me.GroupBox8.ResumeLayout(False)
    Me.GroupBox8.PerformLayout()
    Me.GroupBox9.ResumeLayout(False)
    Me.GroupBox9.PerformLayout()
    Me.TabPage3.ResumeLayout(False)
    Me.GroupBox7.ResumeLayout(False)
    Me.GroupBox7.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents chkAllowOverlay As System.Windows.Forms.CheckBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents tbOverlayAlpha As System.Windows.Forms.TrackBar
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnOverlayColor As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chkAlwaysCopy As System.Windows.Forms.CheckBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btnSelectColor As System.Windows.Forms.Button
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cmbLanguage As System.Windows.Forms.ComboBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents btnSave As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents chkProxyAuth As System.Windows.Forms.CheckBox
  Friend WithEvents chkUseProxy As System.Windows.Forms.CheckBox
  Friend WithEvents chkPromptToSave As System.Windows.Forms.CheckBox
  Friend WithEvents tbProxyPort As System.Windows.Forms.TextBox
  Friend WithEvents tbProxyAddress As System.Windows.Forms.TextBox
  Friend WithEvents tbProxyPassword As System.Windows.Forms.TextBox
  Friend WithEvents tbProxyLogin As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
  Friend WithEvents tbFoxKey As System.Windows.Forms.TextBox
  Friend WithEvents tbFoxId As System.Windows.Forms.TextBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
  Friend WithEvents btnRestoreFoxToolsAccessData As System.Windows.Forms.Button
  Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
  Friend WithEvents tbZzWebPassword As System.Windows.Forms.TextBox
  Friend WithEvents tbZzWebEmail As System.Windows.Forms.TextBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents chkZzWebAuth As System.Windows.Forms.CheckBox
  Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
  Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
