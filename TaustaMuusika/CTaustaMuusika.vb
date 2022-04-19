Public Class CTaustaMuusika
    Implements ITaustaMuusika
    Private Property music = My.Resources.Untitled

    Public Sub startPlayback() Implements ITaustaMuusika.startPlayback
        My.Computer.Audio.Play(music, playMode:=AudioPlayMode.BackgroundLoop)
    End Sub

    Public Sub stopPlayback() Implements ITaustaMuusika.stopPlayback
        My.Computer.Audio.Stop()
    End Sub
End Class
