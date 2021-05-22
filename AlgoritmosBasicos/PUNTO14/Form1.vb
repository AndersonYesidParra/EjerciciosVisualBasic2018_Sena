Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim examenM As Integer = Convert.ToUInt32(txtExamenM.Text)

        Dim nota1 As Integer = Convert.ToUInt32(txtTarea1M.Text)

        Dim nota2 As Integer = Convert.ToUInt32(txtTarea2M.Text)

        Dim nota3 As Integer = Convert.ToUInt32(txtTarea3M.Text)

        Dim totalNotas As Integer = ((nota1 + nota2 + nota3) / 3) * 0.1

        txtPromedioM.Text = totalNotas + (examenM * 0.9)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim examenF As Integer = Convert.ToUInt32(txtExamenF.Text)

        Dim notaa1 As Integer = Convert.ToInt32(txtTarea1F.Text)

        Dim notaa2 As Integer = Convert.ToInt32(txtTarea2F.Text)

        Dim totalNotaas As Integer = ((notaa1 + notaa2) / 2) * 0.2

        txtPromedioF.Text = totalNotaas + (examenF * 0.8)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim examenQ As Integer = Convert.ToInt32(txtExamenQ.Text)

        Dim not1 As Integer = Convert.ToInt32(txtTarea1Q.Text)

        Dim not2 As Integer = Convert.ToInt32(txtTarea2Q.Text)

        Dim not3 As Integer = Convert.ToInt32(txtTarea3Q.Text)

        Dim totalnot As Integer = ((not1 + not2 + not3) / 3) * 0.15

        txtPromedioQ.Text = totalnot + (examenQ * 0.85)

    End Sub
End Class
