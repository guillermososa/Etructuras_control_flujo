Module TP2_05_CASE_Mes
    Enum MesesDelAño As Byte
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septimbre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub Main()
        'Declaracion de variables
        Dim mes As MesesDelAño
        'Ingreso de datos
        Console.Write("Ingrese el numero de mes a evaluar: ")
        mes = Console.ReadLine()
        'Validar y mostrar informacion
        Console.WriteLine()
        Select Case mes
            Case MesesDelAño.Enero
                Console.WriteLine("Corresponde al mes de Enero")
            Case MesesDelAño.Febrero
                Console.WriteLine("Corresponde al mes de Febrero")
            Case MesesDelAño.Marzo
                Console.WriteLine("Corresponde al mes de Marzo")
            Case MesesDelAño.Abril
                Console.WriteLine("Corresponde al mes de Abril")
            Case MesesDelAño.Mayo
                Console.WriteLine("Corresponde al mes de Mayo")
            Case MesesDelAño.Junio
                Console.WriteLine("Corresponde al mes de Junio")
            Case MesesDelAño.Julio
                Console.WriteLine("Corresponde al mes de Julio")
            Case MesesDelAño.Agosto
                Console.WriteLine("Corresponde al mes de Agosto")
            Case MesesDelAño.Septimbre
                Console.WriteLine("Corresponde al mes de Septimbre")
            Case MesesDelAño.Octubre
                Console.WriteLine("Corresponde al mes de Octubre")
            Case MesesDelAño.Noviembre
                Console.WriteLine("Corresponde al mes de Noviembre")
            Case MesesDelAño.Diciembre
                Console.WriteLine("Corresponde al mes de Diciembre")
            Case Else
                Console.WriteLine("El valor ingresado es invalido")
        End Select
        Console.ReadKey()
    End Sub
End Module