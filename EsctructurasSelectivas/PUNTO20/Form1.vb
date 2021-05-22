Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cantidad As Single = Convert.ToInt64(txtKilos.Text)

        If cantidad > 0 And cantidad <= 2 Then

            MsgBox(" Tu descuenta será del 0%")

        Else
            If cantidad >= 2.01 And cantidad < 5 Then

                MsgBox(" Tu descuenta será del 10%")

            End If

            If cantidad >= 5.01 And cantidad < 10 Then

                MsgBox(" Tu descuenta será del 15%")

            End If

            If cantidad > 10.1 Then

                MsgBox(" Tu descuenta será del 20%")

            End If

        End If

    End Sub
End Class
