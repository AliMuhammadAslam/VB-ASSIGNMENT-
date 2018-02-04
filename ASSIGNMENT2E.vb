Module Module1

    Sub Main()
        Dim s, beforeNot, afterBad, finalSentence As String
        Dim locationNot, locationBad As Integer
        s = " "
        beforeNot = " "
        afterBad = " "
        finalSentence = " "
        locationNot = 0
        locationBad = 0
        Console.WriteLine("Enter the sentence: ")
        s = Console.ReadLine
        locationNot = InStr(s, "not")
        locationBad = InStr(s, "bad")
        If locationBad > locationNot Then
            beforeNot = Left(s, locationNot - 1)
            afterBad = Mid(s, locationBad + 3, Len(s))
            finalSentence = beforeNot & "good" & afterBad
            Console.Write("The final sentence is: " & finalSentence)
        Else
            Console.Write("Re enter the sentence")
        End If
        Console.ReadKey()
    End Sub

End Module
