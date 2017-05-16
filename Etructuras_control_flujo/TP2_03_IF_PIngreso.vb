Module TP2_03_IF_PIngreso
    Sub Main()
        'Declaracion de variables
        Dim valor1, valor2, valor3, valor4, valor5 As Integer
        'Ingreso de datos
        Console.Write("Ingrese primer valor: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese segundo valor: ")
        valor2 = Console.ReadLine()
        Console.Write("Ingrese tercer valor: ")
        valor3 = Console.ReadLine()
        Console.Write("Ingrese cuarto valor: ")
        valor4 = Console.ReadLine()
        Console.Write("Ingrese quinto valor: ")
        valor5 = Console.ReadLine()
        'Validar  mostrar informacion
        Console.WriteLine()
        If valor1 >= valor2 And valor1 >= valor3 And valor1 >= valor4 And valor1 >= valor5 Then
            Console.WriteLine("El primer numero ({0}) es el mayor valor", valor1)
        End If
        If valor2 >= valor1 And valor2 >= valor3 And valor2 >= valor4 And valor2 >= valor5 Then
            Console.WriteLine("El segundo numero ({0}) es el mayor valor", valor2)
        End If
        If valor3 >= valor1 And valor3 >= valor2 And valor3 >= valor4 And valor3 >= valor5 Then
            Console.WriteLine("El tercer numero ({0}) es el mayor valor", valor3)
        End If
        If valor4 >= valor1 And valor4 >= valor2 And valor4 >= valor3 And valor4 >= valor5 Then
            Console.WriteLine("El cuarto numero ({0}) es el mayor valor", valor4)
        End If
        If valor5 >= valor1 And valor5 >= valor2 And valor5 >= valor3 And valor5 >= valor4 Then
            Console.WriteLine("El quinto numero ({0}) es el mayor valor", valor5)
        End If
        Console.ReadKey()
    End Sub
End Module