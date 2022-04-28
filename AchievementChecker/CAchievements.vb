Public Class CAchievements
    Implements IAchievments

    Public Function getAchievements() As Object Implements IAchievments.getAchievements
        'Otsib andmebaasist eri andmeid eri saavutuste kohta (vt funktsioone)
        'tagastab stringide massiivi, mida saab notificationinga näidata
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim gamesPlayed = data

    End Function

    Public Function setAchievements() As Object Implements IAchievments.setAchievements
        'vaata mis achievmente saadi. Lisa andmebaasi,kui midagi uut
        Throw New NotImplementedException()
    End Function
    Private Function getGamesPlayed(db As Andmekiht.CDatabase)
        Dim nrOfGamesPlayed As Integer
        'get games played from db
        Return nrOfGamesPlayed
    End Function
End Class
