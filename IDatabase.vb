Public Interface IDatabase

    Function getSona(ByVal value As Integer) As String

    Function getStat(ByVal value As String) As Integer

    Function getHistory()

    Sub insertHistory(value1 As Integer, value2 As String, value3 As Integer, value4 As String, value5 As String, value6 As String)

    Function isWordInList(value As String)

    Function howManyWords()

    Function getItem(tableName As String, itemName As String) As String
    Function getItemInt(tableName As String, itemName As String) As Integer
    Sub setItem(tableName As String, itemName As String, item As String)
    Sub setItem(tableName As String, itemName As String, item As Integer)
    Sub setItem(tableName As String, itemName As String, item As UInteger)
    Sub importCSV(fileName As String)
    Sub deleteTable(tableName As String)
    Function fileCountWords(fileName As String)

    Function listCountWords(listName As String)

    Sub updateWordList(tableName As String)










End Interface
