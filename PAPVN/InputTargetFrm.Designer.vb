Imports MySql.Data.MySqlClient
Imports outlook = Microsoft.Office.Interop.Outlook
Imports System.Text.RegularExpressions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputTargetFrm))
        Me.TitleTbx1 = New System.Windows.Forms.TextBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ContentTbx1 = New System.Windows.Forms.TextBox()
        Me.TitleTbx2 = New System.Windows.Forms.TextBox()
        Me.ContentTbx3 = New System.Windows.Forms.TextBox()
        Me.TitleTxb3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DevPlanTbx = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DiffComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DiffComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DiffComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DiffTbx1 = New System.Windows.Forms.TextBox()
        Me.DiffTbx2 = New System.Windows.Forms.TextBox()
        Me.DiffTbx3 = New System.Windows.Forms.TextBox()
        Me.WeightTbx1 = New System.Windows.Forms.TextBox()
        Me.WeightTbx2 = New System.Windows.Forms.TextBox()
        Me.WeightTbx3 = New System.Windows.Forms.TextBox()
        Me.ContentTbx2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleTbx1
        '
        Me.TitleTbx1.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx1.Location = New System.Drawing.Point(115, 202)
        Me.TitleTbx1.Name = "TitleTbx1"
        Me.TitleTbx1.ReadOnly = True
        Me.TitleTbx1.Size = New System.Drawing.Size(1217, 23)
        Me.TitleTbx1.TabIndex = 0
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1320, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Management by Ojective"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label6.Location = New System.Drawing.Point(51, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1281, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Targets"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.Location = New System.Drawing.Point(51, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1062, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "( KPI, Key Success Factor, Deadline )"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContentTbx1
        '
        Me.ContentTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx1.Location = New System.Drawing.Point(54, 225)
        Me.ContentTbx1.Multiline = True
        Me.ContentTbx1.Name = "ContentTbx1"
        Me.ContentTbx1.ReadOnly = True
        Me.ContentTbx1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx1.Size = New System.Drawing.Size(1059, 125)
        Me.ContentTbx1.TabIndex = 25
        '
        'TitleTbx2
        '
        Me.TitleTbx2.BackColor = System.Drawing.Color.Silver
        Me.TitleTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTbx2.Location = New System.Drawing.Point(115, 350)
        Me.TitleTbx2.Name = "TitleTbx2"
        Me.TitleTbx2.ReadOnly = True
        Me.TitleTbx2.Size = New System.Drawing.Size(1217, 23)
        Me.TitleTbx2.TabIndex = 26
        '
        'ContentTbx3
        '
        Me.ContentTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx3.Location = New System.Drawing.Point(54, 521)
        Me.ContentTbx3.Multiline = True
        Me.ContentTbx3.Name = "ContentTbx3"
        Me.ContentTbx3.ReadOnly = True
        Me.ContentTbx3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx3.Size = New System.Drawing.Size(1059, 123)
        Me.ContentTbx3.TabIndex = 29
        '
        'TitleTxb3
        '
        Me.TitleTxb3.BackColor = System.Drawing.Color.Silver
        Me.TitleTxb3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxb3.Location = New System.Drawing.Point(115, 498)
        Me.TitleTxb3.Name = "TitleTxb3"
        Me.TitleTxb3.ReadOnly = True
        Me.TitleTxb3.Size = New System.Drawing.Size(1217, 23)
        Me.TitleTxb3.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(12, 645)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1320, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Your Development Plan (career plan, self-development, study, certification, train" &
    "ing, etc.)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DevPlanTbx
        '
        Me.DevPlanTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevPlanTbx.Location = New System.Drawing.Point(12, 663)
        Me.DevPlanTbx.Multiline = True
        Me.DevPlanTbx.Name = "DevPlanTbx"
        Me.DevPlanTbx.ReadOnly = True
        Me.DevPlanTbx.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DevPlanTbx.Size = New System.Drawing.Size(1320, 47)
        Me.DevPlanTbx.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label11.Location = New System.Drawing.Point(54, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Title:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label12.Location = New System.Drawing.Point(54, 350)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Title:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.Location = New System.Drawing.Point(54, 498)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 23)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Title:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label14.Location = New System.Drawing.Point(12, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 39)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "No"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label15.Location = New System.Drawing.Point(12, 202)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 148)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label16.Location = New System.Drawing.Point(12, 350)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 148)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label17.Location = New System.Drawing.Point(12, 498)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 146)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "3"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label18.Location = New System.Drawing.Point(1111, 183)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 19)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Difficulty"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label19.Location = New System.Drawing.Point(1249, 183)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 19)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Weight"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DiffComboBox1
        '
        Me.DiffComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DiffComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiffComboBox1.FormattingEnabled = True
        Me.DiffComboBox1.Items.AddRange(New Object() {"D1: Easy for the position", "D2: Appropriate for the position", "D3: Challenging for the position"})
        Me.DiffComboBox1.Location = New System.Drawing.Point(1110, 225)
        Me.DiffComboBox1.Name = "DiffComboBox1"
        Me.DiffComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.DiffComboBox1.TabIndex = 41
        '
        'DiffComboBox2
        '
        Me.DiffComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DiffComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiffComboBox2.FormattingEnabled = True
        Me.DiffComboBox2.Items.AddRange(New Object() {"D1: Easy for the position", "D2: Appropriate for the position", "D3: Challenging for the position"})
        Me.DiffComboBox2.Location = New System.Drawing.Point(1110, 373)
        Me.DiffComboBox2.Name = "DiffComboBox2"
        Me.DiffComboBox2.Size = New System.Drawing.Size(141, 21)
        Me.DiffComboBox2.TabIndex = 42
        '
        'DiffComboBox3
        '
        Me.DiffComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DiffComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiffComboBox3.FormattingEnabled = True
        Me.DiffComboBox3.Items.AddRange(New Object() {"D1: Easy for the position", "D2: Appropriate for the position", "D3: Challenging for the position"})
        Me.DiffComboBox3.Location = New System.Drawing.Point(1110, 521)
        Me.DiffComboBox3.Name = "DiffComboBox3"
        Me.DiffComboBox3.Size = New System.Drawing.Size(141, 21)
        Me.DiffComboBox3.TabIndex = 43
        '
        'DiffTbx1
        '
        Me.DiffTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx1.Location = New System.Drawing.Point(1110, 246)
        Me.DiffTbx1.Multiline = True
        Me.DiffTbx1.Name = "DiffTbx1"
        Me.DiffTbx1.ReadOnly = True
        Me.DiffTbx1.Size = New System.Drawing.Size(141, 104)
        Me.DiffTbx1.TabIndex = 44
        Me.DiffTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx2
        '
        Me.DiffTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx2.Location = New System.Drawing.Point(1110, 394)
        Me.DiffTbx2.Multiline = True
        Me.DiffTbx2.Name = "DiffTbx2"
        Me.DiffTbx2.ReadOnly = True
        Me.DiffTbx2.Size = New System.Drawing.Size(141, 104)
        Me.DiffTbx2.TabIndex = 45
        Me.DiffTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiffTbx3
        '
        Me.DiffTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffTbx3.Location = New System.Drawing.Point(1110, 542)
        Me.DiffTbx3.Multiline = True
        Me.DiffTbx3.Name = "DiffTbx3"
        Me.DiffTbx3.ReadOnly = True
        Me.DiffTbx3.Size = New System.Drawing.Size(141, 102)
        Me.DiffTbx3.TabIndex = 46
        Me.DiffTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTbx1
        '
        Me.WeightTbx1.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx1.Location = New System.Drawing.Point(1249, 225)
        Me.WeightTbx1.MaxLength = 3
        Me.WeightTbx1.Multiline = True
        Me.WeightTbx1.Name = "WeightTbx1"
        Me.WeightTbx1.ReadOnly = True
        Me.WeightTbx1.Size = New System.Drawing.Size(83, 125)
        Me.WeightTbx1.TabIndex = 47
        Me.WeightTbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTbx2
        '
        Me.WeightTbx2.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx2.Location = New System.Drawing.Point(1249, 373)
        Me.WeightTbx2.MaxLength = 2
        Me.WeightTbx2.Multiline = True
        Me.WeightTbx2.Name = "WeightTbx2"
        Me.WeightTbx2.ReadOnly = True
        Me.WeightTbx2.Size = New System.Drawing.Size(83, 125)
        Me.WeightTbx2.TabIndex = 48
        Me.WeightTbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTbx3
        '
        Me.WeightTbx3.BackColor = System.Drawing.Color.MistyRose
        Me.WeightTbx3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTbx3.Location = New System.Drawing.Point(1249, 521)
        Me.WeightTbx3.MaxLength = 2
        Me.WeightTbx3.Multiline = True
        Me.WeightTbx3.Name = "WeightTbx3"
        Me.WeightTbx3.ReadOnly = True
        Me.WeightTbx3.Size = New System.Drawing.Size(83, 123)
        Me.WeightTbx3.TabIndex = 49
        Me.WeightTbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContentTbx2
        '
        Me.ContentTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx2.Location = New System.Drawing.Point(54, 373)
        Me.ContentTbx2.Multiline = True
        Me.ContentTbx2.Name = "ContentTbx2"
        Me.ContentTbx2.ReadOnly = True
        Me.ContentTbx2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentTbx2.Size = New System.Drawing.Size(1059, 125)
        Me.ContentTbx2.TabIndex = 50
        '
        'InputTargetFrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1350, 711)
        Me.Controls.Add(Me.ContentTbx2)
        Me.Controls.Add(Me.WeightTbx3)
        Me.Controls.Add(Me.WeightTbx2)
        Me.Controls.Add(Me.WeightTbx1)
        Me.Controls.Add(Me.DiffTbx3)
        Me.Controls.Add(Me.DiffTbx2)
        Me.Controls.Add(Me.DiffTbx1)
        Me.Controls.Add(Me.DiffComboBox3)
        Me.Controls.Add(Me.DiffComboBox2)
        Me.Controls.Add(Me.DiffComboBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DevPlanTbx)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ContentTbx3)
        Me.Controls.Add(Me.TitleTxb3)
        Me.Controls.Add(Me.TitleTbx2)
        Me.Controls.Add(Me.ContentTbx1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
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
        Me.Controls.Add(Me.TitleTbx1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleTbx1 As TextBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ContentTbx1 As TextBox
    Friend WithEvents TitleTbx2 As TextBox
    Friend WithEvents ContentTbx3 As TextBox
    Friend WithEvents TitleTxb3 As TextBox

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TitleTbx1.TextChanged
        If TitleTbx1.Text <> "" Then
            ContentTbx1.Enabled = True
            DiffComboBox1.Enabled = True
            WeightTbx1.Enabled = True
        End If
    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents DevPlanTbx As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents DiffComboBox1 As ComboBox
    Friend WithEvents DiffComboBox2 As ComboBox
    Friend WithEvents DiffComboBox3 As ComboBox
    Friend WithEvents DiffTbx1 As TextBox
    Friend WithEvents DiffTbx2 As TextBox
    Friend WithEvents DiffTbx3 As TextBox
    Friend WithEvents WeightTbx1 As TextBox
    Friend WithEvents WeightTbx2 As TextBox
    Friend WithEvents WeightTbx3 As TextBox
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
        Dim status As String
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
                Dim query_insert As String = "INSERT INTO targetdata (id, period, EmployeeID, Name, Dept, title, detail, Difficulty, Weight, title2, detail2, difficulty2, weight2, title3, detail3, difficulty3, weight3, devplan) VALUES (@id, @period, @EmployeeID, @Name, @Dept, @title, @detail, @Difficulty, @Weight, @title2, @detail2, @difficulty2, @weight2, @title3, @detail3, @difficulty3, @weight3, @devplan);"
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
                        Dim query As String = "UPDATE targetdata SET devplan= '" & devplan & "', title= '" & title1 & "', detail= '" & detail1 & "', weight = '" & weight1 & "', difficulty = '" & diff1 & "', status ='" & status & "' , title2= '" & title2 & "', detail2= '" & detail2 & "', weight2 = '" & weight2 & "', difficulty2 = '" & diff2 & "', title3= '" & title3 & "', detail3= '" & detail3 & "', weight3 = '" & weight3 & "', difficulty3 = '" & diff3 & "', time=now() WHERE employeeid = '" & username & "' AND period ='" & period & "'"
                        command = New MySqlCommand(query, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        Dim query_mail As String = "SELECT manager.email FROM manager INNER JOIN employee ON manager.employeeid = employee.app1 WHERE employee.employeeid ='" & username & "';"
                        command = New MySqlCommand(query_mail, conn)
                        reader = command.ExecuteReader
                        count = 0
                        While reader.Read
                            count = count + 1
                        End While
                        If count = 1 Then
                            Try
                                OutlookMessage = AppOutlook.CreateItem(outlook.OlItemType.olMailItem)
                                Dim Recipents As outlook.Recipients = OutlookMessage.Recipients
                                Dim address As String
                                address = reader("email").ToString
                                Recipents.Add(address)
                                OutlookMessage.Subject = "Target Submitted - Performance Management System."
                                OutlookMessage.Body = "Dear Manager, " & vbNewLine & " " & vbNewLine & "Your team member, " & name & " (Employee ID: " & username & ") submitted target on Performance Management System." & vbNewLine & "Please open the system, check it and have discussion with him/her." & vbNewLine & "" & vbNewLine & "*This message is automatically sent from system."
                                OutlookMessage.BodyFormat = outlook.OlBodyFormat.olFormatHTML
                                OutlookMessage.Send()
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

    Friend WithEvents ContentTbx2 As TextBox
    Friend WithEvents Statuslb As LinkLabel
End Class
