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
Public Class FoxShapeCollection
  Inherits List(Of FoxShape)

  ''' <summary>
  ''' Add the Shape to the Collection and return added Shape / Добавляет фигуру в коллекцию
  ''' </summary>
  Public Function AddShape(itm As FoxShape) As FoxShape
    If itm.ShapeType = Enums.ShapeType.Pixelate Then
      'inserted the Pixelate Shape after the last Pixelate
      'вставляем после последней фигуры аналогичного типа
      'чтобы смотрелось более ли менее прилично :)
      For i As Integer = Me.Count - 1 To 0 Step -1 'I like C#, but this is not it / C# зер гут
        If Me(i).ShapeType = itm.ShapeType Then
          Me.Insert(i + 1, itm)
          Return Me(i + 1)
        End If
      Next
      'Pixelate Shape not found
      Me.Insert(0, itm)
      Return Me(0)
    End If

    Me.Add(itm)

    Return Me(Me.Count - 1)
  End Function

  ''' <summary>
  ''' Returns the bound of Shapes / Возвращает область видимости фигур
  ''' </summary>
  Public Function GetBound() As Rectangle
    If Me.Count <= 0 Then Return Rectangle.Empty

    Dim x, y, x2, y2 As Integer?

    For Each itm As FoxShape In Me
      If itm.ShapeType = Enums.ShapeType.Pen OrElse itm.ShapeType = Enums.ShapeType.Marker Then
        For Each p As Point In itm.Points
          If Not x.HasValue OrElse p.X < x.Value Then
            x = p.X
          End If
          If Not y.HasValue OrElse p.Y < y.Value Then
            y = p.Y
          End If
          If Not x2.HasValue OrElse p.X > x2.Value Then
            x2 = p.X
          End If
          If Not y2.HasValue OrElse p.Y > y2.Value Then
            y2 = p.Y
          End If
        Next
      ElseIf itm.ShapeType = Enums.ShapeType.Pixelate Then
        If Not x.HasValue OrElse itm.AbsX < x.Value Then
          x = itm.AbsX
        End If
        If Not y.HasValue OrElse itm.AbsY < y.Value Then
          y = itm.AbsY
        End If
        If Not x2.HasValue OrElse itm.AbsX > x2.Value Then
          x2 = itm.AbsX
        End If
        If Not y2.HasValue OrElse itm.AbsY > y2.Value Then
          y2 = itm.AbsY
        End If
      End If
    Next

    If Not (x.HasValue OrElse y.HasValue OrElse x2.HasValue OrElse y2.HasValue) Then Return Rectangle.Empty

    Return New Rectangle(x.Value, y.Value, x2.Value - x.Value, y2.Value - y.Value)
  End Function

  ''' <summary>
  ''' Remove Shapes by location / Удаляет все фигуры из коллекции, которые находятся в области видимости указанных координат
  ''' </summary>
  Public Sub RemoveByPoint(e As Point)
    If Me.Count <= 0 Then Return
    For i As Integer = 0 To Me.Count - 1
      If i > Me.Count - 1 Then Exit For 'exit / выходим, если i больше числа элементов
      Dim itm As FoxShape = Me(i)
      Dim allowRemove As Boolean = False
      If itm.ShapeType = Enums.ShapeType.Pen OrElse itm.ShapeType = Enums.ShapeType.Marker Then
        Dim k As Integer = 8 'factor to the cursor size / коэффициент на размер курсора (16px/2)
        For Each p As Point In itm.Points
          allowRemove = e.X >= p.X - k AndAlso e.X <= p.X + itm.Depth + k AndAlso e.Y >= p.Y - k AndAlso e.Y <= p.Y + itm.Depth + k 'в области линии
          If allowRemove Then Exit For
        Next
      ElseIf itm.ShapeType = Enums.ShapeType.Pixelate Then
        allowRemove = e.X >= itm.AbsX AndAlso e.X <= itm.AbsX + itm.AbsWidth AndAlso e.Y >= itm.AbsY AndAlso e.Y <= itm.AbsY + itm.AbsHeight  'в области прямоугольника
      End If

      If allowRemove Then
        'allow remove the Shape / добро на удаление
        Me.RemoveAt(i) 'remove / удаляем
        i -= 1 'set index to the back / индекс в зад, т.к. элемент удален
      End If
    Next
  End Sub

End Class
