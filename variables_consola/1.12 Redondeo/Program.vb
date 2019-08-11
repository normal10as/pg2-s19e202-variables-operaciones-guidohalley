Imports System.Math


Module Program
    Sub Main(args As String())
        Dim a As Decimal
        Dim b As Decimal
        Console.WriteLine("Ingrese el Numero a Calcular el redonde: ")
        a = Console.ReadLine()
        b = Math.Round(a)
        Console.WriteLine("El numero calculado es: " & b)
    End Sub
End Module
