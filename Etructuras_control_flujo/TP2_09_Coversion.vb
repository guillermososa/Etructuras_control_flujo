Module TP2_09_Coversion
    Enum Medidas As Byte
        Metros
        Centimetros
        Pulgadas
        Pies
        Yardas
    End Enum
    Sub Main()
        'Declaracion de variables
        Dim vmetros, vcentimetros, vpulgadas, vpies, vyardas As Double
        Dim valor As Double
        Dim medida As Medidas
        'Ingreso de datos
        Console.WriteLine("Ingrese Datos")
        Console.Write("¿Que unidad de medida desea convertir (0=Metros/1=Centimetros/2=Pulgadas/3=Pies/4=Yardas)?: ")
        medida = Console.ReadLine()
        Console.Write("Ingrese el valor de {0} a convertir: ", medida.ToString)
        valor = Console.ReadLine()
        Console.WriteLine()
        Select Case medida
            Case Medidas.Metros
                'Calculo
                vmetros = valor
                vcentimetros = vmetros * 100
                vpulgadas = vcentimetros / 2.54
                vpies = vpulgadas / 12
                vyardas = vpies / 3
                'Mostrar informacion
                Console.WriteLine("Centimetros: " & vcentimetros)
                Console.WriteLine("Pulgadas: " & vpulgadas)
                Console.WriteLine("Pies: " & vpies)
                Console.WriteLine("Yardas: " & vyardas)
            Case Medidas.Centimetros
                'Calculo
                vcentimetros = valor
                vmetros = vcentimetros / 100
                vpulgadas = vcentimetros / 2.54
                vpies = vpulgadas / 12
                vyardas = vpies / 3
                'Mostrar informacion
                Console.WriteLine("Metros: " & vmetros)
                Console.WriteLine("Pulgadas: " & vpulgadas)
                Console.WriteLine("Pies: " & vpies)
                Console.WriteLine("Yardas: " & vyardas)
            Case Medidas.Pulgadas
                'Calculo
                vpulgadas = valor
                vcentimetros = vpulgadas * 2.54
                vpies = vpulgadas / 12
                vmetros = vcentimetros / 100
                vyardas = vpies / 3
                'Mostrar informacion
                Console.WriteLine("Metros: " & vmetros)
                Console.WriteLine("Centimetros: " & vcentimetros)
                Console.WriteLine("Pies: " & vpies)
                Console.WriteLine("Yardas: " & vyardas)
            Case Medidas.Pies
                'Calculo
                vpies = valor
                vyardas = vpies / 3
                vpulgadas = vpies * 12
                vcentimetros = vpulgadas * 2.54
                vmetros = vcentimetros / 100
                'Mostrar informacion
                Console.WriteLine("Metros: " & vmetros)
                Console.WriteLine("Centimetros: " & vcentimetros)
                Console.WriteLine("Pulgadas: " & vpulgadas)
                Console.WriteLine("Yardas: " & vyardas)
            Case Medidas.Yardas
                'Calculo
                vyardas = valor
                vpies = vyardas * 3
                vpulgadas = vpies * 12
                vcentimetros = vpulgadas * 2.54
                vmetros = vcentimetros / 100
                'Mostrar informacion
                Console.WriteLine("Metros: " & vmetros)
                Console.WriteLine("Centimetros: " & vcentimetros)
                Console.WriteLine("Pulgadas: " & vpulgadas)
                Console.WriteLine("Pies: " & vpies)
        End Select
        Console.ReadKey()
    End Sub
End Module