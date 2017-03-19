<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.selectfile_button = New System.Windows.Forms.Button
        Me.file_select_textbox = New System.Windows.Forms.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.selectfolder = New System.Windows.Forms.Button
        Me.create_srt_files = New System.Windows.Forms.Button
        Me.folder_select = New System.Windows.Forms.TextBox
        Me.current_status = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.video_start_time = New System.Windows.Forms.TextBox
        Me.video_start_date = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.hours_offset = New System.Windows.Forms.NumericUpDown
        Me.minutes_offset = New System.Windows.Forms.NumericUpDown
        Me.seconds_offset = New System.Windows.Forms.NumericUpDown
        Me.customformat = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.showtimeformat = New System.Windows.Forms.Button
        Me.format_tb = New System.Windows.Forms.TextBox
        Me.add_milliseconds = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.font_underline = New System.Windows.Forms.RadioButton
        Me.font_italic = New System.Windows.Forms.RadioButton
        Me.font_bold = New System.Windows.Forms.RadioButton
        Me.font_normal = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.subtitle_time = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.create_logfile_cb = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.srt_filename = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.srt_single_multi = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.td_source_modify = New System.Windows.Forms.RadioButton
        Me.td_source_create = New System.Windows.Forms.RadioButton
        Me.td_source_media = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.hours_offset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minutes_offset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seconds_offset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.subtitle_time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "mp4"
        Me.OpenFileDialog1.Title = "Select Video File to Process"
        '
        'selectfile_button
        '
        Me.selectfile_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectfile_button.Location = New System.Drawing.Point(11, 9)
        Me.selectfile_button.Name = "selectfile_button"
        Me.selectfile_button.Size = New System.Drawing.Size(128, 28)
        Me.selectfile_button.TabIndex = 1
        Me.selectfile_button.Text = "Select File"
        Me.selectfile_button.UseVisualStyleBackColor = True
        '
        'file_select_textbox
        '
        Me.file_select_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file_select_textbox.Location = New System.Drawing.Point(145, 14)
        Me.file_select_textbox.Name = "file_select_textbox"
        Me.file_select_textbox.Size = New System.Drawing.Size(635, 22)
        Me.file_select_textbox.TabIndex = 3
        '
        'selectfolder
        '
        Me.selectfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectfolder.Location = New System.Drawing.Point(12, 43)
        Me.selectfolder.Name = "selectfolder"
        Me.selectfolder.Size = New System.Drawing.Size(128, 28)
        Me.selectfolder.TabIndex = 19
        Me.selectfolder.Text = "Select Folder"
        Me.selectfolder.UseVisualStyleBackColor = True
        '
        'create_srt_files
        '
        Me.create_srt_files.BackColor = System.Drawing.Color.Orange
        Me.create_srt_files.Enabled = False
        Me.create_srt_files.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_srt_files.Location = New System.Drawing.Point(259, 176)
        Me.create_srt_files.Name = "create_srt_files"
        Me.create_srt_files.Size = New System.Drawing.Size(276, 52)
        Me.create_srt_files.TabIndex = 20
        Me.create_srt_files.Text = "Create SRT Files"
        Me.create_srt_files.UseVisualStyleBackColor = False
        '
        'folder_select
        '
        Me.folder_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folder_select.Location = New System.Drawing.Point(146, 48)
        Me.folder_select.Name = "folder_select"
        Me.folder_select.Size = New System.Drawing.Size(634, 22)
        Me.folder_select.TabIndex = 21
        '
        'current_status
        '
        Me.current_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current_status.Location = New System.Drawing.Point(13, 40)
        Me.current_status.Multiline = True
        Me.current_status.Name = "current_status"
        Me.current_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.current_status.Size = New System.Drawing.Size(772, 115)
        Me.current_status.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Current Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Video Start Time ( HH:MM:SS )"
        '
        'video_start_time
        '
        Me.video_start_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.video_start_time.Location = New System.Drawing.Point(224, 15)
        Me.video_start_time.Name = "video_start_time"
        Me.video_start_time.ReadOnly = True
        Me.video_start_time.Size = New System.Drawing.Size(163, 22)
        Me.video_start_time.TabIndex = 28
        '
        'video_start_date
        '
        Me.video_start_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.video_start_date.Location = New System.Drawing.Point(224, 70)
        Me.video_start_date.Name = "video_start_date"
        Me.video_start_date.ReadOnly = True
        Me.video_start_date.Size = New System.Drawing.Size(163, 22)
        Me.video_start_date.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Video Start Date ( DD/MM/YYYY )"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Video Time Offset (HH:MM:SS):"
        '
        'hours_offset
        '
        Me.hours_offset.Location = New System.Drawing.Point(229, 44)
        Me.hours_offset.Maximum = New Decimal(New Integer() {96, 0, 0, 0})
        Me.hours_offset.Minimum = New Decimal(New Integer() {96, 0, 0, -2147483648})
        Me.hours_offset.Name = "hours_offset"
        Me.hours_offset.Size = New System.Drawing.Size(42, 20)
        Me.hours_offset.TabIndex = 37
        '
        'minutes_offset
        '
        Me.minutes_offset.Location = New System.Drawing.Point(278, 44)
        Me.minutes_offset.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minutes_offset.Minimum = New Decimal(New Integer() {59, 0, 0, -2147483648})
        Me.minutes_offset.Name = "minutes_offset"
        Me.minutes_offset.Size = New System.Drawing.Size(42, 20)
        Me.minutes_offset.TabIndex = 38
        '
        'seconds_offset
        '
        Me.seconds_offset.Location = New System.Drawing.Point(327, 44)
        Me.seconds_offset.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.seconds_offset.Minimum = New Decimal(New Integer() {59, 0, 0, -2147483648})
        Me.seconds_offset.Name = "seconds_offset"
        Me.seconds_offset.Size = New System.Drawing.Size(42, 20)
        Me.seconds_offset.TabIndex = 39
        '
        'customformat
        '
        Me.customformat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customformat.Location = New System.Drawing.Point(134, 19)
        Me.customformat.Name = "customformat"
        Me.customformat.Size = New System.Drawing.Size(236, 22)
        Me.customformat.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Date Time Format:"
        '
        'showtimeformat
        '
        Me.showtimeformat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showtimeformat.Location = New System.Drawing.Point(123, 62)
        Me.showtimeformat.Name = "showtimeformat"
        Me.showtimeformat.Size = New System.Drawing.Size(133, 39)
        Me.showtimeformat.TabIndex = 42
        Me.showtimeformat.Text = "Display Time/Date"
        Me.showtimeformat.UseVisualStyleBackColor = True
        '
        'format_tb
        '
        Me.format_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.format_tb.Location = New System.Drawing.Point(10, 127)
        Me.format_tb.Multiline = True
        Me.format_tb.Name = "format_tb"
        Me.format_tb.ReadOnly = True
        Me.format_tb.Size = New System.Drawing.Size(355, 101)
        Me.format_tb.TabIndex = 43
        '
        'add_milliseconds
        '
        Me.add_milliseconds.AutoSize = True
        Me.add_milliseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_milliseconds.Location = New System.Drawing.Point(9, 96)
        Me.add_milliseconds.Name = "add_milliseconds"
        Me.add_milliseconds.Size = New System.Drawing.Size(309, 20)
        Me.add_milliseconds.TabIndex = 44
        Me.add_milliseconds.Text = "Add Remainder of Duration Time (Milliseconds)"
        Me.add_milliseconds.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.font_underline)
        Me.GroupBox1.Controls.Add(Me.font_italic)
        Me.GroupBox1.Controls.Add(Me.font_bold)
        Me.GroupBox1.Controls.Add(Me.font_normal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 49)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'font_underline
        '
        Me.font_underline.AutoSize = True
        Me.font_underline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.font_underline.Location = New System.Drawing.Point(330, 19)
        Me.font_underline.Name = "font_underline"
        Me.font_underline.Size = New System.Drawing.Size(70, 17)
        Me.font_underline.TabIndex = 50
        Me.font_underline.Text = "Underline"
        Me.font_underline.UseVisualStyleBackColor = True
        '
        'font_italic
        '
        Me.font_italic.AutoSize = True
        Me.font_italic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.font_italic.Location = New System.Drawing.Point(269, 19)
        Me.font_italic.Name = "font_italic"
        Me.font_italic.Size = New System.Drawing.Size(47, 17)
        Me.font_italic.TabIndex = 49
        Me.font_italic.Text = "Italic"
        Me.font_italic.UseVisualStyleBackColor = True
        '
        'font_bold
        '
        Me.font_bold.AutoSize = True
        Me.font_bold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.font_bold.Location = New System.Drawing.Point(213, 19)
        Me.font_bold.Name = "font_bold"
        Me.font_bold.Size = New System.Drawing.Size(50, 17)
        Me.font_bold.TabIndex = 48
        Me.font_bold.Text = "Bold"
        Me.font_bold.UseVisualStyleBackColor = True
        '
        'font_normal
        '
        Me.font_normal.AutoSize = True
        Me.font_normal.Checked = True
        Me.font_normal.Location = New System.Drawing.Point(149, 19)
        Me.font_normal.Name = "font_normal"
        Me.font_normal.Size = New System.Drawing.Size(58, 17)
        Me.font_normal.TabIndex = 47
        Me.font_normal.TabStop = True
        Me.font_normal.Text = "Normal"
        Me.font_normal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Subtitle Font Type:"
        '
        'subtitle_time
        '
        Me.subtitle_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle_time.Location = New System.Drawing.Point(334, 14)
        Me.subtitle_time.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.subtitle_time.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.subtitle_time.Name = "subtitle_time"
        Me.subtitle_time.Size = New System.Drawing.Size(56, 22)
        Me.subtitle_time.TabIndex = 46
        Me.subtitle_time.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.subtitle_time)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 42)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(323, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Length of time in milliseconds to display each subtitle:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.create_logfile_cb)
        Me.GroupBox3.Controls.Add(Me.create_srt_files)
        Me.GroupBox3.Controls.Add(Me.current_status)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 405)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(794, 239)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        '
        'create_logfile_cb
        '
        Me.create_logfile_cb.AutoSize = True
        Me.create_logfile_cb.Location = New System.Drawing.Point(677, 17)
        Me.create_logfile_cb.Name = "create_logfile_cb"
        Me.create_logfile_cb.Size = New System.Drawing.Size(97, 17)
        Me.create_logfile_cb.TabIndex = 24
        Me.create_logfile_cb.Text = "Create Log File"
        Me.create_logfile_cb.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.format_tb)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.customformat)
        Me.GroupBox4.Controls.Add(Me.showtimeformat)
        Me.GroupBox4.Location = New System.Drawing.Point(427, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(379, 260)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.video_start_time)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.hours_offset)
        Me.GroupBox5.Controls.Add(Me.minutes_offset)
        Me.GroupBox5.Controls.Add(Me.add_milliseconds)
        Me.GroupBox5.Controls.Add(Me.seconds_offset)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.video_start_date)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(405, 123)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.srt_filename)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.srt_single_multi)
        Me.GroupBox6.Controls.Add(Me.selectfile_button)
        Me.GroupBox6.Controls.Add(Me.file_select_textbox)
        Me.GroupBox6.Controls.Add(Me.selectfolder)
        Me.GroupBox6.Controls.Add(Me.folder_select)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(794, 115)
        Me.GroupBox6.TabIndex = 51
        Me.GroupBox6.TabStop = False
        '
        'srt_filename
        '
        Me.srt_filename.Enabled = False
        Me.srt_filename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srt_filename.Location = New System.Drawing.Point(639, 87)
        Me.srt_filename.Name = "srt_filename"
        Me.srt_filename.Size = New System.Drawing.Size(141, 22)
        Me.srt_filename.TabIndex = 24
        Me.srt_filename.Text = "merged"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(407, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(226, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "SRT Filename  (Single From Folder):"
        '
        'srt_single_multi
        '
        Me.srt_single_multi.AutoSize = True
        Me.srt_single_multi.Enabled = False
        Me.srt_single_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srt_single_multi.Location = New System.Drawing.Point(145, 89)
        Me.srt_single_multi.Name = "srt_single_multi"
        Me.srt_single_multi.Size = New System.Drawing.Size(240, 20)
        Me.srt_single_multi.TabIndex = 22
        Me.srt_single_multi.Text = "Create Single SRT File From Folder"
        Me.srt_single_multi.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.td_source_modify)
        Me.GroupBox7.Controls.Add(Me.td_source_create)
        Me.GroupBox7.Controls.Add(Me.td_source_media)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(409, 42)
        Me.GroupBox7.TabIndex = 52
        Me.GroupBox7.TabStop = False
        '
        'td_source_modify
        '
        Me.td_source_modify.AutoSize = True
        Me.td_source_modify.Location = New System.Drawing.Point(326, 16)
        Me.td_source_modify.Name = "td_source_modify"
        Me.td_source_modify.Size = New System.Drawing.Size(75, 17)
        Me.td_source_modify.TabIndex = 54
        Me.td_source_modify.Text = "File Modify"
        Me.td_source_modify.UseVisualStyleBackColor = True
        '
        'td_source_create
        '
        Me.td_source_create.AutoSize = True
        Me.td_source_create.Location = New System.Drawing.Point(240, 16)
        Me.td_source_create.Name = "td_source_create"
        Me.td_source_create.Size = New System.Drawing.Size(83, 17)
        Me.td_source_create.TabIndex = 53
        Me.td_source_create.Text = "File Creation"
        Me.td_source_create.UseVisualStyleBackColor = True
        '
        'td_source_media
        '
        Me.td_source_media.AutoSize = True
        Me.td_source_media.Checked = True
        Me.td_source_media.Location = New System.Drawing.Point(127, 16)
        Me.td_source_media.Name = "td_source_media"
        Me.td_source_media.Size = New System.Drawing.Size(112, 17)
        Me.td_source_media.TabIndex = 52
        Me.td_source_media.TabStop = True
        Me.td_source_media.Text = "MediaInfo Encode"
        Me.td_source_media.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Time/Date Source:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 656)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video Time / Date Subtitle File (.srt) Creator  V1.9"
        CType(Me.hours_offset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minutes_offset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seconds_offset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.subtitle_time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents selectfile_button As System.Windows.Forms.Button
    Friend WithEvents file_select_textbox As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents selectfolder As System.Windows.Forms.Button
    Friend WithEvents create_srt_files As System.Windows.Forms.Button
    Friend WithEvents folder_select As System.Windows.Forms.TextBox
    Friend WithEvents current_status As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents video_start_time As System.Windows.Forms.TextBox
    Friend WithEvents video_start_date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents hours_offset As System.Windows.Forms.NumericUpDown
    Friend WithEvents minutes_offset As System.Windows.Forms.NumericUpDown
    Friend WithEvents seconds_offset As System.Windows.Forms.NumericUpDown
    Friend WithEvents customformat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents showtimeformat As System.Windows.Forms.Button
    Friend WithEvents format_tb As System.Windows.Forms.TextBox
    Friend WithEvents add_milliseconds As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents font_normal As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents font_italic As System.Windows.Forms.RadioButton
    Friend WithEvents font_bold As System.Windows.Forms.RadioButton
    Friend WithEvents font_underline As System.Windows.Forms.RadioButton
    Friend WithEvents subtitle_time As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents srt_filename As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents srt_single_multi As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents td_source_create As System.Windows.Forms.RadioButton
    Friend WithEvents td_source_media As System.Windows.Forms.RadioButton
    Friend WithEvents td_source_modify As System.Windows.Forms.RadioButton
    Friend WithEvents create_logfile_cb As System.Windows.Forms.CheckBox

End Class
