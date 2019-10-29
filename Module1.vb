Module Module1

    Sub Main()
        Dim binarynumber As String
        Dim nextchar As Char
        Dim count As Integer
        Dim denaryone As Integer
        Dim denary As Integer
        Dim ValidBinaryString As Boolean

        binarynumber = ""
        nextchar = ""
        count = 0
        denaryone = 0
        denary = 0
        ValidBinaryString = True

        Console.Write("enter binary string: ")
        binarynumber = Console.ReadLine

        If Len(binarynumber) < 1 Or Len(binarynumber) > 8 Then
            ValidBinaryString = False

            If ValidBinaryString = True Then
                For count = 1 To Len(binarynumber)
                    nextchar = Mid(binarynumber, count, 1)
                    If nextchar = "1" Or nextchar = "0" Then
                        ValidBinaryString = True
                    Else
                        ValidBinaryString = False
                    End If
                Next
            End If
        End If

        If ValidBinaryString = False Then
            Console.WriteLine("not a valid binary string")
        End If

        If ValidBinaryString = True Then
            For count = Len(binarynumber) To 1 Step -1
                denaryone = Mid(binarynumber, count, 1)
                denary = denary + denaryone * (2 ^ (Len(binarynumber) - count))
            Next
            Console.WriteLine(binarynumber & " = " & denary)
        End If

        Console.ReadKey()
    End Sub

End Module
