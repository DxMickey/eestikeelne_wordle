Public Class formWordList

    '"Sisesta" nupu vajutamisel
    Private Sub btnSisesta_Click(sender As Object, e As EventArgs) Handles btnSisesta.Click
        Dim data As IDatabase
        data = New CDatabase

        'Kontroll, ega tekstiväli tühi pole
        If txtCSVName.Text = Nothing Then
            MessageBox.Show("Nime kast ei tohi tühi olla")
        Else
            'Kui sellise nimega csv fail on leitud
            If System.IO.File.Exists(Application.StartupPath() & "\" & txtCSVName.Text & ".csv") Then
                'Kui on valitud 4-täheliste sõnade checkbox
                If rbtnLihtne.Checked Then
                    'Kontroll, ega sama nimega sõnade fail pole juba laetud andmebaasi teiste raskusastmete alla
                    If data.getItem("miscData", "customNormal") = txtCSVName.Text Or data.getItem("miscData", "customHard") = txtCSVName.Text Then
                        MessageBox.Show("Sellise nimega fail on juba laetud ühte kolmest listidest")
                    Else
                        'Eelmise kasutaja sõnade tabeli kustutamine andmebaasist ja uude tabelisse uute sõnade sisestamine csv failist
                        data.deleteTable(data.getItem("miscData", "customEasy"))
                        data.importCSV(txtCSVName.Text)
                        data.setItem("miscData", "customEasy", txtCSVName.Text)
                    End If

                    'Kui on valitud 5-täheliste sõnade checkbox
                ElseIf rbtnTavaline.Checked Then
                    'Kontroll, ega sama nimega sõnade fail pole juba laetud andmebaasi teiste raskusastmete alla
                    If data.getItem("miscData", "customEasy") = txtCSVName.Text Or data.getItem("miscData", "customHard") = txtCSVName.Text Then
                        MessageBox.Show("Sellise nimega fail on juba laetud ühte kolmest listidest")
                    Else
                        'Eelmise kasutaja sõnade tabeli kustutamine andmebaasist ja uude tabelisse uute sõnade sisestamine csv failist
                        data.deleteTable(data.getItem("miscData", "customNormal"))
                        data.importCSV(txtCSVName.Text)
                        data.setItem("miscData", "customNormal", txtCSVName.Text)
                    End If

                    'Kui on valitud 6-täheliste sõnade checkbox
                ElseIf rbtnRaske.Checked Then
                    'Kontroll, ega sama nimega sõnade fail pole juba laetud andmebaasi teiste raskusastmete alla
                    If data.getItem("miscData", "customNormal") = txtCSVName.Text Or data.getItem("miscData", "customEasy") = txtCSVName.Text Then
                        MessageBox.Show("Sellise nimega fail on juba laetud ühte kolmest listidest")
                    Else
                        'Eelmise kasutaja sõnade tabeli kustutamine andmebaasist ja uude tabelisse uute sõnade sisestamine csv failist
                        data.deleteTable(data.getItem("miscData", "customHard"))
                        data.importCSV(txtCSVName.Text)
                        data.setItem("miscData", "customHard", txtCSVName.Text)
                    End If

                End If
            Else
                MessageBox.Show("Sellise nimega CSV faili ei suuda leida")

            End If
        End If

    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        Dim data As IDatabase
        data = New CDatabase

        btnOff.Enabled = False
        btnOn.Enabled = True
        data.setItem("miscData", "customListState", "off")
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        Dim data As IDatabase
        data = New CDatabase

        btnOff.Enabled = True
        btnOn.Enabled = False
        data.setItem("miscData", "customListState", "on")
    End Sub

    Private Sub formWordList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As IDatabase
        data = New CDatabase

        btnOff.Enabled = False
        btnOn.Enabled = False
        changeLabelColors()

        If data.getItem("miscData", "customListState") = "off" Then
            btnOn.Enabled = True
        Else
            btnOff.Enabled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New formMenu
        Dim colors As IGraphics
        colors = New CGraphics

        newForm.TopLevel = False
        newForm.Parent = formContainer
        newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.BackColor = colors.backColor


        newForm.Show()
        Me.Close()
    End Sub

    Private Sub changeLabelColors()
        Dim colors As IGraphics
        colors = New CGraphics

        Label1.ForeColor = colors.lblColor
        Label2.ForeColor = colors.lblColor
        rbtnLihtne.ForeColor = colors.lblColor
        rbtnTavaline.ForeColor = colors.lblColor
        rbtnRaske.ForeColor = colors.lblColor
    End Sub
End Class