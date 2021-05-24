<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PMS_UserMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PMS_UserMaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.QuotaGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.FileLocation = New System.Windows.Forms.TextBox()
        Me.UploadBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.BrowseBtn2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UploadBtn2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.EmployeeGrid = New System.Windows.Forms.DataGridView()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DelEmployeeTbx = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.QuotaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.EmployeeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(594, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PERFORMANCE MANAGEMENT SYSTEM - USER MASTER"
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
        Me.QuotaGridView.Location = New System.Drawing.Point(17, 232)
        Me.QuotaGridView.Name = "QuotaGridView"
        Me.QuotaGridView.ReadOnly = True
        Me.QuotaGridView.Size = New System.Drawing.Size(639, 251)
        Me.QuotaGridView.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 19)
        Me.Label2.TabIndex = 42
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(17, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(639, 176)
        Me.TabControl1.TabIndex = 43
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(631, 150)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Upload New User"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.BrowseBtn)
        Me.GroupBox1.Controls.Add(Me.FileLocation)
        Me.GroupBox1.Controls.Add(Me.UploadBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-4, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 187)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 112)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 28)
        Me.ProgressBar1.TabIndex = 44
        '
        'BrowseBtn
        '
        Me.BrowseBtn.BackColor = System.Drawing.Color.Blue
        Me.BrowseBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBtn.ForeColor = System.Drawing.Color.White
        Me.BrowseBtn.Location = New System.Drawing.Point(472, 65)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(152, 30)
        Me.BrowseBtn.TabIndex = 43
        Me.BrowseBtn.Text = "Select Upload File"
        Me.BrowseBtn.UseVisualStyleBackColor = False
        '
        'FileLocation
        '
        Me.FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileLocation.Location = New System.Drawing.Point(20, 69)
        Me.FileLocation.Name = "FileLocation"
        Me.FileLocation.Size = New System.Drawing.Size(424, 26)
        Me.FileLocation.TabIndex = 42
        '
        'UploadBtn
        '
        Me.UploadBtn.BackColor = System.Drawing.Color.Green
        Me.UploadBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadBtn.ForeColor = System.Drawing.Color.White
        Me.UploadBtn.Location = New System.Drawing.Point(472, 112)
        Me.UploadBtn.Name = "UploadBtn"
        Me.UploadBtn.Size = New System.Drawing.Size(152, 30)
        Me.UploadBtn.TabIndex = 41
        Me.UploadBtn.Text = "Upload"
        Me.UploadBtn.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ProgressBar2)
        Me.TabPage2.Controls.Add(Me.BrowseBtn2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.UploadBtn2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(631, 150)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Change User Infor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(13, 65)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(424, 28)
        Me.ProgressBar2.TabIndex = 48
        '
        'BrowseBtn2
        '
        Me.BrowseBtn2.BackColor = System.Drawing.Color.Blue
        Me.BrowseBtn2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBtn2.ForeColor = System.Drawing.Color.White
        Me.BrowseBtn2.Location = New System.Drawing.Point(465, 18)
        Me.BrowseBtn2.Name = "BrowseBtn2"
        Me.BrowseBtn2.Size = New System.Drawing.Size(152, 30)
        Me.BrowseBtn2.TabIndex = 47
        Me.BrowseBtn2.Text = "Select Upload File"
        Me.BrowseBtn2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 26)
        Me.TextBox1.TabIndex = 46
        '
        'UploadBtn2
        '
        Me.UploadBtn2.BackColor = System.Drawing.Color.Green
        Me.UploadBtn2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadBtn2.ForeColor = System.Drawing.Color.White
        Me.UploadBtn2.Location = New System.Drawing.Point(465, 65)
        Me.UploadBtn2.Name = "UploadBtn2"
        Me.UploadBtn2.Size = New System.Drawing.Size(152, 30)
        Me.UploadBtn2.TabIndex = 45
        Me.UploadBtn2.Text = "Upload"
        Me.UploadBtn2.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.EmployeeGrid)
        Me.TabPage3.Controls.Add(Me.DelBtn)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.DelEmployeeTbx)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(631, 150)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Delete User"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'EmployeeGrid
        '
        Me.EmployeeGrid.AllowUserToAddRows = False
        Me.EmployeeGrid.AllowUserToDeleteRows = False
        Me.EmployeeGrid.AllowUserToOrderColumns = True
        Me.EmployeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeGrid.Location = New System.Drawing.Point(13, 58)
        Me.EmployeeGrid.Name = "EmployeeGrid"
        Me.EmployeeGrid.ReadOnly = True
        Me.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeGrid.Size = New System.Drawing.Size(612, 75)
        Me.EmployeeGrid.TabIndex = 44
        '
        'DelBtn
        '
        Me.DelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DelBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.ForeColor = System.Drawing.Color.White
        Me.DelBtn.Location = New System.Drawing.Point(224, 16)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(74, 33)
        Me.DelBtn.TabIndex = 43
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Employee ID"
        '
        'DelEmployeeTbx
        '
        Me.DelEmployeeTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.DelEmployeeTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelEmployeeTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.DelEmployeeTbx.Location = New System.Drawing.Point(103, 21)
        Me.DelEmployeeTbx.Name = "DelEmployeeTbx"
        Me.DelEmployeeTbx.Size = New System.Drawing.Size(91, 23)
        Me.DelEmployeeTbx.TabIndex = 42
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ProgressBar3)
        Me.TabPage4.Controls.Add(Me.ExportBtn)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(631, 150)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Export User List"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(36, 62)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(424, 28)
        Me.ProgressBar3.TabIndex = 45
        '
        'ExportBtn
        '
        Me.ExportBtn.BackColor = System.Drawing.Color.Green
        Me.ExportBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportBtn.ForeColor = System.Drawing.Color.White
        Me.ExportBtn.Location = New System.Drawing.Point(480, 60)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(117, 30)
        Me.ExportBtn.TabIndex = 25
        Me.ExportBtn.Text = "Export"
        Me.ExportBtn.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        '
        'PMS_UserMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 490)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuotaGridView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PMS_UserMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PMS - User Master"
        CType(Me.QuotaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.EmployeeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents QuotaGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents FileLocation As TextBox
    Friend WithEvents UploadBtn As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ExportBtn As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents BrowseBtn2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UploadBtn2 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents EmployeeGrid As DataGridView
    Friend WithEvents DelBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DelEmployeeTbx As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents Timer2 As Timer
End Class
