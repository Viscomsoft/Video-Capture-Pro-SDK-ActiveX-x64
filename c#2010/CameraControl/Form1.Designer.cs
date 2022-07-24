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
            this.chkwhitebalauto = new System.Windows.Forms.CheckBox();
            this.chkfocusauto = new System.Windows.Forms.CheckBox();
            this.FocusTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gainLabel = new System.Windows.Forms.Label();
            this.gainTrackBar = new System.Windows.Forms.TrackBar();
            this.backlightCompensationLabel = new System.Windows.Forms.Label();
            this.backlightCompensationTrackBar = new System.Windows.Forms.TrackBar();
            this.whiteBalanceLabel = new System.Windows.Forms.Label();
            this.whiteBalanceTrackBar = new System.Windows.Forms.TrackBar();
            this.colorEnableLabel = new System.Windows.Forms.Label();
            this.colorEnableTrackBar = new System.Windows.Forms.TrackBar();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.gammaTrackBar = new System.Windows.Forms.TrackBar();
            this.sharpnessLabel = new System.Windows.Forms.Label();
            this.sharpnessTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.hueLabel = new System.Windows.Forms.Label();
            this.hueTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.proPageButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.videoInputComboBox = new System.Windows.Forms.ComboBox();
            this.videoInputLabel = new System.Windows.Forms.Label();
            this.btnbrightnessdefault = new System.Windows.Forms.Button();
            this.btncontrastdefault = new System.Windows.Forms.Button();
            this.btnhuedefault = new System.Windows.Forms.Button();
            this.btnsatdefault = new System.Windows.Forms.Button();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            this.btnsharpnessdefault = new System.Windows.Forms.Button();
            this.btngammadefault = new System.Windows.Forms.Button();
            this.btncolordefault = new System.Windows.Forms.Button();
            this.btnwhitebalancedefault = new System.Windows.Forms.Button();
            this.btnbacklightdefault = new System.Windows.Forms.Button();
            this.btngaindefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FocusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlightCompensationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBalanceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEnableTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkwhitebalauto
            // 
            this.chkwhitebalauto.AutoSize = true;
            this.chkwhitebalauto.Location = new System.Drawing.Point(418, 410);
            this.chkwhitebalauto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkwhitebalauto.Name = "chkwhitebalauto";
            this.chkwhitebalauto.Size = new System.Drawing.Size(48, 16);
            this.chkwhitebalauto.TabIndex = 56;
            this.chkwhitebalauto.Text = "Auto";
            this.chkwhitebalauto.UseVisualStyleBackColor = true;
            this.chkwhitebalauto.CheckedChanged += new System.EventHandler(this.chkwhitebalauto_CheckedChanged);
            // 
            // chkfocusauto
            // 
            this.chkfocusauto.AutoSize = true;
            this.chkfocusauto.Location = new System.Drawing.Point(454, 12);
            this.chkfocusauto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkfocusauto.Name = "chkfocusauto";
            this.chkfocusauto.Size = new System.Drawing.Size(48, 16);
            this.chkfocusauto.TabIndex = 55;
            this.chkfocusauto.Text = "Auto";
            this.chkfocusauto.UseVisualStyleBackColor = true;
            this.chkfocusauto.CheckedChanged += new System.EventHandler(this.chkfocusauto_CheckedChanged);
            // 
            // FocusTrackBar
            // 
            this.FocusTrackBar.Location = new System.Drawing.Point(154, 32);
            this.FocusTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FocusTrackBar.Name = "FocusTrackBar";
            this.FocusTrackBar.Size = new System.Drawing.Size(320, 45);
            this.FocusTrackBar.TabIndex = 54;
            this.FocusTrackBar.Scroll += new System.EventHandler(this.FocusTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "Focus";
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Location = new System.Drawing.Point(16, 520);
            this.gainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(29, 12);
            this.gainLabel.TabIndex = 52;
            this.gainLabel.Text = "Gain";
            // 
            // gainTrackBar
            // 
            this.gainTrackBar.Location = new System.Drawing.Point(150, 520);
            this.gainTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gainTrackBar.Name = "gainTrackBar";
            this.gainTrackBar.Size = new System.Drawing.Size(322, 45);
            this.gainTrackBar.TabIndex = 51;
            this.gainTrackBar.Scroll += new System.EventHandler(this.gainTrackBar_Scroll);
            // 
            // backlightCompensationLabel
            // 
            this.backlightCompensationLabel.AutoSize = true;
            this.backlightCompensationLabel.Location = new System.Drawing.Point(16, 472);
            this.backlightCompensationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlightCompensationLabel.Name = "backlightCompensationLabel";
            this.backlightCompensationLabel.Size = new System.Drawing.Size(137, 12);
            this.backlightCompensationLabel.TabIndex = 50;
            this.backlightCompensationLabel.Text = "Backlight Compensation";
            // 
            // backlightCompensationTrackBar
            // 
            this.backlightCompensationTrackBar.Location = new System.Drawing.Point(150, 472);
            this.backlightCompensationTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backlightCompensationTrackBar.Name = "backlightCompensationTrackBar";
            this.backlightCompensationTrackBar.Size = new System.Drawing.Size(322, 45);
            this.backlightCompensationTrackBar.TabIndex = 49;
            this.backlightCompensationTrackBar.Scroll += new System.EventHandler(this.backlightCompensationTrackBar_Scroll);
            // 
            // whiteBalanceLabel
            // 
            this.whiteBalanceLabel.AutoSize = true;
            this.whiteBalanceLabel.Location = new System.Drawing.Point(16, 426);
            this.whiteBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whiteBalanceLabel.Name = "whiteBalanceLabel";
            this.whiteBalanceLabel.Size = new System.Drawing.Size(83, 12);
            this.whiteBalanceLabel.TabIndex = 48;
            this.whiteBalanceLabel.Text = "White Balance";
            // 
            // whiteBalanceTrackBar
            // 
            this.whiteBalanceTrackBar.Location = new System.Drawing.Point(150, 426);
            this.whiteBalanceTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.whiteBalanceTrackBar.Name = "whiteBalanceTrackBar";
            this.whiteBalanceTrackBar.Size = new System.Drawing.Size(322, 45);
            this.whiteBalanceTrackBar.TabIndex = 47;
            this.whiteBalanceTrackBar.Scroll += new System.EventHandler(this.whiteBalanceTrackBar_Scroll);
            // 
            // colorEnableLabel
            // 
            this.colorEnableLabel.AutoSize = true;
            this.colorEnableLabel.Location = new System.Drawing.Point(16, 380);
            this.colorEnableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorEnableLabel.Name = "colorEnableLabel";
            this.colorEnableLabel.Size = new System.Drawing.Size(77, 12);
            this.colorEnableLabel.TabIndex = 46;
            this.colorEnableLabel.Text = "Color Enable";
            // 
            // colorEnableTrackBar
            // 
            this.colorEnableTrackBar.Location = new System.Drawing.Point(150, 380);
            this.colorEnableTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorEnableTrackBar.Name = "colorEnableTrackBar";
            this.colorEnableTrackBar.Size = new System.Drawing.Size(322, 45);
            this.colorEnableTrackBar.TabIndex = 45;
            this.colorEnableTrackBar.Scroll += new System.EventHandler(this.colorEnableTrackBar_Scroll);
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(16, 332);
            this.gammaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(35, 12);
            this.gammaLabel.TabIndex = 44;
            this.gammaLabel.Text = "Gamma";
            // 
            // gammaTrackBar
            // 
            this.gammaTrackBar.Location = new System.Drawing.Point(150, 332);
            this.gammaTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gammaTrackBar.Name = "gammaTrackBar";
            this.gammaTrackBar.Size = new System.Drawing.Size(322, 45);
            this.gammaTrackBar.TabIndex = 43;
            this.gammaTrackBar.Scroll += new System.EventHandler(this.gammaTrackBar_Scroll);
            // 
            // sharpnessLabel
            // 
            this.sharpnessLabel.AutoSize = true;
            this.sharpnessLabel.Location = new System.Drawing.Point(16, 284);
            this.sharpnessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sharpnessLabel.Name = "sharpnessLabel";
            this.sharpnessLabel.Size = new System.Drawing.Size(59, 12);
            this.sharpnessLabel.TabIndex = 42;
            this.sharpnessLabel.Text = "Sharpness";
            // 
            // sharpnessTrackBar
            // 
            this.sharpnessTrackBar.Location = new System.Drawing.Point(150, 284);
            this.sharpnessTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sharpnessTrackBar.Name = "sharpnessTrackBar";
            this.sharpnessTrackBar.Size = new System.Drawing.Size(322, 45);
            this.sharpnessTrackBar.TabIndex = 41;
            this.sharpnessTrackBar.Scroll += new System.EventHandler(this.sharpnessTrackBar_Scroll);
            // 
            // saturationLabel
            // 
            this.saturationLabel.AutoSize = true;
            this.saturationLabel.Location = new System.Drawing.Point(16, 228);
            this.saturationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(65, 12);
            this.saturationLabel.TabIndex = 40;
            this.saturationLabel.Text = "Saturation";
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Location = new System.Drawing.Point(150, 228);
            this.saturationTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(322, 45);
            this.saturationTrackBar.TabIndex = 39;
            this.saturationTrackBar.Scroll += new System.EventHandler(this.saturationTrackBar_Scroll);
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(16, 182);
            this.hueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(23, 12);
            this.hueLabel.TabIndex = 38;
            this.hueLabel.Text = "Hue";
            // 
            // hueTrackBar
            // 
            this.hueTrackBar.Location = new System.Drawing.Point(150, 182);
            this.hueTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hueTrackBar.Name = "hueTrackBar";
            this.hueTrackBar.Size = new System.Drawing.Size(322, 45);
            this.hueTrackBar.TabIndex = 37;
            this.hueTrackBar.Scroll += new System.EventHandler(this.hueTrackBar_Scroll);
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(16, 136);
            this.contrastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(53, 12);
            this.contrastLabel.TabIndex = 36;
            this.contrastLabel.Text = "Contrast";
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(150, 136);
            this.contrastTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(322, 45);
            this.contrastTrackBar.TabIndex = 35;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(16, 88);
            this.brightnessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(65, 12);
            this.brightnessLabel.TabIndex = 34;
            this.brightnessLabel.Text = "Brightness";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(150, 88);
            this.brightnessTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(322, 45);
            this.brightnessTrackBar.TabIndex = 33;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // proPageButton
            // 
            this.proPageButton.Location = new System.Drawing.Point(572, 314);
            this.proPageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proPageButton.Name = "proPageButton";
            this.proPageButton.Size = new System.Drawing.Size(186, 22);
            this.proPageButton.TabIndex = 32;
            this.proPageButton.Text = "Show Property Page";
            this.proPageButton.UseVisualStyleBackColor = true;
            this.proPageButton.Click += new System.EventHandler(this.proPageButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(572, 286);
            this.previewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(186, 22);
            this.previewButton.TabIndex = 31;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // videoInputComboBox
            // 
            this.videoInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoInputComboBox.FormattingEnabled = true;
            this.videoInputComboBox.Location = new System.Drawing.Point(646, 254);
            this.videoInputComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoInputComboBox.Name = "videoInputComboBox";
            this.videoInputComboBox.Size = new System.Drawing.Size(122, 20);
            this.videoInputComboBox.TabIndex = 30;
            // 
            // videoInputLabel
            // 
            this.videoInputLabel.AutoSize = true;
            this.videoInputLabel.Location = new System.Drawing.Point(568, 256);
            this.videoInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.videoInputLabel.Name = "videoInputLabel";
            this.videoInputLabel.Size = new System.Drawing.Size(71, 12);
            this.videoInputLabel.TabIndex = 29;
            this.videoInputLabel.Text = "Video Input";
            // 
            // btnbrightnessdefault
            // 
            this.btnbrightnessdefault.Location = new System.Drawing.Point(478, 80);
            this.btnbrightnessdefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbrightnessdefault.Name = "btnbrightnessdefault";
            this.btnbrightnessdefault.Size = new System.Drawing.Size(60, 28);
            this.btnbrightnessdefault.TabIndex = 58;
            this.btnbrightnessdefault.Text = "default";
            this.btnbrightnessdefault.UseVisualStyleBackColor = true;
            this.btnbrightnessdefault.Click += new System.EventHandler(this.btnbrightnessdefault_Click);
            // 
            // btncontrastdefault
            // 
            this.btncontrastdefault.Location = new System.Drawing.Point(478, 136);
            this.btncontrastdefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncontrastdefault.Name = "btncontrastdefault";
            this.btncontrastdefault.Size = new System.Drawing.Size(60, 28);
            this.btncontrastdefault.TabIndex = 59;
            this.btncontrastdefault.Text = "default";
            this.btncontrastdefault.UseVisualStyleBackColor = true;
            this.btncontrastdefault.Click += new System.EventHandler(this.btncontrastdefault_Click);
            // 
            // btnhuedefault
            // 
            this.btnhuedefault.Location = new System.Drawing.Point(478, 182);
            this.btnhuedefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhuedefault.Name = "btnhuedefault";
            this.btnhuedefault.Size = new System.Drawing.Size(60, 28);
            this.btnhuedefault.TabIndex = 60;
            this.btnhuedefault.Text = "default";
            this.btnhuedefault.UseVisualStyleBackColor = true;
            this.btnhuedefault.Click += new System.EventHandler(this.btnhuedefault_Click);
            // 
            // btnsatdefault
            // 
            this.btnsatdefault.Location = new System.Drawing.Point(478, 228);
            this.btnsatdefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsatdefault.Name = "btnsatdefault";
            this.btnsatdefault.Size = new System.Drawing.Size(60, 28);
            this.btnsatdefault.TabIndex = 61;
            this.btnsatdefault.Text = "default";
            this.btnsatdefault.UseVisualStyleBackColor = true;
            this.btnsatdefault.Click += new System.EventHandler(this.btnsatdefault_Click);
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(572, 6);
            this.axVideoCap1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(288, 234);
            this.axVideoCap1.TabIndex = 57;
            // 
            // btnsharpnessdefault
            // 
            this.btnsharpnessdefault.Location = new System.Drawing.Point(478, 276);
            this.btnsharpnessdefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsharpnessdefault.Name = "btnsharpnessdefault";
            this.btnsharpnessdefault.Size = new System.Drawing.Size(60, 28);
            this.btnsharpnessdefault.TabIndex = 62;
            this.btnsharpnessdefault.Text = "default";
            this.btnsharpnessdefault.UseVisualStyleBackColor = true;
            this.btnsharpnessdefault.Click += new System.EventHandler(this.btnsharpnessdefault_Click);
            // 
            // btngammadefault
            // 
            this.btngammadefault.Location = new System.Drawing.Point(478, 324);
            this.btngammadefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngammadefault.Name = "btngammadefault";
            this.btngammadefault.Size = new System.Drawing.Size(60, 28);
            this.btngammadefault.TabIndex = 63;
            this.btngammadefault.Text = "default";
            this.btngammadefault.UseVisualStyleBackColor = true;
            this.btngammadefault.Click += new System.EventHandler(this.btngammadefault_Click);
            // 
            // btncolordefault
            // 
            this.btncolordefault.Location = new System.Drawing.Point(478, 372);
            this.btncolordefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncolordefault.Name = "btncolordefault";
            this.btncolordefault.Size = new System.Drawing.Size(60, 28);
            this.btncolordefault.TabIndex = 64;
            this.btncolordefault.Text = "default";
            this.btncolordefault.UseVisualStyleBackColor = true;
            this.btncolordefault.Click += new System.EventHandler(this.btncolordefault_Click);
            // 
            // btnwhitebalancedefault
            // 
            this.btnwhitebalancedefault.Location = new System.Drawing.Point(478, 418);
            this.btnwhitebalancedefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnwhitebalancedefault.Name = "btnwhitebalancedefault";
            this.btnwhitebalancedefault.Size = new System.Drawing.Size(60, 28);
            this.btnwhitebalancedefault.TabIndex = 65;
            this.btnwhitebalancedefault.Text = "default";
            this.btnwhitebalancedefault.UseVisualStyleBackColor = true;
            this.btnwhitebalancedefault.Click += new System.EventHandler(this.btnwhitebalancedefault_Click);
            // 
            // btnbacklightdefault
            // 
            this.btnbacklightdefault.Location = new System.Drawing.Point(478, 464);
            this.btnbacklightdefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbacklightdefault.Name = "btnbacklightdefault";
            this.btnbacklightdefault.Size = new System.Drawing.Size(60, 28);
            this.btnbacklightdefault.TabIndex = 66;
            this.btnbacklightdefault.Text = "default";
            this.btnbacklightdefault.UseVisualStyleBackColor = true;
            this.btnbacklightdefault.Click += new System.EventHandler(this.btnbacklightdefault_Click);
            // 
            // btngaindefault
            // 
            this.btngaindefault.Location = new System.Drawing.Point(477, 512);
            this.btngaindefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngaindefault.Name = "btngaindefault";
            this.btngaindefault.Size = new System.Drawing.Size(60, 28);
            this.btngaindefault.TabIndex = 67;
            this.btngaindefault.Text = "default";
            this.btngaindefault.UseVisualStyleBackColor = true;
            this.btngaindefault.Click += new System.EventHandler(this.btngaindefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 682);
            this.Controls.Add(this.btngaindefault);
            this.Controls.Add(this.btnbacklightdefault);
            this.Controls.Add(this.btnwhitebalancedefault);
            this.Controls.Add(this.btncolordefault);
            this.Controls.Add(this.btngammadefault);
            this.Controls.Add(this.btnsharpnessdefault);
            this.Controls.Add(this.btnsatdefault);
            this.Controls.Add(this.btnhuedefault);
            this.Controls.Add(this.btncontrastdefault);
            this.Controls.Add(this.btnbrightnessdefault);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.chkwhitebalauto);
            this.Controls.Add(this.chkfocusauto);
            this.Controls.Add(this.FocusTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gainLabel);
            this.Controls.Add(this.gainTrackBar);
            this.Controls.Add(this.backlightCompensationLabel);
            this.Controls.Add(this.backlightCompensationTrackBar);
            this.Controls.Add(this.whiteBalanceLabel);
            this.Controls.Add(this.whiteBalanceTrackBar);
            this.Controls.Add(this.colorEnableLabel);
            this.Controls.Add(this.colorEnableTrackBar);
            this.Controls.Add(this.gammaLabel);
            this.Controls.Add(this.gammaTrackBar);
            this.Controls.Add(this.sharpnessLabel);
            this.Controls.Add(this.sharpnessTrackBar);
            this.Controls.Add(this.saturationLabel);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.hueTrackBar);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.proPageButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.videoInputComboBox);
            this.Controls.Add(this.videoInputLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FocusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlightCompensationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBalanceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEnableTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkwhitebalauto;
        private System.Windows.Forms.CheckBox chkfocusauto;
        private System.Windows.Forms.TrackBar FocusTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.TrackBar gainTrackBar;
        private System.Windows.Forms.Label backlightCompensationLabel;
        private System.Windows.Forms.TrackBar backlightCompensationTrackBar;
        private System.Windows.Forms.Label whiteBalanceLabel;
        private System.Windows.Forms.TrackBar whiteBalanceTrackBar;
        private System.Windows.Forms.Label colorEnableLabel;
        private System.Windows.Forms.TrackBar colorEnableTrackBar;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.TrackBar gammaTrackBar;
        private System.Windows.Forms.Label sharpnessLabel;
        private System.Windows.Forms.TrackBar sharpnessTrackBar;
        private System.Windows.Forms.Label saturationLabel;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.TrackBar hueTrackBar;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.Button proPageButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.ComboBox videoInputComboBox;
        private System.Windows.Forms.Label videoInputLabel;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;
        private System.Windows.Forms.Button btnbrightnessdefault;
        private System.Windows.Forms.Button btncontrastdefault;
        private System.Windows.Forms.Button btnhuedefault;
        private System.Windows.Forms.Button btnsatdefault;
        private System.Windows.Forms.Button btnsharpnessdefault;
        private System.Windows.Forms.Button btngammadefault;
        private System.Windows.Forms.Button btncolordefault;
        private System.Windows.Forms.Button btnwhitebalancedefault;
        private System.Windows.Forms.Button btnbacklightdefault;
        private System.Windows.Forms.Button btngaindefault;
    }
}

