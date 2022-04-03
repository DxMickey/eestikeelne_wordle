Public Class formGameSettings
    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        chooseGame("Kerge", False)

    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        chooseGame("Tavaline", False)
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        chooseGame("Raske", False)
    End Sub

    Private Sub chooseGame(ByVal value1 As String, ByVal value2 As Boolean)
        Dim game As IGame
        game = New CGame

        If value1 = "Kerge" Then
            game.maxKast = 4
            game.timeSetting = 360
        ElseIf value1 = "Tavaline" Then
            game.maxKast = 5
            game.timeSetting = 200
        Else
            game.maxKast = 6
            game.timeSetting = 120

        End If

        game.gameMode = value1

        Dim position = Me.Bounds
        Dim newForm As New formGame
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        Dim colors As IGraphics
        colors = New CGraphics
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnNoTime_Click(sender As Object, e As EventArgs) Handles btnNoTime.Click
        Dim game As IGame
        game = New CGame

        game.kasTimed = False
        updateVisibility(True)
    End Sub

    Private Sub btnTimed_Click(sender As Object, e As EventArgs) Handles btnTimed.Click
        Dim game As IGame
        game = New CGame

        game.kasTimed = True
        updateVisibility(True)
    End Sub

    Private Sub updateVisibility(ByVal value As Boolean)
        If value = True Then
            btnNoTime.Visible = False
            btnTimed.Visible = False
            btnEasy.Visible = True
            btnNormal.Visible = True
            btnHard.Visible = True
        ElseIf value = False Then
            btnNoTime.Visible = True
            btnTimed.Visible = True
            btnEasy.Visible = False
            btnNormal.Visible = False
            btnHard.Visible = False
        End If
    End Sub

    Private Sub formGameSettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        updateVisibility(False)
    End Sub
End Class