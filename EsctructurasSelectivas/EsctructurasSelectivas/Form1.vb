Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        Dim edad As Integer = Convert.ToInt32(txtEdad.Text)

        Dim masculinos As Boolean = masculino.Checked

        Dim femeninos As Boolean = Femenino.Checked

        If masculinos And edad > 17 Then

            MsgBox("El nombre es " & nombre)

        Else

            MsgBox("El nombre es " & nombre & " y su edad es: " & edad)


        End If




    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
