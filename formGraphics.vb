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
                'Väärtused on korras
                Dim backColor As Color = Color.FromArgb(255, colors.red, colors.green, colors.blue)
                Me.BackColor = backColor
                setColors(colors.red, colors.green, colors.blue)
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

    'Vaata, milline sisestatud koodiga värv on
    Public Sub btnTry_Click(sender As Object, e As EventArgs) Handles btnTry.Click
        Dim colors As IGraphics
        colors = New CGraphics
        'Väärtusa värvid
        UInteger.TryParse(txtRed.Text, colors.red)
        UInteger.TryParse(txtGreen.Text, colors.green)
        UInteger.TryParse(txtBlue.Text, colors.blue)

        'Kontrolli kas sisestatud väärtused on sobivad
        Dim flag2 As Integer = checkValues(txtRed.Text, txtGreen.Text, txtBlue.Text)
        Dim flag1 As Integer = checkColors(colors.red, colors.green, colors.blue)

        If flag2 = 1 Then

            If flag1 = 1 Then
                'Kui kõik korras, siis muuda värv
                Dim backColor As Color = Color.FromArgb(255, colors.red, colors.green, colors.blue)
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
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


        newForm.Show()
        Me.Close()
    End Sub

    'Default värvus tagasi, control hex väärtus f0f0f0
    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Dim colors As IGraphics
        colors = New CGraphics

        Me.BackColor = SystemColors.Control
        colors.red = 239
        colors.green = 239
        colors.blue = 239
        txtRed.Text = colors.red
        txtGreen.Text = colors.green
        txtBlue.Text = colors.blue

        setColors(colors.red, colors.green, colors.blue)
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

        lblError.Visible = False
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
        Dim pathToGame As String = Application.StartupPath
        Dim fileName As String = "visuals\wordleColor.txt"
        Dim fullPath As String = My.Computer.FileSystem.CombinePath(pathToGame, fileName)

        Dim fileWriter As System.IO.StreamWriter
        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(fullPath, False)

        fileWriter.WriteLine(red, False, 0)
        fileWriter.WriteLine(green, False, 1)
        fileWriter.WriteLine(blue, False, 2)

        fileWriter.Close()
    End Sub

End Class