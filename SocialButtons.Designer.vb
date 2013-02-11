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
Partial Class SocialButtons
  Inherits System.Windows.Forms.UserControl

  'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SocialButtons))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Button8 = New System.Windows.Forms.Button()
    Me.Button7 = New System.Windows.Forms.Button()
    Me.Button6 = New System.Windows.Forms.Button()
    Me.Button5 = New System.Windows.Forms.Button()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'Button8
    '
    resources.ApplyResources(Me.Button8, "Button8")
    Me.Button8.Image = Global.FoxTools.Shooter.My.Resources.Resources.vk40px
    Me.Button8.Name = "Button8"
    Me.Button8.Tag = "3"
    Me.Button8.UseVisualStyleBackColor = True
    '
    'Button7
    '
    resources.ApplyResources(Me.Button7, "Button7")
    Me.Button7.Image = Global.FoxTools.Shooter.My.Resources.Resources.ok40px
    Me.Button7.Name = "Button7"
    Me.Button7.Tag = "4"
    Me.Button7.UseVisualStyleBackColor = True
    '
    'Button6
    '
    resources.ApplyResources(Me.Button6, "Button6")
    Me.Button6.Image = Global.FoxTools.Shooter.My.Resources.Resources.mailru40px
    Me.Button6.Name = "Button6"
    Me.Button6.Tag = "5"
    Me.Button6.UseVisualStyleBackColor = True
    '
    'Button5
    '
    resources.ApplyResources(Me.Button5, "Button5")
    Me.Button5.Image = Global.FoxTools.Shooter.My.Resources.Resources.gplus40px
    Me.Button5.Name = "Button5"
    Me.Button5.Tag = "2"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'Button4
    '
    resources.ApplyResources(Me.Button4, "Button4")
    Me.Button4.Image = Global.FoxTools.Shooter.My.Resources.Resources.facebook40px
    Me.Button4.Name = "Button4"
    Me.Button4.Tag = "1"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'Button3
    '
    resources.ApplyResources(Me.Button3, "Button3")
    Me.Button3.Image = Global.FoxTools.Shooter.My.Resources.Resources.twitter40px
    Me.Button3.Name = "Button3"
    Me.Button3.Tag = "0"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
    Me.TableLayoutPanel1.Controls.Add(Me.Button3, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Button4, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Button6, 5, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Button7, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Button8, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Button5, 2, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    '
    'SocialButtons
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "SocialButtons"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Button8 As System.Windows.Forms.Button
  Friend WithEvents Button7 As System.Windows.Forms.Button
  Friend WithEvents Button6 As System.Windows.Forms.Button
  Friend WithEvents Button5 As System.Windows.Forms.Button
  Friend WithEvents Button4 As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
