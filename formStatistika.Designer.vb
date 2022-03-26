<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStatistika
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGamesCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalTime = New System.Windows.Forms.Label()
        Me.lblAvgTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(273, 510)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(126, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mänge mängitud:"
        '
        'lblGamesCount
        '
        Me.lblGamesCount.AutoSize = True
        Me.lblGamesCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblGamesCount.Location = New System.Drawing.Point(354, 79)
        Me.lblGamesCount.Name = "lblGamesCount"
        Me.lblGamesCount.Size = New System.Drawing.Size(29, 31)
        Me.lblGamesCount.TabIndex = 2
        Me.lblGamesCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(96, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kokku kulunud aeg:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label3.Location = New System.Drawing.Point(40, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keskmiselt kulunud aeg:"
        '
        'lblTotalTime
        '
        Me.lblTotalTime.AutoSize = True
        Me.lblTotalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblTotalTime.Location = New System.Drawing.Point(354, 147)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(29, 31)
        Me.lblTotalTime.TabIndex = 5
        Me.lblTotalTime.Text = "0"
        '
        'lblAvgTime
        '
        Me.lblAvgTime.AutoSize = True
        Me.lblAvgTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblAvgTime.Location = New System.Drawing.Point(354, 207)
        Me.lblAvgTime.Name = "lblAvgTime"
        Me.lblAvgTime.Size = New System.Drawing.Size(29, 31)
        Me.lblAvgTime.TabIndex = 6
        Me.lblAvgTime.Text = "0"
        '
        'formStatistika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.lblAvgTime)
        Me.Controls.Add(Me.lblTotalTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGamesCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "formStatistika"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGamesCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalTime As Label
    Friend WithEvents lblAvgTime As Label
End Class
