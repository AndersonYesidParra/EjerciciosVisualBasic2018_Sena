Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim monto As Single = Convert.ToInt64(txtMonto.Text)

        If monto < 50000 Then

            txtCuota.Text = monto * 0.03

        Else
            If monto >= 50000 Then

                txtCuota.Text = monto * 0.02
            End If

        End If

    End Sub
End Class
