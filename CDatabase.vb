Public Class CDatabase
    Implements IDatabase

    Public Function getHistory() Implements IDatabase.getHistory
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand
        Dim a As String

        SQLconnect.ConnectionString = "Data Source=C:\wordleDB.db"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM history_view"
        Dim SQLite_Data_Reader As SQLite.SQLiteDataReader
        SQLite_Data_Reader = SQLcommand.ExecuteReader

        Dim table As New DataTable
        table.Load(SQLite_Data_Reader)

        Return table
    End Function

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
