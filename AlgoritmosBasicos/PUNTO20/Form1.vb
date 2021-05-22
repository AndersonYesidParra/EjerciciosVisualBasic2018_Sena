Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim base As Integer = Convert.ToInt32(txtBase.Text)

        Dim altura As Integer = Convert.ToInt32(txtAltura.Text)

        Dim area As Integer = base * altura / 2

        txtArea.Text = area

        Dim hipo As Integer = (base ^ 2 + altura ^ 2)

        txtHipotenusa.Text = hipo

        Dim perimetro As Integer = base + altura + hipo

        txtPerimetro.Text = perimetro



    End Sub
End Class
