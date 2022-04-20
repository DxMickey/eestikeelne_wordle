Public Class CUtils
    Implements IUtils

    Public Function isNetworkConnection() As Boolean Implements IUtils.isNetworkConnection
        'Funktsioon, mis kontrollib kas on võrguühendus.
        'Proovib pingida google.com
        'Peaks tegema mingi utility komponendi 
        Return My.Computer.Network.Ping("www.google.com")
    End Function

    Public Function secondsToTimeString(ByRef seconds As Integer, Optional msgString As String = "") As String Implements IUtils.secondsToTimeString
        'muudab sekundites antud arvu loetavaks stringiks
        'sisend võib olla int või str, muundatakse nkn stringiks
        Debug.WriteLine(seconds)
        Dim days = seconds \ (3600 * 24)
        seconds = seconds - (days * 3600 * 24)
        Dim hours = seconds \ 3600
        seconds = seconds - (hours * 3600)
        Dim minutes = seconds \ 60
        seconds = seconds - (minutes * 60)
        Debug.WriteLine(days, hours, minutes)
        Dim s = getTimestring(days, hours, minutes, seconds)
        Debug.WriteLine(s)
        Return s
    End Function
    Private Function getTimestring(ByRef days, hours, minutes, seconds)
        'Võtab sisendina päevad, tunnid, minutid 
        'tagastab loetava stringi.

        'msgString tagastakse siis, kui aeg on 0 või vähem
        Dim infoString = ""
        If hours <= 0 And minutes <= 0 And days <= 0 Then
            'kui aeg on 0 või jookseb miinuses misiganes põhjusel
            'siis lisatakse optsionaale msgString tagastatavasse str-i
            infoString = "" 'msgString
        End If
        'ajaühik_str = { str_ainsuses, str_mitmuses,tühi string}
        Dim d_string = {" Päev, ", " Päeva, ", ""}
        Dim h_string = {" tund, ", " tundi, ", ""}
        Dim m_string = {" minut, ", " minutit, ", ""}
        Dim s_string = {" sekund.", " sekundit", ""}

        'tagastatav stringide kombinatsioon 0-ainsus, 1-mitmus, 2-tühi
        Dim strSet = {1, 1, 1, 1}

        'Stringideks convertimine, et väljastus oleks lihtsam
        Dim d_val_str = Convert.ToString(days)
        Dim h_val_str = Convert.ToString(hours)
        Dim m_val_str = Convert.ToString(minutes)
        Dim s_val_str = Convert.ToString(seconds)
        'Kontroll, kas ainsust vaja.
        If days = 1 Then
            strSet(0) = 0 'vali ainsus
        ElseIf days <= 0 Then
            strSet(0) = 2 'vali tühi string
            d_val_str = ""
        End If

        'sama põhimõte kõigil if plokkidel
        If hours = 1 Then
            strSet(1) = 0
        ElseIf hours <= 0 Then
            strSet(1) = 2
            h_val_str = ""
        End If

        If minutes = 1 Then
            strSet(2) = 0
        ElseIf minutes <= 0 Then
            strSet(2) = 2
            m_val_str = ""
        End If

        If seconds = 1 Then
            strSet(3) = 0
        ElseIf seconds <= 0 Then
            strSet(3) = 2
            s_val_str = ""
        End If

        Return d_val_str & d_string(strSet(0)) _
            & h_val_str & h_string(strSet(1)) _
            & m_val_str & m_string(strSet(2)) _
            & s_val_str & s_string(strSet(3)) _
            & infoString
    End Function
End Class
