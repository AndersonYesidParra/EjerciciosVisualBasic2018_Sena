Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim meses As Integer = Convert.ToInt64(txtMeses.Text)

        Dim intereses As Single = Convert.ToInt32(txtIntereses.Text) / 100

        Dim dinero As Single = Convert.ToInt64(txtDinero.Text)

        Dim ganancia As String = (dinero * intereses) * meses

        If ganancia > 7000 Then

            Dim valor As Single = ((dinero + ganancia) * intereses) * meses

            MsgBox("El dinero que tendra será : " & valor)

        Else

            MsgBox(" La ganacia de los intereses no superan los 7,000")


        End If




    End Sub
End Class
