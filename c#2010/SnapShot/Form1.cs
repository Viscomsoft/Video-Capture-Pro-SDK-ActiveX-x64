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

        private void FillVideoFormat()
        {
            for (int i = 0; i < (int)axVideoCap1.GetVideoFormatCount(); i++)
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName((short)i));
            }
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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


            this.FillVideoFormat();
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Device = (short)this.deviceComboBox.SelectedIndex;
            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;
            this.axVideoCap1.VideoFormat = (short)this.videoFormatComboBox.SelectedIndex;
            this.axVideoCap1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.axVideoCap1.SnapShot2Picture();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strFileName = Application.StartupPath + "\\test.bmp";
            this.axVideoCap1.SnapShot(strFileName);
            this.pictureBox1.Load(strFileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strFileName = Application.StartupPath + "\\test.jpg";

            this.axVideoCap1.SnapShotJPEG(strFileName, 90);
            MessageBox.Show("save to " + strFileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IntPtr hb = new IntPtr(this.axVideoCap1.SnapShot2HBITMAP());
            this.pictureBox1.Image = Bitmap.FromHbitmap(hb);
        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            videoInputComboBox.Items.Clear();
            videoFormatComboBox.Items.Clear();

            axVideoCap1.RefreshVideoDevice((short)deviceComboBox.SelectedIndex);
            
            for (int i = 0; i < (int)axVideoCap1.GetVideoInputCount(); i++)
            {
                this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName((short)i));
            }
            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }


            this.FillVideoFormat();
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }

        }

       
    }
}
