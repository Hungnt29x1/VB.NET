Imports System

Module Program
    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8

        'Dim service As StudentServices = New StudentServices() ' Cách 1
        Dim service As New StudentServices()
        Dim _input As String
        Do
            Console.WriteLine("1. In danh sách")
            Console.WriteLine("2. Thêm danh sách")
            Console.WriteLine("3. Sửa danh sách")
            Console.WriteLine("4. Xóa")
            Console.WriteLine("5. Tìm")
            Console.WriteLine("6. Thoát")
            Console.Write("Mời bạn chọn ")
            _input = Console.ReadLine()
            Select Case _input
                Case "1"
                    service.GetLst()

                Case "2"
                    service.Add()
                Case "3"
                    service.Edit()
                Case "4"
                    service.Delete()
                Case "5"
                    service.Search()
                Case "6"
                    Return
                Case Else
                    Console.WriteLine("Mời chọn lại")
            End Select

        Loop While True

    End Sub
End Module
