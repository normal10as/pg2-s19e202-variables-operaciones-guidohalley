Imports System

Module Program

    Sub Main(args As String())
        Dim nombre As String
        Dim apellido As String
        Dim fecha As Date
        Console.WriteLine("ingrese su nombre")
        nombre = Console.ReadLine
        Console.WriteLine("Ingrese su apellido")
        apellido = Console.ReadLine
        Console.WriteLine("ingrese la Fecha")
        fecha = Console.ReadLine
        Console.WriteLine("Apellido: " & apellido)
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Nacio el: " & fecha)
    End Sub

End Module
