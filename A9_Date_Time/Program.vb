Imports System

Module Program
    'Now: Trả về thời điểm hiện tại, bao gồm cả ngày và giờ.
    'Today: Trả về ngày hiện tại mà không bao gồm giờ.
    'DateAdd: Thêm một khoảng thời gian cụ thể vào một ngày hoặc giờ.
    'DateDiff: Tính khoảng thời gian giữa hai ngày hoặc giờ.
    'Format: Định dạng ngày và giờ theo một định dạng cụ thể.
    'Month, Day, Year: Lấy giá trị tháng, ngày và năm từ một ngày cụ thể.

    Sub Main(args As String())
        Console.OutputEncoding = System.Text.Encoding.UTF8

        Dim currentDate As Date = Now
        Dim newDate As Date = DateAdd(DateInterval.Day, 7, currentDate) ' DateInterval là kiểu liệt kê (enum ) dùng để chị định khoảng thời gian giữa 2 ngày
        Dim diff As Long = DateDiff(DateInterval.Day, currentDate, newDate)
        Dim formattedDate As String = Format(currentDate, "dd/MM/yyyy")
        Dim month As Integer = currentDate.Month
        Dim day As Integer = currentDate.Day
        Dim year As Integer = currentDate.Year

        Console.WriteLine("Ngày và giờ hiện tại: " & currentDate)
        Console.WriteLine("Ngày mới sau khi thêm 7 ngày " & newDate)
        Console.WriteLine("Ngày giữa ngày hiện tại và ngày mới " & diff)
        Console.WriteLine("Format ngày: " & formattedDate)
        Console.WriteLine("Tháng: " & month)
        Console.WriteLine("Ngày: " & day)
        Console.WriteLine("Năm: " & year)
    End Sub
End Module
