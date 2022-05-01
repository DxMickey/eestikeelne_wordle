Imports CSVExporterDNF

Public Class formCSV
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim export As IExporter
        export = New CExporter

        Dim historyTable = data.getHistory()

        Dim rws As Integer = historyTable.Rows.Count, flds As Integer = historyTable.Columns.Count ' for example .. rws = number of rows in datatable e.g. 19, flds = number of fields e.g. 5
        Dim historyArray(rws - 1, flds - 1) As Object ' note placement of rws and flds below
        Array.ForEach(Enumerable.Range(0, flds).ToArray, Sub(x) Array.ForEach(Enumerable.Range(0, rws).ToArray, Sub(y) historyArray(y, x) = historyTable.Rows(y).Item(x)))

        Dim savePath2 As String = data.getItem("miscData", "savePath")
        Dim savePath As String

        If savePath2 = "none" Then
            savePath = export.setFileToSave()

            data.setItem("miscData", "savePath", savePath)
        Else
            export.GetType().GetField("sFileToSave", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance).SetValue(export, savePath2)

        End If



        export.saveDataToCsv(historyArray, True)


    End Sub
End Class