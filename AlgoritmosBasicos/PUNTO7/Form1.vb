Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Peso As Single = Convert.ToInt64(txtPeso.Text)




        If Peso > 3775 Then

            txtDolar.Text = Peso / 3775


        Else

            MsgBox("Sube el precio del Peso ")



        End If

    End Sub
End Class
