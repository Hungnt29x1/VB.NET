Imports System

'1. Toán tử số học:
'Toán tử cộng (+): dùng để cộng hai giá trị số hoặc nối hai chuỗi.
'Toán tử trừ (-): dùng để trừ giá trị số.
'Toán tử nhân (*): dùng để nhân hai giá trị số.
'Toán tử chia (/): dùng để chia giá trị số. Kết quả sẽ là một số thực nếu một trong hai toán hạng là số thực.
'Toán tử chia lấy phần dư (Mod): dùng để tính phần dư của phép chia hai số nguyên.
'2. Toán tử so sánh:
'Toán tử bằng (=): dùng để so sánh bằng giữa hai giá trị.
'Toán tử khác (<>) hoặc (Not =): dùng để so sánh khác giữa hai giá trị.
'Toán tử lớn hơn (>), lớn hơn hoặc bằng (>=), nhỏ hơn (<), nhỏ hơn hoặc bằng (<=): dùng để so sánh giữa hai giá trị số.
'Toán tử And: dùng để kiểm tra điều kiện đúng cho cả hai biểu thức.
'Toán tử Or: dùng để kiểm tra điều kiện đúng cho ít nhất một trong hai biểu thức.
'Toán tử Not: dùng để đảo ngược giá trị của biểu thức.
'3. Toán tử logic:
'Toán tử And: dùng để kết hợp hai biểu thức logic, kết quả sẽ trả về True nếu cả hai biểu thức đều True.
'Toán tử Or: dùng để kết hợp hai biểu thức logic, kết quả sẽ trả về True nếu một trong hai biểu thức đúng.
'Toán tử Not: dùng để đảo ngược giá trị của biểu thức logic.
'Toán tử chuỗi:
'Toán tử nối chuỗi (&): dùng để nối hai chuỗi với nhau.

Module Program
    Sub Main(args As String())

        '------------------------- Toán tử số học ------------------------------
        Dim a As Integer = 5
        Dim b As Integer = 3
        Dim c As Integer
        c = a + b 'c sẽ có giá trị 8
        c = a - b 'c sẽ có giá trị 2
        c = a * b 'c sẽ có giá trị 15
        c = a / b  'c sẽ có giá trị 1 (kết quả là số nguyên) 
        Dim d As Double = a Mod b
        Console.WriteLine(d)
        c = a Mod b 'c sẽ có gi

        '------------------------- Toán tử so sánh -----------------------------
        Dim a1 As Integer = 5
        Dim b1 As Integer = 10
        Dim c1 As Integer = 5

        If a1 < b1 Then
            Console.WriteLine("a1 nhỏ hơn b1")
        End If

        If a1 > b1 Then
            Console.WriteLine("a1 lớn hơn b1")
        End If

        If a1 <= c1 Then
            Console.WriteLine("a1 nhỏ hơn hoặc bằng c1")
        End If

        If a1 >= c1 Then
            Console.WriteLine("a1 lớn hơn hoặc bằng c1")
        End If

        If a1 = c1 Then
            Console.WriteLine("a1 bằng c1")
        End If

        If a1 <> b1 Then
            Console.WriteLine("a1 không bằng b1")
        End If

        '-----------------------Toán tử logic -------------------------------------
        Dim a2 As Boolean = True
        Dim b2 As Boolean = False

        If a2 AndAlso b2 Or a2 = b2 Then
            Console.WriteLine("Cả a2 và b2 đều đúng")
        ElseIf a2 OrElse b2 Then
            Console.WriteLine("a2 hoặc b2 đúng")
        ElseIf Not b2 Then
            Console.WriteLine("b is false")
        End If
    End Sub
End Module
