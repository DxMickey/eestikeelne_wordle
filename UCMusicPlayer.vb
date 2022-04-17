Public Class UCMusicPlayer
    Dim taustaMuusika As ITaustaMuusika

    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click
        taustaMuusika = New CTaustaMuusika
        taustaMuusika.startPlayback()
    End Sub

    Private Sub pbPause_Click(sender As Object, e As EventArgs) Handles pbPause.Click
        taustaMuusika = New CTaustaMuusika
        taustaMuusika.stopPlayback()
    End Sub
End Class
