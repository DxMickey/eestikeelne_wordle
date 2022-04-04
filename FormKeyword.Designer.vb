<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeyword
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
        Me.TextBoxPassword1 = New System.Windows.Forms.TextBox()
        Me.LabelPassword1 = New System.Windows.Forms.Label()
        Me.LabelPassword2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword2 = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxPassword1
        '
        Me.TextBoxPassword1.Location = New System.Drawing.Point(336, 209)
        Me.TextBoxPassword1.Name = "TextBoxPassword1"
        Me.TextBoxPassword1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPassword1.TabIndex = 0
        Me.TextBoxPassword1.UseSystemPasswordChar = True
        '
        'LabelPassword1
        '
        Me.LabelPassword1.AutoSize = True
        Me.LabelPassword1.Location = New System.Drawing.Point(139, 216)
        Me.LabelPassword1.Name = "LabelPassword1"
        Me.LabelPassword1.Size = New System.Drawing.Size(175, 13)
        Me.LabelPassword1.TabIndex = 1
        Me.LabelPassword1.Text = "Seadista parool (max 12 tähemärki):"
        '
        'LabelPassword2
        '
        Me.LabelPassword2.AutoSize = True
        Me.LabelPassword2.Location = New System.Drawing.Point(139, 268)
        Me.LabelPassword2.Name = "LabelPassword2"
        Me.LabelPassword2.Size = New System.Drawing.Size(74, 13)
        Me.LabelPassword2.TabIndex = 2
        Me.LabelPassword2.Text = "Kinnita parool:"
        '
        'TextBoxPassword2
        '
        Me.TextBoxPassword2.Location = New System.Drawing.Point(336, 268)
        Me.TextBoxPassword2.Name = "TextBoxPassword2"
        Me.TextBoxPassword2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPassword2.TabIndex = 3
        Me.TextBoxPassword2.UseSystemPasswordChar = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(336, 341)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Kinnita"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(142, 341)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 5
        '
        'FormKeyword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.TextBoxPassword2)
        Me.Controls.Add(Me.LabelPassword2)
        Me.Controls.Add(Me.LabelPassword1)
        Me.Controls.Add(Me.TextBoxPassword1)
        Me.Name = "FormKeyword"
        Me.Text = "FormKeyword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPassword1 As TextBox
    Friend WithEvents LabelPassword1 As Label
    Friend WithEvents LabelPassword2 As Label
    Friend WithEvents TextBoxPassword2 As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblError As Label
End Class
