Public Class formExportCSV
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase
        Dim append = If(cmbAppend.SelectedItem = "Kirjuta üle", False, True)
        If cbSave.Checked = True Then
            data.exportCSV(txtDelimiter.Text, txtTextQualifier.Text, append, True)
        Else
            data.exportCSV(txtDelimiter.Text, txtTextQualifier.Text, append, False)
        End If

        Dim savePath = data.getItem("miscData", "savePath")
        If savePath <> "none" Then
            lblSavePath.Text = "Valitud fail:" & savePath
            lblSavePath.Visible = True
        Else
            lblSavePath.Visible = False
        End If

    End Sub

    Private Sub formExportCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colors As IGraphics
        colors = New CGraphics


        cmbAppend.SelectedItem = "Kirjuta üle"
        Label1.ForeColor = colors.lblColor
        Label2.ForeColor = colors.lblColor
        Label3.ForeColor = colors.lblColor
    End Sub

    Private Sub formExportCSV_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        lblSavePath.Visible = False

        Dim savePath = data.getItem("miscData", "savePath")
        If savePath <> "none" Then
            lblSavePath.Text = "Valitud fail:" & savePath
            lblSavePath.Visible = True
            cbSave.Checked = True
        End If
    End Sub

End Class