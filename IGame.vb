Public Interface IGame

    Property strSona As String
    Property intRida As Integer
    Property intKast As Integer
    Property lastLetter As Integer
    Property redLetters As String

    Property redLettersHolder As String

    Property winOrLose As Integer

    Property ArvatudSona As String

    Property kestvus As Integer

    Property gameMode As String

    Property maxKast As Integer

    Function getBoxName(ByVal value1 As Integer, ByVal value2 As Integer) As String

    Function wordChecker(ByVal value As String, ByVal index As Integer)


    Function letterCheck(ByVal value As Integer) As Boolean

    Function gameOver() As Boolean

    Function isLetterInWord(ByVal value As String) As Boolean

    Sub deleteLastKey()


End Interface