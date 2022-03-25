

Public Class formGame




    'Listen for any keypress
    Private Sub formGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim game As IGame
        game = New CGame

        Dim data As IDatabase
        data = New CDatabase

        'Dim SQLitecnStr As String = "Data Source=MyPath\wordleDB.db; Integrated Security=true"


        'Salvesta vajutatud nupu ascii kood muutujasse lastLetter

        txtDebug.Text = game.strSona

        game.lastLetter = Asc(e.KeyChar)

        If game.lastLetter = 8 And game.intKast <> 0 Then

            stringToControl(game.inputLetter(game.intRida, game.intKast))

            'game.strArvatudSona = "decrease"

            game.intKast = -1

        End If

        'Kui vajutatud nupp On Enter ja viies täht On sisestatud, uuenda värvid
        If game.lastLetter = 13 And game.intKast = 5 Then
            updateColors()

        End If

        If game.letterCheck(game.lastLetter) And game.intKast <> 5 Then
            game.intRida = 1
            game.intKast = 1
            game.strArvatudSona = UCase(Chr(game.lastLetter))
            'Stringi textboxi control-iks muutmine
            stringToControl(game.inputLetter(game.intRida, game.intKast))

            If isLetterInWord(game.strSona) = False Then
                game.lettersHolder = UCase(Chr(game.lastLetter))

            End If
        End If

        'Kui vajutatud nupp on Enter
        If game.lastLetter = 13 Then
            game.intRida = 1
            game.intKast = 1

            'Mängu resettimine ja mängu lõpu ekraanile liikumine
            If game.gameOver() = True Then

                Randomize()
                newWord()
                game.intKast = Nothing
                game.intRida = Nothing
                Dim position = Me.Bounds
                Dim newForm As New formGameEnd
                AddHandler newForm.Load, Sub() newForm.Bounds = position
                newForm.Show()
                Me.Close()
            End If
            txtDebug2.Text = game.lettersHolder
            game.redLetters = game.lettersHolder
            game.lettersHolder = Nothing
            game.strArvatudSona = Nothing

        End If

    End Sub

    Private Sub updateColors()
        Dim game As IGame
        game = New CGame

        Dim i As Integer = 0

        While i < 5
            Dim misVarv As Integer

            misVarv = game.wordChecker(game.strArvatudSona(i), i)
            Dim a As String = game.inputLetter(game.intRida, i + 1)

            If Me.Controls.Find(a, True).Count = 1 Then
                Dim box As TextBox = Me.Controls.Find(a, True)(0)

                If misVarv = 2 And box.BackColor <> Color.Green Then
                    box.BackColor = Color.Green

                ElseIf misVarv = 1 And box.BackColor <> Color.Yellow Then
                    box.BackColor = Color.Yellow
                ElseIf misVarv = 0 Then
                    Dim f As String = box.Text
                    disableKey(f)
                    game.redLetters = game.strArvatudSona(i)

                End If
            End If

            i = i + 1
        End While

    End Sub

    Private Sub disableKey(ByVal value As String)

        Dim a As String = "txt" & value

        If Me.Controls.Find(a, True).Count = 1 Then
            Dim box As TextBox = Me.Controls.Find(a, True)(0)
            If box.BackColor <> Color.Red Then

                box.BackColor = Color.Red
            End If


        End If

    End Sub

    Private Sub formGame_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim game As IGame
        game = New CGame
        Dim data As IDatabase
        data = New CDatabase
        Randomize()
        Me.KeyPreview = True
        newWord()


    End Sub

    Private Sub stringToControl(ByVal value As String)
        Dim game As IGame
        game = New CGame

        'https://stackoverflow.com/questions/47243351/how-to-obtain-a-control-using-its-name-in-visual-basic-net
        If Me.Controls.Find(value, True).Count = 1 Then
            If game.lastLetter = 8 Then
                Dim box As TextBox = Me.Controls.Find(value, True)(0)
                box.Text = ""
            Else
                Dim box As TextBox = Me.Controls.Find(value, True)(0)
                box.Text = UCase(Chr(game.lastLetter))

            End If

        End If
    End Sub

    Private Function isLetterInWord(ByVal value As String) As Boolean
        Dim game As IGame
        game = New CGame
        Dim a As Boolean = False

        For i = 0 To value.Length - 1
            If UCase(Chr(game.lastLetter)) = value(i) Then
                a = True
            End If

        Next
        If game.lettersHolder <> Nothing Then
            For i = 0 To game.lettersHolder.Length - 1
                If UCase(Chr(game.lastLetter)) = game.lettersHolder(i) Then
                    a = True
                End If

            Next
        End If

        Return a

    End Function

    Private Sub newWord()
        Dim game As IGame
        game = New CGame
        Dim data As IDatabase
        data = New CDatabase

        game.strSona = UCase(Data.getSona(Int((3000 * Rnd()) + 1)))
        While game.strSona = Nothing
            game.strSona = UCase(Data.getSona(Int((3000 * Rnd()) + 1)))
        End While
    End Sub


End Class