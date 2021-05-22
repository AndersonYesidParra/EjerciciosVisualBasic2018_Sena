Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cantidadNotas As Integer = Convert.ToInt32(InputBox("Cuantas notas desea agregar", "ingrese la cantidad"))

        Dim inotas As Integer = 0

        Dim totalNotas As Single = 0

        While cantidadNotas > inotas

            totalNotas += Convert.ToInt64(InputBox("Nota " & inotas + 1, "Ingrese la nota"))

            inotas += 1
        End While

        Dim promedio As Single = totalNotas / cantidadNotas

        MsgBox("El promedio de las notas es: " & promedio)

        lblPromedio.Text = promedio

    End Sub
End Class
