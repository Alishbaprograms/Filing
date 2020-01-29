Module Module1

    Sub Main()
        Dim name As String
        Dim sname As String
        Dim ID As String
        Dim IsFound As Boolean

        name = ""
        sname = ""
        ID = ""
        IsFound = False

        Console.WriteLine("Enter the name you are searching for: ")
        sname = Console.ReadLine

        FileOpen(1, "Membrship.vb", OpenMode.Input)
        Do
            Input(1, name)
            Input(1, ID)
            If name = sname Then
                IsFound = True
                Console.WriteLine("Id: " & ID)

            else 
            IsFound = False
            End If
        Loop Until EOF(1)
        FileClose(1)
        If IsFound = False Then
            Console.WriteLine(sname & "does not exist")

        End If

    End Sub

End Module
