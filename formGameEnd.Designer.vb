<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGameEnd
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btbPlayAgain = New System.Windows.Forms.Button()
        Me.btbToMenu = New System.Windows.Forms.Button()
        Me.lblSona = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblResult.Location = New System.Drawing.Point(223, 144)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(192, 25)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "WORD GUESSED!"
        '
        'btbPlayAgain
        '
        Me.btbPlayAgain.Location = New System.Drawing.Point(281, 310)
        Me.btbPlayAgain.Name = "btbPlayAgain"
        Me.btbPlayAgain.Size = New System.Drawing.Size(75, 23)
        Me.btbPlayAgain.TabIndex = 1
        Me.btbPlayAgain.Text = "Mängi uuesti"
        Me.btbPlayAgain.UseVisualStyleBackColor = True
        '
        'btbToMenu
        '
        Me.btbToMenu.Location = New System.Drawing.Point(281, 386)
        Me.btbToMenu.Name = "btbToMenu"
        Me.btbToMenu.Size = New System.Drawing.Size(75, 23)
        Me.btbToMenu.TabIndex = 2
        Me.btbToMenu.Text = "Menüüsse"
        Me.btbToMenu.UseVisualStyleBackColor = True
        '
        'lblSona
        '
        Me.lblSona.AutoSize = True
        Me.lblSona.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.lblSona.Location = New System.Drawing.Point(279, 202)
        Me.lblSona.Name = "lblSona"
        Me.lblSona.Size = New System.Drawing.Size(77, 26)
        Me.lblSona.TabIndex = 3
        Me.lblSona.Text = "Label1"
        '
        'formGameEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.lblSona)
        Me.Controls.Add(Me.btbToMenu)
        Me.Controls.Add(Me.btbPlayAgain)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "formGameEnd"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents btbPlayAgain As Button
    Friend WithEvents btbToMenu As Button
    Friend WithEvents lblSona As Label
End Class
