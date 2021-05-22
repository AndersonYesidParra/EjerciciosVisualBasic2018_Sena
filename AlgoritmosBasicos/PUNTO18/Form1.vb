Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim radio As Integer = Convert.ToInt32(txtRadio.Text)


        If radio = 0 Then

            MsgBox("Escribe un numero superior a cero")

        End If

        txtResultado.Text = 3.1416 * (radio * radio)


    End Sub
End Class
