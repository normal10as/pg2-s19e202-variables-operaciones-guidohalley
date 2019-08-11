Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim suma As Integer
        Dim media As Integer
        Console.WriteLine(" Ingrese el valor 1: ")
        a = Console.ReadLine()
        Console.WriteLine(" Ingrese el valor 2: ")
        b = Console.ReadLine()
        Console.WriteLine(" Ingrese el valor 3: ")
        c = Console.ReadLine()
        Console.WriteLine(" Ingrese el valor 4: ")
        d = Console.ReadLine()
        suma = a + b + c + d
        media = suma / 4
        Console.WriteLine("la suma total de los valores ingresados son: " & suma)
        Console.WriteLine("el Promedio de los valores sumados es: " & media)


    End Sub
End Module
