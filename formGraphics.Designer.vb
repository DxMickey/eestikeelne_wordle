﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tbrRed = New System.Windows.Forms.TrackBar()
        Me.tbrGreen = New System.Windows.Forms.TrackBar()
        Me.tbrBlue = New System.Windows.Forms.TrackBar()
        CType(Me.tbrRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(412, 609)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(125, 48)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Sätesta"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'pnlColor
        '
        Me.pnlColor.BackColor = System.Drawing.SystemColors.Control
        Me.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColor.Location = New System.Drawing.Point(584, 308)
        Me.pnlColor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(225, 211)
        Me.pnlColor.TabIndex = 2
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRed.Location = New System.Drawing.Point(96, 308)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(59, 16)
        Me.lblRed.TabIndex = 3
        Me.lblRed.Text = "Punane"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreen.Location = New System.Drawing.Point(96, 401)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(69, 16)
        Me.lblGreen.TabIndex = 4
        Me.lblGreen.Text = "Roheline"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(96, 484)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(50, 16)
        Me.lblBlue.TabIndex = 5
        Me.lblBlue.Text = "Sinine"
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(470, 308)
        Me.txtRed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(67, 22)
        Me.txtRed.TabIndex = 6
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(470, 395)
        Me.txtGreen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(67, 22)
        Me.txtGreen.TabIndex = 7
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(470, 484)
        Me.txtBlue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(67, 22)
        Me.txtBlue.TabIndex = 8
        '
        'lblTestColor
        '
        Me.lblTestColor.AutoSize = True
        Me.lblTestColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestColor.Location = New System.Drawing.Point(643, 273)
        Me.lblTestColor.Name = "lblTestColor"
        Me.lblTestColor.Size = New System.Drawing.Size(113, 16)
        Me.lblTestColor.TabIndex = 9
        Me.lblTestColor.Text = "Värvi eelvaade"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(33, 31)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 34)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Brown
        Me.lblError.Location = New System.Drawing.Point(148, 564)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(39, 16)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "Viga"
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(99, 609)
        Me.btnDefault.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(126, 48)
        Me.btnDefault.TabIndex = 14
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'tbrRed
        '
        Me.tbrRed.Location = New System.Drawing.Point(183, 308)
        Me.tbrRed.Maximum = 255
        Me.tbrRed.Name = "tbrRed"
        Me.tbrRed.Size = New System.Drawing.Size(253, 56)
        Me.tbrRed.TabIndex = 15
        '
        'tbrGreen
        '
        Me.tbrGreen.Location = New System.Drawing.Point(183, 401)
        Me.tbrGreen.Maximum = 255
        Me.tbrGreen.Name = "tbrGreen"
        Me.tbrGreen.Size = New System.Drawing.Size(253, 56)
        Me.tbrGreen.TabIndex = 16
        '
        'tbrBlue
        '
        Me.tbrBlue.Location = New System.Drawing.Point(183, 484)
        Me.tbrBlue.Maximum = 255
        Me.tbrBlue.Name = "tbrBlue"
        Me.tbrBlue.Size = New System.Drawing.Size(253, 56)
        Me.tbrBlue.TabIndex = 17
        '
        'formGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 937)
        Me.Controls.Add(Me.tbrBlue)
        Me.Controls.Add(Me.tbrGreen)
        Me.Controls.Add(Me.tbrRed)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graafika"
        CType(Me.tbrRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents tbrRed As TrackBar
    Friend WithEvents tbrGreen As TrackBar
    Friend WithEvents tbrBlue As TrackBar
End Class
