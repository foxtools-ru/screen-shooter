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
Partial Class ConfigPen
  Inherits ConfigShapeForm

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigPen))
    Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.RadioButton4 = New System.Windows.Forms.RadioButton()
    Me.RadioButton3 = New System.Windows.Forms.RadioButton()
    Me.RadioButton2 = New System.Windows.Forms.RadioButton()
    Me.RadioButton1 = New System.Windows.Forms.RadioButton()
    Me.btnColor = New System.Windows.Forms.Button()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    resources.ApplyResources(Me.Panel1, "Panel1")
    Me.Panel1.Controls.Add(Me.RadioButton4)
    Me.Panel1.Controls.Add(Me.RadioButton3)
    Me.Panel1.Controls.Add(Me.RadioButton2)
    Me.Panel1.Controls.Add(Me.RadioButton1)
    Me.Panel1.Name = "Panel1"
    '
    'RadioButton4
    '
    resources.ApplyResources(Me.RadioButton4, "RadioButton4")
    Me.RadioButton4.Image = Global.FoxTools.Shooter.My.Resources.Resources.border10px
    Me.RadioButton4.Name = "RadioButton4"
    Me.RadioButton4.Tag = "10"
    Me.RadioButton4.UseVisualStyleBackColor = True
    '
    'RadioButton3
    '
    resources.ApplyResources(Me.RadioButton3, "RadioButton3")
    Me.RadioButton3.Image = Global.FoxTools.Shooter.My.Resources.Resources.border5px
    Me.RadioButton3.Name = "RadioButton3"
    Me.RadioButton3.Tag = "5"
    Me.RadioButton3.UseVisualStyleBackColor = True
    '
    'RadioButton2
    '
    resources.ApplyResources(Me.RadioButton2, "RadioButton2")
    Me.RadioButton2.Checked = True
    Me.RadioButton2.Image = Global.FoxTools.Shooter.My.Resources.Resources.border3px
    Me.RadioButton2.Name = "RadioButton2"
    Me.RadioButton2.TabStop = True
    Me.RadioButton2.Tag = "3"
    Me.RadioButton2.UseVisualStyleBackColor = True
    '
    'RadioButton1
    '
    resources.ApplyResources(Me.RadioButton1, "RadioButton1")
    Me.RadioButton1.Image = Global.FoxTools.Shooter.My.Resources.Resources.border1px
    Me.RadioButton1.Name = "RadioButton1"
    Me.RadioButton1.Tag = "1"
    Me.RadioButton1.UseVisualStyleBackColor = True
    '
    'btnColor
    '
    resources.ApplyResources(Me.btnColor, "btnColor")
    Me.btnColor.BackColor = System.Drawing.Color.Red
    Me.btnColor.Name = "btnColor"
    Me.btnColor.UseVisualStyleBackColor = False
    '
    'ConfigPen
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.btnColor)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "ConfigPen"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.Panel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents btnColor As System.Windows.Forms.Button
  Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
