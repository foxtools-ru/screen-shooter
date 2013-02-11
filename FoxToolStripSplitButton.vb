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
Imports System.ComponentModel

Public Class FoxToolStripSplitButton

  Private _Pushed As Boolean = False

  ''' <summary>
  ''' Help information / Справочная информация
  ''' </summary>
  <Localizable(True), SettingsBindable(True)> _
  Public Property Info As String
  'SettingsBindable and Localizable attributes for localize property / Атрибуты Localizable и SettingsBindable необходимы, чтобы свойство можно было локализовать

  ''' <summary>
  ''' Button push status / Состояние нажатости кнопки
  ''' </summary>
  Public Property Pushed() As Boolean
    Get
      Return _Pushed
    End Get
    Set(value As Boolean)
      _Pushed = value
      Me.Invalidate()
    End Set
  End Property

  Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
    MyBase.OnPaint(e)
    'draw the pushed button style / если кнопка выбрана, рисуем рамку
    If Me.Pushed Then
      Dim g As Graphics = e.Graphics
      ControlPaint.DrawBorder3D(g, Me.ButtonBounds)
      ControlPaint.DrawBorder3D(g, Me.DropDownButtonBounds)
    End If
  End Sub

End Class
