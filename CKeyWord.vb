Public Class CKeyWord
    Implements IKeyWord

    Public Shared keypass As String
    Public Property keyword As String Implements IKeyWord.keyword
        Get
            Return keypass
        End Get
        Set(value As String)
            keypass = value
        End Set
    End Property
End Class
