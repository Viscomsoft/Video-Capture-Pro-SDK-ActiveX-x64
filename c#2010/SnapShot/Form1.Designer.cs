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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoFormatComboBox = new System.Windows.Forms.ComboBox();
            this.videoFormatLabel = new System.Windows.Forms.Label();
            this.videoInputComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.deviceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(461, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 21);
            this.button5.TabIndex = 27;
            this.button5.Text = "SnapShot JPEG";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 21);
            this.button4.TabIndex = 26;
            this.button4.Text = "SnapShot To HBITMAP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 21);
            this.button3.TabIndex = 25;
            this.button3.Text = "SnapShot to Picture Box";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 24;
            this.button2.Text = "SnapShot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 23;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(310, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // videoFormatComboBox
            // 
            this.videoFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoFormatComboBox.FormattingEnabled = true;
            this.videoFormatComboBox.Location = new System.Drawing.Point(97, 263);
            this.videoFormatComboBox.Name = "videoFormatComboBox";
            this.videoFormatComboBox.Size = new System.Drawing.Size(190, 20);
            this.videoFormatComboBox.TabIndex = 21;
            // 
            // videoFormatLabel
            // 
            this.videoFormatLabel.AutoSize = true;
            this.videoFormatLabel.Location = new System.Drawing.Point(20, 266);
            this.videoFormatLabel.Name = "videoFormatLabel";
            this.videoFormatLabel.Size = new System.Drawing.Size(77, 12);
            this.videoFormatLabel.TabIndex = 20;
            this.videoFormatLabel.Text = "Video Format";
            // 
            // videoInputComboBox
            // 
            this.videoInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoInputComboBox.FormattingEnabled = true;
            this.videoInputComboBox.Location = new System.Drawing.Point(97, 238);
            this.videoInputComboBox.Name = "videoInputComboBox";
            this.videoInputComboBox.Size = new System.Drawing.Size(190, 20);
            this.videoInputComboBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Video Input";
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(11, 11);
            this.axVideoCap1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(276, 186);
            this.axVideoCap1.TabIndex = 29;
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(97, 210);
            this.deviceComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(190, 20);
            this.deviceComboBox.TabIndex = 31;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(20, 212);
            this.deviceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(41, 12);
            this.deviceLabel.TabIndex = 30;
            this.deviceLabel.Text = "Device";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 341);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoFormatComboBox);
            this.Controls.Add(this.videoFormatLabel);
            this.Controls.Add(this.videoInputComboBox);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox videoFormatComboBox;
        private System.Windows.Forms.Label videoFormatLabel;
        private System.Windows.Forms.ComboBox videoInputComboBox;
        private System.Windows.Forms.Label label3;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label deviceLabel;
    }
}

