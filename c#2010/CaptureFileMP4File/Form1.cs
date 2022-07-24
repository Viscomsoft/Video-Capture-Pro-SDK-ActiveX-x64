using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        uint clrHashBrushForeColor;
        uint clrHashBrushBackColor;
        uint clrTranColor;
        Color clrDateColor;

        public Form1()
        {
            InitializeComponent();
        }

        public uint Color2Uint32(Color clr)
        {

            int t;
            byte[] a;

            t = ColorTranslator.ToOle(clr);

            a = BitConverter.GetBytes(t);

            return BitConverter.ToUInt32(a, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strApp;
            int iFindIndex;

            strApp = Application.ExecutablePath;
            iFindIndex = strApp.IndexOf("Examples");
            if (iFindIndex != -1)
            {
                strApp = strApp.Substring(0, iFindIndex);

                imgFileTextBox.Text = strApp + "image.bmp";
                imageFileTextBox.Text = strApp + "image.bmp";
            }

            cboGPU.Items.Add("None");
            cboGPU.Items.Add("Nvidia");
            cboGPU.Items.Add("AMD");
            cboGPU.Items.Add("Intel");
            cboGPU.SelectedIndex = 0;

            cbonvidapreset.Items.Add("slow");
            cbonvidapreset.Items.Add("medium");
            cbonvidapreset.Items.Add("fast");
            cbonvidapreset.Items.Add("high performance");
            cbonvidapreset.Items.Add("high quality");
            cbonvidapreset.Items.Add("bluray disk");
            cbonvidapreset.Items.Add("low latency");
            cbonvidapreset.Items.Add("low latency high quality");
            cbonvidapreset.Items.Add("low latency high performance");
            cbonvidapreset.Items.Add("lossless");
            cbonvidapreset.Items.Add("lossless high performance");
            cbonvidapreset.SelectedIndex = 3;


            cboaudiobitrate.Items.Add("96000");
            cboaudiobitrate.Items.Add("128000");
            cboaudiobitrate.Items.Add("160000");
            cboaudiobitrate.Items.Add("192000");
            cboaudiobitrate.SelectedIndex = 0;

            cboaudiosamplerate.Items.Add("48000");
            cboaudiosamplerate.Items.Add("44100");
            cboaudiosamplerate.SelectedIndex = 0;

            this.axVideoCap1.TVMute = true;

            this.clrTranColor = this.Color2Uint32(Color.FromArgb(0, 0, 0));

            this.clrHashBrushForeColor = this.Color2Uint32(Color.FromArgb(255, 255, 255));
            this.clrHashBrushBackColor = this.Color2Uint32(Color.FromArgb(0, 0, 0));

          //this.axVideoCap1.SetHashBrushValue(0, 0, clrHashBrushForeColor, clrHashBrushBackColor);

            this.textStyleComboBox.Items.AddRange(new string[] { "Normal", "Outline Text", "Filled Outline", "Hatch Brush", "TextureBrush" });
            this.textStyleComboBox.SelectedIndex = 0;

            this.rotateComboBox.Items.AddRange(new string[]{"No Rotation","90-degree rotation without flipping","180-degree rotation without flipping","270-degree rotation without flipping",
"no rotation and a horizontal flip","90-degree rotation followed by a horizontal flip","180-degree rotation followed by a horizontal flip",
"270-degree rotation followed by a horizontal flip","no rotation and a vertical flip","90-degree rotation followed by a vertical flip",
"180-degree rotation followed by a vertical flip","270-degree rotation followed by a vertical flip"});
            this.rotateComboBox.SelectedIndex = 0;

            this.styleComboBox.Items.AddRange(new string[]{"HatchStyleHorizontal ","HatchStyleVertical ","HatchStyleForwardDiagonal ",
"HatchStyleBackwardDiagonal ","HatchStyleCross ","HatchStyleDiagonalCross ","HatchStyle05Percent ","HatchStyle10Percent ",
"HatchStyle20Percent ","HatchStyle25Percent ","HatchStyle30Percent ","HatchStyle40Percent ","HatchStyle50Percent ",
"HatchStyle60Percent ","HatchStyle70Percent ","HatchStyle75Percent ","HatchStyle80Percent ","HatchStyle90Percent ",
"HatchStyleLightDownwardDiagonal ","HatchStyleLightUpwardDiagonal ","HatchStyleDarkDownwardDiagonal ","HatchStyleDarkUpwardDiagonal ",
"HatchStyleWideDownwardDiagonal ","HatchStyleWideUpwardDiagonal ","HatchStyleLightVertical ","HatchStyleLightHorizontal ",
"HatchStyleNarrowVertical ","HatchStyleNarrowHorizontal ","HatchStyleDarkVertical ","HatchStyleDarkHorizontal ",
"HatchStyleDashedDownwardDiagonal ","HatchStyleDashedUpwardDiagonal ","HatchStyleDashedHorizontal ","HatchStyleDashedVertical ",
"HatchStyleSmallConfetti ","HatchStyleLargeConfetti ","HatchStyleZigZag ","HatchStyleWave ","HatchStyleDiagonalBrick ",
"HatchStyleHorizontalBrick ","HatchStyleWeave ","HatchStylePlaid ","HatchStyleDivot ","HatchStyleDottedGrid ",
"HatchStyleDottedDiamond ","HatchStyleShingle ","HatchStyleTrellis ","HatchStyleSphere ","HatchStyleSmallGrid ",
"HatchStyleSmallCheckerBoard ","HatchStyleLargeCheckerBoard ","HatchStyleOutlinedDiamond ","HatchStyleSolidDiamond ",
"HatchStyleTotal "});
            this.styleComboBox.SelectedIndex = 0;

            this.dateFormatComboBox.Items.AddRange(new string[]{"mm/dd/yyyy","dd/mm/yyyy","mm.dd.yyyy","dd.mm.yyyy",
"hh:mm:ss","hh:mm","mm:ss","mm/dd/yyyy hh:mm:ss","dd/mm/yyyy hh:mm:ss","mm.dd.yyyy hh:mm:ss",
"dd.mm.yyyy hh:mm:ss","mm/dd/yyyy hh:mm","dd/mm/yyyy hh:mm","mm.dd.yyyy hh:mm","dd.mm.yyyy hh:mm",
"mm/dd/yyyy.mm:ss","dd/mm/yyyy.mm:ss","mm.dd.yyyy.mm:ss","dd.mm.yyyy.mm:ss"});
            this.dateFormatComboBox.SelectedIndex = 0;

            for (int i = 8; i <= 60; i += 2)
            {
                this.fontSizeComboBox.Items.Add(i);
            }
            this.fontSizeComboBox.SelectedIndex = 2;

            for (int i = 8; i <= 60; i += 2)
            {
                this.dateFontSizeComboBox.Items.Add(i);
            }
            this.dateFontSizeComboBox.SelectedIndex = 4;

            this.fontStyleComboBox.Items.AddRange(new string[] { "Regular", "Bold", "Italic", "BoldItalic", "Underline" });
            this.fontStyleComboBox.SelectedIndex = 0;

            this.dateFontStyleComboBox.Items.AddRange(new string[] { "Regular", "Bold", "Italic", "BoldItalic", "Underline" });
            this.dateFontStyleComboBox.SelectedIndex = 0;

            this.fontNameComboBox.Items.AddRange(new string[] { "Arial", "AirCut", "Arial Black", "Comic Sans MS", "Times New Roman" });
            this.fontNameComboBox.SelectedIndex = 0;

            this.dateFontNameComboBox.Items.AddRange(new string[] { "Arial", "AirCut", "Arial Black", "Comic Sans MS", "Times New Roman" });
            this.dateFontNameComboBox.SelectedIndex = 0;

            
            for (int i = 0; i < (int)axVideoCap1.GetPlaybackDeviceCount(); i++)
                this.cboplaybackdevice.Items.Add(axVideoCap1.GetPlaybackDeviceName((short)i));

            if (this.cboplaybackdevice.Items.Count > 0)
            {
                this.cboplaybackdevice.SelectedIndex = 0;
            }

            

           for (int i = 0; i < (int)axVideoCap1.GetAudioInputPinCount(); i++)
              this.audioInputComboBox.Items.Add(axVideoCap1.GetAudioInputPinName((short)i));

           if (this.audioInputComboBox.Items.Count > 0)
           {
               this.audioInputComboBox.SelectedIndex = 0;
            }

         

            for (int i = 0; i < (int)axVideoCap1.GetDeviceCount(); i++)
            {
                this.deviceComboBox.Items.Add(axVideoCap1.GetDeviceName((short)i));
            }
            if (this.deviceComboBox.Items.Count > 0)
            {
                this.deviceComboBox.SelectedIndex = 0;
            }


            for (int i = 0; i < (int)axVideoCap1.GetVideoInputCount(); i++)
            {
                this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName((short)i));
            }
            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }

            for (int i = 0; i < (int)axVideoCap1.GetVideoFormatCount(); i++)
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName((short)i));
            }
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }

            for (int i = 0; i < (int)axVideoCap1.GetAudioDeviceCount(); i++)
            {
                this.audioDeviceComboBox.Items.Add(axVideoCap1.GetAudioDeviceName((short)i));
            }
            if (this.audioDeviceComboBox.Items.Count > 0)
            {
                this.audioDeviceComboBox.SelectedIndex = 0;
            }

          
        }

        private void ControlCap()
        {
            this.axVideoCap1.Device = (short)this.deviceComboBox.SelectedIndex;

            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;

            this.axVideoCap1.VideoFormat = (short)this.videoFormatComboBox.SelectedIndex;

            this.axVideoCap1.AudioDevice = (short)this.audioDeviceComboBox.SelectedIndex;

            this.axVideoCap1.AudioInputPin = (short)this.audioInputComboBox.SelectedIndex;

     
        }

        private void DrawText()
        {
            string myText = this.textBox1.Text + Environment.NewLine + this.textBox2.Text;
            this.axVideoCap1.DrawText(0, (short)this.leftNumericUpDown.Value, (short)this.topNumericUpDown.Value, myText.Trim());
        }

        private void DrawTime()
        {
            this.axVideoCap1.DrawTime((short)this.dateLeftNumericUpDown.Value, (short)this.dateTopNumericUpDown.Value, (short)this.dateFormatComboBox.SelectedIndex);
        }

        private void DrawImage()
        {
            this.axVideoCap1.DrawImage(0, (short)this.imageLeftNumericUpDown.Value, (short)this.imageTopNumericUpDown.Value, this.imgFileTextBox.Text, clrTranColor, (short)this.alphaChannelTrackBar.Value);
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            this.ControlCap();
            this.axVideoCap1.SyncMode = 1;

            this.axVideoCap1.EffectType = 0;

            if (chkuseSpectrum.Checked)
            {
                axVideoCap1.UseSpectrum = true;
                axVideoCap1.PreviewCaptureAudio = true;
            }
            else
            {
                axVideoCap1.UseSpectrum = false;
                axVideoCap1.PreviewCaptureAudio = false;
            }

            axVideoCap1.SpectrumOwner = (int)pictureBox1.Handle;
            axVideoCap1.SpectrumWidth = pictureBox1.Width;
            axVideoCap1.SpectrumHeight = pictureBox1.Height;

            this.axVideoCap1.Start();

            this.axVideoCap1.ShowText(0, this.showTextCheckBox.Checked);
            this.axVideoCap1.ShowImage(0, this.showImageCheckBox.Checked);
            this.axVideoCap1.ShowDateTime = this.showDateCheckBox.Checked;

            this.axVideoCap1.Rotate((short)(this.rotateComboBox.SelectedIndex));

            this.axVideoCap1.TextFontName(0, this.fontNameComboBox.Text);
            this.axVideoCap1.TextFontSize(0, Convert.ToInt16(this.fontSizeComboBox.Text));
            this.axVideoCap1.TextFontStyle(0, (short)this.fontStyleComboBox.SelectedIndex);

            this.DrawText();

            this.DrawTime();

            this.DrawImage();
        }

        private void axVideoCap1_DeviceChange(object sender, EventArgs e)
        {
            MessageBox.Show("device change");
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            this.ControlCap();
            this.saveFileDialog1.Filter = "MP4 File (*.mp4)|*.mp4";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                axVideoCap1.UseMp4EncoderPlugin = true;
                axVideoCap1.Mp4Videobitrate = Convert.ToInt32(txtmp4videobitrate.Text);
                axVideoCap1.Mp4Audiobitrate = Convert.ToInt32(cboaudiobitrate.Text);
                axVideoCap1.Mp4AudioSamplerate = Convert.ToInt32(cboaudiosamplerate.Text);
                axVideoCap1.Mp4FrameRate = (short)Convert.ToInt32(txtmp4framerate.Text);
                axVideoCap1.Mp4Audiochannel = (short)Convert.ToInt32(txtmp4audiochannel.Text);
                axVideoCap1.Mp4Width = (short)Convert.ToInt32(txtmp4width.Text);
                axVideoCap1.Mp4Height = (short)Convert.ToInt32(txtmp4height.Text);
                axVideoCap1.Mp4Title = "My Video";
                axVideoCap1.Mp4GPUCodec = (short)cboGPU.SelectedIndex;
                axVideoCap1.Mp4NVIDAPreset = (short)cbonvidapreset.SelectedIndex;

                this.axVideoCap1.CaptureVideo = this.captureVideoCheckBox.Checked;
                this.axVideoCap1.CaptureAudio = this.captureAudioCheckBox.Checked;

                this.axVideoCap1.ShowPreview = this.showPreviewCheckBox.Checked;
           
                this.axVideoCap1.CaptureMode = true;
                this.axVideoCap1.CaptureFileName = this.saveFileDialog1.FileName;

                this.axVideoCap1.Rotate((short)this.rotateComboBox.SelectedIndex);

                this.axVideoCap1.SyncMode = 1;
                this.axVideoCap1.EffectType = 0;
                axVideoCap1.PlaybackDevice = (short)cboplaybackdevice.SelectedIndex;


                if (chkuseSpectrum.Checked)
                {
                    axVideoCap1.UseSpectrum = true;
                    axVideoCap1.PreviewCaptureAudio = true;
                }
                else
                {
                    axVideoCap1.UseSpectrum = false;
                    axVideoCap1.PreviewCaptureAudio = false;
                }

                axVideoCap1.SpectrumOwner = (int)pictureBox1.Handle;
                axVideoCap1.SpectrumWidth = pictureBox1.Width;
                axVideoCap1.SpectrumHeight = pictureBox1.Height;

                short result = this.axVideoCap1.Start();

                this.axVideoCap1.ShowText(0, this.showTextCheckBox.Checked);
                this.axVideoCap1.ShowImage(0, this.showImageCheckBox.Checked);
                this.axVideoCap1.ShowDateTime = this.showDateCheckBox.Checked;

                this.axVideoCap1.Rotate((short)this.rotateComboBox.SelectedIndex);

                this.axVideoCap1.InvertColor(this.invertColorCheckBox.Checked);

                this.DrawText();
                this.DrawTime();
                this.DrawImage();

                switch (result)
                {
                    case -1:
                        MessageBox.Show("Capture Failure,Video, Audio Compressor not correct or capture file opening");
                        return;
                    case -2:
                        MessageBox.Show("Capture file not found");
                        return;
                }

                this.previewButton.Enabled = false;
                this.captureButton.Enabled = false;
                this.stopButton.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowPreview = true;
            this.axVideoCap1.CaptureMode = false;
            this.axVideoCap1.Stop();

            this.axVideoCap1.Start();

            this.DrawText();
            this.DrawTime();
            this.DrawImage();

            this.axVideoCap1.Rotate((short)this.rotateComboBox.SelectedIndex);

            this.axVideoCap1.InvertColor(this.invertColorCheckBox.Checked);

            this.axVideoCap1.ShowText(0, this.showTextCheckBox.Checked);

            this.axVideoCap1.ShowImage(0, this.showImageCheckBox.Checked);

            this.previewButton.Enabled = true;
            this.captureButton.Enabled = true;
            this.stopButton.Enabled = false;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Pause();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Resume();
        }

        private void invertColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.invertColorCheckBox.Checked)
            {
                switch (this.rotateComboBox.SelectedIndex)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9:
                    case 11:
                        MessageBox.Show("You selected rotate value cannot support invert color");
                        break;
                }
            }

            this.axVideoCap1.InvertColor(this.invertColorCheckBox.Checked);
        }

        private void rotateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.axVideoCap1.Rotate((short)this.rotateComboBox.SelectedIndex);

            switch (this.rotateComboBox.SelectedIndex)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 11:
                    if (this.invertColorCheckBox.Checked)
                    {
                        MessageBox.Show("You selected rotate value cannot support invert color");
                    }
                    return;
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.axVideoCap1.BackgroundColor;
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.BackgroundColor = this.colorDialog1.Color;
            }
        }

        private void videoCompressorButton_Click(object sender, EventArgs e)
        {
         
        }

        private void drawTextButton_Click(object sender, EventArgs e)
        {
            this.DrawText();
        }

        private void fontStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.TextFontStyle(0, (short)this.fontStyleComboBox.SelectedIndex);
        }

        private void fontNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.TextFontName(0, this.fontNameComboBox.Text);
            this.axVideoCap1.TextFontSize(0, Convert.ToInt16(this.fontSizeComboBox.Text));
        }

        private void fontSizeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.TextFontSize(0, Convert.ToInt16(this.fontSizeComboBox.Text));
        }

        private void textStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.TextStyle(0, (short)this.textStyleComboBox.SelectedIndex);

            switch (this.textStyleComboBox.SelectedIndex)
            {
                case 0:
                    this.fontColorButton.Enabled = true;
                    this.styleComboBox.Enabled = false;
                    this.foreColorButton.Enabled = false;
                    this.backColorButton.Enabled = false;
                    this.imageFileButton.Enabled = false;
                    this.imageFileTextBox.Enabled = false;
                    this.outlineBorderColorButton.Enabled = false;
                    this.outlineBackColorButton.Enabled = false;
                    break;

                case 1:
                    this.fontColorButton.Enabled = false;
                    this.styleComboBox.Enabled = false;
                    this.foreColorButton.Enabled = false;
                    this.backColorButton.Enabled = false;
                    this.imageFileButton.Enabled = false;
                    this.imageFileTextBox.Enabled = false;
                    this.outlineBorderColorButton.Enabled = true;
                    this.outlineBackColorButton.Enabled = false;
                    break;

                case 2:
                    this.fontColorButton.Enabled = false;
                    this.styleComboBox.Enabled = false;
                    this.foreColorButton.Enabled = false;
                    this.backColorButton.Enabled = false;
                    this.imageFileButton.Enabled = false;
                    this.imageFileTextBox.Enabled = false;
                    this.outlineBorderColorButton.Enabled = true;
                    this.outlineBackColorButton.Enabled = true;
                    break;

                case 3:
                    this.fontColorButton.Enabled = false;
                    this.styleComboBox.Enabled = true;
                    this.foreColorButton.Enabled = true;
                    this.backColorButton.Enabled = true;
                    this.imageFileButton.Enabled = false;
                    this.imageFileTextBox.Enabled = false;
                    this.outlineBorderColorButton.Enabled = false;
                    this.outlineBackColorButton.Enabled = false;
                    break;

                case 4:
                    this.fontColorButton.Enabled = false;
                    this.styleComboBox.Enabled = false;
                    this.foreColorButton.Enabled = false;
                    this.backColorButton.Enabled = false;
                    this.imageFileButton.Enabled = true;
                    this.imageFileTextBox.Enabled = true;
                    if (string.IsNullOrEmpty(this.imageFileTextBox.Text))
                    {
                        MessageBox.Show("Please select Texture Brush image");
                    }
                    break;
            }
        }

        private void showTextCheckBox_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowText(0, this.showTextCheckBox.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                axVideoCap1.SpectrumBarColor1 = this.colorDialog1.Color;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                axVideoCap1.SpectrumBarColor2 = this.colorDialog1.Color;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axVideoCap1.SpectrumStereo = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVideoCap1.SpectrumStereo = false;
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.TextColor(0, this.Color2Uint32(this.colorDialog1.Color));
            }
        }

        private void outlineBorderColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.SetOutlineTextBorderColor(0, this.Color2Uint32(this.colorDialog1.Color));
            }
        }

        private void outlineBackColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.SetOutlineTextBackColor(0, this.Color2Uint32(this.colorDialog1.Color));
            }
        }

        private void styleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.SetHashBrushValue(0, (short)this.styleComboBox.SelectedIndex, clrHashBrushForeColor, clrHashBrushBackColor);
 
        }

        private void foreColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.clrHashBrushForeColor = this.Color2Uint32(this.colorDialog1.Color);
            }
            this.axVideoCap1.SetHashBrushValue(0, (short)this.styleComboBox.SelectedIndex, this.clrHashBrushForeColor, this.clrHashBrushBackColor);

        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.clrHashBrushForeColor = this.Color2Uint32(this.colorDialog1.Color);
            }
            this.axVideoCap1.SetHashBrushValue(0, (short)this.styleComboBox.SelectedIndex, this.clrHashBrushForeColor, this.clrHashBrushBackColor);

        }

        private void imageFileButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = this.imageFileTextBox.Text;
            this.openFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG File (*.jpg)|*.jpg|Gif File (*.gif)|*.gif";
            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.imageFileTextBox.Text = this.openFileDialog1.FileName;
                this.axVideoCap1.SetTextureBrushImage(0, this.imageFileTextBox.Text);
            }
 
        }

        private void imgFileButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp";
            this.openFileDialog1.FileName = this.imgFileTextBox.Text;
            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.imgFileTextBox.Text = this.openFileDialog1.FileName;
                this.DrawImage();
            }
        }

        private void transparentColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.clrTranColor = Color2Uint32(this.colorDialog1.Color);
                this.DrawImage();
            }
        }

        private void drawImageButton_Click(object sender, EventArgs e)
        {
            this.DrawImage();
        }

        private void showImageCheckBox_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowImage(0, this.showImageCheckBox.Checked);
     
        }

        private void alphaChannelTrackBar_Scroll(object sender, EventArgs e)
        {
            this.DrawImage();
        }

        private void dateFontStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.DateFontStyle = (short)this.dateFontStyleComboBox.SelectedIndex;
        }

        private void dateFontNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.DateFontName = this.dateFontNameComboBox.Text;
            this.DrawTime();
        }

        private void dateFormatComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.DrawTime((short)this.dateLeftNumericUpDown.Value, (short)this.dateTopNumericUpDown.Value, (short)this.dateFormatComboBox.SelectedIndex);
  
        }

        private void dateFontSizeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.DateFontName = this.dateFontNameComboBox.Text;
            this.axVideoCap1.DateFontSize = Convert.ToInt16(this.dateFontSizeComboBox.Text);
 
        }

        private void dateForeColorButton_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.clrDateColor;
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.clrDateColor = this.colorDialog1.Color;
                this.axVideoCap1.DateColor = this.clrDateColor;
            }
        }

        private void drawTimeButton_Click(object sender, EventArgs e)
        {
            this.DrawTime();
        }

        private void showDateCheckBox_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowDateTime = this.showDateCheckBox.Checked;
        }

        private void useAudioCapCheckBox_Click(object sender, EventArgs e)
        {
        
        }

        private void useVideoCapCheckBox_Click(object sender, EventArgs e)
        {
          
        }

        private void chkcaptureplaybackdevice_Click(object sender, EventArgs e)
        {
            if (chkcaptureplaybackdevice.Checked)
            {
                audioDeviceComboBox.Enabled = false;
                audioInputComboBox.Enabled = false;
                cboplaybackdevice.Enabled = true;
                int iSelVirtualAudioDevice = 0;
                iSelVirtualAudioDevice = audioDeviceComboBox.FindString("Viscomsoft");
                if (iSelVirtualAudioDevice != -1)
                    audioDeviceComboBox.SelectedIndex = iSelVirtualAudioDevice;

            }
            else
            {
                audioDeviceComboBox.SelectedIndex = 0;
                audioDeviceComboBox.Enabled = true;
                audioInputComboBox.Enabled = true;
                cboplaybackdevice.Enabled = false;

            } 
        }
    }
}
