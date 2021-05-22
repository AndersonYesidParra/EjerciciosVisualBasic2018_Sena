Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nota1 As Integer = Convert.ToUInt32(txtNota1.Text)

        Dim nota2 As Integer = Convert.ToInt32(txtNota2.Text)

        Dim nota3 As Integer = Convert.ToInt32(txtNota3.Text)

        Dim nota4 As Integer = Convert.ToInt32(txtNota4.Text)

        txtPromedio.Text = (nota1 + nota2 + nota3 + nota4) / 4


    End Sub
End Class
