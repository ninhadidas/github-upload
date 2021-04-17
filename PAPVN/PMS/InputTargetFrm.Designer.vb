Imports MySql.Data.MySqlClient
Imports outlook = Microsoft.Office.Interop.Outlook
Imports System.Text.RegularExpressions
Imports System.Net.Mail
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputTargetFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputTargetFrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PeriodLabel = New System.Windows.Forms.Label()
        Me.DeptLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmployeeLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Statuslb = New System.Windows.Forms.LinkLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ContentTbx2 = New System.Windows.Forms.TextBox()
        Me.WeightTbx3 = New System.Windows.Forms.TextBox()
        Me.WeightTbx2 = New System.Windows.Forms.TextBox()
        Me.WeightTbx1 = New System.Windows.Forms.TextBox()
        Me.DiffTbx3 = New System.Windows.Forms.TextBox()
        Me.DiffTbx2 = New System.Windows.Forms.TextBox()
        Me.DiffTbx1 = New System.Windows.Forms.TextBox()
        Me.DiffComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DiffComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DiffComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DevPlanTbx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ContentTbx3 = New System.Windows.Forms.TextBox()
        Me.TitleTxb3 = New System.Windows.Forms.TextBox()
        Me.TitleTbx2 = New System.Windows.Forms.TextBox()
        Me.ContentTbx1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TitleTbx1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.App2Lbl = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.App1Lbl = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Status1 = New System.Windows.Forms.RadioButton()
        Me.Status2 = New System.Windows.Forms.RadioButton()
        Me.Status8 = New System.Windows.Forms.RadioButton()
        Me.Status7 = New System.Windows.Forms.RadioButton()
        Me.Status6 = New System.Windows.Forms.RadioButton()
        Me.Status5 = New System.Windows.Forms.RadioButton()
        Me.Status4 = New System.Windows.Forms.RadioButton()
        Me.Status3 = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(616, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PERFORMANCE MANAGEMENT SYSTEM - INPUT TARGETS"
        '
        'CloseBtn
        '
        Me.CloseBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.Black
        Me.CloseBtn.Location = New System.Drawing.Point(1257, 15)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 41)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'PrintBtn
        '
        Me.PrintBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.Color.Black
        Me.PrintBtn.Location = New System.Drawing.Point(1157, 15)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(75, 41)
        Me.PrintBtn.TabIndex = 7
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'SubmitBtn
        '
        Me.SubmitBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.SubmitBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.Black
        Me.SubmitBtn.Location = New System.Drawing.Point(1057, 15)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 41)
        Me.SubmitBtn.TabIndex = 8
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        Me.SubmitBtn.Visible = False
        '
        'SaveBtn
        '
        Me.SaveBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.SaveBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.SaveBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Location = New System.Drawing.Point(957, 15)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 41)
        Me.SaveBtn.TabIndex = 9
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        Me.SaveBtn.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PERIOD:"
        '
        'PeriodLabel
        '
        Me.PeriodLabel.AutoSize = True
        Me.PeriodLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PeriodLabel.Location = New System.Drawing.Point(80, 76)
        Me.PeriodLabel.Name = "PeriodLabel"
        Me.PeriodLabel.Size = New System.Drawing.Size(60, 16)
        Me.PeriodLabel.TabIndex = 11
        Me.PeriodLabel.Text = "PERIOD:"
        '
        'DeptLabel
        '
        Me.DeptLabel.AutoSize = True
        Me.DeptLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DeptLabel.Location = New System.Drawing.Point(317, 76)
        Me.DeptLabel.Name = "DeptLabel"
        Me.DeptLabel.Size = New System.Drawing.Size(39, 16)
        Me.DeptLabel.TabIndex = 13
        Me.DeptLabel.Text = "Dept"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(274, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Dept:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.NameLabel.Location = New System.Drawing.Point(616, 76)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(67, 16)
        Me.NameLabel.TabIndex = 15
        Me.NameLabel.Text = "Full Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(547, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Full Name:"
        '
        'EmployeeLabel
        '
        Me.EmployeeLabel.AutoSize = True
        Me.EmployeeLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.EmployeeLabel.Location = New System.Drawing.Point(983, 76)
        Me.EmployeeLabel.Name = "EmployeeLabel"
        Me.EmployeeLabel.Size = New System.Drawing.Size(87, 16)
        Me.EmployeeLabel.TabIndex = 17
        Me.EmployeeLabel.Text = "Employee ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(892, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Employee ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1178, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Status ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Statuslb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1320, 53)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Statuslb
        '
        Me.Statuslb.AutoSize = True
        Me.Statuslb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslb.Location = New System.Drawing.Point(1245, 20)
        Me.Statuslb.Name = "Statuslb"
        Me.Statuslb.Size = New System.Drawing.Size(14, 13)
        Me.Statuslb.TabIndex = 0
        Me.Statuslb.TabStop = True
        Me.Statuslb.Text = "0"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 116)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1326, 593)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.PictureBox9)
        Me.TabPage1.Controls.Add(Me.PictureBox8)
        Me.TabPage1.Controls.Add(Me.ContentTbx2)
        Me.TabPage1.Controls.Add(Me.WeightTbx3)
        Me.TabPage1.Controls.Add(Me.WeightTbx2)
        Me.TabPage1.Controls.Add(Me.WeightTbx1)
        Me.TabPage1.Controls.Add(Me.DiffTbx3)
        Me.TabPage1.Controls.Add(Me.DiffTbx2)
        Me.TabPage1.Controls.Add(Me.DiffTbx1)
        Me.TabPage1.Controls.Add(Me.DiffComboBox3)
        Me.TabPage1.Controls.Add(Me.DiffComboBox2)
        Me.TabPage1.Controls.Add(Me.DiffComboBox1)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.DevPlanTbx)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ContentTbx3)
        Me.TabPage1.Controls.Add(Me.TitleTxb3)
        Me.TabPage1.Controls.Add(Me.TitleTbx2)
        Me.TabPage1.Controls.Add(Me.ContentTbx1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TitleTbx1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1318, 567)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Management by Ojective"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(12, 474)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 13)
        Me.Label33.TabIndex = 83
        Me.Label33.Text = "Clear"
        Me.Label33.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(12, 333)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 13)
        Me.Label32.TabIndex = 82
        Me.Label32.Text = "Clear"
        Me.Label32.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(10, 438)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 81
        Me.PictureBox9.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox9, "Click here to delete this target")
        Me.PictureBox9.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(10, 297)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 80
        Me.PictureBox8.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox8, "Click here to delete this target")
        Me.PictureBox8.Visible = False
        '
        'ContentTbx2
        '
        Me.ContentTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx2.Location = New System.Drawing.Point(49, 227)
        Me.ContentTbx2.Multiline = True
        Me.ContentTbx2.Name = "ContentTbx2"
        Me.ContentTbx2.ReadOnly = True
        Me.ContentTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx2.Size = New System.Drawing.Size(1059, 125)
        Me.ContentTbx2.TabIndex = 79
        '
        'WeightTbx3
        '
        Me.WeightTbx3.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx3.Location = New System.Drawing.Point(1244, 375)
        Me.WeightTbx3.MaxLength = 2
        Me.WeightTbx3.Multiline = True
        Me.WeightTbx3.Name = "WeightTbx3"
        Me.WeightTbx3.ReadOnly = True
        Me.WeightTbx3.Size = New System.Drawing.Size(70, 121)
        Me.WeightTbx3.TabIndex = 78
        Me.WeightTbx3.Text = "0"
        Me.WeightTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTbx2
        '
        Me.WeightTbx2.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx2.Location = New System.Drawing.Point(1244, 227)
        Me.WeightTbx2.MaxLength = 2
        Me.WeightTbx2.Multiline = True
        Me.WeightTbx2.Name = "WeightTbx2"
        Me.WeightTbx2.ReadOnly = True
        Me.WeightTbx2.Size = New System.Drawing.Size(70, 125)
        Me.WeightTbx2.TabIndex = 77
        Me.WeightTbx2.Text = "0"
        Me.WeightTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTbx1
        '
        Me.WeightTbx1.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx1.Location = New System.Drawing.Point(1244, 79)
        Me.WeightTbx1.MaxLength = 3
        Me.WeightTbx1.Multiline = True
        Me.WeightTbx1.Name = "WeightTbx1"
        Me.WeightTbx1.ReadOnly = True
        Me.WeightTbx1.Size = New System.Drawing.Size(70, 125)
        Me.WeightTbx1.TabIndex = 76
        Me.WeightTbx1.Text = "0"
        Me.WeightTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx3
        '
        Me.DiffTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx3.Location = New System.Drawing.Point(1105, 396)
        Me.DiffTbx3.Multiline = True
        Me.DiffTbx3.Name = "DiffTbx3"
        Me.DiffTbx3.ReadOnly = True
        Me.DiffTbx3.Size = New System.Drawing.Size(141, 100)
        Me.DiffTbx3.TabIndex = 75
        Me.DiffTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx2
        '
        Me.DiffTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx2.Location = New System.Drawing.Point(1105, 248)
        Me.DiffTbx2.Multiline = True
        Me.DiffTbx2.Name = "DiffTbx2"
        Me.DiffTbx2.ReadOnly = True
        Me.DiffTbx2.Size = New System.Drawing.Size(141, 104)
        Me.DiffTbx2.TabIndex = 74
        Me.DiffTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx1
        '
        Me.DiffTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx1.Location = New System.Drawing.Point(1105, 100)
        Me.DiffTbx1.Multiline = True
        Me.DiffTbx1.Name = "DiffTbx1"
        Me.DiffTbx1.ReadOnly = True
        Me.DiffTbx1.Size = New System.Drawing.Size(141, 104)
        Me.DiffTbx1.TabIndex = 73
        Me.DiffTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffComboBox3
        '
        Me.DiffComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DiffComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiffComboBox3.FormattingEnabled = True
        Me.DiffComboBox3.Items.AddRange(New Object() {"D1: Easy for the position", "D2: Appropriate for the position", "D3: Challenging for the position"})
        Me.DiffComboBox3.Location = New System.Drawing.Point(1105, 375)
        Me.DiffComboBox3.Name = "DiffComboBox3"
        Me.DiffComboBox3.Size = New System.Drawing.Size(141, 21)
        Me.DiffComboBox3.TabIndex = 72
        '
        'DiffComboBox2
        '
        Me.DiffComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DiffComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiffComboBox2.FormattingEnabled = True
        Me.DiffComboBox2.Items.AddRange(New Object() {"D1: Easy for the position", "D2: Appropriate for the position", "D3: Challenging for the position"})
        Me.DiffComboBox2.Location = New System.Drawing.Point(1105, 227)
        Me.DiffComboBox2.Name = "DiffComboBox2"
        Me.DiffComboBox2.Size = New System.Drawing.Size(141, 21)
        Me.DiffComboBox2.TabIndex = 71
        '
        'DiffComboBox1
        '
        Me.DiffComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DiffComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiffComboBox1.FormattingEnabled = True
        Me.DiffComboBox1.Items.AddRange(New Object() {"D1: Easy for the position", "D2: Appropriate for the position", "D3: Challenging for the position"})
        Me.DiffComboBox1.Location = New System.Drawing.Point(1105, 79)
        Me.DiffComboBox1.Name = "DiffComboBox1"
        Me.DiffComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.DiffComboBox1.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label19.Location = New System.Drawing.Point(1244, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 19)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Weight"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label18.Location = New System.Drawing.Point(1106, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 19)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Difficulty"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label17.Location = New System.Drawing.Point(7, 352)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 144)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "3"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label16.Location = New System.Drawing.Point(7, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 148)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label15.Location = New System.Drawing.Point(7, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 148)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label14.Location = New System.Drawing.Point(7, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 39)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.Location = New System.Drawing.Point(49, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 23)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Title:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label12.Location = New System.Drawing.Point(49, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Title:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label11.Location = New System.Drawing.Point(49, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Title:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DevPlanTbx
        '
        Me.DevPlanTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevPlanTbx.Location = New System.Drawing.Point(7, 517)
        Me.DevPlanTbx.Multiline = True
        Me.DevPlanTbx.Name = "DevPlanTbx"
        Me.DevPlanTbx.ReadOnly = True
        Me.DevPlanTbx.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DevPlanTbx.Size = New System.Drawing.Size(1307, 43)
        Me.DevPlanTbx.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(7, 497)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1307, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Your Development Plan (career plan, self-development, study, certification, train" &
    "ing, etc.)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContentTbx3
        '
        Me.ContentTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx3.Location = New System.Drawing.Point(49, 375)
        Me.ContentTbx3.Multiline = True
        Me.ContentTbx3.Name = "ContentTbx3"
        Me.ContentTbx3.ReadOnly = True
        Me.ContentTbx3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx3.Size = New System.Drawing.Size(1059, 121)
        Me.ContentTbx3.TabIndex = 58
        '
        'TitleTxb3
        '
        Me.TitleTxb3.BackColor = System.Drawing.Color.Silver
        Me.TitleTxb3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxb3.Location = New System.Drawing.Point(110, 352)
        Me.TitleTxb3.Name = "TitleTxb3"
        Me.TitleTxb3.ReadOnly = True
        Me.TitleTxb3.Size = New System.Drawing.Size(1204, 23)
        Me.TitleTxb3.TabIndex = 57
        '
        'TitleTbx2
        '
        Me.TitleTbx2.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx2.Location = New System.Drawing.Point(110, 204)
        Me.TitleTbx2.Name = "TitleTbx2"
        Me.TitleTbx2.ReadOnly = True
        Me.TitleTbx2.Size = New System.Drawing.Size(1204, 23)
        Me.TitleTbx2.TabIndex = 56
        '
        'ContentTbx1
        '
        Me.ContentTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx1.Location = New System.Drawing.Point(49, 79)
        Me.ContentTbx1.Multiline = True
        Me.ContentTbx1.Name = "ContentTbx1"
        Me.ContentTbx1.ReadOnly = True
        Me.ContentTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx1.Size = New System.Drawing.Size(1059, 125)
        Me.ContentTbx1.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.Location = New System.Drawing.Point(46, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1062, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "( KPI, Key Success Factor, Deadline )"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label6.Location = New System.Drawing.Point(46, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1268, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Targets"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(7, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1311, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Management by Ojective"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleTbx1
        '
        Me.TitleTbx1.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx1.Location = New System.Drawing.Point(110, 56)
        Me.TitleTbx1.Name = "TitleTbx1"
        Me.TitleTbx1.ReadOnly = True
        Me.TitleTbx1.Size = New System.Drawing.Size(1204, 23)
        Me.TitleTbx1.TabIndex = 51
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1318, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Routing"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.App2Lbl)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.App1Lbl)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1306, 164)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Approval Level"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Blue
        Me.Label29.Location = New System.Drawing.Point(609, 98)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(88, 16)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Approval 2: "
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Blue
        Me.Label30.Location = New System.Drawing.Point(609, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 16)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Approval 1: "
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label30.Visible = False
        '
        'App2Lbl
        '
        Me.App2Lbl.AutoSize = True
        Me.App2Lbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App2Lbl.ForeColor = System.Drawing.Color.Blue
        Me.App2Lbl.Location = New System.Drawing.Point(120, 86)
        Me.App2Lbl.Name = "App2Lbl"
        Me.App2Lbl.Size = New System.Drawing.Size(88, 16)
        Me.App2Lbl.TabIndex = 42
        Me.App2Lbl.Text = "Approval 2: "
        Me.App2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(26, 86)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 16)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "Approval 2: "
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'App1Lbl
        '
        Me.App1Lbl.AutoSize = True
        Me.App1Lbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App1Lbl.ForeColor = System.Drawing.Color.Blue
        Me.App1Lbl.Location = New System.Drawing.Point(120, 38)
        Me.App1Lbl.Name = "App1Lbl"
        Me.App1Lbl.Size = New System.Drawing.Size(88, 16)
        Me.App1Lbl.TabIndex = 40
        Me.App1Lbl.Text = "Approval 1: "
        Me.App1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(26, 38)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Approval 1: "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Status1)
        Me.GroupBox2.Controls.Add(Me.Status2)
        Me.GroupBox2.Controls.Add(Me.Status8)
        Me.GroupBox2.Controls.Add(Me.Status7)
        Me.GroupBox2.Controls.Add(Me.Status6)
        Me.GroupBox2.Controls.Add(Me.Status5)
        Me.GroupBox2.Controls.Add(Me.Status4)
        Me.GroupBox2.Controls.Add(Me.Status3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1306, 356)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Approval Flow"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(255, 230)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 16)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "8"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(496, 229)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 16)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "7"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(770, 229)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(16, 16)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "6"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(1024, 230)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(16, 16)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "5"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(1021, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(16, 16)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "4"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(755, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(16, 16)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "3"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(491, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 16)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "2"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(255, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(16, 16)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "1"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(270, 254)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(225, 12)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 37
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(513, 254)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(258, 12)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(787, 254)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(235, 12)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1024, 109)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(13, 119)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(773, 46)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(251, 12)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(506, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 12)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(270, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 12)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Status1
        '
        Me.Status1.AutoSize = True
        Me.Status1.BackColor = System.Drawing.Color.Transparent
        Me.Status1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status1.Enabled = False
        Me.Status1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status1.ForeColor = System.Drawing.Color.Black
        Me.Status1.Location = New System.Drawing.Point(210, 44)
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(106, 49)
        Me.Status1.TabIndex = 23
        Me.Status1.TabStop = True
        Me.Status1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Target Setting"
        Me.Status1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status1.UseVisualStyleBackColor = False
        '
        'Status2
        '
        Me.Status2.AutoSize = True
        Me.Status2.BackColor = System.Drawing.Color.Transparent
        Me.Status2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status2.Enabled = False
        Me.Status2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status2.ForeColor = System.Drawing.Color.Black
        Me.Status2.Location = New System.Drawing.Point(414, 46)
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(165, 81)
        Me.Status2.TabIndex = 24
        Me.Status2.TabStop = True
        Me.Status2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Submitted Target" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 1st Approver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv1 Approval)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Status2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status2.UseVisualStyleBackColor = False
        '
        'Status8
        '
        Me.Status8.AutoSize = True
        Me.Status8.BackColor = System.Drawing.Color.Transparent
        Me.Status8.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status8.Enabled = False
        Me.Status8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status8.ForeColor = System.Drawing.Color.Black
        Me.Status8.Location = New System.Drawing.Point(181, 253)
        Me.Status8.Name = "Status8"
        Me.Status8.Size = New System.Drawing.Size(162, 65)
        Me.Status8.TabIndex = 30
        Me.Status8.TabStop = True
        Me.Status8.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Completed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Final result Approved)"
        Me.Status8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status8.UseVisualStyleBackColor = False
        '
        'Status7
        '
        Me.Status7.AutoSize = True
        Me.Status7.BackColor = System.Drawing.Color.Transparent
        Me.Status7.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status7.Enabled = False
        Me.Status7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status7.ForeColor = System.Drawing.Color.Black
        Me.Status7.Location = New System.Drawing.Point(388, 253)
        Me.Status7.Name = "Status7"
        Me.Status7.Size = New System.Drawing.Size(232, 81)
        Me.Status7.TabIndex = 29
        Me.Status7.TabStop = True
        Me.Status7.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Submitted superior's assessment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to HR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending HR Approval)"
        Me.Status7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status7.UseVisualStyleBackColor = False
        '
        'Status6
        '
        Me.Status6.AutoSize = True
        Me.Status6.BackColor = System.Drawing.Color.Transparent
        Me.Status6.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status6.Enabled = False
        Me.Status6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status6.ForeColor = System.Drawing.Color.Black
        Me.Status6.Location = New System.Drawing.Point(665, 253)
        Me.Status6.Name = "Status6"
        Me.Status6.Size = New System.Drawing.Size(228, 81)
        Me.Status6.TabIndex = 28
        Me.Status6.TabStop = True
        Me.Status6.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Submitted superior's assessment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 2nd Approver " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv2 Approval)"
        Me.Status6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status6.UseVisualStyleBackColor = False
        '
        'Status5
        '
        Me.Status5.AutoSize = True
        Me.Status5.BackColor = System.Drawing.Color.Transparent
        Me.Status5.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status5.Enabled = False
        Me.Status5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status5.ForeColor = System.Drawing.Color.Black
        Me.Status5.Location = New System.Drawing.Point(938, 250)
        Me.Status5.Name = "Status5"
        Me.Status5.Size = New System.Drawing.Size(188, 81)
        Me.Status5.TabIndex = 27
        Me.Status5.TabStop = True
        Me.Status5.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Submitted self-assessment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 1st Approver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv1 Approval)"
        Me.Status5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status5.UseVisualStyleBackColor = False
        '
        'Status4
        '
        Me.Status4.AutoSize = True
        Me.Status4.BackColor = System.Drawing.Color.Transparent
        Me.Status4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status4.Enabled = False
        Me.Status4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status4.ForeColor = System.Drawing.Color.Black
        Me.Status4.Location = New System.Drawing.Point(946, 44)
        Me.Status4.Name = "Status4"
        Me.Status4.Size = New System.Drawing.Size(169, 65)
        Me.Status4.TabIndex = 26
        Me.Status4.TabStop = True
        Me.Status4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Targets Approved " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Input self-assessment)"
        Me.Status4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status4.UseVisualStyleBackColor = False
        '
        'Status3
        '
        Me.Status3.AutoSize = True
        Me.Status3.BackColor = System.Drawing.Color.Transparent
        Me.Status3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status3.Enabled = False
        Me.Status3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status3.ForeColor = System.Drawing.Color.Black
        Me.Status3.Location = New System.Drawing.Point(681, 44)
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(165, 81)
        Me.Status3.TabIndex = 25
        Me.Status3.TabStop = True
        Me.Status3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Submitted Target" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 2nd Approver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv2 Approval)"
        Me.Status3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status3.UseVisualStyleBackColor = False
        '
        'InputTargetFrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1350, 711)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EmployeeLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DeptLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PeriodLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InputTargetFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Target"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PeriodLabel As Label
    Friend WithEvents DeptLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EmployeeLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TitleTbx1.TextChanged
        If TitleTbx1.Text <> "" Then
            ContentTbx1.Enabled = True
            DiffComboBox1.Enabled = True
            WeightTbx1.Enabled = True
        End If
    End Sub
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub InputTargetFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DateValue("May 1, 2020") <= Now And Now <= DateValue("October 31, 2020") Then
        '    PeriodLabel.Text = "1 st Half / FY20"
        'ElseIf DateValue("November 1, 2020") <= Now And Now <= DateValue("April 30, 2021") Then
        '    PeriodLabel.Text = "2 nd Half / FY20"
        'ElseIf DateValue("May 1, 2021") <= Now And Now <= DateValue("October 31, 2021") Then
        '    PeriodLabel.Text = "1 st Half / FY21"
        'ElseIf DateValue("November 1, 2021") <= Now And Now <= DateValue("April 30, 2022") Then
        '    PeriodLabel.Text = "2 nd Half / FY21"
        'End If
        PeriodLabel.Text = WelcomeStaffFrm.PeriodCombox.Text
        Dim username As String
        Dim period As String
        Dim count As Integer
        Dim status As Integer
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        Dim reader As MySqlDataReader
        username = WelcomeStaffFrm.EmployeeIdLabel.Text
        period = PeriodLabel.Text
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM targetdata where employeeid = '" & username & "' and period = '" & period & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                Statuslb.Text = reader("status").ToString
                status = Statuslb.Text
                If Int32.Parse(status) <= 1 Then
                    TitleTbx1.ReadOnly = False
                    DiffComboBox1.Enabled = True
                    WeightTbx1.ReadOnly = False
                    ContentTbx1.ReadOnly = False
                    TitleTbx2.ReadOnly = False
                    DiffComboBox2.Enabled = True
                    WeightTbx2.ReadOnly = False
                    ContentTbx2.ReadOnly = False
                    TitleTxb3.ReadOnly = False
                    DiffComboBox3.Enabled = True
                    WeightTbx3.ReadOnly = False
                    ContentTbx3.ReadOnly = False
                    DevPlanTbx.ReadOnly = False
                    SaveBtn.Visible = True
                    SubmitBtn.Visible = True
                    PictureBox8.Visible = True
                    PictureBox9.Visible = True
                    Label32.Visible = True
                    Label33.Visible = True
                End If
                TitleTbx1.Text = reader("title").ToString
                TitleTbx2.Text = reader("title2").ToString
                TitleTxb3.Text = reader("title3").ToString
                ContentTbx1.Text = reader("detail").ToString
                ContentTbx2.Text = reader("detail2").ToString
                ContentTbx3.Text = reader("detail3").ToString
                DiffTbx1.Text = reader("difficulty").ToString
                DiffTbx2.Text = reader("difficulty2").ToString
                DiffTbx3.Text = reader("difficulty3").ToString
                DevPlanTbx.Text = reader("devplan").ToString
                WeightTbx1.Text = reader("weight").ToString
                WeightTbx2.Text = reader("weight2").ToString
                WeightTbx3.Text = reader("weight3").ToString
                DevPlanTbx.Text = reader("devplan").ToString

            Else
                TitleTbx1.ReadOnly = False
                DiffComboBox1.Enabled = True
                WeightTbx1.ReadOnly = False
                ContentTbx1.ReadOnly = False
                TitleTbx2.ReadOnly = False
                DiffComboBox2.Enabled = True
                WeightTbx2.ReadOnly = False
                ContentTbx2.ReadOnly = False
                TitleTxb3.ReadOnly = False
                DiffComboBox3.Enabled = True
                WeightTbx3.ReadOnly = False
                ContentTbx3.ReadOnly = False
                DevPlanTbx.ReadOnly = False
                SaveBtn.Visible = True
                SubmitBtn.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub DiffComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiffComboBox1.SelectedIndexChanged
        DiffTbx1.Text = DiffComboBox1.Text
    End Sub

    Private Sub DiffComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiffComboBox2.SelectedIndexChanged
        DiffTbx2.Text = DiffComboBox2.Text
    End Sub

    Private Sub DiffComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiffComboBox3.SelectedIndexChanged
        DiffTbx3.Text = DiffComboBox3.Text
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim username As String
        Dim period As String
        Dim title1 As String
        Dim detail1 As String
        Dim weight1 As String
        Dim diff1 As String
        Dim title2 As String
        Dim detail2 As String
        Dim weight2 As String
        Dim diff2 As String
        Dim title3 As String
        Dim detail3 As String
        Dim weight3 As String
        Dim diff3 As String
        Dim devplan As String
        Dim count As Integer
        Dim dept As String
        Dim fullname As String
        Dim reader As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        username = EmployeeLabel.Text
        period = PeriodLabel.Text

        title1 = TitleTbx1.Text
        title2 = TitleTbx2.Text
        title3 = TitleTxb3.Text
        detail1 = ContentTbx1.Text
        detail2 = ContentTbx2.Text
        detail3 = ContentTbx3.Text
        weight1 = WeightTbx1.Text
        weight2 = WeightTbx2.Text
        weight3 = WeightTbx3.Text
        devplan = DevPlanTbx.Text
        diff1 = DiffTbx1.Text
        diff2 = DiffTbx2.Text
        diff3 = DiffTbx3.Text
        devplan = DevPlanTbx.Text
        dept = DeptLabel.Text
        fullname = NameLabel.Text
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM targetdata WHERE employeeid ='" & username & "' AND period ='" & period & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = count + 1
            End While
            reader.Close()
            If count = 1 Then
                Dim query_update As String = "UPDATE targetdata SET devplan= '" & devplan & "', title= '" & title1 & "', detail= '" & detail1 & "', weight = '" & weight1 & "', difficulty = '" & diff1 & "', title2= '" & title2 & "', detail2= '" & detail2 & "', weight2 = '" & weight2 & "', difficulty2 = '" & diff2 & "', title3= '" & title3 & "', detail3= '" & detail3 & "', weight3 = '" & weight3 & "', difficulty3 = '" & diff3 & "', time=now() WHERE employeeid = '" & username & "' AND period ='" & period & "';"
                command = New MySqlCommand(query_update, conn)
                reader = command.ExecuteReader
                reader.Close()
            Else
                Dim query_insert As String = "INSERT INTO targetdata (id, period, EmployeeID, Name, Dept, title, detail, Difficulty, Weight, title2, detail2, difficulty2, weight2, title3, detail3, difficulty3, weight3, devplan, time) VALUES (@id, @period, @EmployeeID, @Name, @Dept, @title, @detail, @Difficulty, @Weight, @title2, @detail2, @difficulty2, @weight2, @title3, @detail3, @difficulty3, @weight3, @devplan, @time);"
                Using conn
                    command = New MySqlCommand(query_insert, conn)
                    command.Parameters.AddWithValue("@id", "")
                    command.Parameters.AddWithValue("@EmployeeID", username)
                    command.Parameters.AddWithValue("@period", period)
                    command.Parameters.AddWithValue("@title", title1)
                    command.Parameters.AddWithValue("@title2", title2)
                    command.Parameters.AddWithValue("@title3", title3)
                    command.Parameters.AddWithValue("@Name", fullname)
                    command.Parameters.AddWithValue("@Dept", dept)
                    command.Parameters.AddWithValue("@detail", detail1)
                    command.Parameters.AddWithValue("@detail2", detail2)
                    command.Parameters.AddWithValue("@detail3", detail3)
                    command.Parameters.AddWithValue("@difficulty", diff1)
                    command.Parameters.AddWithValue("@difficulty2", diff2)
                    command.Parameters.AddWithValue("@difficulty3", diff3)
                    command.Parameters.AddWithValue("@weight", weight1)
                    command.Parameters.AddWithValue("@weight2", weight2)
                    command.Parameters.AddWithValue("@weight3", weight3)
                    command.Parameters.AddWithValue("@devplan", devplan)
                    command.Parameters.AddWithValue("@time", Now())
                    command.ExecuteNonQuery()
                End Using
            End If
            MessageBox.Show("Data save successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim username As String
        Dim name As String = NameLabel.Text
        Dim count As Integer
        Dim period As String
        Dim title1 As String
        Dim detail1 As String
        Dim weight1 As Integer
        Dim diff1 As String
        Dim title2 As String
        Dim detail2 As String
        Dim weight2 As Integer
        Dim diff2 As String
        Dim title3 As String
        Dim detail3 As String
        Dim weight3 As Integer
        Dim diff3 As String
        Dim devplan As String
        Dim status As Integer = 2
        Dim answer As Integer
        Dim sum As Integer
        Dim dept As String
        dept = DeptLabel.Text
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        Dim reader As MySqlDataReader
        username = EmployeeLabel.Text
        period = PeriodLabel.Text
        answer = MessageBox.Show("Are you sure to submit the targets?", "Please confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            title1 = TitleTbx1.Text
            title2 = TitleTbx2.Text
            title3 = TitleTxb3.Text
            detail1 = ContentTbx1.Text
            detail2 = ContentTbx2.Text
            detail3 = ContentTbx3.Text
            weight1 = WeightTbx1.Text
            weight2 = WeightTbx2.Text
            weight3 = WeightTbx3.Text
            devplan = DevPlanTbx.Text
            diff1 = DiffTbx1.Text
            diff2 = DiffTbx2.Text
            diff3 = DiffTbx3.Text
            Dim OutlookMessage As outlook.MailItem
            Dim AppOutlook As New outlook.Application

            If (title1 = "" Or detail1 = "" Or weight1 < 0 Or diff1 = "") Or ((diff2 <> "" And (title2 = "" Or detail2 = "" Or weight2 <= 0)) Or (title3 <> "" And (detail3 = "" Or diff3 = "" Or weight3 <= 0))) Then
                MessageBox.Show("Please check data and try again.", "Check your target!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                sum = weight1 + weight2 + weight3
                If sum <> 100 Then
                    MessageBox.Show("The total weight value must be 100", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Try
                        conn.Open()
                        Using conn
                            Dim query As String = "SELECT * FROM targetdata WHERE employeeid ='" & username & "' AND period ='" & period & "';"
                            command = New MySqlCommand(query, conn)
                            reader = command.ExecuteReader
                            count = 0
                            While reader.Read
                                count = count + 1
                            End While
                            reader.Close()
                            If count = 1 Then
                                Dim query_update As String = "UPDATE targetdata SET devplan= '" & devplan & "', title= '" & title1 & "', detail= '" & detail1 & "', weight = '" & weight1 & "', difficulty = '" & diff1 & "', title2= '" & title2 & "', detail2= '" & detail2 & "', weight2 = '" & weight2 & "', difficulty2 = '" & diff2 & "', title3= '" & title3 & "', detail3= '" & detail3 & "', weight3 = '" & weight3 & "', difficulty3 = '" & diff3 & "', status= '" & status & "',time=now() WHERE employeeid = '" & username & "' AND period ='" & period & "';"
                                command = New MySqlCommand(query_update, conn)
                                reader = command.ExecuteReader
                                reader.Close()
                            Else
                                Dim query_insert As String = "INSERT INTO targetdata (id, period, EmployeeID, Name, Dept, title, detail, Difficulty, Weight, title2, detail2, difficulty2, weight2, title3, detail3, difficulty3, weight3, devplan, status, time) VALUES (@id, @period, @EmployeeID, @Name, @Dept, @title, @detail, @Difficulty, @Weight, @title2, @detail2, @difficulty2, @weight2, @title3, @detail3, @difficulty3, @weight3, @devplan, @status, @time);"
                                command = New MySqlCommand(query_insert, conn)
                                command.Parameters.AddWithValue("@id", "")
                                command.Parameters.AddWithValue("@EmployeeID", username)
                                command.Parameters.AddWithValue("@period", period)
                                command.Parameters.AddWithValue("@title", title1)
                                command.Parameters.AddWithValue("@title2", title2)
                                command.Parameters.AddWithValue("@title3", title3)
                                command.Parameters.AddWithValue("@Name", name)
                                command.Parameters.AddWithValue("@Dept", dept)
                                command.Parameters.AddWithValue("@detail", detail1)
                                command.Parameters.AddWithValue("@detail2", detail2)
                                command.Parameters.AddWithValue("@detail3", detail3)
                                command.Parameters.AddWithValue("@difficulty", diff1)
                                command.Parameters.AddWithValue("@difficulty2", diff2)
                                command.Parameters.AddWithValue("@difficulty3", diff3)
                                command.Parameters.AddWithValue("@weight", weight1)
                                command.Parameters.AddWithValue("@weight2", weight2)
                                command.Parameters.AddWithValue("@weight3", weight3)
                                command.Parameters.AddWithValue("@devplan", devplan)
                                command.Parameters.AddWithValue("@status", status)
                                command.Parameters.AddWithValue("@time", Now())
                                command.ExecuteNonQuery()
                                Dim query_insert2 As String = "INSERT INTO result (employeeid, period) VALUES ('" & username & "','" & period & "')"
                                command = New MySqlCommand(query_insert2, conn)
                                command.ExecuteNonQuery()
                            End If
                            Dim query_mail As String = "SELECT manager.email FROM manager INNER JOIN employee ON manager.employeeid = employee.app1 WHERE employee.employeeid ='" & username & "';"
                            command = New MySqlCommand(query_mail, conn)
                            reader = command.ExecuteReader
                            count = 0
                            While reader.Read
                                count = count + 1
                            End While
                            If count = 1 Then
                                Try
                                    Dim email As String
                                    email = reader("email").ToString
                                    Dim SmtpServer As New SmtpClient()
                                    Dim sendmail As New MailMessage()
                                    SmtpServer.Credentials = New _
                                    Net.NetworkCredential("japan\70H9536", "Papvn17")
                                    SmtpServer.Port = 25
                                    SmtpServer.Host = "157.8.1.154"
                                    sendmail = New MailMessage With {
                                        .From = New MailAddress("helpdesk.papvn@vn.panasonic.com")
                                    }
                                    sendmail.To.Add(email)
                                    sendmail.IsBodyHtml = True
                                    sendmail.Subject = "Target Submitted - Performance Management System."
                                    sendmail.Body = "Dear Manager, <br> <br> Your team member, " & name & " (Employee ID: " & username & ") submitted target on Performance Management System.<br> Please open the system, check it and have discussion with him/her.<br><br>*This message is automatically sent from system."
                                    SmtpServer.Send(sendmail)

                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                Finally
                                    OutlookMessage = Nothing
                                    AppOutlook = Nothing
                                End Try
                            Else
                                MessageBox.Show("Mail could not be sent") 'if you dont want this message, simply delete this line 
                            End If
                            MessageBox.Show("Your targets were submitted to your manager successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                        Me.Close()
                            reader.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                End If
            End If
        End If
        conn.Close()
    End Sub

    Private Sub WeightTbx1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles WeightTbx1.Leave
        Try
            If Not Regex.Match(WeightTbx1.Text, "^\d+$", RegexOptions.IgnoreCase).Success Or WeightTbx1.Text Mod 10 <> 0 Then
                MessageBox.Show("Please enter number 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                WeightTbx1.Focus()
                WeightTbx1.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WeightTbx2_Leave(sender As Object, e As EventArgs) Handles WeightTbx2.Leave
        Try
            If Not Regex.Match(WeightTbx2.Text, "^\d+$", RegexOptions.IgnoreCase).Success Or WeightTbx2.Text Mod 10 <> 0 Then
                MessageBox.Show("Please enter number 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                WeightTbx2.Focus()
                WeightTbx2.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WeightTbx3_Leave(sender As Object, e As EventArgs) Handles WeightTbx3.Leave
        Try
            If Not Regex.Match(WeightTbx3.Text, "^\d+$", RegexOptions.IgnoreCase).Success Or WeightTbx3.Text Mod 10 <> 0 Then
                MessageBox.Show("Please enter number 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                WeightTbx3.Focus()
                WeightTbx3.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Friend WithEvents Statuslb As LinkLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ContentTbx2 As TextBox
    Friend WithEvents WeightTbx3 As TextBox
    Friend WithEvents WeightTbx2 As TextBox
    Friend WithEvents WeightTbx1 As TextBox
    Friend WithEvents DiffTbx3 As TextBox
    Friend WithEvents DiffTbx2 As TextBox
    Friend WithEvents DiffTbx1 As TextBox
    Friend WithEvents DiffComboBox3 As ComboBox
    Friend WithEvents DiffComboBox2 As ComboBox
    Friend WithEvents DiffComboBox1 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DevPlanTbx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ContentTbx3 As TextBox
    Friend WithEvents TitleTxb3 As TextBox
    Friend WithEvents TitleTbx2 As TextBox
    Friend WithEvents ContentTbx1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TitleTbx1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Status1 As RadioButton
    Friend WithEvents Status2 As RadioButton
    Friend WithEvents Status8 As RadioButton
    Friend WithEvents Status7 As RadioButton
    Friend WithEvents Status6 As RadioButton
    Friend WithEvents Status5 As RadioButton
    Friend WithEvents Status4 As RadioButton
    Friend WithEvents Status3 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents App2Lbl As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents App1Lbl As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
