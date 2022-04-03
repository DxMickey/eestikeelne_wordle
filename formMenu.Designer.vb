<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGraphics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(404, 283)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(100, 28)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Mängi"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(316, 443)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(100, 28)
        Me.btnHistory.TabIndex = 1
        Me.btnHistory.Text = "Ajalugu"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(316, 391)
        Me.btnStats.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(100, 28)
        Me.btnStats.TabIndex = 2
        Me.btnStats.Text = "Statistika"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 40.75!)
        Me.Label1.Location = New System.Drawing.Point(48, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(756, 81)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eestikeelne Wordle"
        '
        'btnGraphics
        '
        Me.btnGraphics.Location = New System.Drawing.Point(493, 391)
        Me.btnGraphics.Name = "btnGraphics"
        Me.btnGraphics.Size = New System.Drawing.Size(100, 28)
        Me.btnGraphics.TabIndex = 4
        Me.btnGraphics.Text = "Kujundus"
        Me.btnGraphics.UseVisualStyleBackColor = True
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 937)
        Me.Controls.Add(Me.btnGraphics)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPlay)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formMenu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGraphics As Button
End Class
