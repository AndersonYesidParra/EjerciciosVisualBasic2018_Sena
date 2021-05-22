Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        Dim edad As Integer = Convert.ToInt32(txtEdad.Text)

        Dim masculino As Boolean = Rmasculino.Checked

        Dim femenino As Boolean = Rfemenino.Checked

        If masculino = True Then

            MsgBox("Su nombre es " & nombre & " tiene " & edad & "  años, de genero Masculino " & ", Sus pulsaciones son " & ((220 - edad) / 10))

        Else
            If femenino = True Then

                MsgBox("Su nombre es " & nombre & " tiene " & edad & "  años, de genero Femenino " & ", Sus pulsaciones son " & ((210 - edad) / 10))

            End If

        End If



    End Sub
End Class
