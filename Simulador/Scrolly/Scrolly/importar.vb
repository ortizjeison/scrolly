Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic

Module Importar

    Sub importarExcel(ByVal tabla As DataGridView, ByVal ExcelFile As String, ByVal xSheet As String)

        Dim ds As New DataSet
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim conn As OleDbConnection


        conn = New OleDbConnection( _
                          "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                          "data source=" & ExcelFile & "; " & _
                         "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

        Try
            da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

            conn.Open()
            da.Fill(ds, "MyData")
            dt = ds.Tables("MyData")
            tabla.DataSource = ds
            tabla.DataMember = "MyData"
        Catch ex As Exception
            MsgBox("Los resultados de esta etapa aún no han sido descargados. Por favor haga clic en descargar antes de importar.", MsgBoxStyle.Information, "Informacion")
        Finally
            conn.Close()
        End Try
    End Sub

End Module
