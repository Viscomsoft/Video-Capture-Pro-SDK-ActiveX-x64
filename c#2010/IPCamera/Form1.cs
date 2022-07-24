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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbooutput.Items.Add("AVI");
            cbooutput.Items.Add("MP4");
            cbooutput.SelectedIndex = 0;

            string strVideoComp;
            bool bFindDivx = false;

            for (short i = 0; i < this.axVideoCap1.VideoCompressors.Count; i++)
            {
                strVideoComp = this.axVideoCap1.VideoCompressors.FindVideoCompressorName(i);
                this.cbovideocomp.Items.Add(strVideoComp);
                if (strVideoComp.Substring(0, 4) == "DivX" && bFindDivx == false)
                    this.cbovideocomp.SelectedIndex = i;

                if (strVideoComp.Trim() == "MJPEG Compressor" && bFindDivx == false)
                    this.cbovideocomp.SelectedIndex = i;
            }

            cboIPCamURL.Items.Add("http://158.58.130.148:80/mjpg/video.mjpg");
            cboIPCamURL.Items.Add("http://24.103.196.243:80/cgi-bin/viewer/video.jpg");
            cboIPCamURL.Items.Add("rtsp://116.197.222.158:554/live/ch00_0");
            cboIPCamURL.Items.Add("Custom");
            cboIPCamURL.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iResult;
            this.axVideoCap1.StopIPCamera();
            this.axVideoCap1.CaptureMode = false;
            this.axVideoCap1.IPCameraOpenURLTimeout = int.Parse(txttimeout.Text);
            axVideoCap1.PreviewCaptureAudio = chkpreviewaudio.Checked;
            if (cboIPCamURL.SelectedIndex == 4)

                iResult = axVideoCap1.StartIPCamera(textBox1.Text, txtUserID.Text, txtPass.Text);

            else
                iResult = axVideoCap1.StartIPCamera(cboIPCamURL.Text, txtUserID.Text, txtPass.Text);



            if (iResult != 1)
            {
                if (iResult == -8)
                    MessageBox.Show("The URL is empty");
                if (iResult == -7)
                    MessageBox.Show("Video Compressor cannot use, please select another one");
                if (iResult == -6)
                    MessageBox.Show("Capture Filename empty");
                if (iResult == -5)
                    MessageBox.Show("General network error");
                if (iResult == -4)
                    MessageBox.Show("Authentication failure");
                if (iResult == -3)
                    MessageBox.Show("Invalid Stream, not support this stream format");
                if (iResult == -2)
                    MessageBox.Show("Filter failure");
                if (iResult == -1)
                    MessageBox.Show("Create Graph failure");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.StopIPCamera();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "JPEG File (*.jpg)|*.jpg";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                axVideoCap1.SnapShotJPEG(this.saveFileDialog1.FileName, 90);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axVideoCap1.ShowFullScreen(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int iResult;

            axVideoCap1.StopIPCamera();
            axVideoCap1.CaptureMode = true;

            if (cbooutput.SelectedIndex == 0)
            {
                this.saveFileDialog1.Filter = "AVI File (*.avi)|*.avi";
                axVideoCap1.VideoCompressor = (short)this.cbovideocomp.SelectedIndex;
                axVideoCap1.UseVideoCompressor = this.chkusevideocomp.Checked;

            }
            else
            {
                this.saveFileDialog1.Filter = "MP4 File (*.mp4)|*.mp4";
                axVideoCap1.UseMp4EncoderPlugin = true; 
            }

            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                this.axVideoCap1.CaptureFileName = this.saveFileDialog1.FileName;

            axVideoCap1.PreviewCaptureAudio = chkpreviewaudio.Checked;
            if (cboIPCamURL.SelectedIndex == 4)

                iResult = axVideoCap1.StartIPCamera(textBox1.Text, txtUserID.Text, txtPass.Text);

            else
                iResult = axVideoCap1.StartIPCamera(cboIPCamURL.Text, txtUserID.Text, txtPass.Text);

            if (iResult != 1)
            {
                if (iResult == -8)
                    MessageBox.Show("The URL is empty");
                if (iResult == -7)
                    MessageBox.Show("Video Compressor cannot use, please select another one");
                if (iResult == -6)
                    MessageBox.Show("Capture Filename empty");
                if (iResult == -5)
                    MessageBox.Show("General network error");
                if (iResult == -4)
                    MessageBox.Show("Authentication failure");
                if (iResult == -3)
                    MessageBox.Show("Invalid Stream, not support this stream format");
                if (iResult == -2)
                    MessageBox.Show("Filter failure");
                if (iResult == -1)
                    MessageBox.Show("Create Graph failure");
            }
        }

        private void cboIPCamURL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIPCamURL.SelectedIndex == 3)
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;
        }
    }
}
