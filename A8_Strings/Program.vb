Imports System

Module Program
    'Các phương thức chuỗi
    'Length: Trả về số ký tự trong chuỗi.
    'ToUpper: Chuyển đổi tất cả các ký tự trong chuỗi thành chữ hoa.
    'ToLower: Chuyển đổi tất cả các ký tự trong chuỗi thành chữ thường.
    'Trim: Loại bỏ khoảng trắng từ đầu và cuối chuỗi.
    'Substring: Trả về một phần của chuỗi bắt đầu từ một vị trí được chỉ định và có độ dài được chỉ định.


    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8
        '------------------------ Phương thức chuỗi -----------------------
        Dim str As String = "   xin chao   "
        Console.WriteLine(str.Length) ' kết quả là 15

        Dim str1 As String = "đÂy Là tOUpPer"
        Console.WriteLine(str1.ToUpper()) ' kết quả là "ĐÂY LÀ TOUPPER"

        Dim str2 As String = "đÂy Là tOLOweR"
        Console.WriteLine(str2.ToLower()) ' kết quả là "đây là tolower"

        Dim str3 As String = "   hello world   "
        Console.WriteLine(str3.Trim()) ' kết quả là "hello world"

        Dim str4 As String = "This is a string"
        Console.WriteLine(str4.Substring(5, 2)) ' kết quả là "is"

        '------------------------- Toán tử chuỗi -----------------------------
        ' Toán tử chia chuỗi (Split)
        Dim str5 As String = "Táo,Chuối,Xoài"
        Dim fruits() As String = str5.Split(",")
        For Each fruit As String In fruits
            Console.WriteLine(fruit)
        Next

        ' Toán tử so sánh chuỗi (<>):
        Dim str6 As String = "Hello"
        Dim str7 As String = "World"
        If str6 <> str7 Then
            Console.WriteLine("Chuỗi ko giống nhau.")
        End If

        'Toán tử nối chuỗi
        Dim str8 As String = str6 & " " & str7
        Console.WriteLine(str8) ' output: "Hello World"

        'Toán tử tìm kiếm chuỗi (IndexOf):
        Dim str9 As String = "Cô đơn trên sofa"
        Dim index As Integer = str9.IndexOf("trên")
        Console.WriteLine(index)

        'Toán tử thay thế chuỗi (Replace):
        Dim newStr As String = str9.Replace("trên", "dưới")
        Console.WriteLine(newStr) ' output: "The quick red fox"

    End Sub
End Module
