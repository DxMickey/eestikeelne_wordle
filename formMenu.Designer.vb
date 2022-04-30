<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.btnGraphics = New System.Windows.Forms.Button()
        Me.btnTimeLimit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnWordList = New System.Windows.Forms.Button()
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(352, 251)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Piiramatu"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(292, 372)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnHistory.TabIndex = 1
        Me.btnHistory.Text = "Ajalugu"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(292, 331)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(75, 23)
        Me.btnStats.TabIndex = 2
        Me.btnStats.Text = "Statistika"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 40.75!)
        Me.Label1.Location = New System.Drawing.Point(36, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(609, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eestikeelne Wordle"
        '
        'btnClassic
        '
        Me.btnClassic.Location = New System.Drawing.Point(232, 251)
        Me.btnClassic.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Size = New System.Drawing.Size(75, 23)
        Me.btnClassic.TabIndex = 4
        Me.btnClassic.Text = "Klassikaline"
        Me.btnClassic.UseVisualStyleBackColor = True
        '
        'btnGraphics
        '
        Me.btnGraphics.Location = New System.Drawing.Point(292, 290)
        Me.btnGraphics.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGraphics.Name = "btnGraphics"
        Me.btnGraphics.Size = New System.Drawing.Size(75, 23)
        Me.btnGraphics.TabIndex = 4
        Me.btnGraphics.Text = "Kujundus"
        Me.btnGraphics.UseVisualStyleBackColor = True
        '
        'btnTimeLimit
        '
        Me.btnTimeLimit.Location = New System.Drawing.Point(292, 430)
        Me.btnTimeLimit.Name = "btnTimeLimit"
        Me.btnTimeLimit.Size = New System.Drawing.Size(75, 23)
        Me.btnTimeLimit.TabIndex = 5
        Me.btnTimeLimit.Text = "Ajalimiit"
        Me.btnTimeLimit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(52, 562)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(18, 20)
        Me.lblTimer.TabIndex = 6
        Me.lblTimer.Text = "0"
        Me.lblTimer.Visible = False
        '
        'btnWordList
        '
        Me.btnWordList.Location = New System.Drawing.Point(274, 401)
        Me.btnWordList.Name = "btnWordList"
        Me.btnWordList.Size = New System.Drawing.Size(109, 23)
        Me.btnWordList.TabIndex = 7
        Me.btnWordList.Text = "Enda sõnade list"
        Me.btnWordList.UseVisualStyleBackColor = True
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 6
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(274, 459)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Otsi uuendusi"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.btnWordList)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnTimeLimit)
        Me.Controls.Add(Me.btnClassic)
        Me.Controls.Add(Me.btnGraphics)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "formMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents Label1 As Label

    Friend WithEvents btnClassic As Button

    Friend WithEvents btnGraphics As Button
    Friend WithEvents btnTimeLimit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnWordList As Button
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
    Friend WithEvents btnUpdate As Button
End Class
