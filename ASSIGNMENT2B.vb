Module Module1

    Sub Main()
        Dim s, first, last As String
        Dim lenStr As Integer = 0
        s = " "
        first = " "
        last = " "
        Console.WriteLine("Enter the string: ")
        s = Console.ReadLine
        lenStr = Len(s)
        If lenStr >= 2 Then
            first = Left(s, 2)
            last = Right(s, 2)
            Console.Write("Final string: " & first & last)
        Else
            Console.Write("Final string: ")
        End If
        Console.ReadKey()
    End Sub

End Module
