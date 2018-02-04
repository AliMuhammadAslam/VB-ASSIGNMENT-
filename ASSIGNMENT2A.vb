Module Module1

    Sub Main()
        Dim count As Integer = 0
        Console.WriteLine("Enter the number of donuts: ")
        count = Console.ReadLine
        If count >= 10 Then
            Console.Write("Number of donuts: " & "many")
        Else
            Console.Write("Number of donuts: " & count)
        End If
        Console.ReadKey()
    End Sub

End Module
