Module TP2_13_Numeros_Primos
    Sub Main()
        Dim i, j, divisor As Integer
        For i = 2 To 999
            divisor = 0
            For j = 2 To i
                If i Mod j = 0 Then
                    divisor += 1
                End If
            Next
            If divisor = 1 Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadKey()
    End Sub
End Module