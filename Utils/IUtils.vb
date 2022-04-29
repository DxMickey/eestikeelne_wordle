Public Interface IUtils
    'See komponent on funktsioonide jaoks, mida vaja mitmes kohas
    'Aga mis ei vääri eraldi klassi
    'nt võrgu ühenduse kontroll, aja konversioonid jne

    Function isNetworkConnection() As Boolean
    Function secondsToTimeString(ByVal seconds As Integer, Optional msgString As String = "") As String


End Interface
