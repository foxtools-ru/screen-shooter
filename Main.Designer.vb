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
Partial Class Main
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnNew = New FoxTools.Shooter.FoxToolStripSplitButton(Me.components)
    Me.btnCustomForm = New FoxTools.Shooter.FoxToolStripMenuItem(Me.components)
    Me.btnRectangle = New FoxTools.Shooter.FoxToolStripMenuItem(Me.components)
    Me.btnWindow = New FoxTools.Shooter.FoxToolStripMenuItem(Me.components)
    Me.btnFullScreen = New FoxTools.Shooter.FoxToolStripMenuItem(Me.components)
    Me.btnCancel = New System.Windows.Forms.ToolStripButton()
    Me.btnSettings = New System.Windows.Forms.ToolStripButton()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStrip1
    '
    resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnCancel, Me.btnSettings})
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.ToolStrip1.ShowItemToolTips = False
    '
    'btnNew
    '
    resources.ApplyResources(Me.btnNew, "btnNew")
    Me.btnNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCustomForm, Me.btnRectangle, Me.btnWindow, Me.btnFullScreen})
    Me.btnNew.Image = Global.FoxTools.Shooter.My.Resources.Resources.shooter24px
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Pushed = False
    '
    'btnCustomForm
    '
    resources.ApplyResources(Me.btnCustomForm, "btnCustomForm")
    Me.btnCustomForm.Mode = FoxTools.Shooter.Enums.ScreenMode.Custom
    Me.btnCustomForm.Name = "btnCustomForm"
    Me.btnCustomForm.Tag = ""
    '
    'btnRectangle
    '
    resources.ApplyResources(Me.btnRectangle, "btnRectangle")
    Me.btnRectangle.Mode = FoxTools.Shooter.Enums.ScreenMode.Rectangle
    Me.btnRectangle.Name = "btnRectangle"
    Me.btnRectangle.Tag = ""
    '
    'btnWindow
    '
    resources.ApplyResources(Me.btnWindow, "btnWindow")
    Me.btnWindow.Mode = FoxTools.Shooter.Enums.ScreenMode.Window
    Me.btnWindow.Name = "btnWindow"
    Me.btnWindow.Tag = ""
    '
    'btnFullScreen
    '
    resources.ApplyResources(Me.btnFullScreen, "btnFullScreen")
    Me.btnFullScreen.Mode = FoxTools.Shooter.Enums.ScreenMode.Full
    Me.btnFullScreen.Name = "btnFullScreen"
    Me.btnFullScreen.Tag = ""
    '
    'btnCancel
    '
    resources.ApplyResources(Me.btnCancel, "btnCancel")
    Me.btnCancel.Image = Global.FoxTools.Shooter.My.Resources.Resources.cancel24px
    Me.btnCancel.Name = "btnCancel"
    '
    'btnSettings
    '
    resources.ApplyResources(Me.btnSettings, "btnSettings")
    Me.btnSettings.Image = Global.FoxTools.Shooter.My.Resources.Resources.settings24px
    Me.btnSettings.Name = "btnSettings"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Name = "Label1"
    '
    'Main
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ToolStrip1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.Name = "Main"
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnNew As FoxToolStripSplitButton
  Friend WithEvents btnCustomForm As FoxToolStripMenuItem
  Friend WithEvents btnRectangle As FoxToolStripMenuItem
  Friend WithEvents btnWindow As FoxToolStripMenuItem
  Friend WithEvents btnFullScreen As FoxToolStripMenuItem
  Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnSettings As System.Windows.Forms.ToolStripButton
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
