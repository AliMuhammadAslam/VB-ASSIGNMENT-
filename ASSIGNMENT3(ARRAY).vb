Module Module1
    Dim Alphabets(26) As Integer
    Sub Main()
        Dim count As Integer

        For count = 1 To 26
            Alphabets(count) = 0
        Next

        Call InputFromFile()
        Call OutputArray()
        Console.ReadKey()
    End Sub

    Sub InputFromFile()
        Dim FileRecord As String = ""
        FileOpen(1, "c:\filepractice.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, FileRecord)
            Call UpdateArray(FileRecord)
        End While

        FileClose(1)
    End Sub

    Sub UpdateArray(ByVal FileRecord As String)
        Dim count As Integer = 0
        Dim character As Char = ""

        For count = 1 To Len(FileRecord)
            character = Mid(FileRecord, count, 1)
            Alphabets(Asc(UCase(character)) - 64) = Alphabets(Asc(UCase(character)) - 64) + 1
        Next
    End Sub

    Sub OutputArray()
        Dim count As Integer = 0
        Dim alpha As Char = ""
        For count = 65 To 90
            alpha = Chr(count)
            Console.WriteLine(alpha & " = " & Alphabets(count - 64))
        Next
    End Sub


End Module
