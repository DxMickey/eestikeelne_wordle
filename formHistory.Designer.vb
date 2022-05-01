<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formHistory
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
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.dtgDatagrid = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.UcMusicPlayer1 = New TaustaMuusika.UCMusicPlayer()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        Me.saveDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dtgDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(350, 9)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(32, 537)
        Me.VScrollBar1.TabIndex = 0
        '
        'dtgDatagrid
        '
        Me.dtgDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatagrid.Location = New System.Drawing.Point(12, 12)
        Me.dtgDatagrid.Name = "dtgDatagrid"
        Me.dtgDatagrid.Size = New System.Drawing.Size(660, 669)
        Me.dtgDatagrid.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(287, 706)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(552, 706)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(95, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Ekspordi JSON"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'UcMusicPlayer1
        '
        Me.UcMusicPlayer1.Location = New System.Drawing.Point(12, 723)
        Me.UcMusicPlayer1.Name = "UcMusicPlayer1"
        Me.UcMusicPlayer1.Size = New System.Drawing.Size(58, 26)
        Me.UcMusicPlayer1.TabIndex = 4
        '
        'btnExportCSV
        '
        Me.btnExportCSV.Location = New System.Drawing.Point(451, 706)
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Size = New System.Drawing.Size(95, 23)
        Me.btnExportCSV.TabIndex = 5
        Me.btnExportCSV.Text = "Ekspordi CSV"
        Me.btnExportCSV.UseVisualStyleBackColor = True
        '
        'formHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.btnExportCSV)
        Me.Controls.Add(Me.UcMusicPlayer1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dtgDatagrid)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Name = "formHistory"
        Me.Text = "Form1"
        CType(Me.dtgDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents dtgDatagrid As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents UcMusicPlayer1 As TaustaMuusika.UCMusicPlayer
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents saveDialog1 As SaveFileDialog
End Class
