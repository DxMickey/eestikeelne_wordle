<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCMusicPlayer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pbPause = New System.Windows.Forms.PictureBox()
        Me.pbPlay = New System.Windows.Forms.PictureBox()
        CType(Me.pbPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbPause
        '
        Me.pbPause.ErrorImage = Global.TaustaMuusika.My.Resources.Resources.pause_button
        Me.pbPause.Image = Global.TaustaMuusika.My.Resources.Resources.pause_button
        Me.pbPause.InitialImage = Nothing
        Me.pbPause.Location = New System.Drawing.Point(32, 0)
        Me.pbPause.Name = "pbPause"
        Me.pbPause.Size = New System.Drawing.Size(26, 26)
        Me.pbPause.TabIndex = 0
        Me.pbPause.TabStop = False
        '
        'pbPlay
        '
        Me.pbPlay.Image = Global.TaustaMuusika.My.Resources.Resources.play
        Me.pbPlay.InitialImage = Nothing
        Me.pbPlay.Location = New System.Drawing.Point(0, 0)
        Me.pbPlay.Name = "pbPlay"
        Me.pbPlay.Size = New System.Drawing.Size(26, 26)
        Me.pbPlay.TabIndex = 0
        Me.pbPlay.TabStop = False
        '
        'UCMusicPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbPause)
        Me.Controls.Add(Me.pbPlay)
        Me.Name = "UCMusicPlayer"
        Me.Size = New System.Drawing.Size(58, 26)
        CType(Me.pbPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbPlay As System.Windows.Forms.PictureBox
    Friend WithEvents pbPause As System.Windows.Forms.PictureBox
End Class
