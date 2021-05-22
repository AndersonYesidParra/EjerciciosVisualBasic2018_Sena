Public Class txtCantidad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cantidad As Integer = Convert.ToInt32(txtNumero.Text)

        If cantidad < 5 Then

            MsgBox("Tienes descuento del 10%, total a pagar es: " & ((cantidad * 11000) * 0.9))

        Else
            If cantidad >= 5 And cantidad < 11 Then

                MsgBox("Tienes descuento del 20%, total a pagar es: " & ((cantidad * 11000) * 0.8))

            End If

            If cantidad > 9 Then


                MsgBox("Tienes descuento del 40%, total a pagar es: " & ((cantidad * 11000) * 0.6))

            End If

        End If

    End Sub
End Class
