Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer = 1
        Dim b As Integer = 5
        Dim c As Integer = 2
        Dim e As Integer
        e = (b * b) - (4 * a * c) / (2 * a)
        Console.WriteLine("el restulado obtenido es: " & e)
    End Sub
End Module
