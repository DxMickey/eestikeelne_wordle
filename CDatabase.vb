Public Class CDatabase
    Implements IDatabase



    'Statistikas mängitud mängude arvu suurendamine
    'input = uus mängitud mängude kogus
    Private Sub updateStats(value1 As Integer, value2 As Integer, value3 As Integer) Implements IDatabase.updateStats
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnect.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand

        SQLcommand.CommandText = "INSERT or REPLACE INTO Statistika VALUES(1, " & value1 & ", " & value2 & ", " & value3 & ")"
        SQLcommand.ExecuteNonQuery()
        SQLconnect.Close()

    End Sub

    'Ajaloo uuendamine history_view viewist
    'output = tabel, kuhu on laetud history_view
    Private Function getHistory() Implements IDatabase.getHistory
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnect.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM history_view"
        Dim SQLite_Data_Reader As SQLite.SQLiteDataReader
        SQLite_Data_Reader = SQLcommand.ExecuteReader

        Dim table As New DataTable
        table.Load(SQLite_Data_Reader)

        SQLconnect.Close()

        Return table
    End Function

    'Mängitud mängude arvu lugemine andmebaasist
    'output = tagastab mängitud mängude arvu
    Private Function getStat(ByVal value As String) As Integer Implements IDatabase.getStat
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnect.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand

        SQLcommand.CommandText = "SELECT " & value & " FROM statistika WHERE ID = 1"
        Dim sqlResponse As String = SQLcommand.ExecuteScalar()
        SQLconnect.Close()
        Return sqlResponse
    End Function

    'Vastava ID-ga sõna tagastamine sõnade listist andmebaasis
    'input = soovitud ID integer
    'output = tagastab vastava ID-ga sõna
    Private Function getSona(value As Integer) As String Implements IDatabase.getSona
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnect.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM sonadeList WHERE sonaID = " & value
        Dim sqlResponse As String = SQLcommand.ExecuteScalar()
        SQLconnect.Close()
        Return sqlResponse
    End Function
End Class
