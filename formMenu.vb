Public Class formMenu
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim position = Me.Bounds
        Dim newForm As New formGame
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

End Class
