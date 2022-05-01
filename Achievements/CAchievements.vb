Public Class CAchievements
    Implements IAchievements

    Private _gamesPlayed = vbNull
    Private _timePlayed = vbNull
    Private _avgGuessTime = vbNull
    Private _wordsGuessed = vbNull
    Private _fastestGuess = vbNull
    Private _slowestGuess = vbNull
    Private _highScore = vbNull
    Private _avgScore = vbNull
    Private _acArray As Integer()
    Private _newAchievement = False
    Private _text = ""
    Private _title = ""

    Public Property newAchievement As Boolean Implements IAchievements.newAchievement
        Get
            Return _newAchievement
        End Get
        Set(value As Boolean)
            _newAchievement = value
        End Set
    End Property

    Public Property text As String Implements IAchievements.text
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    Public Property title As String Implements IAchievements.title
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property




    Public Sub New()
        'Uue klass instantsi puhul võetakse andmekihist statistika
        'Et ei peaks iga achievmenti puhul otsima uuesti välja

        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        Dim gamesPlayed = data.getStat("m2ngude_arv")
        Dim timePlayed = data.getStat("m2ngitud_aeg")
        Dim avgGuessTime = data.getStat("keskmine_arvamise_aeg")
        Dim wordsGuessed = data.getStat("arvatud_s6nade_hulk")
        Dim fastestGuess = data.getStat("k6ige_kiirem_aeg")
        Dim slowestGuess = data.getStat("k6ige_aeglasem_aeg")
        Dim highScore = data.getStat("suurim_skoor")
        Dim avgScore = data.getStat("keskmine_skoor")

        'Andmete töötlus, kui mõni formaat oleks parem (nt int asemel string)
        'pole hetkel midagi muuta aga tulevikuks
        'Muutujate seadmine
        _gamesPlayed = gamesPlayed
        _timePlayed = timePlayed
        _avgGuessTime = avgGuessTime
        _wordsGuessed = wordsGuessed
        _fastestGuess = fastestGuess
        _slowestGuess = slowestGuess
        _highScore = highScore
        _avgScore = avgScore

        Me.newAchievement = False
        _acArray = data.getAchievementArray()

        'Saavutuste kontroll
        checkForWordsGuessedAchievements()
        If Not newAchievement Then
            checkForGamesPlayedAchievements()
        End If
        If Not newAchievement Then
            checkForTimePlayedAchievements()
        End If


    End Sub



    Private Function getGamesPlayed(db As Andmekiht.IDatabase)
        'get games played from db
        Dim data As New DataTable
        data = db.getHistory()
        Dim rows = data.Rows
        Dim n = rows(0).ItemArray
        Return n(0)
    End Function
    Private Sub checkForGamesPlayedAchievements()
        'Kontrollib saavutusi, kus teatud mangude arv vaja saada
        'Valib esimese, seega kui 350 mängu tehtud, aga saavutusi pole, siis tuleb esimesena 10, siis 20 jne
        Dim nrToCheck = {10, 20, 50, 100, 200, 500} 'arvud, kus saavutused
        Dim ids = {1, 2, 3, 4, 5, 6} 'nende saavutuste id-d
        For i = 0 To nrToCheck.Length - 1
            'Kui mangud arv on suurem voi vordne, ja see saavutus pole juba tehtud
            If _gamesPlayed >= nrToCheck(i) And _acArray(i) <= 0 Then
                Dim data As Andmekiht.IDatabase
                data = New Andmekiht.CDatabase
                Dim h = data.getAchievementData(ids(i))
                data.setAchievement(ids(i)) 'pmst i  + 1
                text = h(1)
                title = h(0)
                newAchievement = True
                Exit For
            End If
        Next
    End Sub
    Private Sub checkForTimePlayedAchievements()
        'Kontrollib, mitu tundi mängitud ja kas see on saavutus
        Dim nrToCheck = {1, 10, 30}
        Dim ids = {7, 8, 9}

        For i = 0 To nrToCheck.Length - 1
            Dim hrs = _timePlayed / 3600  'debuggimiseks ei saa andmebaasis aega muuta, niiet tuleb siit muuta.
            If hrs >= nrToCheck(i) And _acArray(ids(i) - 1) <= 0 Then
                Dim data As Andmekiht.IDatabase
                data = New Andmekiht.CDatabase
                Dim h = data.getAchievementData(ids(i))
                data.setAchievement(ids(i))
                text = h(1)
                title = h(0)
                newAchievement = True
                Exit For
            End If
        Next
    End Sub
    Private Sub checkForWordsGuessedAchievements()
        Dim nrToCheck = {1, 5, 10, 20, 50, 100, 200, 300, 400, 500}
        Dim ids = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19}
        For i = 0 To nrToCheck.Length - 1
            Dim hrs = _wordsGuessed  'debuggimiseks ei saa andmebaasis aega muuta, niiet tuleb siit muuta.
            If hrs >= nrToCheck(i) And _acArray(ids(i) - 1) <= 0 Then
                Dim data As Andmekiht.IDatabase
                data = New Andmekiht.CDatabase
                Dim h = data.getAchievementData(ids(i))
                data.setAchievement(ids(i))
                text = h(1)
                title = h(0)
                newAchievement = True
                Exit For
            End If
        Next

    End Sub
    Private Sub resetAchievements()
        'saab nullida kõik saavutused. Kasuta ainult debuggimiseks.
        'tuleb kutsuda peale seda, kui _acArray on väärtuse saanud
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        For i = 1 To _acArray.Length
            data.setAchievement(i, 0)
        Next
    End Sub
End Class
