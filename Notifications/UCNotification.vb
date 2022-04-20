Public Class UCNotification
    Private Property timePassed = 0
    Private Sub UCNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.timePassed += 1
        If timePassed >= 5 Then
            Timer1.Stop()
            Timer1.Dispose()
            Me.Dispose()
        End If
    End Sub
End Class
