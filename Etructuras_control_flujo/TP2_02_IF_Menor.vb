Module TP2_02_IF_Menor
    Sub Main()
        'Declaracion de variables
        Dim valor1, valor2, valor3 As Integer
        'Ingreso de datos
        Console.Write("Ingrese primer valor: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese segundo valor: ")
        valor2 = Console.ReadLine()
        Console.Write("Ingrese tercer valor: ")
        valor3 = Console.ReadLine()
        'Validar y mostrar informacion
        Console.WriteLine()
        If valor1 < valor2 And valor1 < valor3 Then
            Console.WriteLine("El valor {0} es menor", valor1)
        ElseIf valor2 < valor3 Then
            Console.WriteLine("El valor {0} es menor", valor2)
        Else
            Console.WriteLine("El valor {0} es menor", valor3)
        End If
        Console.ReadKey()
    End Sub
End Module