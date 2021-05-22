Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim personone As Single = Convert.ToUInt64(txtUno.Text)

        Dim persontwo As Single = Convert.ToUInt64(txtDos.Text)

        Dim personthree As Single = Convert.ToUInt64(txtTres.Text)

        Dim total As Integer = personone + persontwo + personthree

        Dim porcentajep1 As Single = (100 * personone) / total

        txtporcentajeuno.Text = porcentajep1

        Dim porcentajep2 As Single = (100 * persontwo) / total

        txtporcentajedos.Text = porcentajep2

        Dim porcentajep3 As Single = (100 * personthree) / total

        txtporcentajetres.Text = porcentajep3







    End Sub
End Class
