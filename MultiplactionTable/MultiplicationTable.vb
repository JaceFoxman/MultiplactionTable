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


    End Sub

    Sub FirstTable()

        Dim result As String

        For i = 1 To 12

            For j = 1 To 12
                result = (i * j).ToString
                result = result.PadLeft(4)
                Console.Write(result)
            Next

            Console.WriteLine()

        Next

    End Sub

    Sub SecondTable()

        Dim result As String

        For i = 1 To 7

            For j = 1 To 7
                result = (i * j).ToString
                result = result.PadLeft(4)
                Console.Write(result)
            Next

            Console.WriteLine()

        Next

    End Sub

End Module
