Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer


        For i = 0 To AxVideoCap1.GetVideoInputCount - 1
            cboVideoInput.Items.Add(AxVideoCap1.GetVideoInputName(i))
        Next

        If cboVideoInput.Items.Count > 0 Then
            cboVideoInput.SelectedIndex = 0
        End If

        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If
    End Sub

    Private Sub Command1_Click(sender As System.Object, e As System.EventArgs) Handles Command1.Click
        AxVideoCap1.VideoInput = cboVideoInput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex

        Me.AxVideoCap1.Start()

        cmdProPage.Enabled = True

        If Me.AxVideoCap1.CameraFocus.Available Then

            If AxVideoCap1.CameraFocus.Auto Then
                chkfocusauto.Checked = True
            Else
                chkfocusauto.Checked = False
            End If

            FocusTrackBar.Minimum = AxVideoCap1.CameraFocus.Min
            FocusTrackBar.Maximum = AxVideoCap1.CameraFocus.Max
            FocusTrackBar.Value = AxVideoCap1.CameraFocus.Value
        Else
            FocusTrackBar.Enabled = False

        End If


        If Me.AxVideoCap1.Brightness.Available Then
            Me.BrightnessSlider1.Minimum = Me.AxVideoCap1.Brightness.Min
            Me.BrightnessSlider1.Maximum = Me.AxVideoCap1.Brightness.Max
            Me.BrightnessSlider1.Value = Me.AxVideoCap1.Brightness.Value
        Else
            Me.BrightnessSlider1.Enabled = False
        End If



        If Me.AxVideoCap1.Contrast.Available Then
            Me.ContrastSlider1.Maximum = Me.AxVideoCap1.Contrast.Min
            Me.ContrastSlider1.Maximum = Me.AxVideoCap1.Contrast.Max
            Me.ContrastSlider1.Value = Me.AxVideoCap1.Contrast.Value
        Else
            Me.ContrastSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.Hue.Available Then
            Me.HueSlider1.Minimum = Me.AxVideoCap1.Hue.Min
            Me.HueSlider1.Maximum = Me.AxVideoCap1.Hue.Max
            Me.HueSlider1.Value = Me.AxVideoCap1.Hue.Value
        Else
            Me.HueSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.Saturation.Available Then
            Me.SaturationSlider1.Minimum = Me.AxVideoCap1.Saturation.Min
            Me.SaturationSlider1.Maximum = Me.AxVideoCap1.Saturation.Max
            Me.SaturationSlider1.Value = Me.AxVideoCap1.Saturation.Value
        Else
            Me.SaturationSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Sharpness.Available Then
            Me.SharpnessSlider1.Minimum = Me.AxVideoCap1.Sharpness.Min
            Me.SharpnessSlider1.Maximum = Me.AxVideoCap1.Sharpness.Max
            Me.SharpnessSlider1.Value = Me.AxVideoCap1.Sharpness.Value
        Else
            Me.SharpnessSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Gamma.Available Then
            Me.GammaSlider1.Minimum = Me.AxVideoCap1.Gamma.Min
            Me.GammaSlider1.Maximum = Me.AxVideoCap1.Gamma.Max
            Me.GammaSlider1.Value = Me.AxVideoCap1.Gamma.Value
        Else
            Me.GammaSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.ColorEnable.Available Then
            Me.ColorEnableSlider1.Minimum = Me.AxVideoCap1.ColorEnable.Min
            Me.ColorEnableSlider1.Maximum = Me.AxVideoCap1.ColorEnable.Max
            Me.ColorEnableSlider1.Value = Me.AxVideoCap1.ColorEnable.Value
        Else
            Me.ColorEnableSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.WhiteBalance.Available Then

            If AxVideoCap1.WhiteBalance.Auto Then
                chkwhitebalauto.Checked = True
            Else
                chkwhitebalauto.Checked = False
            End If

            Me.WhiteBalanceSlider1.Minimum = Me.AxVideoCap1.WhiteBalance.Min
            Me.WhiteBalanceSlider1.Maximum = Me.AxVideoCap1.WhiteBalance.Max
            Me.WhiteBalanceSlider1.Value = Me.AxVideoCap1.WhiteBalance.Value
        Else
            Me.WhiteBalanceSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.BacklightCompensation.Available Then
            Me.BacklightCompensationSlider1.Minimum = Me.AxVideoCap1.BacklightCompensation.Min
            Me.BacklightCompensationSlider1.Maximum = Me.AxVideoCap1.BacklightCompensation.Max
            Me.BacklightCompensationSlider1.Value = Me.AxVideoCap1.BacklightCompensation.Value
        Else
            Me.BacklightCompensationSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Gain.Available Then
            Me.GainSlider1.Minimum = Me.AxVideoCap1.Gain.Min
            Me.GainSlider1.Maximum = Me.AxVideoCap1.Gain.Max
            Me.GainSlider1.Value = Me.AxVideoCap1.Gain.Value
        Else
            Me.GainSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Zoom.Available Then
            Me.ZoomSlider1.Minimum = Me.AxVideoCap1.Zoom.Min
            Me.ZoomSlider1.Maximum = Me.AxVideoCap1.Zoom.Max
            Me.ZoomSlider1.Value = Me.AxVideoCap1.Zoom.Value
        Else
            Me.ZoomSlider1.Enabled = False
        End If

    End Sub

    Private Sub cmdProPage_Click(sender As System.Object, e As System.EventArgs) Handles cmdProPage.Click
        Me.AxVideoCap1.ShowVideoCapturePropertyPage(0)
    End Sub

    Private Sub BrightnessSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles BrightnessSlider1.Scroll
        AxVideoCap1.Brightness().Value = Me.BrightnessSlider1.Value
    End Sub

    Private Sub ContrastSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles ContrastSlider1.Scroll
        AxVideoCap1.Contrast.Value = Me.ContrastSlider1.Value
    End Sub

    Private Sub HueSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles HueSlider1.Scroll
        AxVideoCap1.Hue.Value = Me.HueSlider1.Value
    End Sub

    Private Sub SaturationSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles SaturationSlider1.Scroll
        AxVideoCap1.Saturation.Value = Me.SaturationSlider1.Value
    End Sub

    Private Sub SharpnessSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles SharpnessSlider1.Scroll
        AxVideoCap1.Sharpness.Value = Me.SharpnessSlider1.Value
    End Sub

    Private Sub GammaSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles GammaSlider1.Scroll
        AxVideoCap1.Gamma.Value = Me.GammaSlider1.Value
    End Sub

    Private Sub ColorEnableSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles ColorEnableSlider1.Scroll
        AxVideoCap1.ColorEnable.Value = Me.ColorEnableSlider1.Value
    End Sub

    Private Sub WhiteBalanceSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles WhiteBalanceSlider1.Scroll
        AxVideoCap1.WhiteBalance.Value = Me.WhiteBalanceSlider1.Value
    End Sub

    Private Sub BacklightCompensationSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles BacklightCompensationSlider1.Scroll
        AxVideoCap1.BacklightCompensation.Value = Me.BacklightCompensationSlider1.Value
    End Sub

    Private Sub GainSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles GainSlider1.Scroll
        AxVideoCap1.Gain.Value = Me.GainSlider1.Value
    End Sub

    Private Sub ZoomSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles ZoomSlider1.Scroll
        AxVideoCap1.Zoom.Value = Me.ZoomSlider1.Value
    End Sub

    Private Sub FocusTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles FocusTrackBar.Scroll
        AxVideoCap1.CameraFocus.Value = Me.FocusTrackBar.Value
    End Sub

    Private Sub chkfocusauto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkfocusauto.CheckedChanged
        If AxVideoCap1.CameraFocus.Available Then

            If chkfocusauto.Checked Then

                AxVideoCap1.CameraFocus.Auto = True
                FocusTrackBar.Enabled = False

            Else

                AxVideoCap1.CameraFocus.Auto = False
                FocusTrackBar.Enabled = True

            End If
        End If
    End Sub

    Private Sub chkwhitebalauto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkwhitebalauto.CheckedChanged
        If AxVideoCap1.WhiteBalance.Available Then


            If chkwhitebalauto.Checked Then

                AxVideoCap1.WhiteBalance.Auto = True
                WhiteBalanceSlider1.Enabled = False

            Else

                AxVideoCap1.WhiteBalance.Auto = False
                WhiteBalanceSlider1.Enabled = True



            End If
        End If
    End Sub
End Class
