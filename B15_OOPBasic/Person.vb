Public Class Person
    Public _id As Integer
    Public _ten As String
    Public _tuoi As Integer
    Public _gioiTinh As Integer

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, ten As String, tuoi As Integer, gioitinh As Integer)
        _id = id
        _ten = ten
        _tuoi = tuoi
        _gioiTinh = gioitinh
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Ten As String
        Get
            Return _ten
        End Get
        Set(value As String)
            _ten = value
        End Set
    End Property

    Public Property Tuoi As Integer
        Get
            Return _tuoi
        End Get
        Set(value As Integer)
            _tuoi = value
        End Set
    End Property

    Public Property GioiTinh As Integer
        Get
            Return _gioiTinh
        End Get
        Set(value As Integer)
            _gioiTinh = value
        End Set
    End Property

    Public Overridable Sub GetList() ' Overridable giống virtrual bên C#
        Console.WriteLine("Đây là lớp cha")
    End Sub
End Class
