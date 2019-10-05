Module Module1

    Sub Main()
        Dim str1, str2, str3, firstword, secword As String
        Dim Sp As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        firstword = ""
        secword = ""
        Sp = 0

        Console.Write("Enter string 1: ")
        str1 = Console.ReadLine()

        Console.Write("Enter String 2: ")
        str2 = Console.ReadLine()

        Sp = InStr(str1, " ")
        firstword = Left(str1, Sp - 1)

        Sp = InStr(str2, " ")
        secword = Right(str2, Len(str2) - Sp)

        str3 = firstword & " " & secword
        Console.WriteLine(str3)

        Console.ReadKey()



    End Sub

End Module
