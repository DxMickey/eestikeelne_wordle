<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTimeLimit
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
        Me.lblNewPass1 = New System.Windows.Forms.Label()
        Me.txtNewPass1 = New System.Windows.Forms.TextBox()
        Me.txtNewPass2 = New System.Windows.Forms.TextBox()
        Me.lblNewPass2 = New System.Windows.Forms.Label()
        Me.txtTimeWait = New System.Windows.Forms.TextBox()
        Me.lblTimeWait = New System.Windows.Forms.Label()
        Me.txtTimePlay = New System.Windows.Forms.TextBox()
        Me.lblTimePlay = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnOnOff = New System.Windows.Forms.Button()
        Me.lblTimePlayNow = New System.Windows.Forms.Label()
        Me.lblTimeWaitNow = New System.Windows.Forms.Label()
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.cmbTimePlay = New System.Windows.Forms.ComboBox()
        Me.cmbWaitTime = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNewPass1
        '
        Me.lblNewPass1.AutoSize = True
        Me.lblNewPass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblNewPass1.Location = New System.Drawing.Point(127, 306)
        Me.lblNewPass1.Name = "lblNewPass1"
        Me.lblNewPass1.Size = New System.Drawing.Size(153, 18)
        Me.lblNewPass1.TabIndex = 0
        Me.lblNewPass1.Text = "Sisesta uus salasõna:"
        Me.lblNewPass1.Visible = False
        '
        'txtNewPass1
        '
        Me.txtNewPass1.Location = New System.Drawing.Point(286, 312)
        Me.txtNewPass1.Name = "txtNewPass1"
        Me.txtNewPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass1.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass1.TabIndex = 1
        Me.txtNewPass1.Visible = False
        '
        'txtNewPass2
        '
        Me.txtNewPass2.Location = New System.Drawing.Point(286, 338)
        Me.txtNewPass2.Name = "txtNewPass2"
        Me.txtNewPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass2.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass2.TabIndex = 3
        Me.txtNewPass2.Visible = False
        '
        'lblNewPass2
        '
        Me.lblNewPass2.AutoSize = True
        Me.lblNewPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblNewPass2.Location = New System.Drawing.Point(83, 343)
        Me.lblNewPass2.Name = "lblNewPass2"
        Me.lblNewPass2.Size = New System.Drawing.Size(196, 18)
        Me.lblNewPass2.TabIndex = 2
        Me.lblNewPass2.Text = "Sisesta uus salasõna uuesti:"
        Me.lblNewPass2.Visible = False
        '
        'txtTimeWait
        '
        Me.txtTimeWait.Location = New System.Drawing.Point(285, 341)
        Me.txtTimeWait.Name = "txtTimeWait"
        Me.txtTimeWait.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeWait.TabIndex = 7
        Me.txtTimeWait.Visible = False
        '
        'lblTimeWait
        '
        Me.lblTimeWait.AutoSize = True
        Me.lblTimeWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblTimeWait.Location = New System.Drawing.Point(138, 343)
        Me.lblTimeWait.Name = "lblTimeWait"
        Me.lblTimeWait.Size = New System.Drawing.Size(141, 18)
        Me.lblTimeWait.TabIndex = 6
        Me.lblTimeWait.Text = "Kaua peab ootama :"
        Me.lblTimeWait.Visible = False
        '
        'txtTimePlay
        '
        Me.txtTimePlay.Location = New System.Drawing.Point(286, 309)
        Me.txtTimePlay.Name = "txtTimePlay"
        Me.txtTimePlay.Size = New System.Drawing.Size(100, 20)
        Me.txtTimePlay.TabIndex = 5
        Me.txtTimePlay.Visible = False
        '
        'lblTimePlay
        '
        Me.lblTimePlay.AutoSize = True
        Me.lblTimePlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblTimePlay.Location = New System.Drawing.Point(134, 306)
        Me.lblTimePlay.Name = "lblTimePlay"
        Me.lblTimePlay.Size = New System.Drawing.Size(146, 18)
        Me.lblTimePlay.TabIndex = 4
        Me.lblTimePlay.Text = "Kaua saab mängida :"
        Me.lblTimePlay.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnEnter.Location = New System.Drawing.Point(285, 385)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(101, 44)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "Sisesta"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(286, 325)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 10
        Me.txtPass.Visible = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPass.Location = New System.Drawing.Point(155, 323)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(125, 18)
        Me.lblPass.TabIndex = 9
        Me.lblPass.Text = "Sisesta salasõna:"
        Me.lblPass.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnBack.Location = New System.Drawing.Point(286, 591)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 38)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnOnOff
        '
        Me.btnOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnOnOff.Location = New System.Drawing.Point(270, 462)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(132, 49)
        Me.btnOnOff.TabIndex = 12
        Me.btnOnOff.Text = "Lülita sisse"
        Me.btnOnOff.UseVisualStyleBackColor = True
        '
        'lblTimePlayNow
        '
        Me.lblTimePlayNow.AutoSize = True
        Me.lblTimePlayNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblTimePlayNow.Location = New System.Drawing.Point(481, 309)
        Me.lblTimePlayNow.Name = "lblTimePlayNow"
        Me.lblTimePlayNow.Size = New System.Drawing.Size(103, 17)
        Me.lblTimePlayNow.TabIndex = 15
        Me.lblTimePlayNow.Text = "Väärtus hetkel:"
        '
        'lblTimeWaitNow
        '
        Me.lblTimeWaitNow.AutoSize = True
        Me.lblTimeWaitNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblTimeWaitNow.Location = New System.Drawing.Point(480, 344)
        Me.lblTimeWaitNow.Name = "lblTimeWaitNow"
        Me.lblTimeWaitNow.Size = New System.Drawing.Size(103, 17)
        Me.lblTimeWaitNow.TabIndex = 16
        Me.lblTimeWaitNow.Text = "Väärtus hetkel:"
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 14
        '
        'cmbTimePlay
        '
        Me.cmbTimePlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimePlay.FormattingEnabled = True
        Me.cmbTimePlay.Items.AddRange(New Object() {"sekund", "minut", "tund"})
        Me.cmbTimePlay.Location = New System.Drawing.Point(392, 307)
        Me.cmbTimePlay.Name = "cmbTimePlay"
        Me.cmbTimePlay.Size = New System.Drawing.Size(83, 21)
        Me.cmbTimePlay.TabIndex = 17
        '
        'cmbWaitTime
        '
        Me.cmbWaitTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWaitTime.FormattingEnabled = True
        Me.cmbWaitTime.Items.AddRange(New Object() {"sekund", "minut", "tund"})
        Me.cmbWaitTime.Location = New System.Drawing.Point(391, 342)
        Me.cmbWaitTime.Name = "cmbWaitTime"
        Me.cmbWaitTime.Size = New System.Drawing.Size(83, 21)
        Me.cmbWaitTime.TabIndex = 18
        '
        'formTimeLimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.cmbWaitTime)
        Me.Controls.Add(Me.cmbTimePlay)
        Me.Controls.Add(Me.lblTimeWaitNow)
        Me.Controls.Add(Me.lblTimePlayNow)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.btnOnOff)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtTimeWait)
        Me.Controls.Add(Me.lblTimeWait)
        Me.Controls.Add(Me.txtTimePlay)
        Me.Controls.Add(Me.lblTimePlay)
        Me.Controls.Add(Me.txtNewPass2)
        Me.Controls.Add(Me.lblNewPass2)
        Me.Controls.Add(Me.txtNewPass1)
        Me.Controls.Add(Me.lblNewPass1)
        Me.Name = "formTimeLimit"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewPass1 As Label
    Friend WithEvents txtNewPass1 As TextBox
    Friend WithEvents txtNewPass2 As TextBox
    Friend WithEvents lblNewPass2 As Label
    Friend WithEvents txtTimeWait As TextBox
    Friend WithEvents lblTimeWait As Label
    Friend WithEvents txtTimePlay As TextBox
    Friend WithEvents lblTimePlay As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnOnOff As Button
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
    Friend WithEvents lblTimePlayNow As Label
    Friend WithEvents lblTimeWaitNow As Label
    Friend WithEvents cmbTimePlay As ComboBox
    Friend WithEvents cmbWaitTime As ComboBox
End Class
