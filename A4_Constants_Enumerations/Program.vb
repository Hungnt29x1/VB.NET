Imports System

Module Program
    Enum Colors
        red = 1
        orange = 2
        yellow = 3
        green = 4
        azure = 5
        blue = 6
        violet = 7
    End Enum

    Sub Main(args As String())
        Console.WriteLine("------------------------CONSTANTS--------------------------")

        Const PI = 3.14149 ' Phải được gán giá định và giá trị này không thể thay đổi
        Dim radius, area As Single
        radius = 7
        area = PI * radius * radius
        Console.WriteLine("Area = " & area)

        Console.WriteLine("------------------------ENUM--------------------------")
        Console.WriteLine("The Color Red is : " & Colors.red)
        Console.WriteLine("The Color Yellow is : " & Colors.yellow)
        Console.WriteLine("The Color Blue is : " & Colors.blue)
        Console.WriteLine("The Color Green is : " & Colors.green)
        Console.ReadKey()
    End Sub
End Module
