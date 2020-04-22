Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn2015.Click
        'Asignación de variables
        Dim Prom2012, Prom2013, Prom2014, Prom2015 As Long
        Dim P1, P2, P3, P4, P5, P6, P7, P8, P9, P10 As Long
        Dim DE1, DE2, DE3, DE4, DE5, DE6, DE7, DE8, DE9, DE10, DE11, DE12, DE13, DE14 As Long
        Dim E1, E2, E3, E4, E5, E6, E7, E8, E9, E10, E11, E12, E13, E14 As Long
        Dim Prom, Dif1, Dif2, Dif3 As Long

        '2012
        '///////////////////////////////////////////////Etapa 1 - 2012 //////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P1.txt", "C:/Scrolly/temp/00time/2012/E1/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P2.txt", "C:/Scrolly/temp/00time/2012/E1/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P3.txt", "C:/Scrolly/temp/00time/2012/E1/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P4.txt", "C:/Scrolly/temp/00time/2012/E1/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P5.txt", "C:/Scrolly/temp/00time/2012/E1/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P6.txt", "C:/Scrolly/temp/00time/2012/E1/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P7.txt", "C:/Scrolly/temp/00time/2012/E1/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P8.txt", "C:/Scrolly/temp/00time/2012/E1/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P9.txt", "C:/Scrolly/temp/00time/2012/E1/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E1/P10.txt", "C:/Scrolly/temp/00time/2012/E1/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E1\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E1/DE1.txt", "C:/Scrolly/temp/00dis/2012/E1/DE1.txt")
        DE1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E1\DE1.txt")

        E1 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE1


        '///////////////////////////////////////////////Etapa 1 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P1.txt", "C:/Scrolly/temp/00time/2012/E2/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P2.txt", "C:/Scrolly/temp/00time/2012/E2/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P3.txt", "C:/Scrolly/temp/00time/2012/E2/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P4.txt", "C:/Scrolly/temp/00time/2012/E2/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P5.txt", "C:/Scrolly/temp/00time/2012/E2/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P6.txt", "C:/Scrolly/temp/00time/2012/E2/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P7.txt", "C:/Scrolly/temp/00time/2012/E2/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P8.txt", "C:/Scrolly/temp/00time/2012/E2/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P9.txt", "C:/Scrolly/temp/00time/2012/E2/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E2/P10.txt", "C:/Scrolly/temp/00time/2012/E2/P10.txt")

        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E2\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E2/DE2.txt", "C:/Scrolly/temp/00dis/2012/E2/DE2.txt")
        DE2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E2\DE2.txt")

        E2 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE2

        '///////////////////////////////////////////////Etapa 3 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P1.txt", "C:/Scrolly/temp/00time/2012/E3/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P2.txt", "C:/Scrolly/temp/00time/2012/E3/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P3.txt", "C:/Scrolly/temp/00time/2012/E3/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P4.txt", "C:/Scrolly/temp/00time/2012/E3/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P5.txt", "C:/Scrolly/temp/00time/2012/E3/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P6.txt", "C:/Scrolly/temp/00time/2012/E3/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P7.txt", "C:/Scrolly/temp/00time/2012/E3/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P8.txt", "C:/Scrolly/temp/00time/2012/E3/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P9.txt", "C:/Scrolly/temp/00time/2012/E3/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E3/P10.txt", "C:/Scrolly/temp/00time/2012/E3/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E3\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E3/DE3.txt", "C:/Scrolly/temp/00dis/2012/E3/DE3.txt")
        DE3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E3\DE3.txt")

        E3 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE3

        '///////////////////////////////////////////////Etapa 4 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P1.txt", "C:/Scrolly/temp/00time/2012/E4/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P2.txt", "C:/Scrolly/temp/00time/2012/E4/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P3.txt", "C:/Scrolly/temp/00time/2012/E4/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P4.txt", "C:/Scrolly/temp/00time/2012/E4/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P5.txt", "C:/Scrolly/temp/00time/2012/E4/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P6.txt", "C:/Scrolly/temp/00time/2012/E4/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P7.txt", "C:/Scrolly/temp/00time/2012/E4/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P8.txt", "C:/Scrolly/temp/00time/2012/E4/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P9.txt", "C:/Scrolly/temp/00time/2012/E4/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E4/P10.txt", "C:/Scrolly/temp/00time/2012/E4/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E4\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E4/DE4.txt", "C:/Scrolly/temp/00dis/2012/E4/DE4.txt")
        DE4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E4\DE4.txt")

        E4 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE4

        '///////////////////////////////////////////////Etapa 5 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P1.txt", "C:/Scrolly/temp/00time/2012/E5/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P2.txt", "C:/Scrolly/temp/00time/2012/E5/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P3.txt", "C:/Scrolly/temp/00time/2012/E5/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P4.txt", "C:/Scrolly/temp/00time/2012/E5/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P5.txt", "C:/Scrolly/temp/00time/2012/E5/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P6.txt", "C:/Scrolly/temp/00time/2012/E5/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P7.txt", "C:/Scrolly/temp/00time/2012/E5/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P8.txt", "C:/Scrolly/temp/00time/2012/E5/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P9.txt", "C:/Scrolly/temp/00time/2012/E5/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E5/P10.txt", "C:/Scrolly/temp/00time/2012/E5/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E5\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E5/DE5.txt", "C:/Scrolly/temp/00dis/2012/E5/DE5.txt")
        DE5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E5\DE5.txt")

        E5 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE5

        '///////////////////////////////////////////////Etapa 6 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P1.txt", "C:/Scrolly/temp/00time/2012/E6/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P2.txt", "C:/Scrolly/temp/00time/2012/E6/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P3.txt", "C:/Scrolly/temp/00time/2012/E6/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P4.txt", "C:/Scrolly/temp/00time/2012/E6/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P5.txt", "C:/Scrolly/temp/00time/2012/E6/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P6.txt", "C:/Scrolly/temp/00time/2012/E6/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P7.txt", "C:/Scrolly/temp/00time/2012/E6/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P8.txt", "C:/Scrolly/temp/00time/2012/E6/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P9.txt", "C:/Scrolly/temp/00time/2012/E6/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E6/P10.txt", "C:/Scrolly/temp/00time/2012/E6/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E6\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E6/DE6.txt", "C:/Scrolly/temp/00dis/2012/E6/DE6.txt")
        DE6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E6\DE6.txt")

        E6 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE6

        '///////////////////////////////////////////////Etapa 7 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P1.txt", "C:/Scrolly/temp/00time/2012/E7/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P2.txt", "C:/Scrolly/temp/00time/2012/E7/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P3.txt", "C:/Scrolly/temp/00time/2012/E7/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P4.txt", "C:/Scrolly/temp/00time/2012/E7/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P5.txt", "C:/Scrolly/temp/00time/2012/E7/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P6.txt", "C:/Scrolly/temp/00time/2012/E7/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P7.txt", "C:/Scrolly/temp/00time/2012/E7/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P8.txt", "C:/Scrolly/temp/00time/2012/E7/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P9.txt", "C:/Scrolly/temp/00time/2012/E7/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E7/P10.txt", "C:/Scrolly/temp/00time/2012/E7/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E7\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E7/DE7.txt", "C:/Scrolly/temp/00dis/2012/E7/DE7.txt")
        DE7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E7\DE7.txt")

        E7 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE7

        '///////////////////////////////////////////////Etapa 8 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P1.txt", "C:/Scrolly/temp/00time/2012/E8/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P2.txt", "C:/Scrolly/temp/00time/2012/E8/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P3.txt", "C:/Scrolly/temp/00time/2012/E8/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P4.txt", "C:/Scrolly/temp/00time/2012/E8/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P5.txt", "C:/Scrolly/temp/00time/2012/E8/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P6.txt", "C:/Scrolly/temp/00time/2012/E8/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P7.txt", "C:/Scrolly/temp/00time/2012/E8/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P8.txt", "C:/Scrolly/temp/00time/2012/E8/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P9.txt", "C:/Scrolly/temp/00time/2012/E8/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E8/P10.txt", "C:/Scrolly/temp/00time/2012/E8/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E8\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E8/DE8.txt", "C:/Scrolly/temp/00dis/2012/E8/DE8.txt")
        DE8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E8\DE8.txt")

        E8 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE8

        '///////////////////////////////////////////////Etapa 9 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P1.txt", "C:/Scrolly/temp/00time/2012/E9/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P2.txt", "C:/Scrolly/temp/00time/2012/E9/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P3.txt", "C:/Scrolly/temp/00time/2012/E9/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P4.txt", "C:/Scrolly/temp/00time/2012/E9/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P5.txt", "C:/Scrolly/temp/00time/2012/E9/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P6.txt", "C:/Scrolly/temp/00time/2012/E9/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P7.txt", "C:/Scrolly/temp/00time/2012/E9/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P8.txt", "C:/Scrolly/temp/00time/2012/E9/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P9.txt", "C:/Scrolly/temp/00time/2012/E9/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E9/P10.txt", "C:/Scrolly/temp/00time/2012/E9/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E9\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E9/DE9.txt", "C:/Scrolly/temp/00dis/2012/E9/DE9.txt")
        DE9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E9\DE9.txt")

        E9 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE9

        '///////////////////////////////////////////////Etapa 10 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P1.txt", "C:/Scrolly/temp/00time/2012/E10/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P2.txt", "C:/Scrolly/temp/00time/2012/E10/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P3.txt", "C:/Scrolly/temp/00time/2012/E10/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P4.txt", "C:/Scrolly/temp/00time/2012/E10/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P5.txt", "C:/Scrolly/temp/00time/2012/E10/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P6.txt", "C:/Scrolly/temp/00time/2012/E10/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P7.txt", "C:/Scrolly/temp/00time/2012/E10/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P8.txt", "C:/Scrolly/temp/00time/2012/E10/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P9.txt", "C:/Scrolly/temp/00time/2012/E10/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E10/P10.txt", "C:/Scrolly/temp/00time/2012/E10/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E10\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E10/DE10.txt", "C:/Scrolly/temp/00dis/2012/E10/DE10.txt")
        DE10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E10\DE10.txt")

        E10 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE10

        '///////////////////////////////////////////////Etapa 11 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P1.txt", "C:/Scrolly/temp/00time/2012/E11/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P2.txt", "C:/Scrolly/temp/00time/2012/E11/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P3.txt", "C:/Scrolly/temp/00time/2012/E11/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P4.txt", "C:/Scrolly/temp/00time/2012/E11/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P5.txt", "C:/Scrolly/temp/00time/2012/E11/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P6.txt", "C:/Scrolly/temp/00time/2012/E11/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P7.txt", "C:/Scrolly/temp/00time/2012/E11/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P8.txt", "C:/Scrolly/temp/00time/2012/E11/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P9.txt", "C:/Scrolly/temp/00time/2012/E11/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E11/P10.txt", "C:/Scrolly/temp/00time/2012/E11/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E11\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E11/DE11.txt", "C:/Scrolly/temp/00dis/2012/E11/DE11.txt")
        DE11 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E11\DE11.txt")

        E11 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE11

        '///////////////////////////////////////////////Etapa 12 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P1.txt", "C:/Scrolly/temp/00time/2012/E12/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P2.txt", "C:/Scrolly/temp/00time/2012/E12/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P3.txt", "C:/Scrolly/temp/00time/2012/E12/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P4.txt", "C:/Scrolly/temp/00time/2012/E12/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P5.txt", "C:/Scrolly/temp/00time/2012/E12/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P6.txt", "C:/Scrolly/temp/00time/2012/E12/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P7.txt", "C:/Scrolly/temp/00time/2012/E12/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P8.txt", "C:/Scrolly/temp/00time/2012/E12/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P9.txt", "C:/Scrolly/temp/00time/2012/E12/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E12/P10.txt", "C:/Scrolly/temp/00time/2012/E12/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E12\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E12/DE12.txt", "C:/Scrolly/temp/00dis/2012/E12/DE12.txt")
        DE12 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E12\DE12.txt")
        E12 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE12

        '///////////////////////////////////////////////Etapa 13 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P1.txt", "C:/Scrolly/temp/00time/2012/E13/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P2.txt", "C:/Scrolly/temp/00time/2012/E13/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P3.txt", "C:/Scrolly/temp/00time/2012/E13/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P4.txt", "C:/Scrolly/temp/00time/2012/E13/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P5.txt", "C:/Scrolly/temp/00time/2012/E13/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P6.txt", "C:/Scrolly/temp/00time/2012/E13/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P7.txt", "C:/Scrolly/temp/00time/2012/E13/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P8.txt", "C:/Scrolly/temp/00time/2012/E13/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P9.txt", "C:/Scrolly/temp/00time/2012/E13/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E13/P10.txt", "C:/Scrolly/temp/00time/2012/E13/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E13\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E13/DE13.txt", "C:/Scrolly/temp/00dis/2012/E13/DE13.txt")
        DE13 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E13\DE13.txt")

        E13 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE13

        '///////////////////////////////////////////////Etapa 14 - 2012 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P1.txt", "C:/Scrolly/temp/00time/2012/E14/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P2.txt", "C:/Scrolly/temp/00time/2012/E14/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P3.txt", "C:/Scrolly/temp/00time/2012/E14/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P4.txt", "C:/Scrolly/temp/00time/2012/E14/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P5.txt", "C:/Scrolly/temp/00time/2012/E14/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P6.txt", "C:/Scrolly/temp/00time/2012/E14/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P7.txt", "C:/Scrolly/temp/00time/2012/E14/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P8.txt", "C:/Scrolly/temp/00time/2012/E14/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P9.txt", "C:/Scrolly/temp/00time/2012/E14/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2012/E14/P10.txt", "C:/Scrolly/temp/00time/2012/E14/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2012\E14\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2012/E14/DE14.txt", "C:/Scrolly/temp/00dis/2012/E14/DE14.txt")
        DE14 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2012\E14\DE14.txt")

        E14 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE14

        Prom2012 = (E1 + E2 + E3 + E4 + E5 + E5 + E6 + E7 + E8 + E9 + E10 + E11 + E12 + E13 + E14) / 14
        Progress.Items.Add("Promedio 2012 = " & Prom2012)
        ' 2013

        '///////////////////////////////////////////////Etapa 1 - 2013 //////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P1.txt", "C:/Scrolly/temp/00time/2013/E1/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P2.txt", "C:/Scrolly/temp/00time/2013/E1/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P3.txt", "C:/Scrolly/temp/00time/2013/E1/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P4.txt", "C:/Scrolly/temp/00time/2013/E1/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P5.txt", "C:/Scrolly/temp/00time/2013/E1/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P6.txt", "C:/Scrolly/temp/00time/2013/E1/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P7.txt", "C:/Scrolly/temp/00time/2013/E1/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P8.txt", "C:/Scrolly/temp/00time/2013/E1/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P9.txt", "C:/Scrolly/temp/00time/2013/E1/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E1/P10.txt", "C:/Scrolly/temp/00time/2013/E1/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E1\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E1/DE1.txt", "C:/Scrolly/temp/00dis/2013/E1/DE1.txt")
        DE1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E1\DE1.txt")

        E1 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE1


        '///////////////////////////////////////////////Etapa 1 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P1.txt", "C:/Scrolly/temp/00time/2013/E2/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P2.txt", "C:/Scrolly/temp/00time/2013/E2/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P3.txt", "C:/Scrolly/temp/00time/2013/E2/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P4.txt", "C:/Scrolly/temp/00time/2013/E2/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P5.txt", "C:/Scrolly/temp/00time/2013/E2/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P6.txt", "C:/Scrolly/temp/00time/2013/E2/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P7.txt", "C:/Scrolly/temp/00time/2013/E2/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P8.txt", "C:/Scrolly/temp/00time/2013/E2/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P9.txt", "C:/Scrolly/temp/00time/2013/E2/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E2/P10.txt", "C:/Scrolly/temp/00time/2013/E2/P10.txt")

        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E2\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E2/DE2.txt", "C:/Scrolly/temp/00dis/2013/E2/DE2.txt")
        DE2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E2\DE2.txt")

        E2 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE2

        '///////////////////////////////////////////////Etapa 3 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P1.txt", "C:/Scrolly/temp/00time/2013/E3/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P2.txt", "C:/Scrolly/temp/00time/2013/E3/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P3.txt", "C:/Scrolly/temp/00time/2013/E3/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P4.txt", "C:/Scrolly/temp/00time/2013/E3/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P5.txt", "C:/Scrolly/temp/00time/2013/E3/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P6.txt", "C:/Scrolly/temp/00time/2013/E3/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P7.txt", "C:/Scrolly/temp/00time/2013/E3/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P8.txt", "C:/Scrolly/temp/00time/2013/E3/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P9.txt", "C:/Scrolly/temp/00time/2013/E3/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E3/P10.txt", "C:/Scrolly/temp/00time/2013/E3/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E3\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E3/DE3.txt", "C:/Scrolly/temp/00dis/2013/E3/DE3.txt")
        DE3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E3\DE3.txt")

        E3 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE3

        '///////////////////////////////////////////////Etapa 4 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P1.txt", "C:/Scrolly/temp/00time/2013/E4/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P2.txt", "C:/Scrolly/temp/00time/2013/E4/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P3.txt", "C:/Scrolly/temp/00time/2013/E4/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P4.txt", "C:/Scrolly/temp/00time/2013/E4/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P5.txt", "C:/Scrolly/temp/00time/2013/E4/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P6.txt", "C:/Scrolly/temp/00time/2013/E4/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P7.txt", "C:/Scrolly/temp/00time/2013/E4/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P8.txt", "C:/Scrolly/temp/00time/2013/E4/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P9.txt", "C:/Scrolly/temp/00time/2013/E4/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E4/P10.txt", "C:/Scrolly/temp/00time/2013/E4/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E4\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E4/DE4.txt", "C:/Scrolly/temp/00dis/2013/E4/DE4.txt")
        DE4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E4\DE4.txt")

        E4 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE4

        '///////////////////////////////////////////////Etapa 5 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P1.txt", "C:/Scrolly/temp/00time/2013/E5/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P2.txt", "C:/Scrolly/temp/00time/2013/E5/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P3.txt", "C:/Scrolly/temp/00time/2013/E5/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P4.txt", "C:/Scrolly/temp/00time/2013/E5/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P5.txt", "C:/Scrolly/temp/00time/2013/E5/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P6.txt", "C:/Scrolly/temp/00time/2013/E5/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P7.txt", "C:/Scrolly/temp/00time/2013/E5/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P8.txt", "C:/Scrolly/temp/00time/2013/E5/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P9.txt", "C:/Scrolly/temp/00time/2013/E5/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E5/P10.txt", "C:/Scrolly/temp/00time/2013/E5/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E5\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E5/DE5.txt", "C:/Scrolly/temp/00dis/2013/E5/DE5.txt")
        DE5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E5\DE5.txt")

        E5 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE5

        '///////////////////////////////////////////////Etapa 6 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P1.txt", "C:/Scrolly/temp/00time/2013/E6/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P2.txt", "C:/Scrolly/temp/00time/2013/E6/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P3.txt", "C:/Scrolly/temp/00time/2013/E6/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P4.txt", "C:/Scrolly/temp/00time/2013/E6/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P5.txt", "C:/Scrolly/temp/00time/2013/E6/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P6.txt", "C:/Scrolly/temp/00time/2013/E6/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P7.txt", "C:/Scrolly/temp/00time/2013/E6/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P8.txt", "C:/Scrolly/temp/00time/2013/E6/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P9.txt", "C:/Scrolly/temp/00time/2013/E6/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E6/P10.txt", "C:/Scrolly/temp/00time/2013/E6/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E6\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E6/DE6.txt", "C:/Scrolly/temp/00dis/2013/E6/DE6.txt")
        DE6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E6\DE6.txt")

        E6 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE6

        '///////////////////////////////////////////////Etapa 7 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P1.txt", "C:/Scrolly/temp/00time/2013/E7/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P2.txt", "C:/Scrolly/temp/00time/2013/E7/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P3.txt", "C:/Scrolly/temp/00time/2013/E7/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P4.txt", "C:/Scrolly/temp/00time/2013/E7/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P5.txt", "C:/Scrolly/temp/00time/2013/E7/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P6.txt", "C:/Scrolly/temp/00time/2013/E7/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P7.txt", "C:/Scrolly/temp/00time/2013/E7/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P8.txt", "C:/Scrolly/temp/00time/2013/E7/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P9.txt", "C:/Scrolly/temp/00time/2013/E7/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E7/P10.txt", "C:/Scrolly/temp/00time/2013/E7/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E7\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E7/DE7.txt", "C:/Scrolly/temp/00dis/2013/E7/DE7.txt")
        DE7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E7\DE7.txt")

        E7 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE7

        '///////////////////////////////////////////////Etapa 8 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P1.txt", "C:/Scrolly/temp/00time/2013/E8/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P2.txt", "C:/Scrolly/temp/00time/2013/E8/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P3.txt", "C:/Scrolly/temp/00time/2013/E8/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P4.txt", "C:/Scrolly/temp/00time/2013/E8/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P5.txt", "C:/Scrolly/temp/00time/2013/E8/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P6.txt", "C:/Scrolly/temp/00time/2013/E8/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P7.txt", "C:/Scrolly/temp/00time/2013/E8/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P8.txt", "C:/Scrolly/temp/00time/2013/E8/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P9.txt", "C:/Scrolly/temp/00time/2013/E8/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E8/P10.txt", "C:/Scrolly/temp/00time/2013/E8/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E8\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E8/DE8.txt", "C:/Scrolly/temp/00dis/2013/E8/DE8.txt")
        DE8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E8\DE8.txt")

        E8 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE8

        '///////////////////////////////////////////////Etapa 9 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P1.txt", "C:/Scrolly/temp/00time/2013/E9/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P2.txt", "C:/Scrolly/temp/00time/2013/E9/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P3.txt", "C:/Scrolly/temp/00time/2013/E9/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P4.txt", "C:/Scrolly/temp/00time/2013/E9/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P5.txt", "C:/Scrolly/temp/00time/2013/E9/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P6.txt", "C:/Scrolly/temp/00time/2013/E9/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P7.txt", "C:/Scrolly/temp/00time/2013/E9/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P8.txt", "C:/Scrolly/temp/00time/2013/E9/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P9.txt", "C:/Scrolly/temp/00time/2013/E9/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E9/P10.txt", "C:/Scrolly/temp/00time/2013/E9/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E9\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E9/DE9.txt", "C:/Scrolly/temp/00dis/2013/E9/DE9.txt")
        DE9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E9\DE9.txt")

        E9 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE9

        '///////////////////////////////////////////////Etapa 10 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P1.txt", "C:/Scrolly/temp/00time/2013/E10/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P2.txt", "C:/Scrolly/temp/00time/2013/E10/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P3.txt", "C:/Scrolly/temp/00time/2013/E10/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P4.txt", "C:/Scrolly/temp/00time/2013/E10/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P5.txt", "C:/Scrolly/temp/00time/2013/E10/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P6.txt", "C:/Scrolly/temp/00time/2013/E10/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P7.txt", "C:/Scrolly/temp/00time/2013/E10/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P8.txt", "C:/Scrolly/temp/00time/2013/E10/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P9.txt", "C:/Scrolly/temp/00time/2013/E10/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E10/P10.txt", "C:/Scrolly/temp/00time/2013/E10/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E10\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E10/DE10.txt", "C:/Scrolly/temp/00dis/2013/E10/DE10.txt")
        DE10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E10\DE10.txt")

        E10 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE10

        '///////////////////////////////////////////////Etapa 11 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P1.txt", "C:/Scrolly/temp/00time/2013/E11/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P2.txt", "C:/Scrolly/temp/00time/2013/E11/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P3.txt", "C:/Scrolly/temp/00time/2013/E11/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P4.txt", "C:/Scrolly/temp/00time/2013/E11/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P5.txt", "C:/Scrolly/temp/00time/2013/E11/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P6.txt", "C:/Scrolly/temp/00time/2013/E11/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P7.txt", "C:/Scrolly/temp/00time/2013/E11/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P8.txt", "C:/Scrolly/temp/00time/2013/E11/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P9.txt", "C:/Scrolly/temp/00time/2013/E11/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E11/P10.txt", "C:/Scrolly/temp/00time/2013/E11/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E11\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E11/DE11.txt", "C:/Scrolly/temp/00dis/2013/E11/DE11.txt")
        DE11 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E11\DE11.txt")

        E11 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE11

        '///////////////////////////////////////////////Etapa 12 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P1.txt", "C:/Scrolly/temp/00time/2013/E12/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P2.txt", "C:/Scrolly/temp/00time/2013/E12/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P3.txt", "C:/Scrolly/temp/00time/2013/E12/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P4.txt", "C:/Scrolly/temp/00time/2013/E12/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P5.txt", "C:/Scrolly/temp/00time/2013/E12/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P6.txt", "C:/Scrolly/temp/00time/2013/E12/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P7.txt", "C:/Scrolly/temp/00time/2013/E12/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P8.txt", "C:/Scrolly/temp/00time/2013/E12/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P9.txt", "C:/Scrolly/temp/00time/2013/E12/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E12/P10.txt", "C:/Scrolly/temp/00time/2013/E12/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E12\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E12/DE12.txt", "C:/Scrolly/temp/00dis/2013/E12/DE12.txt")
        DE12 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E12\DE12.txt")
        E12 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE12

        '///////////////////////////////////////////////Etapa 13 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P1.txt", "C:/Scrolly/temp/00time/2013/E13/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P2.txt", "C:/Scrolly/temp/00time/2013/E13/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P3.txt", "C:/Scrolly/temp/00time/2013/E13/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P4.txt", "C:/Scrolly/temp/00time/2013/E13/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P5.txt", "C:/Scrolly/temp/00time/2013/E13/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P6.txt", "C:/Scrolly/temp/00time/2013/E13/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P7.txt", "C:/Scrolly/temp/00time/2013/E13/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P8.txt", "C:/Scrolly/temp/00time/2013/E13/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P9.txt", "C:/Scrolly/temp/00time/2013/E13/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E13/P10.txt", "C:/Scrolly/temp/00time/2013/E13/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E13\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E13/DE13.txt", "C:/Scrolly/temp/00dis/2013/E13/DE13.txt")
        DE13 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E13\DE13.txt")

        E13 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE13

        '///////////////////////////////////////////////Etapa 14 - 2013 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P1.txt", "C:/Scrolly/temp/00time/2013/E14/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P2.txt", "C:/Scrolly/temp/00time/2013/E14/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P3.txt", "C:/Scrolly/temp/00time/2013/E14/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P4.txt", "C:/Scrolly/temp/00time/2013/E14/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P5.txt", "C:/Scrolly/temp/00time/2013/E14/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P6.txt", "C:/Scrolly/temp/00time/2013/E14/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P7.txt", "C:/Scrolly/temp/00time/2013/E14/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P8.txt", "C:/Scrolly/temp/00time/2013/E14/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P9.txt", "C:/Scrolly/temp/00time/2013/E14/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2013/E14/P10.txt", "C:/Scrolly/temp/00time/2013/E14/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2013\E14\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2013/E14/DE14.txt", "C:/Scrolly/temp/00dis/2013/E14/DE14.txt")
        DE14 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2013\E14\DE14.txt")

        E14 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE14
        Prom2013 = (E1 + E2 + E3 + E4 + E5 + E5 + E6 + E7 + E8 + E9 + E10 + E11 + E12 + E13 + E14) / 14
        Progress.Items.Add("Promedio 2013 = " & Prom2013)

        '2014
        '///////////////////////////////////////////////Etapa 1 - 2014 //////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P1.txt", "C:/Scrolly/temp/00time/2014/E1/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P2.txt", "C:/Scrolly/temp/00time/2014/E1/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P3.txt", "C:/Scrolly/temp/00time/2014/E1/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P4.txt", "C:/Scrolly/temp/00time/2014/E1/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P5.txt", "C:/Scrolly/temp/00time/2014/E1/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P6.txt", "C:/Scrolly/temp/00time/2014/E1/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P7.txt", "C:/Scrolly/temp/00time/2014/E1/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P8.txt", "C:/Scrolly/temp/00time/2014/E1/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P9.txt", "C:/Scrolly/temp/00time/2014/E1/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E1/P10.txt", "C:/Scrolly/temp/00time/2014/E1/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E1\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E1/DE1.txt", "C:/Scrolly/temp/00dis/2014/E1/DE1.txt")
        DE1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E1\DE1.txt")

        E1 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE1


        '///////////////////////////////////////////////Etapa 1 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P1.txt", "C:/Scrolly/temp/00time/2014/E2/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P2.txt", "C:/Scrolly/temp/00time/2014/E2/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P3.txt", "C:/Scrolly/temp/00time/2014/E2/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P4.txt", "C:/Scrolly/temp/00time/2014/E2/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P5.txt", "C:/Scrolly/temp/00time/2014/E2/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P6.txt", "C:/Scrolly/temp/00time/2014/E2/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P7.txt", "C:/Scrolly/temp/00time/2014/E2/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P8.txt", "C:/Scrolly/temp/00time/2014/E2/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P9.txt", "C:/Scrolly/temp/00time/2014/E2/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E2/P10.txt", "C:/Scrolly/temp/00time/2014/E2/P10.txt")

        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E2\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E2/DE2.txt", "C:/Scrolly/temp/00dis/2014/E2/DE2.txt")
        DE2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E2\DE2.txt")

        E2 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE2

        '///////////////////////////////////////////////Etapa 3 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P1.txt", "C:/Scrolly/temp/00time/2014/E3/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P2.txt", "C:/Scrolly/temp/00time/2014/E3/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P3.txt", "C:/Scrolly/temp/00time/2014/E3/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P4.txt", "C:/Scrolly/temp/00time/2014/E3/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P5.txt", "C:/Scrolly/temp/00time/2014/E3/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P6.txt", "C:/Scrolly/temp/00time/2014/E3/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P7.txt", "C:/Scrolly/temp/00time/2014/E3/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P8.txt", "C:/Scrolly/temp/00time/2014/E3/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P9.txt", "C:/Scrolly/temp/00time/2014/E3/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E3/P10.txt", "C:/Scrolly/temp/00time/2014/E3/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E3\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E3/DE3.txt", "C:/Scrolly/temp/00dis/2014/E3/DE3.txt")
        DE3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E3\DE3.txt")

        E3 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE3

        '///////////////////////////////////////////////Etapa 4 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P1.txt", "C:/Scrolly/temp/00time/2014/E4/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P2.txt", "C:/Scrolly/temp/00time/2014/E4/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P3.txt", "C:/Scrolly/temp/00time/2014/E4/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P4.txt", "C:/Scrolly/temp/00time/2014/E4/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P5.txt", "C:/Scrolly/temp/00time/2014/E4/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P6.txt", "C:/Scrolly/temp/00time/2014/E4/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P7.txt", "C:/Scrolly/temp/00time/2014/E4/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P8.txt", "C:/Scrolly/temp/00time/2014/E4/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P9.txt", "C:/Scrolly/temp/00time/2014/E4/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E4/P10.txt", "C:/Scrolly/temp/00time/2014/E4/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E4\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E4/DE4.txt", "C:/Scrolly/temp/00dis/2014/E4/DE4.txt")
        DE4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E4\DE4.txt")

        E4 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE4

        '///////////////////////////////////////////////Etapa 5 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P1.txt", "C:/Scrolly/temp/00time/2014/E5/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P2.txt", "C:/Scrolly/temp/00time/2014/E5/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P3.txt", "C:/Scrolly/temp/00time/2014/E5/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P4.txt", "C:/Scrolly/temp/00time/2014/E5/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P5.txt", "C:/Scrolly/temp/00time/2014/E5/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P6.txt", "C:/Scrolly/temp/00time/2014/E5/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P7.txt", "C:/Scrolly/temp/00time/2014/E5/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P8.txt", "C:/Scrolly/temp/00time/2014/E5/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P9.txt", "C:/Scrolly/temp/00time/2014/E5/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E5/P10.txt", "C:/Scrolly/temp/00time/2014/E5/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E5\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E5/DE5.txt", "C:/Scrolly/temp/00dis/2014/E5/DE5.txt")
        DE5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E5\DE5.txt")

        E5 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE5

        '///////////////////////////////////////////////Etapa 6 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P1.txt", "C:/Scrolly/temp/00time/2014/E6/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P2.txt", "C:/Scrolly/temp/00time/2014/E6/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P3.txt", "C:/Scrolly/temp/00time/2014/E6/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P4.txt", "C:/Scrolly/temp/00time/2014/E6/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P5.txt", "C:/Scrolly/temp/00time/2014/E6/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P6.txt", "C:/Scrolly/temp/00time/2014/E6/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P7.txt", "C:/Scrolly/temp/00time/2014/E6/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P8.txt", "C:/Scrolly/temp/00time/2014/E6/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P9.txt", "C:/Scrolly/temp/00time/2014/E6/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E6/P10.txt", "C:/Scrolly/temp/00time/2014/E6/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E6\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E6/DE6.txt", "C:/Scrolly/temp/00dis/2014/E6/DE6.txt")
        DE6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E6\DE6.txt")

        E6 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE6

        '///////////////////////////////////////////////Etapa 7 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P1.txt", "C:/Scrolly/temp/00time/2014/E7/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P2.txt", "C:/Scrolly/temp/00time/2014/E7/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P3.txt", "C:/Scrolly/temp/00time/2014/E7/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P4.txt", "C:/Scrolly/temp/00time/2014/E7/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P5.txt", "C:/Scrolly/temp/00time/2014/E7/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P6.txt", "C:/Scrolly/temp/00time/2014/E7/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P7.txt", "C:/Scrolly/temp/00time/2014/E7/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P8.txt", "C:/Scrolly/temp/00time/2014/E7/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P9.txt", "C:/Scrolly/temp/00time/2014/E7/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E7/P10.txt", "C:/Scrolly/temp/00time/2014/E7/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E7\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E7/DE7.txt", "C:/Scrolly/temp/00dis/2014/E7/DE7.txt")
        DE7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E7\DE7.txt")

        E7 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE7

        '///////////////////////////////////////////////Etapa 8 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P1.txt", "C:/Scrolly/temp/00time/2014/E8/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P2.txt", "C:/Scrolly/temp/00time/2014/E8/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P3.txt", "C:/Scrolly/temp/00time/2014/E8/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P4.txt", "C:/Scrolly/temp/00time/2014/E8/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P5.txt", "C:/Scrolly/temp/00time/2014/E8/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P6.txt", "C:/Scrolly/temp/00time/2014/E8/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P7.txt", "C:/Scrolly/temp/00time/2014/E8/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P8.txt", "C:/Scrolly/temp/00time/2014/E8/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P9.txt", "C:/Scrolly/temp/00time/2014/E8/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E8/P10.txt", "C:/Scrolly/temp/00time/2014/E8/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E8\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E8/DE8.txt", "C:/Scrolly/temp/00dis/2014/E8/DE8.txt")
        DE8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E8\DE8.txt")

        E8 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE8

        '///////////////////////////////////////////////Etapa 9 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P1.txt", "C:/Scrolly/temp/00time/2014/E9/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P2.txt", "C:/Scrolly/temp/00time/2014/E9/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P3.txt", "C:/Scrolly/temp/00time/2014/E9/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P4.txt", "C:/Scrolly/temp/00time/2014/E9/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P5.txt", "C:/Scrolly/temp/00time/2014/E9/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P6.txt", "C:/Scrolly/temp/00time/2014/E9/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P7.txt", "C:/Scrolly/temp/00time/2014/E9/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P8.txt", "C:/Scrolly/temp/00time/2014/E9/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P9.txt", "C:/Scrolly/temp/00time/2014/E9/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E9/P10.txt", "C:/Scrolly/temp/00time/2014/E9/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E9\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E9/DE9.txt", "C:/Scrolly/temp/00dis/2014/E9/DE9.txt")
        DE9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E9\DE9.txt")

        E9 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE9

        '///////////////////////////////////////////////Etapa 10 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P1.txt", "C:/Scrolly/temp/00time/2014/E10/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P2.txt", "C:/Scrolly/temp/00time/2014/E10/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P3.txt", "C:/Scrolly/temp/00time/2014/E10/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P4.txt", "C:/Scrolly/temp/00time/2014/E10/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P5.txt", "C:/Scrolly/temp/00time/2014/E10/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P6.txt", "C:/Scrolly/temp/00time/2014/E10/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P7.txt", "C:/Scrolly/temp/00time/2014/E10/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P8.txt", "C:/Scrolly/temp/00time/2014/E10/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P9.txt", "C:/Scrolly/temp/00time/2014/E10/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E10/P10.txt", "C:/Scrolly/temp/00time/2014/E10/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E10\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E10/DE10.txt", "C:/Scrolly/temp/00dis/2014/E10/DE10.txt")
        DE10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E10\DE10.txt")

        E10 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE10

        '///////////////////////////////////////////////Etapa 11 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P1.txt", "C:/Scrolly/temp/00time/2014/E11/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P2.txt", "C:/Scrolly/temp/00time/2014/E11/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P3.txt", "C:/Scrolly/temp/00time/2014/E11/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P4.txt", "C:/Scrolly/temp/00time/2014/E11/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P5.txt", "C:/Scrolly/temp/00time/2014/E11/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P6.txt", "C:/Scrolly/temp/00time/2014/E11/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P7.txt", "C:/Scrolly/temp/00time/2014/E11/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P8.txt", "C:/Scrolly/temp/00time/2014/E11/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P9.txt", "C:/Scrolly/temp/00time/2014/E11/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E11/P10.txt", "C:/Scrolly/temp/00time/2014/E11/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E11\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E11/DE11.txt", "C:/Scrolly/temp/00dis/2014/E11/DE11.txt")
        DE11 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E11\DE11.txt")

        E11 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE11

        '///////////////////////////////////////////////Etapa 12 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P1.txt", "C:/Scrolly/temp/00time/2014/E12/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P2.txt", "C:/Scrolly/temp/00time/2014/E12/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P3.txt", "C:/Scrolly/temp/00time/2014/E12/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P4.txt", "C:/Scrolly/temp/00time/2014/E12/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P5.txt", "C:/Scrolly/temp/00time/2014/E12/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P6.txt", "C:/Scrolly/temp/00time/2014/E12/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P7.txt", "C:/Scrolly/temp/00time/2014/E12/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P8.txt", "C:/Scrolly/temp/00time/2014/E12/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P9.txt", "C:/Scrolly/temp/00time/2014/E12/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E12/P10.txt", "C:/Scrolly/temp/00time/2014/E12/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E12\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E12/DE12.txt", "C:/Scrolly/temp/00dis/2014/E12/DE12.txt")
        DE12 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E12\DE12.txt")
        E12 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE12

        '///////////////////////////////////////////////Etapa 13 - 2014 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P1.txt", "C:/Scrolly/temp/00time/2014/E13/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P2.txt", "C:/Scrolly/temp/00time/2014/E13/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P3.txt", "C:/Scrolly/temp/00time/2014/E13/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P4.txt", "C:/Scrolly/temp/00time/2014/E13/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P5.txt", "C:/Scrolly/temp/00time/2014/E13/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P6.txt", "C:/Scrolly/temp/00time/2014/E13/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P7.txt", "C:/Scrolly/temp/00time/2014/E13/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P8.txt", "C:/Scrolly/temp/00time/2014/E13/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P9.txt", "C:/Scrolly/temp/00time/2014/E13/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2014/E13/P10.txt", "C:/Scrolly/temp/00time/2014/E13/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2014\E13\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2014/E13/DE13.txt", "C:/Scrolly/temp/00dis/2014/E13/DE13.txt")
        DE13 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2014\E13\DE13.txt")

        E13 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE13

        Prom2014 = (E1 + E2 + E3 + E4 + E5 + E5 + E6 + E7 + E8 + E9 + E10 + E11 + E12 + E13) / 13
        Progress.Items.Add("Promedio 2014 = " & Prom2014)
        '2015

        '///////////////////////////////////////////////Etapa 1 - 2015 //////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P1.txt", "C:/Scrolly/temp/00time/2015/E1/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P2.txt", "C:/Scrolly/temp/00time/2015/E1/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P3.txt", "C:/Scrolly/temp/00time/2015/E1/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P4.txt", "C:/Scrolly/temp/00time/2015/E1/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P5.txt", "C:/Scrolly/temp/00time/2015/E1/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P6.txt", "C:/Scrolly/temp/00time/2015/E1/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P7.txt", "C:/Scrolly/temp/00time/2015/E1/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P8.txt", "C:/Scrolly/temp/00time/2015/E1/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P9.txt", "C:/Scrolly/temp/00time/2015/E1/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E1/P10.txt", "C:/Scrolly/temp/00time/2015/E1/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E1\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E1/DE1.txt", "C:/Scrolly/temp/00dis/2015/E1/DE1.txt")
        DE1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E1\DE1.txt")

        E1 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE1


        '///////////////////////////////////////////////Etapa 1 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P1.txt", "C:/Scrolly/temp/00time/2015/E2/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P2.txt", "C:/Scrolly/temp/00time/2015/E2/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P3.txt", "C:/Scrolly/temp/00time/2015/E2/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P4.txt", "C:/Scrolly/temp/00time/2015/E2/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P5.txt", "C:/Scrolly/temp/00time/2015/E2/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P6.txt", "C:/Scrolly/temp/00time/2015/E2/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P7.txt", "C:/Scrolly/temp/00time/2015/E2/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P8.txt", "C:/Scrolly/temp/00time/2015/E2/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P9.txt", "C:/Scrolly/temp/00time/2015/E2/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E2/P10.txt", "C:/Scrolly/temp/00time/2015/E2/P10.txt")

        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E2\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E2/DE2.txt", "C:/Scrolly/temp/00dis/2015/E2/DE2.txt")
        DE2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E2\DE2.txt")

        E2 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE2

        '///////////////////////////////////////////////Etapa 3 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P1.txt", "C:/Scrolly/temp/00time/2015/E3/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P2.txt", "C:/Scrolly/temp/00time/2015/E3/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P3.txt", "C:/Scrolly/temp/00time/2015/E3/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P4.txt", "C:/Scrolly/temp/00time/2015/E3/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P5.txt", "C:/Scrolly/temp/00time/2015/E3/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P6.txt", "C:/Scrolly/temp/00time/2015/E3/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P7.txt", "C:/Scrolly/temp/00time/2015/E3/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P8.txt", "C:/Scrolly/temp/00time/2015/E3/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P9.txt", "C:/Scrolly/temp/00time/2015/E3/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E3/P10.txt", "C:/Scrolly/temp/00time/2015/E3/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E3\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E3/DE3.txt", "C:/Scrolly/temp/00dis/2015/E3/DE3.txt")
        DE3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E3\DE3.txt")

        E3 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE3

        '///////////////////////////////////////////////Etapa 4 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P1.txt", "C:/Scrolly/temp/00time/2015/E4/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P2.txt", "C:/Scrolly/temp/00time/2015/E4/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P3.txt", "C:/Scrolly/temp/00time/2015/E4/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P4.txt", "C:/Scrolly/temp/00time/2015/E4/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P5.txt", "C:/Scrolly/temp/00time/2015/E4/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P6.txt", "C:/Scrolly/temp/00time/2015/E4/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P7.txt", "C:/Scrolly/temp/00time/2015/E4/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P8.txt", "C:/Scrolly/temp/00time/2015/E4/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P9.txt", "C:/Scrolly/temp/00time/2015/E4/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E4/P10.txt", "C:/Scrolly/temp/00time/2015/E4/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E4\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E4/DE4.txt", "C:/Scrolly/temp/00dis/2015/E4/DE4.txt")
        DE4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E4\DE4.txt")

        E4 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE4

        '///////////////////////////////////////////////Etapa 5 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P1.txt", "C:/Scrolly/temp/00time/2015/E5/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P2.txt", "C:/Scrolly/temp/00time/2015/E5/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P3.txt", "C:/Scrolly/temp/00time/2015/E5/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P4.txt", "C:/Scrolly/temp/00time/2015/E5/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P5.txt", "C:/Scrolly/temp/00time/2015/E5/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P6.txt", "C:/Scrolly/temp/00time/2015/E5/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P7.txt", "C:/Scrolly/temp/00time/2015/E5/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P8.txt", "C:/Scrolly/temp/00time/2015/E5/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P9.txt", "C:/Scrolly/temp/00time/2015/E5/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E5/P10.txt", "C:/Scrolly/temp/00time/2015/E5/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E5\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E5/DE5.txt", "C:/Scrolly/temp/00dis/2015/E5/DE5.txt")
        DE5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E5\DE5.txt")

        E5 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE5

        '///////////////////////////////////////////////Etapa 6 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P1.txt", "C:/Scrolly/temp/00time/2015/E6/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P2.txt", "C:/Scrolly/temp/00time/2015/E6/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P3.txt", "C:/Scrolly/temp/00time/2015/E6/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P4.txt", "C:/Scrolly/temp/00time/2015/E6/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P5.txt", "C:/Scrolly/temp/00time/2015/E6/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P6.txt", "C:/Scrolly/temp/00time/2015/E6/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P7.txt", "C:/Scrolly/temp/00time/2015/E6/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P8.txt", "C:/Scrolly/temp/00time/2015/E6/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P9.txt", "C:/Scrolly/temp/00time/2015/E6/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E6/P10.txt", "C:/Scrolly/temp/00time/2015/E6/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E6\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E6/DE6.txt", "C:/Scrolly/temp/00dis/2015/E6/DE6.txt")
        DE6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E6\DE6.txt")

        E6 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE6

        '///////////////////////////////////////////////Etapa 7 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P1.txt", "C:/Scrolly/temp/00time/2015/E7/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P2.txt", "C:/Scrolly/temp/00time/2015/E7/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P3.txt", "C:/Scrolly/temp/00time/2015/E7/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P4.txt", "C:/Scrolly/temp/00time/2015/E7/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P5.txt", "C:/Scrolly/temp/00time/2015/E7/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P6.txt", "C:/Scrolly/temp/00time/2015/E7/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P7.txt", "C:/Scrolly/temp/00time/2015/E7/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P8.txt", "C:/Scrolly/temp/00time/2015/E7/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P9.txt", "C:/Scrolly/temp/00time/2015/E7/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E7/P10.txt", "C:/Scrolly/temp/00time/2015/E7/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E7\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E7/DE7.txt", "C:/Scrolly/temp/00dis/2015/E7/DE7.txt")
        DE7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E7\DE7.txt")

        E7 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE7

        '///////////////////////////////////////////////Etapa 8 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P1.txt", "C:/Scrolly/temp/00time/2015/E8/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P2.txt", "C:/Scrolly/temp/00time/2015/E8/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P3.txt", "C:/Scrolly/temp/00time/2015/E8/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P4.txt", "C:/Scrolly/temp/00time/2015/E8/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P5.txt", "C:/Scrolly/temp/00time/2015/E8/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P6.txt", "C:/Scrolly/temp/00time/2015/E8/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P7.txt", "C:/Scrolly/temp/00time/2015/E8/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P8.txt", "C:/Scrolly/temp/00time/2015/E8/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P9.txt", "C:/Scrolly/temp/00time/2015/E8/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E8/P10.txt", "C:/Scrolly/temp/00time/2015/E8/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E8\P10.txt")
        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E8/DE8.txt", "C:/Scrolly/temp/00dis/2015/E8/DE8.txt")
        DE8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E8\DE8.txt")

        E8 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE8

        '///////////////////////////////////////////////Etapa 9 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P1.txt", "C:/Scrolly/temp/00time/2015/E9/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P2.txt", "C:/Scrolly/temp/00time/2015/E9/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P3.txt", "C:/Scrolly/temp/00time/2015/E9/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P4.txt", "C:/Scrolly/temp/00time/2015/E9/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P5.txt", "C:/Scrolly/temp/00time/2015/E9/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P6.txt", "C:/Scrolly/temp/00time/2015/E9/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P7.txt", "C:/Scrolly/temp/00time/2015/E9/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P8.txt", "C:/Scrolly/temp/00time/2015/E9/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P9.txt", "C:/Scrolly/temp/00time/2015/E9/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E9/P10.txt", "C:/Scrolly/temp/00time/2015/E9/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E9\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E9/DE9.txt", "C:/Scrolly/temp/00dis/2015/E9/DE9.txt")
        DE9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E9\DE9.txt")

        E9 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE9

        '///////////////////////////////////////////////Etapa 10 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P1.txt", "C:/Scrolly/temp/00time/2015/E10/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P2.txt", "C:/Scrolly/temp/00time/2015/E10/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P3.txt", "C:/Scrolly/temp/00time/2015/E10/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P4.txt", "C:/Scrolly/temp/00time/2015/E10/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P5.txt", "C:/Scrolly/temp/00time/2015/E10/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P6.txt", "C:/Scrolly/temp/00time/2015/E10/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P7.txt", "C:/Scrolly/temp/00time/2015/E10/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P8.txt", "C:/Scrolly/temp/00time/2015/E10/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P9.txt", "C:/Scrolly/temp/00time/2015/E10/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E10/P10.txt", "C:/Scrolly/temp/00time/2015/E10/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E10\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E10/DE10.txt", "C:/Scrolly/temp/00dis/2015/E10/DE10.txt")
        DE10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E10\DE10.txt")

        E10 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE10

        '///////////////////////////////////////////////Etapa 11 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P1.txt", "C:/Scrolly/temp/00time/2015/E11/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P2.txt", "C:/Scrolly/temp/00time/2015/E11/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P3.txt", "C:/Scrolly/temp/00time/2015/E11/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P4.txt", "C:/Scrolly/temp/00time/2015/E11/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P5.txt", "C:/Scrolly/temp/00time/2015/E11/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P6.txt", "C:/Scrolly/temp/00time/2015/E11/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P7.txt", "C:/Scrolly/temp/00time/2015/E11/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P8.txt", "C:/Scrolly/temp/00time/2015/E11/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P9.txt", "C:/Scrolly/temp/00time/2015/E11/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E11/P10.txt", "C:/Scrolly/temp/00time/2015/E11/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E11\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E11/DE11.txt", "C:/Scrolly/temp/00dis/2015/E11/DE11.txt")
        DE11 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E11\DE11.txt")

        E11 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE11

        '///////////////////////////////////////////////Etapa 12 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P1.txt", "C:/Scrolly/temp/00time/2015/E12/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P2.txt", "C:/Scrolly/temp/00time/2015/E12/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P3.txt", "C:/Scrolly/temp/00time/2015/E12/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P4.txt", "C:/Scrolly/temp/00time/2015/E12/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P5.txt", "C:/Scrolly/temp/00time/2015/E12/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P6.txt", "C:/Scrolly/temp/00time/2015/E12/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P7.txt", "C:/Scrolly/temp/00time/2015/E12/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P8.txt", "C:/Scrolly/temp/00time/2015/E12/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P9.txt", "C:/Scrolly/temp/00time/2015/E12/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E12/P10.txt", "C:/Scrolly/temp/00time/2015/E12/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E12\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E12/DE12.txt", "C:/Scrolly/temp/00dis/2015/E12/DE12.txt")
        DE12 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E12\DE12.txt")
        E12 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE12

        '///////////////////////////////////////////////Etapa 13 - 2015 /////////////////////////////////////////////////////
        'Importar Tiempo
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P1.txt", "C:/Scrolly/temp/00time/2015/E13/P1.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P2.txt", "C:/Scrolly/temp/00time/2015/E13/P2.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P3.txt", "C:/Scrolly/temp/00time/2015/E13/P3.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P4.txt", "C:/Scrolly/temp/00time/2015/E13/P4.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P5.txt", "C:/Scrolly/temp/00time/2015/E13/P5.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P6.txt", "C:/Scrolly/temp/00time/2015/E13/P6.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P7.txt", "C:/Scrolly/temp/00time/2015/E13/P7.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P8.txt", "C:/Scrolly/temp/00time/2015/E13/P8.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P9.txt", "C:/Scrolly/temp/00time/2015/E13/P9.txt")
        My.Computer.Network.DownloadFile("http://00time.scrolly.cf/2015/E13/P10.txt", "C:/Scrolly/temp/00time/2015/E13/P10.txt")
        'Asignación Tiempo (var)
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P1.txt")
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P2.txt")
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P3.txt")
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P4.txt")
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P5.txt")
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P6.txt")
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P7.txt")
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P8.txt")
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P9.txt")
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00time\2015\E13\P10.txt")

        'Importar Distancia
        My.Computer.Network.DownloadFile("http://00dis.scrolly.cf/2015/E13/DE13.txt", "C:/Scrolly/temp/00dis/2015/E13/DE13.txt")
        DE13 = My.Computer.FileSystem.ReadAllText("C:\Scrolly\temp\00dis\2015\E13\DE13.txt")

        E13 = (P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10) / DE13

        Prom2015 = (E1 + E2 + E3 + E4 + E5 + E5 + E6 + E7 + E8 + E9 + E10 + E11 + E12 + E13) / 13

        'Cálculos finales
        Prom = (Prom2012 + Prom2013 + Prom2014 + Prom2015) / 5
        Progress.Items.Add("Promedio 2015 = " & Prom2015)
        Dif1 = Prom2012 - Prom2013
        Dif2 = Prom2013 - Prom2014
        Dif3 = Prom2014 - Prom2015

        MsgBox(Prom)
        MsgBox(Dif1)
        MsgBox(Dif2)
        MsgBox(Dif3)
    End Sub
End Class