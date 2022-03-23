Public Class formGameEnd
    Private Sub btbPlayAgain_Click(sender As Object, e As EventArgs) Handles btbPlayAgain.Click
        Dim position = Me.Bounds
        Dim newForm As New formGame
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btbToMenu_Click(sender As Object, e As EventArgs) Handles btbToMenu.Click
        Dim position = Me.Bounds
        Dim newForm As New formMenu
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub
End Class