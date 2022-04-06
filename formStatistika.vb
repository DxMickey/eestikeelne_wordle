Public Class formStatistika
    Private Sub formStatistika_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As IDatabase
        data = New CDatabase
        changeLabelColors()
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

    Private Sub changeLabelColors()
        Dim colors As IGraphics
        colors = New CGraphics
        Label1.ForeColor = colors.lblColor
        Label2.ForeColor = colors.lblColor
        Label3.ForeColor = colors.lblColor
        Label4.ForeColor = colors.lblColor
        Label5.ForeColor = colors.lblColor
        Label6.ForeColor = colors.lblColor
        Label7.ForeColor = colors.lblColor
        Label8.ForeColor = colors.lblColor
        txtGamesCount.ForeColor = colors.lblColor
        txtTotalTime.ForeColor = colors.lblColor
        txtAvgTime.ForeColor = colors.lblColor
        txtGuessed.ForeColor = colors.lblColor
        txtFastestTime.ForeColor = colors.lblColor
        txtSlowestTime.ForeColor = colors.lblColor
        txtHighscore.ForeColor = colors.lblColor
        txtAvgScore.ForeColor = colors.lblColor
    End Sub

End Class