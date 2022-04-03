Public Class formStatistika
    Private Sub formStatistika_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As IDatabase
        data = New CDatabase
        txtGamesCount.Text = data.getStat("m2ngude_arv")
        txtTotalTime.Text = data.getStat("m2ngitud_aeg") & " sekundit"
        txtAvgTime.Text = data.getStat("keskmine_arvamise_aeg") & " sekundit"
        txtGuessed.Text = data.getStat("arvatud_s6nade_hulk")
        txtFastestTime.Text = data.getStat("k6ige_kiirem_aeg") & " sekundit"
        txtSlowestTime.Text = data.getStat("k6ige_aeglasem_aeg") & " sekundit"
        txtHighscore.Text = data.getStat("suurim_skoor")
        txtAvgScore.Text = data.getStat("keskmine_skoor")
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