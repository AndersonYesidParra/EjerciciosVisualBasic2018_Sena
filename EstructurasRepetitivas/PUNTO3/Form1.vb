Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim edad As Integer = Convert.ToInt32(txtEdad.Text)

        Dim elefante As Boolean = elefantess.Checked

        Dim jirafa As Boolean = jirafass.Checked

        Dim chimpance As Boolean = chimpa.Checked

        If edad And elefante = True Then

            MsgBox(" Le haran las muestra a 20 Elefantes, con edad de " & edad & " años ")

        Else
            If edad And jirafa = True Then

                MsgBox(" Le haran las muestra a 15 Jirafas, con edad de " & edad & " años ")


            End If

            If edad And chimpance = True Then

                MsgBox(" Le haran las muestra a 25 Chimpance, con edad de " & edad & " años ")

            End If


        End If

    End Sub


End Class
