Public Class Scrolly
    'Declaración de variables globalaes
    Dim ExcelNom As String
    Dim Hoja As String
    Dim F, C As Integer
    Dim Datos(,) As Decimal
    Dim D2012(13) As Decimal
    Dim D2013(13) As Decimal
    Dim D2014(13) As Decimal
    Dim D2015(13) As Decimal

    Function ConversionSeg(ByVal num As Long) As Long

        Dim hh, mm, ss, time As Long
        Dim SW As Boolean

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

        'total
        time = (hh * 3600) + (mm * 60) + ss
        Return time
    End Function
    'IMPORTAR DATOS A DATAGRIDVIEW
    Private Sub Importar_Click(sender As Object, e As EventArgs) Handles Importar.Click
        ExcelNom = "C:\prueba\datos.xlsx"
        Hoja = TextBox1.Text
        'Subprograma para importar
        importarExcel(dg1, ExcelNom, Hoja)
    End Sub
    'Extraer datos y almacenarla en vectores
    Private Sub Llenar_Click(sender As Object, e As EventArgs) Handles Llenar.Click
        F = 10
        C = 13
        ReDim Datos(F, C)

        Datos(1, 1) = dg1.Rows(0).Cells(0).Value
        Datos(2, 1) = dg1.Rows(1).Cells(0).Value

        'Almacenamiento en Matriz
        For i = 1 To C
            For j = 1 To F
                Datos(j, i) = dg1.Rows(j - 1).Cells(i - 1).Value
            Next
        Next

        'Conversión a segundos
        For i = 1 To C
            For j = 1 To F
                Datos(j, i) = ConversionSeg(Datos(j, i))
            Next
        Next
        'Impresión
        For i = 1 To C
            For j = 1 To F
                dg1.Rows(j - 1).Cells(i - 1).Value = Datos(j, i)
            Next
        Next

        'DIVIDIR ENTRE LAS DISTANCIAS
        'vectores distancias

        D2015(1) = 175
        D2015(2) = 518
        D2015(3) = 220
        D2015(4) = 315
        D2015(5) = 458
        D2015(6) = 318
        D2015(7) = 321
        D2015(8) = 784
        D2015(9) = 450
        D2015(10) = 371
        D2015(11) = 357
        D2015(12) = 298
        D2015(13) = 174




        For i = 1 To C
            For j = 1 To F
                Datos(j, i) = Datos(j, i) / D2015(i)
            Next j
        Next i


        'Impresión 2
        For i = 1 To C
            For j = 1 To F
                dg1.Rows(j - 1).Cells(i - 1).Value = Datos(j, i)
            Next
        Next
        'Promedio de cada columna
        Dim Suma(C) As Decimal
        Dim Promedio(C) As Decimal

        'Promedio de cada columna
        For i = 1 To C
            Suma(i) = 0
            For j = 1 To F
                Suma(i) = Suma(i) + Datos(j, i)
            Next j
            Promedio(i) = Suma(i) / F
        Next i

        'Impresión de promedios
        For i = 1 To C
            dg1.Rows(10).Cells(i - 1).Value = Promedio(i)
        Next

    End Sub
End Class