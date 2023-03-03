Imports System

Module Program
    'Để khai báo một mảng trong VB.NET, sử dụng từ khóa Dim theo cú pháp
    '           Dim arrayName(size) As dataType
    'Trong đó:
    'arrayName: Tên của mảng.
    'size: Số lượng phần tử trong mảng.
    'dataType: Kiểu dữ liệu của các phần tử trong mảng.

    '------------------------- Dynamic Arrays - Mảng động ----------------------
    'dynamic arrays là một loại mảng mà kích thước của nó có thể được thay đổi tại thời điểm thực thi của chương trình.
    'Để tạo một dynamic array, sử dụng từ khóa ReDim.


    '--------------------------Multi-Dimensional Arrays - Mảng đa chiều ---------------------------------
    '- Được sử dụng để lưu trữ và quản lý các tập hợp dữ liệu có cấu trúc đa chiều.
    '- Cú pháp khai báo một mảng nhiều chiều trong VB.NET như sau:
    '               Dim arrayName(size1, size2, size3, ..., sizeN) As dataType
    'Trong đó:
    'arrayName là tên của mảng.
    'size1, size2, size3, ..., sizeN là kích thước của mỗi chiều của mảng.
    'dataType là kiểu dữ liệu của các phần tử trong mảng.



    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Dim a(4) As Integer ' Mảng a 5 phần tử (a(0), a(1), a(2), a(3) và a(4)) và kiểu dữ liệu là Integer.
        '-----Để truy cập các phần tử trong mảng, sử dụng chỉ số của chúng. Ví dụ:
        a(0) = 10
        a(1) = 20
        a(2) = 30
        a(3) = 40
        a(4) = 50
        'Để lặp qua các phần tử trong một mảng, có thể sử dụng vòng lặp For hoặc For Each. Ví dụ:
        'Sử dụng vòng lặp For
        For i As Integer = 0 To 4
            a(i) = i * 10
            Console.WriteLine("Check: {0}", a(4))
        Next

        ' Sử dụng vòng lặp For Each
        Dim numbers() As Integer = {10, 20, 30, 40, 50}
        For Each number As Integer In numbers
            Console.WriteLine("arrays: {0}", number)
        Next

        '-------------------------------- Mảng động ---------------------------------
        Console.WriteLine("---------------------------Mảng động ----------------------------")
        Dim b() As Integer

        ' Khởi tạo mảng với kích thước ban đầu là 3
        ReDim b(2)
        b(0) = 1
        b(1) = 2
        b(2) = 3

        ' Thêm phần tử vào mảng
        ReDim Preserve b(3) ' ReDim Preserve để thêm một phần tử mới vào mảng và giữ nguyên các giá trị cũ của mảng.
        b(3) = 4

        ' Thay đổi kích thước của mảng
        ReDim Preserve b(4) 'Lại sử dụng ReDim Preserve để tăng kích thước của mảng lên 5 và thêm một phần tử mới vào mảng
        b(4) = 5
        For Each item As Integer In b
            Console.WriteLine("Redim check: {0}", item)
        Next

        '---------------------------------- Mảng đa chiều
        'VD: Ví dụ, để khai báo một mảng hai chiều (2x3) kiểu Integer 
        Console.WriteLine("---------------------------Mảng đa chiều ----------------------------")
        Dim c(1, 2) As Integer
        c(0, 0) = 10

        For i As Integer = 0 To 1
            For j As Integer = 0 To 2
                Console.Write("{0} ", c(i, j))
            Next j
            Console.WriteLine()
        Next i

        '-----------------------------------Một vài Method of The Array class----------------------
        Console.WriteLine("------------------------Một vài Method --------------------------")
        Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}
        Dim temp As Integer() = list
        Dim d As Integer
        Console.Write("Mảng ban đầu: ")

        For Each i In list
            Console.Write("{0} ", i)
        Next i

        Console.WriteLine()
        ' reverse the array
        Array.Reverse(temp)
        Console.Write("Sử dụng Reverse Array: ") ' Đảo ngược lại

        For Each i In temp
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        'sort the array
        Array.Sort(list)
        Console.Write("Sử dung Sort Array: ") ' Sắp xếp

        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()
    End Sub
End Module
