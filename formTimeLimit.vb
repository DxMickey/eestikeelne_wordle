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

                btnOnOff.Visible = True
                lblTimeWaitNow.Visible = True
                lblTimePlayNow.Visible = True
            Else
                MessageBox.Show("Vale salasõna")
            End If
        ElseIf txtTimePlay.Visible = True Then




            If txtTimePlay.Text <> Nothing And txtTimeWait.Text <> Nothing And IsNumeric(txtTimePlay.Text) And IsNumeric(txtTimeWait.Text) Then
                time.timePlay = txtTimePlay.Text
                time.timeWait = txtTimeWait.Text

                data.setItem("time", "timePlay", txtTimePlay.Text)
                data.setItem("time", "timeWait", txtTimeWait.Text)
            Else
                MessageBox.Show("Väärtused peavad olema numbrilised ja ei tohi olla tühjad")
            End If


            lblTimePlayNow.Text = "Väärtus hetkel:" & time.timePlay
            lblTimeWaitNow.Text = "Väärtus hetkel:" & time.timeWait

        End If
    End Sub

    Private Sub formTimeLimit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase

        btnOnOff.Visible = False

        lblTimePlayNow.Visible = False
        lblTimeWaitNow.Visible = False
        lblTimePlayNow.Text = "Väärtus hetkel:" & data.getItem("time", "timePlay")
        lblTimeWaitNow.Text = "Väärtus hetkel:" & data.getItem("time", "timeWait")


        If time.timeState = "On" Then
            btnOnOff.Text = "Lülita välja"
        Else
            btnOnOff.Text = "Lülita sisse"
        End If

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

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase
        If btnOnOff.Text = "Lülita sisse" Then
            If time.timeWait <= 0 Or time.timePlay <= 0 Then
                MessageBox.Show("Väärtused peavad olema nullist suuremad")
            Else
                time.timeState = "On"
                data.setItem("time", "timeState", "On")
                btnOnOff.Text = "Lülita välja"
            End If

        Else
            time.timeState = "Off"
            data.setItem("time", "timeState", "Off")
            btnOnOff.Text = "Lülita sisse"
        End If

        time.timePlay = data.getItem("time", "timePlay")
        time.timeWait = data.getItem("time", "timeWait")
        data.setItem("time", "timeWaitCurrent", time.timeWait)
        data.setItem("time", "timePlayCurrent", time.timePlay)



    End Sub


End Class