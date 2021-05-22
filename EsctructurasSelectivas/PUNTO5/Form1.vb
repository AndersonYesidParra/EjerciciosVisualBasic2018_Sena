Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim diviendo As Integer = Convert.ToInt32(txtDiviendo.Text)

        Dim divisor As Integer = Convert.ToInt32(txtDivisor.Text)

        If divisor <= 0 Then

            MsgBox(" La division no es posible ")

        Else

            txtResultado.Text = diviendo / divisor


        End If




    End Sub
End Class
