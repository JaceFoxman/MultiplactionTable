'Jason Permann
'Spring 2025
'RCET2265
'Multiplication Table
'https://github.com/JaceFoxman/MultiplactionTable.git

Option Strict On
Option Explicit On
Option Compare Text

Module MultiplicationTable

    Sub Main()

        Dim userinput As String
        Dim variable As Integer

        'Boot up menu
        Console.WriteLine("Please enter a number. Enter " & "Q " & "at any time to quit")
        Console.WriteLine()

        Do Until userinput = "Q"

            Try
                'Ask user to input a whole number
                Console.Write("Choose a number: ")
                userinput = Console.ReadLine()
                variable = CInt(userinput)
                Console.WriteLine($"You entered {variable}")
                Console.WriteLine()

                'Send users input to MultiplacationTable
                Console.WriteLine(StrDup(80, "-"))
                Console.WriteLine($"Enjoy Your {userinput} X {userinput} Times Table:")
                Console.WriteLine()
                MultiplacationTable(variable)

            Catch ex As Exception

                If userinput <> "Q" Then Console.WriteLine("Please enter a whole number")

            End Try

        Loop

        Console.WriteLine()
        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close the window")

    End Sub

    Sub MultiplacationTable(ByVal variable As Integer)

        Dim result As String

        For i = 1 To variable

            For j = 1 To variable
                result = (i * j).ToString
                result = result.PadLeft(4)
                Console.Write(result)
            Next

            Console.WriteLine()

        Next

        Console.WriteLine()

    End Sub

End Module
