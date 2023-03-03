Imports System

'Exception Handling (xử lý ngoại lệ) là một kỹ thuật quan trọng trong lập trình để xử lý các lỗi hoặc tình huống bất thường xảy ra trong quá trình thực thi chương trình
'Try định nghĩa một khối mã mà ngoại lệ có thể xảy ra trong đó
'Catch định nghĩa một khối mã được thực thi khi một ngoại lệ được bắt
'Nếu một ngoại lệ được bắt, chương trình sẽ bỏ qua mã trong khối try và thực thi mã trong khối catch tương ứng.
'Finally có thể được sử dụng để định nghĩa một khối mã được thực thi dù ngoại lệ có xảy ra hay không
'Sử dụng try-catch-finally giúp giảm thiểu tác động của các lỗi và ngoại lệ trong chương trình của bạn, giúp chương trình của bạn hoạt động ổn định và tin cậy hơn.

Module Program

    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Try
            ' Mã có thể xảy ra ngoại lệ
        Catch ex As Exception
            ' Xử lý ngoại lệ
        Finally
            ' Mã được thực thi bất kể ngoại lệ có xảy ra hay không
        End Try

        '----------------------------------------------------------
        Dim a As Integer = 5
        Dim b As Integer = 0
        Try
            Dim result As Integer = a \ b
            Console.WriteLine("Kết quả = " & result)
        Catch ex As Exception
            Console.WriteLine("Lỗi: " & ex.Message)
        Finally
            Console.WriteLine("Lỗi thì kệ lỗi")
        End Try
    End Sub
End Module
