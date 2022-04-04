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

        Dim pathToGame As String = Application.StartupPath
        Dim fileName As String = "wordleColor.txt"
        Dim fullPath As String = My.Computer.FileSystem.CombinePath(pathToGame, fileName)
        'Kontrolli, kas fail on olemas
        Dim fileFlag As Boolean = checkFile()

        'Kui värvid väärtustamata, proovi saada need failist
        If colors.red = Nothing Or colors.green = Nothing Or colors.blue = Nothing Then

            If fileFlag Then
                'Loe värvid, mis faili salvestatud
                getFileData()

            Else
                'Fail puudub, tee uus fail
                newFile(fullPath)

            End If

        End If
    End Sub

    'Kontrolli, kas fail on olemas
    Private Function checkFile()
        Dim pathToGame As String = Application.StartupPath
        Dim fileName As String = "wordleColor.txt"
        Dim fullPath As String = My.Computer.FileSystem.CombinePath(pathToGame, fileName)

        If My.Computer.FileSystem.FileExists(fullPath) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub getFileData()
        Dim colors As IGraphics
        colors = New CGraphics
        Dim currentColor(3) As UInteger

        'Tekstifaili salvestamise path
        Dim pathToGame As String = Application.StartupPath
        Dim fileName As String = "wordleColor.txt"
        Dim fullPath As String = My.Computer.FileSystem.CombinePath(pathToGame, fileName)
        Dim flag As Boolean

        'Tekstitöötluse
        Dim fileReader As System.IO.StreamReader
        Dim textData(3) As String

        'Loe tekstifailist esimesed 3 rida
        fileReader = My.Computer.FileSystem.OpenTextFileReader(fullPath)

        For row As Integer = 0 To 2 Step 1
            textData(row) = fileReader.ReadLine
        Next
        fileReader.Close()


        For i As Integer = 0 To 2 Step 1

            If IsNumeric(textData(i)) Then
                UInteger.TryParse(textData(i), currentColor(i))
            Else
                'Kui failis olev väärtus on vigane siis väärtusta see 239ks
                currentColor(i) = 239
                textData(i) = 239
                flag = True
            End If

        Next

        'Uuenda faili sisu, kui mingi väärtus oli vale
        If flag Then
            System.IO.File.WriteAllLines(fullPath, textData)
        End If

        colors.red = currentColor(0)
        colors.green = currentColor(1)
        colors.blue = currentColor(2)

    End Sub

    'Loob uue faili,sätestab algväärtusteks "control" värvi ja kirjutab selle RGB väärtused faili
    Private Sub newFile(ByVal fullPath As String)
        Dim colors As IGraphics
        colors = New CGraphics

        'Loo uus fail
        Dim fs = System.IO.File.Create(fullPath)
        fs.Close()

        colors.red = 239
        colors.green = 239
        colors.blue = 239

        'Kirjuta faili
        Dim fileWriter As System.IO.StreamWriter
        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(fullPath, False)

        fileWriter.WriteLine("239", 0)
        fileWriter.WriteLine("239", 1)
        fileWriter.WriteLine("239", 2)

        fileWriter.Close()
    End Sub

End Class
