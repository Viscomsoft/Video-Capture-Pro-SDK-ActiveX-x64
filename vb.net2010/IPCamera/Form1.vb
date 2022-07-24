Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim strVideoComp As String
        Dim i As Integer
        Dim bFindDivx As Boolean
        bFindDivx = False

        For i = 0 To AxVideoCap1.GetVideoCompressorCount - 1
            strVideoComp = AxVideoCap1.GetVideoCompressorName(i)
            cboVideoCompressor.Items.Add(strVideoComp)


            If strVideoComp.Substring(0, 4) = "DivX" And bFindDivx = False Then
                cboVideoCompressor.SelectedIndex = i
                bFindDivx = True

            End If


            If Trim(strVideoComp) = "MJPEG Compressor" And bFindDivx = False Then
                cboVideoCompressor.SelectedIndex = i
            End If

        Next

    


        cboIPCamURL.Items.Add("http://158.58.130.148:80/mjpg/video.mjpg")
        cboIPCamURL.Items.Add("http://24.103.196.243:80/cgi-bin/viewer/video.jpg")


        cboIPCamURL.Items.Add("rtsp://116.197.222.158:554/live/ch00_0")
        cboIPCamURL.Items.Add("Custom")
        cboIPCamURL.SelectedIndex = 0


    End Sub

    Private Sub Command1_Click(sender As System.Object, e As System.EventArgs) Handles Command1.Click
        Dim iResult As Integer

        AxVideoCap1.StopIPCamera()
        AxVideoCap1.CaptureMode = False
        AxVideoCap1.PreviewCaptureAudio = chkpreviewaudio.Checked
        AxVideoCap1.IPCameraOpenURLTimeout = txtTimeout.Text
        If cboIPCamURL.SelectedIndex = 3 Then

            iResult = AxVideoCap1.StartIPCamera(Text1.Text, txtUserID.Text, txtPass.Text)

        Else
            iResult = AxVideoCap1.StartIPCamera(cboIPCamURL.Text, txtUserID.Text, txtPass.Text)
        End If




        If iResult <> 1 Then

            If iResult = -8 Then MessageBox.Show("The URL is empty")

            If iResult = -7 Then MessageBox.Show("Video Compressor cannot use, please select another one")

            If iResult = -6 Then MessageBox.Show("Capture Filename empty")

            If iResult = -5 Then MessageBox.Show("General network error")

            If iResult = -4 Then MessageBox.Show("Authentication failure")

            If iResult = -3 Then MessageBox.Show("Invalid Stream, not support this stream")

            If iResult = -2 Then MessageBox.Show("Filter failure")

            If iResult = -1 Then MessageBox.Show("Create Graph failure")

        End If



    End Sub

    Private Sub Command2_Click(sender As System.Object, e As System.EventArgs) Handles Command2.Click
        AxVideoCap1.StopIPCamera()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.SaveFileDialog1.Filter = "JPEG File (*.jpg)|*.jpg"

        Me.SaveFileDialog1.ShowDialog()


        AxVideoCap1.SnapShotJPEG(SaveFileDialog1.FileName, 90)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        AxVideoCap1.ShowFullScreen(True)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim iResult As Integer

        AxVideoCap1.StopIPCamera()
        AxVideoCap1.UseVideoCompressor = chkusevideocomp.Checked
        AxVideoCap1.CaptureMode = True
        AxVideoCap1.VideoCompressor = Me.cboVideoCompressor.SelectedIndex

        Me.SaveFileDialog1.Filter = "AVI File (*.avi)|*.avi"
        Me.SaveFileDialog1.ShowDialog()
        AxVideoCap1.CaptureFileName = SaveFileDialog1.FileName

        AxVideoCap1.PreviewCaptureAudio = chkpreviewaudio.Checked
        If cboIPCamURL.SelectedIndex = 3 Then

            iResult = AxVideoCap1.StartIPCamera(Text1.Text, txtUserID.Text, txtPass.Text)

        Else
            iResult = AxVideoCap1.StartIPCamera(cboIPCamURL.Text, txtUserID.Text, txtPass.Text)
        End If




        If iResult <> 1 Then

            If iResult = -8 Then MessageBox.Show("The URL is empty")

            If iResult = -7 Then MessageBox.Show("Video Compressor cannot use, please select another one")

            If iResult = -6 Then MessageBox.Show("Capture Filename empty")

            If iResult = -5 Then MessageBox.Show("General network error")

            If iResult = -4 Then MessageBox.Show("Authentication failure")

            If iResult = -3 Then MessageBox.Show("Invalid Stream, not support this stream")

            If iResult = -2 Then MessageBox.Show("Filter failure")

            If iResult = -1 Then MessageBox.Show("Create Graph failure")

        End If

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cboIPCamURL_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboIPCamURL.SelectedIndexChanged
        If cboIPCamURL.SelectedIndex = 3 Then
            Text1.Enabled = True
        Else
            Text1.Enabled = False

        End If
    End Sub
End Class
