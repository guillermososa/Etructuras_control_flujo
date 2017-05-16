Module TP2_01_IF_Relacion
    Sub Main()
        'Declaracion de variables
        Dim valor1, valor2 As Integer
        'Ingreso de datos
        Console.Write("Ingrese primer valor: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese segundo valor: ")
        valor2 = Console.ReadLine()
        'Validar y mostrar informacion
        Console.WriteLine()
        If valor1 > valor2 Then
            Console.WriteLine("El primer valor es mayor")
        ElseIf valor2 > valor1 Then
            Console.WriteLine("El segundo valor es mayor")
        Else
            Console.WriteLine("Los numeros son iguales")
        End If
        Console.ReadKey()
    End Sub
End Module