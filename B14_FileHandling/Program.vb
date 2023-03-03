Imports System
Imports System.IO

'File Handling (xử lý tập tin) trong VB.NET là quá trình đọc và ghi dữ liệu vào tệp

Module Program
    Sub Main(args As String())
        'FileStream . Ví dụ : Mở một tệp văn bản có tên là "test.txt" để đọc dữ liệu từ tệp này:
        'Dim fileStream As FileStream = New FileStream("test.txt", FileMode.Open, FileAccess.Read)
        'Dim reader As StreamReader = New StreamReader(fileStream)
        'Dim text As String = reader.ReadToEnd()
        'reader.Close()
        'fileStream.Close()

        'tạo một đối tượng FileStream với tên tệp "test.txt" và mở tệp đó với FileAccess.Read
        'Sau đó tạo một đối tượng StreamReader để đọc nội dung của tệp và gán nó cho biến text
        'Cuối cùng, chúng ta đóng tệp và đối tượng đọc của mình.
        '-----------------------------------------

        'FileInfo và Directory để thực hiện các thao tác với tệp và thư mục.
        'Ví dụ dưới đây sử dụng lớp FileInfo để kiểm tra xem một tệp có tồn tại hay không
        Dim file As FileInfo = New FileInfo("test.txt")
        If File.Exists Then
            Console.WriteLine("File tồn tại")
        Else
            Console.WriteLine("File không tồn tại")
        End If


        'Để đọc nội dung của một tập tin, có thể sử dụng lớp FileStream để mở tập tin, sau đó sử dụng lớp StreamReader để đọc các dòng của tập tin và lưu trữ nội dung vào một biến chuỗi:
        Dim filePath As String = "‪D:\Test.txt"

        ' Tạo đối tượng FileStream để mở tập tin
        Dim fileStream1 As New FileStream(filePath, FileMode.Open)

        ' Tạo đối tượng StreamReader để đọc các dòng của tập tin
        Dim streamReader As New StreamReader(fileStream1)

        ' Đọc các dòng của tập tin và lưu trữ nội dung vào biến chuỗi
        Dim content As String = streamReader.ReadToEnd()

        ' Đóng luồng đọc và tập tin
        streamReader.Close()
        fileStream1.Close()

        ' Để ghi nội dung vào một tập tin,có thể sử dụng lớp StreamWriter để tạo một đối tượng ghi và sử dụng phương thức Write hoặc WriteLine để ghi nội dung vào tập tin

        ' Tạo đối tượng StreamWriter để ghi nội dung vào tập tin
        Dim streamWriter As New StreamWriter(filePath, True)

        ' Ghi nội dung vào tập tin
        streamWriter.WriteLine("Hello, world!")

        ' Đóng luồng ghi
        streamWriter.Close()


    End Sub
End Module
