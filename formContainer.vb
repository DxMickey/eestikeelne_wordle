Public Class formContainer
    Private Sub formContainer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim newForm As New formMenu
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog

        newForm.TopLevel = False
        newForm.Parent = Me
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)


        newForm.Show()


    End Sub
End Class