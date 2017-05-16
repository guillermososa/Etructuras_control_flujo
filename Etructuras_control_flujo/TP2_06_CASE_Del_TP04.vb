Module TP2_06_CASE_Del_TP04
    Sub Main()
        'Declaracion de variables
        Dim cant, pdesc As Integer
        Dim punit, mdesc, subtotal, total As Double
        'Ingreso de datos
        Console.WriteLine("Ingrese Datos")
        Console.Write("Cantidad: ")
        cant = Console.ReadLine()
        Console.Write("Precio Unitario: ")
        punit = Console.ReadLine()
        'Compara
        Select Case cant
            Case Is >= 251
                pdesc = 20
            Case Is >= 51
                pdesc = 10
            Case Is >= 10
                pdesc = 5
            Case Else
                pdesc = 0
        End Select
        'Calcula
        subtotal = punit * cant
        mdesc = subtotal * (pdesc / 100)
        total = subtotal - mdesc
        'Muestra la informacion
        Console.WriteLine()
        Console.WriteLine("Subtotal: $" & subtotal)
        Console.WriteLine("Descuento aplicado: {0}%", pdesc)
        Console.WriteLine("Monto descuentado: $" & mdesc)
        Console.WriteLine("Total: $" & total)
        Console.ReadKey()
    End Sub
End Module