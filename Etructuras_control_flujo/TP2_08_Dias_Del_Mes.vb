Module TP2_08_Dias_Del_Mes
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
        Dim anio As Integer
        'Ingreso de datos
        Console.WriteLine("Dia del Mes")
        Console.Write("Ingrese el numero de mes a evaluar: ")
        mes = Console.ReadLine()
        Select Case mes
            Case MesesDelAño.Febrero
                Console.Write("Ingrese el año: ")
                anio = Console.ReadLine()
                Console.WriteLine()
                If (anio Mod 4 = 0 And anio Mod 100 <> 0) Or anio Mod 400 = 0 Then
                    Console.WriteLine("El mes de {0} tiene 29 dias", mes.ToString)
                Else
                    Console.WriteLine("El mes de {0} tiene 28 dias", mes.ToString)
                End If
            Case MesesDelAño.Abril, MesesDelAño.Junio, MesesDelAño.Septimbre, MesesDelAño.Noviembre
                Console.WriteLine()
                Console.WriteLine("El mes de {0} tiene 30 dias", mes.ToString)
            Case MesesDelAño.Enero, MesesDelAño.Marzo, MesesDelAño.Mayo, MesesDelAño.Julio, MesesDelAño.Agosto, MesesDelAño.Octubre, MesesDelAño.Diciembre
                Console.WriteLine()
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case Else
                Console.WriteLine("El valor ingresado es invalido")
        End Select
        Console.ReadKey()
    End Sub
End Module