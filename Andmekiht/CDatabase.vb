Imports System.IO
Imports Newtonsoft.Json
Imports System.Windows.Forms

Public Class CDatabase
    Implements IDatabase

    'Mängu andmete lisamine ajaloo tabelisse andmebaasis
    'input = kõik ajaloo tabelis olevad andmete tulbad
    Private Sub insertHistory(value1 As Integer, value2 As String, value3 As Integer, value4 As String, value5 As String, value6 As String, value7 As Integer) Implements IDatabase.insertHistory


        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "INSERT INTO gameHistory VALUES(" & value1 & ",'" & value2 & "', " & value3 & ", '" & value4 & "', '" & value5 & "', " & value6 & ", " & value7 & ")"
        SQLcommand.ExecuteNonQuery()
        SQLconnection.Close()

    End Sub

    'Funktsioon kontrollimaks mitu sõna on mängulaadi jaoks valitud sõnade listis
    'Output = Sõnade arv game.gameMode-is aktiivse raskusastme järgi ning kui kasutaja sõnade enda list aktiveeritud siis selle sõnade arv listis
    Private Function howManyWords() As Object Implements IDatabase.howManyWords
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand
        Dim game As Game.IGame
        game = New Game.CGame
        Dim millineList As String

        If game.gameMode = "Kerge" Then
            If getItem("miscData", "customListState") = "On" And getItem("miscData", "customEasy") <> "none" Then
                millineList = getItem("miscData", "customEasy")
            Else
                millineList = "sonadeListEasy"
            End If

        ElseIf game.gameMode = "Tavaline" Then
            If getItem("miscData", "customListState") = "On" And getItem("miscData", "customNormal") <> "none" Then
                millineList = getItem("miscData", "customNormal")
            Else
                millineList = "sonadeList"
            End If
        Else
            If getItem("miscData", "customListState") = "On" And getItem("miscData", "customHard") <> "none" Then
                millineList = getItem("miscData", "customHard")
            Else
                millineList = "sonadeListHard"
            End If

        End If

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "Select Count(rowid) FROM '" & millineList & "'"
        Dim sqlResponse As Integer = SQLcommand.ExecuteScalar()
        SQLconnection.Close()

        Return sqlResponse

    End Function

    'Stringi sisestamine andmebaasi soovitud tabelisse
    'Input = soovitud tabeli nimi andmebaasis kuhu sisestatakse, väärtuse nimi tabelis, uus väärtus)
    Private Sub setItem(ByVal tableName As String, ByVal itemName As String, ByVal item As String) Implements IDatabase.setItem
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "UPDATE " & tableName & " SET " & itemName & " = '" & item & "'"
        SQLcommand.ExecuteNonQuery()
        SQLconnection.Close()
    End Sub

    'Integeri sisestamine andmebaasi soovitud tabelisse
    'Input = soovitud tabeli nimi andmebaasis kuhu sisestatakse, väärtuse nimi tabelis, uus väärtus)
    Private Sub setItem(ByVal tableName As String, ByVal itemName As String, ByVal item As Integer) Implements IDatabase.setItem
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "UPDATE " & tableName & " SET " & itemName & " = " & item & ""
        SQLcommand.ExecuteNonQuery()
        SQLconnection.Close()
    End Sub

    'Unsigned integeri sisestamine andmebaasi soovitud tabelisse
    'Input = soovitud tabeli nimi andmebaasis kuhu sisestatakse, väärtuse nimi tabelis, uus väärtus)
    Private Sub setItem(tableName As String, itemName As String, item As UInteger) Implements IDatabase.setItem
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "UPDATE " & tableName & " SET " & itemName & " = " & item & ""
        SQLcommand.ExecuteNonQuery()
        SQLconnection.Close()
    End Sub

    'Integeri tagastamine andmebaasist
    'Input = Tabeli nimi kust soovitakse tagastada ja väärtuse nimi mida soovitakse
    'Output = Integer väärtus mida soovitakse
    Private Function getItemInt(tableName As String, itemName As String) As Integer Implements IDatabase.getItemInt
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "Select " & itemName & " FROM " & tableName
        Dim sqlResponse As Integer = SQLcommand.ExecuteScalar()
        SQLconnection.Close()
        Return sqlResponse
    End Function

    'Stringi tagastamine andmebaasist
    'Input = Tabeli nimi kust soovitakse tagastada ja väärtuse nimi mida soovitakse
    'Output = String väärtus mida soovitakse
    Private Function getItem(tableName As String, itemName As String) As String Implements IDatabase.getItem
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "Select " & itemName & " FROM " & tableName
        Dim sqlResponse As String = SQLcommand.ExecuteScalar()
        SQLconnection.Close()
        Return sqlResponse
    End Function

    'Funktsioon, mis kontrollib, kas sõna mis funktsiooni antakse on olemas sõnade listis
    'Input = kasutaja poolt sisestatud sõna
    'Output = 1 kui sõna on olemas, 0 kui sõna ei ole olemas
    Private Function isWordInList(value As String) As Object Implements IDatabase.isWordInList
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand
        Dim game As Game.IGame
        game = New Game.CGame
        Dim millineList As String
        Dim number As Integer = 0

        If game.gameMode = "Kerge" Then
            If getItem("miscData", "customListState") = "on" And getItem("miscData", "customEasy") <> "none" Then
                millineList = getItem("miscData", "customEasy")
            Else
                millineList = "sonadeListEasy"
            End If

        ElseIf game.gameMode = "Tavaline" Then
            If getItem("miscData", "customListState") = "on" And getItem("miscData", "customNormal") <> "none" Then
                millineList = getItem("miscData", "customNormal")
            Else
                millineList = "sonadeList"
            End If
        Else
            If getItem("miscData", "customListState") = "on" And getItem("miscData", "customHard") <> "none" Then
                millineList = getItem("miscData", "customHard")
            Else
                millineList = "sonadeListHard"
            End If

        End If

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "Select rowid FROM '" & millineList & "' WHERE sona = '" & LCase(value) & "'"
        Dim sqlResponse As Integer = SQLcommand.ExecuteScalar()
        SQLconnection.Close()
        If sqlResponse = 0 Then
            Return 0
        Else
            Return 1
        End If


    End Function


    'Ajaloo uuendamine gameHistory viewist
    'output = tabel, kuhu on laetud gameHistory
    Private Function getHistory() Implements IDatabase.getHistory
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM gameHistory ORDER BY mitmesMäng DESC"
        Dim SQLite_Data_Reader As SQLite.SQLiteDataReader
        SQLite_Data_Reader = SQLcommand.ExecuteReader

        Dim tabel As New DataTable
        tabel.Load(SQLite_Data_Reader)

        SQLconnection.Close()

        Return tabel
    End Function
    Private Function Transpose(ByVal table As DataTable) As DataTable
        Dim flippedTable As New DataTable
        'creates as many columns as rows in source table
        flippedTable.Columns.AddRange(
        table.Select.Select(
            Function(dr) New DataColumn("col" & table.Rows.IndexOf(dr), GetType(Object))
            ).ToArray)
        'iterates columns in source table
        For Each dc As DataColumn In table.Columns
            'get array of values of column in each row and add as new row in target table
            flippedTable.Rows.Add(table.Select.Select(Function(dr) dr(dc)).ToArray)
        Next
        Return flippedTable
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
        Dim game As Game.IGame
        game = New Game.CGame
        Dim millineList As String

        If game.gameMode = "Kerge" Then
            If getItem("miscData", "customListState") = "on" And getItem("miscData", "customEasy") <> "none" Then
                millineList = getItem("miscData", "customEasy")
            Else
                millineList = "sonadeListEasy"
            End If

        ElseIf game.gameMode = "Tavaline" Then
            If getItem("miscData", "customListState") = "on" And getItem("miscData", "customNormal") <> "none" Then
                millineList = getItem("miscData", "customNormal")
            Else
                millineList = "sonadeList"
            End If
        Else
            If getItem("miscData", "customListState") = "on" And getItem("miscData", "customHard") <> "none" Then
                millineList = getItem("miscData", "customHard")
            Else
                millineList = "sonadeListHard"
            End If

        End If

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM        '" & millineList & "' WHERE rowid = " & value
        Dim sqlResponse As String = SQLcommand.ExecuteScalar()
        SQLconnection.Close()
        Return sqlResponse
    End Function

    'CSV failist kasutaja enda sõnade laadimine andmebaasi, sõnade fail peab olema mängu .exe-ga samas kaustas.
    'Input = kasutaja sisestatud failinimi
    Private Sub importCSV(fileName As String, letters As Integer) Implements IDatabase.importCSV
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        Dim fileNameCSV As String = fileName & ".csv"

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "DROP TABLE IF EXISTS '" & fileName & "'"
        SQLcommand.ExecuteNonQuery()

        SQLcommand.CommandText = "CREATE TABLE '" & fileName & "'(sona STRING)"
        SQLcommand.ExecuteNonQuery()

        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(fileNameCSV)
        Dim line As String
        Do
            line = reader.ReadLine

            If line <> Nothing Then

                If line.Length = letters Then
                    SQLcommand.CommandText = "INSERT INTO '" & fileName & "' VALUES('" & line & "')"
                    SQLcommand.ExecuteNonQuery()
                End If
            End If


        Loop Until line Is Nothing

        SQLconnection.Close()
    End Sub

    'Soovitud tabeli kustutamine andmebaasist
    'Input = Tabeli nimi, mida soovitakse kustutada.
    Private Sub deleteTable(tableName As String) Implements IDatabase.deleteTable
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "DROP TABLE IF EXISTS '" & tableName & "'"
        SQLcommand.ExecuteNonQuery()

        SQLconnection.Close()
    End Sub

    ' formHistory on nupp 'Ekspordi JSON', mida see funktsioon siis teeb
    ' kood on suurem osa kopeeritud funktsioonist getHistory
    ' ainult l6pus muudetud mida tabeliga tehakse
    Private Sub exportJSON() Implements IDatabase.exportJSON
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT * FROM gameHistory"
        Dim SQLite_Data_Reader As SQLite.SQLiteDataReader
        SQLite_Data_Reader = SQLcommand.ExecuteReader

        Dim tabel As New DataTable
        '' uus osa
        tabel.Load(SQLite_Data_Reader)
        Dim JSONtabel = JsonConvert.SerializeObject(tabel, Formatting.Indented)

        If (My.Computer.FileSystem.FileExists(Application.StartupPath() & "\export.json")) Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath() & "\export.json")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath() & "\export.json", JSONtabel, True)
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath() & "\export.json", JSONtabel, True)
        End If
        SQLconnection.Close()
    End Sub

    Public Function getAchievementArray() As Integer() Implements IDatabase.getAchievementArray
        'Tagastab massiivi, kujul {0,0,0,1,0...},
        'kus indeks näitab saavutuse ID-d ja väärtus seda, kas tehtud
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()
        SQLcommand = SQLconnection.CreateCommand
        SQLcommand.CommandText = "SELECT isDone FROM achievements ORDER BY ID ASC"
        Dim queryRes As SQLite.SQLiteDataReader
        queryRes = SQLcommand.ExecuteReader
        Dim tabel As New DataTable
        tabel.Load(queryRes)

        Dim N = tabel.Rows.Count - 1
        Dim acArray(N) As Integer

        For i = 0 To N
            Dim el As Integer
            el = tabel.Rows(i).ItemArray(0)
            acArray(i) = el
        Next

        SQLconnection.Close()
        Return acArray

    End Function

    Public Sub setAchievement(id As Integer, Optional setBit As Integer = 1) Implements IDatabase.setAchievement
        'Märgib id väärtuse järgi achievementi tehtuks. Optionaalse väärtusega saab ka nulliks märkida, kui vaja.
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "UPDATE achievements SET isDone = " & setBit & " WHERE ID = " & id
        Dim SQLite_Data_Reader As SQLite.SQLiteDataReader
        SQLite_Data_Reader = SQLcommand.ExecuteReader
        SQLconnection.Close()

    End Sub
    Private Function getAchievementData(ID As Integer) Implements IDatabase.getAchievementData
        'Tagastab saavutuse id järgi kujul {title, text}
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

    'Funktsioon sõnade arvu saamiseks soovitud sõnade listis
    'Input = Listi nimi mille sõnade arvu soovitakse
    'Output = Sõnade arv
    Private Function listCountWords(listName As String) As Object Implements IDatabase.listCountWords
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand


        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "SELECT Count(rowid) FROM '" & listName & "'"
        Dim sqlResponse As Integer = SQLcommand.ExecuteScalar()
        SQLconnection.Close()

        Return sqlResponse
    End Function
        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

    'Funktsioon sõnade arvu saamiseks soovitud failis
    'Input = Faili nimi mille sõnade arvu soovitakse
    'Output = Sõnade arv
    Private Function fileCountWords(fileName As String) As Object Implements IDatabase.fileCountWords
        Dim count As Integer = 0

        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(fileName)
        Dim line As String
        Do
            line = reader.ReadLine

            count = count + 1

        Loop Until line Is Nothing
        reader.Close()
        SQLcommand = SQLconnection.CreateCommand

        Return count
    End Function

    'Meetod sõnade listi uuendamiseks andmebaasis, asendades kõik vanad sõnad uute vastu vastavas tabelis
    'Input = Tabeli nimi, milles soovitakse sõnu uuendada
    Private Sub updateWordList(tableName As String) Implements IDatabase.updateWordList
        Dim SQLconnection As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand

        SQLconnection.ConnectionString = "Data Source=" & Application.StartupPath() & "\wordleDB.db"
        SQLconnection.Open()

        SQLcommand = SQLconnection.CreateCommand

        SQLcommand.CommandText = "DROP TABLE IF EXISTS '" & tableName & "'"
        SQLcommand.ExecuteNonQuery()

        SQLcommand.CommandText = "CREATE TABLE '" & tableName & "'(sona STRING)"
        SQLcommand.ExecuteNonQuery()

        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(tableName & ".csv")
        Dim line As String
        Do
            line = reader.ReadLine

            SQLcommand.CommandText = "INSERT INTO '" & tableName & "' VALUES('" & line & "')"
            SQLcommand.ExecuteNonQuery()

        Loop Until line Is Nothing
        reader.Close()

        SQLconnection.Close()
    End Sub
End Class
SQLcommand.CommandText = "SELECT  title,text FROM achievements WHERE ID = " & ID
Dim queryRes As SQLite.SQLiteDataReader
queryRes = SQLcommand.ExecuteReader
'pain
Dim tabel As New DataTable
tabel.Load(queryRes)
Dim title = tabel.Rows(0).ItemArray(0)
Dim text = tabel.Rows(0).ItemArray(1)
Dim h = {title, text}
SQLconnection.Close()
Return h
End Function
End Class