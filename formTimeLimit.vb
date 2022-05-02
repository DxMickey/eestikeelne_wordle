Public Class formTimeLimit

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        'Vastavalt sellele, millised väljad on näha, valitakse millised väljad nähtavale tuua ja millised peita nupule vajutusel
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
                cmbTimePlay.Visible = True
                cmbWaitTime.Visible = True

                btnOnOff.Visible = True
                lblTimeWaitNow.Visible = True
                lblTimePlayNow.Visible = True
            Else
                MessageBox.Show("Vale salasõna")
            End If
        ElseIf txtTimePlay.Visible = True Then

            'Kontroll, kas sisestatud väärtused ei ole tühjad ning on numbrilised
            If txtTimePlay.Text <> Nothing And txtTimeWait.Text <> Nothing And IsNumeric(txtTimePlay.Text) And IsNumeric(txtTimeWait.Text) Then
                'Väärtuse teisendamine tundideks ja minutiteks kui need on kasutaja poolt valitud
                If cmbTimePlay.SelectedIndex = 0 Then
                    time.timePlay = txtTimePlay.Text
                ElseIf cmbTimePlay.SelectedIndex = 1 Then
                    time.timePlay = txtTimePlay.Text * 60
                ElseIf cmbTimePlay.SelectedIndex = 2 Then
                    time.timePlay = txtTimePlay.Text * 3600
                End If

                'Väärtuse teisendamine tundideks ja minutiteks kui need on kasutaja poolt valitud
                If cmbWaitTime.SelectedIndex = 0 Then
                    time.timeWait = txtTimeWait.Text
                ElseIf cmbWaitTime.SelectedIndex = 1 Then
                    time.timeWait = txtTimeWait.Text * 60
                ElseIf cmbWaitTime.SelectedIndex = 2 Then
                    time.timeWait = txtTimeWait.Text * 3600
                End If

                'Väärtuste salvestamine andmebaasi
                data.setItem("time", "timePlay", time.timePlay)
                data.setItem("time", "timeWait", time.timeWait)

                lblTimePlayNow.Text = "Väärtus hetkel:" & time.timePlay
                lblTimeWaitNow.Text = "Väärtus hetkel:" & time.timeWait
            Else
                MessageBox.Show("Väärtused peavad olema numbrilised ja ei tohi olla tühjad")
            End If

        End If
    End Sub

    Private Sub formTimeLimit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim colors As IGraphics
        colors = New CGraphics

        btnOnOff.Visible = False

        'Labelite värvide seadistamine
        lblNewPass1.ForeColor = colors.lblColor
        lblNewPass2.ForeColor = colors.lblColor
        lblPass.ForeColor = colors.lblColor
        lblTimePlay.ForeColor = colors.lblColor
        lblTimePlayNow.ForeColor = colors.lblColor
        lblTimeWait.ForeColor = colors.lblColor
        lblTimeWaitNow.ForeColor = colors.lblColor
        lblTimePlayNow.Visible = False
        lblTimeWaitNow.Visible = False
        cmbTimePlay.Visible = False
        cmbWaitTime.Visible = False
        cmbTimePlay.SelectedIndex = 0
        cmbWaitTime.SelectedIndex = 0
        lblTimePlayNow.Text = "Väärtus hetkel:" & data.getItem("time", "timePlay") & " sekundit"
        lblTimeWaitNow.Text = "Väärtus hetkel:" & data.getItem("time", "timeWait") & " sekundit"

        If time.timeState = "On" Then
            btnOnOff.Text = "Lülita välja"
        Else
            btnOnOff.Text = "Lülita sisse"
        End If

        'Kui andmebaasis pole passwordi, tähendab see, et kasutaja pole varem parooli sisestanud
        'ning ette kuvatakse uue parooli sisestamise väljad
        If time.password = "none" Then
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
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        'Ajalimiidi sisse ja välja lülitamine
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