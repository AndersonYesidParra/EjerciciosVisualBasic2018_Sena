Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        Dim precioHora As Single = Convert.ToInt64(txtPrecioHora.Text)

        Dim horasTrabajadas As Integer = Convert.ToInt64(txtHorasTrabajadas.Text)

        Dim salario As Single = precioHora * horasTrabajadas

        If salario >= 250501 And salario <= 300000 Then


            MsgBox("Su Nombre es " & nombre & " Trabajo " & horasTrabajadas & " horas, " & "Su salario es " & salario & " El salario tiene retención del 5%, Su nuevo Salario es: " & salario * 0.95)

        Else

            If salario > 300001 Then

                MsgBox("Su Nombre es " & nombre & " Trabajo " & horasTrabajadas & " horas, " & "Su salario es " & salario & " Su salario tiene retención del 8%, Su nuevo Salario es: " & salario * 0.92)


            End If



        End If



    End Sub
End Class
