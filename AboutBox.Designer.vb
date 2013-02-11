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
Partial Class AboutBox
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

  Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
  Friend WithEvents LabelProductName As System.Windows.Forms.Label
  Friend WithEvents LabelVersion As System.Windows.Forms.Label
  Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
  Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
  Friend WithEvents OKButton As System.Windows.Forms.Button
  Friend WithEvents LabelCopyright As System.Windows.Forms.Label

  'Является обязательной для конструктора форм Windows Forms
  Private components As System.ComponentModel.IContainer

  'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
  'Для ее изменения используйте конструктор форм Windows Form.  
  'Не изменяйте ее в редакторе исходного кода.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
    Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
    Me.LabelProductName = New System.Windows.Forms.Label()
    Me.LabelVersion = New System.Windows.Forms.Label()
    Me.LabelCopyright = New System.Windows.Forms.Label()
    Me.LabelCompanyName = New System.Windows.Forms.Label()
    Me.TextBoxDescription = New System.Windows.Forms.TextBox()
    Me.OKButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        resources.ApplyResources(Me.TableLayoutPanel, "TableLayoutPanel")
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LogoPictureBox, "LogoPictureBox")
        Me.LogoPictureBox.Image = Global.FoxTools.Shooter.My.Resources.Resources.FoxToolsScreenShooter
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
        Me.LogoPictureBox.TabStop = False
        '
        'LabelProductName
        '
        resources.ApplyResources(Me.LabelProductName, "LabelProductName")
        Me.LabelProductName.Name = "LabelProductName"
        '
        'LabelVersion
        '
        resources.ApplyResources(Me.LabelVersion, "LabelVersion")
        Me.LabelVersion.Name = "LabelVersion"
        '
        'LabelCopyright
        '
        resources.ApplyResources(Me.LabelCopyright, "LabelCopyright")
        Me.LabelCopyright.Name = "LabelCopyright"
        '
        'LabelCompanyName
        '
        resources.ApplyResources(Me.LabelCompanyName, "LabelCompanyName")
        Me.LabelCompanyName.Name = "LabelCompanyName"
        '
        'TextBoxDescription
        '
        resources.ApplyResources(Me.TextBoxDescription, "TextBoxDescription")
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.TabStop = False
        '
        'OKButton
        '
        resources.ApplyResources(Me.OKButton, "OKButton")
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Name = "OKButton"
        '
        'AboutBox
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.ShowInTaskbar = False
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

End Class
