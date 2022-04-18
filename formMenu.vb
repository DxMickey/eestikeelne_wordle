Public Class formMenu
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim game As IGame
        game = New CGame

        game.kasPiiramatu = True

        Dim newForm As New formGameSettings
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

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim newForm As New formHistory
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

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Dim newForm As New formStatistika
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


    Private Sub btnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        Dim game As IGame
        game = New CGame

        game.kasPiiramatu = False
        'Väärtuste taastamine algseadetele
        game.kasTimed = False
        game.gameMode = "Tavaline"
        game.maxKast = 5

        Dim newForm As New formGame
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


    Private Sub btnGraphics_Click(sender As Object, e As EventArgs) Handles btnGraphics.Click
        Dim newForm As New formGraphics
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

    'Menüü laadides sea taustavärv
    Private Sub formMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colors As IGraphics
        colors = New CGraphics

        lblTimer.Visible = False

        getColor()
        Me.BackColor = colors.backColor
        Label1.ForeColor = colors.lblColor
    End Sub


    'Saab sätestatud taustavärvi RGB
    Private Sub getColor()
        Dim colors As IGraphics
        colors = New CGraphics
        Dim data As IDatabase
        data = New CDatabase


        'Kui värvid väärtustamata, proovi saada need failist
        If colors.red = Nothing Or colors.green = Nothing Or colors.blue = Nothing Then

            colors.red = data.getItemInt("miscData", "red")
            colors.green = data.getItemInt("miscData", "green")
            colors.blue = data.getItemInt("miscData", "blue")
            colors.backColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)
            setLblColor()
        End If
    End Sub

    Private Sub btnTimeLimit_Click(sender As Object, e As EventArgs) Handles btnTimeLimit.Click
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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim data As IDatabase
        data = New CDatabase

        time.timeWait = time.timeWait - 1
        lblTimer.Text = "Aega jäänud kuni saab uuesti mängida:" & time.timeWait & "s"
        lblTimer.Visible = True
        data.setItem("time", "timeWaitCurrent", time.timeWait)

        If time.timeWait <= 0 And time.timeState = "On" Then
            btnClassic.Enabled = True
            btnPlay.Enabled = True

            time.timePlay = data.getItem("time", "timePlay")
            time.timeWait = data.getItem("time", "timeWait")

            lblTimer.Visible = False
            Timer1.Enabled = False

        End If

    End Sub

    Private Sub formMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim time As ITimeLimit
        time = New CTimeLimit

        If time.timePlay <= 0 Then
            Timer1.Enabled = True
            lblTimer.Text = "Aega jäänud kuni saab uuesti mängida:"
            lblTimer.Visible = True
            btnClassic.Enabled = False
            btnPlay.Enabled = False
        End If
    End Sub
    Private Sub btnWordList_Click(sender As Object, e As EventArgs) Handles btnWordList.Click
        Dim newForm As New formWordList
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



    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub


    Private Sub setLblColor()
        Dim colors As IGraphics
        colors = New CGraphics
        If (colors.red > 175 Or colors.red < 80) Or (colors.green > 175 Or colors.green < 80) _
            Or (colors.blue > 175 Or colors.blue < 80) Then
            colors.lblColor = Color.FromArgb(255, 255 - colors.red, 255 - colors.green, 255 - colors.blue)
        Else
            colors.lblColor = Color.FromArgb(255, 255 - (colors.red + 70), 255 - (colors.green + 70), 255 - (colors.blue + 70))
        End If
    End Sub

End Class
