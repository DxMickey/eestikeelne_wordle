Public Class FormKeyword
    Private Sub TextBoxPassword1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword1.TextChanged
        TextBoxPassword1.MaxLength = 12
    End Sub

    Private Sub TextBoxPassword2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword2.TextChanged
        TextBoxPassword2.MaxLength = 12
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim salavoti As IKeyWord

        If TextBoxPassword2.Text.Equals(TextBoxPassword1.Text) Then
            salavoti = New CKeyWord

            Dim newForm As New formTimeLimit
            Dim colors As IGraphics
            colors = New CGraphics

            newForm.TopLevel = False
            newForm.Parent = formContainer
            newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            newForm.StartPosition = FormStartPosition.Manual
            newForm.Location = New Point(0, 0)
            newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


            newForm.Show()
            Me.Close()
        Else
            lblError.Text = "Sisestatud paroolid ei kattu!"
        End If
    End Sub
End Class