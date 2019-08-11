Imports System

Module Program
    Sub Main(args As String())
        Dim m As Decimal
        Dim r As Decimal
        Dim t As Decimal
        Dim I As Integer
        Dim anio As Decimal = 360 * 100
        Console.Write("**cacluladora de interes**" & vbCrLf)
        Console.WriteLine("ingrese el Monto invertido: ")
        m = Console.ReadLine()
        Console.WriteLine("ingrese el interes anual: ")
        r = Console.ReadLine()
        Console.WriteLine("la cantidad de dias es: ")
        t = Console.ReadLine()
        I = (m * r * t) / anio
        Console.WriteLine("el interes anual invertido es: " & I)

    End Sub
End Module
