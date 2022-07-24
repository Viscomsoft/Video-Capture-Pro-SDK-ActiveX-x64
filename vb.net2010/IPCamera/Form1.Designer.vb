<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtTimeout = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkpreviewaudio = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboIPCamURL = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cboVideoCompressor = New System.Windows.Forms.ComboBox()
        Me.chkusevideocomp = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 540)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 12)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Press ESC to close the full screen"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(478, 490)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 30)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Show full screen"
        '
        'txtTimeout
        '
        Me.txtTimeout.Location = New System.Drawing.Point(496, 79)
        Me.txtTimeout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimeout.Name = "txtTimeout"
        Me.txtTimeout.Size = New System.Drawing.Size(70, 21)
        Me.txtTimeout.TabIndex = 41
        Me.txtTimeout.Text = "15000"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(368, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Open URL Timeout (15000 = 15 second)"
        '
        'chkpreviewaudio
        '
        Me.chkpreviewaudio.AutoSize = True
        Me.chkpreviewaudio.Location = New System.Drawing.Point(30, 538)
        Me.chkpreviewaudio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkpreviewaudio.Name = "chkpreviewaudio"
        Me.chkpreviewaudio.Size = New System.Drawing.Size(102, 16)
        Me.chkpreviewaudio.TabIndex = 39
        Me.chkpreviewaudio.Text = "Preview Audio"
        Me.chkpreviewaudio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Custom URL"
        '
        'cboIPCamURL
        '
        Me.cboIPCamURL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIPCamURL.FormattingEnabled = True
        Me.cboIPCamURL.Location = New System.Drawing.Point(6, 32)
        Me.cboIPCamURL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboIPCamURL.Name = "cboIPCamURL"
        Me.cboIPCamURL.Size = New System.Drawing.Size(468, 20)
        Me.cboIPCamURL.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(617, 490)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(252, 32)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Start Capture IP Camera and Capture to AVI"
        '
        'cboVideoCompressor
        '
        Me.cboVideoCompressor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVideoCompressor.Location = New System.Drawing.Point(526, 467)
        Me.cboVideoCompressor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboVideoCompressor.Name = "cboVideoCompressor"
        Me.cboVideoCompressor.Size = New System.Drawing.Size(209, 20)
        Me.cboVideoCompressor.TabIndex = 35
        '
        'chkusevideocomp
        '
        Me.chkusevideocomp.Checked = True
        Me.chkusevideocomp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkusevideocomp.Location = New System.Drawing.Point(526, 398)
        Me.chkusevideocomp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkusevideocomp.Name = "chkusevideocomp"
        Me.chkusevideocomp.Size = New System.Drawing.Size(189, 23)
        Me.chkusevideocomp.TabIndex = 33
        Me.chkusevideocomp.Text = "Use Video Compressor"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(526, 436)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Video Compressor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 490)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 30)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Snapshot"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(264, 82)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(83, 21)
        Me.txtPass.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Password"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(84, 82)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(83, 21)
        Me.txtUserID.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "User Name"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(210, 490)
        Me.Command2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(117, 32)
        Me.Command2.TabIndex = 26
        Me.Command2.Text = "Stop"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(30, 490)
        Me.Command1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(172, 32)
        Me.Command1.TabIndex = 25
        Me.Command1.Text = "Start Capture IP Camera"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(84, 58)
        Me.Text1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(462, 20)
        Me.Text1.TabIndex = 24
        Me.Text1.Text = "http://24.103.196.243:80/cgi-bin/viewer/video.jpg"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(595, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "URL of IP Camera e.g. http://195.196.200.6:80/mjpg/video.mjpg?resolution=640x480"
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(11, 134)
        Me.AxVideoCap1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(483, 352)
        Me.AxVideoCap1.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 535)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtTimeout)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkpreviewaudio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboIPCamURL)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cboVideoCompressor)
        Me.Controls.Add(Me.chkusevideocomp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtTimeout As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkpreviewaudio As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboIPCamURL As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cboVideoCompressor As System.Windows.Forms.ComboBox
    Friend WithEvents chkusevideocomp As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap

End Class
