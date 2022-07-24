Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To AxVideoCap1.GetDeviceCount - 1
            cbovideodevice.Items.Add(AxVideoCap1.GetDeviceName(i))
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap1.GetVideoInputCount - 1
            cbovideoinput.Items.Add(AxVideoCap1.GetVideoInputName(i))
        Next



        If cbovideoinput.Items.Count > 0 Then
            cbovideoinput.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnstart_Click(sender As System.Object, e As System.EventArgs) Handles btnstart.Click
        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoFormat = AxVideoCap1.VideoFormats.FindVideoFormat(cbovideoformat.Text)
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.Start()
    End Sub

    Private Sub btnsnapshot_Click(sender As System.Object, e As System.EventArgs) Handles btnsnapshot.Click
        On Error Resume Next
        PictureBox1.Image = AxVideoCap1.SnapShot2Picture()

    End Sub
End Class
