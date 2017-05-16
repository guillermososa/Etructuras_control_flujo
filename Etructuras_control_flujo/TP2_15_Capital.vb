Module TP2_15_Capital
    Sub Main()
        'Declaracion de variables
        Const tasa_interes As UShort = 36
        Dim capital, meses, interes, saldo, interes_ganado As Double
        Dim i As Integer
        interes_ganado = 0
        'Ingreso de datos
        Console.Write("Ingrese capital inicial: ")
        capital = Console.ReadLine()
        Console.Write("Ingrese cantidad de meses: ")
        meses = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("MES  CAPITAL         INTERES         SALDO")
        For i = 1 To meses
            interes = capital * (tasa_interes / 12) / 100
            saldo = capital + interes
            Console.WriteLine("{0}   ${1}       ${2}         ${3}", i.ToString("00"), capital.ToString("#########0.00"), interes.ToString("#########0.00"), saldo.ToString("#########0.00"))
            capital = saldo
            interes_ganado += interes
            interes = 0
            saldo = 0
        Next
        Console.WriteLine()
        Console.WriteLine("Interes ganado: $" & interes_ganado.ToString("#########0.00"))
        Console.ReadKey()
    End Sub
End Module