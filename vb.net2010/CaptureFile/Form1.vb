﻿Public Class Form1

    Public clrHashBrushBackColor As Color
    Public clrHashBrushForeColor As Color
    Public clrTranColor As Color

    Private Sub AddStillPinVideoFormat()
        Dim i As Integer
        Dim strStillPinName As String

        cbostillpin.Items.Clear()
        For i = 0 To AxVideoCap1.StillPinVideoFormats.Count - 1
            strStillPinName = AxVideoCap1.StillPinVideoFormats.FindVideoFormatName(i)
            cbostillpin.Items.Add(strStillPinName)
        Next

        If cbostillpin.Items.Count > 0 Then

            cbostillpin.SelectedIndex = 0
        End If


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim strVideoCompName As String
        Dim strAudioCompName As String
        Dim bFindDivx As Boolean
        Dim strApp As String
        Dim iFindIndex As Integer

        strApp = Application.ExecutablePath
        iFindIndex = strApp.IndexOf("Examples")

        If iFindIndex <> -1 Then
            strApp = strApp.Substring(0, iFindIndex)

            txtImage.Text = strApp + "\image.bmp"
            txttextureimage.Text = strApp + "\image.bmp"
        End If

        clrHashBrushForeColor = Color.FromArgb(255, 255, 255)
        clrHashBrushBackColor = Color.FromArgb(0, 0, 0)

        For i = 0 To AxVideoCap1.GetPlaybackDeviceCount - 1
            cboplaybackdevice.Items.Add(AxVideoCap1.GetPlaybackDeviceName(i))
        Next
        If cboplaybackdevice.Items.Count > 0 Then
            cboplaybackdevice.SelectedIndex = 0
        End If

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





        For i = 0 To AxVideoCap1.GetAudioDeviceCount - 1
            cboAudioDevice.Items.Add(AxVideoCap1.GetAudioDeviceName(i))
        Next

        If cboAudioDevice.Items.Count > 0 Then
            cboAudioDevice.SelectedIndex = 0
        End If

        For i = 0 To AxVideoCap1.GetAudioInputPinCount - 1
            cboaudioinput.Items.Add(AxVideoCap1.GetAudioInputPinName(i))
        Next

        If cboaudioinput.Items.Count > 0 Then
            cboaudioinput.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap1.GetAudioCompressorCount - 1
            strAudioCompName = AxVideoCap1.GetAudioCompressorName(i)
            cboaudiocomp.Items.Add(strAudioCompName)

            If strAudioCompName = "PCM" Then
                cboaudiocomp.SelectedIndex = i
            End If

        Next


        bFindDivx = False

        For i = 0 To AxVideoCap1.GetVideoCompressorCount - 1
            strVideoCompName = AxVideoCap1.GetVideoCompressorName(i)
            cbovideocomp.Items.Add(strVideoCompName)

            If strVideoCompName.Substring(0, 4) = "DivX" And bFindDivx = False Then
                cbovideocomp.SelectedIndex = i
                bFindDivx = True

            End If


            If strVideoCompName = "Microsoft Video 1" And bFindDivx = False Then
                cbovideocomp.SelectedIndex = i
            End If


        Next



        cbovideostand.Items.Add("Digital sensor")
        cbovideostand.Items.Add("NTSC (M) standard, 7.5 IRE black")
        cbovideostand.Items.Add("NTSC (M) standard, 0 IRE black (Japan)")
        cbovideostand.Items.Add("NTSC-433")
        cbovideostand.Items.Add("PAL -B standard")
        cbovideostand.Items.Add("PAL (D) standard")
        cbovideostand.Items.Add("PAL (H) standard")
        cbovideostand.Items.Add("PAL (I) standard")
        cbovideostand.Items.Add("PAL (M) standard")
        cbovideostand.Items.Add("PAL (N) standard")
        cbovideostand.Items.Add("PAL-60 standard")
        cbovideostand.Items.Add("SECAM (B) standard")
        cbovideostand.Items.Add("SECAM (D) standard")
        cbovideostand.Items.Add("SECAM (G) standard")
        cbovideostand.Items.Add("SECAM (H) standard")
        cbovideostand.Items.Add("SECAM (K) standard")
        cbovideostand.Items.Add("SECAM (K1) standard")
        cbovideostand.Items.Add("SECAM (L) standard")
        cbovideostand.Items.Add("SECAM (L1) standard")
        cbovideostand.Items.Add("Combination (N) PAL standard (Argentina) ")

        cbovideostand.SelectedIndex = 0

        cborotate.Items.Add("No Rotation")
        cborotate.Items.Add("90-degree rotation without flipping")
        cborotate.Items.Add("180-degree rotation without flipping")
        cborotate.Items.Add("270-degree rotation without flipping")
        cborotate.Items.Add("no rotation and a horizontal flip")
        cborotate.Items.Add("90-degree rotation followed by a horizontal flip")
        cborotate.Items.Add("180-degree rotation followed by a horizontal flip")
        cborotate.Items.Add("270-degree rotation followed by a horizontal flip")
        cborotate.Items.Add("no rotation and a vertical flip")
        cborotate.Items.Add("90-degree rotation followed by a vertical flip")
        cborotate.Items.Add("180-degree rotation followed by a vertical flip")
        cborotate.Items.Add("270-degree rotation followed by a vertical flip")
        cborotate.Items.Add("90-degree rotation with stretch mode")
        cborotate.Items.Add("270-degree rotation with stretch mode")
        cborotate.SelectedIndex = 0


        For i = 0 To AxVideoCap1.GetWMVProfileCount - 1
            cbowmvprofile.Items.Add(AxVideoCap1.GetWMVProfileName(i))
        Next

        If cbowmvprofile.Items.Count > 0 Then
            cbowmvprofile.SelectedIndex = 0
        End If


        cbodateformat.Items.Add("mm/dd/yyyy")
        cbodateformat.Items.Add("dd/mm/yyyy")
        cbodateformat.Items.Add("mm.dd.yyyy")
        cbodateformat.Items.Add("dd.mm.yyyy")
        cbodateformat.Items.Add("hh:mm:ss")
        cbodateformat.Items.Add("hh:mm")
        cbodateformat.Items.Add("mm:ss")
        cbodateformat.Items.Add("mm/dd/yyyy hh:mm:ss")
        cbodateformat.Items.Add("dd/mm/yyyy hh:mm:ss")
        cbodateformat.Items.Add("mm.dd.yyyy hh:mm:ss")
        cbodateformat.Items.Add("dd.mm.yyyy hh:mm:ss")
        cbodateformat.Items.Add("mm/dd/yyyy hh:mm")
        cbodateformat.Items.Add("dd/mm/yyyy hh:mm")
        cbodateformat.Items.Add("mm.dd.yyyy hh:mm")
        cbodateformat.Items.Add("dd.mm.yyyy hh:mm")
        cbodateformat.Items.Add("mm/dd/yyyy.mm:ss")
        cbodateformat.Items.Add("dd/mm/yyyy.mm:ss")
        cbodateformat.Items.Add("mm.dd.yyyy.mm:ss")
        cbodateformat.Items.Add("dd.mm.yyyy.mm:ss")
        cbodateformat.SelectedIndex = 0

        cbodatefontstyle.Items.Add("Regular")
        cbodatefontstyle.Items.Add("Bold")
        cbodatefontstyle.Items.Add("Italic")
        cbodatefontstyle.Items.Add("BoldItalic")
        cbodatefontstyle.Items.Add("Underline")
        cbodatefontstyle.SelectedIndex = 0

        cbodatefontname.Items.Add("Arial")
        cbodatefontname.Items.Add("AirCut")
        cbodatefontname.Items.Add("Arial Black")
        cbodatefontname.Items.Add("Comic Sans MS")
        cbodatefontname.Items.Add("Times New Roman")
        cbodatefontname.SelectedIndex = 0

        For i = 8 To 60 Step 2
            cbodatefontsize.Items.Add(Trim(Str(i)))
        Next
        cbodatefontsize.SelectedIndex = 3

        cbofontstyle.Items.Add("Regular")
        cbofontstyle.Items.Add("Bold")
        cbofontstyle.Items.Add("Italic")
        cbofontstyle.Items.Add("BoldItalic")
        cbofontstyle.Items.Add("Underline")
        cbofontstyle.SelectedIndex = 0

        cbofontname.Items.Add("Arial")
        cbofontname.Items.Add("AirCut")
        cbofontname.Items.Add("Arial Black")
        cbofontname.Items.Add("Comic Sans MS")
        cbofontname.Items.Add("Times New Roman")
        cbofontname.SelectedIndex = 0

        For i = 8 To 60 Step 2
            cbofontsize.Items.Add(Trim(Str(i)))
        Next
        cbofontsize.SelectedIndex = 3

        cbotextstyle.Items.Add("Normal")
        cbotextstyle.Items.Add("Outline Text")
        cbotextstyle.Items.Add("Filled Outline")
        cbotextstyle.Items.Add("Hatch Brush")
        cbotextstyle.Items.Add("TextureBrush")
        cbotextstyle.SelectedIndex = 0

        cbohashbrushstyle.Items.Add("HatchStyleHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleForwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleBackwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleCross ")
        cbohashbrushstyle.Items.Add("HatchStyleDiagonalCross ")
        cbohashbrushstyle.Items.Add("HatchStyle05Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle10Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle20Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle25Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle30Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle40Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle50Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle60Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle70Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle75Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle80Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle90Percent ")
        cbohashbrushstyle.Items.Add("HatchStyleLightDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleLightUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleWideDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleWideUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleLightVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleLightHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleNarrowVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleNarrowHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallConfetti ")
        cbohashbrushstyle.Items.Add("HatchStyleLargeConfetti ")
        cbohashbrushstyle.Items.Add("HatchStyleZigZag ")
        cbohashbrushstyle.Items.Add("HatchStyleWave ")
        cbohashbrushstyle.Items.Add("HatchStyleDiagonalBrick ")
        cbohashbrushstyle.Items.Add("HatchStyleHorizontalBrick ")
        cbohashbrushstyle.Items.Add("HatchStyleWeave ")
        cbohashbrushstyle.Items.Add("HatchStylePlaid ")
        cbohashbrushstyle.Items.Add("HatchStyleDivot ")
        cbohashbrushstyle.Items.Add("HatchStyleDottedGrid ")
        cbohashbrushstyle.Items.Add("HatchStyleDottedDiamond ")
        cbohashbrushstyle.Items.Add("HatchStyleShingle ")
        cbohashbrushstyle.Items.Add("HatchStyleTrellis ")
        cbohashbrushstyle.Items.Add("HatchStyleSphere ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallGrid ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallCheckerBoard ")
        cbohashbrushstyle.Items.Add("HatchStyleLargeCheckerBoard ")
        cbohashbrushstyle.Items.Add("HatchStyleOutlinedDiamond ")
        cbohashbrushstyle.Items.Add("HatchStyleSolidDiamond ")
        cbohashbrushstyle.Items.Add("HatchStyleTotal ")
        cbohashbrushstyle.SelectedIndex = 0

        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 320x240")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 640x480")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 800x600")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 1024x768")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 1280x1024")
        cbowmv9profile.SelectedIndex = 0

        AddStillPinVideoFormat()
    End Sub

    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function
    Private Sub btnpreview_Click(sender As System.Object, e As System.EventArgs) Handles btnpreview.Click
        Dim iDateFormat As Integer

        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = AxVideoCap1.VideoFormats.FindVideoFormat(cbovideoformat.Text)
        AxVideoCap1.VideoStandard = cbovideostand.SelectedIndex
        AxVideoCap1.AudioInputPin = cboaudioinput.SelectedIndex

        AxVideoCap1.AudioDevice = cboAudioDevice.SelectedIndex

        AxVideoCap1.SyncMode = 1

        AxVideoCap1.EffectType = VIDEOCAPLib.MYVIDEOCAPEFFECTTYPE.OVERLAY
        AxVideoCap1.StillPinVideoFormat = cbostillpin.SelectedIndex

        If chkuseSpectrum.Checked Then

            AxVideoCap1.UseSpectrum = True
            AxVideoCap1.PreviewCaptureAudio = True

        Else

            AxVideoCap1.UseSpectrum = False
            AxVideoCap1.PreviewCaptureAudio = False
        End If

        AxVideoCap1.SpectrumOwner = pictureBox1.Handle
        AxVideoCap1.SpectrumWidth = pictureBox1.Width
        AxVideoCap1.SpectrumHeight = pictureBox1.Height

        AxVideoCap1.Start()

        iDateFormat = cbodateformat.SelectedIndex
        AxVideoCap1.DrawText(0, txtfontleft.Text, txtfonttop.Text, txtText1.Text + Chr(13) + Chr(10) + txtText2.Text)
        AxVideoCap1.DrawTime(txtdateleft.Text, txtdatetop.Text, iDateFormat)
        AxVideoCap1.DrawImage(0, txtimageleft.Text, txtimagetop.Text, txtImage.Text, Color2Uint32(clrTranColor), TrackBar1.Value)
    End Sub

    Private Sub btncapture_Click(sender As System.Object, e As System.EventArgs) Handles btncapture.Click
        Dim strApp As String
        Dim iFindIndex As Integer

        Dim iresult As Integer
        Dim iDateFormat As Integer



        If RadioButton1.Checked Then ' avi
            SaveFileDialog1.Filter = "AVI file (*.avi)|*.avi||"
            SaveFileDialog1.DefaultExt = "avi"
            AxVideoCap1.VideoCompressor = cbovideocomp.SelectedIndex
            AxVideoCap1.AudioCompressor = cboaudiocomp.SelectedIndex


            AxVideoCap1.UseAudioCompressor = chkuseaudiocomp.Checked
            AxVideoCap1.UseVideoCompressor = chkusevideocomp.Checked
            AxVideoCap1.OutputWMV = False

        End If

        If RadioButton2.Checked Then


            If cboAudioDevice.Items.Count = 0 Then
                MsgBox("Cannot save to wmv file, because you have not audio device, by default wmv profile must include video and audio stream, you need create custom profile without audio stream")
                Exit Sub
            End If
            SaveFileDialog1.Filter = "WMV file (*.wmv)|*.wmv||"
            SaveFileDialog1.DefaultExt = "wmv"

            AxVideoCap1.WMVProfile = cbowmvprofile.SelectedIndex
            AxVideoCap1.OutputWMV = True


        End If

        If RadioButton3.Checked Then


            If cboAudioDevice.Items.Count = 0 Then
                MsgBox("Cannot save to wmv file, because you have not audio device, by default wmv profile must include video and audio stream, you need create custom profile without audio stream")
                Exit Sub
            End If
            SaveFileDialog1.Filter = "WMV file (*.wmv)|*.wmv||"
            SaveFileDialog1.DefaultExt = "wmv"

            AxVideoCap1.WMVProfile = cbowmvprofile.SelectedIndex
            AxVideoCap1.OutputWMV = True

            strApp = Application.ExecutablePath
            iFindIndex = strApp.IndexOf("Examples")

            strApp = strApp.Substring(0, iFindIndex) + "Profiles"


            Select Case cbowmv9profile.SelectedIndex
                Case 0

                    AxVideoCap1.WMVCustomFileName = strApp + "\320x240.prx"
                Case 1
                    AxVideoCap1.WMVCustomFileName = strApp + "\640x480.prx"
                Case 2
                    AxVideoCap1.WMVCustomFileName = strApp + "\800x600.prx"
                Case 3
                    AxVideoCap1.WMVCustomFileName = strApp + "\1024x768.prx"
                Case 4
                    AxVideoCap1.WMVCustomFileName = strApp + "\1280x1024.prx"


            End Select



        End If






        SaveFileDialog1.ShowDialog()

        AxVideoCap1.CaptureFileName = SaveFileDialog1.FileName
        AxVideoCap1.CaptureMode = True
        AxVideoCap1.CaptureAudio = True
        AxVideoCap1.CaptureVideo = True

        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoCap1.VideoStandard = cbovideostand.SelectedIndex
        AxVideoCap1.AudioInputPin = cboaudioinput.SelectedIndex
        AxVideoCap1.SyncMode = 1
        AxVideoCap1.EffectType = VIDEOCAPLib.MYVIDEOCAPEFFECTTYPE.OVERLAY

        AxVideoCap1.AudioDevice = cboAudioDevice.SelectedIndex

        AxVideoCap1.PlaybackDevice = cboplaybackdevice.SelectedIndex
        If chkuseSpectrum.Checked Then

            AxVideoCap1.UseSpectrum = True
            AxVideoCap1.PreviewCaptureAudio = True

        Else

            AxVideoCap1.UseSpectrum = False
            AxVideoCap1.PreviewCaptureAudio = False
        End If

        AxVideoCap1.SpectrumOwner = pictureBox1.Handle
        AxVideoCap1.SpectrumWidth = pictureBox1.Width
        AxVideoCap1.SpectrumHeight = pictureBox1.Height
        iresult = AxVideoCap1.Start()

        If iresult = -1 Then
            MsgBox("Capture failure, selected wrong video/audio compressor ")

        End If


        If chkhue.Checked Then
            AxVideoCap1.ChangeHue(txthuer.Text, txthueg.Text, txthueb.Text)

        End If

        If chklightness.Checked Then
            AxVideoCap1.ChangeLigthness(txtlightnessr.Text, txtlightnessr.Text, txtlightnessr.Text)

        End If
        AxVideoCap1.Rotate(cborotate.SelectedIndex)

        If chkinvertcolor.Checked Then

            AxVideoCap1.InvertColor(True)
        Else
            AxVideoCap1.InvertColor(False)
        End If


        iDateFormat = cbodateformat.SelectedIndex
        AxVideoCap1.DrawText(0, txtfontleft.Text, txtfonttop.Text, txtText1.Text + Chr(13) + Chr(10) + txtText2.Text)
        AxVideoCap1.DrawTime(txtdateleft.Text, txtdatetop.Text, iDateFormat)
        AxVideoCap1.DrawImage(0, txtimageleft.Text, txtimagetop.Text, txtImage.Text, Color2Uint32(clrTranColor), TrackBar1.Value)

    End Sub

    Private Sub btnstopcapture_Click(sender As System.Object, e As System.EventArgs) Handles btnstopcapture.Click
        Dim iDateFormat As Integer
        AxVideoCap1.CaptureMode = False
        AxVideoCap1.Stop()
        AxVideoCap1.Start()
        iDateFormat = cbodateformat.SelectedIndex

        AxVideoCap1.Rotate(cborotate.SelectedIndex)

        If chkinvertcolor.Checked Then

            AxVideoCap1.InvertColor(True)
        Else
            AxVideoCap1.InvertColor(False)
        End If

        AxVideoCap1.DrawText(0, txtfontleft.Text, txtfonttop.Text, txtText1.Text + Chr(13) + Chr(10) + txtText2.Text)
        AxVideoCap1.DrawTime(txtdateleft.Text, txtdatetop.Text, iDateFormat)
        AxVideoCap1.DrawImage(0, txtimageleft.Text, txtimagetop.Text, txtImage.Text, Color2Uint32(clrTranColor), TrackBar1.Value)
    End Sub

    Private Sub btnpause_Click(sender As System.Object, e As System.EventArgs) Handles btnpause.Click
        AxVideoCap1.Pause()
    End Sub

    Private Sub btnresume_Click(sender As System.Object, e As System.EventArgs) Handles btnresume.Click
        AxVideoCap1.Resume()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        AxVideoCap1.ShowFullScreen(True)
    End Sub

    Private Sub BtnStillPinSnapshot_Click(sender As System.Object, e As System.EventArgs) Handles BtnStillPinSnapshot.Click
        SaveFileDialog1.Filter = "JPEG file (*.jpg)|*.jpg||"
        SaveFileDialog1.DefaultExt = "jpg"
        SaveFileDialog1.ShowDialog()
        AxVideoCap1.SnapShotJPEG(SaveFileDialog1.FileName, 99)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.DateColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim iDateFormat As Integer
        iDateFormat = cbodateformat.SelectedIndex
        AxVideoCap1.DrawTime(txtdateleft.Text, txtdatetop.Text, iDateFormat)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        AxVideoCap1.ChangeHue(-1, -1, -1)
        txthuer.Text = "-1"
        txthueg.Text = "-1"
        txthueb.Text = "-1"
    End Sub

    Private Sub chkinvertcolor_Click(sender As System.Object, e As System.EventArgs) Handles chkinvertcolor.Click
        If chkinvertcolor.Checked Then

            If cborotate.SelectedIndex = 1 Or cborotate.SelectedIndex = 3 Or cborotate.SelectedIndex = 5 Or cborotate.SelectedIndex = 7 Or cborotate.SelectedIndex = 11 Or cborotate.SelectedIndex = 12 Or cborotate.SelectedIndex = 13 Then
                MsgBox("You selected rotate value cannot support invert color")
            End If

            AxVideoCap1.InvertColor(True)
        Else
            AxVideoCap1.InvertColor(False)
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        AxVideoCap1.ChangeHue(txthuer.Text, txthueg.Text, txthueb.Text)
    End Sub

    Private Sub chkhue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkhue.CheckedChanged
        If chkhue.Checked Then

            txthuer.Enabled = True
            txthueg.Enabled = True
            txthueb.Enabled = True
        Else
            txthuer.Enabled = False
            txthueg.Enabled = False
            txthueb.Enabled = False

            AxVideoCap1.ChangeHue(-1, -1, -1)
            txthuer.Text = "-1"
            txthueg.Text = "-1"
            txthueb.Text = "-1"

        End If
    End Sub

    Private Sub cborotate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cborotate.SelectedIndexChanged
        If cborotate.SelectedIndex = 1 Or cborotate.SelectedIndex = 3 Or cborotate.SelectedIndex = 5 Or cborotate.SelectedIndex = 7 Or cborotate.SelectedIndex = 11 Or cborotate.SelectedIndex = 12 Or cborotate.SelectedIndex = 13 Then
            If chkinvertcolor.Checked Then
                MsgBox("You selected rotate value cannot support invert color")
            End If

            If chkgrayscale.Checked Then
                MsgBox("You selected rotate value cannot support grayscale")
            End If

        End If


        AxVideoCap1.Rotate(cborotate.SelectedIndex)
    End Sub

    Private Sub chkgrayscale_Click(sender As System.Object, e As System.EventArgs) Handles chkgrayscale.Click
        If chkgrayscale.Checked Then

            If cborotate.SelectedIndex = 1 Or cborotate.SelectedIndex = 3 Or cborotate.SelectedIndex = 5 Or cborotate.SelectedIndex = 7 Or cborotate.SelectedIndex = 11 Or cborotate.SelectedIndex = 12 Or cborotate.SelectedIndex = 13 Then
                MsgBox("You selected rotate value cannot support grayscale color")
            End If

            AxVideoCap1.GrayScale(True)
        Else
            AxVideoCap1.GrayScale(False)
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        AxVideoCap1.ChangeLigthness(-1, -1, -1)

        txtlightnessr.Text = -1
        txtlightnessg.Text = -1
        txtlightnessb.Text = -1
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        AxVideoCap1.ChangeLigthness(txtlightnessr.Text, txtlightnessg.Text, txtlightnessb.Text)

    End Sub

    Private Sub chklightness_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chklightness.CheckedChanged
        If chklightness.Checked Then

            txtlightnessr.Enabled = True
            txtlightnessg.Enabled = True
            txtlightnessb.Enabled = True
        Else
            txtlightnessr.Enabled = False
            txtlightnessg.Enabled = False
            txtlightnessb.Enabled = False

            AxVideoCap1.ChangeLigthness(-1, -1, -1)

            txtlightnessr.Text = -1
            txtlightnessg.Text = -1
            txtlightnessb.Text = -1

        End If
    End Sub

    Private Sub cbofontstyle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbofontstyle.SelectedIndexChanged
        AxVideoCap1.TextFontStyle(0, cbofontstyle.SelectedIndex)
    End Sub

    Private Sub cbofontname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbofontname.SelectedIndexChanged
        AxVideoCap1.TextFontName(0, cbofontname.Items.Item(cbofontname.SelectedIndex))

    End Sub

    Private Sub cbofontsize_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbofontsize.SelectedIndexChanged
        AxVideoCap1.TextFontSize(0, Val(cbofontsize.Items.Item(cbofontsize.SelectedIndex)))

    End Sub

    Private Sub cbotextstyle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbotextstyle.SelectedIndexChanged
        AxVideoCap1.TextStyle(0, cbotextstyle.SelectedIndex)

        Select Case cbotextstyle.SelectedIndex
            Case 0
                cmdsolidfontcolor.Enabled = True
                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False
                cmdtextureselimage.Enabled = False
                txttextureimage.Enabled = False
                cmdoutlineborder.Enabled = False
                cmdoutlineback.Enabled = False


            Case 1
                cmdsolidfontcolor.Enabled = False
                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False
                cmdtextureselimage.Enabled = False
                txttextureimage.Enabled = False
                cmdoutlineborder.Enabled = True
                cmdoutlineback.Enabled = False

            Case 2
                cmdsolidfontcolor.Enabled = False
                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False
                cmdtextureselimage.Enabled = False
                txttextureimage.Enabled = False
                cmdoutlineborder.Enabled = True
                cmdoutlineback.Enabled = True

            Case 3
                cmdsolidfontcolor.Enabled = False
                cbohashbrushstyle.Enabled = True
                cmdhashforecolor.Enabled = True
                cmdhashbackcolor.Enabled = True
                cmdtextureselimage.Enabled = False
                txttextureimage.Enabled = False
                cmdoutlineborder.Enabled = False
                cmdoutlineback.Enabled = False

            Case 4

                cmdsolidfontcolor.Enabled = False

                cbohashbrushstyle.Enabled = False
                cmdhashforecolor.Enabled = False
                cmdhashbackcolor.Enabled = False

                cmdtextureselimage.Enabled = True
                txttextureimage.Enabled = True

                If txttextureimage.Text = "" Then
                    MsgBox("Please select Texture Brush image ")
                End If

                AxVideoCap1.SetTextureBrushImage(0, txttextureimage.Text)


        End Select
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        AxVideoCap1.DrawText(0, txtfontleft.Text, txtfonttop.Text, txtText1.Text + Chr(13) + Chr(10) + txtText2.Text)

    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.SpectrumBarColor1 = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.SpectrumBarColor2 = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        AxVideoCap1.SpectrumStereo = True
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        AxVideoCap1.SpectrumStereo = False
    End Sub

    Private Sub cmdtextureselimage_Click(sender As System.Object, e As System.EventArgs) Handles cmdtextureselimage.Click
        OpenFileDialog1.Filter = "BMP file (*.bmp)|*.bmp|JPG file (*.jpg)|*.jpg|GIF file (*.gif)|*.gif||"
        OpenFileDialog1.ShowDialog()
        txttextureimage.Text = OpenFileDialog1.FileName
        AxVideoCap1.SetTextureBrushImage(0, txttextureimage.Text)
    End Sub

    Private Sub cmdsolidfontcolor_Click(sender As System.Object, e As System.EventArgs) Handles cmdsolidfontcolor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.TextColor(0, Color2Uint32(ColorDialog1.Color))
        End If
    End Sub

    Private Sub cmdoutlineborder_Click(sender As System.Object, e As System.EventArgs) Handles cmdoutlineborder.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.SetOutlineTextBorderColor(0, Color2Uint32(ColorDialog1.Color))
        End If
    End Sub

    Private Sub cmdoutlineback_Click(sender As System.Object, e As System.EventArgs) Handles cmdoutlineback.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.SetOutlineTextBackColor(0, Color2Uint32(ColorDialog1.Color))
        End If
    End Sub

    Private Sub cmdhashforecolor_Click(sender As System.Object, e As System.EventArgs) Handles cmdhashforecolor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            clrHashBrushForeColor = ColorDialog1.Color
            AxVideoCap1.SetHashBrushValue(0, cbohashbrushstyle.SelectedIndex, Color2Uint32(clrHashBrushForeColor), Color2Uint32(clrHashBrushBackColor))
        End If
    End Sub

    Private Sub cmdhashbackcolor_Click(sender As System.Object, e As System.EventArgs) Handles cmdhashbackcolor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            clrHashBrushBackColor = ColorDialog1.Color
            AxVideoCap1.SetHashBrushValue(0, cbohashbrushstyle.SelectedIndex, Color2Uint32(clrHashBrushForeColor), Color2Uint32(clrHashBrushBackColor))
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "BMP file (*.bmp)|*.bmp|JPG file (*.jpg)|*.jpg||"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtImage.Text = OpenFileDialog1.FileName
            AxVideoCap1.DrawImage(0, txtimageleft.Text, txtimagetop.Text, txtImage.Text, Color2Uint32(clrTranColor), TrackBar1.Value)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            clrTranColor = ColorDialog1.Color
            AxVideoCap1.DrawImage(0, txtimageleft.Text, txtimagetop.Text, txtImage.Text, Color2Uint32(clrTranColor), TrackBar1.Value)
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        AxVideoCap1.DrawImage(0, txtimageleft.Text, txtimagetop.Text, txtImage.Text, Color2Uint32(clrTranColor), TrackBar1.Value)

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        AxVideoCap1.DrawImage(0, txtimageleft.Text, txtimagetop.Text, txtImage.Text, Color2Uint32(clrTranColor), TrackBar1.Value)

    End Sub

    Private Sub chkuseaudiocomp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkuseaudiocomp.CheckedChanged

        If chkuseaudiocomp.Checked Then
            cboaudiocomp.Enabled = True
        Else
            cboaudiocomp.Enabled = False

        End If
    End Sub

    Private Sub chkusevideocomp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkusevideocomp.CheckedChanged
        If chkusevideocomp.Checked Then
            cbovideocomp.Enabled = True
        Else
            cbovideocomp.Enabled = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            cbovideocomp.Enabled = False
            cboaudiocomp.Enabled = False
            cbowmvprofile.Enabled = True
            cbowmv9profile.Enabled = False
            chkuseaudiocomp.Enabled = False
            chkusevideocomp.Enabled = False

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            cbovideocomp.Enabled = False
            cboaudiocomp.Enabled = False
            cbowmvprofile.Enabled = False
            cbowmv9profile.Enabled = True
            chkuseaudiocomp.Enabled = False
            chkusevideocomp.Enabled = False
        End If
    End Sub

    Private Sub cbovideodevice_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbovideodevice.SelectedIndexChanged
        Dim i As Integer
        cbovideoinput.Items.Clear()
        cbovideoformat.Items.Clear()
        cbostillpin.Items.Clear()

        AxVideoCap1.RefreshVideoDevice(cbovideodevice.SelectedIndex)

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

        AddStillPinVideoFormat()
    End Sub

    Private Sub cbodatefontstyle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbodatefontstyle.SelectedIndexChanged
        AxVideoCap1.DateFontStyle = cbodatefontstyle.SelectedIndex
    End Sub

    Private Sub cbodatefontname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbodatefontname.SelectedIndexChanged
        AxVideoCap1.DateFontName = cbodatefontname.Items.Item(cbodatefontname.SelectedIndex)

    End Sub

    Private Sub cbodatefontsize_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbodatefontsize.SelectedIndexChanged
        AxVideoCap1.DateFontSize = Val(cbodatefontsize.Items.Item(cbodatefontsize.SelectedIndex))

    End Sub

    Private Sub cbodateformat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbodateformat.SelectedIndexChanged
        Dim iDateFormat As Integer
        iDateFormat = cbodateformat.SelectedIndex
        AxVideoCap1.DrawTime(txtdateleft.Text, txtdatetop.Text, iDateFormat)

    End Sub

 

    Private Sub chkshowdatetime_Click(sender As Object, e As System.EventArgs) Handles chkshowdatetime.Click
        If chkshowdatetime.Checked Then
            AxVideoCap1.ShowDateTime = True
        Else
            AxVideoCap1.ShowDateTime = False
        End If
    End Sub
End Class
