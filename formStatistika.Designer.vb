<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formStatistika
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGamesCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalTime = New System.Windows.Forms.Label()
        Me.txtAvgTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGuessed = New System.Windows.Forms.Label()
        Me.txtFastestTime = New System.Windows.Forms.Label()
        Me.txtSlowestTime = New System.Windows.Forms.Label()
        Me.txtHighscore = New System.Windows.Forms.Label()
        Me.txtAvgScore = New System.Windows.Forms.Label()
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(275, 636)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 53)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(228, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mänge mängitud:"
        '
        'txtGamesCount
        '
        Me.txtGamesCount.AutoSize = True
        Me.txtGamesCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtGamesCount.Location = New System.Drawing.Point(456, 51)
        Me.txtGamesCount.Name = "txtGamesCount"
        Me.txtGamesCount.Size = New System.Drawing.Size(29, 31)
        Me.txtGamesCount.TabIndex = 2
        Me.txtGamesCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(198, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kokku kulunud aeg:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label3.Location = New System.Drawing.Point(142, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keskmiselt kulunud aeg:"
        '
        'txtTotalTime
        '
        Me.txtTotalTime.AutoSize = True
        Me.txtTotalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtTotalTime.Location = New System.Drawing.Point(456, 96)
        Me.txtTotalTime.Name = "txtTotalTime"
        Me.txtTotalTime.Size = New System.Drawing.Size(29, 31)
        Me.txtTotalTime.TabIndex = 5
        Me.txtTotalTime.Text = "0"
        '
        'txtAvgTime
        '
        Me.txtAvgTime.AutoSize = True
        Me.txtAvgTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtAvgTime.Location = New System.Drawing.Point(456, 139)
        Me.txtAvgTime.Name = "txtAvgTime"
        Me.txtAvgTime.Size = New System.Drawing.Size(29, 31)
        Me.txtAvgTime.TabIndex = 6
        Me.txtAvgTime.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label4.Location = New System.Drawing.Point(161, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ära arvatud sõnade nr:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label5.Location = New System.Drawing.Point(116, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kõige kiirem ära arvamine:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label6.Location = New System.Drawing.Point(71, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Kõige aeglasem ära arvamine:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label7.Location = New System.Drawing.Point(269, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 31)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Suurim skoor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label8.Location = New System.Drawing.Point(235, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 31)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Keskmine skoor:"
        '
        'txtGuessed
        '
        Me.txtGuessed.AutoSize = True
        Me.txtGuessed.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtGuessed.Location = New System.Drawing.Point(456, 188)
        Me.txtGuessed.Name = "txtGuessed"
        Me.txtGuessed.Size = New System.Drawing.Size(29, 31)
        Me.txtGuessed.TabIndex = 12
        Me.txtGuessed.Text = "0"
        '
        'txtFastestTime
        '
        Me.txtFastestTime.AutoSize = True
        Me.txtFastestTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtFastestTime.Location = New System.Drawing.Point(456, 233)
        Me.txtFastestTime.Name = "txtFastestTime"
        Me.txtFastestTime.Size = New System.Drawing.Size(29, 31)
        Me.txtFastestTime.TabIndex = 13
        Me.txtFastestTime.Text = "0"
        '
        'txtSlowestTime
        '
        Me.txtSlowestTime.AutoSize = True
        Me.txtSlowestTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtSlowestTime.Location = New System.Drawing.Point(456, 278)
        Me.txtSlowestTime.Name = "txtSlowestTime"
        Me.txtSlowestTime.Size = New System.Drawing.Size(29, 31)
        Me.txtSlowestTime.TabIndex = 14
        Me.txtSlowestTime.Text = "0"
        '
        'txtHighscore
        '
        Me.txtHighscore.AutoSize = True
        Me.txtHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtHighscore.Location = New System.Drawing.Point(456, 324)
        Me.txtHighscore.Name = "txtHighscore"
        Me.txtHighscore.Size = New System.Drawing.Size(29, 31)
        Me.txtHighscore.TabIndex = 15
        Me.txtHighscore.Text = "0"
        '
        'txtAvgScore
        '
        Me.txtAvgScore.AutoSize = True
        Me.txtAvgScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txtAvgScore.Location = New System.Drawing.Point(456, 368)
        Me.txtAvgScore.Name = "txtAvgScore"
        Me.txtAvgScore.Size = New System.Drawing.Size(29, 31)
        Me.txtAvgScore.TabIndex = 16
        Me.txtAvgScore.Text = "0"
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 17
        '
        'formStatistika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.txtAvgScore)
        Me.Controls.Add(Me.txtHighscore)
        Me.Controls.Add(Me.txtSlowestTime)
        Me.Controls.Add(Me.txtFastestTime)
        Me.Controls.Add(Me.txtGuessed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAvgTime)
        Me.Controls.Add(Me.txtTotalTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGamesCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "formStatistika"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGamesCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalTime As Label
    Friend WithEvents txtAvgTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGuessed As Label
    Friend WithEvents txtFastestTime As Label
    Friend WithEvents txtSlowestTime As Label
    Friend WithEvents txtHighscore As Label
    Friend WithEvents txtAvgScore As Label
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
End Class
