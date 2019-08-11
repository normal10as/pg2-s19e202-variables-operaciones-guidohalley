Imports System.Math


Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer = 10
        Console.WriteLine("Ingrese un numero para saber las operaciones: ")
        a = Console.ReadLine()
        b = Math.Abs(a)
        Console.WriteLine("el valor absoluto de el numero ingresado es: " & b) '2'
        c = Math.Pow(x:=a, y:=10)
        Console.WriteLine("El valor del numero elevado a la 10 es: " & c) '1024'
        d = Math.Sqrt(a)
        Console.WriteLine("La raiz cuadra de el Numero Ingresado es: " & d) '1.41'
    End Sub
End Module
