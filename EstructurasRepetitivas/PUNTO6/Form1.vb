Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim placaAunto As String = InputBox("numero de tu placa:")

        Dim numFinal As Integer = Convert.ToInt32(Convert.ToString(placaAunto.Last()))

        If numFinal = 1 Or numFinal = 2 Then

            MsgBox("Tu placa termina en " & numFinal & " El color de tu auto es Amarillo")

        Else

            If numFinal = 3 Or numFinal = 4 Then

                MsgBox("Tu placa termina en " & numFinal & " El color de tu auto es Rosa")

            End If

            If numFinal = 5 Or numFinal = 6 Then

                MsgBox("Tu placa termina en " & numFinal & " El color de tu auto es Roja")

            End If

            If numFinal = 7 Or numFinal = 8 Then

                MsgBox("Tu placa termina en " & numFinal & " El color de tu auto es Verde")

            End If

            If numFinal = 9 Or numFinal = 0 Then

                MsgBox("Tu placa termina en " & numFinal & " El color de tu auto es Azul")

            End If



        End If


    End Sub
End Class
