Imports System
'Lớp(Class) là một mô-đun trong VB.NET, nó chứa các thành phần dữ liệu và phương thức để xử lý dữ liệu đó. Lớp là một bản thiết kế cho một đối tượng cụ thể.

'Đối tượng(Object) là một thực thể của một lớp cụ thể. Nó bao gồm các thành phần dữ liệu và phương thức của lớp đó.

'Một lớp được định nghĩa bằng từ khóa Class, theo sau là tên của lớp và khối lệnh chứa các thành phần của lớp.

'Trong lớp, chúng ta có thể khai báo các thuộc tính (Property), các phương thức (Method), các sự kiện (Event), các hàm tạo (Constructor) và các hàm huỷ (Destructor).

'Để tạo một đối tượng, chúng ta cần sử dụng từ khóa New để khởi tạo đối tượng từ lớp tương ứng. Sau đó, chúng ta có thể truy cập các thành phần của đối tượng thông qua dấu chấm (.) và tên thành phần.

'Chúng ta có thể thừa kế (Inheritance) các thành phần của một lớp bằng cách sử dụng từ khóa Inherits và tên của lớp cha. Lớp con (Derived Class) sẽ kế thừa các thành phần của lớp cha (Base Class).

'Một lớp có thể triển khai (Implement) một hoặc nhiều Interface. Interface là một tập hợp các phương thức và thuộc tính mà một lớp phải triển khai nếu lớp đó triển khai Interface đó.

'Một lớp có thể khai báo các thành phần với phạm vi truy cập khác nhau bằng các từ khóa Public, Private, Protected, Friend và Protected Friend.

'Chúng ta có thể sử dụng từ khóa Shared để khai báo một thành phần là tĩnh (Static), có thể truy cập trực tiếp thông qua tên lớp mà không cần tạo một đối tượng từ lớp đó.

'Một lớp có thể khai báo các thuộc tính chỉ đọc (ReadOnly Property) và thuộc tính chỉ ghi (WriteOnly Property). Thuộc tính chỉ đọc chỉ có thể đọc giá trị của thuộc tính đó, còn thuộc tính chỉ ghi chỉ có thể ghi giá trị cho thuộc tính đó.


'-----------------------------Ví Dụ--------------------------------------
Public Class Car
    Private _make As String
    Private _model As String
    Private _year As Integer

    Public Property Make As String
        Get                          ' Phương thức Get được sử dụng để trả về giá trị của thuộc tính
            Return _make
        End Get
        Set(value As String)         ' Phương thức Set được sử dụng để gán giá trị cho thuộc tính.
            _make = value
        End Set
    End Property

    Public Property Model As String
        Get
            Return _model
        End Get
        Set(value As String)
            _model = value
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Public Sub New(make As String, model As String, year As Integer)
        _make = make
        _model = model
        _year = year
    End Sub

    Public Function GetInfo() As String
        Return String.Format("{0} {1} ({2})", _make, _model, _year)
    End Function
End Class

'Giải thích:
'Trong ví dụ này, chúng ta định nghĩa một lớp Car với các thuộc tính _make, _model, _year được khai báo là Private (không truy cập được từ bên ngoài lớp) và được truy cập thông qua các thuộc tính Make, Model, Year có tính chất Public. Chúng ta cũng định nghĩa một phương thức New để khởi tạo giá trị ban đầu cho các thuộc tính, và một phương thức GetInfo để trả về thông tin về đối tượng Car dưới dạng chuỗi


'-------------------------------------------------------------

Module Program
    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Dim myCar As New Car("Toyota", "Camry", 2022)
        Console.WriteLine(myCar.GetInfo())
    End Sub
End Module
