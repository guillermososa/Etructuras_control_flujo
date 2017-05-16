Module TP2_12_Fibonacci
    Sub Main()
        Dim i, num1, num2, num3 As Integer
        num1 = 0
        num2 = 1
        Console.WriteLine(num1)
        Console.WriteLine(num2)
        For i = 1 To 20
            num3 = num1 + num2
            Console.WriteLine(num3)
            num1 = num2
            num2 = num3
        Next
        Console.ReadKey()
    End Sub
End Module