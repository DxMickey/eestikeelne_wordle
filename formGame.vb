
Public Class formGame

    'Listen for any keypress
    Private Sub formGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim game As IGame
        game = New CGame

        Dim data As IDatabase
        data = New CDatabase

        'Salvesta vajutatud nupu ascii kood muutujasse lastLetter
        game.lastLetter = Asc(e.KeyChar)

        'Kui vajutatud klahv on Backspace ja Kasti arv pole 0
        If game.lastLetter = 8 And game.intKast <> 0 Then

            game.deleteLastKey()
            stringToControl(game.getBoxName(game.intRida, game.intKast))
            game.intKast = -1

        End If

        'Kui vajutatud nupp On Enter ja viimane täht On sisestatud, uuenda värve
        If game.lastLetter = 13 And game.intKast = game.maxKast Then
            updateColors()

        End If

        'Kui letterCheck tagastab True ja Kasti arv pole max kasti arv
        If game.letterCheck(game.lastLetter) And game.intKast <> game.maxKast Then
            game.intKast = 1
            'ArvatudSona-le viimase tähe lisamine
            game.ArvatudSona = UCase(Chr(game.lastLetter))
            'Textboxi nime control-iks muutmine
            stringToControl(game.getBoxName(game.intRida, game.intKast))

            If game.isLetterInWord(game.strSona) = False Then
                game.redLettersHolder = UCase(Chr(game.lastLetter))

            End If
        End If

        'Kui vajutatud nupp on Enter ja Kasti number on max
        If game.lastLetter = 13 And game.intKast = game.maxKast Then

            'Mängu resettimine ja mängu lõpu ekraanile liikumine
            If game.gameOver() = True Then
                finishGame()
            Else
                game.intRida = 1
                game.intKast = 2
                game.redLetters = game.redLettersHolder
                game.redLettersHolder = Nothing
                game.ArvatudSona = Nothing

            End If


        End If

    End Sub

    'Sub kastide värvide uuendamiseks
    Private Sub updateColors()
        Dim game As IGame
        game = New CGame

        Dim i As Integer = 0

        While i < game.maxKast
            Dim misVarv As Integer

            misVarv = game.wordChecker(game.ArvatudSona(i), i)
            Dim a As String = game.getBoxName(game.intRida, i + 1)

            If Me.Controls.Find(a, True).Count = 1 Then
                Dim box As TextBox = Me.Controls.Find(a, True)(0)

                'Kui wordChecker tagastas 2, siis on õige täht vastavas kastis, ehk kast tehakse roheliseks
                If misVarv = 2 And box.BackColor <> Color.Green Then
                    box.BackColor = Color.Green

                    'Kui wordChecker tagastas 1, siis täht on sõnas olemas, aga vales kastis, seega kast tehakse kollaseks
                ElseIf misVarv = 1 And box.BackColor <> Color.Yellow Then
                    box.BackColor = Color.Yellow

                    'Kui wordChecker tagastas 0, siis tähte pole sõnas, ehk klaviatuuril tehakse täht punaseks ja täht lisatakse redLetters stringi
                ElseIf misVarv = 0 Then
                    Dim f As String = box.Text
                    makeKeyRed(f)
                    game.redLetters = game.ArvatudSona(i)

                End If
            End If

            i = i + 1
        End While

    End Sub

    'Klaviatuuril tähe punaseks muutmine
    'input = stringi kujul täht
    Private Sub makeKeyRed(ByVal value As String)

        Dim a As String = "txt" & value

        If Me.Controls.Find(a, True).Count = 1 Then
            Dim box As TextBox = Me.Controls.Find(a, True)(0)
            If box.BackColor <> Color.Red Then

                box.BackColor = Color.Red
            End If

        End If

    End Sub

    'Textboxi nime muutmine control-iks ja controli kasutades viimase vajutatud tähe sisestamine Textboxi
    'input = stringina Textboxi nimi
    Private Sub stringToControl(ByVal value As String)
        Dim game As IGame
        game = New CGame

        'https://stackoverflow.com/questions/47243351/how-to-obtain-a-control-using-its-name-in-visual-basic-net
        If Me.Controls.Find(value, True).Count = 1 Then
            'Kui viimane vajutatud klahv on Backspace siis Textboxi sisu tühjendatakse
            If game.lastLetter = 8 Then
                Dim box As TextBox = Me.Controls.Find(value, True)(0)
                box.Text = ""
            Else
                Dim box As TextBox = Me.Controls.Find(value, True)(0)
                box.Text = UCase(Chr(game.lastLetter))

            End If

        End If
    End Sub

    'Uue sõna hankimine sõnade listist
    Private Sub newWord()
        Dim game As IGame
        game = New CGame
        Dim data As IDatabase
        data = New CDatabase

        game.strSona = UCase(data.getSona(Int((3000 * Rnd()) + 1)))
        'Hetkel on sõnade tekstifailis tühimikus, seega kui tuleb tühimik, tuleb uus sõna valida
        While game.strSona = Nothing
            game.strSona = UCase(data.getSona(Int((3000 * Rnd()) + 1)))
        End While
    End Sub

    'Sub, mis töötab iga kord kui form avatakse
    Private Sub formGame_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim game As IGame
        game = New CGame
        Dim data As IDatabase
        data = New CDatabase

        'Väärtuste taastamine algandmetele
        game.intKast = Nothing
        game.intRida = Nothing
        game.redLettersHolder = Nothing
        game.ArvatudSona = Nothing
        game.redLetters = Nothing
        game.kestvus = Nothing
        hideTextboxes()


        'Randomize() tuleb kasutada, et juhusliku sõna leiaks newWord(), vastasel juhul leiab Rnd() iga kord sama random numbri
        Randomize()
        'Peab olema true, et klahvivajutusi oleks võimalik jälgida
        Me.KeyPreview = True
        newWord()
        txtDebug.Text = game.strSona
        Timer1.Enabled = True

    End Sub

    'Mängu lõpetamine, andmete edastamine, uue formi avamine
    Private Sub finishGame()
        Dim game As IGame
        game = New CGame

        Dim data As IDatabase
        data = New CDatabase

        Timer1.Enabled = False


        Dim avgTime As Integer = 0
        If data.getStat("GamesPlayed") <> 0 Then
            avgTime = (data.getStat("TimePlayed") + game.kestvus) / (data.getStat("GamesPlayed") + 1)
        ElseIf data.getStat("GamesPlayed") = 0 Then
            avgTime = game.kestvus
        End If

        'Mängude statistika uuendamine
        data.updateStats(data.getStat("GamesPlayed") + 1, data.getStat("TimePlayed") + game.kestvus, avgTime)

        Dim kasArvatud As String
        If game.winOrLose = 1 Then
            kasArvatud = "jah"
        Else
            kasArvatud = "ei"
        End If
        data.insertHistory(data.getStat("GamesPlayed"), game.gameMode, game.kestvus, game.strSona, kasArvatud)

        enableAllTextBoxes()

        'Uue formi avamine
        Dim position = Me.Bounds
        Dim newForm As New formGameEnd
        AddHandler newForm.Load, Sub() newForm.Bounds = position
        newForm.Show()
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim game As IGame
        game = New CGame

        game.kestvus = 1

        txtDebug2.Text = game.kestvus

    End Sub

    Private Sub hideTextboxes()
        Dim game As IGame
        game = New CGame

        If game.gameMode = "Kerge" Then
            For i As Integer = 5 To 6
                For j As Integer = 1 To 6
                    hideThisTextBox("txtRida" & j & "Kast" & i, False)
                Next
            Next
        ElseIf game.gameMode = "Tavaline" Then
            For i As Integer = 1 To 6

                hideThisTextBox("txtRida" & i & "Kast6", False)
            Next

        End If
    End Sub

    Private Sub hideThisTextBox(ByVal value1 As String, ByVal value2 As Boolean)

        If Me.Controls.Find(value1, True).Count = 1 Then
            Dim box As TextBox = Me.Controls.Find(value1, True)(0)
            box.Visible = False


        End If
    End Sub

    Private Sub enableAllTextBoxes()
        For i As Integer = 5 To 6
            For j As Integer = 1 To 6
                hideThisTextBox("txtRida" & j & "Kast" & i, True)
            Next
        Next

    End Sub
End Class