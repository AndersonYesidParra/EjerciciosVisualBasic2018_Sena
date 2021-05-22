Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim ninosCantidad As Integer = Convert.ToInt32(txtCantidadninos.Text)

        Dim ininos As Integer = 0

        Dim pesoninos As Single = 0

        While ininos < ninosCantidad

            pesoninos += Convert.ToInt64(InputBox("Peso niño", "Ingrese el peso del niño en Kg"))


            ininos += 1


        End While

        Dim resultadoNinos As Single = pesoninos / ninosCantidad

        MsgBox("Promedio del peso de los niños es : " & resultadoNinos & "Kg")




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim jovenCantidad As Integer = Convert.ToInt32(txtJovenes.Text)

        Dim ijoven As Integer = 0

        Dim pesojoven As Single = 0

        While ijoven < jovenCantidad

            pesojoven += Convert.ToInt64(InputBox("Peso Joven", "Ingrese el peso del joven en Kg"))


            ijoven += 1


        End While

        Dim resultadoJovenes As Single = pesojoven / jovenCantidad

        MsgBox("Promedio del peso de los jovenes es : " & resultadoJovenes & "Kg")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim adultosCantidad As Integer = Convert.ToInt32(txtAdultos.Text)

        Dim iadultos As Integer = 0

        Dim pesoadultos As Single = 0

        While iadultos < adultosCantidad

            pesoadultos += Convert.ToInt64(InputBox("Peso adultos", "Ingrese el peso del adulto en Kg"))


            iadultos += 1


        End While

        Dim resultadoAdultos As Single = pesoadultos / adultosCantidad

        MsgBox("Promedio del peso de los adultos es : " & resultadoAdultos & "Kg")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim viejosCantidad As Integer = Convert.ToInt32(txtViejos.Text)

        Dim iviejos As Integer = 0

        Dim pesoviejos As Single = 0

        While iviejos < viejosCantidad
2
            pesoviejos += Convert.ToInt64(InputBox("Peso viejos", "Ingrese el peso del viejo en Kg"))


            iviejos += 1


        End While

        Dim resultadoViejos As Single = pesoviejos / viejosCantidad

        MsgBox("Promedio del peso de los adultos es : " & resultadoViejos & "Kg")


    End Sub
End Class
