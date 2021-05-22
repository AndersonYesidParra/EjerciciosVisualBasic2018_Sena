Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        Dim clave As Integer = Convert.ToInt32(txtClave.Text)

        Dim precio As Integer = Convert.ToInt32(txtPrecio.Text)

        If clave = 1 Then


            MsgBox("Su nombre es " & nombre & ", La clave es " & clave & ", Su precio con descuento es " & precio * 0.9)

        Else

            If clave = 2 Then

                MsgBox("Su nombre es " & nombre & ", La clave es " & clave & ", Su precio con descuento es " & precio * 0.8)

            End If

            If clave <> 1 Or clave <> 2 Then

                MsgBox(" La clave debe ser 1 o 2")

            End If

        End If


    End Sub
End Class
