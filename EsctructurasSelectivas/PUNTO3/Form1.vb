Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numeroX As Integer = Convert.ToInt32(txtX.Text)

        Dim numeroY As Integer = Convert.ToInt32(txtY.Text)

        If numeroX > 0 And numeroY > 0 Then

            MsgBox("Los mumeros son: " & numeroX & " , " & numeroY)

        Else

            MsgBox("Elige un numero positivo ")

        End If

    End Sub
End Class
