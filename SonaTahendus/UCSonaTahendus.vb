Public Class UCSonaTahendus
    Property _textColor As System.Drawing.Color = MyBase.ForeColor 'System.Drawing.Color.Black
    Property _backColor As System.Drawing.Color = MyBase.BackColor 'System.Drawing.Color.White

    Public Sub setWordTexts(sona, tahendus)
        lblSona.ForeColor = _textColor
        TextBox1.ForeColor = _textColor
        TextBox1.BackColor = _backColor
        lblSona.Text = sona
        TextBox1.Text = tahendus
    End Sub


End Class
