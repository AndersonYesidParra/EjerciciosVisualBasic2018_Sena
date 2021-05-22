Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim base As Integer = Convert.ToInt32(txtBase.Text)

        Dim altura As Integer = Convert.ToInt32(txtAltura.Text)



        If base = 0 Or altura = 0 Then

            MsgBox("Escribir un número superior a cero")

        End If

        txtResultado.Text = (base * altura) / 2



    End Sub
End Class
