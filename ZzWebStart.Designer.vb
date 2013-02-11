<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZzWebStart
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZzWebStart))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.tbPassword = New System.Windows.Forms.TextBox()
    Me.tbEmail = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.chkAuthentication = New System.Windows.Forms.CheckBox()
    Me.tbComment = New System.Windows.Forms.TextBox()
    Me.btnSend = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.chkMore = New System.Windows.Forms.CheckBox()
    Me.chkDisableComments = New System.Windows.Forms.CheckBox()
    Me.chkLepota = New System.Windows.Forms.CheckBox()
    Me.chkDisableRss = New System.Windows.Forms.CheckBox()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'GroupBox1
    '
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.LinkLabel1)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.tbPassword)
    Me.GroupBox1.Controls.Add(Me.tbEmail)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'Label5
    '
    resources.ApplyResources(Me.Label5, "Label5")
    Me.Label5.Name = "Label5"
    '
    'LinkLabel1
    '
    resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.TabStop = True
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
    '
    'tbPassword
    '
    resources.ApplyResources(Me.tbPassword, "tbPassword")
    Me.tbPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FoxTools.Shooter.My.MySettings.Default, "ZzWebPwd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.tbPassword.Name = "tbPassword"
    Me.tbPassword.Text = Global.FoxTools.Shooter.My.MySettings.Default.ZzWebPwd
    '
    'tbEmail
    '
    resources.ApplyResources(Me.tbEmail, "tbEmail")
    Me.tbEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FoxTools.Shooter.My.MySettings.Default, "ZzWebEmail", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.tbEmail.Name = "tbEmail"
    Me.tbEmail.Text = Global.FoxTools.Shooter.My.MySettings.Default.ZzWebEmail
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
    'chkAuthentication
    '
    resources.ApplyResources(Me.chkAuthentication, "chkAuthentication")
    Me.chkAuthentication.Checked = Global.FoxTools.Shooter.My.MySettings.Default.ZzWebAuth
    Me.chkAuthentication.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.FoxTools.Shooter.My.MySettings.Default, "ZzWebAuth", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkAuthentication.Name = "chkAuthentication"
    Me.chkAuthentication.UseVisualStyleBackColor = True
    '
    'tbComment
    '
    resources.ApplyResources(Me.tbComment, "tbComment")
    Me.tbComment.ForeColor = System.Drawing.SystemColors.WindowText
    Me.tbComment.Name = "tbComment"
    Me.tbComment.Tag = ""
    '
    'btnSend
    '
    resources.ApplyResources(Me.btnSend, "btnSend")
    Me.btnSend.Name = "btnSend"
    Me.btnSend.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    resources.ApplyResources(Me.btnCancel, "btnCancel")
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'chkMore
    '
    resources.ApplyResources(Me.chkMore, "chkMore")
    Me.chkMore.Checked = Global.FoxTools.Shooter.My.MySettings.Default.ZzWebConfigMore
    Me.chkMore.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.FoxTools.Shooter.My.MySettings.Default, "ZzWebConfigMore", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkMore.Name = "chkMore"
    Me.chkMore.UseVisualStyleBackColor = True
    '
    'chkDisableComments
    '
    resources.ApplyResources(Me.chkDisableComments, "chkDisableComments")
    Me.chkDisableComments.Checked = Global.FoxTools.Shooter.My.MySettings.Default.ZzWebDisComments
    Me.chkDisableComments.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.FoxTools.Shooter.My.MySettings.Default, "ZzWebDisComments", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkDisableComments.Name = "chkDisableComments"
    Me.chkDisableComments.UseVisualStyleBackColor = True
    '
    'chkLepota
    '
    resources.ApplyResources(Me.chkLepota, "chkLepota")
    Me.chkLepota.Checked = Global.FoxTools.Shooter.My.MySettings.Default.ZzWebLepota
    Me.chkLepota.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.FoxTools.Shooter.My.MySettings.Default, "ZzWebLepota", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkLepota.Name = "chkLepota"
    Me.chkLepota.UseVisualStyleBackColor = True
    '
    'chkDisableRss
    '
    resources.ApplyResources(Me.chkDisableRss, "chkDisableRss")
    Me.chkDisableRss.Checked = Global.FoxTools.Shooter.My.MySettings.Default.ZzWebDisRss
    Me.chkDisableRss.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.FoxTools.Shooter.My.MySettings.Default, "ZzWebDisRss", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkDisableRss.Name = "chkDisableRss"
    Me.chkDisableRss.UseVisualStyleBackColor = True
    '
    'ZzWebStart
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancel
    Me.Controls.Add(Me.chkDisableRss)
    Me.Controls.Add(Me.chkLepota)
    Me.Controls.Add(Me.chkDisableComments)
    Me.Controls.Add(Me.chkMore)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnSend)
    Me.Controls.Add(Me.tbComment)
    Me.Controls.Add(Me.chkAuthentication)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "ZzWebStart"
    Me.ShowInTaskbar = False
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents tbPassword As System.Windows.Forms.TextBox
  Friend WithEvents tbEmail As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents chkAuthentication As System.Windows.Forms.CheckBox
  Friend WithEvents tbComment As System.Windows.Forms.TextBox
  Friend WithEvents btnSend As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents chkMore As System.Windows.Forms.CheckBox
  Friend WithEvents chkDisableComments As System.Windows.Forms.CheckBox
  Friend WithEvents chkLepota As System.Windows.Forms.CheckBox
  Friend WithEvents chkDisableRss As System.Windows.Forms.CheckBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
  Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
