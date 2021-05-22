Public Class Form1
    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click

        Dim numero As Integer = Convert.ToInt32(txtNumero.Text)

        Dim pagar As Single = Convert.ToInt64(txtTotal.Text)

        If numero < 74 Then

            MsgBox("El numero es menor que 74 tienes un descuento del 15% tu saldo a pagar es " & pagar * 0.85)

        Else
            If numero >= 74 Then

                MsgBox("El numero es mayor o igual que 74 tienes un descuento del 20% tu saldo a pagar es " & pagar * 0.8)


            End If



        End If

    End Sub
End Class
