Public Class formTimeLimit
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim newForm As New formMenu
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)
        newForm.labelTimeChanged.Show()
        newForm.Show()
        newForm.Timer1.Start()
        Me.Close()
    End Sub


End Class