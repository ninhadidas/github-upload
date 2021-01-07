Imports MySql.Data.MySqlClient
Imports outlook = Microsoft.Office.Interop.Outlook
Imports System.Text.RegularExpressions
Imports excel = Microsoft.Office.Interop.Excel
Imports System.IO.File
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelfAssessFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelfAssessFrm))
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CompetencyBtn = New System.Windows.Forms.Button()
        Me.DevPlanTbx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.RenTbx2 = New System.Windows.Forms.TextBox()
        Me.JinTbx2 = New System.Windows.Forms.TextBox()
        Me.JirTbx2 = New System.Windows.Forms.TextBox()
        Me.RenTbx1 = New System.Windows.Forms.TextBox()
        Me.JinTbx1 = New System.Windows.Forms.TextBox()
        Me.JirTbx1 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AchieveCbox3 = New System.Windows.Forms.ComboBox()
        Me.AchieveCbox2 = New System.Windows.Forms.ComboBox()
        Me.AchieveCbox1 = New System.Windows.Forms.ComboBox()
        Me.EmpAchTbx3 = New System.Windows.Forms.TextBox()
        Me.EmpAchTbx2 = New System.Windows.Forms.TextBox()
        Me.EmpAchTbx1 = New System.Windows.Forms.TextBox()
        Me.SelComTbx3 = New System.Windows.Forms.TextBox()
        Me.SelComTbx2 = New System.Windows.Forms.TextBox()
        Me.SelComTbx1 = New System.Windows.Forms.TextBox()
        Me.WeightTbx3 = New System.Windows.Forms.TextBox()
        Me.WeightTbx2 = New System.Windows.Forms.TextBox()
        Me.WeightTbx1 = New System.Windows.Forms.TextBox()
        Me.DiffTbx3 = New System.Windows.Forms.TextBox()
        Me.DiffTbx2 = New System.Windows.Forms.TextBox()
        Me.DiffTbx1 = New System.Windows.Forms.TextBox()
        Me.ContentTbx3 = New System.Windows.Forms.TextBox()
        Me.TitleTxb3 = New System.Windows.Forms.TextBox()
        Me.ContentTbx2 = New System.Windows.Forms.TextBox()
        Me.TitleTbx2 = New System.Windows.Forms.TextBox()
        Me.ContentTbx1 = New System.Windows.Forms.TextBox()
        Me.TitleTbx1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
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
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.CloseBtn.Location = New System.Drawing.Point(1287, 17)
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
        Me.PrintBtn.Location = New System.Drawing.Point(1252, 14)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(78, 40)
        Me.PrintBtn.TabIndex = 7
        Me.PrintBtn.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.PrintBtn, "Print Btn")
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'SubmitBtn
        '
        Me.SubmitBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.SubmitBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.Black
        Me.SubmitBtn.Location = New System.Drawing.Point(1152, 14)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(78, 40)
        Me.SubmitBtn.TabIndex = 8
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        Me.SubmitBtn.Visible = False
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
        Me.DeptLabel.Location = New System.Drawing.Point(330, 14)
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
        Me.Label5.Location = New System.Drawing.Point(287, 14)
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
        Me.NameLabel.Location = New System.Drawing.Point(597, 14)
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
        Me.Label7.Location = New System.Drawing.Point(528, 14)
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
        Me.EmployeeLabel.Location = New System.Drawing.Point(940, 14)
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
        Me.Label4.Location = New System.Drawing.Point(849, 14)
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
        Me.Label8.Location = New System.Drawing.Point(1139, 14)
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
        Me.GroupBox1.Size = New System.Drawing.Size(1271, 45)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Statuslb
        '
        Me.Statuslb.AutoSize = True
        Me.Statuslb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslb.Location = New System.Drawing.Point(1219, 14)
        Me.Statuslb.Name = "Statuslb"
        Me.Statuslb.Size = New System.Drawing.Size(30, 16)
        Me.Statuslb.TabIndex = 23
        Me.Statuslb.TabStop = True
        Me.Statuslb.Text = "Sta"
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
        Me.PrevBtn.Size = New System.Drawing.Size(87, 40)
        Me.PrevBtn.TabIndex = 132
        Me.PrevBtn.Text = "< Previous"
        Me.ToolTip1.SetToolTip(Me.PrevBtn, "Save button")
        Me.PrevBtn.UseVisualStyleBackColor = False
        '
        'NextBtn
        '
        Me.NextBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.NextBtn.BackColor = System.Drawing.SystemColors.Control
        Me.NextBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.NextBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.ForeColor = System.Drawing.Color.Black
        Me.NextBtn.Location = New System.Drawing.Point(1243, 6)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(87, 39)
        Me.NextBtn.TabIndex = 121
        Me.NextBtn.Text = "Next >"
        Me.ToolTip1.SetToolTip(Me.NextBtn, "Save button")
        Me.NextBtn.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CompetencyBtn)
        Me.TabPage2.Controls.Add(Me.DevPlanTbx)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.SaveBtn)
        Me.TabPage2.Controls.Add(Me.PrevBtn)
        Me.TabPage2.Controls.Add(Me.SubmitBtn)
        Me.TabPage2.Controls.Add(Me.TextBox14)
        Me.TabPage2.Controls.Add(Me.PrintBtn)
        Me.TabPage2.Controls.Add(Me.TextBox13)
        Me.TabPage2.Controls.Add(Me.TextBox12)
        Me.TabPage2.Controls.Add(Me.RenTbx2)
        Me.TabPage2.Controls.Add(Me.JinTbx2)
        Me.TabPage2.Controls.Add(Me.JirTbx2)
        Me.TabPage2.Controls.Add(Me.RenTbx1)
        Me.TabPage2.Controls.Add(Me.JinTbx1)
        Me.TabPage2.Controls.Add(Me.JirTbx1)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1338, 544)
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
        Me.CompetencyBtn.Location = New System.Drawing.Point(854, 14)
        Me.CompetencyBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CompetencyBtn.Name = "CompetencyBtn"
        Me.CompetencyBtn.Size = New System.Drawing.Size(175, 40)
        Me.CompetencyBtn.TabIndex = 136
        Me.CompetencyBtn.Text = "Competency Description"
        Me.CompetencyBtn.UseVisualStyleBackColor = False
        '
        'DevPlanTbx
        '
        Me.DevPlanTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevPlanTbx.Location = New System.Drawing.Point(10, 470)
        Me.DevPlanTbx.Multiline = True
        Me.DevPlanTbx.Name = "DevPlanTbx"
        Me.DevPlanTbx.ReadOnly = True
        Me.DevPlanTbx.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DevPlanTbx.Size = New System.Drawing.Size(1320, 66)
        Me.DevPlanTbx.TabIndex = 135
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(10, 452)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1320, 20)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "Your Development Plan (career plan, self-development, study, certification, train" &
    "ing, etc.)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.Transparent
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Location = New System.Drawing.Point(1049, 14)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(82, 40)
        Me.SaveBtn.TabIndex = 133
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        Me.SaveBtn.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(10, 342)
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
        Me.TextBox13.Location = New System.Drawing.Point(10, 236)
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
        Me.TextBox12.Location = New System.Drawing.Point(10, 130)
        Me.TextBox12.MaxLength = 3
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(190, 107)
        Me.TextBox12.TabIndex = 128
        Me.TextBox12.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELF-RELIANCE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Jiritsu - 自立)"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RenTbx2
        '
        Me.RenTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenTbx2.Location = New System.Drawing.Point(764, 342)
        Me.RenTbx2.Multiline = True
        Me.RenTbx2.Name = "RenTbx2"
        Me.RenTbx2.ReadOnly = True
        Me.RenTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RenTbx2.Size = New System.Drawing.Size(566, 107)
        Me.RenTbx2.TabIndex = 96
        '
        'JinTbx2
        '
        Me.JinTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JinTbx2.Location = New System.Drawing.Point(764, 236)
        Me.JinTbx2.Multiline = True
        Me.JinTbx2.Name = "JinTbx2"
        Me.JinTbx2.ReadOnly = True
        Me.JinTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JinTbx2.Size = New System.Drawing.Size(566, 107)
        Me.JinTbx2.TabIndex = 95
        '
        'JirTbx2
        '
        Me.JirTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JirTbx2.Location = New System.Drawing.Point(764, 130)
        Me.JirTbx2.Multiline = True
        Me.JirTbx2.Name = "JirTbx2"
        Me.JirTbx2.ReadOnly = True
        Me.JirTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JirTbx2.Size = New System.Drawing.Size(566, 107)
        Me.JirTbx2.TabIndex = 94
        '
        'RenTbx1
        '
        Me.RenTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenTbx1.Location = New System.Drawing.Point(199, 342)
        Me.RenTbx1.Multiline = True
        Me.RenTbx1.Name = "RenTbx1"
        Me.RenTbx1.ReadOnly = True
        Me.RenTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RenTbx1.Size = New System.Drawing.Size(566, 107)
        Me.RenTbx1.TabIndex = 93
        '
        'JinTbx1
        '
        Me.JinTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JinTbx1.Location = New System.Drawing.Point(199, 236)
        Me.JinTbx1.Multiline = True
        Me.JinTbx1.Name = "JinTbx1"
        Me.JinTbx1.ReadOnly = True
        Me.JinTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JinTbx1.Size = New System.Drawing.Size(566, 107)
        Me.JinTbx1.TabIndex = 92
        '
        'JirTbx1
        '
        Me.JirTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JirTbx1.Location = New System.Drawing.Point(199, 130)
        Me.JirTbx1.Multiline = True
        Me.JirTbx1.Name = "JirTbx1"
        Me.JirTbx1.ReadOnly = True
        Me.JirTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JirTbx1.Size = New System.Drawing.Size(566, 107)
        Me.JirTbx1.TabIndex = 91
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label31.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label31.Location = New System.Drawing.Point(764, 111)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(566, 20)
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
        Me.Label30.Location = New System.Drawing.Point(199, 111)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(566, 20)
        Me.Label30.TabIndex = 77
        Me.Label30.Text = "Good Behavior Aligned to the Competency"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label28.Location = New System.Drawing.Point(199, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(1131, 20)
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
        Me.Label27.Location = New System.Drawing.Point(10, 92)
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
        Me.Label26.Location = New System.Drawing.Point(10, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(1320, 20)
        Me.Label26.TabIndex = 73
        Me.Label26.Text = "Competency"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NextBtn)
        Me.TabPage1.Controls.Add(Me.AchieveCbox3)
        Me.TabPage1.Controls.Add(Me.AchieveCbox2)
        Me.TabPage1.Controls.Add(Me.AchieveCbox1)
        Me.TabPage1.Controls.Add(Me.EmpAchTbx3)
        Me.TabPage1.Controls.Add(Me.EmpAchTbx2)
        Me.TabPage1.Controls.Add(Me.EmpAchTbx1)
        Me.TabPage1.Controls.Add(Me.SelComTbx3)
        Me.TabPage1.Controls.Add(Me.SelComTbx2)
        Me.TabPage1.Controls.Add(Me.SelComTbx1)
        Me.TabPage1.Controls.Add(Me.WeightTbx3)
        Me.TabPage1.Controls.Add(Me.WeightTbx2)
        Me.TabPage1.Controls.Add(Me.WeightTbx1)
        Me.TabPage1.Controls.Add(Me.DiffTbx3)
        Me.TabPage1.Controls.Add(Me.DiffTbx2)
        Me.TabPage1.Controls.Add(Me.DiffTbx1)
        Me.TabPage1.Controls.Add(Me.ContentTbx3)
        Me.TabPage1.Controls.Add(Me.TitleTxb3)
        Me.TabPage1.Controls.Add(Me.ContentTbx2)
        Me.TabPage1.Controls.Add(Me.TitleTbx2)
        Me.TabPage1.Controls.Add(Me.ContentTbx1)
        Me.TabPage1.Controls.Add(Me.TitleTbx1)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1338, 544)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Management By Objective"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AchieveCbox3
        '
        Me.AchieveCbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AchieveCbox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AchieveCbox3.Enabled = False
        Me.AchieveCbox3.FormattingEnabled = True
        Me.AchieveCbox3.Items.AddRange(New Object() {"A3: Highly achieved", "A2: Achieved", "A1: Not achieved"})
        Me.AchieveCbox3.Location = New System.Drawing.Point(1226, 402)
        Me.AchieveCbox3.Name = "AchieveCbox3"
        Me.AchieveCbox3.Size = New System.Drawing.Size(104, 21)
        Me.AchieveCbox3.TabIndex = 120
        '
        'AchieveCbox2
        '
        Me.AchieveCbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AchieveCbox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AchieveCbox2.Enabled = False
        Me.AchieveCbox2.FormattingEnabled = True
        Me.AchieveCbox2.Items.AddRange(New Object() {"A3: Highly achieved", "A2: Achieved", "A1: Not achieved"})
        Me.AchieveCbox2.Location = New System.Drawing.Point(1226, 260)
        Me.AchieveCbox2.Name = "AchieveCbox2"
        Me.AchieveCbox2.Size = New System.Drawing.Size(104, 21)
        Me.AchieveCbox2.TabIndex = 119
        '
        'AchieveCbox1
        '
        Me.AchieveCbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AchieveCbox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AchieveCbox1.Enabled = False
        Me.AchieveCbox1.FormattingEnabled = True
        Me.AchieveCbox1.Items.AddRange(New Object() {"A3: Highly achieved", "A2: Achieved", "A1: Not achieved"})
        Me.AchieveCbox1.Location = New System.Drawing.Point(1225, 118)
        Me.AchieveCbox1.Name = "AchieveCbox1"
        Me.AchieveCbox1.Size = New System.Drawing.Size(105, 21)
        Me.AchieveCbox1.TabIndex = 118
        '
        'EmpAchTbx3
        '
        Me.EmpAchTbx3.BackColor = System.Drawing.Color.White
        Me.EmpAchTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAchTbx3.Location = New System.Drawing.Point(1225, 423)
        Me.EmpAchTbx3.MaxLength = 0
        Me.EmpAchTbx3.Multiline = True
        Me.EmpAchTbx3.Name = "EmpAchTbx3"
        Me.EmpAchTbx3.ReadOnly = True
        Me.EmpAchTbx3.Size = New System.Drawing.Size(105, 116)
        Me.EmpAchTbx3.TabIndex = 111
        Me.EmpAchTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpAchTbx2
        '
        Me.EmpAchTbx2.BackColor = System.Drawing.Color.White
        Me.EmpAchTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAchTbx2.Location = New System.Drawing.Point(1225, 281)
        Me.EmpAchTbx2.MaxLength = 0
        Me.EmpAchTbx2.Multiline = True
        Me.EmpAchTbx2.Name = "EmpAchTbx2"
        Me.EmpAchTbx2.ReadOnly = True
        Me.EmpAchTbx2.Size = New System.Drawing.Size(105, 121)
        Me.EmpAchTbx2.TabIndex = 110
        Me.EmpAchTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpAchTbx1
        '
        Me.EmpAchTbx1.BackColor = System.Drawing.Color.White
        Me.EmpAchTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAchTbx1.Location = New System.Drawing.Point(1225, 139)
        Me.EmpAchTbx1.MaxLength = 0
        Me.EmpAchTbx1.Multiline = True
        Me.EmpAchTbx1.Name = "EmpAchTbx1"
        Me.EmpAchTbx1.ReadOnly = True
        Me.EmpAchTbx1.Size = New System.Drawing.Size(105, 121)
        Me.EmpAchTbx1.TabIndex = 109
        Me.EmpAchTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SelComTbx3
        '
        Me.SelComTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelComTbx3.Location = New System.Drawing.Point(845, 402)
        Me.SelComTbx3.Multiline = True
        Me.SelComTbx3.Name = "SelComTbx3"
        Me.SelComTbx3.ReadOnly = True
        Me.SelComTbx3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SelComTbx3.Size = New System.Drawing.Size(381, 137)
        Me.SelComTbx3.TabIndex = 108
        '
        'SelComTbx2
        '
        Me.SelComTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelComTbx2.Location = New System.Drawing.Point(845, 260)
        Me.SelComTbx2.Multiline = True
        Me.SelComTbx2.Name = "SelComTbx2"
        Me.SelComTbx2.ReadOnly = True
        Me.SelComTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SelComTbx2.Size = New System.Drawing.Size(381, 142)
        Me.SelComTbx2.TabIndex = 107
        '
        'SelComTbx1
        '
        Me.SelComTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelComTbx1.Location = New System.Drawing.Point(845, 118)
        Me.SelComTbx1.Multiline = True
        Me.SelComTbx1.Name = "SelComTbx1"
        Me.SelComTbx1.ReadOnly = True
        Me.SelComTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SelComTbx1.Size = New System.Drawing.Size(381, 142)
        Me.SelComTbx1.TabIndex = 106
        '
        'WeightTbx3
        '
        Me.WeightTbx3.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx3.Location = New System.Drawing.Point(785, 425)
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
        Me.WeightTbx2.Location = New System.Drawing.Point(785, 283)
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
        Me.WeightTbx1.Location = New System.Drawing.Point(785, 141)
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
        Me.DiffTbx3.Location = New System.Drawing.Point(666, 425)
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
        Me.DiffTbx2.Location = New System.Drawing.Point(666, 283)
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
        Me.DiffTbx1.Location = New System.Drawing.Point(666, 141)
        Me.DiffTbx1.Multiline = True
        Me.DiffTbx1.Name = "DiffTbx1"
        Me.DiffTbx1.ReadOnly = True
        Me.DiffTbx1.Size = New System.Drawing.Size(119, 119)
        Me.DiffTbx1.TabIndex = 94
        Me.DiffTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContentTbx3
        '
        Me.ContentTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx3.Location = New System.Drawing.Point(52, 425)
        Me.ContentTbx3.Multiline = True
        Me.ContentTbx3.Name = "ContentTbx3"
        Me.ContentTbx3.ReadOnly = True
        Me.ContentTbx3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx3.Size = New System.Drawing.Size(614, 114)
        Me.ContentTbx3.TabIndex = 79
        '
        'TitleTxb3
        '
        Me.TitleTxb3.BackColor = System.Drawing.Color.Silver
        Me.TitleTxb3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxb3.Location = New System.Drawing.Point(113, 402)
        Me.TitleTxb3.Name = "TitleTxb3"
        Me.TitleTxb3.ReadOnly = True
        Me.TitleTxb3.Size = New System.Drawing.Size(732, 23)
        Me.TitleTxb3.TabIndex = 78
        '
        'ContentTbx2
        '
        Me.ContentTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx2.Location = New System.Drawing.Point(52, 283)
        Me.ContentTbx2.Multiline = True
        Me.ContentTbx2.Name = "ContentTbx2"
        Me.ContentTbx2.ReadOnly = True
        Me.ContentTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx2.Size = New System.Drawing.Size(614, 119)
        Me.ContentTbx2.TabIndex = 77
        '
        'TitleTbx2
        '
        Me.TitleTbx2.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx2.Location = New System.Drawing.Point(113, 260)
        Me.TitleTbx2.Name = "TitleTbx2"
        Me.TitleTbx2.ReadOnly = True
        Me.TitleTbx2.Size = New System.Drawing.Size(732, 23)
        Me.TitleTbx2.TabIndex = 76
        '
        'ContentTbx1
        '
        Me.ContentTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx1.Location = New System.Drawing.Point(52, 141)
        Me.ContentTbx1.Multiline = True
        Me.ContentTbx1.Name = "ContentTbx1"
        Me.ContentTbx1.ReadOnly = True
        Me.ContentTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx1.Size = New System.Drawing.Size(614, 119)
        Me.ContentTbx1.TabIndex = 75
        '
        'TitleTbx1
        '
        Me.TitleTbx1.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx1.Location = New System.Drawing.Point(113, 118)
        Me.TitleTbx1.Name = "TitleTbx1"
        Me.TitleTbx1.ReadOnly = True
        Me.TitleTbx1.Size = New System.Drawing.Size(732, 23)
        Me.TitleTbx1.TabIndex = 71
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label23.Location = New System.Drawing.Point(1225, 99)
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
        Me.Label22.Location = New System.Drawing.Point(845, 99)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(381, 19)
        Me.Label22.TabIndex = 102
        Me.Label22.Text = "Comment"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label20.Location = New System.Drawing.Point(845, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(485, 20)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = "Employee - Self Assessment"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label19.Location = New System.Drawing.Point(784, 99)
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
        Me.Label18.Location = New System.Drawing.Point(666, 99)
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
        Me.Label17.Location = New System.Drawing.Point(10, 402)
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
        Me.Label16.Location = New System.Drawing.Point(10, 260)
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
        Me.Label15.Location = New System.Drawing.Point(10, 118)
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
        Me.Label14.Location = New System.Drawing.Point(10, 79)
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
        Me.Label13.Location = New System.Drawing.Point(52, 402)
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
        Me.Label12.Location = New System.Drawing.Point(52, 260)
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
        Me.Label11.Location = New System.Drawing.Point(52, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Title:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.Location = New System.Drawing.Point(49, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(617, 20)
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
        Me.Label6.Location = New System.Drawing.Point(49, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(796, 20)
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
        Me.Label3.Location = New System.Drawing.Point(10, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1320, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Management by Ojective"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1346, 570)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1338, 544)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Routing"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(16, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1306, 144)
        Me.GroupBox3.TabIndex = 6
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1306, 351)
        Me.GroupBox2.TabIndex = 5
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
        'SelfAssessFrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1350, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SelfAssessFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERFORMANCE MANAGEMENT SYSTEM - TARGETS ASSESSMENT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
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
    Friend WithEvents SubmitBtn As Button
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
    Private Sub SelfAssessFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim query As String = "SELECT * FROM targetdata WHERE employeeid = '" & username & "' AND period = '" & period & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = count + 1
            End While
            status = reader("status").ToString
            If count = 1 Then
                If status = 4 Then
                    SelComTbx1.ReadOnly = False
                    SelComTbx2.ReadOnly = False
                    SelComTbx3.ReadOnly = False
                    AchieveCbox1.Enabled = True
                    AchieveCbox2.Enabled = True
                    AchieveCbox3.Enabled = True
                    SaveBtn.Visible = True
                    SubmitBtn.Visible = True
                    JirTbx1.ReadOnly = False
                    JirTbx2.ReadOnly = False
                    JinTbx1.ReadOnly = False
                    JinTbx2.ReadOnly = False
                    RenTbx1.ReadOnly = False
                    RenTbx2.ReadOnly = False
                End If
                Statuslb.Text = status
                DeptLabel.Text = reader("dept").ToString
                NameLabel.Text = reader("name").ToString
                EmployeeLabel.Text = username
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

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Statuslb As LinkLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PrevBtn As Button
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents RenTbx2 As TextBox
    Friend WithEvents JinTbx2 As TextBox
    Friend WithEvents JirTbx2 As TextBox
    Friend WithEvents RenTbx1 As TextBox
    Friend WithEvents JinTbx1 As TextBox
    Friend WithEvents JirTbx1 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents NextBtn As Button
    Friend WithEvents AchieveCbox3 As ComboBox
    Friend WithEvents AchieveCbox2 As ComboBox
    Friend WithEvents AchieveCbox1 As ComboBox
    Friend WithEvents EmpAchTbx3 As TextBox
    Friend WithEvents EmpAchTbx2 As TextBox
    Friend WithEvents EmpAchTbx1 As TextBox
    Friend WithEvents SelComTbx3 As TextBox
    Friend WithEvents SelComTbx2 As TextBox
    Friend WithEvents SelComTbx1 As TextBox
    Friend WithEvents WeightTbx3 As TextBox
    Friend WithEvents WeightTbx2 As TextBox
    Friend WithEvents WeightTbx1 As TextBox
    Friend WithEvents DiffTbx3 As TextBox
    Friend WithEvents DiffTbx2 As TextBox
    Friend WithEvents DiffTbx1 As TextBox
    Friend WithEvents ContentTbx3 As TextBox
    Friend WithEvents TitleTxb3 As TextBox
    Friend WithEvents ContentTbx2 As TextBox
    Friend WithEvents TitleTbx2 As TextBox
    Friend WithEvents ContentTbx1 As TextBox
    Friend WithEvents TitleTbx1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DevPlanTbx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage3 As TabPage
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
End Class
