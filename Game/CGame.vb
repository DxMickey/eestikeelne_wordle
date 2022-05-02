Public Class CGame
    Implements IGame

    Shared strSonaSymbol As String
    Shared intRidaSymbol As Integer
    Shared intKastSymbol As Integer
    Shared strArvatudSona As String
    Shared intLastLetter As Integer
    Shared strRedLetters As String
    Shared strRedLettersHolder As String
    Shared intWinOrLose As Integer
    Shared intKestvus As Integer
    Shared strGameMode As String
    Shared intMaxKast As Integer
    Shared intTimeLeft As Integer
    Shared intTimeSetting As Integer
    Shared boolKasTimed As Boolean
    Shared boolKasPiiramatu As Boolean
    Shared intMisKuupaev As Date
    Shared intGameScore As Integer

    Public Property misKuupaev As Date Implements IGame.misKuupaev
        Get
            Return intMisKuupaev
        End Get
        Set(ByVal value As Date)
            intMisKuupaev = value
        End Set
    End Property

    Private Property kasPiiramatu As Boolean Implements IGame.kasPiiramatu
        Get
            Return boolKasPiiramatu
        End Get
        Set(ByVal value As Boolean)
            boolKasPiiramatu = value
        End Set
    End Property

    Private Property kasTimed As Boolean Implements IGame.kasTimed
        Get
            Return boolKasTimed
        End Get
        Set(ByVal value As Boolean)
            boolKasTimed = value
        End Set
    End Property

    Private Property timeSetting As Integer Implements IGame.timeSetting
        Get
            Return intTimeSetting
        End Get
        Set(ByVal value As Integer)
            intTimeSetting = value
        End Set
    End Property

    Private Property timeLeft As Integer Implements IGame.timeLeft
        Get
            Return intTimeLeft
        End Get
        Set(ByVal value As Integer)
            intTimeLeft = value
        End Set
    End Property

    Private Property kestvus As Integer Implements IGame.kestvus
        Get
            Return intKestvus
        End Get
        Set(ByVal value As Integer)
            If value = Nothing Then
                intKestvus = 0
            Else
                'intKestvusele väärtuse value lisamine
                intKestvus = kestvus + value
            End If

        End Set
    End Property

    Private Property gameMode As String Implements IGame.gameMode
        Get
            Return strGameMode
        End Get
        Set(ByVal value As String)
            strGameMode = value
        End Set
    End Property

    Private Property maxKast As Integer Implements IGame.maxKast
        Get
            Return intMaxKast
        End Get
        Set(ByVal value As Integer)
            intMaxKast = value
        End Set
    End Property

    Private Property lastLetter As Integer Implements IGame.lastLetter
        Get
            Return intLastLetter
        End Get
        Set(ByVal value As Integer)
            intLastLetter = value
        End Set
    End Property

    Private Property redLetters As String Implements IGame.redLetters
        Get
            Return strRedLetters
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                strRedLetters = Nothing
            Else
                'Väärtuse value lisamine stringile strRedLetters
                strRedLetters = strRedLetters & value
            End If

        End Set
    End Property

    Private Property redLettersHolder As String Implements IGame.redLettersHolder
        Get
            Return strRedLettersHolder
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                strRedLettersHolder = Nothing
            Else
                'Väärtuse value lisamine stringile redLettersHolder
                strRedLettersHolder = redLettersHolder & value
            End If

        End Set
    End Property

    Private Property winOrLose As Integer Implements IGame.winOrLose
        Get
            Return intWinOrLose
        End Get
        Set(ByVal value As Integer)
            intWinOrLose = value
        End Set
    End Property

    Private Property ArvatudSona As String Implements IGame.ArvatudSona
        Get
            Return strArvatudSona
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                strArvatudSona = Nothing
                'Kui ArvatudSona-l pole väärtust, siis on ArvatudSona uueks väärtuseks value
            ElseIf strArvatudSona = Nothing Then
                strArvatudSona = value
                'Kui vajutatud klahv ei ole Backspace siis value väärtus lisatakse stringile strArvatudSona
            ElseIf lastLetter <> 8 Then
                strArvatudSona = strArvatudSona & value
            End If

        End Set
    End Property

    Private Property strSona As String Implements IGame.strSona
        Get
            Return strSonaSymbol
        End Get
        Set(ByVal value As String)
            strSonaSymbol = value
        End Set
    End Property

    Private Property intRida As Integer Implements IGame.intRida
        Get
            Return intRidaSymbol
        End Get
        Set(ByVal value As Integer)
            'Kui value on 1, siis lisatakse ridade arvule 1
            If value = 1 Then
                intRidaSymbol = intRida + 1
                'Kui value on Nothing, siis toimub ridade algasendisse taastamine ehk ridade arv on 1
            ElseIf value = Nothing Then
                intRidaSymbol = 1
            End If

        End Set
    End Property

    Private Property intKast As Integer Implements IGame.intKast
        Get
            Return intKastSymbol
        End Get
        Set(ByVal value As Integer)

            'Kui value on Nothing siis taastatakse Kastide väärtus tagasi 0-i
            If value = Nothing Then
                intKastSymbol = 0

                'Kui viimane vajutad klahv ei ole Backspace ning Kastide väärtus pole maksimaalne, siis suurendatakse Kastide väärtust ühe võrra
            ElseIf intLastLetter <> 8 And intKast <> maxKast Then
                intKastSymbol = intKast + 1
                'Kui value on -1, siis vähendatakse Kastide väärtust ühe võrra
            ElseIf value = -1 Then
                intKastSymbol = intKastSymbol - 1
            End If
        End Set
    End Property

    Public Property gameScore As Integer Implements IGame.gameScore
        Get
            Return intGameScore
        End Get
        Set(value As Integer)
            If value = Nothing Then
                intGameScore = 0
            ElseIf value = 0 Then
                intGameScore = gameScore
            Else
                intGameScore = gameScore + value
            End If
        End Set
    End Property

    'ArvatudSona-st viimase tähe kustutamine
    Private Sub deleteLastKey() Implements IGame.deleteLastKey
        Dim oldArvatud As String = ArvatudSona
        Dim redLetters As String = redLettersHolder

        ArvatudSona = Nothing

        If oldArvatud.Length <> 0 Then
            ArvatudSona = oldArvatud.Substring(0, oldArvatud.Length - 1)
        End If

        If redLetters <> Nothing Then
            Dim charAtRedIndex As String = redLetters.Chars(redLetters.Length - 1)
            Dim charAtArvatudIndex As String = oldArvatud.Chars(oldArvatud.Length - 1)

            If charAtRedIndex = charAtArvatudIndex Then
                redLettersHolder = Nothing
                redLettersHolder = redLetters.Substring(0, redLetters.Length - 1)
            End If
        End If

    End Sub

    'Kontrollib kas viimane vajutatud täht on otsitavas sõnas ning kas on juba salvestatud punaste tähtede hoidjasse
    'input = otsitav sõna
    'output = True kui viimane vajutatud täht on otsitavas sõnas või on juba olemas punaste tähtede hoidjas
    '         False kui viimane vajutatud täht ei ole otsitavas sõnas ja ei ole juba olemas punaste tähtede hoidjas
    Private Function isLetterInWord(value As String) As Boolean Implements IGame.isLetterInWord
        Dim letterInWord As Boolean = False

        'Kontrollimine kas viimane vajutatud täht eksisteerib otsitavas sõnas, kui jah siis letterInWord on True
        For i = 0 To value.Length - 1
            If UCase(Chr(lastLetter)) = value(i) Then
                letterInWord = True
            End If

        Next
        'Kui redLettersHolder ei ole tühi, kontrollitakse ega viimane vajutatud täht juba ei ole olemas otsitavas sõnas mitte eksisteerivate tähtede stringis. Kui on siis letterInWord on True
        If redLettersHolder <> Nothing Then
            For i = 0 To redLettersHolder.Length - 1
                If UCase(Chr(lastLetter)) = redLettersHolder(i) Then
                    letterInWord = True
                End If

            Next
        End If

        Return letterInWord
    End Function

    'Sisestatud tähtede võrdlemine otsitava sõnaga
    'input = täht, tähe index
    'output = 2 kui otsitava sõnas on samas kohas sama täht
    '         1 kui täht on olemas arvatavas sõnas aga mitte samas kohas
    '         0 kui tähte pole arvatavas sõnas
    Private Function wordChecker(ByVal value As String, ByVal index As Integer) Implements IGame.wordChecker
        Dim game As IGame
        game = New CGame

        Dim tulemus As Integer = 0
        Dim i As Integer = 0

        While i < game.maxKast

            If strSona(i) = value And i = index Then
                tulemus = 2

            ElseIf tulemus = 0 And strSona(i) = value Then
                tulemus = 1

            End If
            i = i + 1
        End While

        Return tulemus

    End Function

    'Kontrollib kas arvatud sõna on otsitav sõna
    'output = True kui otsitav sõna = arvatud sõna
    '         True kui sõnad ei ühti, aga rida on 6, ehk mängija kaotas mängu
    Private Function gameOver() As Boolean Implements IGame.gameOver
        Dim over As Boolean
        If strSona = strArvatudSona Then
            over = True
            winOrLose = 1
        ElseIf intRida = 6 Then
            over = True
        End If
        Return over
    End Function

    'Kontrollib, kas vajutatud klahv on täht ning ei kuulu punaste tähtede hulka
    'input = sisestatud klahvi ascii kood
    'output = True kui vajutatud klahv on täht ning ei kuulu punaste tähtede hulka
    '         False kui vajutatud klahv ei ole täht või kuulub punaste tähtede hulka
    Private Function letterCheck(value As Integer) As Boolean Implements IGame.letterCheck
        Dim letterIsCorrect As Boolean = False
        Dim i As Integer

        'Kontrollimine kas viimase vajutatud klahvi ascii kood vastab korrektsete klahvide koodiga.
        If value >= 65 And value <= 90 Or value >= 97 And value <= 122 Or value = 196 Or value = 213 Or value = 214 Or value = 220 Or value = 228 Or value = 245 Or value = 246 Or value = 252 Then
            letterIsCorrect = True
        End If

        Return letterIsCorrect
    End Function

    'Funktsioon textboxi nime saamiseks
    'input = rea arv, kasti arv
    'output = Labeli nimi vastava rea ja kasti arvuga
    Private Function getBoxName(ByVal value1 As Integer, ByVal value2 As Integer) As String Implements IGame.getBoxName

        Dim whichBox As String = "lblRida" & value1.ToString & "Kast" & value2.ToString

        Return whichBox
    End Function

End Class