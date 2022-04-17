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
        Me.txtTranslation = New System.Windows.Forms.TextBox()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.lblScoreName = New System.Windows.Forms.Label()
        Me.lblGameScore = New System.Windows.Forms.Label()
        Me.lblBestScoreName = New System.Windows.Forms.Label()
        Me.lblBestScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblResult.Location = New System.Drawing.Point(297, 177)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(236, 30)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "WORD GUESSED!"
        '
        'btbPlayAgain
        '
        Me.btbPlayAgain.Location = New System.Drawing.Point(379, 450)
        Me.btbPlayAgain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btbPlayAgain.Name = "btbPlayAgain"
        Me.btbPlayAgain.Size = New System.Drawing.Size(100, 28)
        Me.btbPlayAgain.TabIndex = 1
        Me.btbPlayAgain.Text = "Mängi uuesti"
        Me.btbPlayAgain.UseVisualStyleBackColor = True
        '
        'btbToMenu
        '
        Me.btbToMenu.Location = New System.Drawing.Point(379, 510)
        Me.btbToMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btbToMenu.Name = "btbToMenu"
        Me.btbToMenu.Size = New System.Drawing.Size(100, 28)
        Me.btbToMenu.TabIndex = 2
        Me.btbToMenu.Text = "Menüüsse"
        Me.btbToMenu.UseVisualStyleBackColor = True
        '
        'lblSona
        '
        Me.lblSona.AutoSize = True
        Me.lblSona.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.lblSona.Location = New System.Drawing.Point(372, 249)
        Me.lblSona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSona.Name = "lblSona"
        Me.lblSona.Size = New System.Drawing.Size(101, 32)
        Me.lblSona.TabIndex = 3
        Me.lblSona.Text = "Label1"
        '
        'txtTranslation
        '
        Me.txtTranslation.Location = New System.Drawing.Point(487, 367)
        Me.txtTranslation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Size = New System.Drawing.Size(132, 22)
        Me.txtTranslation.TabIndex = 4
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(379, 364)
        Me.btnTranslate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(100, 28)
        Me.btnTranslate.TabIndex = 5
        Me.btnTranslate.Text = "Tõlgi"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'cmbLanguage
        '
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Location = New System.Drawing.Point(209, 366)
        Me.cmbLanguage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(160, 24)
        Me.cmbLanguage.TabIndex = 6
        '
        'lblScoreName
        '
        Me.lblScoreName.AutoSize = True
        Me.lblScoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreName.Location = New System.Drawing.Point(335, 45)
        Me.lblScoreName.Name = "lblScoreName"
        Me.lblScoreName.Size = New System.Drawing.Size(126, 42)
        Me.lblScoreName.TabIndex = 7
        Me.lblScoreName.Text = "Skoor:"
        '
        'lblGameScore
        '
        Me.lblGameScore.AutoSize = True
        Me.lblGameScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameScore.Location = New System.Drawing.Point(463, 45)
        Me.lblGameScore.Name = "lblGameScore"
        Me.lblGameScore.Size = New System.Drawing.Size(39, 42)
        Me.lblGameScore.TabIndex = 8
        Me.lblGameScore.Text = "0"
        '
        'lblBestScoreName
        '
        Me.lblBestScoreName.AutoSize = True
        Me.lblBestScoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestScoreName.Location = New System.Drawing.Point(235, 87)
        Me.lblBestScoreName.Name = "lblBestScoreName"
        Me.lblBestScoreName.Size = New System.Drawing.Size(226, 42)
        Me.lblBestScoreName.TabIndex = 9
        Me.lblBestScoreName.Text = "Parim skoor:"
        '
        'lblBestScore
        '
        Me.lblBestScore.AutoSize = True
        Me.lblBestScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestScore.Location = New System.Drawing.Point(463, 87)
        Me.lblBestScore.Name = "lblBestScore"
        Me.lblBestScore.Size = New System.Drawing.Size(39, 42)
        Me.lblBestScore.TabIndex = 10
        Me.lblBestScore.Text = "0"
        '
        'formGameEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 937)
        Me.Controls.Add(Me.lblBestScore)
        Me.Controls.Add(Me.lblBestScoreName)
        Me.Controls.Add(Me.lblGameScore)
        Me.Controls.Add(Me.lblScoreName)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.txtTranslation)
        Me.Controls.Add(Me.lblSona)
        Me.Controls.Add(Me.btbToMenu)
        Me.Controls.Add(Me.btbPlayAgain)
        Me.Controls.Add(Me.lblResult)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents lblScoreName As Label
    Friend WithEvents lblGameScore As Label
    Friend WithEvents lblBestScoreName As Label
    Friend WithEvents lblBestScore As Label
End Class
