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
Imports System.Drawing.Drawing2D

Public Class FoxShape

  ''' <summary>
  ''' Type of Shape / Тип фигуры
  ''' </summary>
  Public Property ShapeType As Enums.ShapeType = Enums.ShapeType.Pen

  ''' <summary>
  ''' Start position by X / Начало ввода по X
  ''' </summary>
  Public Property X As Integer

  ''' <summary>
  ''' Start position by Y / Начало ввода по Y
  ''' </summary>
  Public Property Y As Integer

  ''' <summary>
  ''' Width of Shape / Ширина фигуры
  ''' </summary>
  Public Property Width As Integer

  ''' <summary>
  ''' Height of Shape / Высота фигуры
  ''' </summary>
  Public Property Height As Integer

  ''' <summary>
  ''' Color of Shape / Цвет
  ''' </summary>
  Public Property Color As Color = Color.Red

  ''' <summary>
  ''' Line depth / Толщена линий/пера, глубина искажений, в зависимости от типа фигуры
  ''' </summary>
  Public Property Depth As Integer = 3

  ''' <summary>
  ''' Text / Текст (TODO)
  ''' </summary>
  Public Property Text As String = String.Empty

  ''' <summary>
  ''' Array of Points for Pen and Marker ShapeType / Массив точек (для пера и маркера)
  ''' </summary>
  Public Property Points As New List(Of Point)

  ''' <summary>
  ''' The Shape is Completed / Фигура завершена, больше изменяться не будет
  ''' </summary>
  Public Property IsCompleted As Boolean = False

  ''' <summary>
  ''' Image cache for Pixelate / Прорисованная фигура, для улучшения производительности. Можно просто Имагин Кеша
  ''' </summary>
  Public Property ImageCache As Image

  ''' <summary>
  ''' Absolute position by X / Абсолютная позиция по X (с учетом отрицательной ширины фигуры)
  ''' </summary>
  Public ReadOnly Property AbsX As Integer
    Get
      If Me.Width < 0 Then
        Return Me.X - Math.Abs(Me.Width)
      Else
        Return Me.X
      End If
    End Get
  End Property

  ''' <summary>
  ''' Absolute position by Y / Абсолютная позиция по Y (с учетом отрицательной высоты фигуры)
  ''' </summary>
  Public ReadOnly Property AbsY As Integer
    Get
      If Me.Height < 0 Then
        Return Me.Y - Math.Abs(Me.Height)
      Else
        Return Me.Y
      End If
    End Get
  End Property

  ''' <summary>
  ''' Absolute width of the Shape / Ширина фигуры, всегда не ниже нуля
  ''' </summary>
  Public ReadOnly Property AbsWidth As Integer
    Get
      Return Math.Abs(Me.Width)
    End Get
  End Property

  ''' <summary>
  ''' Absolute height of the Shape / Высота фигуры, всегда не ниже нуля
  ''' </summary>
  Public ReadOnly Property AbsHeight As Integer
    Get
      Return Math.Abs(Me.Height)
    End Get
  End Property

  ''' <summary>
  ''' Returns the Pen by properties of the current Shape / Возвращает перо на основе параметров фигуры
  ''' </summary>
  Public Function GetPen() As Pen
    'create new Pen / создаем перо
    Dim pn As New Pen(New SolidBrush(Me.Color), Me.Depth)

    'set cap type / форма линий
    pn.StartCap = LineCap.Round 'LineCap.Square
    pn.EndCap = LineCap.Round 'LineCap.Square

    'set line type / стиль линий
    pn.DashStyle = DashStyle.Solid
    pn.LineJoin = LineJoin.Round

    'return / возвращаем перо
    Return pn
  End Function

End Class
