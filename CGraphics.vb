Public Class CGraphics
    Implements IGraphics

    Shared redValue As UInteger
    Shared greenValue As UInteger
    Shared blueValue As UInteger
    Shared labelColor As Color
    Shared backgroundColor

    Public Property red As UInteger Implements IGraphics.red
        Get
            Return redValue
        End Get
        Set(value As UInteger)
            redValue = value
        End Set
    End Property

    Public Property green As UInteger Implements IGraphics.green
        Get
            Return greenValue
        End Get
        Set(value As UInteger)
            greenValue = value
        End Set
    End Property

    Public Property blue As UInteger Implements IGraphics.blue
        Get
            Return blueValue
        End Get
        Set(value As UInteger)
            blueValue = value
        End Set
    End Property

    Public Property lblColor As Color Implements IGraphics.lblColor
        Get
            Return labelColor
        End Get
        Set(value As Color)
            labelColor = value
        End Set
    End Property

    Public Property backColor As Color Implements IGraphics.backColor
        Get
            Return backgroundColor
        End Get
        Set(value As Color)
            backgroundColor = value
        End Set
    End Property
End Class
