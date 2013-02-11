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
Partial Class Result
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Result))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSend = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSendToFoxTools = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSendToZzWeb = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSendToEmail = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPen = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuMarker = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPixelate = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEraser = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuHomePage = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSourceCode = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuService = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnNew = New System.Windows.Forms.ToolStripButton()
    Me.btnSave = New System.Windows.Forms.ToolStripButton()
    Me.btnCopy = New System.Windows.Forms.ToolStripButton()
    Me.btnSend = New FoxTools.Shooter.FoxToolStripSplitButton(Me.components)
    Me.btnSendToFoxTools = New System.Windows.Forms.ToolStripMenuItem()
    Me.btnSendToZzWeb = New System.Windows.Forms.ToolStripMenuItem()
    Me.btnSendToEmail = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnPen = New FoxTools.Shooter.FoxToolStripButton(Me.components)
    Me.btnMarker = New FoxTools.Shooter.FoxToolStripButton(Me.components)
    Me.btnDegradation = New FoxTools.Shooter.FoxToolStripButton(Me.components)
    Me.btnClear = New FoxTools.Shooter.FoxToolStripButton(Me.components)
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
    Me.MenuStrip1.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
    Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuTools, Me.mnuHelp})
    Me.MenuStrip1.Name = "MenuStrip1"
    '
    'mnuFile
    '
    resources.ApplyResources(Me.mnuFile, "mnuFile")
    Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.ToolStripSeparator2, Me.mnuSaveAs, Me.mnuSend, Me.ToolStripSeparator3, Me.mnuExit})
    Me.mnuFile.Name = "mnuFile"
    '
    'mnuNew
    '
    resources.ApplyResources(Me.mnuNew, "mnuNew")
    Me.mnuNew.Name = "mnuNew"
    '
    'ToolStripSeparator2
    '
    resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    '
    'mnuSaveAs
    '
    resources.ApplyResources(Me.mnuSaveAs, "mnuSaveAs")
    Me.mnuSaveAs.Name = "mnuSaveAs"
    '
    'mnuSend
    '
    resources.ApplyResources(Me.mnuSend, "mnuSend")
    Me.mnuSend.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSendToFoxTools, Me.mnuSendToZzWeb, Me.mnuSendToEmail})
    Me.mnuSend.Name = "mnuSend"
    '
    'mnuSendToFoxTools
    '
    resources.ApplyResources(Me.mnuSendToFoxTools, "mnuSendToFoxTools")
    Me.mnuSendToFoxTools.Name = "mnuSendToFoxTools"
    '
    'mnuSendToZzWeb
    '
    resources.ApplyResources(Me.mnuSendToZzWeb, "mnuSendToZzWeb")
    Me.mnuSendToZzWeb.Name = "mnuSendToZzWeb"
    '
    'mnuSendToEmail
    '
    resources.ApplyResources(Me.mnuSendToEmail, "mnuSendToEmail")
    Me.mnuSendToEmail.Name = "mnuSendToEmail"
    '
    'ToolStripSeparator3
    '
    resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    '
    'mnuExit
    '
    resources.ApplyResources(Me.mnuExit, "mnuExit")
    Me.mnuExit.Name = "mnuExit"
    '
    'mnuEdit
    '
    resources.ApplyResources(Me.mnuEdit, "mnuEdit")
    Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy})
    Me.mnuEdit.Name = "mnuEdit"
    '
    'mnuCopy
    '
    resources.ApplyResources(Me.mnuCopy, "mnuCopy")
    Me.mnuCopy.Name = "mnuCopy"
    '
    'mnuTools
    '
    resources.ApplyResources(Me.mnuTools, "mnuTools")
    Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPen, Me.mnuMarker, Me.mnuPixelate, Me.mnuEraser, Me.ToolStripSeparator5, Me.mnuSettings})
    Me.mnuTools.Name = "mnuTools"
    '
    'mnuPen
    '
    resources.ApplyResources(Me.mnuPen, "mnuPen")
    Me.mnuPen.Name = "mnuPen"
    '
    'mnuMarker
    '
    resources.ApplyResources(Me.mnuMarker, "mnuMarker")
    Me.mnuMarker.Name = "mnuMarker"
    '
    'mnuPixelate
    '
    resources.ApplyResources(Me.mnuPixelate, "mnuPixelate")
    Me.mnuPixelate.Name = "mnuPixelate"
    '
    'mnuEraser
    '
    resources.ApplyResources(Me.mnuEraser, "mnuEraser")
    Me.mnuEraser.Name = "mnuEraser"
    '
    'ToolStripSeparator5
    '
    resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
    Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
    '
    'mnuSettings
    '
    resources.ApplyResources(Me.mnuSettings, "mnuSettings")
    Me.mnuSettings.Name = "mnuSettings"
    '
    'mnuHelp
    '
    resources.ApplyResources(Me.mnuHelp, "mnuHelp")
    Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHomePage, Me.mnuSourceCode, Me.ToolStripSeparator4, Me.mnuAbout})
    Me.mnuHelp.Name = "mnuHelp"
    '
    'mnuHomePage
    '
    resources.ApplyResources(Me.mnuHomePage, "mnuHomePage")
    Me.mnuHomePage.Name = "mnuHomePage"
    '
    'mnuSourceCode
    '
    resources.ApplyResources(Me.mnuSourceCode, "mnuSourceCode")
    Me.mnuSourceCode.Name = "mnuSourceCode"
    '
    'ToolStripSeparator4
    '
    resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    '
    'mnuAbout
    '
    resources.ApplyResources(Me.mnuAbout, "mnuAbout")
    Me.mnuAbout.Name = "mnuAbout"
    '
    'mnuService
    '
    resources.ApplyResources(Me.mnuService, "mnuService")
    Me.mnuService.Name = "mnuService"
    '
    'ToolStrip1
    '
    resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnCopy, Me.btnSend, Me.ToolStripSeparator1, Me.btnPen, Me.btnMarker, Me.btnDegradation, Me.btnClear})
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    '
    'btnNew
    '
    resources.ApplyResources(Me.btnNew, "btnNew")
    Me.btnNew.Image = Global.FoxTools.Shooter.My.Resources.Resources.shooter24px
    Me.btnNew.Name = "btnNew"
    '
    'btnSave
    '
    resources.ApplyResources(Me.btnSave, "btnSave")
    Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnSave.Image = Global.FoxTools.Shooter.My.Resources.Resources.save24px
    Me.btnSave.Name = "btnSave"
    '
    'btnCopy
    '
    resources.ApplyResources(Me.btnCopy, "btnCopy")
    Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnCopy.Image = Global.FoxTools.Shooter.My.Resources.Resources.copy24px
    Me.btnCopy.Name = "btnCopy"
    '
    'btnSend
    '
    resources.ApplyResources(Me.btnSend, "btnSend")
    Me.btnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnSend.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSendToFoxTools, Me.btnSendToZzWeb, Me.btnSendToEmail})
    Me.btnSend.Image = Global.FoxTools.Shooter.My.Resources.Resources.share24px
    Me.btnSend.Name = "btnSend"
    Me.btnSend.Pushed = False
    '
    'btnSendToFoxTools
    '
    resources.ApplyResources(Me.btnSendToFoxTools, "btnSendToFoxTools")
    Me.btnSendToFoxTools.Name = "btnSendToFoxTools"
    '
    'btnSendToZzWeb
    '
    resources.ApplyResources(Me.btnSendToZzWeb, "btnSendToZzWeb")
    Me.btnSendToZzWeb.Name = "btnSendToZzWeb"
    '
    'btnSendToEmail
    '
    resources.ApplyResources(Me.btnSendToEmail, "btnSendToEmail")
    Me.btnSendToEmail.Name = "btnSendToEmail"
    '
    'ToolStripSeparator1
    '
    resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    '
    'btnPen
    '
    resources.ApplyResources(Me.btnPen, "btnPen")
    Me.btnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnPen.Image = Global.FoxTools.Shooter.My.Resources.Resources.pen24px
    Me.btnPen.Name = "btnPen"
    Me.btnPen.ShapeType = FoxTools.Shooter.Enums.ShapeType.Pen
    '
    'btnMarker
    '
    resources.ApplyResources(Me.btnMarker, "btnMarker")
    Me.btnMarker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnMarker.Image = Global.FoxTools.Shooter.My.Resources.Resources.marker24px
    Me.btnMarker.Name = "btnMarker"
    Me.btnMarker.ShapeType = FoxTools.Shooter.Enums.ShapeType.Marker
    '
    'btnDegradation
    '
    resources.ApplyResources(Me.btnDegradation, "btnDegradation")
    Me.btnDegradation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnDegradation.Image = Global.FoxTools.Shooter.My.Resources.Resources.pixelize24px
    Me.btnDegradation.Name = "btnDegradation"
    Me.btnDegradation.ShapeType = FoxTools.Shooter.Enums.ShapeType.Pixelate
    '
    'btnClear
    '
    resources.ApplyResources(Me.btnClear, "btnClear")
    Me.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnClear.Image = Global.FoxTools.Shooter.My.Resources.Resources.eraser24px
    Me.btnClear.Name = "btnClear"
    Me.btnClear.ShapeType = FoxTools.Shooter.Enums.ShapeType.Eraser
    '
    'Panel1
    '
    resources.ApplyResources(Me.Panel1, "Panel1")
    Me.Panel1.BackColor = System.Drawing.Color.White
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Panel1.Controls.Add(Me.PictureBox1)
    Me.Panel1.Name = "Panel1"
    '
    'PictureBox1
    '
    resources.ApplyResources(Me.PictureBox1, "PictureBox1")
    Me.PictureBox1.BackColor = System.Drawing.Color.White
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.TabStop = False
    '
    'SaveFileDialog1
    '
    Me.SaveFileDialog1.FileName = "Screen.png"
    resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
    '
    'Result
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.KeyPreview = True
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Result"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuService As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnSend As FoxTools.Shooter.FoxToolStripSplitButton
  Friend WithEvents btnSendToFoxTools As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btnSendToEmail As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btnPen As FoxTools.Shooter.FoxToolStripButton
  Friend WithEvents btnMarker As FoxTools.Shooter.FoxToolStripButton
  Friend WithEvents btnDegradation As FoxTools.Shooter.FoxToolStripButton
  Friend WithEvents btnClear As FoxTools.Shooter.FoxToolStripButton
  Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSend As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuPen As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuMarker As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuPixelate As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEraser As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuHomePage As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSourceCode As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSendToFoxTools As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSendToEmail As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents mnuSendToZzWeb As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btnSendToZzWeb As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
End Class
