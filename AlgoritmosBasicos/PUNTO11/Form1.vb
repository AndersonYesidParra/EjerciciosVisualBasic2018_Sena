﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim articulo As Single = Convert.ToUInt64(txtArticulo.Text)

        txtGanancia.Text = articulo * 1.3


    End Sub
End Class
