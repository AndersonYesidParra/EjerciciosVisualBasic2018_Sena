Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim diviendo As Integer = Convert.ToInt32(txtDividendo.Text)

        Dim divisor As Integer = Convert.ToInt32(txtDivisor.Text)

        txtResiduo.Text = diviendo Mod divisor

        txtCociente.Text = (diviendo / divisor)


    End Sub
End Class
