Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles D_Tiempo.Click
        'Variables
        Dim Param, Ext1, Ext2 As String
        Dim etapa, piloto As String
        Dim añoN, etapaN, pilotoN As Integer
        Dim i As Integer

        'Default
        Param = "My.Computer.Network.DownloadFile(""http://00time.scrolly.cf/"
        etapa = "/E"
        piloto = "/P"
        Ext1 = ".txt"", ""C:/Scrolly/temp/00time/"
        Ext2 = ".txt"")"

        'Inicialización
        '   Año
        añoN = Val(InputBox("Ingrese el año"))
        etapaN = Val(InputBox("Ingrese el número de la etapa"))

        'Contadores
        pilotoN = 0
        'Ciclo mayor
        Print.Text = ""
        For i = 1 To 10
            pilotoN = pilotoN + 1
            Print.Text = Print.Text & vbCrLf & Param & añoN & etapa & etapaN & piloto & pilotoN & Ext1 & añoN & etapa & etapaN & piloto & pilotoN & Ext2
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles A_Tiempo.Click
        'Variables
        Dim Param, Ext1 As String
        Dim etapa, piloto, piloto2 As String
        Dim añoN, etapaN, pilotoN As Integer
        Dim i As Integer

        'Inicialización
        '   Año
        añoN = Val(InputBox("Ingrese el año"))

        'Default
        Param = " = My.Computer.FileSystem.ReadAllText(""C:\Scrolly\temp\00time\"
        etapa = "\E"
        piloto = "P"
        piloto2 = "\P"
        Ext1 = ".txt"")"
        '   contadores
        etapaN = 0
        pilotoN = 0

        etapaN = Val(InputBox("Ingrese el número de la etapa"))

        'Ciclo mayor
        Print.Text = ""
        For i = 1 To 10
            pilotoN = pilotoN + 1
            Print.Text = Print.Text & vbCrLf & piloto & pilotoN & Param & añoN & etapa & etapaN & piloto2 & pilotoN & Ext1
        Next i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles D_Distancia.Click
        'Variables
        Dim Param, Param2, Ext1, Ext2, DisEtapa As String
        Dim etapa, etapa2, DE, DE2 As String
        Dim añoN, etapaN As Integer

        '   Año
        añoN = Val(InputBox("Ingrese el año"))
    

        'Default
        Param = "My.Computer.Network.DownloadFile(""http://00dis.scrolly.cf/"
        etapa = "/E"
        DE = "/DE"
        DE2 = "\DE"
        Ext1 = ".txt"", ""C:/Scrolly/temp/00dis/"
        Ext2 = ".txt"")"
        Param2 = " = My.Computer.FileSystem.ReadAllText(""C:\Scrolly\temp\00dis\"
        etapa2 = "\E"
        DisEtapa = "DE"

        etapaN = Val(InputBox("Ingrese el número de la etapa"))

        Print.Text = ""
        Print.Text = Print.Text & vbCrLf & Param & añoN & etapa & etapaN & DE & etapaN & Ext1 & añoN & etapa & etapaN & DE & etapaN & Ext2 _
            & vbCrLf & DisEtapa & etapaN & Param2 & añoN & etapa2 & etapaN & DE2 & etapaN & Ext2
    End Sub
End Class
