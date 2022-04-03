Public Class formMenu
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim game As IGame
        game = New CGame

        game.kasPiiramatu = True

        Dim position = Me.Bounds
        Dim newForm As New formGameSettings
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim position = Me.Bounds
        Dim newForm As New formHistory
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Dim position = Me.Bounds
        Dim newForm As New formStatistika
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        Dim game As IGame
        game = New CGame

        game.kasPiiramatu = False
        'Väärtuste taastamine algseadetele
        game.kasTimed = False
        game.gameMode = "Tavaline"
        game.maxKast = 5

        Dim position = Me.Bounds
        Dim newForm As New formGame
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub
End Class
