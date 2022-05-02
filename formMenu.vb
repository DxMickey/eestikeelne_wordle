Imports System.Net

Public Class formMenu
    Dim utils As Utils.IUtils = New Utils.CUtils
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim game As Game.IGame
        game = New Game.CGame

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
        Dim game As Game.IGame
        game = New Game.CGame

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
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase


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
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        If time.timeWait <= 0 And time.timeState = "On" Then
            btnClassic.Enabled = True
            btnPlay.Enabled = True

            time.timePlay = data.getItem("time", "timePlay")
            time.timeWait = data.getItem("time", "timeWait")
            data.setItem("time", "timeWaitCurrent", time.timeWait)
            data.setItem("time", "timePlayCurrent", time.timePlay)


            lblTimer.Visible = False
            Timer1.Enabled = False
        Else
            time.timeWait = time.timeWait - 1
            lblTimer.Text = "Aega jäänud kuni saab uuesti mängida:" & utils.secondsToTimeString(time.timeWait)
            lblTimer.Visible = True
            data.setItem("time", "timeWaitCurrent", time.timeWait)

        End If





    End Sub

    Private Sub formMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim time As ITimeLimit
        time = New CTimeLimit
        Dim colors As IGraphics
        colors = New CGraphics

        lblTimer.ForeColor = colors.lblColor


        If time.timePlay <= 0 And time.timeState = "On" Then
            Timer1.Enabled = True
            ' lblTimer.Text = "Aega jäänud kuni saab uuesti mängida:"
            'lblTimer.Visible = True
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim utils As Utils.IUtils
        utils = New Utils.CUtils

        'Interneti ühenduse kontrollimine
        If utils.isNetworkConnection() = False Then
            MessageBox.Show("Internet puudub")
        Else

            Dim client As New WebClient
            Dim saveFile As New SaveFileDialog
            'Cloudis olevate sõnalistide asukohad
            Dim fileUrl1 As String = "https://docs.google.com/uc?export=download&id=1BEwFvCp8TXU1tqlo9cJccKilIWvg_lTM"
            Dim fileUrl2 As String = "https://docs.google.com/uc?export=download&id=1tpY8m6-sEzLla8l160oSGyFPvlkCJQFm"
            Dim fileUrl3 As String = "https://docs.google.com/uc?export=download&id=1dR14DNVom_LtZkZAyNmrIDb9XdwO6RPy"
            MessageBox.Show("Uuenduse kontrollimine võib võtta mõne hetke!")
            Cursor = Cursors.WaitCursor

            'Cloudis olevad sõnalistid laetakse alla
            client.DownloadFile(New Uri(fileUrl1), "sonadeListEasy.csv")
            client.DownloadFile(New Uri(fileUrl2), "sonadeList.csv")
            client.DownloadFile(New Uri(fileUrl3), "sonadeListHard.csv")

            'Kontrollimine, kas alla laetud sõnalistides on erinev hulk sõnu võrreldes andmebaasis olevatega, kui on erinev tähendab, et on erinev versioon ja uuendus on olemas.
            If data.fileCountWords("sonadeListEasy.csv") <> data.listCountWords("sonadeListEasy") Or data.fileCountWords("sonadeList.csv") <> data.listCountWords("sonadeList") Or data.fileCountWords("sonadeListHard.csv") <> data.listCountWords("sonadeListHard") Then
                Cursor = Cursors.Default
                'Kasutajale valiku andmine, kas ta soovib uuendada
                Dim tulemus As DialogResult = MessageBox.Show("Uuendus on olemas. Kas te soovite uuendada sõnu?", "Uuendus", MessageBoxButtons.YesNo)
                If tulemus = DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    'Sõnade asendamine vastavas sõnadelistis andmebaasis, kui sõnade hulk erineb
                    If data.fileCountWords("sonadeListEasy.csv") <> data.listCountWords("sonadeListEasy") Then
                        data.updateWordList("sonadeListEasy")
                    End If
                    If data.fileCountWords("sonadeList.csv") <> data.listCountWords("sonadeList") Then
                        data.updateWordList("sonadeList")
                    End If
                    If data.fileCountWords("sonadeListHard.csv") <> data.listCountWords("sonadeListHard") Then
                        data.updateWordList("sonadeListHard")
                    End If

                    'Allalaaditud sõnalistide kustutamine
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath() & "\sonadeListEasy.csv")
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath() & "\sonadeList.csv")
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath() & "\sonadeListHard.csv")

                    Cursor = Cursors.Default
                    MessageBox.Show("Uuendus lõpetatud")

                Else
                    Cursor = Cursors.Default
                End If
            Else
                Cursor = Cursors.Default
                MessageBox.Show("Uuendust ei ole!")

            End If


        End If
    End Sub


End Class

