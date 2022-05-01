<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formExportCSV
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
        Me.txtDelimiter = New System.Windows.Forms.TextBox()
        Me.txtTextQualifier = New System.Windows.Forms.TextBox()
        Me.cmbAppend = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
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
        Me.btnExport.Location = New System.Drawing.Point(125, 251)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Ekspordi"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'formExportCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 322)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAppend)
        Me.Controls.Add(Me.txtTextQualifier)
        Me.Controls.Add(Me.txtDelimiter)
        Me.Name = "formExportCSV"
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
End Class
