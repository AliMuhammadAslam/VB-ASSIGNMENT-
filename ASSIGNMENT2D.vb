Module Module1

    Sub Main()
        Dim a, b, first2a, first2b, resta, restb, myWord As String
        a = " "
        b = " "
        first2a = " "
        first2b = " "
        resta = " "
        restb = " "
        myWord = " "
        Console.WriteLine("Enter the first string: ")
        a = Console.ReadLine
        Console.WriteLine("Enter the second string: ")
        b = Console.ReadLine
        first2a = Mid(a, 1, 2)
        first2b = Mid(b, 1, 2)
        resta = Mid(a, 3, Len(a))
        restb = Mid(b, 3, Len(b))
        myWord = first2b & resta & " " & first2a & restb
        Console.Write("The final word is: " & myWord)
        Console.ReadKey()




    End Sub

End Module
