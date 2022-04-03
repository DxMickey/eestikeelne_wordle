Public Class CDatabase
    Implements IDatabase

    'Mängu andmete lisamine ajaloo tabelisse andmebaasis
    'input = kõik ajaloo tabelis olevad andmete tulbad
    Private Sub insertHistory(value1 As Integer, value2 As String, value3 As Integer, value4 As String, value5 As String, value6 As String) Implements IDatabase.insertHistory
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "INSERT INTO gameHistory VALUES(" & value1 & ",'" & value2 & "', " & value3 & ", '" & value4 & "', '" & value5 & "', " & value6 & ")"
        SQLcommand.ExecuteNonQuery()
        SQLconnection.Close()
    End Sub


    Public Function howManyWords() As Object Implements IDatabase.howManyWords
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand
        Dim game As IGame
        game = New CGame
        Dim millineList As String

        If game.gameMode = "Kerge" Then
            millineList = "sonadeListEasy"
        ElseIf game.gameMode = "Tavaline" Then
            millineList = "sonadeList"
        Else
            millineList = "sonadeListHard"

        End If

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT Count(sonaID) FROM '" & millineList & "'"
        Dim sqlResponse As Integer = SQLcommand.ExecuteScalar()
        SQLconnection.Close()

        Return sqlResponse

    End Function

    Private Function isWordInList(value As String) As Object Implements IDatabase.isWordInList
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand
        Dim game As IGame
        game = New CGame
        Dim millineList As String
        Dim number As Integer = 0

        If game.gameMode = "Kerge" Then
            millineList = "sonadeListEasy"
        ElseIf game.gameMode = "Tavaline" Then
            millineList = "sonadeList"
        Else
            millineList = "sonadeListHard"

        End If

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT sonaID FROM '" & millineList & "' WHERE sona = '" & LCase(value) & "'"
        Dim sqlResponse As Integer = SQLcommand.ExecuteScalar()
        SQLconnection.Close()
        If sqlResponse = 0 Then
            Return 0
        Else
            Return 1
        End If


    End Function


    'Ajaloo uuendamine history_view viewist
    'output = tabel, kuhu on laetud history_view
    Private Function getHistory() Implements IDatabase.getHistory
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM history_view"
        Dim SQLite_Data_Reader As SQLite.SQLiteDataReader
        SQLite_Data_Reader = SQLcommand.ExecuteReader

        Dim tabel As New DataTable
        tabel.Load(SQLite_Data_Reader)

        SQLconnection.Close()

        Return tabel
    End Function

    'Statistika tagastamine andmebaasist
    'input = soovitud stati nimi
    'output = tagastab mängitud mängude arvu
    Private Function getStat(ByVal value As String) As Integer Implements IDatabase.getStat
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT " & value & " FROM statistika"
        Dim sqlResponse As String = SQLcommand.ExecuteScalar()
        SQLconnection.Close()
        Return sqlResponse
    End Function

    'Vastava ID-ga sõna tagastamine sõnade listist andmebaasis
    'input = soovitud ID arv
    'output = tagastab vastava ID-ga sõna
    Private Function getSona(value As Integer) As String Implements IDatabase.getSona
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand
        Dim game As IGame
        game = New CGame
        Dim millineList As String

        If game.gameMode = "Kerge" Then
            millineList = "sonadeListEasy"
        ElseIf game.gameMode = "Tavaline" Then
            millineList = "sonadeList"
        Else
            millineList = "sonadeListHard"

        End If

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM        '" & millineList & "' WHERE sonaID = " & value
        Dim sqlResponse As String = SQLcommand.ExecuteScalar()
        SQLconnection.Close()
        Return sqlResponse
    End Function
End Class