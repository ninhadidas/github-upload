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
    Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SBMS_GAControlPanel))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReviewBtn = New System.Windows.Forms.PictureBox()
        Me.ReportBtn = New System.Windows.Forms.PictureBox()
        Me.UserMasterBtn = New System.Windows.Forms.PictureBox()
        Me.BusQuotaBtn = New System.Windows.Forms.PictureBox()
        Me.BusMasterBtn = New System.Windows.Forms.PictureBox()
        Me.RoutingBtn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ReviewBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserMasterBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusQuotaBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusMasterBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoutingBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReviewBtn
        '
        Me.ReviewBtn.Image = CType(resources.GetObject("ReviewBtn.Image"), System.Drawing.Image)
        Me.ReviewBtn.Location = New System.Drawing.Point(15, 15)
        Me.ReviewBtn.Name = "ReviewBtn"
        Me.ReviewBtn.Size = New System.Drawing.Size(150, 150)
        Me.ReviewBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReviewBtn.TabIndex = 19
        Me.ReviewBtn.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ReviewBtn, "Review and Controls the requests")
        '
        'ReportBtn
        '
        Me.ReportBtn.Image = CType(resources.GetObject("ReportBtn.Image"), System.Drawing.Image)
        Me.ReportBtn.Location = New System.Drawing.Point(376, 15)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(150, 150)
        Me.ReportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReportBtn.TabIndex = 18
        Me.ReportBtn.TabStop = False
        Me.ToolTip3.SetToolTip(Me.ReportBtn, "Check & Export Report")
        '
        'UserMasterBtn
        '
        Me.UserMasterBtn.Image = CType(resources.GetObject("UserMasterBtn.Image"), System.Drawing.Image)
        Me.UserMasterBtn.Location = New System.Drawing.Point(196, 185)
        Me.UserMasterBtn.Name = "UserMasterBtn"
        Me.UserMasterBtn.Size = New System.Drawing.Size(150, 150)
        Me.UserMasterBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserMasterBtn.TabIndex = 17
        Me.UserMasterBtn.TabStop = False
        Me.ToolTip5.SetToolTip(Me.UserMasterBtn, "Update Employee Information")
        '
        'BusQuotaBtn
        '
        Me.BusQuotaBtn.Image = CType(resources.GetObject("BusQuotaBtn.Image"), System.Drawing.Image)
        Me.BusQuotaBtn.Location = New System.Drawing.Point(15, 185)
        Me.BusQuotaBtn.Name = "BusQuotaBtn"
        Me.BusQuotaBtn.Size = New System.Drawing.Size(150, 150)
        Me.BusQuotaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BusQuotaBtn.TabIndex = 20
        Me.BusQuotaBtn.TabStop = False
        Me.ToolTip4.SetToolTip(Me.BusQuotaBtn, "Maintain Bus Monthly Km Quota")
        '
        'BusMasterBtn
        '
        Me.BusMasterBtn.Image = CType(resources.GetObject("BusMasterBtn.Image"), System.Drawing.Image)
        Me.BusMasterBtn.Location = New System.Drawing.Point(196, 15)
        Me.BusMasterBtn.Name = "BusMasterBtn"
        Me.BusMasterBtn.Size = New System.Drawing.Size(150, 150)
        Me.BusMasterBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BusMasterBtn.TabIndex = 21
        Me.BusMasterBtn.TabStop = False
        Me.ToolTip2.SetToolTip(Me.BusMasterBtn, "Update Bus Information")
        '
        'RoutingBtn
        '
        Me.RoutingBtn.Image = CType(resources.GetObject("RoutingBtn.Image"), System.Drawing.Image)
        Me.RoutingBtn.Location = New System.Drawing.Point(376, 185)
        Me.RoutingBtn.Name = "RoutingBtn"
        Me.RoutingBtn.Size = New System.Drawing.Size(150, 150)
        Me.RoutingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RoutingBtn.TabIndex = 22
        Me.RoutingBtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Review Requests"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(205, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Bus Master Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(420, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Report"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Monthly Bus Quota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(203, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "User Master Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(394, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 18)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Routing Master"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(150, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "99"
        '
        'SBMS_GAControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 350)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RoutingBtn)
        Me.Controls.Add(Me.BusMasterBtn)
        Me.Controls.Add(Me.BusQuotaBtn)
        Me.Controls.Add(Me.ReviewBtn)
        Me.Controls.Add(Me.ReportBtn)
        Me.Controls.Add(Me.UserMasterBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SBMS_GAControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Control Panel"
        CType(Me.ReviewBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserMasterBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusQuotaBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusMasterBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoutingBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UserMasterBtn As PictureBox
    Friend WithEvents ReportBtn As PictureBox
    Friend WithEvents ReviewBtn As PictureBox
    Friend WithEvents BusQuotaBtn As PictureBox
    Friend WithEvents BusMasterBtn As PictureBox
    Friend WithEvents RoutingBtn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents Label7 As Label
End Class
