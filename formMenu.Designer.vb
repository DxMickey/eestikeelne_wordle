﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.btnGraphics = New System.Windows.Forms.Button()
        Me.btnTimeLimit = New System.Windows.Forms.Button()
        Me.labelTimeChanged = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(352, 251)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Piiramatu"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(292, 372)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnHistory.TabIndex = 1
        Me.btnHistory.Text = "Ajalugu"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(292, 331)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(75, 23)
        Me.btnStats.TabIndex = 2
        Me.btnStats.Text = "Statistika"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 40.75!)
        Me.Label1.Location = New System.Drawing.Point(36, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(609, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eestikeelne Wordle"
        '
        'btnClassic
        '
        Me.btnClassic.Location = New System.Drawing.Point(232, 251)
        Me.btnClassic.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Size = New System.Drawing.Size(75, 23)
        Me.btnClassic.TabIndex = 4
        Me.btnClassic.Text = "Klassikaline"
        Me.btnClassic.UseVisualStyleBackColor = True
        '
        'btnGraphics
        '
        Me.btnGraphics.Location = New System.Drawing.Point(292, 290)
        Me.btnGraphics.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGraphics.Name = "btnGraphics"
        Me.btnGraphics.Size = New System.Drawing.Size(75, 23)
        Me.btnGraphics.TabIndex = 4
        Me.btnGraphics.Text = "Kujundus"
        Me.btnGraphics.UseVisualStyleBackColor = True
        '
        'btnTimeLimit
        '
        Me.btnTimeLimit.Location = New System.Drawing.Point(292, 418)
        Me.btnTimeLimit.Name = "btnTimeLimit"
        Me.btnTimeLimit.Size = New System.Drawing.Size(75, 23)
        Me.btnTimeLimit.TabIndex = 5
        Me.btnTimeLimit.Text = "Ajalimiit"
        Me.btnTimeLimit.UseVisualStyleBackColor = True
        '
        'labelTimeChanged
        '
        Me.labelTimeChanged.AutoSize = True
        Me.labelTimeChanged.BackColor = System.Drawing.Color.Lime
        Me.labelTimeChanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.labelTimeChanged.Location = New System.Drawing.Point(165, 517)
        Me.labelTimeChanged.Name = "labelTimeChanged"
        Me.labelTimeChanged.Size = New System.Drawing.Size(0, 31)
        Me.labelTimeChanged.TabIndex = 6
        '
        'Timer1
        '
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.labelTimeChanged)
        Me.Controls.Add(Me.btnTimeLimit)
        Me.Controls.Add(Me.btnClassic)
        Me.Controls.Add(Me.btnGraphics)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "formMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents Label1 As Label

    Friend WithEvents btnClassic As Button

    Friend WithEvents btnGraphics As Button
    Friend WithEvents btnTimeLimit As Button
    Friend WithEvents labelTimeChanged As Label
    Friend WithEvents Timer1 As Timer
End Class
