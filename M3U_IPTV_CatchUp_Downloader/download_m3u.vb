Imports System.Net

Module download


    Private WithEvents downloader_M3U As WebClient


    'M3U Download
    Public Sub M3U_URL_Download(ByVal M3U_URL As String)
        Try


            If M3U_URL <> "" Then
                'If (M3U_URL.ToLower.Contains("m3u_plus") = False) Then
                '    MsgBox("Please use the m3u_plus file!")
                '    Exit Sub
                'End If
                downloader_M3U = New WebClient
                downloader_M3U.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath() & "\Downloads")
                downloader_M3U.DownloadFileAsync(New Uri(M3U_URL), Form1.local_M3U, Stopwatch.StartNew)
            End If
        Catch ex As Exception
            MsgBox("Please check your M3U URL")
        End Try
    End Sub

    'M3U Download complete
    Private Sub client_DownloadCompleted_M3U() Handles downloader_M3U.DownloadFileCompleted


        download_epg.EPG_URL_Download(Form1.TextBox_EPG_URL.Text)

        If My.Computer.FileSystem.FileExists(Form1.local_M3U) Then
            Form1.fill_ListBox(Form1.local_M3U)
        End If
    End Sub


    Private Sub client_DownloadCompleted_M3U_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader_M3U.DownloadProgressChanged
        Form1.ProgressBar1.Value = e.ProgressPercentage
        'status
        Form1.Label_status.Text = "Downloading M3U    " & e.ProgressPercentage & " %" & "    " & Math.Round(e.BytesReceived / 1000000, 2) & " MB / " & Math.Round(e.TotalBytesToReceive / 1000000, 2) & " MB" & "    " & (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000) / (1024 * 1024)).ToString("0.000 MB/s")
    End Sub
End Module
