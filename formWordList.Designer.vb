<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formWordList
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
        Me.btnSisesta = New System.Windows.Forms.Button()
        Me.rbtnLihtne = New System.Windows.Forms.RadioButton()
        Me.rbtnTavaline = New System.Windows.Forms.RadioButton()
        Me.rbtnRaske = New System.Windows.Forms.RadioButton()
        Me.btnOnOff = New System.Windows.Forms.Button()
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.openDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(311, 587)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Millist sõnade listi soovid sisestada?"
        '
        'btnSisesta
        '
        Me.btnSisesta.Location = New System.Drawing.Point(299, 276)
        Me.btnSisesta.Name = "btnSisesta"
        Me.btnSisesta.Size = New System.Drawing.Size(100, 34)
        Me.btnSisesta.TabIndex = 7
        Me.btnSisesta.Text = "Vali CSV fail"
        Me.btnSisesta.UseVisualStyleBackColor = True
        '
        'rbtnLihtne
        '
        Me.rbtnLihtne.AutoSize = True
        Me.rbtnLihtne.Location = New System.Drawing.Point(299, 185)
        Me.rbtnLihtne.Name = "rbtnLihtne"
        Me.rbtnLihtne.Size = New System.Drawing.Size(108, 17)
        Me.rbtnLihtne.TabIndex = 9
        Me.rbtnLihtne.TabStop = True
        Me.rbtnLihtne.Text = "4-tähelised sõnad"
        Me.rbtnLihtne.UseVisualStyleBackColor = True
        '
        'rbtnTavaline
        '
        Me.rbtnTavaline.AutoSize = True
        Me.rbtnTavaline.Location = New System.Drawing.Point(299, 208)
        Me.rbtnTavaline.Name = "rbtnTavaline"
        Me.rbtnTavaline.Size = New System.Drawing.Size(108, 17)
        Me.rbtnTavaline.TabIndex = 10
        Me.rbtnTavaline.TabStop = True
        Me.rbtnTavaline.Text = "5-tähelised sõnad"
        Me.rbtnTavaline.UseVisualStyleBackColor = True
        '
        'rbtnRaske
        '
        Me.rbtnRaske.AutoSize = True
        Me.rbtnRaske.Location = New System.Drawing.Point(299, 231)
        Me.rbtnRaske.Name = "rbtnRaske"
        Me.rbtnRaske.Size = New System.Drawing.Size(108, 17)
        Me.rbtnRaske.TabIndex = 11
        Me.rbtnRaske.TabStop = True
        Me.rbtnRaske.Text = "6-tähelised sõnad"
        Me.rbtnRaske.UseVisualStyleBackColor = True
        '
        'btnOnOff
        '
        Me.btnOnOff.Location = New System.Drawing.Point(311, 357)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOnOff.TabIndex = 12
        Me.btnOnOff.Text = "Lülita sisse"
        Me.btnOnOff.UseVisualStyleBackColor = True
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 14
        '
        'formWordList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.btnOnOff)
        Me.Controls.Add(Me.rbtnRaske)
        Me.Controls.Add(Me.rbtnTavaline)
        Me.Controls.Add(Me.rbtnLihtne)
        Me.Controls.Add(Me.btnSisesta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "formWordList"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSisesta As Button
    Friend WithEvents rbtnLihtne As RadioButton
    Friend WithEvents rbtnTavaline As RadioButton
    Friend WithEvents rbtnRaske As RadioButton
    Friend WithEvents btnOnOff As Button
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
    Friend WithEvents openDialog1 As OpenFileDialog
End Class
