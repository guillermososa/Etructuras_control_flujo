Module TP2_04_IF_Pruducto
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
        If cant < 10 Then
            pdesc = 0
        ElseIf cant <= 50 Then
            pdesc = 5
        ElseIf cant <= 250 Then
            pdesc = 10
        Else
            pdesc = 20
        End If
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