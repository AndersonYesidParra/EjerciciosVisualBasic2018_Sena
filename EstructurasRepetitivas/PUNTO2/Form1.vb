Public Class Form1

    Dim total As Single = 0

    Dim naranjaKg As Single = 2000

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cantidad As Integer = Convert.ToInt64(txtCantidad.Text)

        If cantidad > 10 And rdbDeudor.Checked Then

            Dim valor As Single = naranjaKg * cantidad
            Dim dcto As Single = valor - (valor * 0.15)
            total += dcto
            MsgBox("Valor a pagar: " & valor)

        Else
            Dim valor As Single = naranjaKg * cantidad
            total += valor
            MsgBox("Valor a pagar: " & valor)

        End If

        lblResultado.Text = total


    End Sub


End Class
