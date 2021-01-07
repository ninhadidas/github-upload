Imports MySql.Data.MySqlClient
Imports outlook = Microsoft.Office.Interop.Outlook
Imports System.Text.RegularExpressions
Imports excel = Microsoft.Office.Interop.Excel
Imports System.IO.File
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerViewFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerViewFrm))
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ExportBtn = New System.Windows.Forms.Button()
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
        Me.Diff3ValueLb = New System.Windows.Forms.Label()
        Me.Diff2ValueLb = New System.Windows.Forms.Label()
        Me.Diff1ValueLb = New System.Windows.Forms.Label()
        Me.SupAchLb3 = New System.Windows.Forms.Label()
        Me.SupAchLb2 = New System.Windows.Forms.Label()
        Me.SupAchLb1 = New System.Windows.Forms.Label()
        Me.RejectBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.ApproveBtn = New System.Windows.Forms.Button()
        Me.SupAchCbox3 = New System.Windows.Forms.ComboBox()
        Me.SupAchCbox2 = New System.Windows.Forms.ComboBox()
        Me.SupAchCbox1 = New System.Windows.Forms.ComboBox()
        Me.SupComTbx3 = New System.Windows.Forms.TextBox()
        Me.SupComTbx2 = New System.Windows.Forms.TextBox()
        Me.SupComTbx1 = New System.Windows.Forms.TextBox()
        Me.SupAchTbx3 = New System.Windows.Forms.TextBox()
        Me.SupAchTbx2 = New System.Windows.Forms.TextBox()
        Me.SupAchTbx1 = New System.Windows.Forms.TextBox()
        Me.EmpAchTbx3 = New System.Windows.Forms.TextBox()
        Me.EmpAchTbx2 = New System.Windows.Forms.TextBox()
        Me.EmpAchTbx1 = New System.Windows.Forms.TextBox()
        Me.SelComTbx3 = New System.Windows.Forms.TextBox()
        Me.SelComTbx2 = New System.Windows.Forms.TextBox()
        Me.SelComTbx1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.WeightTbx3 = New System.Windows.Forms.TextBox()
        Me.WeightTbx2 = New System.Windows.Forms.TextBox()
        Me.WeightTbx1 = New System.Windows.Forms.TextBox()
        Me.DiffTbx3 = New System.Windows.Forms.TextBox()
        Me.DiffTbx2 = New System.Windows.Forms.TextBox()
        Me.DiffTbx1 = New System.Windows.Forms.TextBox()
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
        Me.ContentTbx2 = New System.Windows.Forms.TextBox()
        Me.TitleTbx2 = New System.Windows.Forms.TextBox()
        Me.ContentTbx1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TitleTbx1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CompetencyBtn = New System.Windows.Forms.Button()
        Me.SupEvaLb3 = New System.Windows.Forms.Label()
        Me.SupEvaLb2 = New System.Windows.Forms.Label()
        Me.SupEvaLb1 = New System.Windows.Forms.Label()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.Next2Btn = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.OvrSupEvaTbx = New System.Windows.Forms.TextBox()
        Me.OvrSupCmTbx = New System.Windows.Forms.TextBox()
        Me.SupEvaCbx3 = New System.Windows.Forms.ComboBox()
        Me.SupEvaTbx3 = New System.Windows.Forms.TextBox()
        Me.SupEvaCbx2 = New System.Windows.Forms.ComboBox()
        Me.SupEvaTbx2 = New System.Windows.Forms.TextBox()
        Me.SupEvaCbx1 = New System.Windows.Forms.ComboBox()
        Me.SupEvaTbx1 = New System.Windows.Forms.TextBox()
        Me.RenTbx2 = New System.Windows.Forms.TextBox()
        Me.JinTbx2 = New System.Windows.Forms.TextBox()
        Me.JirTbx2 = New System.Windows.Forms.TextBox()
        Me.RenTbx1 = New System.Windows.Forms.TextBox()
        Me.JinTbx1 = New System.Windows.Forms.TextBox()
        Me.JirTbx1 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CompetencyScore = New System.Windows.Forms.Label()
        Me.MBOScoreLb = New System.Windows.Forms.Label()
        Me.OvrDiffScore = New System.Windows.Forms.Label()
        Me.ApproveRstBtn = New System.Windows.Forms.Button()
        Me.RejectRstBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.NotableTbx = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TotalEvaLbl = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ComScrLbl = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.MngObjLbl = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.OvrEvaLbl = New System.Windows.Forms.Label()
        Me.OvrAchLbl = New System.Windows.Forms.Label()
        Me.OvrDiffLbl = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Prev2Btn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.App2Lbl = New System.Windows.Forms.Label()
        Me.App1Lbl = New System.Windows.Forms.Label()
        Me.App2IDLbl = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.App1IDLbl = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
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
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.Black
        Me.CloseBtn.Location = New System.Drawing.Point(1274, 17)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(59, 40)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'PrintBtn
        '
        Me.PrintBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.Color.Black
        Me.PrintBtn.Location = New System.Drawing.Point(1200, 17)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(59, 40)
        Me.PrintBtn.TabIndex = 7
        Me.PrintBtn.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.PrintBtn, "Print Btn")
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'ExportBtn
        '
        Me.ExportBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ExportBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExportBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportBtn.ForeColor = System.Drawing.Color.Black
        Me.ExportBtn.Location = New System.Drawing.Point(1126, 17)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(59, 40)
        Me.ExportBtn.TabIndex = 8
        Me.ExportBtn.Text = "Export"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 14)
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
        Me.PeriodLabel.Location = New System.Drawing.Point(74, 14)
        Me.PeriodLabel.Name = "PeriodLabel"
        Me.PeriodLabel.Size = New System.Drawing.Size(55, 16)
        Me.PeriodLabel.TabIndex = 11
        Me.PeriodLabel.Text = "PERIOD"
        '
        'DeptLabel
        '
        Me.DeptLabel.AutoSize = True
        Me.DeptLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DeptLabel.Location = New System.Drawing.Point(286, 14)
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
        Me.Label5.Location = New System.Drawing.Point(243, 14)
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
        Me.NameLabel.Location = New System.Drawing.Point(545, 14)
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
        Me.Label7.Location = New System.Drawing.Point(476, 14)
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
        Me.EmployeeLabel.Location = New System.Drawing.Point(839, 14)
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
        Me.Label4.Location = New System.Drawing.Point(748, 14)
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
        Me.Label8.Location = New System.Drawing.Point(974, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Status ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Statuslb)
        Me.GroupBox1.Controls.Add(Me.PeriodLabel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DeptLabel)
        Me.GroupBox1.Controls.Add(Me.EmployeeLabel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1098, 45)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Statuslb
        '
        Me.Statuslb.AutoSize = True
        Me.Statuslb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslb.Location = New System.Drawing.Point(1054, 14)
        Me.Statuslb.Name = "Statuslb"
        Me.Statuslb.Size = New System.Drawing.Size(30, 16)
        Me.Statuslb.TabIndex = 23
        Me.Statuslb.TabStop = True
        Me.Statuslb.Text = "Sta"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(4, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1346, 612)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Diff3ValueLb)
        Me.TabPage1.Controls.Add(Me.Diff2ValueLb)
        Me.TabPage1.Controls.Add(Me.Diff1ValueLb)
        Me.TabPage1.Controls.Add(Me.SupAchLb3)
        Me.TabPage1.Controls.Add(Me.SupAchLb2)
        Me.TabPage1.Controls.Add(Me.SupAchLb1)
        Me.TabPage1.Controls.Add(Me.RejectBtn)
        Me.TabPage1.Controls.Add(Me.NextBtn)
        Me.TabPage1.Controls.Add(Me.ApproveBtn)
        Me.TabPage1.Controls.Add(Me.SupAchCbox3)
        Me.TabPage1.Controls.Add(Me.SupAchCbox2)
        Me.TabPage1.Controls.Add(Me.SupAchCbox1)
        Me.TabPage1.Controls.Add(Me.SupComTbx3)
        Me.TabPage1.Controls.Add(Me.SupComTbx2)
        Me.TabPage1.Controls.Add(Me.SupComTbx1)
        Me.TabPage1.Controls.Add(Me.SupAchTbx3)
        Me.TabPage1.Controls.Add(Me.SupAchTbx2)
        Me.TabPage1.Controls.Add(Me.SupAchTbx1)
        Me.TabPage1.Controls.Add(Me.EmpAchTbx3)
        Me.TabPage1.Controls.Add(Me.EmpAchTbx2)
        Me.TabPage1.Controls.Add(Me.EmpAchTbx1)
        Me.TabPage1.Controls.Add(Me.SelComTbx3)
        Me.TabPage1.Controls.Add(Me.SelComTbx2)
        Me.TabPage1.Controls.Add(Me.SelComTbx1)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.WeightTbx3)
        Me.TabPage1.Controls.Add(Me.WeightTbx2)
        Me.TabPage1.Controls.Add(Me.WeightTbx1)
        Me.TabPage1.Controls.Add(Me.DiffTbx3)
        Me.TabPage1.Controls.Add(Me.DiffTbx2)
        Me.TabPage1.Controls.Add(Me.DiffTbx1)
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
        Me.TabPage1.Controls.Add(Me.ContentTbx2)
        Me.TabPage1.Controls.Add(Me.TitleTbx2)
        Me.TabPage1.Controls.Add(Me.ContentTbx1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TitleTbx1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1338, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Management By Objective"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Diff3ValueLb
        '
        Me.Diff3ValueLb.AutoSize = True
        Me.Diff3ValueLb.ForeColor = System.Drawing.Color.Black
        Me.Diff3ValueLb.Location = New System.Drawing.Point(569, 460)
        Me.Diff3ValueLb.Name = "Diff3ValueLb"
        Me.Diff3ValueLb.Size = New System.Drawing.Size(68, 13)
        Me.Diff3ValueLb.TabIndex = 128
        Me.Diff3ValueLb.Text = "Diff3ValueLb"
        Me.Diff3ValueLb.Visible = False
        '
        'Diff2ValueLb
        '
        Me.Diff2ValueLb.AutoSize = True
        Me.Diff2ValueLb.ForeColor = System.Drawing.Color.Black
        Me.Diff2ValueLb.Location = New System.Drawing.Point(578, 313)
        Me.Diff2ValueLb.Name = "Diff2ValueLb"
        Me.Diff2ValueLb.Size = New System.Drawing.Size(68, 13)
        Me.Diff2ValueLb.TabIndex = 127
        Me.Diff2ValueLb.Text = "Diff2ValueLb"
        Me.Diff2ValueLb.Visible = False
        '
        'Diff1ValueLb
        '
        Me.Diff1ValueLb.AutoSize = True
        Me.Diff1ValueLb.ForeColor = System.Drawing.Color.Black
        Me.Diff1ValueLb.Location = New System.Drawing.Point(569, 180)
        Me.Diff1ValueLb.Name = "Diff1ValueLb"
        Me.Diff1ValueLb.Size = New System.Drawing.Size(68, 13)
        Me.Diff1ValueLb.TabIndex = 126
        Me.Diff1ValueLb.Text = "Diff1ValueLb"
        Me.Diff1ValueLb.Visible = False
        '
        'SupAchLb3
        '
        Me.SupAchLb3.AutoSize = True
        Me.SupAchLb3.ForeColor = System.Drawing.Color.Black
        Me.SupAchLb3.Location = New System.Drawing.Point(1256, 450)
        Me.SupAchLb3.Name = "SupAchLb3"
        Me.SupAchLb3.Size = New System.Drawing.Size(63, 13)
        Me.SupAchLb3.TabIndex = 125
        Me.SupAchLb3.Text = "SupAchLb3"
        Me.SupAchLb3.Visible = False
        '
        'SupAchLb2
        '
        Me.SupAchLb2.AutoSize = True
        Me.SupAchLb2.ForeColor = System.Drawing.Color.Black
        Me.SupAchLb2.Location = New System.Drawing.Point(1263, 313)
        Me.SupAchLb2.Name = "SupAchLb2"
        Me.SupAchLb2.Size = New System.Drawing.Size(63, 13)
        Me.SupAchLb2.TabIndex = 124
        Me.SupAchLb2.Text = "SupAchLb2"
        Me.SupAchLb2.Visible = False
        '
        'SupAchLb1
        '
        Me.SupAchLb1.AutoSize = True
        Me.SupAchLb1.ForeColor = System.Drawing.Color.Black
        Me.SupAchLb1.Location = New System.Drawing.Point(1257, 157)
        Me.SupAchLb1.Name = "SupAchLb1"
        Me.SupAchLb1.Size = New System.Drawing.Size(63, 13)
        Me.SupAchLb1.TabIndex = 123
        Me.SupAchLb1.Text = "SupAchLb1"
        Me.SupAchLb1.Visible = False
        '
        'RejectBtn
        '
        Me.RejectBtn.BackColor = System.Drawing.Color.Red
        Me.RejectBtn.FlatAppearance.BorderSize = 0
        Me.RejectBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RejectBtn.ForeColor = System.Drawing.Color.White
        Me.RejectBtn.Location = New System.Drawing.Point(1083, 3)
        Me.RejectBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.RejectBtn.Name = "RejectBtn"
        Me.RejectBtn.Size = New System.Drawing.Size(140, 25)
        Me.RejectBtn.TabIndex = 122
        Me.RejectBtn.Text = "Reject Targets"
        Me.RejectBtn.UseVisualStyleBackColor = False
        Me.RejectBtn.Visible = False
        '
        'NextBtn
        '
        Me.NextBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.NextBtn.BackColor = System.Drawing.SystemColors.Control
        Me.NextBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.NextBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.ForeColor = System.Drawing.Color.Black
        Me.NextBtn.Location = New System.Drawing.Point(1242, 4)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(87, 24)
        Me.NextBtn.TabIndex = 121
        Me.NextBtn.Text = "Next >"
        Me.ToolTip1.SetToolTip(Me.NextBtn, "Save button")
        Me.NextBtn.UseVisualStyleBackColor = False
        '
        'ApproveBtn
        '
        Me.ApproveBtn.BackColor = System.Drawing.Color.ForestGreen
        Me.ApproveBtn.FlatAppearance.BorderSize = 0
        Me.ApproveBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApproveBtn.ForeColor = System.Drawing.Color.White
        Me.ApproveBtn.Location = New System.Drawing.Point(930, 3)
        Me.ApproveBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ApproveBtn.Name = "ApproveBtn"
        Me.ApproveBtn.Size = New System.Drawing.Size(132, 25)
        Me.ApproveBtn.TabIndex = 23
        Me.ApproveBtn.Text = "Approve Targets"
        Me.ApproveBtn.UseVisualStyleBackColor = False
        Me.ApproveBtn.Visible = False
        '
        'SupAchCbox3
        '
        Me.SupAchCbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupAchCbox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupAchCbox3.Enabled = False
        Me.SupAchCbox3.FormattingEnabled = True
        Me.SupAchCbox3.Items.AddRange(New Object() {"A3: Highly achieved", "A2: Achieved", "A1: Not achieved"})
        Me.SupAchCbox3.Location = New System.Drawing.Point(1230, 378)
        Me.SupAchCbox3.Name = "SupAchCbox3"
        Me.SupAchCbox3.Size = New System.Drawing.Size(99, 21)
        Me.SupAchCbox3.TabIndex = 120
        '
        'SupAchCbox2
        '
        Me.SupAchCbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupAchCbox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupAchCbox2.Enabled = False
        Me.SupAchCbox2.FormattingEnabled = True
        Me.SupAchCbox2.Items.AddRange(New Object() {"A3: Highly achieved", "A2: Achieved", "A1: Not achieved"})
        Me.SupAchCbox2.Location = New System.Drawing.Point(1230, 236)
        Me.SupAchCbox2.Name = "SupAchCbox2"
        Me.SupAchCbox2.Size = New System.Drawing.Size(99, 21)
        Me.SupAchCbox2.TabIndex = 119
        '
        'SupAchCbox1
        '
        Me.SupAchCbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupAchCbox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupAchCbox1.Enabled = False
        Me.SupAchCbox1.FormattingEnabled = True
        Me.SupAchCbox1.Items.AddRange(New Object() {"A3: Highly achieved", "A2: Achieved", "A1: Not achieved"})
        Me.SupAchCbox1.Location = New System.Drawing.Point(1230, 94)
        Me.SupAchCbox1.Name = "SupAchCbox1"
        Me.SupAchCbox1.Size = New System.Drawing.Size(99, 21)
        Me.SupAchCbox1.TabIndex = 118
        '
        'SupComTbx3
        '
        Me.SupComTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupComTbx3.Location = New System.Drawing.Point(1049, 378)
        Me.SupComTbx3.Multiline = True
        Me.SupComTbx3.Name = "SupComTbx3"
        Me.SupComTbx3.ReadOnly = True
        Me.SupComTbx3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SupComTbx3.Size = New System.Drawing.Size(181, 136)
        Me.SupComTbx3.TabIndex = 117
        '
        'SupComTbx2
        '
        Me.SupComTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupComTbx2.Location = New System.Drawing.Point(1049, 236)
        Me.SupComTbx2.Multiline = True
        Me.SupComTbx2.Name = "SupComTbx2"
        Me.SupComTbx2.ReadOnly = True
        Me.SupComTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SupComTbx2.Size = New System.Drawing.Size(181, 142)
        Me.SupComTbx2.TabIndex = 116
        '
        'SupComTbx1
        '
        Me.SupComTbx1.AcceptsReturn = True
        Me.SupComTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupComTbx1.Location = New System.Drawing.Point(1049, 94)
        Me.SupComTbx1.Multiline = True
        Me.SupComTbx1.Name = "SupComTbx1"
        Me.SupComTbx1.ReadOnly = True
        Me.SupComTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SupComTbx1.Size = New System.Drawing.Size(181, 142)
        Me.SupComTbx1.TabIndex = 115
        '
        'SupAchTbx3
        '
        Me.SupAchTbx3.BackColor = System.Drawing.Color.White
        Me.SupAchTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupAchTbx3.Location = New System.Drawing.Point(1230, 400)
        Me.SupAchTbx3.MaxLength = 0
        Me.SupAchTbx3.Multiline = True
        Me.SupAchTbx3.Name = "SupAchTbx3"
        Me.SupAchTbx3.ReadOnly = True
        Me.SupAchTbx3.Size = New System.Drawing.Size(99, 114)
        Me.SupAchTbx3.TabIndex = 114
        Me.SupAchTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupAchTbx2
        '
        Me.SupAchTbx2.BackColor = System.Drawing.Color.White
        Me.SupAchTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupAchTbx2.Location = New System.Drawing.Point(1230, 258)
        Me.SupAchTbx2.MaxLength = 0
        Me.SupAchTbx2.Multiline = True
        Me.SupAchTbx2.Name = "SupAchTbx2"
        Me.SupAchTbx2.ReadOnly = True
        Me.SupAchTbx2.Size = New System.Drawing.Size(99, 119)
        Me.SupAchTbx2.TabIndex = 113
        Me.SupAchTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupAchTbx1
        '
        Me.SupAchTbx1.BackColor = System.Drawing.Color.White
        Me.SupAchTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupAchTbx1.Location = New System.Drawing.Point(1230, 116)
        Me.SupAchTbx1.MaxLength = 0
        Me.SupAchTbx1.Multiline = True
        Me.SupAchTbx1.Name = "SupAchTbx1"
        Me.SupAchTbx1.ReadOnly = True
        Me.SupAchTbx1.Size = New System.Drawing.Size(99, 120)
        Me.SupAchTbx1.TabIndex = 112
        Me.SupAchTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpAchTbx3
        '
        Me.EmpAchTbx3.BackColor = System.Drawing.Color.White
        Me.EmpAchTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAchTbx3.Location = New System.Drawing.Point(945, 378)
        Me.EmpAchTbx3.MaxLength = 0
        Me.EmpAchTbx3.Multiline = True
        Me.EmpAchTbx3.Name = "EmpAchTbx3"
        Me.EmpAchTbx3.ReadOnly = True
        Me.EmpAchTbx3.Size = New System.Drawing.Size(105, 136)
        Me.EmpAchTbx3.TabIndex = 111
        Me.EmpAchTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpAchTbx2
        '
        Me.EmpAchTbx2.BackColor = System.Drawing.Color.White
        Me.EmpAchTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAchTbx2.Location = New System.Drawing.Point(945, 236)
        Me.EmpAchTbx2.MaxLength = 0
        Me.EmpAchTbx2.Multiline = True
        Me.EmpAchTbx2.Name = "EmpAchTbx2"
        Me.EmpAchTbx2.ReadOnly = True
        Me.EmpAchTbx2.Size = New System.Drawing.Size(105, 142)
        Me.EmpAchTbx2.TabIndex = 110
        Me.EmpAchTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpAchTbx1
        '
        Me.EmpAchTbx1.BackColor = System.Drawing.Color.White
        Me.EmpAchTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAchTbx1.Location = New System.Drawing.Point(945, 94)
        Me.EmpAchTbx1.MaxLength = 0
        Me.EmpAchTbx1.Multiline = True
        Me.EmpAchTbx1.Name = "EmpAchTbx1"
        Me.EmpAchTbx1.ReadOnly = True
        Me.EmpAchTbx1.Size = New System.Drawing.Size(105, 142)
        Me.EmpAchTbx1.TabIndex = 109
        Me.EmpAchTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SelComTbx3
        '
        Me.SelComTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelComTbx3.Location = New System.Drawing.Point(717, 378)
        Me.SelComTbx3.Multiline = True
        Me.SelComTbx3.Name = "SelComTbx3"
        Me.SelComTbx3.ReadOnly = True
        Me.SelComTbx3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SelComTbx3.Size = New System.Drawing.Size(229, 137)
        Me.SelComTbx3.TabIndex = 108
        '
        'SelComTbx2
        '
        Me.SelComTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelComTbx2.Location = New System.Drawing.Point(717, 236)
        Me.SelComTbx2.Multiline = True
        Me.SelComTbx2.Name = "SelComTbx2"
        Me.SelComTbx2.ReadOnly = True
        Me.SelComTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SelComTbx2.Size = New System.Drawing.Size(229, 142)
        Me.SelComTbx2.TabIndex = 107
        '
        'SelComTbx1
        '
        Me.SelComTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelComTbx1.Location = New System.Drawing.Point(717, 94)
        Me.SelComTbx1.Multiline = True
        Me.SelComTbx1.Name = "SelComTbx1"
        Me.SelComTbx1.ReadOnly = True
        Me.SelComTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SelComTbx1.Size = New System.Drawing.Size(229, 142)
        Me.SelComTbx1.TabIndex = 106
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label24.Location = New System.Drawing.Point(1230, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 19)
        Me.Label24.TabIndex = 105
        Me.Label24.Text = "Achievement"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label25.Location = New System.Drawing.Point(1048, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(182, 19)
        Me.Label25.TabIndex = 104
        Me.Label25.Text = "Comment"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label23.Location = New System.Drawing.Point(945, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 19)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "Achievement"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label22.Location = New System.Drawing.Point(717, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(229, 19)
        Me.Label22.TabIndex = 102
        Me.Label22.Text = "Comment"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label21.Location = New System.Drawing.Point(1048, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(281, 20)
        Me.Label21.TabIndex = 101
        Me.Label21.Text = "Superior - Assessment"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label20.Location = New System.Drawing.Point(717, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(333, 20)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = "Employee - Self Assessment"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WeightTbx3
        '
        Me.WeightTbx3.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx3.Location = New System.Drawing.Point(657, 401)
        Me.WeightTbx3.MaxLength = 2
        Me.WeightTbx3.Multiline = True
        Me.WeightTbx3.Name = "WeightTbx3"
        Me.WeightTbx3.ReadOnly = True
        Me.WeightTbx3.Size = New System.Drawing.Size(60, 114)
        Me.WeightTbx3.TabIndex = 99
        Me.WeightTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTbx2
        '
        Me.WeightTbx2.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx2.Location = New System.Drawing.Point(657, 259)
        Me.WeightTbx2.MaxLength = 2
        Me.WeightTbx2.Multiline = True
        Me.WeightTbx2.Name = "WeightTbx2"
        Me.WeightTbx2.ReadOnly = True
        Me.WeightTbx2.Size = New System.Drawing.Size(60, 119)
        Me.WeightTbx2.TabIndex = 98
        Me.WeightTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTbx1
        '
        Me.WeightTbx1.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx1.Location = New System.Drawing.Point(657, 117)
        Me.WeightTbx1.MaxLength = 3
        Me.WeightTbx1.Multiline = True
        Me.WeightTbx1.Name = "WeightTbx1"
        Me.WeightTbx1.ReadOnly = True
        Me.WeightTbx1.Size = New System.Drawing.Size(60, 119)
        Me.WeightTbx1.TabIndex = 97
        Me.WeightTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx3
        '
        Me.DiffTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx3.Location = New System.Drawing.Point(538, 401)
        Me.DiffTbx3.Multiline = True
        Me.DiffTbx3.Name = "DiffTbx3"
        Me.DiffTbx3.ReadOnly = True
        Me.DiffTbx3.Size = New System.Drawing.Size(119, 114)
        Me.DiffTbx3.TabIndex = 96
        Me.DiffTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx2
        '
        Me.DiffTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx2.Location = New System.Drawing.Point(538, 259)
        Me.DiffTbx2.Multiline = True
        Me.DiffTbx2.Name = "DiffTbx2"
        Me.DiffTbx2.ReadOnly = True
        Me.DiffTbx2.Size = New System.Drawing.Size(119, 119)
        Me.DiffTbx2.TabIndex = 95
        Me.DiffTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx1
        '
        Me.DiffTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx1.Location = New System.Drawing.Point(538, 117)
        Me.DiffTbx1.Multiline = True
        Me.DiffTbx1.Name = "DiffTbx1"
        Me.DiffTbx1.ReadOnly = True
        Me.DiffTbx1.Size = New System.Drawing.Size(119, 119)
        Me.DiffTbx1.TabIndex = 94
        Me.DiffTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label19.Location = New System.Drawing.Point(656, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 19)
        Me.Label19.TabIndex = 90
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
        Me.Label18.Location = New System.Drawing.Point(538, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 19)
        Me.Label18.TabIndex = 89
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
        Me.Label17.Location = New System.Drawing.Point(9, 378)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 137)
        Me.Label17.TabIndex = 88
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
        Me.Label16.Location = New System.Drawing.Point(9, 236)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 142)
        Me.Label16.TabIndex = 87
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
        Me.Label15.Location = New System.Drawing.Point(9, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 142)
        Me.Label15.TabIndex = 86
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
        Me.Label14.Location = New System.Drawing.Point(9, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 39)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.Location = New System.Drawing.Point(51, 379)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 23)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Title:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label12.Location = New System.Drawing.Point(51, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Title:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label11.Location = New System.Drawing.Point(51, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Title:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DevPlanTbx
        '
        Me.DevPlanTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevPlanTbx.Location = New System.Drawing.Point(9, 538)
        Me.DevPlanTbx.Multiline = True
        Me.DevPlanTbx.Name = "DevPlanTbx"
        Me.DevPlanTbx.ReadOnly = True
        Me.DevPlanTbx.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DevPlanTbx.Size = New System.Drawing.Size(1320, 42)
        Me.DevPlanTbx.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(9, 517)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1320, 20)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Development Plan (career plan, self-development, study, certification, training, " &
    "etc.)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContentTbx3
        '
        Me.ContentTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx3.Location = New System.Drawing.Point(51, 401)
        Me.ContentTbx3.Multiline = True
        Me.ContentTbx3.Name = "ContentTbx3"
        Me.ContentTbx3.ReadOnly = True
        Me.ContentTbx3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx3.Size = New System.Drawing.Size(487, 114)
        Me.ContentTbx3.TabIndex = 79
        '
        'TitleTxb3
        '
        Me.TitleTxb3.BackColor = System.Drawing.Color.Silver
        Me.TitleTxb3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxb3.Location = New System.Drawing.Point(112, 378)
        Me.TitleTxb3.Name = "TitleTxb3"
        Me.TitleTxb3.ReadOnly = True
        Me.TitleTxb3.Size = New System.Drawing.Size(605, 23)
        Me.TitleTxb3.TabIndex = 78
        '
        'ContentTbx2
        '
        Me.ContentTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx2.Location = New System.Drawing.Point(51, 259)
        Me.ContentTbx2.Multiline = True
        Me.ContentTbx2.Name = "ContentTbx2"
        Me.ContentTbx2.ReadOnly = True
        Me.ContentTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx2.Size = New System.Drawing.Size(487, 119)
        Me.ContentTbx2.TabIndex = 77
        '
        'TitleTbx2
        '
        Me.TitleTbx2.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx2.Location = New System.Drawing.Point(112, 236)
        Me.TitleTbx2.Name = "TitleTbx2"
        Me.TitleTbx2.ReadOnly = True
        Me.TitleTbx2.Size = New System.Drawing.Size(605, 23)
        Me.TitleTbx2.TabIndex = 76
        '
        'ContentTbx1
        '
        Me.ContentTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx1.Location = New System.Drawing.Point(51, 116)
        Me.ContentTbx1.Multiline = True
        Me.ContentTbx1.Name = "ContentTbx1"
        Me.ContentTbx1.ReadOnly = True
        Me.ContentTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx1.Size = New System.Drawing.Size(487, 119)
        Me.ContentTbx1.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.Location = New System.Drawing.Point(48, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(490, 20)
        Me.Label9.TabIndex = 74
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
        Me.Label6.Location = New System.Drawing.Point(48, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(669, 20)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Targets"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(9, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1320, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Management by Ojective"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleTbx1
        '
        Me.TitleTbx1.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx1.Location = New System.Drawing.Point(112, 94)
        Me.TitleTbx1.Name = "TitleTbx1"
        Me.TitleTbx1.ReadOnly = True
        Me.TitleTbx1.Size = New System.Drawing.Size(605, 23)
        Me.TitleTbx1.TabIndex = 71
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CompetencyBtn)
        Me.TabPage2.Controls.Add(Me.SupEvaLb3)
        Me.TabPage2.Controls.Add(Me.SupEvaLb2)
        Me.TabPage2.Controls.Add(Me.SupEvaLb1)
        Me.TabPage2.Controls.Add(Me.PrevBtn)
        Me.TabPage2.Controls.Add(Me.Next2Btn)
        Me.TabPage2.Controls.Add(Me.TextBox14)
        Me.TabPage2.Controls.Add(Me.TextBox13)
        Me.TabPage2.Controls.Add(Me.TextBox12)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.OvrSupEvaTbx)
        Me.TabPage2.Controls.Add(Me.OvrSupCmTbx)
        Me.TabPage2.Controls.Add(Me.SupEvaCbx3)
        Me.TabPage2.Controls.Add(Me.SupEvaTbx3)
        Me.TabPage2.Controls.Add(Me.SupEvaCbx2)
        Me.TabPage2.Controls.Add(Me.SupEvaTbx2)
        Me.TabPage2.Controls.Add(Me.SupEvaCbx1)
        Me.TabPage2.Controls.Add(Me.SupEvaTbx1)
        Me.TabPage2.Controls.Add(Me.RenTbx2)
        Me.TabPage2.Controls.Add(Me.JinTbx2)
        Me.TabPage2.Controls.Add(Me.JirTbx2)
        Me.TabPage2.Controls.Add(Me.RenTbx1)
        Me.TabPage2.Controls.Add(Me.JinTbx1)
        Me.TabPage2.Controls.Add(Me.JirTbx1)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1338, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Competency"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CompetencyBtn
        '
        Me.CompetencyBtn.BackColor = System.Drawing.Color.Transparent
        Me.CompetencyBtn.FlatAppearance.BorderSize = 0
        Me.CompetencyBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompetencyBtn.ForeColor = System.Drawing.Color.Black
        Me.CompetencyBtn.Location = New System.Drawing.Point(551, 14)
        Me.CompetencyBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CompetencyBtn.Name = "CompetencyBtn"
        Me.CompetencyBtn.Size = New System.Drawing.Size(175, 24)
        Me.CompetencyBtn.TabIndex = 165
        Me.CompetencyBtn.Text = "Competency Description"
        Me.CompetencyBtn.UseVisualStyleBackColor = False
        '
        'SupEvaLb3
        '
        Me.SupEvaLb3.AutoSize = True
        Me.SupEvaLb3.ForeColor = System.Drawing.Color.Black
        Me.SupEvaLb3.Location = New System.Drawing.Point(1189, 388)
        Me.SupEvaLb3.Name = "SupEvaLb3"
        Me.SupEvaLb3.Size = New System.Drawing.Size(13, 13)
        Me.SupEvaLb3.TabIndex = 164
        Me.SupEvaLb3.Text = "0"
        Me.SupEvaLb3.Visible = False
        '
        'SupEvaLb2
        '
        Me.SupEvaLb2.AutoSize = True
        Me.SupEvaLb2.ForeColor = System.Drawing.Color.Black
        Me.SupEvaLb2.Location = New System.Drawing.Point(1180, 270)
        Me.SupEvaLb2.Name = "SupEvaLb2"
        Me.SupEvaLb2.Size = New System.Drawing.Size(13, 13)
        Me.SupEvaLb2.TabIndex = 163
        Me.SupEvaLb2.Text = "0"
        Me.SupEvaLb2.Visible = False
        '
        'SupEvaLb1
        '
        Me.SupEvaLb1.AutoSize = True
        Me.SupEvaLb1.ForeColor = System.Drawing.Color.Black
        Me.SupEvaLb1.Location = New System.Drawing.Point(1189, 169)
        Me.SupEvaLb1.Name = "SupEvaLb1"
        Me.SupEvaLb1.Size = New System.Drawing.Size(13, 13)
        Me.SupEvaLb1.TabIndex = 162
        Me.SupEvaLb1.Text = "0"
        Me.SupEvaLb1.Visible = False
        '
        'PrevBtn
        '
        Me.PrevBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PrevBtn.BackColor = System.Drawing.SystemColors.Control
        Me.PrevBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.PrevBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevBtn.ForeColor = System.Drawing.Color.Black
        Me.PrevBtn.Location = New System.Drawing.Point(10, 14)
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(87, 24)
        Me.PrevBtn.TabIndex = 132
        Me.PrevBtn.Text = "< Previous"
        Me.ToolTip1.SetToolTip(Me.PrevBtn, "Save button")
        Me.PrevBtn.UseVisualStyleBackColor = False
        '
        'Next2Btn
        '
        Me.Next2Btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Next2Btn.BackColor = System.Drawing.SystemColors.Control
        Me.Next2Btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.Next2Btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next2Btn.ForeColor = System.Drawing.Color.Black
        Me.Next2Btn.Location = New System.Drawing.Point(1243, 14)
        Me.Next2Btn.Name = "Next2Btn"
        Me.Next2Btn.Size = New System.Drawing.Size(87, 24)
        Me.Next2Btn.TabIndex = 131
        Me.Next2Btn.Text = "Next >"
        Me.ToolTip1.SetToolTip(Me.Next2Btn, "Save button")
        Me.Next2Btn.UseVisualStyleBackColor = False
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(10, 320)
        Me.TextBox14.MaxLength = 3
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(190, 107)
        Me.TextBox14.TabIndex = 130
        Me.TextBox14.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COLLABORATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Renkei - 連携)"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(10, 214)
        Me.TextBox13.MaxLength = 3
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(190, 107)
        Me.TextBox13.TabIndex = 129
        Me.TextBox13.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SPEED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Jinsoku - 迅速)"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(10, 108)
        Me.TextBox12.MaxLength = 3
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(190, 107)
        Me.TextBox12.TabIndex = 128
        Me.TextBox12.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELF-RELIANCE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Jiritsu - 自立)"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label36.Location = New System.Drawing.Point(1095, 439)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(235, 20)
        Me.Label36.TabIndex = 127
        Me.Label36.Text = "Overall Superior's Evaluation"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OvrSupEvaTbx
        '
        Me.OvrSupEvaTbx.BackColor = System.Drawing.Color.White
        Me.OvrSupEvaTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvrSupEvaTbx.Location = New System.Drawing.Point(1095, 458)
        Me.OvrSupEvaTbx.MaxLength = 0
        Me.OvrSupEvaTbx.Multiline = True
        Me.OvrSupEvaTbx.Name = "OvrSupEvaTbx"
        Me.OvrSupEvaTbx.ReadOnly = True
        Me.OvrSupEvaTbx.Size = New System.Drawing.Size(235, 121)
        Me.OvrSupEvaTbx.TabIndex = 126
        Me.OvrSupEvaTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OvrSupCmTbx
        '
        Me.OvrSupCmTbx.BackColor = System.Drawing.Color.White
        Me.OvrSupCmTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvrSupCmTbx.Location = New System.Drawing.Point(9, 458)
        Me.OvrSupCmTbx.MaxLength = 0
        Me.OvrSupCmTbx.Multiline = True
        Me.OvrSupCmTbx.Name = "OvrSupCmTbx"
        Me.OvrSupCmTbx.ReadOnly = True
        Me.OvrSupCmTbx.Size = New System.Drawing.Size(1087, 121)
        Me.OvrSupCmTbx.TabIndex = 125
        '
        'SupEvaCbx3
        '
        Me.SupEvaCbx3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupEvaCbx3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupEvaCbx3.Enabled = False
        Me.SupEvaCbx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupEvaCbx3.FormattingEnabled = True
        Me.SupEvaCbx3.Items.AddRange(New Object() {"C5: Outstanding", "C4: Excellent", "C3: Standard", "C2: Need Improvement", "C1: Bad/Poor"})
        Me.SupEvaCbx3.Location = New System.Drawing.Point(1095, 321)
        Me.SupEvaCbx3.Name = "SupEvaCbx3"
        Me.SupEvaCbx3.Size = New System.Drawing.Size(235, 24)
        Me.SupEvaCbx3.TabIndex = 124
        '
        'SupEvaTbx3
        '
        Me.SupEvaTbx3.BackColor = System.Drawing.Color.White
        Me.SupEvaTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupEvaTbx3.Location = New System.Drawing.Point(1095, 342)
        Me.SupEvaTbx3.MaxLength = 0
        Me.SupEvaTbx3.Multiline = True
        Me.SupEvaTbx3.Name = "SupEvaTbx3"
        Me.SupEvaTbx3.ReadOnly = True
        Me.SupEvaTbx3.Size = New System.Drawing.Size(235, 85)
        Me.SupEvaTbx3.TabIndex = 123
        Me.SupEvaTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupEvaCbx2
        '
        Me.SupEvaCbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupEvaCbx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupEvaCbx2.Enabled = False
        Me.SupEvaCbx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupEvaCbx2.FormattingEnabled = True
        Me.SupEvaCbx2.Items.AddRange(New Object() {"C5: Outstanding", "C4: Excellent", "C3: Standard", "C2: Need Improvement", "C1: Bad/Poor"})
        Me.SupEvaCbx2.Location = New System.Drawing.Point(1095, 215)
        Me.SupEvaCbx2.Name = "SupEvaCbx2"
        Me.SupEvaCbx2.Size = New System.Drawing.Size(235, 24)
        Me.SupEvaCbx2.TabIndex = 122
        '
        'SupEvaTbx2
        '
        Me.SupEvaTbx2.BackColor = System.Drawing.Color.White
        Me.SupEvaTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupEvaTbx2.Location = New System.Drawing.Point(1095, 236)
        Me.SupEvaTbx2.MaxLength = 0
        Me.SupEvaTbx2.Multiline = True
        Me.SupEvaTbx2.Name = "SupEvaTbx2"
        Me.SupEvaTbx2.ReadOnly = True
        Me.SupEvaTbx2.Size = New System.Drawing.Size(235, 85)
        Me.SupEvaTbx2.TabIndex = 121
        Me.SupEvaTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupEvaCbx1
        '
        Me.SupEvaCbx1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupEvaCbx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupEvaCbx1.Enabled = False
        Me.SupEvaCbx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupEvaCbx1.FormattingEnabled = True
        Me.SupEvaCbx1.Items.AddRange(New Object() {"C5: Outstanding", "C4: Excellent", "C3: Standard", "C2: Need Improvement", "C1: Bad/Poor"})
        Me.SupEvaCbx1.Location = New System.Drawing.Point(1095, 109)
        Me.SupEvaCbx1.Name = "SupEvaCbx1"
        Me.SupEvaCbx1.Size = New System.Drawing.Size(235, 24)
        Me.SupEvaCbx1.TabIndex = 120
        '
        'SupEvaTbx1
        '
        Me.SupEvaTbx1.BackColor = System.Drawing.Color.White
        Me.SupEvaTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupEvaTbx1.Location = New System.Drawing.Point(1095, 130)
        Me.SupEvaTbx1.MaxLength = 0
        Me.SupEvaTbx1.Multiline = True
        Me.SupEvaTbx1.Name = "SupEvaTbx1"
        Me.SupEvaTbx1.ReadOnly = True
        Me.SupEvaTbx1.Size = New System.Drawing.Size(235, 85)
        Me.SupEvaTbx1.TabIndex = 119
        Me.SupEvaTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RenTbx2
        '
        Me.RenTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenTbx2.Location = New System.Drawing.Point(647, 320)
        Me.RenTbx2.Multiline = True
        Me.RenTbx2.Name = "RenTbx2"
        Me.RenTbx2.ReadOnly = True
        Me.RenTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RenTbx2.Size = New System.Drawing.Size(449, 107)
        Me.RenTbx2.TabIndex = 96
        '
        'JinTbx2
        '
        Me.JinTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JinTbx2.Location = New System.Drawing.Point(647, 214)
        Me.JinTbx2.Multiline = True
        Me.JinTbx2.Name = "JinTbx2"
        Me.JinTbx2.ReadOnly = True
        Me.JinTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JinTbx2.Size = New System.Drawing.Size(449, 107)
        Me.JinTbx2.TabIndex = 95
        '
        'JirTbx2
        '
        Me.JirTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JirTbx2.Location = New System.Drawing.Point(647, 108)
        Me.JirTbx2.Multiline = True
        Me.JirTbx2.Name = "JirTbx2"
        Me.JirTbx2.ReadOnly = True
        Me.JirTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JirTbx2.Size = New System.Drawing.Size(449, 107)
        Me.JirTbx2.TabIndex = 94
        '
        'RenTbx1
        '
        Me.RenTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenTbx1.Location = New System.Drawing.Point(199, 320)
        Me.RenTbx1.Multiline = True
        Me.RenTbx1.Name = "RenTbx1"
        Me.RenTbx1.ReadOnly = True
        Me.RenTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RenTbx1.Size = New System.Drawing.Size(449, 107)
        Me.RenTbx1.TabIndex = 93
        '
        'JinTbx1
        '
        Me.JinTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JinTbx1.Location = New System.Drawing.Point(199, 214)
        Me.JinTbx1.Multiline = True
        Me.JinTbx1.Name = "JinTbx1"
        Me.JinTbx1.ReadOnly = True
        Me.JinTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JinTbx1.Size = New System.Drawing.Size(449, 107)
        Me.JinTbx1.TabIndex = 92
        '
        'JirTbx1
        '
        Me.JirTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JirTbx1.Location = New System.Drawing.Point(199, 108)
        Me.JirTbx1.Multiline = True
        Me.JirTbx1.Name = "JirTbx1"
        Me.JirTbx1.ReadOnly = True
        Me.JirTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JirTbx1.Size = New System.Drawing.Size(449, 107)
        Me.JirTbx1.TabIndex = 91
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label35.Location = New System.Drawing.Point(9, 439)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(1087, 20)
        Me.Label35.TabIndex = 90
        Me.Label35.Text = "Overall Superior's Comment"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label31.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label31.Location = New System.Drawing.Point(647, 89)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(449, 20)
        Me.Label31.TabIndex = 78
        Me.Label31.Text = "Need improvement"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label30.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label30.Location = New System.Drawing.Point(199, 89)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(450, 20)
        Me.Label30.TabIndex = 77
        Me.Label30.Text = "Good Behavior Aligned to the Competency"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label29.Location = New System.Drawing.Point(1095, 70)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(235, 39)
        Me.Label29.TabIndex = 76
        Me.Label29.Text = "Superior's Evaluation"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label28.Location = New System.Drawing.Point(199, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(897, 20)
        Me.Label28.TabIndex = 75
        Me.Label28.Text = "Self Assessment"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label27.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label27.Location = New System.Drawing.Point(10, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(190, 39)
        Me.Label27.TabIndex = 74
        Me.Label27.Text = "Items"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label26.Location = New System.Drawing.Point(10, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(1320, 20)
        Me.Label26.TabIndex = 73
        Me.Label26.Text = "Competency"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.CompetencyScore)
        Me.TabPage3.Controls.Add(Me.MBOScoreLb)
        Me.TabPage3.Controls.Add(Me.OvrDiffScore)
        Me.TabPage3.Controls.Add(Me.ApproveRstBtn)
        Me.TabPage3.Controls.Add(Me.RejectRstBtn)
        Me.TabPage3.Controls.Add(Me.SaveBtn)
        Me.TabPage3.Controls.Add(Me.Label52)
        Me.TabPage3.Controls.Add(Me.NotableTbx)
        Me.TabPage3.Controls.Add(Me.Label51)
        Me.TabPage3.Controls.Add(Me.Label50)
        Me.TabPage3.Controls.Add(Me.Label49)
        Me.TabPage3.Controls.Add(Me.Label48)
        Me.TabPage3.Controls.Add(Me.TotalEvaLbl)
        Me.TabPage3.Controls.Add(Me.Label47)
        Me.TabPage3.Controls.Add(Me.ComScrLbl)
        Me.TabPage3.Controls.Add(Me.Label45)
        Me.TabPage3.Controls.Add(Me.MngObjLbl)
        Me.TabPage3.Controls.Add(Me.Label42)
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.OvrEvaLbl)
        Me.TabPage3.Controls.Add(Me.OvrAchLbl)
        Me.TabPage3.Controls.Add(Me.OvrDiffLbl)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Prev2Btn)
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1338, 586)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Result for This Period"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(1243, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 24)
        Me.Button1.TabIndex = 164
        Me.Button1.Text = "Next >"
        Me.ToolTip1.SetToolTip(Me.Button1, "Save button")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CompetencyScore
        '
        Me.CompetencyScore.AutoSize = True
        Me.CompetencyScore.ForeColor = System.Drawing.Color.Black
        Me.CompetencyScore.Location = New System.Drawing.Point(760, 177)
        Me.CompetencyScore.Name = "CompetencyScore"
        Me.CompetencyScore.Size = New System.Drawing.Size(95, 13)
        Me.CompetencyScore.TabIndex = 163
        Me.CompetencyScore.Text = "Competency score"
        Me.CompetencyScore.Visible = False
        '
        'MBOScoreLb
        '
        Me.MBOScoreLb.AutoSize = True
        Me.MBOScoreLb.ForeColor = System.Drawing.Color.Black
        Me.MBOScoreLb.Location = New System.Drawing.Point(319, 176)
        Me.MBOScoreLb.Name = "MBOScoreLb"
        Me.MBOScoreLb.Size = New System.Drawing.Size(71, 13)
        Me.MBOScoreLb.TabIndex = 162
        Me.MBOScoreLb.Text = "MBOScoreLb"
        Me.MBOScoreLb.Visible = False
        '
        'OvrDiffScore
        '
        Me.OvrDiffScore.AutoSize = True
        Me.OvrDiffScore.ForeColor = System.Drawing.Color.Black
        Me.OvrDiffScore.Location = New System.Drawing.Point(505, 135)
        Me.OvrDiffScore.Name = "OvrDiffScore"
        Me.OvrDiffScore.Size = New System.Drawing.Size(68, 13)
        Me.OvrDiffScore.TabIndex = 161
        Me.OvrDiffScore.Text = "OvrDiffScore"
        Me.OvrDiffScore.Visible = False
        '
        'ApproveRstBtn
        '
        Me.ApproveRstBtn.BackColor = System.Drawing.Color.Green
        Me.ApproveRstBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApproveRstBtn.ForeColor = System.Drawing.Color.White
        Me.ApproveRstBtn.Location = New System.Drawing.Point(930, 6)
        Me.ApproveRstBtn.Name = "ApproveRstBtn"
        Me.ApproveRstBtn.Size = New System.Drawing.Size(134, 28)
        Me.ApproveRstBtn.TabIndex = 159
        Me.ApproveRstBtn.Text = "Approve Result"
        Me.ApproveRstBtn.UseVisualStyleBackColor = False
        Me.ApproveRstBtn.Visible = False
        '
        'RejectRstBtn
        '
        Me.RejectRstBtn.BackColor = System.Drawing.Color.Red
        Me.RejectRstBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RejectRstBtn.ForeColor = System.Drawing.Color.White
        Me.RejectRstBtn.Location = New System.Drawing.Point(780, 6)
        Me.RejectRstBtn.Name = "RejectRstBtn"
        Me.RejectRstBtn.Size = New System.Drawing.Size(134, 28)
        Me.RejectRstBtn.TabIndex = 158
        Me.RejectRstBtn.Text = "Reject Result"
        Me.RejectRstBtn.UseVisualStyleBackColor = False
        Me.RejectRstBtn.Visible = False
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Location = New System.Drawing.Point(1080, 5)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(104, 28)
        Me.SaveBtn.TabIndex = 23
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        Me.SaveBtn.Visible = False
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(19, 293)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(157, 16)
        Me.Label52.TabIndex = 157
        Me.Label52.Text = "* Matrix for MBO Score"
        '
        'NotableTbx
        '
        Me.NotableTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotableTbx.Location = New System.Drawing.Point(9, 509)
        Me.NotableTbx.Multiline = True
        Me.NotableTbx.Name = "NotableTbx"
        Me.NotableTbx.ReadOnly = True
        Me.NotableTbx.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.NotableTbx.Size = New System.Drawing.Size(1320, 71)
        Me.NotableTbx.TabIndex = 156
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label51.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label51.Location = New System.Drawing.Point(9, 481)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(1320, 29)
        Me.Label51.TabIndex = 155
        Me.Label51.Text = "Notable items/things to be considered into final decision which are not mentioned" &
    " above (if any)"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(1131, 258)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(168, 16)
        Me.Label50.TabIndex = 154
        Me.Label50.Text = "[Total Evaluation Matrix]"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(642, 264)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(212, 16)
        Me.Label49.TabIndex = 153
        Me.Label49.Text = "[Competency Evaluation Score]"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(10, 264)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(160, 16)
        Me.Label48.TabIndex = 149
        Me.Label48.Text = "[MBO Evaluation Score]"
        '
        'TotalEvaLbl
        '
        Me.TotalEvaLbl.BackColor = System.Drawing.Color.White
        Me.TotalEvaLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalEvaLbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalEvaLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TotalEvaLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TotalEvaLbl.Location = New System.Drawing.Point(1253, 200)
        Me.TotalEvaLbl.Name = "TotalEvaLbl"
        Me.TotalEvaLbl.Size = New System.Drawing.Size(76, 49)
        Me.TotalEvaLbl.TabIndex = 148
        Me.TotalEvaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label47.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label47.Location = New System.Drawing.Point(957, 200)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(300, 49)
        Me.Label47.TabIndex = 147
        Me.Label47.Text = "Total Evaluation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(*see below matrix)"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComScrLbl
        '
        Me.ComScrLbl.BackColor = System.Drawing.Color.White
        Me.ComScrLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ComScrLbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComScrLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComScrLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ComScrLbl.Location = New System.Drawing.Point(779, 200)
        Me.ComScrLbl.Name = "ComScrLbl"
        Me.ComScrLbl.Size = New System.Drawing.Size(76, 49)
        Me.ComScrLbl.TabIndex = 146
        Me.ComScrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label45.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label45.Location = New System.Drawing.Point(483, 200)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(300, 49)
        Me.Label45.TabIndex = 145
        Me.Label45.Text = "Competency Score"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MngObjLbl
        '
        Me.MngObjLbl.BackColor = System.Drawing.Color.White
        Me.MngObjLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MngObjLbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngObjLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MngObjLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MngObjLbl.Location = New System.Drawing.Point(305, 200)
        Me.MngObjLbl.Name = "MngObjLbl"
        Me.MngObjLbl.Size = New System.Drawing.Size(76, 49)
        Me.MngObjLbl.TabIndex = 144
        Me.MngObjLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label42.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label42.Location = New System.Drawing.Point(9, 200)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(300, 49)
        Me.Label42.TabIndex = 143
        Me.Label42.Text = "Management by Objectives"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(10, 174)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(200, 16)
        Me.Label41.TabIndex = 142
        Me.Label41.Text = "2. Summary of the final result"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(10, 67)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(402, 16)
        Me.Label40.TabIndex = 141
        Me.Label40.Text = "1. Overall Achievement Evaluation (automatically calculated)"
        '
        'OvrEvaLbl
        '
        Me.OvrEvaLbl.BackColor = System.Drawing.Color.White
        Me.OvrEvaLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OvrEvaLbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvrEvaLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.OvrEvaLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.OvrEvaLbl.Location = New System.Drawing.Point(957, 118)
        Me.OvrEvaLbl.Name = "OvrEvaLbl"
        Me.OvrEvaLbl.Size = New System.Drawing.Size(372, 42)
        Me.OvrEvaLbl.TabIndex = 140
        Me.OvrEvaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OvrAchLbl
        '
        Me.OvrAchLbl.BackColor = System.Drawing.Color.White
        Me.OvrAchLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OvrAchLbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvrAchLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.OvrAchLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.OvrAchLbl.Location = New System.Drawing.Point(483, 118)
        Me.OvrAchLbl.Name = "OvrAchLbl"
        Me.OvrAchLbl.Size = New System.Drawing.Size(372, 42)
        Me.OvrAchLbl.TabIndex = 139
        Me.OvrAchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OvrDiffLbl
        '
        Me.OvrDiffLbl.BackColor = System.Drawing.Color.White
        Me.OvrDiffLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OvrDiffLbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvrDiffLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.OvrDiffLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.OvrDiffLbl.Location = New System.Drawing.Point(9, 118)
        Me.OvrDiffLbl.Name = "OvrDiffLbl"
        Me.OvrDiffLbl.Size = New System.Drawing.Size(372, 42)
        Me.OvrDiffLbl.TabIndex = 138
        Me.OvrDiffLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label34.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label34.Location = New System.Drawing.Point(483, 89)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(372, 29)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "Overall Achievement"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label33.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label33.Location = New System.Drawing.Point(957, 89)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(372, 29)
        Me.Label33.TabIndex = 136
        Me.Label33.Text = "Overall Evaluation"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label32.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label32.Location = New System.Drawing.Point(9, 89)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(372, 29)
        Me.Label32.TabIndex = 135
        Me.Label32.Text = "Overall Difficulty"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1320, 20)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Result for This Period"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prev2Btn
        '
        Me.Prev2Btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Prev2Btn.BackColor = System.Drawing.SystemColors.Control
        Me.Prev2Btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.Prev2Btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prev2Btn.ForeColor = System.Drawing.Color.Black
        Me.Prev2Btn.Location = New System.Drawing.Point(9, 3)
        Me.Prev2Btn.Name = "Prev2Btn"
        Me.Prev2Btn.Size = New System.Drawing.Size(87, 28)
        Me.Prev2Btn.TabIndex = 133
        Me.Prev2Btn.Text = "< Previous"
        Me.ToolTip1.SetToolTip(Me.Prev2Btn, "Save button")
        Me.Prev2Btn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1086, 278)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(239, 179)
        Me.PictureBox3.TabIndex = 152
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(645, 288)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(210, 180)
        Me.PictureBox2.TabIndex = 151
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 288)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(445, 169)
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1338, 586)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Routing"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(13, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 28)
        Me.Button2.TabIndex = 134
        Me.Button2.Text = "< Previous"
        Me.ToolTip1.SetToolTip(Me.Button2, "Save button")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.App2Lbl)
        Me.GroupBox3.Controls.Add(Me.App1Lbl)
        Me.GroupBox3.Controls.Add(Me.App2IDLbl)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.App1IDLbl)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1306, 164)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Approval Level"
        '
        'App2Lbl
        '
        Me.App2Lbl.AutoSize = True
        Me.App2Lbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App2Lbl.ForeColor = System.Drawing.Color.Blue
        Me.App2Lbl.Location = New System.Drawing.Point(120, 86)
        Me.App2Lbl.Name = "App2Lbl"
        Me.App2Lbl.Size = New System.Drawing.Size(88, 16)
        Me.App2Lbl.TabIndex = 44
        Me.App2Lbl.Text = "Approval 2: "
        Me.App2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'App1Lbl
        '
        Me.App1Lbl.AutoSize = True
        Me.App1Lbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App1Lbl.ForeColor = System.Drawing.Color.Blue
        Me.App1Lbl.Location = New System.Drawing.Point(120, 38)
        Me.App1Lbl.Name = "App1Lbl"
        Me.App1Lbl.Size = New System.Drawing.Size(88, 16)
        Me.App1Lbl.TabIndex = 43
        Me.App1Lbl.Text = "Approval 1: "
        Me.App1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'App2IDLbl
        '
        Me.App2IDLbl.AutoSize = True
        Me.App2IDLbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App2IDLbl.ForeColor = System.Drawing.Color.Blue
        Me.App2IDLbl.Location = New System.Drawing.Point(532, 86)
        Me.App2IDLbl.Name = "App2IDLbl"
        Me.App2IDLbl.Size = New System.Drawing.Size(106, 16)
        Me.App2IDLbl.TabIndex = 42
        Me.App2IDLbl.Text = "Approval ID 2: "
        Me.App2IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.App2IDLbl.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(26, 86)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 16)
        Me.Label37.TabIndex = 41
        Me.Label37.Text = "Approval 2: "
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'App1IDLbl
        '
        Me.App1IDLbl.AutoSize = True
        Me.App1IDLbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App1IDLbl.ForeColor = System.Drawing.Color.Blue
        Me.App1IDLbl.Location = New System.Drawing.Point(532, 38)
        Me.App1IDLbl.Name = "App1IDLbl"
        Me.App1IDLbl.Size = New System.Drawing.Size(106, 16)
        Me.App1IDLbl.TabIndex = 40
        Me.App1IDLbl.Text = "Approval ID 1: "
        Me.App1IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.App1IDLbl.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(26, 38)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(88, 16)
        Me.Label38.TabIndex = 39
        Me.Label38.Text = "Approval 1: "
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.Label56)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox8)
        Me.GroupBox2.Controls.Add(Me.PictureBox9)
        Me.GroupBox2.Controls.Add(Me.PictureBox10)
        Me.GroupBox2.Controls.Add(Me.Status1)
        Me.GroupBox2.Controls.Add(Me.Status2)
        Me.GroupBox2.Controls.Add(Me.Status8)
        Me.GroupBox2.Controls.Add(Me.Status7)
        Me.GroupBox2.Controls.Add(Me.Status6)
        Me.GroupBox2.Controls.Add(Me.Status5)
        Me.GroupBox2.Controls.Add(Me.Status4)
        Me.GroupBox2.Controls.Add(Me.Status3)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1306, 351)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Approval Flow"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(255, 230)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(16, 16)
        Me.Label39.TabIndex = 45
        Me.Label39.Text = "8"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(496, 229)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(16, 16)
        Me.Label43.TabIndex = 44
        Me.Label43.Text = "7"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(770, 229)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(16, 16)
        Me.Label44.TabIndex = 43
        Me.Label44.Text = "6"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(1024, 230)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(16, 16)
        Me.Label46.TabIndex = 42
        Me.Label46.Text = "5"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(1021, 20)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(16, 16)
        Me.Label53.TabIndex = 41
        Me.Label53.Text = "4"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(755, 20)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(16, 16)
        Me.Label54.TabIndex = 40
        Me.Label54.Text = "3"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(491, 21)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(16, 16)
        Me.Label55.TabIndex = 39
        Me.Label55.Text = "2"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(255, 21)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(16, 16)
        Me.Label56.TabIndex = 38
        Me.Label56.Text = "1"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PictureBox4.Location = New System.Drawing.Point(1024, 106)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(13, 121)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(773, 46)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(251, 12)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 33
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(506, 46)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(250, 12)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 32
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(270, 47)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(219, 12)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 31
        Me.PictureBox10.TabStop = False
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
        'ManagerViewFrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1350, 694)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ExportBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ManagerViewFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERFORMANCE MANAGEMENT SYSTEM - TARGETS ASSESSMENT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents ExportBtn As Button
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
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub ManagerViewFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PeriodLabel.Text = WelcomeMngFrm.PeriodCombox.Text
        Dim username As String
        Dim period As String
        Dim count As Integer
        Dim status As Integer
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        Dim reader As MySqlDataReader
        username = DataGridUser.DataGridView.CurrentRow.Cells(1).Value.ToString
        period = PeriodLabel.Text
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM targetdata INNER JOIN result ON targetdata.employeeid = result.employeeid WHERE targetdata.employeeid = '" & username & "' AND targetdata.period = '" & period & "' AND result.employeeid = '" & username & "' AND result.period = '" & period & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                Statuslb.Text = reader("status").ToString
                status = Int32.Parse(Statuslb.Text)
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
                SelComTbx1.Text = reader("Scomment1").ToString
                SelComTbx2.Text = reader("Scomment2").ToString
                SelComTbx3.Text = reader("Scomment3").ToString
                EmpAchTbx1.Text = reader("Sachievement1").ToString
                EmpAchTbx2.Text = reader("Sachievement2").ToString
                EmpAchTbx3.Text = reader("Sachievement3").ToString
                JirTbx1.Text = reader("Jir1").ToString
                JirTbx2.Text = reader("Jir2").ToString
                JinTbx1.Text = reader("Jin1").ToString
                JinTbx2.Text = reader("Jin2").ToString
                RenTbx1.Text = reader("Ren1").ToString
                RenTbx2.Text = reader("Ren2").ToString
                SupComTbx1.Text = reader("comment1").ToString
                SupComTbx2.Text = reader("comment2").ToString
                SupComTbx3.Text = reader("comment3").ToString
                OvrDiffLbl.Text = reader(48).ToString
                SupAchTbx1.Text = reader("achievement1").ToString
                SupAchTbx2.Text = reader("achievement2").ToString
                SupAchTbx3.Text = reader("achievement3").ToString
                SupEvaTbx1.Text = reader("Jiritsu").ToString
                SupEvaTbx2.Text = reader("Jinsoku").ToString
                SupEvaTbx3.Text = reader("Renkei").ToString
                OvrSupCmTbx.Text = reader("OSC").ToString
                OvrSupEvaTbx.Text = reader("OSE").ToString
                OvrAchLbl.Text = reader("achievement").ToString
                OvrEvaLbl.Text = reader("evaluation").ToString
                MngObjLbl.Text = reader("mbo").ToString
                CompetencyScore.Text = reader("competency").ToString
                TotalEvaLbl.Text = reader("total").ToString
                NotableTbx.Text = reader("notable").ToString

            Else
                MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

        Dim employeeid As String
        Dim appid As String
        employeeid = EmployeeLabel.Text
        appid = WelcomeMngFrm.EmployeeIdLabel.Text

        If status = 2 Then
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM employee WHERE employeeid = '" & username & "' AND App1 = '" & appid & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = count + 1
                End While
                reader.Close()
                If count >= 1 Then
                    ApproveBtn.Visible = True
                    RejectBtn.Visible = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If

        If status = 3 Then '2nd approval
            Try
                conn.Open()
                Dim query2 As String = "SELECT * FROM employee WHERE employeeid = '" & username & "' AND app2 = '" & appid & "';"
                command = New MySqlCommand(query2, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = count + 1
                End While
                reader.Close()
                If count >= 1 Then
                    ApproveBtn.Visible = True
                    RejectBtn.Visible = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If

        If status = 5 Then '1st approval
            Try
                conn.Open()
                Dim query2 As String = "SELECT * FROM employee WHERE employeeid = '" & username & "' AND app1 = '" & appid & "';"
                command = New MySqlCommand(query2, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = count + 1
                End While
                reader.Close()
                If count >= 1 Then
                    ApproveRstBtn.Visible = True
                    SaveBtn.Visible = True
                    SupAchCbox1.Enabled = True
                    SupComTbx1.ReadOnly = False
                    SupComTbx2.ReadOnly = False
                    SupComTbx3.ReadOnly = False
                    NotableTbx.ReadOnly = False
                    SupEvaCbx1.Enabled = True
                    SupEvaCbx2.Enabled = True
                    SupEvaCbx3.Enabled = True
                    OvrSupCmTbx.ReadOnly = False
                    If TitleTbx2.Text <> "" And ContentTbx2.Text <> "" And WeightTbx2.Text <> "" And DiffTbx2.Text <> "" Then
                        SupAchCbox2.Enabled = True
                    End If
                    If TitleTxb3.Text <> "" And ContentTbx3.Text <> "" And WeightTbx3.Text <> "" And DiffTbx3.Text <> "" Then
                        SupAchCbox3.Enabled = True
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If

        If status = 6 Then '2nd approval
            Try
                conn.Open()
                Dim query2 As String = "SELECT * FROM employee WHERE employeeid = '" & username & "' AND app2 = '" & appid & "';"
                command = New MySqlCommand(query2, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = count + 1
                End While
                reader.Close()
                If count >= 1 Then
                    ApproveRstBtn.Visible = True
                    RejectRstBtn.Visible = True
                    SaveBtn.Visible = True
                    SupAchCbox1.Enabled = True
                    SupAchCbox2.Enabled = True
                    SupAchCbox3.Enabled = True
                    SupComTbx1.ReadOnly = False
                    SupComTbx2.ReadOnly = False
                    SupComTbx3.ReadOnly = False
                    NotableTbx.ReadOnly = False
                    SupEvaCbx1.Enabled = True
                    SupEvaCbx2.Enabled = True
                    SupEvaCbx3.Enabled = True
                    OvrSupCmTbx.ReadOnly = False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If

        If status <= 1 Or status = 4 Then
            Dim result As DialogResult = MessageBox.Show("Your staff has not yet completed input targets/ self-assessment, do you want to view this?", "Targets/Self-Assessment not yet submitted", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Me.Close()
            Else
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM employee WHERE employeeid = '" & username & "';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count = count + 1
                    End While
                    reader.Close()
                    If count >= 1 Then
                        ApproveBtn.Visible = False
                        RejectBtn.Visible = False
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Dim xlsApp As excel.Application
        Dim xlsWorkBook As excel.Workbook
        Dim xlsWorkSheet As excel.Worksheet

        xlsApp = New excel.Application

        If TitleTbx1.Text = "" Then

            MessageBox.Show("Nothing to export!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim spath As String = ""
            Dim fo As New SaveFileDialog
            fo.Filter = "All files|*.xlsx"
            fo.CheckPathExists = True
            fo.OverwritePrompt = True
            If fo.ShowDialog() = DialogResult.OK Then
                spath = fo.FileName
            End If
            Try
                xlsApp = New Microsoft.Office.Interop.Excel.Application
                xlsWorkBook = xlsApp.Workbooks.Open("C:\PAPVN\PAPVN Performance Management Form.xlsx")
                xlsWorkSheet = xlsWorkBook.Sheets("Form")
                xlsWorkSheet.Cells(3, 3) = "Period: " & PeriodLabel.Text
                xlsWorkSheet.Range("F3").Value = DeptLabel.Text
                xlsWorkSheet.Range("O3").Value = EmployeeLabel.Text
                xlsWorkSheet.Range("J3").Value = NameLabel.Text

                'export target 1
                xlsWorkSheet.Range("C10").Value = "Title: " & TitleTbx1.Text
                xlsWorkSheet.Range("C11").Value = ContentTbx1.Text
                xlsWorkSheet.Range("E11").Value = Int32.Parse(WeightTbx1.Text) / 100
                xlsWorkSheet.Range("D11").Value = DiffTbx1.Text

                'export target 2
                xlsWorkSheet.Range("C12").Value = "Title: " & TitleTbx2.Text
                xlsWorkSheet.Range("C13").Value = ContentTbx2.Text
                xlsWorkSheet.Range("E13").Value = Int32.Parse(WeightTbx2.Text) / 100
                xlsWorkSheet.Range("D13").Value = DiffTbx2.Text

                'export target3
                xlsWorkSheet.Range("C14").Value = "Title: " & TitleTxb3.Text
                xlsWorkSheet.Range("C15").Value = ContentTbx3.Text
                xlsWorkSheet.Range("E15").Value = Int32.Parse(WeightTbx3.Text) / 100
                xlsWorkSheet.Range("D15").Value = DiffTbx3.Text

                'Scomment
                xlsWorkSheet.Range("F10").Value = SelComTbx1.Text
                xlsWorkSheet.Range("F12").Value = SelComTbx2.Text
                xlsWorkSheet.Range("F14").Value = SelComTbx3.Text

                xlsWorkSheet.Range("J10").Value = EmpAchTbx1.Text
                xlsWorkSheet.Range("J12").Value = EmpAchTbx2.Text
                xlsWorkSheet.Range("J14").Value = EmpAchTbx3.Text

                xlsWorkSheet.Range("K10").Value = SupComTbx1.Text
                xlsWorkSheet.Range("K12").Value = SupComTbx2.Text
                xlsWorkSheet.Range("K14").Value = SupComTbx3.Text

                xlsWorkSheet.Range("O10").Value = SupAchTbx1.Text
                xlsWorkSheet.Range("O12").Value = SupAchTbx2.Text
                xlsWorkSheet.Range("O14").Value = SupAchTbx3.Text

                xlsWorkSheet.Range("D28").Value = JirTbx1.Text
                xlsWorkSheet.Range("D31").Value = JinTbx1.Text
                xlsWorkSheet.Range("D34").Value = RenTbx1.Text

                xlsWorkSheet.Range("I28").Value = JirTbx2.Text
                xlsWorkSheet.Range("I31").Value = JinTbx2.Text
                xlsWorkSheet.Range("I34").Value = RenTbx2.Text

                xlsWorkSheet.Range("M28").Value = SupEvaTbx1.Text
                xlsWorkSheet.Range("M31").Value = SupEvaTbx2.Text
                xlsWorkSheet.Range("M34").Value = SupEvaTbx3.Text

                xlsWorkSheet.Range("B39").Value = OvrSupCmTbx.Text
                xlsWorkSheet.Range("B61").Value = NotableTbx.Text
                xlsWorkSheet.Range("B66").Value = DevPlanTbx.Text
                '   xlsWorkSheet.Range("D45").Value = MngObjLbl.Text
                '   xlsWorkSheet.Range("N45").Value = TotalEvaLbl.Text
                xlsWorkBook.SaveAs(spath)
                MessageBox.Show("Successfully Exported!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                xlsWorkBook.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                xlsApp.Quit()
            End Try
        End If
    End Sub

    Private Sub WeightTbx1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles WeightTbx1.Leave
        If Not Regex.Match(WeightTbx1.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            WeightTbx1.Focus()
            WeightTbx1.Clear()
        End If
    End Sub

    Private Sub WeightTbx2_Leave(sender As Object, e As EventArgs) Handles WeightTbx2.Leave
        If Not Regex.Match(WeightTbx2.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            WeightTbx2.Focus()
            WeightTbx2.Clear()
        End If
    End Sub
    Private Sub SupAchCbox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupAchCbox2.SelectedIndexChanged
        SupAchTbx2.Text = SupAchCbox2.Text
    End Sub

    Private Sub SupAchCbox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupAchCbox3.SelectedIndexChanged
        SupAchTbx3.Text = SupAchCbox3.Text
    End Sub

    Private Sub SupAchCbox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupAchCbox1.SelectedIndexChanged
        SupAchTbx1.Text = SupAchCbox1.Text
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SupAchCbox3 As ComboBox
    Friend WithEvents SupAchCbox2 As ComboBox
    Friend WithEvents SupAchCbox1 As ComboBox
    Friend WithEvents SupComTbx3 As TextBox
    Friend WithEvents SupComTbx2 As TextBox
    Friend WithEvents SupComTbx1 As TextBox
    Friend WithEvents SupAchTbx3 As TextBox
    Friend WithEvents SupAchTbx2 As TextBox
    Friend WithEvents SupAchTbx1 As TextBox
    Friend WithEvents EmpAchTbx3 As TextBox
    Friend WithEvents EmpAchTbx2 As TextBox
    Friend WithEvents EmpAchTbx1 As TextBox
    Friend WithEvents SelComTbx3 As TextBox
    Friend WithEvents SelComTbx2 As TextBox
    Friend WithEvents SelComTbx1 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents WeightTbx3 As TextBox
    Friend WithEvents WeightTbx2 As TextBox
    Friend WithEvents WeightTbx1 As TextBox
    Friend WithEvents DiffTbx3 As TextBox
    Friend WithEvents DiffTbx2 As TextBox
    Friend WithEvents DiffTbx1 As TextBox
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
    Friend WithEvents ContentTbx2 As TextBox
    Friend WithEvents TitleTbx2 As TextBox
    Friend WithEvents ContentTbx1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TitleTbx1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ApproveBtn As Button
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents OvrSupEvaTbx As TextBox
    Friend WithEvents OvrSupCmTbx As TextBox
    Friend WithEvents SupEvaCbx3 As ComboBox
    Friend WithEvents SupEvaTbx3 As TextBox
    Friend WithEvents SupEvaCbx2 As ComboBox
    Friend WithEvents SupEvaTbx2 As TextBox
    Friend WithEvents SupEvaCbx1 As ComboBox
    Friend WithEvents SupEvaTbx1 As TextBox
    Friend WithEvents RenTbx2 As TextBox
    Friend WithEvents JinTbx2 As TextBox
    Friend WithEvents JirTbx2 As TextBox
    Friend WithEvents RenTbx1 As TextBox
    Friend WithEvents JinTbx1 As TextBox
    Friend WithEvents JirTbx1 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents NextBtn As Button
    Friend WithEvents Statuslb As LinkLabel
    Friend WithEvents RejectBtn As Button
    Friend WithEvents PrevBtn As Button
    Friend WithEvents Next2Btn As Button
    Friend WithEvents TotalEvaLbl As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents ComScrLbl As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents MngObjLbl As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents OvrEvaLbl As Label
    Friend WithEvents OvrAchLbl As Label
    Friend WithEvents OvrDiffLbl As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Prev2Btn As Button
    Friend WithEvents NotableTbx As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents ApproveRstBtn As Button
    Friend WithEvents RejectRstBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Diff3ValueLb As Label
    Friend WithEvents Diff2ValueLb As Label
    Friend WithEvents Diff1ValueLb As Label
    Friend WithEvents SupAchLb3 As Label
    Friend WithEvents SupAchLb2 As Label
    Friend WithEvents SupAchLb1 As Label
    Friend WithEvents OvrDiffScore As Label
    Friend WithEvents SupEvaLb3 As Label
    Friend WithEvents SupEvaLb2 As Label
    Friend WithEvents SupEvaLb1 As Label
    Friend WithEvents MBOScoreLb As Label
    Friend WithEvents CompetencyScore As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents App2Lbl As Label
    Friend WithEvents App1Lbl As Label
    Friend WithEvents App2IDLbl As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents App1IDLbl As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Status1 As RadioButton
    Friend WithEvents Status2 As RadioButton
    Friend WithEvents Status8 As RadioButton
    Friend WithEvents Status7 As RadioButton
    Friend WithEvents Status6 As RadioButton
    Friend WithEvents Status5 As RadioButton
    Friend WithEvents Status4 As RadioButton
    Friend WithEvents Status3 As RadioButton
    Friend WithEvents CompetencyBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
