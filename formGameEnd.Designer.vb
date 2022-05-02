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
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btbToMenu = New System.Windows.Forms.Button()
        Me.txtTranslation = New System.Windows.Forms.TextBox()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.lblScoreName = New System.Windows.Forms.Label()
        Me.lblGameScore = New System.Windows.Forms.Label()
        Me.lblBestScoreName = New System.Windows.Forms.Label()
        Me.lblBestScore = New System.Windows.Forms.Label()
        Me.lblNewHighscore = New System.Windows.Forms.Label()
        Me.UcSonaTahendus1 = New SonaTahendus.UCSonaTahendus()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblResult.Location = New System.Drawing.Point(210, 248)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(237, 31)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "SÕNA ARVATUD!"
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.btnPlayAgain.Location = New System.Drawing.Point(284, 548)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(110, 53)
        Me.btnPlayAgain.TabIndex = 1
        Me.btnPlayAgain.Text = "Mängi uuesti"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'btbToMenu
        '
        Me.btbToMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.btbToMenu.Location = New System.Drawing.Point(284, 617)
        Me.btbToMenu.Name = "btbToMenu"
        Me.btbToMenu.Size = New System.Drawing.Size(110, 41)
        Me.btbToMenu.TabIndex = 2
        Me.btbToMenu.Text = "Menüüsse"
        Me.btbToMenu.UseVisualStyleBackColor = True
        '
        'txtTranslation
        '
        Me.txtTranslation.Location = New System.Drawing.Point(384, 468)
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Size = New System.Drawing.Size(100, 20)
        Me.txtTranslation.TabIndex = 4
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(303, 466)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(75, 23)
        Me.btnTranslate.TabIndex = 5
        Me.btnTranslate.Text = "Tõlgi"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'cmbLanguage
        '
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Items.AddRange(New Object() {"en", "ru", "fi", "fr", "de", "it", "es"})
        Me.cmbLanguage.Location = New System.Drawing.Point(176, 467)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cmbLanguage.TabIndex = 6
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 7
        '
        'lblScoreName
        '
        Me.lblScoreName.AutoSize = True
        Me.lblScoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreName.Location = New System.Drawing.Point(221, 87)
        Me.lblScoreName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScoreName.Name = "lblScoreName"
        Me.lblScoreName.Size = New System.Drawing.Size(182, 36)
        Me.lblScoreName.TabIndex = 7
        Me.lblScoreName.Text = "Skoor          :"
        '
        'lblGameScore
        '
        Me.lblGameScore.AutoSize = True
        Me.lblGameScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameScore.Location = New System.Drawing.Point(392, 89)
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
        Me.lblBestScoreName.Location = New System.Drawing.Point(222, 123)
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
        Me.lblBestScore.Location = New System.Drawing.Point(392, 123)
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
        Me.lblNewHighscore.Location = New System.Drawing.Point(210, 47)
        Me.lblNewHighscore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewHighscore.Name = "lblNewHighscore"
        Me.lblNewHighscore.Size = New System.Drawing.Size(250, 31)
        Me.lblNewHighscore.TabIndex = 11
        Me.lblNewHighscore.Text = "Uus suurim skoor!"
        '
        'UcSonaTahendus1
        '
        Me.UcSonaTahendus1._backColor = System.Drawing.Color.White
        Me.UcSonaTahendus1._textColor = System.Drawing.Color.Black
        Me.UcSonaTahendus1.Location = New System.Drawing.Point(128, 281)
        Me.UcSonaTahendus1.Margin = New System.Windows.Forms.Padding(2)
        Me.UcSonaTahendus1.Name = "UcSonaTahendus1"
        Me.UcSonaTahendus1.Size = New System.Drawing.Size(407, 156)
        Me.UcSonaTahendus1.TabIndex = 8
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
        Me.Controls.Add(Me.btbToMenu)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "formGameEnd"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btbToMenu As Button
    Friend WithEvents txtTranslation As TextBox
    Friend WithEvents btnTranslate As Button
    Friend WithEvents cmbLanguage As ComboBox
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
    Friend WithEvents UcSonaTahendus1 As SonaTahendus.UCSonaTahendus
    Friend WithEvents lblScoreName As Label
    Friend WithEvents lblGameScore As Label
    Friend WithEvents lblBestScoreName As Label
    Friend WithEvents lblBestScore As Label
    Friend WithEvents lblNewHighscore As Label
End Class
