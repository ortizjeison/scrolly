Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles descargar.Click
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (1).txt", "C:/Scrally/tiempos/P (1).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (2).txt", "C:/Scrally/tiempos/P (2).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (3).txt", "C:/Scrally/tiempos/P (3).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (4).txt", "C:/Scrally/tiempos/P (4).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (5).txt", "C:/Scrally/tiempos/P (5).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (6).txt", "C:/Scrally/tiempos/P (6).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (7).txt", "C:/Scrally/tiempos/P (7).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (8).txt", "C:/Scrally/tiempos/P (8).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (9).txt", "C:/Scrally/tiempos/P (9).txt")
        My.Computer.Network.DownloadFile("http://scrally.cf/tiempos/P (10).txt", "C:/Scrally/tiempos/P (10).txt")

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles read.Click
        Dim P1, P2, P3, P4, P5, P6, P7, P8, P9, P10 As String
        P1 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (1).txt")
        Listbox.Items.Add(P1)
        P2 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (2).txt")
        Listbox.Items.Add(P2)
        P3 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (3).txt")
        Listbox.Items.Add(P3)
        P4 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (4).txt")
        Listbox.Items.Add(P4)
        P5 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (5).txt")
        Listbox.Items.Add(P5)
        P6 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (6).txt")
        Listbox.Items.Add(P6)
        P7 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (7).txt")
        Listbox.Items.Add(P7)
        P8 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (8).txt")
        Listbox.Items.Add(P8)
        P9 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (9).txt")
        Listbox.Items.Add(P9)
        P10 = My.Computer.FileSystem.ReadAllText("C:\Scrally\tiempos\P (10).txt")
        Listbox.Items.Add(P10)
    End Sub
End Class
