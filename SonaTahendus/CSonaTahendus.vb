Imports System.Text
Imports System.Net
Imports System.IO
Public Class CSonaTahendus
    Implements ISonaTahendus
    Private Const sonaveebURL = "https://sonaveeb.ee/search/unif/dlall/dsall/"
    Private Const nettiPole = "Puudub võrguühendus :("
    Private Const sonaPole = "Selle sõnal pole tähendust!"
    Private strOutput = ""

    Public Function getSonaTahendus(ByRef sona As String) Implements ISonaTahendus.getSonaTahendus

        sona = LCase(sona)
        If Not hasNetworkConnection() Then
            Return nettiPole
        Else
            Try
                Dim tahendus = scrapeWord(sona)
                Return tahendus
            Catch ex As Exception
                Return "Ei leidnud tähendust " & vbCrLf & "https://sonaveeb.ee/search/unif/dlall/dsall/" & sona & "/1"
            End Try
        End If
        Return "Midagi läks katki"
    End Function
    Private Function scrapeWord(sona)
        'Otsib valja sonale vastava URL-i ja proovib selle tahenduse valja saada
        'https://www.codeguru.com/visual-basic/creating-a-web-text-scraper-with-visual-basic/



        Dim request As HttpWebRequest = WebRequest.Create("https://sonaveeb.ee/search/unif/dlall/dsall/" & sona & "/1")
        request.Proxy = Nothing
        request.UseDefaultCredentials = True
        request.CookieContainer = New CookieContainer()
        Dim response As HttpWebResponse = request.GetResponse()
        Dim response2 As StreamReader = New StreamReader(response.GetResponseStream)
        Dim str As String = response2.ReadToEnd()
        Dim jk = parseHTMLforDefinition(str)

        Return jk
    End Function
    Private Function parseHTMLforDefinition(ByVal str)
        'Formatting Techniques
        'Peaks tagstama true or false ja strout panem komponendi tippu
        Dim strOutput As String
        Try
            Dim htmlContent = New HtmlAgilityPack.HtmlDocument()
            htmlContent.LoadHtml(str)
            Dim dblQuote = """"
            Dim span = htmlContent.DocumentNode.SelectNodes("//span[contains(@class, " &
                                                            dblQuote & "homonym-intro d-block" & dblQuote & ")]")
            strOutput = span(0).InnerText

        Catch ex As Exception
            Return "Ei suutnud tähendust leida"
        End Try
        Return strOutput
    End Function
    Private Function hasNetworkConnection()
        'Funktsioon, mis kontrollib kas on võrguühendus.
        'Proovib pingida google.com
        'Peaks tegema mingi utility komponendi 
        Return My.Computer.Network.Ping("www.google.com")
    End Function
End Class
