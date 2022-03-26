﻿Public Class CGame
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

    Public Property kestvus As Integer Implements IGame.kestvus
        Get
            Return intKestvus
        End Get
        Set(ByVal value As Integer)
            If value = Nothing Then
                intKestvus = 0
            Else
                intKestvus = kestvus + value
            End If

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
            End If

            If strArvatudSona = Nothing Then
                strArvatudSona = value
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
            If value = 1 Then
                intRidaSymbol = intRida + 1
            End If
            If value = Nothing Then
                intRidaSymbol = 1
            End If

        End Set
    End Property

    Private Property intKast As Integer Implements IGame.intKast
        Get
            Return intKastSymbol
        End Get
        Set(ByVal value As Integer)
            If value = 2 And intLastLetter <> 8 Then
                intKastSymbol = 0
            ElseIf intLastLetter <> 8 And intKast <> 5 Then
                intKastSymbol = intKast + value
            End If
            If value = Nothing Then
                intKastSymbol = 0
            End If
            If value = -1 Then
                intKastSymbol = intKastSymbol - 1
            End If

        End Set
    End Property

    'Kontrollib kas viimane vajutatud täht on otsitavas sõnas ning kas on juba salvestatud punaste tähtede hoidjasse
    'input = otsitav sõna 
    'output = True kui viimane vajutatud täht on otsitavas sõnas või on juba olemas punaste tähtede hoidjas
    '         False kui viimane vajutatud täht ei ole otsitavas sõnas ja ei ole juba olemas punaste tähtede hoidjas
    Private Function isLetterInWord(value As String) As Boolean Implements IGame.isLetterInWord
        Dim a As Boolean = False

        For i = 0 To value.Length - 1
            If UCase(Chr(lastLetter)) = value(i) Then
                a = True
            End If

        Next
        If redLettersHolder <> Nothing Then
            For i = 0 To redLettersHolder.Length - 1
                If UCase(Chr(lastLetter)) = redLettersHolder(i) Then
                    a = True
                End If

            Next
        End If

        Return a
    End Function

    'Sisestatud tähtede võrdlemine otsitava sõnaga
    'input = täht, tähe index
    'output = 2 kui otsitava sõnas on samas kohas sama täht
    '         1 kui täht on olemas arvatavas sõnas aga mitte samas kohas
    '         0 kui tähte pole arvatavas sõnas
    Private Function wordChecker(ByVal value As String, ByVal index As Integer) Implements IGame.wordChecker
        Dim tulemus As Integer = 0
        Dim i As Integer = 0


        While i < 5

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
        Dim a As Boolean = False
        Dim i As Integer

        If value >= 65 And value <= 90 Or value >= 97 And value <= 122 Or value = 196 Or value = 213 Or value = 214 Or value = 220 Or value = 228 Or value = 245 Or value = 246 Or value = 252 Then
            a = True
        End If

        'Punaste tähtede kontrollimine
        If intRidaSymbol > 1 Then

            For i = 0 To Len(strRedLetters) - 1
                If UCase(Chr(value)) = strRedLetters(i) Then
                    a = False
                End If
            Next
        End If

        Return a
    End Function

    'Funktsioon textboxi nime saamiseks
    'input = rea arv, kasti arv
    'output = Textboxi nimi vastava rea ja kasti arvuga
    Private Function getBoxName(ByVal value1 As Integer, ByVal value2 As Integer) As String Implements IGame.getBoxName

        Dim whichBox As String = "txtRida" & value1.ToString & "Kast" & value2.ToString

        Return whichBox
    End Function

End Class