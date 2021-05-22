Public Class txtPrecio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim camisas As Integer = Convert.ToInt32(txtCamisa.Text)

        Dim precios As Single = Convert.ToInt32(txtPrecios.Text)

        Dim total As Single = camisas * precios

        If camisas <= 3 Then

            MsgBox("Precio de la camisa es $" & total & ", La camisa tiene un descuento del 10% tu Precio total es: $" & total * 0.9)

        Else

            If camisas > 4 Then

                MsgBox("Precio de la camisa es $" & total & ", La camisa tiene un descuento del 20% tu Precio total es: $" & total * 0.8)

            End If

        End If

    End Sub
End Class
