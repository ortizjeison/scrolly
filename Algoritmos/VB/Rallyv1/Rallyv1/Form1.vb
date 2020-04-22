Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Def de variables
        Dim T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12 As Decimal
        Dim D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12 As Decimal
        Dim X1, X2, X3, X4, X5, X6, X7, X8, X9, X10, X11, Prom1 As Decimal
        Dim Horas, Minutos, Segundos As Decimal
        Dim min1, min2, min3, Seg1, Seg2, Seg3, T12ToHoras As Decimal

        'Lectura
        'Time
        T1 = Val(Tiempo1.Text)
        T2 = Val(Tiempo2.Text)
        T3 = Val(Tiempo3.Text)
        T4 = Val(Tiempo4.Text)
        T5 = Val(Tiempo5.Text)
        T6 = Val(Tiempo6.Text)
        T7 = Val(Tiempo7.Text)
        T8 = Val(Tiempo8.Text)
        T9 = Val(Tiempo9.Text)
        T10 = Val(Tiempo10.Text)
        T11 = Val(Tiempo11.Text)
        T12 = Val(Tiempo12.Text)

        'Dis
        D1 = Val(Dis1.Text)
        D2 = Val(Dis2.Text)
        D3 = Val(Dis3.Text)
        D4 = Val(Dis4.Text)
        D5 = Val(Dis5.Text)
        D6 = Val(Dis6.Text)
        D7 = Val(Dis7.Text)
        D8 = Val(Dis8.Text)
        D9 = Val(Dis9.Text)
        D10 = Val(Dis10.Text)
        D11 = Val(Dis11.Text)
        D12 = Val(Dis12.Text)

        'Operaciones
        X1 = T1 / D1
        X2 = T2 / D2
        X3 = T3 / D3
        X4 = T4 / D4
        X5 = T5 / D5
        X6 = T6 / D6
        X7 = T7 / D7
        X8 = T8 / D8
        X9 = T9 / D9
        X10 = T10 / D10
        X11 = T11 / D11

        Prom1 = (X1 + X2 + X3 + X4 + X5 + X6 + X7 + X8 + X9 + X10 + X11) / 11
        'Predicción Etapa 12
        T12 = D12 * Prom1
        T12ToHoras = T12 + 600
        'Conversión unidades de tiempo
        'Horas
        Horas = T12ToHoras \ 3600
        'Minutos
        min1 = (T12ToHoras / 3600) - Horas
        min2 = min1 * 60
        min3 = min2 Mod 1
        Minutos = Format(min2 - min3, "0")
        'Segundos
        Seg1 = min2 - Minutos
        Seg2 = Seg1 * 60
        Seg3 = Seg2 Mod 1
        Segundos = Int(Seg2 - Seg3)
        'Imprimir el tiempo
        Tiempo13.Text = Horas & " : " & Minutos & " : " & Segundos
    End Sub
End Class
