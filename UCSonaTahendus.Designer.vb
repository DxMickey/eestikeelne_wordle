<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSonaTahendus
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblSona = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbSonaTahendus = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblSona
        '
        Me.lblSona.AutoSize = True
        Me.lblSona.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblSona.Location = New System.Drawing.Point(-3, 11)
        Me.lblSona.Name = "lblSona"
        Me.lblSona.Size = New System.Drawing.Size(66, 25)
        Me.lblSona.TabIndex = 0
        Me.lblSona.Text = "Sona"
        Me.lblSona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'rtbSonaTahendus
        '
        Me.rtbSonaTahendus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSonaTahendus.Enabled = False
        Me.rtbSonaTahendus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rtbSonaTahendus.Location = New System.Drawing.Point(2, 41)
        Me.rtbSonaTahendus.Name = "rtbSonaTahendus"
        Me.rtbSonaTahendus.Size = New System.Drawing.Size(197, 96)
        Me.rtbSonaTahendus.TabIndex = 3
        Me.rtbSonaTahendus.Text = "Siia ilmub sona t2hendus jne"
        '
        'UCSonaTahendus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rtbSonaTahendus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSona)
        Me.Name = "UCSonaTahendus"
        Me.Size = New System.Drawing.Size(202, 141)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSona As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbSonaTahendus As RichTextBox
End Class
