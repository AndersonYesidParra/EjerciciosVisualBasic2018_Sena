Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim hombres As Integer = Convert.ToInt32(txtHombre.Text)

        Dim mujeres As Integer = Convert.ToInt32(txtMujeres.Text)

        Dim total As Integer = hombres + mujeres

        Dim percentajeH As Integer = (hombres * 100) / total

        Dim porcentajeM As Integer = (mujeres * 100) / total

        MsgBox("El porcentaje de mujeres es: " & porcentajeM & ", el porcentaje de hombres es: " & percentajeH)



    End Sub

End Class
