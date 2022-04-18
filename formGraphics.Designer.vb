<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGraphics
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
        Me.btnTry = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.lblTestColor = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTry
        '
        Me.btnTry.Location = New System.Drawing.Point(216, 293)
        Me.btnTry.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTry.Name = "btnTry"
        Me.btnTry.Size = New System.Drawing.Size(56, 19)
        Me.btnTry.TabIndex = 0
        Me.btnTry.Text = "Proovi"
        Me.btnTry.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(142, 293)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(56, 19)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Sätesta"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'pnlColor
        '
        Me.pnlColor.BackColor = System.Drawing.SystemColors.Control
        Me.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColor.Location = New System.Drawing.Point(327, 127)
        Me.pnlColor.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(169, 172)
        Me.pnlColor.TabIndex = 2
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Location = New System.Drawing.Point(66, 158)
        Me.lblRed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(44, 13)
        Me.lblRed.TabIndex = 3
        Me.lblRed.Text = "Punane"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Location = New System.Drawing.Point(66, 202)
        Me.lblGreen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(49, 13)
        Me.lblGreen.TabIndex = 4
        Me.lblGreen.Text = "Roheline"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Location = New System.Drawing.Point(66, 240)
        Me.lblBlue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(36, 13)
        Me.lblBlue.TabIndex = 5
        Me.lblBlue.Text = "Sinine"
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(148, 153)
        Me.txtRed.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(125, 20)
        Me.txtRed.TabIndex = 6
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(148, 197)
        Me.txtGreen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(125, 20)
        Me.txtGreen.TabIndex = 7
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(148, 235)
        Me.txtBlue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(125, 20)
        Me.txtBlue.TabIndex = 8
        '
        'lblTestColor
        '
        Me.lblTestColor.AutoSize = True
        Me.lblTestColor.Location = New System.Drawing.Point(371, 98)
        Me.lblTestColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTestColor.Name = "lblTestColor"
        Me.lblTestColor.Size = New System.Drawing.Size(78, 13)
        Me.lblTestColor.TabIndex = 9
        Me.lblTestColor.Text = "Värvi eelvaade"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(25, 25)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 28)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Brown
        Me.lblError.Location = New System.Drawing.Point(116, 342)
        Me.lblError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(31, 15)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "Viga"
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(68, 293)
        Me.btnDefault.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(56, 19)
        Me.btnDefault.TabIndex = 14
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'formGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTestColor)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.pnlColor)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnTry)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graafika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTry As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents pnlColor As Panel
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents txtRed As TextBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents lblTestColor As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblError As Label
    Friend WithEvents btnDefault As Button
End Class
