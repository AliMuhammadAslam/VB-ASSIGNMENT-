Module Module1

    Sub Main()
        Dim a, b, aFront, bFront, aBack, bBack, finalString As String
        a = " "
        b = " "
        aFront = " "
        bFront = " "
        aBack = " "
        bBack = " "
        finalString = " "
        Console.WriteLine("Enter the first string: ")
        a = Console.ReadLine
        Console.WriteLine("Enter the second string: ")
        b = Console.ReadLine
        If Len(a) Mod 2 = 0 Then
            aFront = Mid(a, 1, Len(a) / 2)
            aBack = Mid(a, Len(a) / 2 + 1, Len(a) - Len(aFront))
        Else
            aFront = Mid(a, 1, (Len(a) / 2) + (1 / 2))
            aBack = Mid(a, (Len(a) / 2) + (3 / 2), Len(a) - Len(aFront))
        End If
        If Len(b) Mod 2 = 0 Then
            bFront = Mid(b, 1, Len(b) / 2)
            bBack = Mid(b, Len(b) / 2 + 1, Len(b) - Len(bFront))
        Else
            bFront = Mid(b, 1, (Len(b) / 2) + (1 / 2))
            bBack = Mid(b, (Len(b) / 2) + (3 / 2), Len(b) - Len(bFront))
        End If
        finalString = aFront & "+" & bFront & "+" & aBack & "+" & bBack
        Console.Write("The final string is: " & finalString)
        Console.ReadKey()





    End Sub

End Module
