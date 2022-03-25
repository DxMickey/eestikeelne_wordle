Public Class CGame
    Implements IGame

    Shared strSonaSymbol As String
    Shared intRidaSymbol As Integer
    Shared intKastSymbol As Integer
    Shared strArvatudSonaSymbol As String
    Shared intLastLetter As Integer
    Shared strRedLetters As String

    Public Property lastLetter As Integer Implements IGame.lastLetter
        Get
            Return intLastLetter
        End Get
        Set(ByVal value As Integer)
            intLastLetter = value
        End Set
    End Property

    Public Property redLetters As String Implements IGame.redLetters
        Get
            Return strRedLetters
        End Get
        Set(ByVal value As String)
            strRedLetters = strRedLetters & value
        End Set
    End Property

    Private Property strArvatudSona As String Implements IGame.strArvatudSona
        Get
            Return strArvatudSonaSymbol
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                strArvatudSonaSymbol = Nothing
            End If

            If strArvatudSona = Nothing Then
                strArvatudSonaSymbol = value
            ElseIf lastLetter <> 8 Then
                strArvatudSonaSymbol = strArvatudSona & value
            End If
            If value = "decrease" Then
                Dim a As Integer = Len(strArvatudSona)
                Dim i As Integer
                Dim y As String = strArvatudSona
                strArvatudSonaSymbol = Nothing
                For i = 0 To a - 1
                    strArvatudSonaSymbol = strArvatudSona & y(i)
                Next

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
            If intKast = 5 Then
                intRidaSymbol = intRida + value
            End If
            If intRida = 0 Then
                intRidaSymbol = value
            End If
            If value = Nothing Then
                intRidaSymbol = 0
            End If



        End Set
    End Property

    Private Property intKast As Integer Implements IGame.intKast
        Get
            Return intKastSymbol
        End Get
        Set(ByVal value As Integer)
            If intKast = 5 And intLastLetter <> 8 Then
                intKastSymbol = 0
            ElseIf intLastLetter <> 8 Then
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

    Public Function wordChecker(ByVal value As String, ByVal index As Integer) Implements IGame.wordChecker
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

    Public Function inputKeyboard(value As String) As String Implements IGame.inputKeyboard
        Dim whichBox As String = "txt" & value
        Return whichBox
    End Function

    Public Function gameOver() As Boolean Implements IGame.gameOver
        Dim over As Boolean
        If strSona = strArvatudSona Then
            over = True
        End If
        Return over
    End Function

    Public Function letterCheck(value As Integer) As Boolean Implements IGame.letterCheck
        Dim a As Boolean = False
        Dim i As Integer

        If value >= 65 And value <= 90 Or value >= 97 And value <= 122 Or value = 196 Or value = 213 Or value = 214 Or value = 220 Or value = 228 Or value = 245 Or value = 246 Or value = 252 Then
            a = True
        End If

        If intRidaSymbol > 1 Then

            For i = 0 To Len(strRedLetters) - 1
                If UCase(Chr(value)) = strRedLetters(i) Then
                    a = False
                End If
            Next
        End If

        Return a
    End Function

    Private Function inputLetter(ByVal value1 As Integer, ByVal value2 As Integer) As String Implements IGame.inputLetter

        Dim whichBox As String = "txtRida" & value1.ToString & "Kast" & value2.ToString

        Return whichBox
    End Function

End Class