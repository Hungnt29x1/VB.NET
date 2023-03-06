Public Class Student
    Inherits Person
    Public _hoclop As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal ten As String, ByVal tuoi As Integer, ByVal gioitinh As Integer, ByVal hoclop As String)
        MyBase.New(id, ten, tuoi, gioitinh)
        _hoclop = hoclop
    End Sub

    Public Property HocLop As String
        Get
            Return _hoclop
        End Get
        Set(value As String)
            _hoclop = value
        End Set
    End Property

    Public Overrides Sub GetList()
        Console.WriteLine($"Id {_id} | Tên : {_ten} | Tuổi : {_tuoi} | Giới Tính : {_gioiTinh}")
    End Sub
End Class
