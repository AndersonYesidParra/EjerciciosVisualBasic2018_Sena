Module Module1

    Sub Main()

        Dim a, b, c, d As Double

        a = 25
        b = 17
        c = 3
        d = 1

        If Not ((a = d) Or ((d >= b) And (a > b))) Then

            Console.WriteLine("True")

        Else

            Console.WriteLine("False")

        End If


    End Sub

End Module
