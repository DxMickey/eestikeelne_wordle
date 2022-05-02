Imports System.Text
Imports System.Net
Imports System.IO
Public Class CSonaTahendus
    Implements ISonaTahendus

    Private Const sonaveebURL = "https://sonaveeb.ee/search/unif/dlall/dsall/"
    Private Const nettiPole = "Puudub võrguühendus :("
    Private Const sonaPole = "Selle sõnal pole tähendust!"
    Private strOutput = ""

    Public Function getSonaTahendusAsync(ByRef sona As String) Implements ISonaTahendus.getSonaTahendusAsync
        Dim tahendus As Task(Of String) 'Webresponse jaoks
        sona = LCase(sona)
        Dim utils As Utils.IUtils = New Utils.CUtils
        If Not utils.isNetworkConnection() Then
            Return nettiPole
        End If
        Try
            tahendus = scrapeWordAsync(sona)
        Catch ex As Exception
            Return "Ei leidnud tähendust " & vbCrLf & "https://sonaveeb.ee/search/unif/dlall/dsall/" & sona & "/1"
        End Try
        If tahendus Is Nothing Then
            Return "Midagi läks katki :("
        End If
        Return tahendus


    End Function
    Private Function scrapeWord(sona)

        'Otsib valja sonale vastava URL-i ja proovib selle tahenduse valja saada
        'https://www.codeguru.com/visual-basic/creating-a-web-text-scraper-with-visual-basic/
        Try

            Dim request As HttpWebRequest = WebRequest.Create(sonaveebURL & sona & "/1")
            request.Proxy = Nothing
            request.UseDefaultCredentials = True
            request.CookieContainer = New CookieContainer()
            Dim response As HttpWebResponse = request.GetResponse()
            Dim response2 As StreamReader = New StreamReader(response.GetResponseStream)
            Dim str As String = response2.ReadToEnd()
            Dim jk = parseHTMLforDefinition(str)

            Return jk
        Catch ex As Exception
            Return ex
        End Try


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
    Private Async Function scrapeWordAsync(sona As String) As Task(Of String)
        Dim request As HttpWebRequest = WebRequest.Create(sonaveebURL & sona & "/1")
        request.Proxy = Nothing
        request.UseDefaultCredentials = True
        request.CookieContainer = New CookieContainer()
        Dim response As HttpWebResponse = Await request.GetResponseAsync()
        Dim response2 As StreamReader = New StreamReader(response.GetResponseStream)
        Dim str As String = response2.ReadToEnd()
        Dim jk = parseHTMLforDefinition(str)

        Return jk
    End Function
End Class
