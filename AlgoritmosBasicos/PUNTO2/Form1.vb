Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dinero As Double

        dinero = txtSueldo.Text

        If (dinero <> 0 And btn10.Checked) Then

            MsgBox("Su porcentaje es : " & dinero * 0.1)



        ElseIf (dinero <> 0 And btn20.Checked) Then

            MsgBox("Su porcentaje es : " & dinero * 0.2)
        End If





    End Sub

End Class
