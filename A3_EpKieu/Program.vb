Imports System

Module Program
    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Dim num1 As Integer = 10
        Dim num2 As Double = 3.14
        Dim str As String = "42"
        Dim boolVal As Boolean = True

        ' Ép kiểu Integer sang Double
        Dim result1 As Double = CDbl(num1)

        ' Ép kiểu Double sang Integer
        Dim result2 As Integer = CInt(num2)

        ' Ép kiểu String sang Integer
        Dim result3 As Integer = CInt(str)

        ' Ép kiểu Boolean sang Integer
        Dim result4 As Integer = CInt(boolVal)

        ' Ép kiểu Integer sang String
        Dim result5 As String = CStr(num1)

        Console.WriteLine($"Ép kiểu Integer sang Double: {result1}")
        Console.WriteLine($"Ép kiểu Double sang Integer: {result2}")
        Console.WriteLine($"Ép kiểu String sang Integer: {result3}")
        Console.WriteLine($"Ép kiểu Boolean sang Integer: {result4}")
        Console.WriteLine($"Ép kiểu Integer sang String: {result5}")

    End Sub
End Module
