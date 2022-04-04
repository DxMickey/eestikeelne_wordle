Public Class formTimeLimit





    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase



        If txtNewPass1.Visible = True Then
            If txtNewPass1.Text = txtNewPass2.Text Then
                time.password = txtNewPass1.Text
                data.setItem("miscData", "parool", txtNewPass1.Text)
                txtNewPass1.Visible = False
                txtNewPass2.Visible = False
                lblNewPass1.Visible = False
                lblNewPass2.Visible = False

                txtPass.Visible = True
                lblPass.Visible = True

            Else
                MessageBox.Show("Salasõnad ei ühti")
            End If
        ElseIf txtPass.Visible = True Then
            If txtPass.Text = time.password Then
                txtPass.Visible = False
                lblPass.Visible = False

                txtTimePlay.Visible = True
                txtTimeWait.Visible = True
                lblTimePlay.Visible = True
                lblTimeWait.Visible = True

                btnOff.Visible = True
                btnOn.Visible = True

                If time.timeState = "off" Then
                    btnOff.Enabled = False
                    btnOn.Enabled = True
                Else
                    btnOff.Enabled = True
                    btnOn.Enabled = False
                End If
            Else
                MessageBox.Show("Vale salasõna")
            End If
        ElseIf txtTimePlay.Visible = True Then




            If txtTimePlay.Text <> Nothing And txtTimeWait.Text <> Nothing And IsNumeric(txtTimePlay.Text) And IsNumeric(txtTimeWait.Text) Then
                time.timePlay = txtTimePlay.Text
                time.timeWait = txtTimeWait.Text

                data.setItem("miscData", "timePlay", txtTimePlay.Text)
                data.setItem("miscData", "timeWait", txtTimeWait.Text)
            Else
                MessageBox.Show("Väärtused peavad olema numbrilised ja ei tohi olla tühjad")
            End If



        End If
    End Sub

    Private Sub formTimeLimit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase

        btnOff.Visible = False
        btnOn.Visible = False

        If time.password = "Puudub" Then
            txtNewPass1.Visible = True
            txtNewPass2.Visible = True
            lblNewPass1.Visible = True
            lblNewPass2.Visible = True
        Else
            txtPass.Visible = True
            lblPass.Visible = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New formMenu
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
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase

        time.timeState = "On"
        data.setItem("miscData", "timeState", "On")

        btnOff.Enabled = True
        btnOn.Enabled = False

    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase

        time.timeState = "Off"
        data.setItem("miscData", "timeState", "Off")

        btnOff.Enabled = False
        btnOn.Enabled = True
    End Sub
End Class