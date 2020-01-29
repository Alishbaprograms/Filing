Module Module1

    Sub Main()
        Dim name As String
        Dim ID As String
        Dim more As String

        name = ""
        ID = ""
        more = ""

        FileOpen(1, "Memebership.txt", OpenMode.Append)
        Do
            Console.Write("Enter member's name: ")
            name = Console.ReadLine
            Console.Write("Enter ID: ")
            ID = Console.ReadLine

            WriteLine(1, name)
            WriteLine(1, ID)

            Console.Write("Do you want to enter more data (y/n)? ")
            more = Console.ReadLine
        Loop Until more = "n"
        FileClose(1)

    End Sub

End Module
