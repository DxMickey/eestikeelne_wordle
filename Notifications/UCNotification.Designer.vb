<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCNotification
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rtbNotificationInfo = New System.Windows.Forms.RichTextBox()
        Me.pbNotificationImage = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbNotificationImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(17, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(37, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "lblTitle"
        '
        'rtbNotificationInfo
        '
        Me.rtbNotificationInfo.Location = New System.Drawing.Point(3, 86)
        Me.rtbNotificationInfo.Name = "rtbNotificationInfo"
        Me.rtbNotificationInfo.Size = New System.Drawing.Size(160, 54)
        Me.rtbNotificationInfo.TabIndex = 1
        Me.rtbNotificationInfo.Text = "Teenisid saavutuse vms"
        '
        'pbNotificationImage
        '
        Me.pbNotificationImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbNotificationImage.Location = New System.Drawing.Point(56, 30)
        Me.pbNotificationImage.Name = "pbNotificationImage"
        Me.pbNotificationImage.Size = New System.Drawing.Size(54, 50)
        Me.pbNotificationImage.TabIndex = 2
        Me.pbNotificationImage.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'UCNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbNotificationImage)
        Me.Controls.Add(Me.rtbNotificationInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "UCNotification"
        Me.Size = New System.Drawing.Size(170, 143)
        CType(Me.pbNotificationImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents rtbNotificationInfo As RichTextBox
    Friend WithEvents pbNotificationImage As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
