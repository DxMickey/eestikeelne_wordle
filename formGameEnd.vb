Imports Google.Cloud.Translation.V2

Public Class formGameEnd
    Private Sub btbPlayAgain_Click(sender As Object, e As EventArgs) Handles btbPlayAgain.Click
        Dim position = Me.Bounds
        Dim newForm As New formGame
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btbToMenu_Click(sender As Object, e As EventArgs) Handles btbToMenu.Click
        Dim position = Me.Bounds
        Dim newForm As New formMenu
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub formGameEnd_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim game As IGame
        game = New CGame
        Dim data As IDatabase
        data = New CDatabase

        cmbLanguage.Items.Add("en")
        cmbLanguage.Items.Add("ru")
        cmbLanguage.Items.Add("fi")
        cmbLanguage.Items.Add("fr")
        cmbLanguage.Items.Add("de")
        cmbLanguage.Items.Add("it")
        cmbLanguage.Items.Add("es")





        If game.winOrLose = 1 Then
            lblResult.Text = "Sa arvasid sõna ära!"
        Else
            lblResult.Text = "Sa ei suutnud sõna ära arvata!"
        End If

        lblSona.Text = game.strSona
    End Sub

    Private Sub TranslateWord()
        Dim game As IGame
        game = New CGame

        Dim TClient As TranslationClient = TranslationClient.CreateFromApiKey("AIzaSyAv_0Zx3VCVGgn0hGLMoCCtT4O5xtYu1rY")

        Dim response = TClient.TranslateText(game.strSona, cmbLanguage.SelectedItem, "et")
        Dim result As String = response.TranslatedText

        If result = game.strSona Then
            txtTranslation.Text = "Puudub"
        Else
            txtTranslation.Text = result
        End If



    End Sub

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        TranslateWord()
    End Sub
End Class