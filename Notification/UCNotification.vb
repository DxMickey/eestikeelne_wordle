Public Class UCNotification
    Dim timePassed = 0
    Public Property timeOut = 5
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timePassed += 1
        If timePassed >= timeOut Then
            Timer1.Stop()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Timer1.Stop()
        Catch ex As Exception

        End Try
        Me.Dispose()
    End Sub


End Class
