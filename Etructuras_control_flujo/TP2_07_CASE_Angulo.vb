Module TP2_07_CASE_Angulo
    Sub Main()
        'Declaracion de variables
        Dim angulo As Short
        'Ingreso de datos
        Console.Write("Ingrese tamaño del angulo (en grados): ")
        angulo = Console.ReadLine()
        'Validar y mostrar informacion
        Console.WriteLine()
        Select Case angulo
            Case Is < 0, Is >= 360
                Console.WriteLine("El valor ingresado es invalido")
            Case Is < 90
                Console.WriteLine("Corresponde a un angulo agudo")
            Case Is = 90
                Console.WriteLine("Corresponde a un angulo recto")
            Case Is < 180
                Console.WriteLine("Corresponde a un angulo obtuso")
            Case Is = 180
                Console.WriteLine("Corresponde a un angulo llano")
            Case Is < 360
                Console.WriteLine("Corresponde a un angulo concavo")
        End Select
        Console.ReadKey()
    End Sub
End Module