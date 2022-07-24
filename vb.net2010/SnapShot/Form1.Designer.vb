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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.chkshowdate = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsnapshot = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.cbovideoinput = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkshowdate
        '
        Me.chkshowdate.Checked = True
        Me.chkshowdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkshowdate.Location = New System.Drawing.Point(21, 413)
        Me.chkshowdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkshowdate.Name = "chkshowdate"
        Me.chkshowdate.Size = New System.Drawing.Size(208, 17)
        Me.chkshowdate.TabIndex = 22
        Me.chkshowdate.Text = "Show Date Time"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(425, 123)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(624, 397)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'cbovideoformat
        '
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.Location = New System.Drawing.Point(166, 84)
        Me.cbovideoformat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.Size = New System.Drawing.Size(293, 20)
        Me.cbovideoformat.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Video Format"
        '
        'btnsnapshot
        '
        Me.btnsnapshot.Location = New System.Drawing.Point(21, 439)
        Me.btnsnapshot.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsnapshot.Name = "btnsnapshot"
        Me.btnsnapshot.Size = New System.Drawing.Size(166, 26)
        Me.btnsnapshot.TabIndex = 18
        Me.btnsnapshot.Text = "Snapshot"
        '
        'btnstart
        '
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(468, 84)
        Me.btnstart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(124, 26)
        Me.btnstart.TabIndex = 17
        Me.btnstart.Text = "Preview"
        '
        'cbovideoinput
        '
        Me.cbovideoinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoinput.Location = New System.Drawing.Point(166, 50)
        Me.cbovideoinput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbovideoinput.Name = "cbovideoinput"
        Me.cbovideoinput.Size = New System.Drawing.Size(293, 20)
        Me.cbovideoinput.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Video Input"
        '
        'cbovideodevice
        '
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.Location = New System.Drawing.Point(166, 16)
        Me.cbovideodevice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.Size = New System.Drawing.Size(293, 20)
        Me.cbovideodevice.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Video Device"
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(12, 111)
        Me.AxVideoCap1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(386, 298)
        Me.AxVideoCap1.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 556)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.chkshowdate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsnapshot)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.cbovideoinput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkshowdate As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbovideoformat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsnapshot As System.Windows.Forms.Button
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents cbovideoinput As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbovideodevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap

End Class
