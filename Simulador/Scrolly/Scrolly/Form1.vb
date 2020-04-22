Public Class Scrolly
    'Declaración de variables globalaes
    Dim ExcelNom As String
    Dim Hoja As String
    Dim EtapaEnCurso As String
    Dim EtapaActual As Byte
    'Declaración de vectores globales
    Dim Posición() As Integer
    Dim Numero() As Integer
    Dim Nombre() As String
    Dim Marca() As String
    Dim Tiempo() As Long
    Dim TiempoSim() As Long
    Dim Diferencia() As String
    Dim Distancias() As Long
    Dim N As Integer

    '//////////////////////////////////////FUNCIONES//////////////////////////////////////////////////
    '                                   FUNCIÓN ALEATORIOS
    Function Aleatorio(ByVal LimInf As Double, ByVal LimSup As Double) As Double
        Dim Al As Double
        Randomize()
        Al = (LimInf - LimSup) * Rnd() + LimSup
        Return Al
    End Function
    Function Seg2Time(ByVal valor As Long) As String

        Dim Horas, Minutos, Segundos As Decimal
        Dim H, M, S As String
        Dim min1, min2, min3, Seg1, Seg2, Seg3 As Decimal
        Dim Converted As String

        Converted = ""

        'Horas
        Horas = valor \ 3600

        H = CStr(Horas)
        If Horas <= 9 Then
            H = CStr(0 & Horas)
        End If


        'Minutos
        min1 = (valor / 3600) - Horas
        min2 = min1 * 60
        min3 = min2 Mod 1
        Minutos = Int(min2 - min3)

        M = CStr(Minutos)
        If Minutos <= 9 Then
            M = CStr(0 & Minutos)
        End If

        'Segundos
        Seg1 = min2 - Minutos
        Seg2 = Seg1 * 60
        Seg3 = Seg2 Mod 1
        Segundos = Int(Seg2 - Seg3)

        S = CStr(Segundos)
        If Segundos <= 9 Then
            S = CStr(0 & Segundos)
        End If

        'Retornar tiempo convertido
        Converted = H & ":" & M & ":" & S
        Return Converted
    End Function
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

    '////////////////////////////////////////FIN FUNCIONES //////////////////////////////////////////

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Descargar.Click
        'Combo para seleccionar la etapa en curso y descargar ese archivo

        EtapaEnCurso = ComboEtapa.SelectedItem

        If EtapaEnCurso = "Etapa 1" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E1.xlsx", "C:/Scrolly/temp/2016/E1.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 2" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E2.xlsx", "C:/Scrolly/temp/2016/E2.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 3" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E3.xlsx", "C:/Scrolly/temp/2016/E3.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 4" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E4.xlsx", "C:/Scrolly/temp/2016/E4.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 5" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E5.xlsx", "C:/Scrolly/temp/2016/E5.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 6" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E6.xlsx", "C:/Scrolly/temp/2016/E6.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 7" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E7.xlsx", "C:/Scrolly/temp/2016/E7.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 8" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E8.xlsx", "C:/Scrolly/temp/2016/E8.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 9" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E9.xlsx", "C:/Scrolly/temp/2016/E9.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 10" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E10.xlsx", "C:/Scrolly/temp/2016/E10.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 11" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E11.xlsx", "C:/Scrolly/temp/2016/E11.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 12" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E12.xlsx", "C:/Scrolly/temp/2016/E12.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 13" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E13.xlsx", "C:/Scrolly/temp/2016/E13.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        ElseIf EtapaEnCurso = "Etapa 14" Then
            My.Computer.Network.DownloadFile("http://scrolly.cf/2016/E14.xlsx", "C:/Scrolly/temp/2016/E14.xlsx")
            MsgBox("Los datos han sido descargados satisfactoriamente", MsgBoxStyle.Information)
        End If

    End Sub
    'IMPORTAR DATOS A DATAGRIDVIEW
    Private Sub Importar_Click(sender As Object, e As EventArgs) Handles Importar.Click

        EtapaEnCurso = ComboEtapa.SelectedItem

        If EtapaEnCurso = "Etapa 1" Then
            EtapaActual = 1
            ExcelNom = "C:\Scrolly\temp\2016\E1.xlsx"
        ElseIf EtapaEnCurso = "Etapa 2" Then
            EtapaActual = 2
            ExcelNom = "C:\Scrolly\temp\2016\E2.xlsx"
        ElseIf EtapaEnCurso = "Etapa 3" Then
            EtapaActual = 3
            ExcelNom = "C:\Scrolly\temp\2016\E3.xlsx"
        ElseIf EtapaEnCurso = "Etapa 4" Then
            EtapaActual = 4
            ExcelNom = "C:\Scrolly\temp\2016\E4.xlsx"
        ElseIf EtapaEnCurso = "Etapa 5" Then
            EtapaActual = 5
            ExcelNom = "C:\Scrolly\temp\2016\E5.xlsx"
        ElseIf EtapaEnCurso = "Etapa 6" Then
            EtapaActual = 6
            ExcelNom = "C:\Scrolly\temp\2016\E6.xlsx"
        ElseIf EtapaEnCurso = "Etapa 7" Then
            EtapaActual = 7
            ExcelNom = "C:\Scrolly\temp\2016\E7.xlsx"
        ElseIf EtapaEnCurso = "Etapa 8" Then
            EtapaActual = 8
            ExcelNom = "C:\Scrolly\temp\2016\E8.xlsx"
        ElseIf EtapaEnCurso = "Etapa 9" Then
            EtapaActual = 9
            ExcelNom = "C:\Scrolly\temp\2016\E9.xlsx"
        ElseIf EtapaEnCurso = "Etapa 10" Then
            EtapaActual = 10
            ExcelNom = "C:\Scrolly\temp\2016\E10.xlsx"
        ElseIf EtapaEnCurso = "Etapa 11" Then
            EtapaActual = 11
            ExcelNom = "C:\Scrolly\temp\2016\E11.xlsx"
        ElseIf EtapaEnCurso = "Etapa 12" Then
            EtapaActual = 12
            ExcelNom = "C:\Scrolly\temp\2016\E12.xlsx"
        ElseIf EtapaEnCurso = "Etapa 13" Then
            EtapaActual = 13
            ExcelNom = "C:\Scrolly\temp\2016\E13.xlsx"
        ElseIf EtapaEnCurso = "Etapa 14" Then
            EtapaActual = 14
            ExcelNom = "C:\Scrolly\temp\2016\E14.xlsx"
        End If

        Hoja = "Hoja1"
        'Subprograma para importar
        importarExcel(dg1, ExcelNom, Hoja)
    End Sub

    'Extraer datos y almacenarla en vectores
    Private Sub Llenar_Click(sender As Object, e As EventArgs) Handles Llenar.Click

        N = Val(InputBox("Ingrese el número de pilotos a considerar"))
        ReDim Posición(N), Numero(N), Nombre(N), Marca(N), Tiempo(N), Diferencia(N)


        For i = 1 To N
            Posición(i) = dg1.Rows(i - 1).Cells(0).Value
            Numero(i) = Int(dg1.Rows(i - 1).Cells(1).Value)
            Nombre(i) = dg1.Rows(i - 1).Cells(2).Value
            Marca(i) = dg1.Rows(i - 1).Cells(3).Value
            'Tiempo(N) se convierten a segundos:
            Tiempo(i) = ConversionSeg(dg1.Rows(i - 1).Cells(4).Value)
        Next

        For i = 1 To N
            dg1.Rows(i - 1).Cells(4).Value = Tiempo(i)
        Next
    End Sub
    '                       SIMULACIÓN SOBRE EL VECTOR TIEMPO
    Private Sub Simular_Click(sender As Object, e As EventArgs) Handles Simular.Click

        Dim Sw As Integer
        Dim Sup, Inf, Random As Integer
        Dim Promedios(5) As Long
        Dim DisEtapaSig As Long
        Dim ContadorEtapa As Integer

        Sw = Val(InputBox("¿Hasta qué etapa quieres simular?"))

        If (Sw < EtapaActual) Then
            MsgBox("Está tratando de simular una etapa anterior, intente de nuevo.", MsgBoxStyle.Exclamation)
            End
        ElseIf (Sw > 13) Then
            MsgBox("Está tratando de simular una etapa que no existe, intente de nuevo.", MsgBoxStyle.Exclamation)
            End
        End If

        ReDim TiempoSim(N), Distancias(14)

        'Llenado del vector Distancias

        Distancias(1) = 175
        Distancias(2) = 518
        Distancias(3) = 220
        Distancias(4) = 315
        Distancias(5) = 458
        Distancias(6) = 318
        Distancias(7) = 321
        Distancias(8) = 784
        Distancias(9) = 450
        Distancias(10) = 371
        Distancias(11) = 357
        Distancias(12) = 298
        Distancias(13) = 174

        ContadorEtapa = EtapaActual + 1

        '                                   Ciclo grande
        While ContadorEtapa <> Sw + 1

            DisEtapaSig = Distancias(ContadorEtapa)
            Sup = 49
            Inf = 36

            'Simular Tiempos de la etapa siguiente
            For i = 1 To N
                Random = Int(Aleatorio(Inf, Sup))
                'Tiempo con ayuda del aleatorio
                TiempoSim(i) = Tiempo(i) + (DisEtapaSig * Random)
            Next
            ContadorEtapa = ContadorEtapa + 1
        End While
        'Fin Ciclo
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        'ORDENAR LOS VECTORES EN FUNCIÓN DEL TIEMPO SIMULADO

        Dim NumeroTemp As Long
        Dim NombreTemp As String
        Dim MarcaTemp As String
        Dim TiempoTemp As Long

        For i = 1 To N - 1
            For j = i + 1 To N
                If TiempoSim(i) > TiempoSim(j) Then
                    'Pasar los (i) a temporales
                    NumeroTemp = Numero(i) : NombreTemp = Nombre(i) : MarcaTemp = Marca(i) : TiempoTemp = TiempoSim(i)
                    'Pasar los (j) a (i)
                    Numero(i) = Numero(j) : Nombre(i) = Nombre(j) : Marca(i) = Marca(j) : TiempoSim(i) = TiempoSim(j)
                    'Pasar los temporales a (j)
                    Numero(j) = NumeroTemp : Nombre(j) = NombreTemp : Marca(j) = MarcaTemp : TiempoSim(j) = TiempoTemp
                End If
            Next
        Next

        Dim TiempoConv(N) As String
        'Convertir al formato hh:mm:ss
        For i = 1 To N
            TiempoConv(i) = (Seg2Time(TiempoSim(i)))
        Next

        'VECTOR DIFERENCIA
        Diferencia(1) = 0
        For i = 2 To N
            Diferencia(i) = (Seg2Time(TiempoSim(i) - TiempoSim(1)))
        Next
        'Impresión final
        dg2.RowCount = N + 1
        dg2.ColumnCount = 6

        dg2.Rows(0).Cells(0).Value = "Posición"
        dg2.Rows(0).Cells(1).Value = "Número"
        dg2.Rows(0).Cells(2).Value = "Nombre"
        dg2.Rows(0).Cells(3).Value = "Marca"
        dg2.Rows(0).Cells(4).Value = "Tiempo"
        dg2.Rows(0).Cells(5).Value = "Diferencia"

        For i = 1 To N
            dg2.Rows(i).Cells(0).Value = Posición(i)
            dg2.Rows(i).Cells(1).Value = Numero(i)
            dg2.Rows(i).Cells(2).Value = Nombre(i)
            dg2.Rows(i).Cells(3).Value = Marca(i)
            dg2.Rows(i).Cells(4).Value = TiempoConv(i)
            dg2.Rows(i).Cells(5).Value = Diferencia(i)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.FileSystem.DeleteDirectory("C:/Scrolly/", FileIO.DeleteDirectoryOption.DeleteAllContents)
        MsgBox("Ha pulsasdo ""Salir"". Los archivos temporales han sido eliminados, vuelve pronto ;)", MsgBoxStyle.Information, vbYes)
        End
    End Sub

    Private Sub Scrolly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenido a Scrolly, para comenzar selecciona la etapa actual (Se recomienda la etapa 4 ya que contiene datos reales, las demás tienen datos aleatorios)", MsgBoxStyle.Information)
    End Sub
End Class