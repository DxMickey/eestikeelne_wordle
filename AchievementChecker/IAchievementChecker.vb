Public Interface IAchievementChecker
    Property currentAchievements

    'On uusi achievemente?
    Function areNewAchievements() As Boolean
    'Mitu mängu on mängitud
    Function returnGamesPlayed() As Integer
    'Mitu N pikkust sõna on arvatud
    Function returnNLetterWordsWon(ByRef N As Integer) As Integer
    'Veel mingeid achievemente siia
End Interface
