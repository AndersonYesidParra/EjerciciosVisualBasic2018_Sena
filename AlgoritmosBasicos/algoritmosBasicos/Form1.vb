Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim base, altura, area As Single

        base = txtBase.Text

        altura = txtAltura.Text

        area = base * altura / 2

        lblResultado.Text = area



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
