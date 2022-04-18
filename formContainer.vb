Public Class formContainer
    Private Sub formContainer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase
        Dim newForm As New formMenu
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog

        time.password = data.getItem("miscData", "parool")
        time.timeState = data.getItem("miscData", "timeState")
        'time.timePlay = data.getItem("miscData", "timePlayCurrent")
        time.timePlay = 0
        time.timeWait = data.getItem("miscData", "timeWaitCurrent")

        newForm.TopLevel = False
        newForm.Parent = Me
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)


        newForm.Show()


    End Sub
End Class