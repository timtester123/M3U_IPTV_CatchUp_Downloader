Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1


    Public local_M3U As String = Path.GetTempPath() & "\M3U.m3u"
    Public local_EPG As String = Path.GetTempPath() & "\EPG.XML"
    Public EPG_XML As String


    'Form functions

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = Me.Text & " - v." & Application.ProductVersion

        'check for Update
        check_for_update(True)

        'load settings
        load_settings()

        TextBox_Filter.Focus()

        '

    End Sub

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing

        save_settings()

    End Sub

    Private Sub save_settings()
        My.Settings.EPG_URL = TextBox_EPG_URL.Text
        My.Settings.M3U_URL = TextBox_M3U_URL.Text
        My.Settings.DownloadPath = TextBox_Download_Path.Text
        My.Settings.offset_a = TextBox_offset_a.Text
        My.Settings.offset_b = TextBox_offset_b.Text
        My.Settings.Save()
    End Sub
    Private Sub load_settings()
        Dim M3U_URL As String = My.Settings.M3U_URL
        Dim EPG_URL As String = My.Settings.EPG_URL
        Dim DownloadPath As String = My.Settings.DownloadPath
        Dim offset_a As String = My.Settings.offset_a
        Dim offset_b As String = My.Settings.offset_b
        TextBox_EPG_URL.Text = EPG_URL
        TextBox_M3U_URL.Text = M3U_URL

        If DownloadPath = "" Then
            TextBox_Download_Path.Text = Application.StartupPath()
        Else
            TextBox_Download_Path.Text = DownloadPath
        End If

        If offset_a = "" Then
            TextBox_offset_a.Text = 2
        Else
            TextBox_offset_a.Text = offset_a
        End If
        If offset_b = "" Then
            TextBox_offset_b.Text = 2
        Else
            TextBox_offset_b.Text = offset_b
        End If




        M3U_URL_Download(TextBox_M3U_URL.Text)

    End Sub



    Private Sub Button_reload_Click(sender As Object, e As EventArgs) Handles Button_reload.Click


        ListBox_Backup.Items.Clear()
        ListBox.Items.Clear()
        TextBox_Filter.Text = ""
        TextBox_Filter.Visible = True
        Label_seeach.Visible = True
        Button_Download.Visible = False
        Button_show_TV.Visible = False
        Button_Play.Visible = False

        M3U_URL_Download(TextBox_M3U_URL.Text)
    End Sub



    Dim URLs As New List(Of String)
    Dim Namen As New List(Of String)
    Dim IDs As New List(Of String)
    Public Sub fill_ListBox(ByVal file As String)


        If (My.Computer.FileSystem.FileExists(file)) Then

            Dim FileText As String = My.Computer.FileSystem.ReadAllText(file).Replace(vbCr, "")
            If FileText.ToLower.Contains("tvg-id=""") = False Then 'check if M3U Plus
                MsgBox("Please use the m3u_plus file!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim FileText_lines As String() = FileText.Split(vbLf)
            For index = 1 To FileText_lines.Length - 1
                Dim line1 As String = FileText_lines(index)
                If line1.ToLower.StartsWith("#extinf:") Then
                    If line1.ToLower.Contains("tvg-id=""""") Then 'skip if no id
                        Continue For
                    End If

                    Dim line2 As String = FileText_lines(index + 1)

                    Dim NAME As String = ""
                    Dim URL As String = ""
                    Dim ID As String = ""

                    'URL
                    URL = line2.Replace(vbCrLf, "").Replace(vbCr, "")
                    URL = URL
                    'Nur TV
                    If URL.ToLower.Contains("/serie") = False And URL.ToLower.Contains("/movie") = False Then

                        'ID
                        ID = get_Field(line1, "tvg-id=")
                        'Name
                        NAME = get_Field(line1, "tvg-name=")

                        'Illegale Charakter entfernen
                        NAME = RemoveIllegalFileNameChars(NAME).Trim()


                        URLs.Add(URL)
                        Namen.Add(NAME)
                        IDs.Add(ID)
                        ListBox.Items.Add(NAME)
                        ListBox_Backup.Items.Add(NAME)
                    End If
                Else
                    Continue For
                End If
            Next
        Else
            TextBox_EPG_URL.Text = ""
            MsgBox("The Ffile doesn't exists!")
        End If

    End Sub
    'Filter
    Private Sub TextBox_Filter_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Filter.TextChanged
        'search
        Dim items = From it In ListBox_Backup.Items.Cast(Of Object)()
                    Where it.ToString().IndexOf(TextBox_Filter.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
        Dim matchingItemList As List(Of Object) = items.ToList()
        ListBox.BeginUpdate()
        ListBox.Items.Clear()
        For Each item In matchingItemList
            ListBox.Items.Add(item)
        Next
        ListBox.EndUpdate()
    End Sub


    Private Sub Button_Download_Click(sender As Object, e As EventArgs) Handles Button_Download.Click

        If My.Computer.FileSystem.DirectoryExists(TextBox_Download_Path.Text) = False Then
            MsgBox("Please check the download path: " & TextBox_Download_Path.Text)
            Exit Sub
        End If

        'Download
        If (ListBox.SelectedIndices.Count > 0) Then
            Button_cancel.Visible = True

            Dim title As String = ""
            Dim start_time_str As String = ""
            Dim name As String = ""
            'get URL
            Dim timeshift_URL As String = get_timeshift_URL(title, start_time_str, name)

            'Create Folder and download
            Dim folder As String = TextBox_Download_Path.Text & "\" & name
            My.Computer.FileSystem.CreateDirectory(folder)
            Dim DownloadFile As String = folder + "\" & RemoveIllegalFileNameChars(name & " - " & title + " - " & start_time_str, "") & ".mkv"


            'check if download already running
            For index = 0 To Downloads_URLS.Count - 1
                If Downloads_URLS(index) = timeshift_URL Then
                    MsgBox("Download of File: " & title & " already running!")
                    Exit Sub
                End If
            Next

            'append
            Downloads_URLS.Add(timeshift_URL)
            Downloads_DownloadFiles.Add(DownloadFile)
            total_files = Downloads_URLS.Count

            'if not active else only append
            If downloader.IsBusy = False Then
                downloader.DownloadFileAsync(New Uri(Downloads_URLS(0)), Downloads_DownloadFiles(0), Stopwatch.StartNew)
                akt_file = Path.GetFileName(Downloads_DownloadFiles(0))
            End If


        End If

    End Sub



    Private Sub Button_cancel_Click(sender As Object, e As EventArgs) Handles Button_cancel.Click

        'cancel
        downloader.CancelAsync()
        downloader.Dispose()

        Label_status.Text = "Download cancelled"
        left_files = 0
        Button_cancel.Visible = False


        For i = 0 To Downloads_URLS.Count - 1
            Downloads_URLS.RemoveAt(0)
        Next
        For i = 0 To Downloads_DownloadFiles.Count - 1
            Try
                'delete file
                If My.Computer.FileSystem.FileExists(Downloads_DownloadFiles(0)) Then
                    If downloader.IsBusy Then 'Wait a moment
                        System.Threading.Thread.Sleep(200)
                    End If
                    My.Computer.FileSystem.DeleteFile(Downloads_DownloadFiles(0))
                End If
            Catch ex As Exception
                MsgBox("Can't delete file, please delete manually")
            End Try
            Downloads_DownloadFiles.RemoveAt(0)
        Next
    End Sub


    Public WithEvents downloader As WebClient = New WebClient

    Dim Downloads_URLS As New List(Of String)
    Dim Downloads_DownloadFiles As New List(Of String)
    Dim total_files As Integer
    Dim left_files As Integer
    Dim akt_file As String

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        'status
        Label_status.Text = left_files & "/" & total_files & "    " & akt_file & "    " & e.ProgressPercentage & " %" & "    " & Math.Round(e.BytesReceived / 1000000, 2) & " MB / " & Math.Round(e.TotalBytesToReceive / 1000000, 2) & " MB" & "    " & (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000) / (1024 * 1024)).ToString("0.000 MB/s")
    End Sub
    Private Sub client_DownloadCompleted() Handles downloader.DownloadFileCompleted
        left_files = left_files + 1
        If Downloads_URLS.Count > 0 Then
            'Check if download success
            If My.Computer.FileSystem.GetFileInfo(Downloads_DownloadFiles(0)).Length = 0 Then
                My.Computer.FileSystem.DeleteFile(Downloads_DownloadFiles(0))
                MsgBox("No CatchUp available?")
            End If
            'Remove downloaded from queue
            Downloads_URLS.RemoveAt(0)
            Downloads_DownloadFiles.RemoveAt(0)
            'start next one
            If Downloads_URLS.Count > 0 Then
                akt_file = Path.GetFileName(Downloads_DownloadFiles(0))
                downloader.DownloadFileAsync(New Uri(Downloads_URLS(0)), Downloads_DownloadFiles(0), Stopwatch.StartNew)
            End If
        End If
        'complete
        If Downloads_URLS.Count = 0 Then
            Label_status.Text = "Download complete"
            Button_cancel.Visible = False
            left_files = 0
        End If
    End Sub


    Private Sub Button_Play_Click(sender As Object, e As EventArgs) Handles Button_Play.Click
        If (ListBox.SelectedIndices.Count > 0) Then
            'start vlc
            play_VLC()
        End If
    End Sub


    Public Function get_timeshift_URL(ByRef title As String, ByRef start_time_str As String, ByRef name As String) As String
        name = Namen(selected_channel_Nr)
        Dim URL As String = URLs(selected_channel_Nr)

        ''channel Nr
        'Dim channel_Nr As String = URL.Substring(URL.LastIndexOf("/") + 1, URL.Length - URL.LastIndexOf("/") - 1)
        'channel_Nr = channel_Nr.ToLower.Replace(".m3u8", "").Replace(".m3u", "")
        'URL = URL.Substring(0, URL.LastIndexOf("/"))
        ''PW
        'Dim PW As String = URL.Substring(URL.LastIndexOf("/") + 1, URL.Length - URL.LastIndexOf("/") - 1)
        'URL = URL.Substring(0, URL.LastIndexOf("/"))
        ''User
        'Dim USER As String = URL.Substring(URL.LastIndexOf("/") + 1, URL.Length - URL.LastIndexOf("/") - 1)
        'Dim base_URL As String = URL.Substring(0, URL.LastIndexOf("/"))
        ''remove if something behind the port
        'If base_URL.LastIndexOf("/") > base_URL.LastIndexOf(":") Then
        '    base_URL = base_URL.Substring(0, base_URL.IndexOf("/", base_URL.LastIndexOf(":")))
        'End If

        Dim channel_Nr As String = ""
        Dim USER As String = ""
        Dim PW As String = ""
        Dim base_URL As String = ""
        get_User_PW_Channel(channel_Nr, base_URL, USER, PW, URL)

        Dim offset_a As Integer = TextBox_offset_a.Text
        Dim offset_b As Integer = TextBox_offset_b.Text

        'EPG Data
        Dim start_time As DateTime = startTime(ListBox.SelectedIndex)
        start_time = start_time.AddMinutes(offset_b * -1) ' start x minutes before
        Dim stop_time As DateTime = stopTime(ListBox.SelectedIndex)
        title = Titles(ListBox.SelectedIndex)
        Dim elapsedTime As TimeSpan = DateTime.Parse(stop_time).Subtract(start_time)
        Dim elapsedTime_min As Integer = elapsedTime.TotalMinutes + offset_b '  x minutes after
        start_time_str = start_time.ToString("yyyy-MM-dd:HH-mm")
        'CatchUp URL
        Dim timeshift_URL As String = base_URL & "/streaming/timeshift.php?username=" & USER & "&password=" & PW & "&stream=" & channel_Nr & "&start=" & start_time_str & "&duration=" & elapsedTime_min

        Return timeshift_URL
    End Function



    Public Sub get_User_PW_Channel(ByRef channel_Nr As String, ByRef base_URL As String, ByRef USER As String, ByRef PW As String, ByVal URL As String)
        'channel Nr
        channel_Nr = URL.Substring(URL.LastIndexOf("/") + 1, URL.Length - URL.LastIndexOf("/") - 1)
        channel_Nr = channel_Nr.ToLower.Replace(".m3u8", "").Replace(".m3u", "")
        URL = URL.Substring(0, URL.LastIndexOf("/"))
        'PW
        PW = URL.Substring(URL.LastIndexOf("/") + 1, URL.Length - URL.LastIndexOf("/") - 1)
        URL = URL.Substring(0, URL.LastIndexOf("/"))
        'User
        USER = URL.Substring(URL.LastIndexOf("/") + 1, URL.Length - URL.LastIndexOf("/") - 1)
        base_URL = URL.Substring(0, URL.LastIndexOf("/"))
        'remove if something behind the port
        If base_URL.LastIndexOf("/") > base_URL.LastIndexOf(":") Then
            base_URL = base_URL.Substring(0, base_URL.IndexOf("/", base_URL.LastIndexOf(":")))
        End If
    End Sub






    Dim Titles As New List(Of String)
    Dim startTime As New List(Of DateTime)
    Dim stopTime As New List(Of DateTime)

    Dim selected_channel_Nr As String

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        If Button_show_TV.Visible Then 'Show Dowload
            Button_Download.Visible = True
            Button_Play.Visible = True
            Exit Sub
        End If
        If ListBox.SelectedIndices.Count = 0 Then 'nothing selecteds
            Exit Sub
        End If
        If EPG_XML = "" Then 'XML empty
            MsgBox("EPG Download not complete, please try again")
            ListBox.ClearSelected()
            Exit Sub
        End If

        'clear
        For i = 0 To Titles.Count - 1
            Titles.RemoveAt(0)
        Next
        For i = 0 To startTime.Count - 1
            startTime.RemoveAt(0)
        Next
        For i = 0 To stopTime.Count - 1
            stopTime.RemoveAt(0)
        Next

        'selektierten Eintrag
        Dim selectedItem As String = ListBox.SelectedItem.ToString
        Dim ID As String = ""
        For x = 0 To Namen.Count - 1
            If Namen(x) = selectedItem Then
                ID = IDs(x)
                selected_channel_Nr = x
                Exit For
            End If
        Next


        'EPG laden
        Dim EPG As XDocument = XDocument.Parse(EPG_XML)

        'selektierten Sender EPG laden
        For Each elem As XElement In EPG.Descendants
            If elem.Name.ToString.ToLower = "programme" Then
                If elem.Attribute("channel").Value.ToString.ToLower = ID.ToLower Then 'ID suchen
                    For Each elem_child As XElement In elem.Descendants
                        If elem_child.Name.ToString.ToLower = "title" Then
                            Titles.Add(elem_child.Value.ToString) 'Title
                            startTime.Add(convert_to_DateTime(elem.Attribute("start").Value.ToString)) 'Start Time
                            stopTime.Add(convert_to_DateTime(elem.Attribute("stop").Value.ToString)) 'Stop Time
                            Exit For
                        End If
                    Next
                End If
            End If
        Next

        'insert in Listbox
        ListBox.Items.Clear()
        For i = 0 To Titles.Count - 1
            ListBox.Items.Add(startTime(i).ToString & " | " & stopTime(i).ToString & " | " & Titles(i))
        Next

        'back button
        Button_show_TV.Visible = True
        Label_seeach.Visible = False
        TextBox_Filter.Visible = False

    End Sub

    'insert Backup in Listbox
    Private Sub Button_show_TV_Click(sender As Object, e As EventArgs) Handles Button_show_TV.Click
        ListBox.Items.Clear()
        ListBox.Items.AddRange(ListBox_Backup.Items)
        TextBox_Filter.Text = ""
        Button_show_TV.Visible = False
        Button_Download.Visible = False
        Button_Play.Visible = False
        Label_seeach.Visible = True
        TextBox_Filter.Visible = True
        TextBox_Filter.Focus()
    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        Process.Start("https://timtester.in/donate/")
    End Sub

    Private Sub CheckForUpdateOnGitHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateOnGitHubToolStripMenuItem.Click

        check_for_update(False)

    End Sub

    Private Sub Button_choose_Download_path_Click(sender As Object, e As EventArgs) Handles Button_choose_Download_path.Click
        FolderBrowserDialog_DownloadPath.ShowDialog()
        Dim DownloadPath As String = FolderBrowserDialog_DownloadPath.SelectedPath
        TextBox_Download_Path.Text = DownloadPath
    End Sub

    Private Sub TextBox_offset_b_TextChanged(sender As Object, e As EventArgs) Handles TextBox_offset_b.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox_offset_b.Text = digitsOnly.Replace(TextBox_offset_b.Text, "")
    End Sub

    Private Sub TextBox_offset_a_TextChanged(sender As Object, e As EventArgs) Handles TextBox_offset_a.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox_offset_a.Text = digitsOnly.Replace(TextBox_offset_a.Text, "")
    End Sub
End Class
