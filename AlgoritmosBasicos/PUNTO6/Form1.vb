Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim hombres As Integer = Convert.ToUInt32(txtHombres.Text)

        Dim mujeres As Integer = Convert.ToInt32(txtMujeres.Text)

        Dim total As Integer = hombres + mujeres

        Dim totalHombres = (hombres * 100) / total

        Dim totalmujeres = (mujeres * 100) / total

        MsgBox("El porcentaje de los Hombres son : " & totalHombres & " % " & " Total Mujeres " & totalmujeres & " % ")






    End Sub
End Class
