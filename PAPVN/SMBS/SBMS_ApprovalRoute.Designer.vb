<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SBMS_ApprovalRoute
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SBMS_ApprovalRoute))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ApprovalRouteView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.UploadBtn = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BusID = New System.Windows.Forms.Label()
        Me.FileLocation = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.BusID2 = New System.Windows.Forms.Label()
        Me.AddrTbx2 = New System.Windows.Forms.TextBox()
        Me.BusNameCombox2 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.EmployeeIDTbx2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MobileTbx2 = New System.Windows.Forms.TextBox()
        Me.NameTbx2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.EmailTbx2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ApprovalRouteView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "BUS MANAGEMENT SYSTEM - APPROVAL ROUTE MASTER"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(17, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(747, 439)
        Me.TabControl1.TabIndex = 41
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ApprovalRouteView)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(739, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add New Approval Route"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ApprovalRouteView
        '
        Me.ApprovalRouteView.AllowUserToAddRows = False
        Me.ApprovalRouteView.AllowUserToDeleteRows = False
        Me.ApprovalRouteView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ApprovalRouteView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ApprovalRouteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApprovalRouteView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ApprovalRouteView.Location = New System.Drawing.Point(9, 181)
        Me.ApprovalRouteView.MultiSelect = False
        Me.ApprovalRouteView.Name = "ApprovalRouteView"
        Me.ApprovalRouteView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ApprovalRouteView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ApprovalRouteView.RowHeadersVisible = False
        Me.ApprovalRouteView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ApprovalRouteView.Size = New System.Drawing.Size(714, 226)
        Me.ApprovalRouteView.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BrowseBtn)
        Me.GroupBox1.Controls.Add(Me.UploadBtn)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.BusID)
        Me.GroupBox1.Controls.Add(Me.FileLocation)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 155)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'BrowseBtn
        '
        Me.BrowseBtn.BackColor = System.Drawing.Color.Blue
        Me.BrowseBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBtn.ForeColor = System.Drawing.Color.White
        Me.BrowseBtn.Location = New System.Drawing.Point(529, 29)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(152, 30)
        Me.BrowseBtn.TabIndex = 77
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = False
        '
        'UploadBtn
        '
        Me.UploadBtn.BackColor = System.Drawing.Color.Green
        Me.UploadBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadBtn.ForeColor = System.Drawing.Color.White
        Me.UploadBtn.Location = New System.Drawing.Point(529, 76)
        Me.UploadBtn.Name = "UploadBtn"
        Me.UploadBtn.Size = New System.Drawing.Size(152, 30)
        Me.UploadBtn.TabIndex = 76
        Me.UploadBtn.Text = "Upload"
        Me.UploadBtn.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(72, 74)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 28)
        Me.ProgressBar1.TabIndex = 75
        '
        'BusID
        '
        Me.BusID.AutoSize = True
        Me.BusID.Location = New System.Drawing.Point(98, 143)
        Me.BusID.Name = "BusID"
        Me.BusID.Size = New System.Drawing.Size(0, 13)
        Me.BusID.TabIndex = 71
        Me.BusID.Visible = False
        '
        'FileLocation
        '
        Me.FileLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FileLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileLocation.ForeColor = System.Drawing.Color.Navy
        Me.FileLocation.Location = New System.Drawing.Point(72, 33)
        Me.FileLocation.Name = "FileLocation"
        Me.FileLocation.Size = New System.Drawing.Size(424, 23)
        Me.FileLocation.TabIndex = 34
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(739, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Delete/Update Approval Route"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteBtn)
        Me.GroupBox2.Controls.Add(Me.UpdateBtn)
        Me.GroupBox2.Controls.Add(Me.BusID2)
        Me.GroupBox2.Controls.Add(Me.AddrTbx2)
        Me.GroupBox2.Controls.Add(Me.BusNameCombox2)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.EmployeeIDTbx2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.MobileTbx2)
        Me.GroupBox2.Controls.Add(Me.NameTbx2)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.EmailTbx2)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 206)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Update/Delete Employee"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Red
        Me.DeleteBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(313, 157)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(152, 34)
        Me.DeleteBtn.TabIndex = 72
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.Blue
        Me.UpdateBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(73, 157)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(152, 34)
        Me.UpdateBtn.TabIndex = 41
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'BusID2
        '
        Me.BusID2.AutoSize = True
        Me.BusID2.Location = New System.Drawing.Point(98, 157)
        Me.BusID2.Name = "BusID2"
        Me.BusID2.Size = New System.Drawing.Size(0, 13)
        Me.BusID2.TabIndex = 71
        Me.BusID2.Visible = False
        '
        'AddrTbx2
        '
        Me.AddrTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddrTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddrTbx2.ForeColor = System.Drawing.Color.Navy
        Me.AddrTbx2.Location = New System.Drawing.Point(313, 117)
        Me.AddrTbx2.Name = "AddrTbx2"
        Me.AddrTbx2.Size = New System.Drawing.Size(298, 23)
        Me.AddrTbx2.TabIndex = 66
        '
        'BusNameCombox2
        '
        Me.BusNameCombox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BusNameCombox2.ForeColor = System.Drawing.Color.Navy
        Me.BusNameCombox2.FormattingEnabled = True
        Me.BusNameCombox2.Items.AddRange(New Object() {"Bus 1-01", "Bus 1-02", "Bus 1-03", "Bus 1-04", "Bus 1-05", "Bus 1-06", "Bus 1-07", "Bus 1-08", "Bus 1-09"})
        Me.BusNameCombox2.Location = New System.Drawing.Point(101, 119)
        Me.BusNameCombox2.Name = "BusNameCombox2"
        Me.BusNameCombox2.Size = New System.Drawing.Size(124, 21)
        Me.BusNameCombox2.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Bus Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 16)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Employee ID"
        '
        'EmployeeIDTbx2
        '
        Me.EmployeeIDTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EmployeeIDTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTbx2.ForeColor = System.Drawing.Color.Navy
        Me.EmployeeIDTbx2.Location = New System.Drawing.Point(101, 31)
        Me.EmployeeIDTbx2.MaxLength = 7
        Me.EmployeeIDTbx2.Name = "EmployeeIDTbx2"
        Me.EmployeeIDTbx2.Size = New System.Drawing.Size(124, 23)
        Me.EmployeeIDTbx2.TabIndex = 58
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(259, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 16)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Addr."
        '
        'MobileTbx2
        '
        Me.MobileTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MobileTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTbx2.ForeColor = System.Drawing.Color.Navy
        Me.MobileTbx2.Location = New System.Drawing.Point(101, 75)
        Me.MobileTbx2.MaxLength = 10
        Me.MobileTbx2.Name = "MobileTbx2"
        Me.MobileTbx2.Size = New System.Drawing.Size(124, 23)
        Me.MobileTbx2.TabIndex = 40
        '
        'NameTbx2
        '
        Me.NameTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NameTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTbx2.ForeColor = System.Drawing.Color.Navy
        Me.NameTbx2.Location = New System.Drawing.Point(313, 31)
        Me.NameTbx2.Name = "NameTbx2"
        Me.NameTbx2.Size = New System.Drawing.Size(298, 23)
        Me.NameTbx2.TabIndex = 34
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(259, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 16)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 16)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Mobile No"
        '
        'EmailTbx2
        '
        Me.EmailTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EmailTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTbx2.ForeColor = System.Drawing.Color.Navy
        Me.EmailTbx2.Location = New System.Drawing.Point(313, 74)
        Me.EmailTbx2.Name = "EmailTbx2"
        Me.EmailTbx2.Size = New System.Drawing.Size(298, 23)
        Me.EmailTbx2.TabIndex = 28
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(258, 78)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Email"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SBMS_ApprovalRoute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SBMS_ApprovalRoute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Route Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ApprovalRouteView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BusID As Label
    Friend WithEvents FileLocation As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents BusID2 As Label
    Friend WithEvents AddrTbx2 As TextBox
    Friend WithEvents BusNameCombox2 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents EmployeeIDTbx2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents MobileTbx2 As TextBox
    Friend WithEvents NameTbx2 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents EmailTbx2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents ApprovalRouteView As DataGridView
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents UploadBtn As Button
End Class
