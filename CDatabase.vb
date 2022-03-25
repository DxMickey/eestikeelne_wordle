Public Class CDatabase
    Implements IDatabase

    Private Function getSona(value As Integer) As String Implements IDatabase.getSona
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnect.ConnectionString = "Data Source=C:\wordleDB.db"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM sonadeList WHERE sonaID = " & value
        Dim sqlResponse As String = SQLcommand.ExecuteScalar()
        Return sqlResponse
    End Function
End Class
