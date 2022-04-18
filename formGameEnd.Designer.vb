<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGameEnd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btbPlayAgain = New System.Windows.Forms.Button()
        Me.btbToMenu = New System.Windows.Forms.Button()
        Me.lblSona = New System.Windows.Forms.Label()
        Me.txtTranslation = New System.Windows.Forms.TextBox()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.UcMusicPlayer1 = New eesti_wordle.UCMusicPlayer()
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
        Me.btbPlayAgain.Location = New System.Drawing.Point(284, 366)
        Me.btbPlayAgain.Name = "btbPlayAgain"
        Me.btbPlayAgain.Size = New System.Drawing.Size(75, 23)
        Me.btbPlayAgain.TabIndex = 1
        Me.btbPlayAgain.Text = "Mängi uuesti"
        Me.btbPlayAgain.UseVisualStyleBackColor = True
        '
        'btbToMenu
        '
        Me.btbToMenu.Location = New System.Drawing.Point(284, 414)
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
        'txtTranslation
        '
        Me.txtTranslation.Location = New System.Drawing.Point(365, 298)
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Size = New System.Drawing.Size(100, 20)
        Me.txtTranslation.TabIndex = 4
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(284, 296)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(75, 23)
        Me.btnTranslate.TabIndex = 5
        Me.btnTranslate.Text = "Tõlgi"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'cmbLanguage
        '
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Location = New System.Drawing.Point(157, 297)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cmbLanguage.TabIndex = 6
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 7
        '
        'formGameEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.txtTranslation)
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
    Friend WithEvents txtTranslation As TextBox
    Friend WithEvents btnTranslate As Button
    Friend WithEvents cmbLanguage As ComboBox
    Friend WithEvents UcMusicPlayer1 As UCMusicPlayer
End Class
