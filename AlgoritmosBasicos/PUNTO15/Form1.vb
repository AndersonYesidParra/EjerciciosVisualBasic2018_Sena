Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim presion As Single = Convert.ToInt64(txtPresion.Text)

        Dim temperatura As Single = Convert.ToInt64(txtTemperatura.Text)

        Dim volumen As Single = Convert.ToInt64(txtVolumen.Text)

        txtResultado.Text = ((presion * volumen) / 0.37 * (temperatura + 460))

    End Sub


End Class
