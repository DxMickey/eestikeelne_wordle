<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGameSettings
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
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.btnNoTime = New System.Windows.Forms.Button()
        Me.btnTimed = New System.Windows.Forms.Button()
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGameMode = New System.Windows.Forms.Label()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEasy
        '
        Me.btnEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnEasy.Location = New System.Drawing.Point(154, 366)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(121, 49)
        Me.btnEasy.TabIndex = 0
        Me.btnEasy.Text = "Lihtne"
        Me.btnEasy.UseVisualStyleBackColor = True
        '
        'btnNormal
        '
        Me.btnNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnNormal.Location = New System.Drawing.Point(284, 367)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(121, 48)
        Me.btnNormal.TabIndex = 1
        Me.btnNormal.Text = "Tavaline"
        Me.btnNormal.UseVisualStyleBackColor = True
        '
        'btnHard
        '
        Me.btnHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnHard.Location = New System.Drawing.Point(411, 367)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(121, 50)
        Me.btnHard.TabIndex = 2
        Me.btnHard.Text = "Raske"
        Me.btnHard.UseVisualStyleBackColor = True
        '
        'btnNoTime
        '
        Me.btnNoTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnNoTime.Location = New System.Drawing.Point(209, 302)
        Me.btnNoTime.Name = "btnNoTime"
        Me.btnNoTime.Size = New System.Drawing.Size(114, 58)
        Me.btnNoTime.TabIndex = 3
        Me.btnNoTime.Text = "Ilma ajata"
        Me.btnNoTime.UseVisualStyleBackColor = True
        '
        'btnTimed
        '
        Me.btnTimed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnTimed.Location = New System.Drawing.Point(362, 302)
        Me.btnTimed.Name = "btnTimed"
        Me.btnTimed.Size = New System.Drawing.Size(119, 59)
        Me.btnTimed.TabIndex = 4
        Me.btnTimed.Text = "Ajaline"
        Me.btnTimed.UseVisualStyleBackColor = True
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'lblGameMode
        '
        Me.lblGameMode.AutoSize = True
        Me.lblGameMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblGameMode.Location = New System.Drawing.Point(216, 268)
        Me.lblGameMode.Name = "lblGameMode"
        Me.lblGameMode.Size = New System.Drawing.Size(265, 31)
        Me.lblGameMode.TabIndex = 7
        Me.lblGameMode.Text = "Vali mängulaadi tüüp"
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblDifficulty.Location = New System.Drawing.Point(203, 329)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(288, 31)
        Me.lblDifficulty.TabIndex = 8
        Me.lblDifficulty.Text = "Vali mängu raskusaste"
        Me.lblDifficulty.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Button1.Location = New System.Drawing.Point(284, 625)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 41)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Tagasi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formGameSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.lblGameMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.btnTimed)
        Me.Controls.Add(Me.btnNoTime)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnNormal)
        Me.Controls.Add(Me.btnEasy)
        Me.Name = "formGameSettings"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEasy As Button
    Friend WithEvents btnNormal As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents btnNoTime As Button
    Friend WithEvents btnTimed As Button
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGameMode As Label
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents Button1 As Button
End Class
