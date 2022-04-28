Public Interface INotification
    Property timeout As Integer
    Property backColor As Color
    Property textColor As Color
    Sub showNotif(ByRef parentElement As Windows.Forms.Form,
                   ByVal text As String, ByVal title As String,
                   Optional ByVal imgpath As String = "",
                   Optional ByVal timeOut As Integer = 5)

End Interface
