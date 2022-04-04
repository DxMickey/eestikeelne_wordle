<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelLogIn = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelLogIn
        '
        Me.LabelLogIn.AutoSize = True
        Me.LabelLogIn.Location = New System.Drawing.Point(192, 255)
        Me.LabelLogIn.Name = "LabelLogIn"
        Me.LabelLogIn.Size = New System.Drawing.Size(76, 13)
        Me.LabelLogIn.TabIndex = 0
        Me.LabelLogIn.Text = "Sisesta parool:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(274, 252)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(310, 278)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Logi sisse"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(271, 180)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 3
        '
        'formLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelLogIn)
        Me.Name = "formLogIn"
        Me.Text = "formLogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLogIn As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblError As Label
End Class
