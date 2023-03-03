Imports System

Module Program
    ' Vòng lặp For: dùng để thực hiện một khối lệnh một số lần cụ thể.
    'Cú pháp:
    '           For counter As Integer = start To end Step stepSize
    '               Statements to be executed inside the loop
    '           Next
    '    Trong đó:
    '- counter là tên biến đếm.
    '- start là giá trị khởi đầu của biến đếm.
    '- End là giá trị kết thúc của biến đếm.
    '- stepSize là giá trị thay đổi của biến đếm sau mỗi lần lặp (mặc định là 1 nếu không có chỉ định).

    ' Vòng lặp While: dùng để thực hiện một khối lệnh trong khi một điều kiện cụ thể là True
    'Cú pháp: 
    '           While condition
    '              Statements to be executed inside the loop
    '           End While
    'Trong đó condition là biểu thức logic trả về True hoặc False

    'Vòng lặp Do While: tương tự như vòng lặp While, nhưng khối lệnh được thực hiện trước khi kiểm tra điều kiện.
    'Cú pháp 
    '           Do
    '               Statements to be executed inside the loop
    '           Loop While condition
    ' Trong đó condition là biểu thức logic trả về True hoặc False.

    'Vòng lặp Do Until: tương tự như vòng lặp Do While, nhưng khối lệnh được thực hiện cho đến khi điều kiện là True.
    ' Cú pháp: 
    '           Do
    '               Statements to be executed inside the loop
    '           Loop Until condition
    ' Trong đó condition là biểu thức logic trả về True hoặc False.

    'Vòng lặp For Each: dùng để lặp qua các phần tử trong một tập hợp.
    'Cú pháp:
    '           For Each element In collection
    '               Statements to be executed inside the loop
    '           Next
    'Trong đó element là biến lưu trữ giá trị của mỗi phần tử trong tập hợp, và collection là tập hợp các phần tử.
    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8

        ' Vòng lặp For
        For i As Integer = 1 To 10 Step 1 ' Step là bước nhảy --> Step 1 => Bước nhảy giá trị 1
            Console.WriteLine("Đây là for: {0}", i)
        Next
        Console.WriteLine("--------------------------------------")
        ' Vòng lặp While
        Dim j As Integer = 1
        While j <= 10
            Console.WriteLine("Đây là While : {0}", j)
            j += 1
        End While
        Console.WriteLine("--------------------------------------")

        ' Vòng lặp Do While
        Dim k As Integer = 1
        Do
            Console.WriteLine("Đây là Do While: {0}", k)
            k += 1
        Loop While k <= 10
        Console.WriteLine("--------------------------------------")

        ' Vòng lặp Do Until
        Dim l As Integer = 1
        Do
            Console.WriteLine("Đây là Do Until: {0}", l)
            l += 1
        Loop Until l > 2

        ' Vòng lặp For Each
        Dim numbers() As Integer = {1, 2, 3, 4, 5}
        Dim sum As Integer = 0
        Console.WriteLine("--------------------------------------")

        For Each number As Integer In numbers
            Console.Write("{0} ", number)
        Next
        Console.WriteLine("Tổng của fore: " & sum)
    End Sub
End Module
