<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SBMS_BusInfoMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SBMS_BusInfoMaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DriverMobiNoTbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DriverNameTbx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BusNameTbx = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.BusID = New System.Windows.Forms.Label()
        Me.LocationCombox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BusTripRouteTbx = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BusModelTbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PlateNoTbx = New System.Windows.Forms.TextBox()
        Me.BusYearTbx = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BusCompanyTbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DriverMobiNoTbx2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DriverNameTbx2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LocationCombox2 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BusTripRouteTbx2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BusModelTbx2 = New System.Windows.Forms.TextBox()
        Me.PlateNoTbx2 = New System.Windows.Forms.TextBox()
        Me.BusYearTbx2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BusCompanyTbx2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.BusID2 = New System.Windows.Forms.Label()
        Me.BusNameCombox2 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(522, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "BUS MANAGEMENT SYSTEM - BUS INFO MASTER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DriverMobiNoTbx)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DriverNameTbx)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BusNameTbx)
        Me.GroupBox1.Controls.Add(Me.SubmitBtn)
        Me.GroupBox1.Controls.Add(Me.BusID)
        Me.GroupBox1.Controls.Add(Me.LocationCombox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.BusTripRouteTbx)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BusModelTbx)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PlateNoTbx)
        Me.GroupBox1.Controls.Add(Me.BusYearTbx)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BusCompanyTbx)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 206)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Bus"
        '
        'DriverMobiNoTbx
        '
        Me.DriverMobiNoTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DriverMobiNoTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriverMobiNoTbx.ForeColor = System.Drawing.Color.Navy
        Me.DriverMobiNoTbx.Location = New System.Drawing.Point(762, 74)
        Me.DriverMobiNoTbx.MaxLength = 10
        Me.DriverMobiNoTbx.Name = "DriverMobiNoTbx"
        Me.DriverMobiNoTbx.Size = New System.Drawing.Size(143, 23)
        Me.DriverMobiNoTbx.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(636, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Mobile No"
        '
        'DriverNameTbx
        '
        Me.DriverNameTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DriverNameTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriverNameTbx.ForeColor = System.Drawing.Color.Navy
        Me.DriverNameTbx.Location = New System.Drawing.Point(762, 31)
        Me.DriverNameTbx.Name = "DriverNameTbx"
        Me.DriverNameTbx.Size = New System.Drawing.Size(143, 23)
        Me.DriverNameTbx.TabIndex = 75
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(635, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Driver's Name"
        '
        'BusNameTbx
        '
        Me.BusNameTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusNameTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusNameTbx.ForeColor = System.Drawing.Color.Navy
        Me.BusNameTbx.Location = New System.Drawing.Point(101, 31)
        Me.BusNameTbx.MaxLength = 10
        Me.BusNameTbx.Name = "BusNameTbx"
        Me.BusNameTbx.Size = New System.Drawing.Size(124, 23)
        Me.BusNameTbx.TabIndex = 72
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.Color.Green
        Me.SubmitBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitBtn.Location = New System.Drawing.Point(398, 166)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(152, 34)
        Me.SubmitBtn.TabIndex = 41
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'BusID
        '
        Me.BusID.AutoSize = True
        Me.BusID.Location = New System.Drawing.Point(1014, 114)
        Me.BusID.Name = "BusID"
        Me.BusID.Size = New System.Drawing.Size(97, 13)
        Me.BusID.TabIndex = 71
        Me.BusID.Text = "fdbvfgbgfbgfbgf"
        '
        'LocationCombox
        '
        Me.LocationCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocationCombox.ForeColor = System.Drawing.Color.Navy
        Me.LocationCombox.FormattingEnabled = True
        Me.LocationCombox.Items.AddRange(New Object() {"TL1", "TL2"})
        Me.LocationCombox.Location = New System.Drawing.Point(549, 35)
        Me.LocationCombox.Name = "LocationCombox"
        Me.LocationCombox.Size = New System.Drawing.Size(62, 21)
        Me.LocationCombox.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(479, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Location"
        '
        'BusTripRouteTbx
        '
        Me.BusTripRouteTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusTripRouteTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusTripRouteTbx.ForeColor = System.Drawing.Color.Navy
        Me.BusTripRouteTbx.Location = New System.Drawing.Point(385, 117)
        Me.BusTripRouteTbx.Name = "BusTripRouteTbx"
        Me.BusTripRouteTbx.Size = New System.Drawing.Size(226, 23)
        Me.BusTripRouteTbx.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Bus Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Bus Model"
        '
        'BusModelTbx
        '
        Me.BusModelTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusModelTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusModelTbx.ForeColor = System.Drawing.Color.Navy
        Me.BusModelTbx.Location = New System.Drawing.Point(101, 116)
        Me.BusModelTbx.MaxLength = 30
        Me.BusModelTbx.Name = "BusModelTbx"
        Me.BusModelTbx.Size = New System.Drawing.Size(124, 23)
        Me.BusModelTbx.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Trip Route"
        '
        'PlateNoTbx
        '
        Me.PlateNoTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PlateNoTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNoTbx.ForeColor = System.Drawing.Color.Navy
        Me.PlateNoTbx.Location = New System.Drawing.Point(101, 75)
        Me.PlateNoTbx.MaxLength = 15
        Me.PlateNoTbx.Name = "PlateNoTbx"
        Me.PlateNoTbx.Size = New System.Drawing.Size(124, 23)
        Me.PlateNoTbx.TabIndex = 40
        '
        'BusYearTbx
        '
        Me.BusYearTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusYearTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusYearTbx.ForeColor = System.Drawing.Color.Navy
        Me.BusYearTbx.Location = New System.Drawing.Point(385, 31)
        Me.BusYearTbx.MaxLength = 4
        Me.BusYearTbx.Name = "BusYearTbx"
        Me.BusYearTbx.Size = New System.Drawing.Size(80, 23)
        Me.BusYearTbx.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(259, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Model Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Plate No"
        '
        'BusCompanyTbx
        '
        Me.BusCompanyTbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusCompanyTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusCompanyTbx.ForeColor = System.Drawing.Color.Navy
        Me.BusCompanyTbx.Location = New System.Drawing.Point(385, 74)
        Me.BusCompanyTbx.Name = "BusCompanyTbx"
        Me.BusCompanyTbx.Size = New System.Drawing.Size(226, 23)
        Me.BusCompanyTbx.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(258, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Company"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.DriverMobiNoTbx2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DriverNameTbx2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LocationCombox2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.BusTripRouteTbx2)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.BusModelTbx2)
        Me.GroupBox2.Controls.Add(Me.PlateNoTbx2)
        Me.GroupBox2.Controls.Add(Me.BusYearTbx2)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.BusCompanyTbx2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.DeleteBtn)
        Me.GroupBox2.Controls.Add(Me.UpdateBtn)
        Me.GroupBox2.Controls.Add(Me.BusID2)
        Me.GroupBox2.Controls.Add(Me.BusNameCombox2)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(921, 206)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Update/Delete Bus"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(258, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 16)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Trip Route"
        '
        'DriverMobiNoTbx2
        '
        Me.DriverMobiNoTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DriverMobiNoTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriverMobiNoTbx2.ForeColor = System.Drawing.Color.Navy
        Me.DriverMobiNoTbx2.Location = New System.Drawing.Point(762, 73)
        Me.DriverMobiNoTbx2.Name = "DriverMobiNoTbx2"
        Me.DriverMobiNoTbx2.Size = New System.Drawing.Size(143, 23)
        Me.DriverMobiNoTbx2.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(636, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Mobile No"
        '
        'DriverNameTbx2
        '
        Me.DriverNameTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DriverNameTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriverNameTbx2.ForeColor = System.Drawing.Color.Navy
        Me.DriverNameTbx2.Location = New System.Drawing.Point(762, 30)
        Me.DriverNameTbx2.Name = "DriverNameTbx2"
        Me.DriverNameTbx2.Size = New System.Drawing.Size(143, 23)
        Me.DriverNameTbx2.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(635, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Driver's Name"
        '
        'LocationCombox2
        '
        Me.LocationCombox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocationCombox2.ForeColor = System.Drawing.Color.Navy
        Me.LocationCombox2.FormattingEnabled = True
        Me.LocationCombox2.Items.AddRange(New Object() {"TL1", "TL2"})
        Me.LocationCombox2.Location = New System.Drawing.Point(549, 32)
        Me.LocationCombox2.Name = "LocationCombox2"
        Me.LocationCombox2.Size = New System.Drawing.Size(62, 21)
        Me.LocationCombox2.TabIndex = 89
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(479, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 16)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Location"
        '
        'BusTripRouteTbx2
        '
        Me.BusTripRouteTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusTripRouteTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusTripRouteTbx2.ForeColor = System.Drawing.Color.Navy
        Me.BusTripRouteTbx2.Location = New System.Drawing.Point(385, 116)
        Me.BusTripRouteTbx2.Name = "BusTripRouteTbx2"
        Me.BusTripRouteTbx2.Size = New System.Drawing.Size(226, 23)
        Me.BusTripRouteTbx2.TabIndex = 87
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 16)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Bus Model"
        '
        'BusModelTbx2
        '
        Me.BusModelTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusModelTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusModelTbx2.ForeColor = System.Drawing.Color.Navy
        Me.BusModelTbx2.Location = New System.Drawing.Point(101, 115)
        Me.BusModelTbx2.MaxLength = 20
        Me.BusModelTbx2.Name = "BusModelTbx2"
        Me.BusModelTbx2.Size = New System.Drawing.Size(124, 23)
        Me.BusModelTbx2.TabIndex = 85
        '
        'PlateNoTbx2
        '
        Me.PlateNoTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PlateNoTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNoTbx2.ForeColor = System.Drawing.Color.Navy
        Me.PlateNoTbx2.Location = New System.Drawing.Point(101, 74)
        Me.PlateNoTbx2.MaxLength = 15
        Me.PlateNoTbx2.Name = "PlateNoTbx2"
        Me.PlateNoTbx2.Size = New System.Drawing.Size(124, 23)
        Me.PlateNoTbx2.TabIndex = 83
        '
        'BusYearTbx2
        '
        Me.BusYearTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusYearTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusYearTbx2.ForeColor = System.Drawing.Color.Navy
        Me.BusYearTbx2.Location = New System.Drawing.Point(385, 30)
        Me.BusYearTbx2.MaxLength = 4
        Me.BusYearTbx2.Name = "BusYearTbx2"
        Me.BusYearTbx2.Size = New System.Drawing.Size(80, 23)
        Me.BusYearTbx2.TabIndex = 82
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(259, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Model Year"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 16)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Plate No"
        '
        'BusCompanyTbx2
        '
        Me.BusCompanyTbx2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.BusCompanyTbx2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.BusCompanyTbx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BusCompanyTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusCompanyTbx2.ForeColor = System.Drawing.Color.Navy
        Me.BusCompanyTbx2.Location = New System.Drawing.Point(385, 73)
        Me.BusCompanyTbx2.Name = "BusCompanyTbx2"
        Me.BusCompanyTbx2.Size = New System.Drawing.Size(226, 23)
        Me.BusCompanyTbx2.TabIndex = 80
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(258, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 16)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "Company"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Red
        Me.DeleteBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(612, 157)
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
        Me.UpdateBtn.Location = New System.Drawing.Point(204, 157)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(152, 34)
        Me.UpdateBtn.TabIndex = 41
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'BusID2
        '
        Me.BusID2.AutoSize = True
        Me.BusID2.Location = New System.Drawing.Point(1014, 114)
        Me.BusID2.Name = "BusID2"
        Me.BusID2.Size = New System.Drawing.Size(76, 13)
        Me.BusID2.TabIndex = 71
        Me.BusID2.Text = "fdgfdgfhfhfg"
        '
        'BusNameCombox2
        '
        Me.BusNameCombox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BusNameCombox2.ForeColor = System.Drawing.Color.Navy
        Me.BusNameCombox2.FormattingEnabled = True
        Me.BusNameCombox2.Location = New System.Drawing.Point(101, 34)
        Me.BusNameCombox2.Name = "BusNameCombox2"
        Me.BusNameCombox2.Size = New System.Drawing.Size(124, 21)
        Me.BusNameCombox2.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Bus Name"
        '
        'SBMS_BusInfoMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SBMS_BusInfoMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Master Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BusTripRouteTbx As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BusModelTbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PlateNoTbx As TextBox
    Friend WithEvents BusYearTbx As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BusCompanyTbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents BusID As Label
    Friend WithEvents LocationCombox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents BusID2 As Label
    Friend WithEvents BusNameCombox2 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents BusNameTbx As TextBox
    Friend WithEvents DriverMobiNoTbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DriverNameTbx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DriverMobiNoTbx2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DriverNameTbx2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LocationCombox2 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BusTripRouteTbx2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BusModelTbx2 As TextBox
    Friend WithEvents PlateNoTbx2 As TextBox
    Friend WithEvents BusYearTbx2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BusCompanyTbx2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label14 As Label
End Class
