<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox_Backup = New System.Windows.Forms.ListBox()
        Me.TextBox_EPG_URL = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_M3U_URL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_reload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_TimeZone_offset = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_offset_a = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_offset_b = New System.Windows.Forms.TextBox()
        Me.Button_choose_Download_path = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Download_Path = New System.Windows.Forms.TextBox()
        Me.Button_Download = New System.Windows.Forms.Button()
        Me.TextBox_Filter = New System.Windows.Forms.TextBox()
        Me.Label_seeach = New System.Windows.Forms.Label()
        Me.Button_Play = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Button_show_TV = New System.Windows.Forms.Button()
        Me.Button_cancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdateOnGitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog_DownloadPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_Backup
        '
        Me.ListBox_Backup.FormattingEnabled = True
        Me.ListBox_Backup.ItemHeight = 20
        Me.ListBox_Backup.Location = New System.Drawing.Point(1120, 1080)
        Me.ListBox_Backup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox_Backup.Name = "ListBox_Backup"
        Me.ListBox_Backup.Size = New System.Drawing.Size(32, 44)
        Me.ListBox_Backup.TabIndex = 11
        Me.ListBox_Backup.Visible = False
        '
        'TextBox_EPG_URL
        '
        Me.TextBox_EPG_URL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_EPG_URL.Location = New System.Drawing.Point(213, 85)
        Me.TextBox_EPG_URL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_EPG_URL.Name = "TextBox_EPG_URL"
        Me.TextBox_EPG_URL.Size = New System.Drawing.Size(816, 26)
        Me.TextBox_EPG_URL.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 232)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1164, 35)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label_status
        '
        Me.Label_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_status.AutoSize = True
        Me.Label_status.BackColor = System.Drawing.Color.Transparent
        Me.Label_status.Location = New System.Drawing.Point(26, 272)
        Me.Label_status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(36, 20)
        Me.Label_status.TabIndex = 4
        Me.Label_status.Text = "0 %"
        Me.Label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "EPG URL:"
        '
        'TextBox_M3U_URL
        '
        Me.TextBox_M3U_URL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_M3U_URL.Location = New System.Drawing.Point(213, 29)
        Me.TextBox_M3U_URL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_M3U_URL.Name = "TextBox_M3U_URL"
        Me.TextBox_M3U_URL.Size = New System.Drawing.Size(816, 26)
        Me.TextBox_M3U_URL.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "M3U URL:"
        '
        'Button_reload
        '
        Me.Button_reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_reload.Location = New System.Drawing.Point(1040, 29)
        Me.Button_reload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_reload.Name = "Button_reload"
        Me.Button_reload.Size = New System.Drawing.Size(140, 95)
        Me.Button_reload.TabIndex = 3
        Me.Button_reload.Text = "load / reload"
        Me.Button_reload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox_TimeZone_offset)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_offset_a)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_offset_b)
        Me.GroupBox1.Controls.Add(Me.Button_choose_Download_path)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_Download_Path)
        Me.GroupBox1.Controls.Add(Me.Button_reload)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_M3U_URL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label_status)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.TextBox_EPG_URL)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1192, 302)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(520, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "TimeZone offset in hours (+ / -) :"
        '
        'TextBox_TimeZone_offset
        '
        Me.TextBox_TimeZone_offset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_TimeZone_offset.Location = New System.Drawing.Point(881, 185)
        Me.TextBox_TimeZone_offset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_TimeZone_offset.Name = "TextBox_TimeZone_offset"
        Me.TextBox_TimeZone_offset.Size = New System.Drawing.Size(31, 26)
        Me.TextBox_TimeZone_offset.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(373, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "after:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(209, 188)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "before:"
        '
        'TextBox_offset_a
        '
        Me.TextBox_offset_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_offset_a.Location = New System.Drawing.Point(443, 185)
        Me.TextBox_offset_a.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_offset_a.Name = "TextBox_offset_a"
        Me.TextBox_offset_a.Size = New System.Drawing.Size(31, 26)
        Me.TextBox_offset_a.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Offset (minutes)"
        '
        'TextBox_offset_b
        '
        Me.TextBox_offset_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_offset_b.Location = New System.Drawing.Point(311, 185)
        Me.TextBox_offset_b.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_offset_b.Name = "TextBox_offset_b"
        Me.TextBox_offset_b.Size = New System.Drawing.Size(31, 26)
        Me.TextBox_offset_b.TabIndex = 13
        '
        'Button_choose_Download_path
        '
        Me.Button_choose_Download_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_choose_Download_path.Location = New System.Drawing.Point(1040, 134)
        Me.Button_choose_Download_path.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_choose_Download_path.Name = "Button_choose_Download_path"
        Me.Button_choose_Download_path.Size = New System.Drawing.Size(135, 40)
        Me.Button_choose_Download_path.TabIndex = 12
        Me.Button_choose_Download_path.Text = "choose"
        Me.Button_choose_Download_path.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Download Path:"
        '
        'TextBox_Download_Path
        '
        Me.TextBox_Download_Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_Download_Path.Location = New System.Drawing.Point(213, 134)
        Me.TextBox_Download_Path.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Download_Path.Name = "TextBox_Download_Path"
        Me.TextBox_Download_Path.Size = New System.Drawing.Size(816, 26)
        Me.TextBox_Download_Path.TabIndex = 10
        '
        'Button_Download
        '
        Me.Button_Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_Download.Location = New System.Drawing.Point(4, 77)
        Me.Button_Download.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Download.Name = "Button_Download"
        Me.Button_Download.Size = New System.Drawing.Size(670, 46)
        Me.Button_Download.TabIndex = 5
        Me.Button_Download.Text = "Download"
        Me.Button_Download.UseVisualStyleBackColor = True
        Me.Button_Download.Visible = False
        '
        'TextBox_Filter
        '
        Me.TextBox_Filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_Filter.Location = New System.Drawing.Point(118, 28)
        Me.TextBox_Filter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Filter.Name = "TextBox_Filter"
        Me.TextBox_Filter.Size = New System.Drawing.Size(1058, 26)
        Me.TextBox_Filter.TabIndex = 4
        '
        'Label_seeach
        '
        Me.Label_seeach.AutoSize = True
        Me.Label_seeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_seeach.Location = New System.Drawing.Point(14, 32)
        Me.Label_seeach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_seeach.Name = "Label_seeach"
        Me.Label_seeach.Size = New System.Drawing.Size(64, 20)
        Me.Label_seeach.TabIndex = 3
        Me.Label_seeach.Text = "Search:"
        '
        'Button_Play
        '
        Me.Button_Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_Play.Location = New System.Drawing.Point(849, 77)
        Me.Button_Play.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Play.Name = "Button_Play"
        Me.Button_Play.Size = New System.Drawing.Size(328, 46)
        Me.Button_Play.TabIndex = 7
        Me.Button_Play.Text = "Play / VLC"
        Me.Button_Play.UseVisualStyleBackColor = True
        Me.Button_Play.Visible = False
        '
        'ListBox
        '
        Me.ListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 20
        Me.ListBox.Location = New System.Drawing.Point(4, 189)
        Me.ListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(1177, 524)
        Me.ListBox.TabIndex = 10
        '
        'Button_show_TV
        '
        Me.Button_show_TV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_show_TV.Location = New System.Drawing.Point(4, 132)
        Me.Button_show_TV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_show_TV.Name = "Button_show_TV"
        Me.Button_show_TV.Size = New System.Drawing.Size(1173, 46)
        Me.Button_show_TV.TabIndex = 8
        Me.Button_show_TV.Text = "Show TV programs"
        Me.Button_show_TV.UseVisualStyleBackColor = True
        Me.Button_show_TV.Visible = False
        '
        'Button_cancel
        '
        Me.Button_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_cancel.Location = New System.Drawing.Point(684, 77)
        Me.Button_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_cancel.Name = "Button_cancel"
        Me.Button_cancel.Size = New System.Drawing.Size(156, 46)
        Me.Button_cancel.TabIndex = 6
        Me.Button_cancel.Text = "Cancel"
        Me.Button_cancel.UseVisualStyleBackColor = True
        Me.Button_cancel.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_cancel)
        Me.GroupBox2.Controls.Add(Me.Button_show_TV)
        Me.GroupBox2.Controls.Add(Me.ListBox)
        Me.GroupBox2.Controls.Add(Me.Button_Play)
        Me.GroupBox2.Controls.Add(Me.Label_seeach)
        Me.GroupBox2.Controls.Add(Me.TextBox_Filter)
        Me.GroupBox2.Controls.Add(Me.Button_Download)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 327)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1192, 734)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateToolStripMenuItem, Me.CheckForUpdateOnGitHubToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1192, 25)
        Me.MenuStrip.TabIndex = 12
        Me.MenuStrip.Text = "MenuStrip"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(57, 19)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'CheckForUpdateOnGitHubToolStripMenuItem
        '
        Me.CheckForUpdateOnGitHubToolStripMenuItem.Name = "CheckForUpdateOnGitHubToolStripMenuItem"
        Me.CheckForUpdateOnGitHubToolStripMenuItem.Size = New System.Drawing.Size(169, 19)
        Me.CheckForUpdateOnGitHubToolStripMenuItem.Text = "Check for Update on GitHub"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(920, 188)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "(reload required)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1192, 1061)
        Me.Controls.Add(Me.ListBox_Backup)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1208, 1348)
        Me.MinimumSize = New System.Drawing.Size(1208, 1038)
        Me.Name = "Form1"
        Me.Text = "M3U IPTV CatchUp Downloader ©TimTester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox_Backup As ListBox
    Friend WithEvents TextBox_EPG_URL As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label_status As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_M3U_URL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_reload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Download As Button
    Friend WithEvents TextBox_Filter As TextBox
    Friend WithEvents Label_seeach As Label
    Friend WithEvents Button_Play As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Button_show_TV As Button
    Friend WithEvents Button_cancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdateOnGitHubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Download_Path As TextBox
    Friend WithEvents Button_choose_Download_path As Button
    Friend WithEvents FolderBrowserDialog_DownloadPath As FolderBrowserDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_offset_b As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_offset_a As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_TimeZone_offset As TextBox
    Friend WithEvents Label8 As Label
End Class
