Imports System

Module Program
    'Collections là một tập hợp các đối tượng có thể chứa nhiều phần tử của các kiểu dữ liệu khác nhau. Các Collections cung cấp các phương thức và thuộc tính để quản lý và truy xuất các phần tử trong nó.
    'Có nhiều loại Collections khác nhau trong VB.NET như List, ArrayList, Stack, Queue, Hashtable, SortedList, và Dictionary.
    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8

        '-------------List-------------
        Console.WriteLine("-------------------------LIST-------------------------")
        Dim a As New List(Of Integer)
        a.Add(1)
        a.Add(2)
        a.Add(3)
        a.Add(4)
        a.Add(5)
        For Each item As Integer In a
            Console.WriteLine("Đây là List : {0}", item)
        Next

        '-------------ArrayList-------------
        Console.WriteLine("-------------------------ARRAYLIST-------------------------")
        Dim list As New ArrayList()
        list.Add("Táo")
        list.Add("Chuối")
        list.Add("Xoài")
        For Each item As String In list
            Console.WriteLine("Đây là ArrayList : {0}", item)
        Next

        'Stack - phần tử được thêm vào cuối cùng sẽ được lấy ra đầu tiên.
        Console.WriteLine("-------------------------Stack-------------------------")
        Dim stack As New Stack(Of Integer)
        stack.Push(1)
        stack.Push(2)
        stack.Push(3)
        Console.WriteLine(stack.Pop())
        Console.WriteLine(stack.Pop())
        Console.WriteLine(stack.Pop())

        'Queue- phần tử được thêm vào trước tiên sẽ được lấy ra đầu tiên.
        Console.WriteLine("-------------------------Queue-------------------------")
        Dim queue As New Queue(Of Integer)
        queue.Enqueue(1)
        queue.Enqueue(2)
        queue.Enqueue(3)
        Console.WriteLine(queue.Dequeue())
        Console.WriteLine(queue.Dequeue())
        Console.WriteLine(queue.Dequeue())

        'Hashtable : là một cấu trúc dữ liệu sử dụng khóa - giá trị, trong đó mỗi khóa được băm để tìm kiếm giá trị tương ứng . Hashtable không đảm bảo thứ tự của các phần tử.
        Console.WriteLine("-------------------------Hashtable-------------------------")
        Dim hashtable As New Hashtable()
        hashtable.Add("Ten", "Hùng")
        hashtable.Add("Tuoi", 22)
        hashtable.Add("QuocGia", "Việt Nam")
        Console.WriteLine(hashtable("Ten"))
        Console.WriteLine(hashtable("Tuoi"))
        Console.WriteLine(hashtable("QuocGia"))

        'SortedList:  là một cấu trúc dữ liệu khác sử dụng khóa - giá trị, tuy nhiên các phần tử được sắp xếp theo thứ tự của khóa
        Console.WriteLine("-------------------------SortedList-------------------------")
        Dim sortedList As New SortedList()
        sortedList.Add("Ba", 3)
        sortedList.Add("Một", 1)
        sortedList.Add("Bốn", 4)
        sortedList.Add("Hai", 2)
        For Each item As String In sortedList.Keys
            Console.WriteLine(item & ": " & sortedList(item))
        Next

        '------------------Dictionary-----------------
        Console.WriteLine("-------------------------Dictionary-------------------------")
        Dim dictionary As New Dictionary(Of String, Integer)
        dictionary.Add("Một", 1)
        dictionary.Add("Hai", 2)
        dictionary.Add("Ba", 3)
        For Each item As String In dictionary.Keys
            Console.WriteLine(item & ": " & dictionary(item))
        Next




    End Sub
End Module
