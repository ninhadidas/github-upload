<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SBMS_MngView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SBMS_MngView))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmployeeIDTbx = New System.Windows.Forms.TextBox()
        Me.MobileTbx = New System.Windows.Forms.TextBox()
        Me.NameTbx = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ApproveBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RejectBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MngCm_Tbx = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComebackTimeTbx = New System.Windows.Forms.TextBox()
        Me.PickUpTimeTbx = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ContentTbx = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NoteTbx = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.AssetTbx = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ArrivalTbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepatureTbx = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AttachedGridPerson = New System.Windows.Forms.DataGridView()
        Me.Id_Label = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.GoBackTbx = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.AttachedGridPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.EmployeeIDTbx)
        Me.GroupBox1.Controls.Add(Me.MobileTbx)
        Me.GroupBox1.Controls.Add(Me.NameTbx)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.EmailTbx)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 108)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requester's Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Employee ID *"
        '
        'EmployeeIDTbx
        '
        Me.EmployeeIDTbx.BackColor = System.Drawing.Color.Silver
        Me.EmployeeIDTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.EmployeeIDTbx.Location = New System.Drawing.Point(111, 31)
        Me.EmployeeIDTbx.Name = "EmployeeIDTbx"
        Me.EmployeeIDTbx.ReadOnly = True
        Me.EmployeeIDTbx.Size = New System.Drawing.Size(170, 23)
        Me.EmployeeIDTbx.TabIndex = 58
        '
        'MobileTbx
        '
        Me.MobileTbx.BackColor = System.Drawing.Color.Silver
        Me.MobileTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.MobileTbx.Location = New System.Drawing.Point(111, 72)
        Me.MobileTbx.Name = "MobileTbx"
        Me.MobileTbx.ReadOnly = True
        Me.MobileTbx.Size = New System.Drawing.Size(170, 23)
        Me.MobileTbx.TabIndex = 40
        '
        'NameTbx
        '
        Me.NameTbx.BackColor = System.Drawing.Color.Silver
        Me.NameTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.NameTbx.Location = New System.Drawing.Point(374, 31)
        Me.NameTbx.Name = "NameTbx"
        Me.NameTbx.ReadOnly = True
        Me.NameTbx.Size = New System.Drawing.Size(322, 23)
        Me.NameTbx.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(303, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Full Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mobile No:"
        '
        'EmailTbx
        '
        Me.EmailTbx.BackColor = System.Drawing.Color.Silver
        Me.EmailTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.EmailTbx.Location = New System.Drawing.Point(374, 72)
        Me.EmailTbx.Name = "EmailTbx"
        Me.EmailTbx.ReadOnly = True
        Me.EmailTbx.Size = New System.Drawing.Size(322, 23)
        Me.EmailTbx.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(303, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Email:"
        '
        'ApproveBtn
        '
        Me.ApproveBtn.BackColor = System.Drawing.Color.Green
        Me.ApproveBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApproveBtn.ForeColor = System.Drawing.Color.White
        Me.ApproveBtn.Location = New System.Drawing.Point(19, 600)
        Me.ApproveBtn.Name = "ApproveBtn"
        Me.ApproveBtn.Size = New System.Drawing.Size(152, 34)
        Me.ApproveBtn.TabIndex = 38
        Me.ApproveBtn.Text = "Approve"
        Me.ApproveBtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(212, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(289, 25)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "BUS REQUEST FORM - ID: "
        '
        'RejectBtn
        '
        Me.RejectBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RejectBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RejectBtn.ForeColor = System.Drawing.Color.White
        Me.RejectBtn.Location = New System.Drawing.Point(308, 600)
        Me.RejectBtn.Name = "RejectBtn"
        Me.RejectBtn.Size = New System.Drawing.Size(152, 34)
        Me.RejectBtn.TabIndex = 39
        Me.RejectBtn.Text = "Send Back"
        Me.RejectBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MngCm_Tbx)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 419)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 60)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manager's comment"
        '
        'MngCm_Tbx
        '
        Me.MngCm_Tbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.MngCm_Tbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngCm_Tbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.MngCm_Tbx.Location = New System.Drawing.Point(7, 21)
        Me.MngCm_Tbx.Multiline = True
        Me.MngCm_Tbx.Name = "MngCm_Tbx"
        Me.MngCm_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MngCm_Tbx.Size = New System.Drawing.Size(687, 33)
        Me.MngCm_Tbx.TabIndex = 57
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.GoBackTbx)
        Me.GroupBox2.Controls.Add(Me.ComebackTimeTbx)
        Me.GroupBox2.Controls.Add(Me.PickUpTimeTbx)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.ContentTbx)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.NoteTbx)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.AssetTbx)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ArrivalTbx)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DepatureTbx)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 303)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trip's Information"
        '
        'ComebackTimeTbx
        '
        Me.ComebackTimeTbx.BackColor = System.Drawing.Color.Silver
        Me.ComebackTimeTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComebackTimeTbx.Location = New System.Drawing.Point(7, 271)
        Me.ComebackTimeTbx.Name = "ComebackTimeTbx"
        Me.ComebackTimeTbx.ReadOnly = True
        Me.ComebackTimeTbx.Size = New System.Drawing.Size(263, 23)
        Me.ComebackTimeTbx.TabIndex = 80
        '
        'PickUpTimeTbx
        '
        Me.PickUpTimeTbx.BackColor = System.Drawing.Color.Silver
        Me.PickUpTimeTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUpTimeTbx.Location = New System.Drawing.Point(305, 47)
        Me.PickUpTimeTbx.Name = "PickUpTimeTbx"
        Me.PickUpTimeTbx.ReadOnly = True
        Me.PickUpTimeTbx.Size = New System.Drawing.Size(154, 23)
        Me.PickUpTimeTbx.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(502, 274)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 16)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "Số Người Về Cùng"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 248)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(264, 16)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "Comeback Start Time (Giờ Bắt Đầu Về)*"
        '
        'ContentTbx
        '
        Me.ContentTbx.BackColor = System.Drawing.Color.Silver
        Me.ContentTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.ContentTbx.Location = New System.Drawing.Point(7, 153)
        Me.ContentTbx.Name = "ContentTbx"
        Me.ContentTbx.ReadOnly = True
        Me.ContentTbx.Size = New System.Drawing.Size(687, 23)
        Me.ContentTbx.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(190, 16)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Purpose (Nội Dung Đặt Xe)*"
        '
        'NoteTbx
        '
        Me.NoteTbx.BackColor = System.Drawing.Color.Silver
        Me.NoteTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.NoteTbx.Location = New System.Drawing.Point(304, 99)
        Me.NoteTbx.Name = "NoteTbx"
        Me.NoteTbx.ReadOnly = True
        Me.NoteTbx.Size = New System.Drawing.Size(390, 23)
        Me.NoteTbx.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(495, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(162, 32)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "List of Attached Person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Xem DS Người Đi Cùng)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(301, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(159, 16)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "Pickup Time (Giờ Đón) *"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(301, 80)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(101, 16)
        Me.Label28.TabIndex = 71
        Me.Label28.Text = "Note (Ghi Chú)"
        '
        'AssetTbx
        '
        Me.AssetTbx.BackColor = System.Drawing.Color.Silver
        Me.AssetTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssetTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.AssetTbx.Location = New System.Drawing.Point(6, 99)
        Me.AssetTbx.Name = "AssetTbx"
        Me.AssetTbx.ReadOnly = True
        Me.AssetTbx.Size = New System.Drawing.Size(273, 23)
        Me.AssetTbx.TabIndex = 70
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(4, 80)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(270, 16)
        Me.Label27.TabIndex = 69
        Me.Label27.Text = "Asset bring out (Tài Sản Mang Ra Ngoài)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Arrival Location (Địa Điểm Cần Đi)*"
        '
        'ArrivalTbx
        '
        Me.ArrivalTbx.BackColor = System.Drawing.Color.Silver
        Me.ArrivalTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrivalTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.ArrivalTbx.Location = New System.Drawing.Point(6, 211)
        Me.ArrivalTbx.Name = "ArrivalTbx"
        Me.ArrivalTbx.ReadOnly = True
        Me.ArrivalTbx.Size = New System.Drawing.Size(688, 23)
        Me.ArrivalTbx.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Departure Location (Địa Điểm Đón Xe)*"
        '
        'DepatureTbx
        '
        Me.DepatureTbx.BackColor = System.Drawing.Color.Silver
        Me.DepatureTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepatureTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.DepatureTbx.Location = New System.Drawing.Point(7, 47)
        Me.DepatureTbx.Name = "DepatureTbx"
        Me.DepatureTbx.ReadOnly = True
        Me.DepatureTbx.Size = New System.Drawing.Size(272, 23)
        Me.DepatureTbx.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(726, 513)
        Me.TabControl1.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(718, 487)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.AttachedGridPerson)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(718, 487)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Attached Person"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(173, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(336, 16)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Attached person (Danh sách những người đi cùng)"
        '
        'AttachedGridPerson
        '
        Me.AttachedGridPerson.AllowUserToAddRows = False
        Me.AttachedGridPerson.AllowUserToDeleteRows = False
        Me.AttachedGridPerson.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttachedGridPerson.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AttachedGridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttachedGridPerson.DefaultCellStyle = DataGridViewCellStyle2
        Me.AttachedGridPerson.Location = New System.Drawing.Point(31, 48)
        Me.AttachedGridPerson.Name = "AttachedGridPerson"
        Me.AttachedGridPerson.ReadOnly = True
        Me.AttachedGridPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AttachedGridPerson.Size = New System.Drawing.Size(656, 425)
        Me.AttachedGridPerson.TabIndex = 2
        '
        'Id_Label
        '
        Me.Id_Label.AutoSize = True
        Me.Id_Label.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_Label.ForeColor = System.Drawing.Color.Navy
        Me.Id_Label.Location = New System.Drawing.Point(486, 53)
        Me.Id_Label.Name = "Id_Label"
        Me.Id_Label.Size = New System.Drawing.Size(64, 25)
        Me.Id_Label.TabIndex = 43
        Me.Id_Label.Text = "1234"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Red
        Me.DeleteBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(578, 600)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(152, 34)
        Me.DeleteBtn.TabIndex = 44
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'GoBackTbx
        '
        Me.GoBackTbx.BackColor = System.Drawing.Color.Silver
        Me.GoBackTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackTbx.Location = New System.Drawing.Point(639, 267)
        Me.GoBackTbx.Name = "GoBackTbx"
        Me.GoBackTbx.ReadOnly = True
        Me.GoBackTbx.Size = New System.Drawing.Size(55, 23)
        Me.GoBackTbx.TabIndex = 81
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(658, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 82
        Me.PictureBox2.TabStop = False
        '
        'SBMS_MngView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 637)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.Id_Label)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.RejectBtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ApproveBtn)
        Me.MaximizeBox = False
        Me.Name = "SBMS_MngView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Request Form - Manager View"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AttachedGridPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NameTbx As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EmailTbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ApproveBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents EmployeeIDTbx As TextBox
    Friend WithEvents MobileTbx As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RejectBtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MngCm_Tbx As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents ContentTbx As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents NoteTbx As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents AssetTbx As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ArrivalTbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DepatureTbx As TextBox
    Friend WithEvents ComebackTimeTbx As TextBox
    Friend WithEvents PickUpTimeTbx As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Id_Label As Label
    Friend WithEvents AttachedGridPerson As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GoBackTbx As TextBox
End Class
