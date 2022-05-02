Public Class formContainer
    Private Sub formContainer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim newForm As New formMenu
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog

        'Ajalimiidi väärtuste saamine andmebaasist
        time.password = data.getItem("miscData", "parool")
        time.timeState = data.getItem("time", "timeState")
        time.timePlay = data.getItem("time", "timePlayCurrent")
        time.timeWait = data.getItem("time", "timeWaitCurrent")

        newForm.TopLevel = False
        newForm.Parent = Me
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)

        newForm.Show()

    End Sub
End Class