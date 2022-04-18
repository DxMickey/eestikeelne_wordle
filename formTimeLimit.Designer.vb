<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTimeLimit
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
        Me.SuspendLayout()
        '
        'lblNewPass1
        '
        Me.lblNewPass1.AutoSize = True
        Me.lblNewPass1.Location = New System.Drawing.Point(173, 259)
        Me.lblNewPass1.Name = "lblNewPass1"
        Me.lblNewPass1.Size = New System.Drawing.Size(109, 13)
        Me.lblNewPass1.TabIndex = 0
        Me.lblNewPass1.Text = "Sisesta uus salasõna:"
        Me.lblNewPass1.Visible = False
        '
        'txtNewPass1
        '
        Me.txtNewPass1.Location = New System.Drawing.Point(285, 256)
        Me.txtNewPass1.Name = "txtNewPass1"
        Me.txtNewPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass1.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass1.TabIndex = 1
        Me.txtNewPass1.Visible = False
        '
        'txtNewPass2
        '
        Me.txtNewPass2.Location = New System.Drawing.Point(285, 287)
        Me.txtNewPass2.Name = "txtNewPass2"
        Me.txtNewPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass2.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass2.TabIndex = 3
        Me.txtNewPass2.Visible = False
        '
        'lblNewPass2
        '
        Me.lblNewPass2.AutoSize = True
        Me.lblNewPass2.Location = New System.Drawing.Point(142, 290)
        Me.lblNewPass2.Name = "lblNewPass2"
        Me.lblNewPass2.Size = New System.Drawing.Size(140, 13)
        Me.lblNewPass2.TabIndex = 2
        Me.lblNewPass2.Text = "Sisesta uus salasõna uuesti:"
        Me.lblNewPass2.Visible = False
        '
        'txtTimeWait
        '
        Me.txtTimeWait.Location = New System.Drawing.Point(285, 291)
        Me.txtTimeWait.Name = "txtTimeWait"
        Me.txtTimeWait.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeWait.TabIndex = 7
        Me.txtTimeWait.Visible = False
        '
        'lblTimeWait
        '
        Me.lblTimeWait.AutoSize = True
        Me.lblTimeWait.Location = New System.Drawing.Point(164, 294)
        Me.lblTimeWait.Name = "lblTimeWait"
        Me.lblTimeWait.Size = New System.Drawing.Size(114, 13)
        Me.lblTimeWait.TabIndex = 6
        Me.lblTimeWait.Text = "Kaua peab ootama (s):"
        Me.lblTimeWait.Visible = False
        '
        'txtTimePlay
        '
        Me.txtTimePlay.Location = New System.Drawing.Point(285, 256)
        Me.txtTimePlay.Name = "txtTimePlay"
        Me.txtTimePlay.Size = New System.Drawing.Size(100, 20)
        Me.txtTimePlay.TabIndex = 5
        Me.txtTimePlay.Visible = False
        '
        'lblTimePlay
        '
        Me.lblTimePlay.AutoSize = True
        Me.lblTimePlay.Location = New System.Drawing.Point(164, 259)
        Me.lblTimePlay.Name = "lblTimePlay"
        Me.lblTimePlay.Size = New System.Drawing.Size(118, 13)
        Me.lblTimePlay.TabIndex = 4
        Me.lblTimePlay.Text = "Kaua saab mängida (s):"
        Me.lblTimePlay.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(299, 333)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "Sisesta"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(285, 256)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 10
        Me.txtPass.Visible = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(189, 259)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(89, 13)
        Me.lblPass.TabIndex = 9
        Me.lblPass.Text = "Sisesta salasõna:"
        Me.lblPass.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(299, 499)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnOnOff
        '
        Me.btnOnOff.Location = New System.Drawing.Point(299, 441)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOnOff.TabIndex = 12
        Me.btnOnOff.Text = "Lülita sisse"
        Me.btnOnOff.UseVisualStyleBackColor = True
        '
        'lblTimePlayNow
        '
        Me.lblTimePlayNow.AutoSize = True
        Me.lblTimePlayNow.Location = New System.Drawing.Point(392, 259)
        Me.lblTimePlayNow.Name = "lblTimePlayNow"
        Me.lblTimePlayNow.Size = New System.Drawing.Size(78, 13)
        Me.lblTimePlayNow.TabIndex = 13
        Me.lblTimePlayNow.Text = "Väärtus hetkel:"
        '
        'lblTimeWaitNow
        '
        Me.lblTimeWaitNow.AutoSize = True
        Me.lblTimeWaitNow.Location = New System.Drawing.Point(392, 298)
        Me.lblTimeWaitNow.Name = "lblTimeWaitNow"
        Me.lblTimeWaitNow.Size = New System.Drawing.Size(78, 13)
        Me.lblTimeWaitNow.TabIndex = 14
        Me.lblTimeWaitNow.Text = "Väärtus hetkel:"
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 14
        '
        'formTimeLimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.lblTimeWaitNow)
        Me.Controls.Add(Me.lblTimePlayNow)
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
    Friend WithEvents lblTimePlayNow As Label
    Friend WithEvents lblTimeWaitNow As Label
End Class
