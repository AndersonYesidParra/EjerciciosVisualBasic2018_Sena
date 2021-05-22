Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim valorCompra As Single = Convert.ToUInt16(txtCompra.Text)

        Dim Descuento As Single = valorCompra * 0.15

        txtDescuento.Text = valorCompra - Descuento



    End Sub
End Class
