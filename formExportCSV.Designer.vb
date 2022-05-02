<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formExportCSV
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
        Me.txtDelimiter = New System.Windows.Forms.TextBox()
        Me.txtTextQualifier = New System.Windows.Forms.TextBox()
        Me.cmbAppend = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.cbSave = New System.Windows.Forms.CheckBox()
        Me.lblSavePath = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDelimiter
        '
        Me.txtDelimiter.Location = New System.Drawing.Point(28, 81)
        Me.txtDelimiter.Name = "txtDelimiter"
        Me.txtDelimiter.Size = New System.Drawing.Size(121, 20)
        Me.txtDelimiter.TabIndex = 0
        '
        'txtTextQualifier
        '
        Me.txtTextQualifier.Location = New System.Drawing.Point(28, 135)
        Me.txtTextQualifier.Name = "txtTextQualifier"
        Me.txtTextQualifier.Size = New System.Drawing.Size(121, 20)
        Me.txtTextQualifier.TabIndex = 1
        '
        'cmbAppend
        '
        Me.cmbAppend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAppend.FormattingEnabled = True
        Me.cmbAppend.Items.AddRange(New Object() {"Kirjuta üle", "Lisa faili lõppu"})
        Me.cmbAppend.Location = New System.Drawing.Point(28, 191)
        Me.cmbAppend.Name = "cmbAppend"
        Me.cmbAppend.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppend.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Määra väljade eraldaja. Vaikimisi „:""."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(25, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Määra teksti kvalifikaator (eraldustunnus)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(25, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kas kirjutada fail üle või lisada lõppu"
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnExport.Location = New System.Drawing.Point(113, 262)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(103, 36)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Ekspordi"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'cbSave
        '
        Me.cbSave.AutoSize = True
        Me.cbSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cbSave.Location = New System.Drawing.Point(28, 224)
        Me.cbSave.Name = "cbSave"
        Me.cbSave.Size = New System.Drawing.Size(161, 21)
        Me.cbSave.TabIndex = 7
        Me.cbSave.Text = "Jäta meelde faili valik"
        Me.cbSave.UseVisualStyleBackColor = True
        '
        'lblSavePath
        '
        Me.lblSavePath.AutoSize = True
        Me.lblSavePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblSavePath.Location = New System.Drawing.Point(12, 248)
        Me.lblSavePath.Name = "lblSavePath"
        Me.lblSavePath.Size = New System.Drawing.Size(58, 13)
        Me.lblSavePath.TabIndex = 8
        Me.lblSavePath.Text = "Valitud fail:"
        '
        'formExportCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 322)
        Me.Controls.Add(Me.lblSavePath)
        Me.Controls.Add(Me.cbSave)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAppend)
        Me.Controls.Add(Me.txtTextQualifier)
        Me.Controls.Add(Me.txtDelimiter)
        Me.Name = "formExportCSV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSV Eksportimise seaded"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDelimiter As TextBox
    Friend WithEvents txtTextQualifier As TextBox
    Friend WithEvents cmbAppend As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents cbSave As CheckBox
    Friend WithEvents lblSavePath As Label
End Class