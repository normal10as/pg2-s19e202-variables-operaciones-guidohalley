
Imports System.DateTime
Module Ajustar_reloj
    Sub Main(args As String())
        Dim Dia, Hora As Byte
        Dim fecha As Date
        Console.Write("Ingresar dia: ")
        Dia = Console.ReadLine()
        Console.Write("Ingresar hora: ")
        Hora = Console.ReadLine()
        fecha = New DateTime(Now.Year, Now.Month, Dia, Hora, Now.Minute, Now.Second)
        Console.Write("La fecha Ajustada es: " & fecha)
    End Sub
End Module