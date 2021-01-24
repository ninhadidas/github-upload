<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SBMS_BusQuotaMaster
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SBMS_BusQuotaMaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.FileLocation = New System.Windows.Forms.TextBox()
        Me.UploadBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.QuotaGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QuotaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(646, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "BUS MANAGEMENT SYSTEM - MONTHLY KM QUOTA MASTER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.BrowseBtn)
        Me.GroupBox1.Controls.Add(Me.FileLocation)
        Me.GroupBox1.Controls.Add(Me.UploadBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 126)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upload New Month Quota"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 75)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 28)
        Me.ProgressBar1.TabIndex = 44
        '
        'BrowseBtn
        '
        Me.BrowseBtn.BackColor = System.Drawing.Color.Blue
        Me.BrowseBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBtn.ForeColor = System.Drawing.Color.White
        Me.BrowseBtn.Location = New System.Drawing.Point(472, 28)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(152, 30)
        Me.BrowseBtn.TabIndex = 43
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = False
        '
        'FileLocation
        '
        Me.FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileLocation.Location = New System.Drawing.Point(20, 32)
        Me.FileLocation.Name = "FileLocation"
        Me.FileLocation.Size = New System.Drawing.Size(424, 26)
        Me.FileLocation.TabIndex = 42
        '
        'UploadBtn
        '
        Me.UploadBtn.BackColor = System.Drawing.Color.Green
        Me.UploadBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadBtn.ForeColor = System.Drawing.Color.White
        Me.UploadBtn.Location = New System.Drawing.Point(472, 75)
        Me.UploadBtn.Name = "UploadBtn"
        Me.UploadBtn.Size = New System.Drawing.Size(152, 30)
        Me.UploadBtn.TabIndex = 41
        Me.UploadBtn.Text = "Upload"
        Me.UploadBtn.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'QuotaGridView
        '
        Me.QuotaGridView.AllowUserToAddRows = False
        Me.QuotaGridView.AllowUserToDeleteRows = False
        Me.QuotaGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QuotaGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.QuotaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QuotaGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.QuotaGridView.Location = New System.Drawing.Point(17, 235)
        Me.QuotaGridView.Name = "QuotaGridView"
        Me.QuotaGridView.ReadOnly = True
        Me.QuotaGridView.Size = New System.Drawing.Size(639, 404)
        Me.QuotaGridView.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Recently Uploaded"
        '
        'SBMS_BusQuotaMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 661)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuotaGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SBMS_BusQuotaMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Quota Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.QuotaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UploadBtn As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents FileLocation As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents QuotaGridView As DataGridView
    Friend WithEvents Label2 As Label
End Class
