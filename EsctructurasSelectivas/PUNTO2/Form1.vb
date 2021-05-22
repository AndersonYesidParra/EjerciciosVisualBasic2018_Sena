Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        Dim edad As Integer = Convert.ToInt64(txtEdad.Text)

        Dim masculinos As Boolean = masculino.Checked

        Dim femeninas As Boolean = Femenino.Checked

        Dim solteros As Boolean = soltero.Checked

        Dim casados As Boolean = casado.Checked

        Dim otros As Boolean = otro.Checked

        If femeninas And edad < 18 Then

            MsgBox("Su nombre es: " & nombre)


        Else

            If solteros Then

                MsgBox("Su estado civil es Soltero ")


            End If

            If casados Then

                MsgBox("Su estado civil es Casado ")

            End If

            If otros Then

                MsgBox("Su estado civil es Otros ")

            End If

        End If


    End Sub
End Class
