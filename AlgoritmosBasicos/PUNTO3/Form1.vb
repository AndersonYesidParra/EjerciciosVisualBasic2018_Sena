Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim Sueldo As Single = Convert.ToInt64(txtSueldo.Text)

        Dim Comisiones As Single = 0

        Dim ValorComision As Single = 0

        If Convert.ToUInt64(txtComision.Text) Then

            Comisiones = Convert.ToUInt64(txtComision.Text)

            ValorComision = Comisiones * 0.1

        End If


        lbltotal.Text = Sueldo + ValorComision




    End Sub
End Class
