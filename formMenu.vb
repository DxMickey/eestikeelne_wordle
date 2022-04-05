Imports System.Net

Public Class formMenu
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim game As IGame
        game = New CGame

        game.kasPiiramatu = True

        Dim newForm As New formGameSettings
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim newForm As New formHistory
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Dim newForm As New formStatistika
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


        newForm.Show()
        Me.Close()
    End Sub


    Private Sub btnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        Dim game As IGame
        game = New CGame

        game.kasPiiramatu = False
        'Väärtuste taastamine algseadetele
        game.kasTimed = False
        game.gameMode = "Tavaline"
        game.maxKast = 5

        Dim newForm As New formGame
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


        newForm.Show()
        Me.Close()
    End Sub


    Private Sub btnGraphics_Click(sender As Object, e As EventArgs) Handles btnGraphics.Click
        Dim newForm As New formGraphics
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


        newForm.Show()
        Me.Close()
    End Sub

    'Menüü laadides sea taustavärv
    Private Sub formMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colors As IGraphics
        colors = New CGraphics

        getColor()
        Me.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)
    End Sub


    'Saab sätestatud taustavärvi RGB
    Private Sub getColor()
        Dim colors As IGraphics
        colors = New CGraphics
        Dim data As IDatabase
        data = New CDatabase


        'Kui värvid väärtustamata, proovi saada need failist
        If colors.red = Nothing Or colors.green = Nothing Or colors.blue = Nothing Then

            colors.red = data.getItemInt("miscData", "red")
            colors.green = data.getItemInt("miscData", "green")
            colors.blue = data.getItemInt("miscData", "blue")
        End If
    End Sub

    Private Sub btnWordList_Click(sender As Object, e As EventArgs) Handles btnWordList.Click
        Dim newForm As New formWordList
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = Color.FromArgb(255, colors.red, colors.green, colors.blue)


        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim data As IDatabase
        data = New CDatabase

        Dim client As New WebClient
        Dim saveFile As New SaveFileDialog
        Dim fileUrl1 As String = "https://docs.google.com/uc?export=download&id=1BEwFvCp8TXU1tqlo9cJccKilIWvg_lTM"
        Dim fileUrl2 As String = "https://docs.google.com/uc?export=download&id=1tpY8m6-sEzLla8l160oSGyFPvlkCJQFm"
        Dim fileUrl3 As String = "https://docs.google.com/uc?export=download&id=1dR14DNVom_LtZkZAyNmrIDb9XdwO6RPy"
        MessageBox.Show("Uuenduse kontrollimine võib võtta mõne hetke!")

        client.DownloadFile(New Uri(fileUrl1), "sonadeListEasy.csv")
        client.DownloadFile(New Uri(fileUrl2), "sonadeList.csv")
        client.DownloadFile(New Uri(fileUrl3), "sonadeListHard.csv")


        'txtDebug.Text = data.listCountWords("sonadeListHard")

        If data.fileCountWords("sonadeListEasy.csv") <> data.listCountWords("sonadeListEasy") Or data.fileCountWords("sonadeList.csv") <> data.listCountWords("sonadeList") Or data.fileCountWords("sonadeListHard.csv") <> data.listCountWords("sonadeListHard") Then
            MsgBox("Uuendus on olemas. Kas te soovite uuendada sõnu?", MsgBoxStyle.YesNo, "Uuendus")
            If MsgBoxResult.Yes Then
                If data.fileCountWords("sonadeListEasy.csv") <> data.listCountWords("sonadeListEasy") Then
                    data.updateWordList("sonadeListEasy")
                End If
                If data.fileCountWords("sonadeList.csv") <> data.listCountWords("sonadeList") Then
                    data.updateWordList("sonadeList")
                End If
                If data.fileCountWords("sonadeListHard.csv") <> data.listCountWords("sonadeListHard") Then
                    data.updateWordList("sonadeListHard")
                End If
            Else

            End If
        Else
            MessageBox.Show("Uuendust ei ole!")

        End If


        My.Computer.FileSystem.DeleteFile(Application.StartupPath() & "\sonadeListEasy.csv")
        My.Computer.FileSystem.DeleteFile(Application.StartupPath() & "\sonadeList.csv")
        My.Computer.FileSystem.DeleteFile(Application.StartupPath() & "\sonadeListHard.csv")
    End Sub
End Class
