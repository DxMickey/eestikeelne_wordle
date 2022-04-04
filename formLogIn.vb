Public Class formLogIn
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If TextBox1.Text = CKeyWord.keypass Then
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.MaxLength = 12
    End Sub
End Class