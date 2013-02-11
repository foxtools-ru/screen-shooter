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
Partial Class PromptToSave
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromptToSave))
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.chkDontShowAgain = New System.Windows.Forms.CheckBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnYes = New System.Windows.Forms.Button()
    Me.btnNo = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.Panel1.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    resources.ApplyResources(Me.Panel1, "Panel1")
    Me.Panel1.BackColor = System.Drawing.SystemColors.Window
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.PictureBox1)
    Me.Panel1.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Panel1.Name = "Panel1"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
    Me.Label1.Name = "Label1"
    '
    'PictureBox1
    '
    resources.ApplyResources(Me.PictureBox1, "PictureBox1")
    Me.PictureBox1.Image = Global.FoxTools.Shooter.My.Resources.Resources.warning
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.TabStop = False
    '
    'chkDontShowAgain
    '
    resources.ApplyResources(Me.chkDontShowAgain, "chkDontShowAgain")
    Me.chkDontShowAgain.Name = "chkDontShowAgain"
    Me.chkDontShowAgain.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
    Me.TableLayoutPanel1.Controls.Add(Me.chkDontShowAgain, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnYes, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnNo, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 4, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    '
    'btnYes
    '
    resources.ApplyResources(Me.btnYes, "btnYes")
    Me.btnYes.Name = "btnYes"
    Me.btnYes.UseVisualStyleBackColor = True
    '
    'btnNo
    '
    resources.ApplyResources(Me.btnNo, "btnNo")
    Me.btnNo.Name = "btnNo"
    Me.btnNo.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    resources.ApplyResources(Me.btnCancel, "btnCancel")
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'PromptToSave
    '
    Me.AcceptButton = Me.btnYes
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancel
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.Panel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "PromptToSave"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents chkDontShowAgain As System.Windows.Forms.CheckBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents btnYes As System.Windows.Forms.Button
  Friend WithEvents btnNo As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
