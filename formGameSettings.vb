Public Class formGameSettings
    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        chooseGame("Kerge")

    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        chooseGame("Tavaline")
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        chooseGame("Raske")
    End Sub

    Private Sub chooseGame(ByVal value As String)
        Dim game As IGame
        game = New CGame

        If value = "Kerge" Then
            game.maxKast = 4
        ElseIf value = "Tavaline" Then
            game.maxKast = 5
        Else
            game.maxKast = 6

        End If

        game.gameMode = value

        Dim position = Me.Bounds
        Dim newForm As New formGame
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub
End Class