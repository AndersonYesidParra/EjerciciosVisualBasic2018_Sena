Public Class Form1

    Dim iventas As Single = 0

    Dim total As Single = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim salarioBasico = Convert.ToInt64(InputBox("Salario basico", "Inserte el salario basico"))

        Dim totalVentas = Convert.ToInt64(InputBox("Total en ventas", "Ingrese el total en ventas"))

        Dim totalPago = salarioBasico + (totalVentas * 0.1)

        MsgBox("Total a pagar al empleado: " & totalPago)

        total += totalPago

        lblResultado.Text = total

    End Sub
End Class
