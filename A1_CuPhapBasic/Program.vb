Imports System

'Module Program
'    Sub Main(args As String())
'        Console.WriteLine("Hello World!")
'    End Sub
'End Module

Public Class Rectangle ' định nghĩa lớp Rectangle.
    Private length As Double ' trường dữ liệu  trong lớp Rectangle
    Private width As Double  ' trường dữ liệu   trong lớp Rectangle

    'Public methods
    Public Sub AcceptDetails() 'Public Sub: định nghĩa một phương thức public không trả về giá trị nào.
        length = 4.5
        width = 3.5
    End Sub

    Public Function GetArea() As Double ' Public Function định nghĩa một phương thức public trả về một giá trị.
        GetArea = length * width
    End Function

    Public Sub Display() 'Public Sub: định nghĩa một phương thức public không trả về giá trị nào.
        Console.WriteLine("Length: {0}", length)
        Console.WriteLine("Width: {0}", width)
        Console.WriteLine("Area: {0}", GetArea())

    End Sub

    Shared Sub Main() ' định nghĩa một phương thức tĩnh (static method), được chia sẻ và sử dụng trong toàn bộ ứng dụng.
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Dim r As New Rectangle() ' Khởi tạo 1 đối tượng
        Dim nhap As String ' Khai báo 1 biến
        Console.Write("Mời bạn nhập tên bạn:")
        nhap = Console.ReadLine()
        Console.WriteLine("Xin chào: {0}", nhap)
        r.AcceptDetails()
        r.Display()
        Dim a As New Class1()
        Console.ReadLine()
    End Sub
End Class
