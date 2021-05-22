Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeroX As Integer = Convert.ToInt32(txtX.Text)

        Dim numeroY As Integer = Convert.ToInt32(txtY.Text)


        If numeroX > 0 And numeroY > 0 Then


            MsgBox("son positivos")

        Else

            MsgBox("Los numeros son: " & numeroX & " , " & numeroY)


        End If

    End Sub
End Class
