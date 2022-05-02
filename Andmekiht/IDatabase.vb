Public Interface IDatabase

    Function getSona(ByVal value As Integer) As String

    Function getStat(ByVal value As String) As Integer

    Function getHistory()

    Sub insertHistory(value1 As Integer, value2 As Integer, value3 As String, value4 As Integer, value5 As String, value6 As String, value7 As String)

    Function isWordInList(value As String)

    Function howManyWords()

    Function fileCountWords(fileName As String)
    Function listCountWords(listName As String)
    Function getItem(tableName As String, itemName As String) As String
    Function getItemInt(tableName As String, itemName As String) As Integer
    Sub setItem(tableName As String, itemName As String, item As String)
    Sub setItem(tableName As String, itemName As String, item As Integer)
    Sub setItem(tableName As String, itemName As String, item As UInteger)
    Sub importCSV(fileName As String, letters As Integer)
    Sub deleteTable(tableName As String)
    Sub exportJSON(location As String)
    Sub updateWordList(tableName As String)
    Function getAchievementArray() As Integer()
    Sub setAchievement(id As Integer, Optional setBit As Integer = 1)
    Function getAchievementData(ID As Integer)

    Sub exportCSV(delimiter As String, textQualifier As String, append As Boolean, save As Boolean)

End Interface