Imports System

Module Program
    Sub Main(args As String())
        Dim Division As Integer
        Dim resto As Integer
        Console.WriteLine("Ingrese un Numero entero: ")
        Division = Console.ReadLine
        resto = Division / 2
        Console.WriteLine("El resto del numero es: " & resto)
    End Sub
End Module
