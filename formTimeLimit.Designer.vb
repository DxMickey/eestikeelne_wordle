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
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNewPass1
        '
        Me.lblNewPass1.AutoSize = True
        Me.lblNewPass1.Location = New System.Drawing.Point(174, 281)
        Me.lblNewPass1.Name = "lblNewPass1"
        Me.lblNewPass1.Size = New System.Drawing.Size(109, 13)
        Me.lblNewPass1.TabIndex = 0
        Me.lblNewPass1.Text = "Sisesta uus salasõna:"
        Me.lblNewPass1.Visible = False
        '
        'txtNewPass1
        '
        Me.txtNewPass1.Location = New System.Drawing.Point(286, 278)
        Me.txtNewPass1.Name = "txtNewPass1"
        Me.txtNewPass1.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass1.TabIndex = 1
        Me.txtNewPass1.Visible = False
        '
        'txtNewPass2
        '
        Me.txtNewPass2.Location = New System.Drawing.Point(286, 313)
        Me.txtNewPass2.Name = "txtNewPass2"
        Me.txtNewPass2.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass2.TabIndex = 3
        Me.txtNewPass2.Visible = False
        '
        'lblNewPass2
        '
        Me.lblNewPass2.AutoSize = True
        Me.lblNewPass2.Location = New System.Drawing.Point(143, 316)
        Me.lblNewPass2.Name = "lblNewPass2"
        Me.lblNewPass2.Size = New System.Drawing.Size(140, 13)
        Me.lblNewPass2.TabIndex = 2
        Me.lblNewPass2.Text = "Sisesta uus salasõna uuesti:"
        Me.lblNewPass2.Visible = False
        '
        'txtTimeWait
        '
        Me.txtTimeWait.Location = New System.Drawing.Point(286, 208)
        Me.txtTimeWait.Name = "txtTimeWait"
        Me.txtTimeWait.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeWait.TabIndex = 7
        Me.txtTimeWait.Visible = False
        '
        'lblTimeWait
        '
        Me.lblTimeWait.AutoSize = True
        Me.lblTimeWait.Location = New System.Drawing.Point(165, 211)
        Me.lblTimeWait.Name = "lblTimeWait"
        Me.lblTimeWait.Size = New System.Drawing.Size(114, 13)
        Me.lblTimeWait.TabIndex = 6
        Me.lblTimeWait.Text = "Kaua peab ootama (s):"
        Me.lblTimeWait.Visible = False
        '
        'txtTimePlay
        '
        Me.txtTimePlay.Location = New System.Drawing.Point(286, 173)
        Me.txtTimePlay.Name = "txtTimePlay"
        Me.txtTimePlay.Size = New System.Drawing.Size(100, 20)
        Me.txtTimePlay.TabIndex = 5
        Me.txtTimePlay.Visible = False
        '
        'lblTimePlay
        '
        Me.lblTimePlay.AutoSize = True
        Me.lblTimePlay.Location = New System.Drawing.Point(165, 176)
        Me.lblTimePlay.Name = "lblTimePlay"
        Me.lblTimePlay.Size = New System.Drawing.Size(118, 13)
        Me.lblTimePlay.TabIndex = 4
        Me.lblTimePlay.Text = "Kaua saab mängida (s):"
        Me.lblTimePlay.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(299, 355)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(286, 243)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 10
        Me.txtPass.Visible = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(190, 246)
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
        'btnOn
        '
        Me.btnOn.Location = New System.Drawing.Point(227, 419)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(75, 23)
        Me.btnOn.TabIndex = 12
        Me.btnOn.Text = "Lülita sisse"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(360, 419)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOff.TabIndex = 13
        Me.btnOff.Text = "Lülita välja"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'formTimeLimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
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
    Friend WithEvents btnOn As Button
    Friend WithEvents btnOff As Button
End Class
