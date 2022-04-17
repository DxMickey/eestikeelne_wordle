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
        Dim game As IGame
        game = New CGame
        Dim data As IDatabase
        data = New CDatabase
        Dim colors As IGraphics
        colors = New CGraphics

        Dim tempHighScore As Integer = data.getStat("suurim_skoor")
        Dim gamesPlayed As Integer = data.getStat("m2ngude_arv")
        Dim tempAverageScore As Int64 = 0
        Dim averageScore As Integer = 0
        lblNewHighscore.Visible = False

        'Leia suurim skoor, kui uus skoor on suurem kui vana, siis uuenda
        If tempHighScore < game.gameScore Then
            data.setScoreItem("suurim_skoor", game.gameScore)
            lblNewHighscore.Visible = True
        End If

        'Leia keskmine skoor
        For i As Integer = 1 To gamesPlayed Step 1
            Dim temp As Integer = data.getItemWithId("gameHistory", "score", i)
            If temp > 0 Then
                tempAverageScore += temp
            End If
        Next
        averageScore = tempAverageScore / gamesPlayed
        data.setScoreItem("keskmine_skoor", averageScore)

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
        'Mängu skoor
        lblGameScore.Text = game.gameScore
        lblBestScore.Text = data.getStat("suurim_skoor")
        'Nulli skoor uue mängu jaoks
        game.gameScore = Nothing

    End Sub

    'Google.Cloud.Translation.V2 API kasutamine sõna tõlke saamiseks
    Private Sub TranslateWord()
        Dim game As IGame
        game = New CGame

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