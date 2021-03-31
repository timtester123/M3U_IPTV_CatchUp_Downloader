Imports System.Net

Module download_epg


    Private WithEvents downloader_EPG As WebClient


    'EPG  functions

    'EPG Download
    Public Sub EPG_URL_Download(ByVal EPG_URL As String)
        Try
            If EPG_URL <> "" Then
                downloader_EPG = New WebClient
                downloader_EPG.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath() & "\Downloads")
                downloader_EPG.DownloadFileAsync(New Uri(EPG_URL), Form1.local_EPG, Stopwatch.StartNew)
            End If
        Catch ex As Exception
            MsgBox("Please check your EPG URL")
        End Try

    End Sub

    'EPG Download complete
    Private Sub client_DownloadCompleted_EPG() Handles downloader_EPG.DownloadFileCompleted
        Form1.Label_status.Text = "Downloading files complete, please choose your TV program"

        Try
            Form1.EPG_XML = My.Computer.FileSystem.ReadAllText(Form1.local_EPG)
        Catch ex As Exception
            MsgBox("Please check your EPG URL")
        End Try

    End Sub

    Private Sub client_DownloadCompleted_EPG_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader_EPG.DownloadProgressChanged
        Form1.ProgressBar1.Value = e.ProgressPercentage
        'status
        Form1.Label_status.Text = "Downloading EPG    " & e.ProgressPercentage & " %" & "    " & Math.Round(e.BytesReceived / 1000000, 2) & " MB / " & Math.Round(e.TotalBytesToReceive / 1000000, 2) & " MB" & "    " & (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000) / (1024 * 1024)).ToString("0.000 MB/s")

    End Sub



End Module
