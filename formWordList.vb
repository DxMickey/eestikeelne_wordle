Public Class formWordList

    '"Sisesta" nupu vajutamisel
    Private Sub btnSisesta_Click(sender As Object, e As EventArgs) Handles btnSisesta.Click
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        openDialog1.Filter = "CSV|*.csv"
        openDialog1.Title = "Vali CSV fail"
        openDialog1.ShowDialog()


        Dim location As String = openDialog1.FileName

        'Kui sellise nimega csv fail on leitud
        If System.IO.File.Exists(location) Then
            'Kui on valitud 4-täheliste sõnade checkbox
            If rbtnLihtne.Checked Then

                'Eelmise kasutaja sõnade tabeli kustutamine andmebaasist ja uude tabelisse uute sõnade sisestamine csv failist
                data.deleteTable("customEasy")
                data.importCSV(location, 4)


                'Kui on valitud 5-täheliste sõnade checkbox
            ElseIf rbtnTavaline.Checked Then

                'Eelmise kasutaja sõnade tabeli kustutamine andmebaasist ja uude tabelisse uute sõnade sisestamine csv failist
                data.deleteTable("customNormal")
                data.importCSV(location, 5)



                'Kui on valitud 6-täheliste sõnade checkbox
            ElseIf rbtnRaske.Checked Then

                'Eelmise kasutaja sõnade tabeli kustutamine andmebaasist ja uude tabelisse uute sõnade sisestamine csv failist
                data.deleteTable("customHard")
                data.importCSV(location, 6)



            End If
        Else
            MessageBox.Show("Sellist CSV faili ei suuda leida")

        End If

    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        If btnOnOff.Text = "Lülita sisse" Then
            data.setItem("miscData", "customListState", "on")
            btnOnOff.Text = "Lülita välja"
        Else
            data.setItem("miscData", "customListState", "off")
            btnOnOff.Text = "Lülita sisse"
        End If
    End Sub

    Private Sub formWordList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim data As Andmekiht.IDatabase
        data = New Andmekiht.CDatabase

        changeLabelColors()
        rbtnLihtne.Checked = True

        If data.getItem("miscData", "customListState") = "off" Then
            btnOnOff.Text = "Lülita sisse"
        Else
            btnOnOff.Text = "Lülita välja"
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
        rbtnLihtne.ForeColor = colors.lblColor
        rbtnTavaline.ForeColor = colors.lblColor
        rbtnRaske.ForeColor = colors.lblColor
    End Sub

End Class