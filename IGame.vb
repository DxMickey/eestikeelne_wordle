Public Interface IGame
    Property strSona As String
    Property intRida As Integer
    Property intKast As Integer
    Property lastLetter As Integer
    Property redLetters As String

    Property lettersHolder As String

    Property winOrLose As Integer







    Property strArvatudSona As String

    Function inputLetter(ByVal value1 As Integer, ByVal value2 As Integer) As String


    Function wordChecker(ByVal value As String, ByVal index As Integer)

    Function inputKeyboard(ByVal value As String) As String

    Function letterCheck(ByVal value As Integer) As Boolean

    Function gameOver() As Boolean
















End Interface
