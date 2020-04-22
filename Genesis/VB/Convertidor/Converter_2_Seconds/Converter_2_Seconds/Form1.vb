Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Long
        Dim hh, mm, ss, time As Long
        Dim SW As Boolean

        num = Val(InputBox("Ingrese el número sin "":"" "))

        'Cálculo de horas
        hh = 0
        If num < 10000 Then
            SW = False
        Else
            SW = True
        End If

        While SW = True
            num = num - 10000
            hh = hh + 1

            If num < 10000 Then
                SW = False
            End If
        End While

        'Cálculo de minutos
        mm = 0
        If num < 100 Then
            SW = False
        Else
            SW = True
        End If

        While SW = True
            num = num - 100
            mm = mm + 1

            If num < 100 Then
                SW = False
            End If
        End While

        'Cálculo Segundos
        ss = num

        'Tiempo =
        time = (hh * 3600) + (mm * 60) + ss

        MsgBox("Sus segundos son: " & time & " s.")
    End Sub
End Class
