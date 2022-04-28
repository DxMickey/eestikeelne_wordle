
Public Class CNotification
    Implements INotification

    Private _timeout = 5
    Private _text As String
    Private _title As String
    Private _imagepath As String
    Private _width As Integer
    Private _height As Integer
    Private _size As Size
    Private _backColor = Color.Transparent
    Private _textColor = Color.Black

    Public Property timeout As Integer Implements INotification.timeout
        Get
            Return _timeout
        End Get
        Set(value As Integer)
            _timeout = value
        End Set
    End Property

    Public Property backColor As Color Implements INotification.backColor
        Get
            Return _backColor
        End Get
        Set(value As Color)
            _backColor = value
        End Set
    End Property

    Public Property textColor As Color Implements INotification.textColor
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
        End Set
    End Property



    Private Sub INotification_showNotif(ByRef parentElement As Form, text As String, title As String, Optional imgpath As String = "", Optional timeOut As Integer = 3) Implements INotification.showNotif
        _text = text
        _title = title
        _imagepath = imgpath
        _width = parentElement.Size.Width
        _height = 60
        _size.Width = _width + 20
        _size.Height = _height
        Dim textBoxWidthPercentage = 0.8 '80% of the width of the window
        Dim tbSize As New Size
        tbSize.Width = _size.Width * textBoxWidthPercentage
        tbSize.Height = _size.Height

        Dim n As New UCNotification
        'n.BackColor = Color.FromArgb(255)
        n.Size = _size
        n.RichTextBox1.Text = Me._text
        n.RichTextBox1.Size = tbSize
        n.lblTitle.Text = Me._title
        n.Location = New System.Drawing.Point(0, 0)
        n.timeOut = timeOut

        n.btnClose.Location = New System.Drawing.Point(_width - 45, 3)

        n.BackColor = _backColor
        n.ForeColor = _textColor

        n.Timer1.Start()

        parentElement.Controls.Add(n)
    End Sub
End Class
