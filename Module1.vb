Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim mychar, nextchar As Char
        Dim Counter As Integer

        str1 = ""
        str2 = ""
        mychar = ""
        nextchar = ""
        Counter = 0

        Console.Write("Enter String: ")
        str1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        mychar = Console.ReadLine

        For Counter = 1 To Len(str1)
            nextchar = Mid(str1, Counter, 1)
            If nextchar <> mychar Then
                str2 = str2 & nextchar
            End If
        Next
        Console.WriteLine("Final String = " & str2)
        Console.ReadKey()

    End Sub

End Module
