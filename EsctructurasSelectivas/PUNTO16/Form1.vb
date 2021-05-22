Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        Dim edad As Integer = Convert.ToInt32(txtEdad.Text)

        Dim tiempo As Integer = Convert.ToInt32(txtAnos.Text)

        If edad > 60 And tiempo < 25 Then

            MsgBox(nombre & " esta inscrita a la jubiilación por edad")

        Else
            If edad < 60 And tiempo > 25 Then

                MsgBox(nombre & " esta inscrita a la jubiilación por Antiguedad Joven")

            End If

            If edad >= 60 And tiempo >= 25 Then


                MsgBox(nombre & " esta inscrita a la jubiilación por Antiguedad Adulta")

            End If



        End If

    End Sub
End Class
