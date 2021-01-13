<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SBMS_GAControlPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SBMS_GAControlPanel))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReportBtn = New System.Windows.Forms.PictureBox()
        Me.UserMasterBtn = New System.Windows.Forms.PictureBox()
        Me.ReviewBtn = New System.Windows.Forms.PictureBox()
        Me.BusQuotaBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.QuitBtn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ReportBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserMasterBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReviewBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusQuotaBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportBtn
        '
        Me.ReportBtn.Image = CType(resources.GetObject("ReportBtn.Image"), System.Drawing.Image)
        Me.ReportBtn.Location = New System.Drawing.Point(376, 26)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(150, 150)
        Me.ReportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReportBtn.TabIndex = 18
        Me.ReportBtn.TabStop = False
        '
        'UserMasterBtn
        '
        Me.UserMasterBtn.Image = CType(resources.GetObject("UserMasterBtn.Image"), System.Drawing.Image)
        Me.UserMasterBtn.Location = New System.Drawing.Point(196, 196)
        Me.UserMasterBtn.Name = "UserMasterBtn"
        Me.UserMasterBtn.Size = New System.Drawing.Size(150, 150)
        Me.UserMasterBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserMasterBtn.TabIndex = 17
        Me.UserMasterBtn.TabStop = False
        '
        'ReviewBtn
        '
        Me.ReviewBtn.Image = CType(resources.GetObject("ReviewBtn.Image"), System.Drawing.Image)
        Me.ReviewBtn.Location = New System.Drawing.Point(15, 26)
        Me.ReviewBtn.Name = "ReviewBtn"
        Me.ReviewBtn.Size = New System.Drawing.Size(150, 150)
        Me.ReviewBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReviewBtn.TabIndex = 19
        Me.ReviewBtn.TabStop = False
        '
        'BusQuotaBtn
        '
        Me.BusQuotaBtn.Image = CType(resources.GetObject("BusQuotaBtn.Image"), System.Drawing.Image)
        Me.BusQuotaBtn.Location = New System.Drawing.Point(15, 196)
        Me.BusQuotaBtn.Name = "BusQuotaBtn"
        Me.BusQuotaBtn.Size = New System.Drawing.Size(150, 150)
        Me.BusQuotaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BusQuotaBtn.TabIndex = 20
        Me.BusQuotaBtn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(196, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'QuitBtn
        '
        Me.QuitBtn.Image = CType(resources.GetObject("QuitBtn.Image"), System.Drawing.Image)
        Me.QuitBtn.Location = New System.Drawing.Point(376, 196)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(150, 150)
        Me.QuitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuitBtn.TabIndex = 22
        Me.QuitBtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(29, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Review Requests"
        '
        'SBMS_GAControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BusQuotaBtn)
        Me.Controls.Add(Me.ReviewBtn)
        Me.Controls.Add(Me.ReportBtn)
        Me.Controls.Add(Me.UserMasterBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SBMS_GAControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Panel"
        CType(Me.ReportBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserMasterBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReviewBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusQuotaBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UserMasterBtn As PictureBox
    Friend WithEvents ReportBtn As PictureBox
    Friend WithEvents ReviewBtn As PictureBox
    Friend WithEvents BusQuotaBtn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents QuitBtn As PictureBox
    Friend WithEvents Label1 As Label
End Class
