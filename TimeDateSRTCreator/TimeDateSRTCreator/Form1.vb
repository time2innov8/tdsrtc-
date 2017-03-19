Imports MediaInfoNET
Imports System.IO
Imports System.Text
Public Class Form1
    Dim mydate As Date
    Dim subtitle_date As Date
    Dim video_duration As String
    Dim total_playtime As String
    Dim duration_seconds As Integer
    Dim short_filename As String
    Dim file_mod_time As String
    Dim create_date_seconds As Long
    Dim file_creation_date As Date
    Dim hexstring As String = ""
    Dim numeric_value As Long = 0
    Dim timescale As Long
    Dim match_mvhd As Boolean
    Dim byte_counter As Long = 0
    Dim mp4_timescale As Long
    Dim mp4_duration As Long
    Dim video_seconds As Integer
    Dim video_milliseconds As Integer
    Dim info_text As String
    Dim open_tag As String
    Dim close_tag As String
    Dim multi_offset As Integer
    Dim sub_date1 As String
    Dim sub_date2 As String
    Const logfile As String = "log.txt"
 
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If My.Computer.FileSystem.FileExists("MediaInfo.dll") Then
                Exit Try
            End If
            If InStr(System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"), "64") Then
                My.Computer.FileSystem.CopyFile("MediaInfo64.dll", "MediaInfo.dll", True)
            Else
                My.Computer.FileSystem.CopyFile("MediaInfo32.dll", "MediaInfo.dll", True)
            End If

        Catch
        End Try

        Try
            If Not My.Computer.FileSystem.FileExists("MediaInfoNET.dll") Then
                MsgBox("This application requires the MediaInfoNET wrapper, it can be downloaded from:" & vbCrLf & " http://sourceforge.net/projects/mediainfonet/", MsgBoxStyle.Critical, "This application will now close")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
        customformat.Text = "F"
    End Sub
    Private Sub selectfile_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectfile_button.Click
        multi_offset = 0
        srt_single_multi.Checked = False
        create_srt_files.Text = "Create SRT Files"
        file_select_textbox.Text = ""
        folder_select.Text = ""
        current_status.Text = ""
        create_srt_files.BackColor = Color.Orange
        video_duration = ""
        OpenFileDialog1.ShowDialog()
        file_select_textbox.Text = OpenFileDialog1.FileName
        If OpenFileDialog1.FileName = "" Then
            selectfile_button.Enabled = True
            Exit Sub
        End If
        create_srt_files.Text = "Create SRT From Single File"
        srt_single_multi.Enabled = False
        srt_filename.Enabled = False
        short_filename = Path.GetFileNameWithoutExtension(file_select_textbox.Text)
       
        mydate = System.IO.File.GetCreationTime(file_select_textbox.Text)

        video_start_date.Text = mydate.ToString("dd/MM/yyyy")
        video_start_time.Text = mydate.ToString("HH:mm:ss")

        create_srt_files.Enabled = True
    End Sub

   
    Private Sub selectfolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectfolder.Click
        multi_offset = 0
        srt_single_multi.Checked = False
        create_srt_files.Text = "Create SRT Files"
        file_select_textbox.Text = ""
        folder_select.Text = ""
        current_status.Text = ""
        create_srt_files.BackColor = Color.Orange
        create_srt_files.BackColor = Color.Orange
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then
            create_srt_files.Enabled = False
            Exit Sub
        End If
        create_srt_files.Text = "Create Multiple SRT Files"
        srt_single_multi.Enabled = True
        srt_filename.Enabled = True
        folder_select.Text = FolderBrowserDialog1.SelectedPath
        create_srt_files.Enabled = True
    End Sub

    Private Sub create_srt_files_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_srt_files.Click

        If My.Computer.FileSystem.FileExists(logfile) Then
            My.Computer.FileSystem.DeleteFile(logfile)
        End If

        subtitle_date = Date.Parse("00:00:00")
        multi_offset = 0

        If Len(file_select_textbox.Text) > 0 Then
            srt_single_multi.Checked = False
            srt_filename.Enabled = False
            create_srt(file_select_textbox.Text)
            Exit Sub
        End If


        Try
            Dim video_types() As String = {".mp4", ".avi", ".mpg", ".wmv", ".mov", ".m4v", ".webm", ".ogv", ".mts", ".m2ts"}

            Dim valid_files As Boolean = False

            create_srt_files.BackColor = Color.LightGreen
            create_srt_files.Text = "Processing Files"

            If srt_single_multi.Checked = True Then
                subtitle_date = "00:00:00"
                If Len(srt_filename.Text) = 0 Then
                    srt_filename.Text = "merged"
                End If
                If My.Computer.FileSystem.FileExists(folder_select.Text & "/" & srt_filename.Text & ".srt") Then
                    My.Computer.FileSystem.DeleteFile((folder_select.Text & "/" & srt_filename.Text & ".srt"))
                End If
            End If


            Dim dirinfo As DirectoryInfo
            Dim allFiles() As FileInfo
            dirinfo = New DirectoryInfo(folder_select.Text)
            allFiles = dirinfo.GetFiles()

            Dim tempfile As String = ""

            Array.Sort(allFiles, New clsCompareFileInfo)
            Dim match_ext As Boolean
            For Each fl As FileInfo In allFiles
                If srt_single_multi.Checked = False Then
                    multi_offset = 0
                End If

                tempfile = fl.ToString
                short_filename = Path.GetFileNameWithoutExtension(fl.ToString)
                update_log_file("Checking file: " & tempfile)
                match_ext = False

              
                For count As Integer = 0 To video_types.GetUpperBound(0)
                    If InStr(Path.GetExtension(fl.ToString).ToLower, video_types(count)) Then
                        match_ext = True
                        update_log_file("Matched file (" & video_types(count) & ") :" & tempfile)
                        Exit For
                    End If
                Next

                If match_ext = True Then
                    create_srt(folder_select.Text & "\" & fl.ToString)
                    valid_files = True
                Else
                    update_log_file("Unable to match file: " & tempfile)
                End If

            Next

           

            If valid_files = True Then
                create_srt_files.BackColor = Color.GreenYellow
                create_srt_files.Text = "All Files Processed"
            Else
                create_srt_files.BackColor = Color.Yellow
                create_srt_files.Text = "No Files To Process"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            create_srt_files.Text = "Error Detected!!"
            create_srt_files.BackColor = Color.Yellow
        End Try
    End Sub

    Sub create_srt(ByVal file_to_read As String)

        Try
            update_log_file("Creating srt file for: " & file_to_read)
            format_tb.Text = ""
            Dim star_pos2 As Integer
            format_tb.ForeColor = Color.Black
            star_pos2 = InStr(customformat.Text, "*")

            If star_pos2 > 0 Then
                Dim temp_customformat As String = customformat.Text
                While Len(temp_customformat) > 0
                    If InStr(temp_customformat, "*") > 0 Then
                        star_pos2 = InStr(temp_customformat, "*")
                        Dim temp_format = Mid(temp_customformat, 1, star_pos2 - 1)
                        format_tb.Text = format_tb.Text & open_tag & Date.Now.ToString(temp_format) & close_tag & vbCrLf
                        temp_customformat = Mid(temp_customformat, star_pos2 + 1)
                    Else
                        format_tb.Text = format_tb.Text & open_tag & Date.Now.ToString(Mid(temp_customformat, 1)) & close_tag
                        temp_customformat = ""
                    End If

                End While
            Else
                format_tb.Text = open_tag & Date.Now.ToString(customformat.Text) & close_tag
            End If

        Catch
            format_tb.Text = "Invalid Time/Date format"
            format_tb.ForeColor = Color.Red
            create_srt_files.Enabled = False
        End Try

        current_status.Text = ""

        Dim star_pos As Integer

        Try
            format_tb.Text = ""
            format_tb.ForeColor = Color.Black
            star_pos = InStr(customformat.Text, "*")

            If star_pos > 0 Then
                Dim temp_customformat As String = customformat.Text
                While Len(temp_customformat) > 0
                    If InStr(temp_customformat, "*") > 0 Then
                        star_pos = InStr(temp_customformat, "*")
                        Dim temp_format = Mid(temp_customformat, 1, star_pos - 1)
                        format_tb.Text = format_tb.Text & open_tag & Date.Now.ToString(temp_format) & close_tag & vbCrLf
                        temp_customformat = Mid(temp_customformat, star_pos + 1)
                    Else
                        format_tb.Text = format_tb.Text & open_tag & Date.Now.ToString(Mid(temp_customformat, 1)) & close_tag
                        temp_customformat = ""
                    End If

                End While
            Else
                format_tb.Text = open_tag & Date.Now.ToString(customformat.Text) & close_tag
            End If
        Catch
            format_tb.Text = "Invalid Time/Date format"
            format_tb.ForeColor = Color.Red
            Exit Sub
        End Try

        current_status.Text = current_status.Text & "Processed file: " & file_to_read & vbCrLf

        read_duration(file_to_read)
        If duration_seconds = 0 Then
            current_status.Text = current_status.Text & "Invalid File: " & file_to_read & vbCrLf
            Exit Sub
        End If

        Dim encoded_pos As Integer = 0

        encoded_pos = InStr(info_text, "Encoded date : ")

        If td_source_create.Checked = True Then
            mydate = DateAdd(DateInterval.Hour, hours_offset.Value, System.IO.File.GetCreationTime(file_to_read)) 
            GoTo bypass_encode_read
        End If

        If td_source_modify.Checked = True Then
            mydate = DateAdd(DateInterval.Hour, hours_offset.Value, System.IO.File.GetLastWriteTime(file_to_read))
            GoTo bypass_encode_read
        End If


        If encoded_pos > 0 Then
            Dim info_date As String = Mid(info_text, encoded_pos + 18, 21)
            Try
                mydate = Date.Parse(info_date)
                mydate = DateAdd(DateInterval.Hour, hours_offset.Value, mydate)
            Catch
                mydate = DateAdd(DateInterval.Hour, hours_offset.Value, System.IO.File.GetCreationTime(file_to_read))
            End Try
        Else
            mydate = DateAdd(DateInterval.Hour, hours_offset.Value, System.IO.File.GetCreationTime(file_to_read))
        End If

bypass_encode_read:

        mydate = DateAdd(DateInterval.Minute, minutes_offset.Value, mydate)
        mydate = DateAdd(DateInterval.Second, seconds_offset.Value, mydate)

        video_start_date.Text = mydate.ToString("dd/MM/yyyy")
        video_start_time.Text = mydate.ToString("HH:mm:ss")


        If srt_single_multi.Checked = False Then
            subtitle_date = "00:00:00"
        End If
        Dim subtitle_date2 As Date
        Dim textWriter As New System.Text.StringBuilder
        star_pos = 0
        For i = 1 To duration_seconds
            '----------------------------------------------------------------------------------------------------------------------------------------------------------------
            textWriter.AppendLine(i + multi_offset)
            subtitle_date2 = subtitle_date.AddMilliseconds(subtitle_time.Value)
            sub_date1 = subtitle_date.ToString("HH:mm:ss,fff")
            sub_date1 = sub_date1.Replace(".", ":")
            sub_date2 = subtitle_date2.ToString("HH:mm:ss,fff")
            sub_date2 = sub_date2.Replace(".", ":")

            textWriter.AppendLine(sub_date1 & " --> " & sub_date2)

            star_pos = InStr(customformat.Text, "*")
            If star_pos > 0 Then
                Dim temp_customformat As String = customformat.Text
                While Len(temp_customformat) > 0
                    star_pos = InStr(temp_customformat, "*")
                    If InStr(temp_customformat, "*") > 0 Then
                        Dim temp_format = Mid(temp_customformat, 1, star_pos - 1)
                        textWriter.AppendLine(open_tag & (mydate.AddSeconds(i).ToString(temp_format) & close_tag))
                        temp_customformat = Mid(temp_customformat, star_pos + 1)
                    Else
                        textWriter.AppendLine(open_tag & (mydate.AddSeconds(i).ToString(Mid(temp_customformat, 1))) & close_tag)
                        temp_customformat = ""
                    End If

                End While
            Else
                textWriter.AppendLine(open_tag & (mydate.AddSeconds(i).ToString(customformat.Text)) & close_tag)
            End If
            textWriter.AppendLine()
            subtitle_date = subtitle_date.AddSeconds(1)
        Next
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If add_milliseconds.Checked = True Then
            subtitle_date2 = subtitle_date.AddMilliseconds(video_milliseconds)

            sub_date1 = subtitle_date.ToString("HH:mm:ss,fff")
            sub_date1 = sub_date1.Replace(".", ":")
            sub_date2 = subtitle_date2.ToString("HH:mm:ss,fff")
            sub_date2 = sub_date2.Replace(".", ":")

            textWriter.AppendLine(duration_seconds + 1 + multi_offset)

            textWriter.AppendLine(sub_date1 & " --> " & sub_date2)

            star_pos = InStr(customformat.Text, "*")
            If star_pos > 0 Then
                Dim temp_customformat As String = customformat.Text
                While Len(temp_customformat) > 0
                    star_pos = InStr(temp_customformat, "*")
                    If InStr(temp_customformat, "*") > 0 Then
                        Dim temp_format = Mid(temp_customformat, 1, star_pos - 1)
                        textWriter.AppendLine(open_tag & (mydate.AddSeconds(duration_seconds + 1).ToString(temp_format) & close_tag))
                        temp_customformat = Mid(temp_customformat, star_pos + 1)
                    Else
                        textWriter.AppendLine(open_tag & (mydate.AddSeconds(duration_seconds + 1).ToString(Mid(temp_customformat, 1))) & close_tag)
                        temp_customformat = ""
                    End If

                End While
            Else
                textWriter.AppendLine(open_tag & (mydate.AddSeconds(duration_seconds + 1).ToString(customformat.Text)) & close_tag)
            End If
            textWriter.AppendLine()
            subtitle_date = subtitle_date2

        End If

        If srt_single_multi.Checked = True Then
            My.Computer.FileSystem.WriteAllText(Path.GetDirectoryName(file_to_read) & "/" & srt_filename.Text & ".srt", textWriter.ToString, True)
        Else
            System.IO.File.WriteAllText(Path.GetDirectoryName(file_to_read) & "/" & short_filename & ".srt", textWriter.ToString)
        End If

        If srt_single_multi.Checked = True Then
            current_status.Text = current_status.Text & "Created file: " & Path.GetDirectoryName(file_to_read) & "\" & srt_filename.Text & ".srt" & vbCrLf
        Else
            If add_milliseconds.Checked = True Then
                current_status.Text = current_status.Text & "Created file: " & Path.GetDirectoryName(file_to_read) & "\" & short_filename & ".srt (Duration: " & duration_seconds & " seconds " & video_milliseconds & " milliseconds)" & vbCrLf
            Else
                current_status.Text = current_status.Text & "Created file: " & Path.GetDirectoryName(file_to_read) & "\" & short_filename & ".srt (Duration: " & duration_seconds & " seconds)" & vbCrLf
            End If
        End If
        current_status.Text = current_status.Text & "Video Start Date/Time: " & mydate & vbCrLf & vbCrLf
        If Len(folder_select.Text) = 0 Then
            file_select_textbox.Text = file_to_read
        End If
        current_status.Refresh()
        Application.DoEvents()

        If add_milliseconds.Checked = True Then
            multi_offset = multi_offset + duration_seconds + 1
        Else
            multi_offset = multi_offset + duration_seconds
        End If

        update_log_file(current_status.Text)

    End Sub

    Sub read_duration(ByVal file2open As String)

        Try
            Dim VideoFile As MediaFile = New MediaFile(file2open)
            info_text = VideoFile.Info_Text.ToString
            Dim temp_duration As String = VideoFile.General.DurationStringAccurate
           video_milliseconds = Microsoft.VisualBasic.Right(VideoFile.General.DurationStringAccurate, 3)
            Dim temp_seconds = VideoFile.General.DurationMillis.ToString
            temp_seconds = Mid(temp_seconds, 1, Len(temp_seconds) - 3)
            duration_seconds = Val(temp_seconds)
        Catch
            current_status.Text = current_status.Text & "Invalid File detected: " & file2open & vbCrLf
        End Try


    End Sub

    
    
    Private Sub showtimeformat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showtimeformat.Click
        Try
            format_tb.Text = ""
            Dim star_pos As Integer
            format_tb.ForeColor = Color.Black
            star_pos = InStr(customformat.Text, "*")

            If star_pos > 0 Then
                Dim temp_customformat As String = customformat.Text
                While Len(temp_customformat) > 0
                    If InStr(temp_customformat, "*") > 0 Then
                        star_pos = InStr(temp_customformat, "*")
                        Dim temp_format = Mid(temp_customformat, 1, star_pos - 1)
                        format_tb.Text = format_tb.Text & open_tag & Date.Now.ToString(temp_format) & close_tag & vbCrLf
                        temp_customformat = Mid(temp_customformat, star_pos + 1)
                    Else
                        format_tb.Text = format_tb.Text & open_tag & Date.Now.ToString(Mid(temp_customformat, 1)) & close_tag
                        temp_customformat = ""
                    End If

                End While
            Else
                format_tb.Text = open_tag & Date.Now.ToString(customformat.Text) & close_tag
            End If

          Catch
            format_tb.Text = "Invalid Time/Date format"
            format_tb.ForeColor = Color.Red
            create_srt_files.Enabled = False
        End Try
    End Sub
    Private Sub check_font() Handles font_normal.CheckedChanged, font_bold.CheckedChanged, font_italic.CheckedChanged, font_underline.CheckedChanged
        If font_normal.Checked = True Then
            open_tag = ""
            close_tag = ""
         ElseIf font_bold.Checked = True Then
            open_tag = "<b>"
            close_tag = "</b>"
        ElseIf font_italic.Checked = True Then
            open_tag = "<i>"
            close_tag = "</i>"
        ElseIf font_underline.Checked = True Then
            open_tag = "<u>"
            close_tag = "</u>"
        End If
    End Sub


    Private Sub srt_single_multi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srt_single_multi.CheckedChanged
        If srt_single_multi.Enabled = True Then
            If Len(file_select_textbox.Text) = 0 Then
                If Len(folder_select.Text) > 0 Then
                    If srt_single_multi.Checked = True Then
                        create_srt_files.Text = "Create Single SRT From Multiple Files"
                    Else
                        create_srt_files.Text = "Create Multiple SRT Files"
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub update_log_file(ByVal line2write As String)
        If create_logfile_cb.Checked = True Then
            Try
                My.Computer.FileSystem.WriteAllText(logfile, Date.Now.ToString & " - " & line2write & vbCrLf, True)
            Catch
            End Try
        End If
    End Sub

End Class
Public Class clsCompareFileInfo
    Implements IComparer
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim File1 As FileInfo
        Dim File2 As FileInfo

        File1 = DirectCast(x, FileInfo)
        File2 = DirectCast(y, FileInfo)

        Compare = DateTime.Compare(File1.LastWriteTime, File2.LastWriteTime)
    End Function
End Class