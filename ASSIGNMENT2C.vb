Module Module1

    Sub Main()
        Dim s, myWord As String
        Dim Chr1, Character As Char
        Dim Count As Integer = 0
        s = " "
        myWord = " "
        Const constant = "*"
        Chr1 = " "
        Character = " "
        Console.WriteLine("Enter the string: ")
        s = Console.ReadLine
        Chr1 = Left(s, 1)
        myWord = Chr1
        For Count = 2 To Len(s)
            Character = Mid(s, Count, 1)
            If Character = Chr1 Then
                myWord = myWord & constant
            Else
                myWord = myWord & Character

            End If
        Next
        Console.Write("Final word: " & myWord)
        Console.ReadKey()


    End Sub

End Module
