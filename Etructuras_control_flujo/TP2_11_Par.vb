Module TP2_11_Par
    Sub Main()
        'Declaracion de variables
        Dim valor, cantpar, cantimpar As Integer
        cantpar = 0
        cantimpar = 0
        'Ingreso de datos y calculos
        Console.WriteLine("Ingreso de Datos")
        Do
            Console.Write("Ingrese valores enteros:")
            valor = Console.ReadLine()
            If valor > 0 Then
                If valor Mod 2 = 0 Then
                    cantpar += 1
                Else
                    cantimpar += 1
                End If
            End If
        Loop While valor <> 0
        'Validar y mostrar informacion
        Console.WriteLine()
        If cantpar <> 0 And cantimpar <> 0 Then
            Console.WriteLine("Total de valores pares: " & cantpar)
            Console.WriteLine("Total de valores impares: " & cantimpar)
        Else
            If cantimpar = 0 Then
                Console.WriteLine("Todos los valores son pares")
            Else
                Console.WriteLine("Todos los valores son impares")
            End If
        End If
        Console.ReadKey()
    End Sub
End Module