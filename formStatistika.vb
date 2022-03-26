Public Class formStatistika
    Private Sub formStatistika_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As IDatabase
        data = New CDatabase
        lblGamesCount.Text = data.getStat("GamesPlayed")
        lblTotalTime.Text = data.getStat("TimePlayed") & " sekundit"
        lblAvgTime.Text = data.getStat("AverageTimePerGame") & " sekundit"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim position = Me.Bounds
        Dim newForm As New formMenu
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

End Class