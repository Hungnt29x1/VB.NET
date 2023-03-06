Public Class StudentServices
    Private _lstStudent As List(Of Student)
    Private _student As Student

    Private _input As String

    Public Sub New()
        _lstStudent = New List(Of Student)
        fakeData()

    End Sub

    Private Sub fakeData()
        _lstStudent = New List(Of Student) From {
            New Student(1, "Hùng", 22, 1, "Fresher C#"),
            New Student(2, "Hải", 27, 1, "Fresher Java"),
            New Student(3, "Thảo", 22, 0, "Fresher PHP"),
            New Student(4, "Tiên", 22, 0, "Fresher Tester")
        }
    End Sub

    Public Sub GetLst()
        For Each item As Student In _lstStudent
            item.GetList()
        Next
    End Sub

    Public Sub Add()
        Console.WriteLine("Mời nhập số lượng muốn thêm: ")
        _input = Console.ReadLine()
        For i = 1 To CInt(_input) Step 1
            _student = New Student()
            Console.WriteLine("Mời nhập Id : ")
            _student.Id = CInt(Console.ReadLine())
            Console.WriteLine("Mời nhập Tên : ")
            _student.Ten = Console.ReadLine()
            Console.WriteLine("Mời nhập Tuổi : ")
            _student.Tuoi = CInt(Console.ReadLine())
            Console.WriteLine("Mời nhập giới tính : ")
            _student.GioiTinh = CInt(Console.ReadLine())
            Console.WriteLine("Mời nhập Lớp : ")
            _student.HocLop = Console.ReadLine()
            _lstStudent.Add(_student)
        Next
    End Sub

    Public Sub Edit()
        Console.Write("Mời nhập Id muốn sửa : ")
        _input = CInt(Console.ReadLine())
        For i = 1 To _lstStudent.Count Step 1
            If _lstStudent(i).Id = _input Then
                Console.WriteLine("1. Sửa tên")
                Console.WriteLine("2. Sửa tuổi")
                Console.WriteLine("3. Sửa giới tính")
                Console.WriteLine("4. Sửa lớp")
                _input = Console.ReadLine()
                Select Case _input
                    Case "1"
                        Console.WriteLine("Mời nhập lại tên: ")
                        _lstStudent(i).Ten = Console.ReadLine()
                    Case "2"
                        Console.WriteLine("Mời nhập lại tuổi: ")
                        _lstStudent(i).Tuoi = CInt(Console.ReadLine())
                    Case "3"
                        Console.WriteLine("Mời lại lại giới tính: ")
                        _lstStudent(i).GioiTinh = CInt(Console.ReadLine())
                    Case "4"
                        Console.WriteLine("Mời lại lại giới tính: ")
                        _lstStudent(i).HocLop = Console.ReadLine()
                End Select
                Console.WriteLine("Sửa thành công!")
                Return
            End If
        Next
        Console.WriteLine("Không tìm thấy")
    End Sub

    Public Sub Delete()
        Console.Write("Nhập Id muốn xóa : ")
        _input = Console.ReadLine()
        For i = 1 To _lstStudent.Count Step 1
            If _lstStudent(i).Id = CInt(_input) Then
                _lstStudent.RemoveAt(i)
                Console.WriteLine("Xóa thành công!")
                Return
            End If
        Next
        Console.WriteLine("Không tìm thấy?")
    End Sub

    Public Sub Search()
        Console.Write("Mời bạn nhập tên: ")
        _input = Console.ReadLine()
        For i = 1 To _lstStudent.Count Step 1
            If _lstStudent(i).Ten = _input Then
                _lstStudent(i).GetList()
                Return
            End If
        Next
        Console.WriteLine("không tìm thấy")
    End Sub
End Class
