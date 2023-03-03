Imports System

Module Program
    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Dim b As Byte
        Dim n As Integer
        Dim si As Single
        Dim d As Double
        Dim da As Date
        Dim c As Char
        Dim s As String
        Dim bl As Boolean

        b = 1
        n = 1234567
        si = 0.12345678901234566
        d = 0.12345678901234566
        da = Today
        c = "U"c
        s = "Me"

        If s = "Me" Then
            bl = True
        Else
            bl = False
        End If

        If bl Then
            'the oath taking
            Console.Write(c & " và," & s & vbCrLf)
            Console.WriteLine("Ngày hôm nay: {0}", da)
            Console.WriteLine("Đây là kiểu Boolean : {0}", bl)
            Console.WriteLine("Đây là kiểu Byte: {0}", b)
            Console.WriteLine("The Single: {0}, The Double: {1}", si, d)
        Else
            Console.Write("Boolean = {0}", bl)
        End If
        Console.ReadKey()

    End Sub
End Module
