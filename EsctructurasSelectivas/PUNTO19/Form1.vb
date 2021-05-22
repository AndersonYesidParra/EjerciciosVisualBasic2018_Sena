Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim precio As Single = Convert.ToInt64(txtPrecio.Text)

        Dim nosi As Boolean = nosy.Checked

        Dim otraM As Boolean = otraMarca.Checked

        If precio > 20000 And nosi = True Then

            MsgBox("Producto NOSY, total a pagar con descuento es :  " & (precio * 0.85))

        Else

            MsgBox("No aplica descuentos, total a pagar es: " & precio)


        End If




    End Sub
End Class
