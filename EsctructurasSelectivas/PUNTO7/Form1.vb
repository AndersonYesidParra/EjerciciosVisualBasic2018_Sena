Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        Dim horasTrabajadas As Integer = Convert.ToInt32(txtHorasTrabajadas.Text)

        Dim precioHoras As Single = Convert.ToInt64(txtPrecioHoras.Text)

        Dim salario As Single = horasTrabajadas * precioHoras

        Dim aumento As Integer

        If horasTrabajadas > 48 Then

            Dim extra As Integer = horasTrabajadas - 48

            aumento = extra * (precioHoras * 1.25)
            MsgBox("Su nombre es: " & nombre & " Su salario es : " & salario + aumento)

        Else

            MsgBox("Su nombre es: " & nombre & " Su salario es : " & salario)


        End If






    End Sub
End Class
