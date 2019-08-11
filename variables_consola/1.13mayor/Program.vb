Imports System

Module Program
    Sub Main(args As String())
        Dim a As Byte
        Dim b As Byte
        Dim c As Byte
        Dim d As Integer
        Dim e As Integer
        Console.WriteLine("Inregse el valor de a: ")
        a = Console.ReadLine()
        Console.WriteLine("Inregse el valor de b: ")
        b = Console.ReadLine
        Console.WriteLine("Inregse el valor de c: ")
        c = Console.ReadLine
        If a > b And c Then
            Console.Write("El Numero Mayor es: " & a)
        Else
            d = Math.Max(b, c)
            Console.Write("El Numero Mayor es " & d)
        End If
    End Sub
End Module
