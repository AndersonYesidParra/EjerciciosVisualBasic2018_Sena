Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim lado1 As Single = Convert.ToUInt64(txtlado1.Text)

        Dim lado2 As Single = Convert.ToUInt64(txtLado2.Text)

        Dim lado3 As Single = Convert.ToUInt64(txtLado3.Text)

        Dim lado4 As Single = Convert.ToUInt64(txtLado4.Text)

        txtResultado.Text = (lado1 + lado2 + lado3 + lado4)



    End Sub
End Class
