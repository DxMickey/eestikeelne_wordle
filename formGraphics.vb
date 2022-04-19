Public Class formGraphics

    'Sätesta värv kogu mängu jaoks
    Public Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim colors As IGraphics
        colors = New CGraphics
        UInteger.TryParse(txtRed.Text, colors.red)
        UInteger.TryParse(txtGreen.Text, colors.green)
        UInteger.TryParse(txtBlue.Text, colors.blue)

        'Kontrolli, kas  sisestatud väärtused on sobivad
        'Ehk kas on numbrilised ja lubatud vahemikus
        Dim flag2 As Integer = checkValues(txtRed.Text, txtGreen.Text, txtBlue.Text)
        Dim flag1 As Integer = checkColors(colors.red, colors.green, colors.blue)

        If flag2 = 1 Then

            If flag1 = 1 Then
                'Väärtused on korras, vaheta taustavärv ja muuda labelite värv
                lblError.Visible = False
                setColors(colors.red, colors.green, colors.blue)
                colors.backColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)
                'colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
                setLblColor()
                changeLabels(colors.lblColor)
                Me.BackColor = colors.backColor
            Else
                'Väärtused numbrilised, kuid piirkonnast väljas
                lblError.Visible = True
                lblError.Text = "Vigane väärtus! Väärtused peavad olema vahemikus 0 - 255"
            End If
        Else
            'Väärtused ei ole numbilised
            lblError.Visible = True
            lblError.Text = "Vigane väärtus! Väärtused peavad olema numbrilised"
        End If

    End Sub

    'Algandmed akna avamisel
    Private Sub formGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baseSettings()
    End Sub

    'Tagasi main menüüsse, säilitab värvi
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New formMenu
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = colors.backColor


        newForm.Show()
        Me.Close()
    End Sub

    'Default värvus tagasi, control hex väärtus f0f0f0
    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Dim colors As IGraphics
        colors = New CGraphics

        lblError.Visible = False
        Me.BackColor = SystemColors.Control
        colors.red = 239
        colors.green = 239
        colors.blue = 239

        txtRed.Text = 239
        txtGreen.Text = 239
        txtBlue.Text = 239

        setColors(colors.red, colors.green, colors.blue)
        colors.backColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)
        'colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        setLblColor()
        changeLabels(colors.lblColor)
    End Sub

    'Muuda värtvuseid ja proovi värvi
    Private Sub tbrGreen_Scroll(sender As Object, e As EventArgs) Handles tbrGreen.Scroll
        Dim colors As IGraphics
        colors = New CGraphics

        colors.green = Int(tbrGreen.Value)
        txtGreen.Text = colors.green

        tryColor()
    End Sub

    'Muuda värvuseid ja proovi värvi
    Private Sub tbrRed_Scroll(sender As Object, e As EventArgs) Handles tbrRed.Scroll
        Dim colors As IGraphics
        colors = New CGraphics

        colors.red = Int(tbrRed.Value)
        txtRed.Text = colors.red

        tryColor()
    End Sub

    'Muuda väärtuseid ja proovi värvi
    Private Sub tbrBlue_Scroll(sender As Object, e As EventArgs) Handles tbrBlue.Scroll
        Dim colors As IGraphics
        colors = New CGraphics

        colors.blue = Int(tbrBlue.Value)
        txtBlue.Text = colors.blue

        tryColor()
    End Sub

    'Proovi värvi, kui punase lahtrit on muudetud
    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged
        tryColor()
    End Sub

    'Proovi värvi, kui rohelise lahtrit on muudetud
    Private Sub txtGreen_TextChanged(sender As Object, e As EventArgs) Handles txtGreen.TextChanged
        tryColor()
    End Sub

    'Proovi värvi, kui sinise lahtrit on muudetud
    Private Sub txtBlue_TextChanged(sender As Object, e As EventArgs) Handles txtBlue.TextChanged
        tryColor()
    End Sub




    'Kontrolli, kas sistestatud värv jääb vahemikku 255
    'Kui jah, tagasta 1, kui ei, tagasta 0
    Private Function checkColors(ByVal red As UInteger, ByVal green As UInteger, ByVal blue As UInteger)

        If (red >= 0 And red <= 255) And (green >= 0 And green <= 255) And (blue >= 0 And blue <= 255) Then
            Return 1
        Else
            Return 0
        End If
    End Function


    'Algsed akna väärtused, peida vea label
    Private Sub baseSettings()
        Dim colors As IGraphics
        colors = New CGraphics
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        changeLabels(colors.lblColor)
        'Peida error silt
        lblError.Visible = False
        'Algväärtusta sliderid
        tbrRed.Value = colors.red
        tbrGreen.Value = colors.green
        tbrBlue.Value = colors.blue
        'Algväärtusta tekstboxid
        txtRed.Text = colors.red
        txtGreen.Text = colors.green
        txtBlue.Text = colors.blue
    End Sub


    'Kontrolli, kas sisestatud väärtused on numbrilised
    'kui jah, siis tagasta 1, kui ei siis 0
    Private Function checkValues(ByVal val As String, ByVal val2 As String, ByVal val3 As String)
        Dim check1, check2, check3 As Boolean
        'Kas on numbrilised, tagastab true/false
        check1 = IsNumeric(val)
        check2 = IsNumeric(val2)
        check3 = IsNumeric(val3)
        If check1 And check2 And check3 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    'Salvestab kasutaja sisestatud värvid tekstifaili
    Private Sub setColors(ByVal red As UInteger, ByVal green As UInteger, ByVal blue As UInteger)
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        data.setItem("miscData", "red", red)
        data.setItem("miscData", "green", green)
        data.setItem("miscData", "blue", blue)

    End Sub


    Private Sub tryColor()
        Dim red, green, blue As UInteger
        'Väärtusta värvid
        UInteger.TryParse(txtRed.Text, red)
        UInteger.TryParse(txtGreen.Text, green)
        UInteger.TryParse(txtBlue.Text, blue)

        'Kontrolli kas sisestatud väärtused on sobivad
        Dim flag2 As Integer = checkValues(txtRed.Text, txtGreen.Text, txtBlue.Text)
        Dim flag1 As Integer = checkColors(red, green, blue)

        If flag2 = 1 Then

            If flag1 = 1 Then
                'Kui kõik korras, siis muuda värv
                lblError.Visible = False

                tbrRed.Value = red
                tbrGreen.Value = green
                tbrBlue.Value = blue

                Dim backColor As Color = Color.FromArgb(255, red, green, blue)
                pnlColor.BackColor = backColor
            Else
                'Väärtus on numbriline, kuid piirkonnast väljas
                lblError.Visible = True
                lblError.Text = "Vigane väärtus! Väärtused peavad olema vahemikus 0 - 255"
            End If
        Else
            'Väärtus ei ole numbriline
            lblError.Visible = True
            lblError.Text = "Vigane väärtus! Väärtused peavad olema numbrilised"
        End If

    End Sub

    Private Sub changeLabels(ByVal color As Color)
        lblBlue.ForeColor = color
        lblError.ForeColor = color
        lblGreen.ForeColor = color
        lblTestColor.ForeColor = color
        lblRed.ForeColor = color
    End Sub

    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red - 70), 255 - (colors.green - 70), 255 - (colors.blue - 70))
        End If
    End Sub
End Class