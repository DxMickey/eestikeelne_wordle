
Public Class formGame

    'Listen for any keypress
    Private Sub formGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim game As Game.IGame
        game = New Game.CGame
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        'Salvesta vajutatud nupu ascii kood muutujasse lastLetter
        game.lastLetter = Asc(e.KeyChar)

        gameEngine()

    End Sub

    'Siin toimub kogu mäng
    Private Sub gameEngine()
        Dim game As Game.IGame
        game = New Game.CGame

        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        game.winOrLose = 0

        'Kui vajutatud klahv on Backspace ja Kasti arv pole 0, siis kustutakse viimane nupuvajutus ja kasti arvu vähendatakse
        If game.lastLetter = 8 And game.intKast <> 0 Then

            game.deleteLastKey()
            stringToControl(game.getBoxName(game.intRida, game.intKast))
            game.intKast = -1

        End If

        'Kui letterCheck tagastab True ja Kasti arv pole max kasti arv
        If game.letterCheck(game.lastLetter) And game.intKast <> game.maxKast Then

            'ArvatudSona-le viimase tähe lisamine
            game.ArvatudSona = UCase(Chr(game.lastLetter))

            'Kasti väärtuse suurendamine ühe võrra
            game.intKast = 1

            'Textboxi nime control-iks muutmine
            stringToControl(game.getBoxName(game.intRida, game.intKast))

            'Kui täht ei eksisteeri otsitavas sõnas ning ei ole juba olemas punaste tähtede stringis, siis lisa täht holderisse
            If game.isLetterInWord(game.strSona) = False Then
                game.redLettersHolder = UCase(Chr(game.lastLetter))

            End If
        End If

        'Kui vajutatud nupp on Enter ja Kasti number on maksimaalne
        If game.lastLetter = 13 And game.intKast = game.maxKast Then

            If data.isWordInList(game.ArvatudSona) > 0 Then

                'Kui sõna on arvatud, või read on otsa saanud, lõpeta mäng
                If game.gameOver() = True Then
                    finishGame()
                    'Vastasel juhul väärtuste taastamine uue rea jaoks ja rea suurendamine ühe võrra
                Else
                    updateColors()
                    lblScore.Text = game.gameScore
                    game.intRida = 1
                    game.intKast = Nothing
                    'Holderi tõstmine ümber punaste tähtede stringi ja Holderi tühjaks tegemine
                    game.redLetters = game.redLettersHolder
                    game.redLettersHolder = Nothing
                    game.ArvatudSona = Nothing

                End If
            Else

                MessageBox.Show("Sellist sõna pole listis")

            End If

        End If

    End Sub

    'Meetod kastide värvide uuendamiseks
    Private Sub updateColors()
        Dim game As Game.IGame
        game = New Game.CGame

        Dim i As Integer = 0
        Dim boxScore As Integer = 0

        'Loop mis käib läbi kõikide kastide
        While i < game.maxKast
            Dim misVarv As Integer

            misVarv = game.wordChecker(game.ArvatudSona(i), i)
            Dim boxName As String = game.getBoxName(game.intRida, i + 1)

            If Me.Controls.Find(boxName, True).Count = 1 Then
                Dim box As Label = Me.Controls.Find(boxName, True)(0)

                'Kui wordChecker tagastas 2, siis on õige täht vastavas kastis, ehk kast tehakse roheliseks
                If misVarv = 2 And box.BackColor <> Color.Green Then
                    'Iga roheline kast on 10 punkti
                    boxScore += 10
                    box.BackColor = Color.Green
                    Dim boxText1 As String = box.Text
                    changeKeyColor(boxText1, 2)

                    'Kui wordChecker tagastas 1, siis täht on sõnas olemas, aga vales kastis, seega kast tehakse kollaseks
                ElseIf misVarv = 1 And box.BackColor <> Color.Yellow Then
                    'Iga kollane kast on võrdeline 5 punktiga
                    boxScore += 5
                    box.BackColor = Color.Yellow
                    Dim boxText2 As String = box.Text
                    changeKeyColor(boxText2, 1)

                    'Kui wordChecker tagastas 0, siis tähte pole sõnas, ehk klaviatuuril tehakse täht punaseks ja täht lisatakse redLetters stringi
                ElseIf misVarv = 0 Then
                    box.BackColor = Color.Red
                    Dim boxText3 As String = box.Text
                    changeKeyColor(boxText3, 0)
                    game.redLetters = game.ArvatudSona(i)

                End If
            End If

            i = i + 1
        End While

        'Valem skoori leidmiseks, kui saadud skooriks on 0, siis seda ei arvestata
        If boxScore > 0 Then
            game.gameScore = boxScore * ((7 - game.intRida) * (11 - game.intRida))
        End If

    End Sub

    'Klaviatuuril tähe punaseks muutmine
    'input = stringi kujul täht
    Private Sub changeKeyColor(ByVal name As String, ByVal whichColor As Integer)

        Dim boxName As String = "lbl" & name

        If Me.Controls.Find(boxName, True).Count = 1 Then
            Dim box As Label = Me.Controls.Find(boxName, True)(0)

            If box.BackColor <> Color.Red And whichColor = 0 Then

                box.BackColor = Color.Red
            ElseIf box.BackColor <> Color.Green And box.BackColor <> Color.Yellow And whichColor = 1 Then
                box.BackColor = Color.Yellow
            ElseIf box.BackColor <> Color.Green And whichColor = 2 Then
                box.BackColor = Color.Green
            End If

        End If

    End Sub

    'Textboxi nime muutmine control-iks ja controli kasutades viimase vajutatud tähe sisestamine Textboxi
    'input = stringina Textboxi nimi
    Private Sub stringToControl(ByVal value As String)
        Dim game As Game.IGame
        game = New Game.CGame

        'https://stackoverflow.com/questions/47243351/how-to-obtain-a-control-using-its-name-in-visual-basic-net
        If Me.Controls.Find(value, True).Count = 1 Then
            'Kui viimane vajutatud klahv on Backspace siis Textboxi sisu tühjendatakse
            If game.lastLetter = 8 Then
                Dim box As Label = Me.Controls.Find(value, True)(0)
                box.Text = ""
                'Vastasel juhul sisestatakse Kasti väärtuseks viimasena vajutatud täht
            Else
                Dim box As Label = Me.Controls.Find(value, True)(0)
                box.Text = UCase(Chr(game.lastLetter))

            End If

        End If
    End Sub

    'Uue sõna hankimine sõnade listist
    Private Sub newWord()
        Dim game As Game.IGame
        game = New Game.CGame
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        game.strSona = UCase(data.getSona(Int((data.howManyWords() * Rnd()) + 1)))
        'Hetkel on sõnade tekstifailis tühimikus, seega kui tuleb tühimik, tuleb uus sõna valida
        While game.strSona = Nothing
            game.strSona = UCase(data.getSona(Int((data.howManyWords() * Rnd()) + 1)))
        End While
    End Sub

    'Meetod, mis töötab iga kord kui form avatakse
    Private Sub formGame_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim game As Game.IGame
        game = New Game.CGame
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim colors As IGraphics
        colors = New CGraphics

        'Debug sõna väärtuse peitmine
        txtDebug.Visible = False

        'Muuda labelite värvi
        lblTimeLeft.ForeColor = colors.lblColor
        lblTimeText.ForeColor = colors.lblColor
        Label1.ForeColor = colors.lblColor
        lblScore.ForeColor = colors.lblColor

        'Väärtuste taastamine algväärtustele uue mängu jaoks
        game.intKast = Nothing
        game.intRida = Nothing
        game.redLettersHolder = Nothing
        game.ArvatudSona = Nothing
        game.redLetters = Nothing
        game.kestvus = Nothing
        game.winOrLose = 0
        hideTextboxes()
        game.timeLeft = game.timeSetting
        lblTimeLeft.Text = game.timeSetting

        'Randomize() tuleb kasutada, et juhusliku sõna leiaks newWord(), vastasel juhul leiab Rnd() iga kord sama random numbri
        Randomize()
        'Peab olema true, et klahvivajutusi oleks võimalik jälgida
        Me.KeyPreview = True

        'Kuupäeva kontrollimine, kui mängitakse mitte piiramatut versiooni siis kui uus ja vana kuupäev on samad, tuleb vana sõna uuesti
        Dim uusKuupaev As String = DateTime.Today.ToShortDateString()
        Dim vanaKuupaev As String = data.getItem("miscData", "kuupaev")

        If game.kasPiiramatu = False Then

            game.strSona = data.getItem("miscData", "dailySona")
            If uusKuupaev.Equals(vanaKuupaev) = False Then
                newWord()
                data.setItem("miscData", "dailySona", game.strSona)
                data.setItem("miscData", "kuupaev", uusKuupaev)
            End If

        Else
            newWord()

        End If

        'Debugi jaoks arvatava sõna lisamine tekstiväljale, tekstivälja on võimalik nähtavale tuua F6 klahviga
        txtDebug.Text = game.strSona
        Timer1.Enabled = True
        If game.kasTimed Then
            Timer2.Enabled = True
            game.timeLeft = game.timeSetting
            lblTimeLeft.Visible = True
            lblTimeText.Visible = True

            'Ekstra punkte, kui timed versioon kasutuses
            If game.timeSetting = 360 Then
                game.gameScore = 5400
            ElseIf game.timeSetting = 200 Then
                game.gameScore = 12000
            ElseIf game.timeSetting = 120 Then
                game.gameScore = 18000
            End If
            'Uuenda skoor, et lisapunktid oleksid nähtavad
            lblScore.Text = game.gameScore
        Else
            lblTimeLeft.Visible = False
            lblTimeText.Visible = False
        End If

    End Sub

    'Mängu lõpetamine, andmete edastamine, uue formi avamine
    Private Sub finishGame()
        Dim game As Game.IGame
        game = New Game.CGame
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim time As ITimeLimit
        time = New CTimeLimit

        Timer1.Enabled = False
        Timer2.Enabled = False

        Dim kasArvatud As String
        If game.winOrLose = 1 Then
            kasArvatud = "Jah"
            'Kui sõna arvati ära, siis korrutatakse tavaline tulemus kümnega
            'et esimesel korral äraarvamine annaks suurima summa punkte
            game.gameScore = (10 * game.maxKast) * ((7 - game.intRida) * (11 - game.intRida)) * 10
        Else
            kasArvatud = "Ei"
        End If

        If time.timeState = "On" Then
            time.timePlay = time.timePlay - game.kestvus
            data.setItem("time", "timePlayCurrent", time.timePlay)
        End If

        'Mängu andmete sisestamine ajaloosse andmebaasis
        'data.insertHistory(data.getStat("m2ngude_arv"), game.gameMode, game.kestvus, game.strSona, kasArvatud, game.intRida, game.gameScore)
        data.insertHistory(data.getStat("m2ngude_arv"), game.gameScore, game.gameMode, game.kestvus, game.strSona, kasArvatud, game.intRida)
        enableAllTextBoxes()

        Me.Hide()
        'Uue formi avamine
        Dim newForm As New formGameEnd
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim game As Game.IGame
        game = New Game.CGame

        game.kestvus = 1

    End Sub

    'Vastavalt raskusastmetele, vastava arvu kastide peitmine
    'Kui Kerge siis 2 viimase rea peitmine
    'Kui Tavaline siis 1 viimase rea peitmine
    Private Sub hideTextboxes()
        Dim game As Game.IGame
        game = New Game.CGame

        If game.gameMode = "Kerge" Then
            For i As Integer = 5 To 6
                For j As Integer = 1 To 6
                    hideThisTextBox("lblRida" & j & "Kast" & i, False)
                Next
            Next
        ElseIf game.gameMode = "Tavaline" Then
            For i As Integer = 1 To 6

                hideThisTextBox("lblRida" & i & "Kast6", False)
            Next

        End If
    End Sub

    'Meetod Kasti nähtamatuks tegemiseks
    'input = value1 on textboxi nimi; value2 on boolean väärtus, kui False siis kast muudetakse nähtamatuks, kui True siis nähtavaks
    Private Sub hideThisTextBox(ByVal value1 As String, ByVal value2 As Boolean)

        If Me.Controls.Find(value1, True).Count = 1 Then
            Dim box As Label = Me.Controls.Find(value1, True)(0)
            box.Visible = value2

        End If
    End Sub

    'Kõikide kastide nähtavaks tegemine
    Private Sub enableAllTextBoxes()
        For i As Integer = 5 To 6
            For j As Integer = 1 To 6
                hideThisTextBox("lblRida" & j & "Kast" & i, True)
            Next
        Next

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim game As Game.IGame
        game = New Game.CGame

        If game.timeLeft <= 0 Then
            finishGame()
            Exit Sub
        End If

        'Vähem lisapunkte, mida aeglasemalt mängitakse
        If game.timeSetting = 360 Then
            game.gameScore = -15
        ElseIf game.timeSetting = 200 Then
            game.gameScore = -60
        ElseIf game.timeSetting = 120 Then
            game.gameScore = -150
        End If

        'Uuenda skoori
        lblScore.Text = game.gameScore
        game.timeLeft = (game.timeLeft - 1)
        lblTimeLeft.Text = game.timeLeft
    End Sub

    'Listen for any click on on-screen keyboard
    Private Sub lblQ_Click(sender As Object, e As EventArgs) Handles lblQ.Click, lblZ.Click, lblY.Click, lblX.Click, lblW.Click, lblV.Click, lblÜ.Click, lblU.Click, lblT.Click, lblS.Click, lblR.Click, lblP.Click, lblÕ.Click, lblÖ.Click, lblO.Click, lblN.Click, lblM.Click, lblL.Click, lblK.Click, lblJ.Click, lblI.Click, lblH.Click, lblG.Click, lblF.Click, lblEnter.Click, lblE.Click, lblD.Click, lblC.Click, lblBackspace.Click, lblB.Click, lblÄ.Click, lblA.Click
        Dim game As Game.IGame
        game = New Game.CGame

        If sender.Text = "ENTER" Then
            game.lastLetter = 13
        ElseIf sender.Text = "KUSTUTA" Then
            game.lastLetter = 8
        Else
            'viimase klahvi ascii koodi salvestamine lastLetterisse
            game.lastLetter = Asc(sender.Text)

        End If

        gameEngine()

    End Sub

    Private Sub formGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'F6 klahvi vajutusel muudetakse debugi sõna väärtus nähtavaks
        If e.KeyCode = Keys.F6 Then
            txtDebug.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tulemus As DialogResult = MessageBox.Show("Kas olete kindel, et soovide mängust lahkuda?", "Kinnitus", MessageBoxButtons.YesNo)
        If tulemus = DialogResult.Yes Then
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
        End If
    End Sub
End Class