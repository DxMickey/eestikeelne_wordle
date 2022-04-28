Imports Google.Cloud.Translation.V2

Public Class formGameEnd
    Private Sub btbPlayAgain_Click(sender As Object, e As EventArgs) Handles btbPlayAgain.Click
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

    Private Sub btbToMenu_Click(sender As Object, e As EventArgs) Handles btbToMenu.Click
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

    Private Sub formGameEnd_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim game As Game.IGame
        game = New Game.CGame
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim time As ITimeLimit
        time = New CTimeLimit

        If time.timeState = "On" And time.timePlay <= 0 Then
            btbPlayAgain.Enabled = False
        Else
            btbPlayAgain.Enabled = True
        End If

        Dim colors As IGraphics
        colors = New CGraphics

        Dim tempHighScore As Integer = data.getStat("suurim_skoor")
        Dim gamesPlayed As Integer = data.getStat("m2ngude_arv")
        Dim tempAverageScore As Int64 = 0
        Dim averageScore As Integer = 0
        Dim firstGameIndex As Integer = data.getItemInt("gameHistory", "mitmesMäng")
        lblNewHighscore.Visible = False

        'Leia suurim skoor, kui uus skoor on suurem kui vana, siis uuenda
        'If tempHighScore < game.gameScore Then
        'data.setScoreItem("suurim_skoor", game.gameScore)
        'lblNewHighscore.Visible = True
        ' End If



        'Tõlkekasti keelte valiku lisamine
        cmbLanguage.Items.Add("en")
        cmbLanguage.Items.Add("ru")
        cmbLanguage.Items.Add("fi")
        cmbLanguage.Items.Add("fr")
        cmbLanguage.Items.Add("de")
        cmbLanguage.Items.Add("it")
        cmbLanguage.Items.Add("es")

        'Võidu või kaotuse teksti valimine
        If game.winOrLose = 1 Then
            lblResult.ForeColor = colors.lblColor
            lblResult.Text = "Sa arvasid sõna ära!"
        Else
            lblResult.ForeColor = colors.lblColor
            lblResult.Text = "Sa ei suutnud sõna ära arvata!"
        End If

        'Vaheta labelite värvid
        lblSona.ForeColor = colors.lblColor
        lblBestScore.ForeColor = colors.lblColor
        lblBestScoreName.ForeColor = colors.lblColor
        lblGameScore.ForeColor = colors.lblColor
        lblScoreName.ForeColor = colors.lblColor
        lblNewHighscore.ForeColor = colors.lblColor

        'Mängu sõna
        lblSona.Text = game.strSona

        'Sõna tähenduse saamine
        Dim sonaTahendus As SonaTahendus.ISonaTahendus
        sonaTahendus = New SonaTahendus.CSonaTahendus
        UcSonaTahendus1._backColor = colors.backColor
        UcSonaTahendus1._textColor = colors.lblColor
        Dim tahendus = sonaTahendus.getSonaTahendus(game.strSona)
        UcSonaTahendus1.setWordTexts(game.strSona, tahendus)


        'Mängu skoor
        lblGameScore.Text = game.gameScore
        lblBestScore.Text = data.getStat("suurim_skoor")
        'Nulli skoor uue mängu jaoks
        game.gameScore = Nothing


        'Achievement chechker
        Dim ac As AchievementChecker.IAchievements 'ei tea miks achievementchecker mitte achievements
        ac = New AchievementChecker.CAchievements
        Dim achievement = ac.getAchievements() 'massiiv, kus title ja kirjeldus

        'NotificationAchievemen
        'if achievements siis 
        If ac.TwoHundredGames Then
            Dim notif As Notification.INotification
            notif = New Notification.CNotification
            notif.backColor = colors.backColor
            notif.textColor = colors.lblColor

            notif.showNotif(Me, achievement(1), achievement(0))
        End If


    End Sub

    'Google.Cloud.Translation.V2 API kasutamine sõna tõlke saamiseks
    Private Sub TranslateWord()
        Dim game As Game.IGame
        game = New Game.CGame

        Dim TClient As TranslationClient = TranslationClient.CreateFromApiKey("AIzaSyAv_0Zx3VCVGgn0hGLMoCCtT4O5xtYu1rY")
        If checkInternet() = False Then
            txtTranslation.Text = "Internet puudub"
        Else

            Dim response = TClient.TranslateText(game.strSona, cmbLanguage.SelectedItem, "et")
            Dim result As String = response.TranslatedText

            If String.Equals(result, game.strSona) Then
                txtTranslation.Text = "Puudub"
            Else
                txtTranslation.Text = result
            End If
        End If

    End Sub

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        TranslateWord()
    End Sub

    'Internetiühenduse kontrollimine, kui google.com-i pingimine ebaõnnestub, tagastab False
    Private Function checkInternet() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False

        End Try

    End Function



End Class