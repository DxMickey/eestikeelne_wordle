Public Class CTimeLimit
    Implements ITimeLimit
    'test

    Shared intTimePlay As Integer
    Shared intTimeWait As Integer
    Shared strPassword As String
    Shared strTimeState As String

    Public Property password As String Implements ITimeLimit.password
        Get
            Return strPassword
        End Get
        Set(ByVal value As String)
            strPassword = value
        End Set
    End Property

    Public Property timeState As String Implements ITimeLimit.timeState
        Get
            Return strTimeState
        End Get
        Set(ByVal value As String)
            strTimeState = value
        End Set
    End Property

    Private Property timePlay As Integer Implements ITimeLimit.timePlay
        Get
            Return intTimePlay
        End Get
        Set(ByVal value As Integer)
            intTimePlay = value
        End Set
    End Property

    Private Property timeWait As Integer Implements ITimeLimit.timeWait
        Get
            Return intTimeWait
        End Get
        Set(ByVal value As Integer)
            intTimeWait = value
        End Set
    End Property
End Class
