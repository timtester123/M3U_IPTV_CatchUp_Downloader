﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button_Download = New System.Windows.Forms.Button()
        Me.TextBox_Filter = New System.Windows.Forms.TextBox()
        Me.Label_seeach = New System.Windows.Forms.Label()
        Me.Button_Play = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Button_show_TV = New System.Windows.Forms.Button()
        Me.Button_cancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.VisitWatchHDtoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdateOnGitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_Backup
        '
        Me.ListBox_Backup.FormattingEnabled = True
        Me.ListBox_Backup.Location = New System.Drawing.Point(747, 702)
        Me.ListBox_Backup.Name = "ListBox_Backup"
        Me.ListBox_Backup.Size = New System.Drawing.Size(23, 30)
        Me.ListBox_Backup.TabIndex = 11
        Me.ListBox_Backup.Visible = False
        '
        'TextBox_EPG_URL
        '
        Me.TextBox_EPG_URL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_EPG_URL.Location = New System.Drawing.Point(108, 55)
        Me.TextBox_EPG_URL.Name = "TextBox_EPG_URL"
        Me.TextBox_EPG_URL.Size = New System.Drawing.Size(579, 26)
        Me.TextBox_EPG_URL.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 87)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(776, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label_status
        '
        Me.Label_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_status.AutoSize = True
        Me.Label_status.BackColor = System.Drawing.Color.Transparent
        Me.Label_status.Location = New System.Drawing.Point(17, 113)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(24, 13)
        Me.Label_status.TabIndex = 4
        Me.Label_status.Text = "0 %"
        Me.Label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "EPG URL:"
        '
        'TextBox_M3U_URL
        '
        Me.TextBox_M3U_URL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_M3U_URL.Location = New System.Drawing.Point(108, 19)
        Me.TextBox_M3U_URL.Name = "TextBox_M3U_URL"
        Me.TextBox_M3U_URL.Size = New System.Drawing.Size(579, 26)
        Me.TextBox_M3U_URL.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "M3U URL:"
        '
        'Button_reload
        '
        Me.Button_reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_reload.Location = New System.Drawing.Point(693, 19)
        Me.Button_reload.Name = "Button_reload"
        Me.Button_reload.Size = New System.Drawing.Size(93, 62)
        Me.Button_reload.TabIndex = 3
        Me.Button_reload.Text = "load / reload"
        Me.Button_reload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_reload)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_M3U_URL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label_status)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.TextBox_EPG_URL)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 130)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button_Download
        '
        Me.Button_Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_Download.Location = New System.Drawing.Point(3, 51)
        Me.Button_Download.Name = "Button_Download"
        Me.Button_Download.Size = New System.Drawing.Size(447, 30)
        Me.Button_Download.TabIndex = 5
        Me.Button_Download.Text = "Download"
        Me.Button_Download.UseVisualStyleBackColor = True
        Me.Button_Download.Visible = False
        '
        'TextBox_Filter
        '
        Me.TextBox_Filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_Filter.Location = New System.Drawing.Point(79, 19)
        Me.TextBox_Filter.Name = "TextBox_Filter"
        Me.TextBox_Filter.Size = New System.Drawing.Size(707, 26)
        Me.TextBox_Filter.TabIndex = 4
        '
        'Label_seeach
        '
        Me.Label_seeach.AutoSize = True
        Me.Label_seeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_seeach.Location = New System.Drawing.Point(9, 22)
        Me.Label_seeach.Name = "Label_seeach"
        Me.Label_seeach.Size = New System.Drawing.Size(64, 20)
        Me.Label_seeach.TabIndex = 3
        Me.Label_seeach.Text = "Search:"
        '
        'Button_Play
        '
        Me.Button_Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_Play.Location = New System.Drawing.Point(566, 51)
        Me.Button_Play.Name = "Button_Play"
        Me.Button_Play.Size = New System.Drawing.Size(219, 30)
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
        Me.ListBox.Location = New System.Drawing.Point(3, 122)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(786, 504)
        Me.ListBox.TabIndex = 10
        '
        'Button_show_TV
        '
        Me.Button_show_TV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_show_TV.Location = New System.Drawing.Point(3, 87)
        Me.Button_show_TV.Name = "Button_show_TV"
        Me.Button_show_TV.Size = New System.Drawing.Size(782, 30)
        Me.Button_show_TV.TabIndex = 8
        Me.Button_show_TV.Text = "Show TV programs"
        Me.Button_show_TV.UseVisualStyleBackColor = True
        Me.Button_show_TV.Visible = False
        '
        'Button_cancel
        '
        Me.Button_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_cancel.Location = New System.Drawing.Point(456, 51)
        Me.Button_cancel.Name = "Button_cancel"
        Me.Button_cancel.Size = New System.Drawing.Size(104, 30)
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
        Me.GroupBox2.Location = New System.Drawing.Point(0, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 641)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitWatchHDtoToolStripMenuItem, Me.DonateToolStripMenuItem, Me.CheckForUpdateOnGitHubToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip.TabIndex = 12
        Me.MenuStrip.Text = "MenuStrip"
        '
        'VisitWatchHDtoToolStripMenuItem
        '
        Me.VisitWatchHDtoToolStripMenuItem.Name = "VisitWatchHDtoToolStripMenuItem"
        Me.VisitWatchHDtoToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.VisitWatchHDtoToolStripMenuItem.Text = "Visit WatchHD.to"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'CheckForUpdateOnGitHubToolStripMenuItem
        '
        Me.CheckForUpdateOnGitHubToolStripMenuItem.Name = "CheckForUpdateOnGitHubToolStripMenuItem"
        Me.CheckForUpdateOnGitHubToolStripMenuItem.Size = New System.Drawing.Size(169, 20)
        Me.CheckForUpdateOnGitHubToolStripMenuItem.Text = "Check for Update on GitHub"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(795, 795)
        Me.Controls.Add(Me.ListBox_Backup)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(811, 834)
        Me.MinimumSize = New System.Drawing.Size(811, 834)
        Me.Name = "Form1"
        Me.Text = "M3U IPTV CatchUp Downloader ©TimTester (made for WatchHD.to)"
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
    Friend WithEvents VisitWatchHDtoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdateOnGitHubToolStripMenuItem As ToolStripMenuItem
End Class
