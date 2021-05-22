Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim presopuesto As Single = Convert.ToInt64(txtPresopuesto.Text)

        txtGinecologia.Text = presopuesto * 0.4

        txtTraumotologia.Text = presopuesto * 0.3

        txtPediatria.Text = presopuesto * 0.3




    End Sub
End Class
