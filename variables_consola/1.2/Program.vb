Imports System

Module variables_consola
    Sub Main(args As String())
        Dim nombre As String = "Guido"
        Dim dni As Long = 41273318
        Dim lugarnacimiento As String = "Posadas"
        Dim fechanacimiento As Date = "27-05-1998"
        Dim altura As Double = 1.73
        Dim nacionalidad As String = "Argentina"
        Dim temp As Short = 15
        Dim calle As String = "Calle 137 a"
        Dim distancia As Double = 175.7
        Dim profundidad As Double = 3.9
        Dim habitantes As Double = 1.175
        Dim peso As Single = 63
        Dim monto As Double = 850
        Console.WriteLine("Nombre: " + nombre)
        Console.WriteLine("DNI: " & dni)
        Console.WriteLine("Lugar de nacimiento: " + lugarnacimiento)
        Console.WriteLine("Fecha de nacimiento: " + fechanacimiento)
        Console.WriteLine("Altura: " & altura)
        Console.WriteLine("Nacionalidad: " + nacionalidad)
        Console.WriteLine("Temperatura de ambiente: " & temp)
        Console.WriteLine("Nombre de calle: " + calle)
        Console.WriteLine("Distancia entre Florianopolis y Rio de Janeiro: " & distancia)
        Console.WriteLine("Profundidad del mar: " & profundidad)
        Console.WriteLine("Cantidad de habitantes en Misiones: " & habitantes)
        Console.WriteLine("Peso de carne: " & peso)
        Console.WriteLine("Monto de pollo: " & monto)
        Console.ReadLine()
    End Sub
End Module