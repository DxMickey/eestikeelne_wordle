<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGameSettings
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
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.btnNoTime = New System.Windows.Forms.Button()
        Me.btnTimed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEasy
        '
        Me.btnEasy.Location = New System.Drawing.Point(155, 187)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(75, 23)
        Me.btnEasy.TabIndex = 0
        Me.btnEasy.Text = "Lihtne"
        Me.btnEasy.UseVisualStyleBackColor = True
        '
        'btnNormal
        '
        Me.btnNormal.Location = New System.Drawing.Point(317, 187)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(75, 23)
        Me.btnNormal.TabIndex = 1
        Me.btnNormal.Text = "Tavaline"
        Me.btnNormal.UseVisualStyleBackColor = True
        '
        'btnHard
        '
        Me.btnHard.Location = New System.Drawing.Point(479, 187)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(75, 23)
        Me.btnHard.TabIndex = 2
        Me.btnHard.Text = "Raske"
        Me.btnHard.UseVisualStyleBackColor = True
        '
        'btnNoTime
        '
        Me.btnNoTime.Location = New System.Drawing.Point(236, 187)
        Me.btnNoTime.Name = "btnNoTime"
        Me.btnNoTime.Size = New System.Drawing.Size(75, 23)
        Me.btnNoTime.TabIndex = 3
        Me.btnNoTime.Text = "Ilma ajata"
        Me.btnNoTime.UseVisualStyleBackColor = True
        '
        'btnTimed
        '
        Me.btnTimed.Location = New System.Drawing.Point(398, 187)
        Me.btnTimed.Name = "btnTimed"
        Me.btnTimed.Size = New System.Drawing.Size(75, 23)
        Me.btnTimed.TabIndex = 4
        Me.btnTimed.Text = "Ajaline"
        Me.btnTimed.UseVisualStyleBackColor = True
        '
        'formGameSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.btnTimed)
        Me.Controls.Add(Me.btnNoTime)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnNormal)
        Me.Controls.Add(Me.btnEasy)
        Me.Name = "formGameSettings"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEasy As Button
    Friend WithEvents btnNormal As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents btnNoTime As Button
    Friend WithEvents btnTimed As Button
End Class
