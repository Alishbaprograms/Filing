Module Module1

    Sub Main()
        Dim name As String
        Dim ID As String
        Dim telenum As String
        Dim address As String

        name = ""
        ID = ""
        telenum = ""
        address = ""

        FileOpen(1, "Membership.txt", OpenMode.Input)
        FileOpen(2, "Membership2.txt", OpenMode.Output)
        Do
            Input(1, name)
            Input(1, ID)
            Console.WriteLine("Name: " & name)
            Console.WriteLine("ID: " & ID)

            Console.WriteLine("Enter telephone Number: ")
            telenum = Console.ReadLine
            Console.WriteLine("Enter the address: ")
            address = Console.ReadLine

            WriteLine(2, name)
            WriteLine(2, ID)
            WriteLine(2, telenum)
            WriteLine(2, address)

        Loop Until EOF(1) Or EOF(2)

        FileClose(1)
        FileClose(2)
    End Sub

End Module
