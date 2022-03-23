Public Class formGame

    Private Sub formGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        Dim letter As IGame
        letter = New CGame


        Dim pressedKey As Integer
        pressedKey = Asc(e.KeyChar)

        If pressedKey = 13 And letter.intKast = 5 Then
            updateColors()
        End If




        If letter.intKast <> 5 Or pressedKey = 13 Then


            letter.intRida = 1
            letter.intKast = 1


            Dim a = letter.inputLetter(letter.intRida, letter.intKast)



            If pressedKey >= 65 And pressedKey <= 90 Or pressedKey >= 97 And pressedKey <= 122 Or pressedKey = 132 Or pressedKey = 142 Or pressedKey = 148 Or pressedKey = 153 Or pressedKey = 154 Or pressedKey = 229 Or pressedKey = 228 Or pressedKey = 129 Then
                'https://stackoverflow.com/questions/47243351/how-to-obtain-a-control-using-its-name-in-visual-basic-net
                If Me.Controls.Find(a, True).Count = 1 Then
                    Dim box As TextBox = Me.Controls.Find(a, True)(0)
                    box.Text = UCase(Chr(pressedKey))
                    letter.strArvatudSona = UCase(Chr(pressedKey))
                    'txtDebug2.Text = letter.strArvatudSona

                End If
            End If







        End If






        If pressedKey = 13 Then

            If letter.gameOver() = True Then
                letter.intKast = Nothing
                letter.intRida = Nothing
                Dim position = Me.Bounds
                Dim newForm As New formGameEnd
                AddHandler newForm.Load, Sub() newForm.Bounds = position
                newForm.Show()
                Me.Close()
            End If
            letter.strArvatudSona = Nothing

        End If


    End Sub





    Private Sub updateColors()
        Dim letter As IGame
        letter = New CGame

        Dim i As Integer = 0


        While i < 5
            Dim misVarv As Integer




            misVarv = letter.wordChecker(letter.strArvatudSona(i), i)
            Dim a As String = letter.inputLetter(letter.intRida, i + 1)

            If Me.Controls.Find(a, True).Count = 1 Then
                Dim box As TextBox = Me.Controls.Find(a, True)(0)


                If misVarv = 2 Then
                    box.BackColor = Color.Green



                ElseIf misVarv = 1 Then
                    box.BackColor = Color.Yellow
                ElseIf misVarv = 0 Then
                    Dim f As String = box.Text
                    disableKey(f)
                End If



            End If


            i = i + 1
        End While

    End Sub


    Private Sub disableKey(ByVal value As String)

        Dim a As String = "txt" & value

        If Me.Controls.Find(a, True).Count = 1 Then
            Dim box As TextBox = Me.Controls.Find(a, True)(0)



            box.BackColor = Color.Red






        End If


    End Sub










    Private Sub formGame_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim letter As IGame
        letter = New CGame
        Me.KeyPreview = True
        letter.strSona = (UCase("ämber"))

    End Sub



End Class