Public Class formHistory
    Private Sub formHistory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As IDatabase
        data = New CDatabase
        dtgDatagrid.DataSource = data.getHistory()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim position = Me.Bounds
        Dim newForm As New formMenu
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        Dim colors As IGraphics
        colors = New CGraphics
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)
        newForm.Show()
        Me.Close()
    End Sub
End Class