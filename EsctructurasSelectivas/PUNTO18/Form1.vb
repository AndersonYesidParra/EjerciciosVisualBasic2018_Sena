Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cantidad As Integer = Convert.ToInt32(txtCantidades.Text)

        If cantidad < 5 Then

            MsgBox("Cada llanta tiene un costo de 30.000, total a pagar " & (cantidad * 30000))

        Else
            If cantidad >= 5 And cantidad < 10 Then

                MsgBox("Cada llanta tiene un costo de 25.000, total a pagar " & (cantidad * 25000))

            End If

            If cantidad > 10 Then

                MsgBox("Cada llanta tiene un costo de 20.000, total a pagar " & (cantidad * 20000))

            End If

        End If


    End Sub
End Class
