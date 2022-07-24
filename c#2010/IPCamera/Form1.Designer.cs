namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.txttimeout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkpreviewaudio = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.cboIPCamURL = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cbovideocomp = new System.Windows.Forms.ComboBox();
            this.chkusevideocomp = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            this.cbooutput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 424);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 12);
            this.label6.TabIndex = 59;
            this.label6.Text = "Press ESC to close the full screen";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(388, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 20);
            this.button5.TabIndex = 58;
            this.button5.Text = "Show full screen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txttimeout
            // 
            this.txttimeout.Location = new System.Drawing.Point(613, 70);
            this.txttimeout.Name = "txttimeout";
            this.txttimeout.Size = new System.Drawing.Size(85, 21);
            this.txttimeout.TabIndex = 57;
            this.txttimeout.Text = "15000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 12);
            this.label4.TabIndex = 56;
            this.label4.Text = "Open URL Timeout (15000 = 15 second)";
            // 
            // chkpreviewaudio
            // 
            this.chkpreviewaudio.AutoSize = true;
            this.chkpreviewaudio.Location = new System.Drawing.Point(18, 498);
            this.chkpreviewaudio.Name = "chkpreviewaudio";
            this.chkpreviewaudio.Size = new System.Drawing.Size(102, 16);
            this.chkpreviewaudio.TabIndex = 55;
            this.chkpreviewaudio.Text = "Preview Audio";
            this.chkpreviewaudio.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 46);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 12);
            this.Label5.TabIndex = 54;
            this.Label5.Text = "Custom URL";
            // 
            // cboIPCamURL
            // 
            this.cboIPCamURL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIPCamURL.FormattingEnabled = true;
            this.cboIPCamURL.Location = new System.Drawing.Point(15, 14);
            this.cboIPCamURL.Name = "cboIPCamURL";
            this.cboIPCamURL.Size = new System.Drawing.Size(414, 20);
            this.cboIPCamURL.TabIndex = 53;
            this.cboIPCamURL.SelectedIndexChanged += new System.EventHandler(this.cboIPCamURL_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 460);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 21);
            this.button4.TabIndex = 52;
            this.button4.Text = "Start Capture IP Camera and save to AVI file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbovideocomp
            // 
            this.cbovideocomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideocomp.FormattingEnabled = true;
            this.cbovideocomp.Location = new System.Drawing.Point(492, 344);
            this.cbovideocomp.Name = "cbovideocomp";
            this.cbovideocomp.Size = new System.Drawing.Size(218, 20);
            this.cbovideocomp.TabIndex = 51;
            // 
            // chkusevideocomp
            // 
            this.chkusevideocomp.AutoSize = true;
            this.chkusevideocomp.Checked = true;
            this.chkusevideocomp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkusevideocomp.Location = new System.Drawing.Point(492, 314);
            this.chkusevideocomp.Name = "chkusevideocomp";
            this.chkusevideocomp.Size = new System.Drawing.Size(144, 16);
            this.chkusevideocomp.TabIndex = 50;
            this.chkusevideocomp.Text = "Use Video Compressor";
            this.chkusevideocomp.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 20);
            this.button3.TabIndex = 49;
            this.button3.Text = "Snapshot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(272, 70);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(85, 21);
            this.txtPass.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(91, 70);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(96, 21);
            this.txtUserID.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "Open URL Timeout";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 44;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 21);
            this.button1.TabIndex = 43;
            this.button1.Text = "Start Capture IP Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(91, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 21);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "http://24.103.196.243:80/cgi-bin/viewer/video.jpg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "URL of IP Camera e.g. http://195.196.200.6:80/mjpg/video.mjpg?resolution=640x480";
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(17, 96);
            this.axVideoCap1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(436, 312);
            this.axVideoCap1.TabIndex = 60;
            // 
            // cbooutput
            // 
            this.cbooutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooutput.FormattingEnabled = true;
            this.cbooutput.Location = new System.Drawing.Point(518, 498);
            this.cbooutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbooutput.Name = "cbooutput";
            this.cbooutput.Size = new System.Drawing.Size(94, 20);
            this.cbooutput.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 500);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 62;
            this.label7.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 496);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbooutput);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txttimeout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkpreviewaudio);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.cboIPCamURL);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbovideocomp);
            this.Controls.Add(this.chkusevideocomp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txttimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkpreviewaudio;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cboIPCamURL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbovideocomp;
        private System.Windows.Forms.CheckBox chkusevideocomp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;
        private System.Windows.Forms.ComboBox cbooutput;
        private System.Windows.Forms.Label label7;
    }
}

