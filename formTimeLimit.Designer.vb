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
        Me.lblTimeLimit = New System.Windows.Forms.Label()
        Me.lblCooldown = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTimeLimit
        '
        Me.lblTimeLimit.AutoSize = True
        Me.lblTimeLimit.Location = New System.Drawing.Point(149, 176)
        Me.lblTimeLimit.Name = "lblTimeLimit"
        Me.lblTimeLimit.Size = New System.Drawing.Size(134, 13)
        Me.lblTimeLimit.TabIndex = 0
        Me.lblTimeLimit.Text = "Seadista mängu ajapiirang:"
        '
        'lblCooldown
        '
        Me.lblCooldown.AutoSize = True
        Me.lblCooldown.Location = New System.Drawing.Point(152, 253)
        Me.lblCooldown.Name = "lblCooldown"
        Me.lblCooldown.Size = New System.Drawing.Size(189, 13)
        Me.lblCooldown.TabIndex = 1
        Me.lblCooldown.Text = "Seadista mängude vaheline ajapiirang:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(384, 176)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(384, 253)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(152, 363)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(160, 23)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Kinnita muudatused"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'formTimeLimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCooldown)
        Me.Controls.Add(Me.lblTimeLimit)
        Me.Name = "formTimeLimit"
        Me.Text = "formTimeLimit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimeLimit As Label
    Friend WithEvents lblCooldown As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnConfirm As Button
End Class
