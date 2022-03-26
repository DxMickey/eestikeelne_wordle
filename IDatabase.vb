Public Interface IDatabase

    Function getSona(ByVal value As Integer) As String

    Function getGamesCount() As Integer

    Function getHistory()

    Sub updateGamesCount(ByVal value As Integer)



End Interface
