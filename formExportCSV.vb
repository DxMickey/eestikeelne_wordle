Public Class formExportCSV
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim data As IDatabase
        data = New CDatabase
        Dim append = If(cmbAppend.SelectedItem = "Kirjuta üle", False, True)
        data.exportCSV(txtDelimiter.Text, txtTextQualifier.Text, append)
    End Sub

    Private Sub formExportCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colors As IGraphics
        colors = New CGraphics

        cmbAppend.SelectedItem = "Kirjuta üle"
        Label1.ForeColor = colors.lblColor
        Label2.ForeColor = colors.lblColor
        Label3.ForeColor = colors.lblColor
    End Sub
End Class