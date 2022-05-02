Imports System.Net
Imports System.IO
Public Class CSonaTahendus
    Implements ISonaTahendus

    Private Const sonaveebURL = "https://sonaveeb.ee/search/unif/dlall/dsall/"
    Private Const nettiPole = "Puudub võrguühendus :("
    Private Const sonaPole = "Selle sõnal pole tähendust!"

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

    Private Function parseHTMLforDefinition(str)
        'Formatting Techniques
        'Tagastab HTML-ist otsitava sõna
        Dim strOutput As String
        Try
            Dim htmlContent = New HtmlAgilityPack.HtmlDocument()
            htmlContent.LoadHtml(str)
            Dim dblQuote = """"
            'Valib saadud veebilehelt õige koha. Kasutab Xpath-i
            Dim span = htmlContent.DocumentNode.SelectNodes("//span[contains(@class, " &
                                                            dblQuote & "homonym-intro d-block" & dblQuote & ")]")
            strOutput = span(0).InnerText
        Catch ex As Exception
            Return "Ei suutnud tähendust leida"
        End Try
        Return strOutput
    End Function
    Private Async Function scrapeWordAsync(sona As String) As Task(Of String)
        'Otsib netist sõnatähenduse asünkroonselt
        Dim request As HttpWebRequest = WebRequest.Create(sonaveebURL & sona & "/1")
        request.Proxy = Nothing
        request.UseDefaultCredentials = True
        request.CookieContainer = New CookieContainer()
        Dim response As HttpWebResponse = Await request.GetResponseAsync()
        Dim response2 As StreamReader = New StreamReader(response.GetResponseStream)
        Dim htmlStr As String = response2.ReadToEnd()

        Dim def = parseHTMLforDefinition(htmlStr)
        Return def
    End Function
End Class
