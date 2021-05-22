Public Class Form1
    Private Sub Calcula_Click(sender As Object, e As EventArgs) Handles Calcula.Click

        Dim Examen As Single = Convert.ToInt64(txtExamen.Text) * 0.15

        Dim notaUno As Single = Convert.ToInt64(txtUno.Text)

        Dim notaDos As Single = Convert.ToInt64(txtDos.Text)

        Dim notaTres As Single = Convert.ToInt64(txtTres.Text)

        Dim Parciales As Single = ((notaUno + notaDos + notaTres) / 3) * 0.55

        Dim Trabajo As Single = Convert.ToInt64(txtTrabajo.Text) * 0.3

        txtNota.Text = Parciales + Trabajo + Examen









    End Sub
End Class
