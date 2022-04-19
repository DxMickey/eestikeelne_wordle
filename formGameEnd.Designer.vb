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
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.UcSonaTahendus1 = New eesti_wordle.UCSonaTahendus()
        Me.lblScoreName = New System.Windows.Forms.Label()
        Me.lblGameScore = New System.Windows.Forms.Label()
        Me.lblBestScoreName = New System.Windows.Forms.Label()
        Me.lblBestScore = New System.Windows.Forms.Label()
        Me.lblNewHighscore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblResult.Location = New System.Drawing.Point(232, 180)
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
        Me.lblSona.Location = New System.Drawing.Point(284, 228)
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
        Me.UcMusicPlayer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 7
        '
        'UcSonaTahendus1
        '
        Me.UcSonaTahendus1.Location = New System.Drawing.Point(118, 405)
        Me.UcSonaTahendus1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcSonaTahendus1.Name = "UcSonaTahendus1"
        Me.UcSonaTahendus1.Size = New System.Drawing.Size(152, 115)
        Me.UcSonaTahendus1.TabIndex = 8
        '
        'lblScoreName
        '
        Me.lblScoreName.AutoSize = True
        Me.lblScoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreName.Location = New System.Drawing.Point(130, 17)
        Me.lblScoreName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScoreName.Name = "lblScoreName"
        Me.lblScoreName.Size = New System.Drawing.Size(102, 36)
        Me.lblScoreName.TabIndex = 7
        Me.lblScoreName.Text = "Skoor:"
        '
        'lblGameScore
        '
        Me.lblGameScore.AutoSize = True
        Me.lblGameScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameScore.Location = New System.Drawing.Point(226, 17)
        Me.lblGameScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGameScore.Name = "lblGameScore"
        Me.lblGameScore.Size = New System.Drawing.Size(32, 36)
        Me.lblGameScore.TabIndex = 8
        Me.lblGameScore.Text = "0"
        '
        'lblBestScoreName
        '
        Me.lblBestScoreName.AutoSize = True
        Me.lblBestScoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestScoreName.Location = New System.Drawing.Point(56, 51)
        Me.lblBestScoreName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBestScoreName.Name = "lblBestScoreName"
        Me.lblBestScoreName.Size = New System.Drawing.Size(181, 36)
        Me.lblBestScoreName.TabIndex = 9
        Me.lblBestScoreName.Text = "Parim skoor:"
        '
        'lblBestScore
        '
        Me.lblBestScore.AutoSize = True
        Me.lblBestScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestScore.Location = New System.Drawing.Point(226, 51)
        Me.lblBestScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBestScore.Name = "lblBestScore"
        Me.lblBestScore.Size = New System.Drawing.Size(32, 36)
        Me.lblBestScore.TabIndex = 10
        Me.lblBestScore.Text = "0"
        '
        'lblNewHighscore
        '
        Me.lblNewHighscore.AutoSize = True
        Me.lblNewHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewHighscore.Location = New System.Drawing.Point(206, 138)
        Me.lblNewHighscore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewHighscore.Name = "lblNewHighscore"
        Me.lblNewHighscore.Size = New System.Drawing.Size(250, 31)
        Me.lblNewHighscore.TabIndex = 11
        Me.lblNewHighscore.Text = "Uus suurim skoor!"
        '
        'formGameEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.UcSonaTahendus1)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.lblNewHighscore)
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
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
    Friend WithEvents UcSonaTahendus1 As UCSonaTahendus
    Friend WithEvents lblScoreName As Label
    Friend WithEvents lblGameScore As Label
    Friend WithEvents lblBestScoreName As Label
    Friend WithEvents lblBestScore As Label
    Friend WithEvents lblNewHighscore As Label
End Class
