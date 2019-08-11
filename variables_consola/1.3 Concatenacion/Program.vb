Imports System

Module Program
    Sub Main(args As String())
        Dim nombredeempresa As String = "Guidocorporation"
        Dim nombredecalle As String = "uruguay"
        Dim altura As Integer = 7322
        Dim fechainicio As Date = "11/05/2019"
        Console.WriteLine(nombredeempresa & nombredecalle & altura)
        Console.WriteLine(" Segunda Impresion ")
        Console.WriteLine(Convert.ToString({nombredeempresa}))
        Console.WriteLine(Convert.ToString({nombredecalle}))
        Console.WriteLine(Convert.ToString({altura}))
    End Sub
End Module
