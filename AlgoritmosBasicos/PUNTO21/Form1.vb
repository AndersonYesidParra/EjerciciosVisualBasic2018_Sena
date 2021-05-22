Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dMayor As Single = Convert.ToUInt64(txtMayor.Text)

        Dim dMenor As Single = Convert.ToUInt64(txtMenor.Text)

        txtResultado.Text = (dMayor * dMenor) / 2

    End Sub

End Class
