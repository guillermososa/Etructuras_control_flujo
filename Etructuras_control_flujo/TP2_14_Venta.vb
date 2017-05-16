Module TP2_14_Venta
    Sub Main()
        'Declaracion de variables
        Dim cant, pdesc As Integer
        Dim punit, mdesc, subtotal, total, totaldesc, totalapagar As Double
        'Ingreso de datos
        Console.WriteLine("Ingrese Datos")
        Console.WriteLine()
        Do
            Console.Write("Cantidad: ")
            cant = Console.ReadLine()
            If cant <> 0 Then
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
                totaldesc += mdesc
                totalapagar += total
                'Muestra la informacion
                Console.WriteLine("Subtotal: $" & subtotal)
                Console.WriteLine("Descuento aplicado: {0}%", pdesc)
                Console.WriteLine("Monto descuentado: $" & mdesc)
                Console.WriteLine("Total: $" & total)
                Console.WriteLine()
            End If
        Loop While cant <> 0
        Console.WriteLine("Total descuentado: $" & totaldesc)
        Console.WriteLine("Total a pagar: $" & totalapagar)
        Console.ReadKey()
    End Sub
End Module