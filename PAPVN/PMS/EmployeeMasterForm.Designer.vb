<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeMasterForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EmployeeGrid = New System.Windows.Forms.DataGridView()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DelEmployeeTbx = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DivCombox = New System.Windows.Forms.ComboBox()
        Me.IsApprove = New System.Windows.Forms.ComboBox()
        Me.NameTbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.App2Tbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmployeeTbx = New System.Windows.Forms.TextBox()
        Me.App1Tbx = New System.Windows.Forms.TextBox()
        Me.DeptCombox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmailTbx = New System.Windows.Forms.TextBox()
        Me.LocationCombox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PositionCombox = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NewDivCombox = New System.Windows.Forms.ComboBox()
        Me.NewDeptCombox = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NewInfoDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UpdateTypeCombox = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.UpdateUserGid = New System.Windows.Forms.DataGridView()
        Me.App2NewNameTbx = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.App1NewNameTbx = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChangeInfoBtn = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.App2NewTbx = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.UpdateIdTbx = New System.Windows.Forms.TextBox()
        Me.App1NewTbx = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EmployeeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NewInfoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateUserGid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 441)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add/Remove Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EmployeeGrid)
        Me.GroupBox2.Controls.Add(Me.DelBtn)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.DelEmployeeTbx)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 116)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remove Employee"
        '
        'EmployeeGrid
        '
        Me.EmployeeGrid.AllowUserToAddRows = False
        Me.EmployeeGrid.AllowUserToDeleteRows = False
        Me.EmployeeGrid.AllowUserToOrderColumns = True
        Me.EmployeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeGrid.Location = New System.Drawing.Point(113, 19)
        Me.EmployeeGrid.Name = "EmployeeGrid"
        Me.EmployeeGrid.ReadOnly = True
        Me.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeGrid.Size = New System.Drawing.Size(644, 86)
        Me.EmployeeGrid.TabIndex = 40
        '
        'DelBtn
        '
        Me.DelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DelBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.ForeColor = System.Drawing.Color.White
        Me.DelBtn.Location = New System.Drawing.Point(18, 72)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(74, 33)
        Me.DelBtn.TabIndex = 39
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Employee ID"
        '
        'DelEmployeeTbx
        '
        Me.DelEmployeeTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.DelEmployeeTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelEmployeeTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.DelEmployeeTbx.Location = New System.Drawing.Point(18, 43)
        Me.DelEmployeeTbx.Name = "DelEmployeeTbx"
        Me.DelEmployeeTbx.Size = New System.Drawing.Size(74, 23)
        Me.DelEmployeeTbx.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.SubmitBtn)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DivCombox)
        Me.GroupBox1.Controls.Add(Me.IsApprove)
        Me.GroupBox1.Controls.Add(Me.NameTbx)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.App2Tbx)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.EmployeeTbx)
        Me.GroupBox1.Controls.Add(Me.App1Tbx)
        Me.GroupBox1.Controls.Add(Me.DeptCombox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EmailTbx)
        Me.GroupBox1.Controls.Add(Me.LocationCombox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PositionCombox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 270)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Employee"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(270, 32)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "* Set 0 if employee has no Approver 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Default password for new employee is blank" &
    ""
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.Color.Green
        Me.SubmitBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitBtn.Location = New System.Drawing.Point(349, 216)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(84, 34)
        Me.SubmitBtn.TabIndex = 38
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 16)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Employee type"
        '
        'DivCombox
        '
        Me.DivCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.DivCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.DivCombox.FormattingEnabled = True
        Me.DivCombox.Items.AddRange(New Object() {"Administration", "Refrigerator", "ARBU", "AP Marketing", "AWBU", "R&D", "Washing Machine", "WM Procurement"})
        Me.DivCombox.Location = New System.Drawing.Point(72, 75)
        Me.DivCombox.Name = "DivCombox"
        Me.DivCombox.Size = New System.Drawing.Size(176, 24)
        Me.DivCombox.TabIndex = 22
        '
        'IsApprove
        '
        Me.IsApprove.BackColor = System.Drawing.Color.LemonChiffon
        Me.IsApprove.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsApprove.ForeColor = System.Drawing.Color.MediumBlue
        Me.IsApprove.FormattingEnabled = True
        Me.IsApprove.Items.AddRange(New Object() {"Regular Employee", "Approver (VN)", "Approver (JP)"})
        Me.IsApprove.Location = New System.Drawing.Point(108, 28)
        Me.IsApprove.Name = "IsApprove"
        Me.IsApprove.Size = New System.Drawing.Size(140, 24)
        Me.IsApprove.TabIndex = 37
        '
        'NameTbx
        '
        Me.NameTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.NameTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.NameTbx.Location = New System.Drawing.Point(524, 28)
        Me.NameTbx.Name = "NameTbx"
        Me.NameTbx.Size = New System.Drawing.Size(234, 23)
        Me.NameTbx.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Employee ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(446, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Full Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(265, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department:"
        '
        'App2Tbx
        '
        Me.App2Tbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.App2Tbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App2Tbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App2Tbx.Location = New System.Drawing.Point(359, 168)
        Me.App2Tbx.Name = "App2Tbx"
        Me.App2Tbx.Size = New System.Drawing.Size(74, 23)
        Me.App2Tbx.TabIndex = 32
        Me.App2Tbx.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Division:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(263, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Approver 2*:"
        '
        'EmployeeTbx
        '
        Me.EmployeeTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.EmployeeTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.EmployeeTbx.Location = New System.Drawing.Point(359, 28)
        Me.EmployeeTbx.Name = "EmployeeTbx"
        Me.EmployeeTbx.Size = New System.Drawing.Size(74, 23)
        Me.EmployeeTbx.TabIndex = 8
        '
        'App1Tbx
        '
        Me.App1Tbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.App1Tbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App1Tbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App1Tbx.Location = New System.Drawing.Point(98, 168)
        Me.App1Tbx.Name = "App1Tbx"
        Me.App1Tbx.Size = New System.Drawing.Size(74, 23)
        Me.App1Tbx.TabIndex = 30
        '
        'DeptCombox
        '
        Me.DeptCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.DeptCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.DeptCombox.FormattingEnabled = True
        Me.DeptCombox.Location = New System.Drawing.Point(359, 75)
        Me.DeptCombox.Name = "DeptCombox"
        Me.DeptCombox.Size = New System.Drawing.Size(145, 24)
        Me.DeptCombox.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Approver 1*:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(521, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Location:"
        '
        'EmailTbx
        '
        Me.EmailTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.EmailTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.EmailTbx.Location = New System.Drawing.Point(72, 122)
        Me.EmailTbx.Name = "EmailTbx"
        Me.EmailTbx.Size = New System.Drawing.Size(432, 23)
        Me.EmailTbx.TabIndex = 28
        '
        'LocationCombox
        '
        Me.LocationCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.LocationCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.LocationCombox.FormattingEnabled = True
        Me.LocationCombox.Items.AddRange(New Object() {"TL1", "TL2"})
        Me.LocationCombox.Location = New System.Drawing.Point(599, 122)
        Me.LocationCombox.Name = "LocationCombox"
        Me.LocationCombox.Size = New System.Drawing.Size(49, 24)
        Me.LocationCombox.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(521, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Position:"
        '
        'PositionCombox
        '
        Me.PositionCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.PositionCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.PositionCombox.FormattingEnabled = True
        Me.PositionCombox.Location = New System.Drawing.Point(599, 75)
        Me.PositionCombox.Name = "PositionCombox"
        Me.PositionCombox.Size = New System.Drawing.Size(158, 24)
        Me.PositionCombox.TabIndex = 26
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NewDivCombox)
        Me.TabPage2.Controls.Add(Me.NewDeptCombox)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.NewInfoDataGrid)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.UpdateTypeCombox)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.UpdateUserGid)
        Me.TabPage2.Controls.Add(Me.App2NewNameTbx)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.App1NewNameTbx)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.ChangeInfoBtn)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.App2NewTbx)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.UpdateIdTbx)
        Me.TabPage2.Controls.Add(Me.App1NewTbx)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Update Employee's Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NewDivCombox
        '
        Me.NewDivCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.NewDivCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewDivCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.NewDivCombox.FormattingEnabled = True
        Me.NewDivCombox.Items.AddRange(New Object() {"Administration", "Refrigerator", "ARBU", "AP Marketing", "AWBU", "R&D", "Washing Machine", "WM Procurement"})
        Me.NewDivCombox.Location = New System.Drawing.Point(211, 154)
        Me.NewDivCombox.Name = "NewDivCombox"
        Me.NewDivCombox.Size = New System.Drawing.Size(176, 24)
        Me.NewDivCombox.TabIndex = 73
        Me.NewDivCombox.Text = "Select Division"
        Me.NewDivCombox.Visible = False
        '
        'NewDeptCombox
        '
        Me.NewDeptCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.NewDeptCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewDeptCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.NewDeptCombox.FormattingEnabled = True
        Me.NewDeptCombox.Location = New System.Drawing.Point(491, 154)
        Me.NewDeptCombox.Name = "NewDeptCombox"
        Me.NewDeptCombox.Size = New System.Drawing.Size(145, 24)
        Me.NewDeptCombox.TabIndex = 72
        Me.NewDeptCombox.Text = "Select Department"
        Me.NewDeptCombox.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 154)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(188, 16)
        Me.Label22.TabIndex = 71
        Me.Label22.Text = "Change New Department To"
        Me.Label22.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 313)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 16)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Employee's New Info"
        '
        'NewInfoDataGrid
        '
        Me.NewInfoDataGrid.AllowUserToAddRows = False
        Me.NewInfoDataGrid.AllowUserToDeleteRows = False
        Me.NewInfoDataGrid.AllowUserToOrderColumns = True
        Me.NewInfoDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.NewInfoDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewInfoDataGrid.Location = New System.Drawing.Point(20, 335)
        Me.NewInfoDataGrid.Name = "NewInfoDataGrid"
        Me.NewInfoDataGrid.ReadOnly = True
        Me.NewInfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NewInfoDataGrid.Size = New System.Drawing.Size(746, 60)
        Me.NewInfoDataGrid.TabIndex = 69
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(164, 16)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Employee's Current Info"
        '
        'UpdateTypeCombox
        '
        Me.UpdateTypeCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.UpdateTypeCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTypeCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.UpdateTypeCombox.FormattingEnabled = True
        Me.UpdateTypeCombox.Items.AddRange(New Object() {"Change Approver 1", "Change Approver 2", "Change Both Approvers", "Update Employee's Information"})
        Me.UpdateTypeCombox.Location = New System.Drawing.Point(129, 15)
        Me.UpdateTypeCombox.Name = "UpdateTypeCombox"
        Me.UpdateTypeCombox.Size = New System.Drawing.Size(277, 24)
        Me.UpdateTypeCombox.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 16)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Type of update"
        '
        'UpdateUserGid
        '
        Me.UpdateUserGid.AllowUserToAddRows = False
        Me.UpdateUserGid.AllowUserToDeleteRows = False
        Me.UpdateUserGid.AllowUserToOrderColumns = True
        Me.UpdateUserGid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UpdateUserGid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateUserGid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UpdateUserGid.Location = New System.Drawing.Point(20, 74)
        Me.UpdateUserGid.Name = "UpdateUserGid"
        Me.UpdateUserGid.ReadOnly = True
        Me.UpdateUserGid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UpdateUserGid.Size = New System.Drawing.Size(746, 60)
        Me.UpdateUserGid.TabIndex = 65
        '
        'App2NewNameTbx
        '
        Me.App2NewNameTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.App2NewNameTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App2NewNameTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App2NewNameTbx.Location = New System.Drawing.Point(566, 196)
        Me.App2NewNameTbx.Name = "App2NewNameTbx"
        Me.App2NewNameTbx.ReadOnly = True
        Me.App2NewNameTbx.Size = New System.Drawing.Size(200, 23)
        Me.App2NewNameTbx.TabIndex = 64
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(488, 199)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "Name:"
        '
        'App1NewNameTbx
        '
        Me.App1NewNameTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.App1NewNameTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App1NewNameTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App1NewNameTbx.Location = New System.Drawing.Point(94, 196)
        Me.App1NewNameTbx.Name = "App1NewNameTbx"
        Me.App1NewNameTbx.ReadOnly = True
        Me.App1NewNameTbx.Size = New System.Drawing.Size(200, 23)
        Me.App1NewNameTbx.TabIndex = 62
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(12, 242)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 32)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Vietnamese: Use Employee ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Japanese: Use Global ID"
        '
        'ChangeInfoBtn
        '
        Me.ChangeInfoBtn.BackColor = System.Drawing.Color.Green
        Me.ChangeInfoBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeInfoBtn.ForeColor = System.Drawing.Color.White
        Me.ChangeInfoBtn.Location = New System.Drawing.Point(332, 242)
        Me.ChangeInfoBtn.Name = "ChangeInfoBtn"
        Me.ChangeInfoBtn.Size = New System.Drawing.Size(84, 34)
        Me.ChangeInfoBtn.TabIndex = 59
        Me.ChangeInfoBtn.Text = "Submit"
        Me.ChangeInfoBtn.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(481, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 16)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Employee ID need to update:"
        '
        'App2NewTbx
        '
        Me.App2NewTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.App2NewTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App2NewTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App2NewTbx.Location = New System.Drawing.Point(641, 152)
        Me.App2NewTbx.Name = "App2NewTbx"
        Me.App2NewTbx.ReadOnly = True
        Me.App2NewTbx.Size = New System.Drawing.Size(125, 23)
        Me.App2NewTbx.TabIndex = 58
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(488, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 16)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "New Approval 2 ID*"
        '
        'UpdateIdTbx
        '
        Me.UpdateIdTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.UpdateIdTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateIdTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.UpdateIdTbx.Location = New System.Drawing.Point(692, 15)
        Me.UpdateIdTbx.Name = "UpdateIdTbx"
        Me.UpdateIdTbx.ReadOnly = True
        Me.UpdateIdTbx.Size = New System.Drawing.Size(74, 23)
        Me.UpdateIdTbx.TabIndex = 54
        '
        'App1NewTbx
        '
        Me.App1NewTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.App1NewTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App1NewTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App1NewTbx.Location = New System.Drawing.Point(167, 151)
        Me.App1NewTbx.Name = "App1NewTbx"
        Me.App1NewTbx.ReadOnly = True
        Me.App1NewTbx.Size = New System.Drawing.Size(125, 23)
        Me.App1NewTbx.TabIndex = 56
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 16)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "New Approval 1 ID*"
        '
        'EmployeeMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "EmployeeMasterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EmployeeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NewInfoDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateUserGid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents EmployeeTbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DeptCombox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DivCombox As ComboBox
    Friend WithEvents NameTbx As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents App2Tbx As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents App1Tbx As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailTbx As TextBox
    Friend WithEvents LocationCombox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PositionCombox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DelBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DelEmployeeTbx As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents IsApprove As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents EmployeeGrid As DataGridView
    Friend WithEvents UpdateTypeCombox As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents UpdateUserGid As DataGridView
    Friend WithEvents App2NewNameTbx As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents App1NewNameTbx As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ChangeInfoBtn As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents App2NewTbx As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents UpdateIdTbx As TextBox
    Friend WithEvents App1NewTbx As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents NewDivCombox As ComboBox
    Friend WithEvents NewDeptCombox As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents NewInfoDataGrid As DataGridView
    Friend WithEvents Label17 As Label
End Class
