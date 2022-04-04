Public Class CTimeLimit
    Implements ITimeLimit

    Public Shared timeLimit As UInteger
    Public Shared timeNew As UInteger

    Public Property TimeToLive As UInteger Implements ITimeLimit.TimeToLive
        Get
            Return timeLimit
        End Get
        Set(value As UInteger)
            timeLimit = value
        End Set
    End Property

    Public Property ITimeLimit_TimeTillNew As UInteger Implements ITimeLimit.TimeTillNew
        Get
            Return timeNew
        End Get
        Set(value As UInteger)
            timeNew = value
        End Set
    End Property
End Class
