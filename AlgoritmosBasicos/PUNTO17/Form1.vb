Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim salario As Single = Convert.ToUInt64(txtSalario.Text)

        txtNuevo.Text = salario + (salario * 0.25)

    End Sub
End Class
