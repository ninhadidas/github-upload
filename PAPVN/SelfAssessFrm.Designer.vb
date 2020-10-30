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
        Me.SttLabel = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.SttLabel)
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
        'SttLabel
        '
        Me.SttLabel.AutoSize = True
        Me.SttLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SttLabel.Location = New System.Drawing.Point(1219, 14)
        Me.SttLabel.Name = "SttLabel"
        Me.SttLabel.Size = New System.Drawing.Size(30, 16)
        Me.SttLabel.TabIndex = 23
        Me.SttLabel.TabStop = True
        Me.SttLabel.Text = "Sta"
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
        Me.Label31.Size = New System.Drawing.Size(566, 107)
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
        Me.Label30.Size = New System.Drawing.Size(566, 107)
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
        Me.TabControl1.Location = New System.Drawing.Point(4, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1346, 570)
        Me.TabControl1.TabIndex = 22
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
                SttLabel.Text = status
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
    Friend WithEvents SttLabel As LinkLabel
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
End Class
