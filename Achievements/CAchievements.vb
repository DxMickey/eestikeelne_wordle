Public Class CAchievements
    Implements IAchievements

    Public Property TwoHundredGames = False


    Private Property IAchievements_TwoHundredGames1 As Boolean Implements IAchievements.TwoHundredGames
        Get
            Return TwoHundredGames
        End Get
        Set(value As Boolean)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Function getAchievements() As Object Implements IAchievements.getAchievements
        'Otsib andmebaasist eri andmeid eri saavutuste kohta (vt funktsioone)
        'tagastab stringide massiivi, mida saab notificationinga näidata
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim gamesPlayed = Me.getGamesPlayed(data)
        Dim arr = checkForGamesPlayedAchievements(gamesPlayed)
        Return arr
    End Function

    Public Function setAchievements() As Object Implements IAchievements.setAchievements
        'vaata mis achievmente saadi. Lisa andmebaasi,kui midagi uut
        Throw New NotImplementedException()
    End Function
    Private Function getGamesPlayed(db As Andmekiht.IDatabase)
        'get games played from db
        Dim data As New DataTable
        data = db.getHistory()
        Dim rows = data.Rows
        Dim n = rows(0).ItemArray
        Return n(0)
    End Function
    Private Function checkForGamesPlayedAchievements(n) As Array

        Dim achievementArray = {}
        If n > 200 Then
            TwoHundredGames = True
            Return {"Elite Gamer", "Mängisid 200 mängu!"}
        End If
        Return achievementArray
    End Function
End Class
