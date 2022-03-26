Public Interface IDatabase

    Function getSona(ByVal value As Integer) As String

    Function getStat(ByVal value As String) As Integer

    Function getHistory()

    Sub updateStats(value1 As Integer, value2 As Integer, value3 As Integer)










End Interface
