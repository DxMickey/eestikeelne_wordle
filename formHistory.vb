Public Class formHistory
    Private Sub formHistory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        dtgDatagrid.DataSource = data.getHistory()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New formMenu
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = colors.backColor


        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        data.exportJSON()
    End Sub

    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        Dim newForm As New formExportCSV
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.BackColor = colors.backColor

        newForm.Show()
    End Sub
End Class