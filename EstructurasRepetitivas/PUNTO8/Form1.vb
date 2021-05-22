Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        Dim CantidadHombre As Integer = Convert.ToInt32(InputBox("¿Cuantos Hombres?"))

        Dim ihombres As Integer = 0

        Dim totaledadesHombres As Integer = 0

        While CantidadHombre > ihombres

            totaledadesHombres += Convert.ToInt64(InputBox(" Hombre " & ihombres + 1, " Ingrese la edad "))

            ihombres += 1
        End While

        Dim promedioEdadH As Single = totaledadesHombres / CantidadHombre

        MsgBox("El promedio de la edad de los Hombres es: " & promedioEdadH)



        Dim CantidadMujeres As Integer = Convert.ToInt32(InputBox("¿Cuantas Mujeres?"))

        Dim imujeres As Integer = 0

        Dim totaldeMujeres As Integer = 0

        While CantidadMujeres > imujeres

            totaldeMujeres += Convert.ToInt64(InputBox(" Mujer " & imujeres + 1, " Ingrese la edad "))

            imujeres += 1
        End While

        Dim promedioEdadM As Single = totaldeMujeres / CantidadMujeres

        MsgBox("El promedio de la edad de las mujeres es: " & promedioEdadM)

        MsgBox("El promedio de la edad de los Hombres es: " & promedioEdadH & " El promedio de la edad de las mujeres es: " & promedioEdadM)



    End Sub
End Class
