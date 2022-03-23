Public Class CGame
    Implements IGame

    Shared strSonaSymbol As String
    Shared intRidaSymbol As Integer
    Shared intKastSymbol As Integer
    Shared strArvatudSonaSymbol As String

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
            Else
                strArvatudSonaSymbol = strArvatudSona & value
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
            If intKast = 5 Then
                intKastSymbol = 0
            Else
                intKastSymbol = intKast + value
            End If
            If value = Nothing Then
                intKastSymbol = 0
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

    Private Function inputLetter(ByVal value1 As Integer, ByVal value2 As Integer) As String Implements IGame.inputLetter

        Dim whichBox As String = "txtRida" & value1.ToString & "Kast" & value2.ToString

        Return whichBox
    End Function


End Class
