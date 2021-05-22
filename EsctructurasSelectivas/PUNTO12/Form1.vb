Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim llanta As Integer = Convert.ToInt32(txtLLanta.Text)

        If llanta < 5 Then

            MsgBox("El precio a pagar es: $" & llanta * 80000)

        Else
            If llanta >= 5 Then

                MsgBox("El precio a pagar es: $" & llanta * 70000)

            End If


        End If

    End Sub
End Class
