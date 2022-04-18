Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Public Class CSonaTahendus
    Implements ISonaTahendus
    Private Const sonaveebURL = "https://sonaveeb.ee/search/unif/dlall/dsall/"
    Private Const nettiPole = "Puudub võrguühendus :("
    Private Const sonaPole = "Selle sõnal pole tähendust!"
    Private strOutput = ""

    Public Function getSonaTahendus(ByRef sona As String) Implements ISonaTahendus.getSonaTahendus


        If Not hasNetworkConnection() Then
            Return nettiPole
        End If
        Return "Scraper pole valmis"
        'Try
        '    Me.scrapeWord(sona)
        'Catch ex As Exception
        '    Return sonaPole
        'End Try
        'Return strOutput
    End Function
    Private Function scrapeWord(sona)
        'Otsib valja sonale vastava URL-i ja proovib selle tahenduse valja saada
        'https://www.codeguru.com/visual-basic/creating-a-web-text-scraper-with-visual-basic/

        Dim reqURL = sonaveebURL & sona
        Dim webRes As WebResponse
        Dim webReq = HttpWebRequest.Create(sonaveebURL)

        Try
            webRes = webReq.GetResponse()
            Debug.WriteLine(webRes)

            'Loeb vastuse ja paneb muutujasse strOutput
            Using sr As New StreamReader(webRes.GetResponseStream())
                strOutput = sr.ReadToEnd()
                ' Close and clean up the StreamReader
                sr.Close()
            End Using


            If Len(Me.strOutput) > 0 Then
                parseHTMLforDefinition()
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try
        Return ""
    End Function
    Private Function parseHTMLforDefinition()
        'Formatting Techniques

        ' Remove Doctype ( HTML 5 )
        strOutput = Regex.Replace(strOutput, "<!(.|\s)*?>", "")

        ' Remove HTML Tags
        strOutput = Regex.Replace(strOutput, "</?[a-z][a-z0-9]*[^<>]*>", "")

        ' Remove HTML Comments
        strOutput = Regex.Replace(strOutput, "<!--(.|\s)*?-->", "")

        ' Remove Script Tags
        strOutput = Regex.Replace(strOutput, "<script.*?</script>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

        ' Remove Stylesheets
        strOutput = Regex.Replace(strOutput, "<style.*?</style>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

        Return strOutput
    End Function
    Private Function hasNetworkConnection()
        'Funktsioon, mis kontrollib kas on võrguühendus.
        'Proovib pingida google.com
        'Peaks tegema mingi utility komponendi 
        Return My.Computer.Network.Ping("www.google.com")
    End Function
End Class
