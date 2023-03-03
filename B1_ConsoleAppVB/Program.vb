Imports System

Module Program 'Module dùng để định nghĩa 1 module nào đó, và Program chính là tên của module cần định nghĩa.
    Sub Main(args As String()) 'Từ khóa Sub dùng để khai báo một hàm, và Main chính là tên của hàm cần khai báo. Hàm main() là một hàm đặc biệt, khi bạn chạy chương trình VB thì trình biên dịch sẽ chạy hàm nay đầu tiên.
        Console.WriteLine("Hello World!") ' xuất ra màn hình
        Console.WriteLine("Mời bạn nhập vớ vẩn vào.")
        'Console.ReadLine() ' Nhập vào màn hình
        Dim a As Integer = 20


        ' Test if else
        If a > 10 Then
            Console.WriteLine("True rồi")
        Else
            Console.WriteLine("False rồi")
        End If
        ' Test ElseIf
        If a = 10 Then
            Console.WriteLine("x bằng 10")
        ElseIf a > 10 Then
            Console.WriteLine("x lớn hơn 10")
        Else
            Console.WriteLine("x bé hơn 10")
        End If
        KieuDuLieu()



    End Sub 'End Sub chính là phần đóng hàm, tức là nội dung bên trong hàm sẽ bắt đầu bằng Sub Main() và kết thúc là End Sub.

    Sub KieuDuLieu()
        Dim id As Integer
        Dim name As String = "Đây là kiểu text"
        Dim percentage As Double = 10.2333 ' Kiểu số thực
        Dim percentage2 As Long = 10.2333 ' Kiểu số thực
        Dim gender As Char = "M"c
        Dim isVerified As Boolean
        id = 10.1
        isVerified = True
        Console.WriteLine("Integer:{0}", id)
        Console.WriteLine("String:{0}", name)
        Console.WriteLine("Double:{0}", percentage)
        Console.WriteLine("Long:{0}", percentage2)
        Console.WriteLine("Char:{0}", gender)
        Console.WriteLine("Boolean:{0}", isVerified)
        Console.ReadLine()
    End Sub
End Module
