```vb
  Private Delegate Function EnumDelegate(hWnd As IntPtr, lParam As Integer) As Boolean

  <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
  Private Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
  End Function

  <DllImport("user32.dll", EntryPoint:="EnumDesktopWindows", ExactSpelling:=False, CharSet:=CharSet.Auto, SetLastError:=True)> _
  Private Shared Function EnumDesktopWindows(hDesktop As IntPtr, lpEnumCallbackFunction As EnumDelegate, lParam As IntPtr) As Boolean
  End Function

  <DllImport("user32.dll")> _
  Private Shared Function EnumWindows(lpEnumCallbackFunction As EnumDelegate, lParam As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
  End Function

  <DllImport("user32.dll", EntryPoint:="GetWindowText", ExactSpelling:=False, CharSet:=CharSet.Auto, SetLastError:=True)> _
  Private Shared Function GetWindowText(hWnd As IntPtr, lpWindowText As StringBuilder, nMaxCount As Integer) As Integer
  End Function

  Private Function GetWindowTitle(hWnd As IntPtr) As String
    Dim t As New StringBuilder(255)
    Dim len As Integer = GetWindowText(hWnd, t, t.Capacity + 1)
    Return t.ToString()
  End Function

  <DllImport("user32.dll", SetLastError:=True)> _
  Private Shared Function GetWindowRect(ByVal hWnd As IntPtr, <Out()> ByRef lpRect As RECT) As <MarshalAs(UnmanagedType.Bool)> Boolean
  End Function

  <StructLayoutAttribute(LayoutKind.Sequential)> _
  Private Structure RECT
    Public left As Integer
    Public top As Integer
    Public right As Integer
    Public bottom As Integer
  End Structure

  <DllImport("user32.dll", SetLastError:=True)> _
  Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
  End Function

  <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
  Public Shared Function GetDesktopWindow() As IntPtr
  End Function

  <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
  Private Shared Function GetForegroundWindow() As IntPtr
  End Function

  <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
  Private Shared Function GetWindow(ByVal hWnd As IntPtr, ByVal wCmd As String) As IntPtr
  End Function

  <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
  Private Shared Function GetTopWindow(ByVal hWnd As IntPtr) As IntPtr
  End Function

  <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
  Public Shared Function GetAncestor(ByVal hWnd As IntPtr, ByVal flags As Integer) As IntPtr
  End Function

  <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
  Public Shared Function IsWindow(ByVal hWnd As IntPtr) As Boolean
  End Function

  <DllImport("user32.dll", EntryPoint:="WindowFromPoint", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
  Public Shared Function WindowFromPoint(ByVal pt As SPOINT) As IntPtr
  End Function

  <StructLayout(LayoutKind.Sequential)> _
  Public Structure SPOINT
    Public X As Integer
    Public Y As Integer

    Public Sub New(x As Integer, y As Integer)
      Me.X = x
      Me.Y = y
    End Sub

    Public Shared Widening Operator CType(p As SPOINT) As System.Drawing.Point
      Return New System.Drawing.Point(p.X, p.Y)
    End Operator

    Public Shared Widening Operator CType(p As System.Drawing.Point) As SPOINT
      Return New SPOINT(p.X, p.Y)
    End Operator

  End Structure

  Private Function GetZOrder(hWnd As IntPtr) As Integer
    Dim z As Integer = 0
    Dim h As IntPtr = hWnd
    While h <> IntPtr.Zero
      System.Math.Max(System.Threading.Interlocked.Increment(z), z - 1)
      h = GetWindow(h, 3)
    End While
    Return z
  End Function
```
