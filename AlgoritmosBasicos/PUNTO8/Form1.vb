Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim edad As Single = Convert.ToInt64(txtEdad.Text)


        txtResultado.Text = (220 - edad) / 10

    End Sub

End Class
