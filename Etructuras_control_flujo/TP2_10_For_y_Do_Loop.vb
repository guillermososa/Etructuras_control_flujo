Module TP2_10_For_y_Do_Loop
    Sub Main()
        'Declaracion de variables
        Dim num1, num2 As Double
        Dim i, cont As Integer
        'Primer ingreso de datos
        Do
            Console.Clear()
            Console.WriteLine("Ingrese 2 valores")
            Console.Write("Valor 1: ")
            num1 = Console.ReadLine()
            Console.Write("Valor 2: ")
            num2 = Console.ReadLine()
            Console.WriteLine()
        Loop Until num1 < num2
        cont = 0
        For i = num1 To num2
            If i Mod 5 = 0 Then
                cont += 1
            End If
        Next
        Console.WriteLine("Existe {0} multiplos de 5 entre {1} y {2}.", cont, num1, num2)
        Console.ReadKey()
        'Segundo ingreso de datos
        Do
            Console.Clear()
            Console.WriteLine("Ingrese 2 valores")
            Console.Write("Valor 1: ")
            num1 = Console.ReadLine()
            Console.Write("Valor 2: ")
            num2 = Console.ReadLine()
            Console.WriteLine()
        Loop While num1 > num2
        cont = 0
        For i = num1 To num2
            If i Mod 5 = 0 Then
                cont += 1
            End If
        Next
        Console.WriteLine("Existe {0} multiplos de 5 entre {1} y {2}.", cont, num1, num2)
        Console.ReadKey()
        'Tercer ingreso de datos
        num1 = 2
        num2 = 1
        Do While num1 > num2
            Console.Clear()
            Console.WriteLine("Ingrese 2 valores")
            Console.Write("Valor 1: ")
            num1 = Console.ReadLine()
            Console.Write("Valor 2: ")
            num2 = Console.ReadLine()
            Console.WriteLine()
        Loop
        cont = 0
        For i = num1 To num2
            If i Mod 5 = 0 Then
                cont += 1
            End If
        Next
        Console.WriteLine("Existe {0} multiplos de 5 entre {1} y {2}.", cont, num1, num2)
        Console.ReadKey()
        'Cuarto ingreso de datos
        num1 = 2
        num2 = 1
        Do Until num1 < num2
            Console.Clear()
            Console.WriteLine("Ingrese 2 valores")
            Console.Write("Valor 1: ")
            num1 = Console.ReadLine()
            Console.Write("Valor 2: ")
            num2 = Console.ReadLine()
            Console.WriteLine()
        Loop
        cont = 0
        For i = num1 To num2
            If i Mod 5 = 0 Then
                cont += 1
            End If
        Next
        Console.WriteLine("Existe {0} multiplos de 5 entre {1} y {2}.", cont, num1, num2)
        Console.ReadKey()
    End Sub
End Module