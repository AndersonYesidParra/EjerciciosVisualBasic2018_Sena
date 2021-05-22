Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim duerme As Single = Convert.ToInt64(txtDuerme.Text) * 1.08

        Dim sentado As Single = Convert.ToInt64(txtSentado.Text) * 1.66

        txtCalorias.Text = duerme * sentado


    End Sub
End Class
