<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMS_RehireEmployee
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
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(270, 48)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "* Set 0 if employee is not the Approver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "** Set 0 if employee has no Approver 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Default password for new employee is blank"
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.Color.Green
        Me.SubmitBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitBtn.Location = New System.Drawing.Point(368, 248)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(84, 34)
        Me.SubmitBtn.TabIndex = 60
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 16)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Is Approver?*"
        '
        'DivCombox
        '
        Me.DivCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.DivCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.DivCombox.FormattingEnabled = True
        Me.DivCombox.Items.AddRange(New Object() {"Administration", "Refrigerator", "ARBU", "AP Marketing", "AWBU", "R&D", "Washing Machine", "WM Procurement"})
        Me.DivCombox.Location = New System.Drawing.Point(128, 76)
        Me.DivCombox.Name = "DivCombox"
        Me.DivCombox.Size = New System.Drawing.Size(176, 24)
        Me.DivCombox.TabIndex = 45
        '
        'IsApprove
        '
        Me.IsApprove.BackColor = System.Drawing.Color.LemonChiffon
        Me.IsApprove.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsApprove.ForeColor = System.Drawing.Color.MediumBlue
        Me.IsApprove.FormattingEnabled = True
        Me.IsApprove.Items.AddRange(New Object() {"0", "1"})
        Me.IsApprove.Location = New System.Drawing.Point(128, 29)
        Me.IsApprove.Name = "IsApprove"
        Me.IsApprove.Size = New System.Drawing.Size(74, 24)
        Me.IsApprove.TabIndex = 59
        '
        'NameTbx
        '
        Me.NameTbx.BackColor = System.Drawing.Color.Silver
        Me.NameTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.NameTbx.Location = New System.Drawing.Point(508, 29)
        Me.NameTbx.Name = "NameTbx"
        Me.NameTbx.ReadOnly = True
        Me.NameTbx.Size = New System.Drawing.Size(269, 23)
        Me.NameTbx.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Employee ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(430, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Full Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(414, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Department:"
        '
        'App2Tbx
        '
        Me.App2Tbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.App2Tbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App2Tbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App2Tbx.Location = New System.Drawing.Point(378, 169)
        Me.App2Tbx.Name = "App2Tbx"
        Me.App2Tbx.Size = New System.Drawing.Size(74, 23)
        Me.App2Tbx.TabIndex = 55
        Me.App2Tbx.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Division:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(282, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 16)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Approver 2*:"
        '
        'EmployeeTbx
        '
        Me.EmployeeTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.EmployeeTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.EmployeeTbx.Location = New System.Drawing.Point(323, 29)
        Me.EmployeeTbx.Name = "EmployeeTbx"
        Me.EmployeeTbx.Size = New System.Drawing.Size(74, 23)
        Me.EmployeeTbx.TabIndex = 43
        '
        'App1Tbx
        '
        Me.App1Tbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.App1Tbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.App1Tbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.App1Tbx.Location = New System.Drawing.Point(128, 169)
        Me.App1Tbx.Name = "App1Tbx"
        Me.App1Tbx.Size = New System.Drawing.Size(74, 23)
        Me.App1Tbx.TabIndex = 53
        '
        'DeptCombox
        '
        Me.DeptCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.DeptCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.DeptCombox.FormattingEnabled = True
        Me.DeptCombox.Location = New System.Drawing.Point(508, 71)
        Me.DeptCombox.Name = "DeptCombox"
        Me.DeptCombox.Size = New System.Drawing.Size(145, 24)
        Me.DeptCombox.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Approver 1*:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Location:"
        '
        'EmailTbx
        '
        Me.EmailTbx.BackColor = System.Drawing.Color.LemonChiffon
        Me.EmailTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTbx.ForeColor = System.Drawing.Color.MediumBlue
        Me.EmailTbx.Location = New System.Drawing.Point(128, 123)
        Me.EmailTbx.Name = "EmailTbx"
        Me.EmailTbx.Size = New System.Drawing.Size(395, 23)
        Me.EmailTbx.TabIndex = 51
        '
        'LocationCombox
        '
        Me.LocationCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.LocationCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.LocationCombox.FormattingEnabled = True
        Me.LocationCombox.Items.AddRange(New Object() {"TL1", "TL2"})
        Me.LocationCombox.Location = New System.Drawing.Point(618, 168)
        Me.LocationCombox.Name = "LocationCombox"
        Me.LocationCombox.Size = New System.Drawing.Size(49, 24)
        Me.LocationCombox.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Position:"
        '
        'PositionCombox
        '
        Me.PositionCombox.BackColor = System.Drawing.Color.LemonChiffon
        Me.PositionCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionCombox.ForeColor = System.Drawing.Color.MediumBlue
        Me.PositionCombox.FormattingEnabled = True
        Me.PositionCombox.Location = New System.Drawing.Point(618, 123)
        Me.PositionCombox.Name = "PositionCombox"
        Me.PositionCombox.Size = New System.Drawing.Size(158, 24)
        Me.PositionCombox.TabIndex = 49
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel.Location = New System.Drawing.Point(686, 79)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(22, 16)
        Me.IDLabel.TabIndex = 62
        Me.IDLabel.Text = "ID"
        Me.IDLabel.Visible = False
        '
        'PMS_RehireEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 294)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DivCombox)
        Me.Controls.Add(Me.IsApprove)
        Me.Controls.Add(Me.NameTbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.App2Tbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EmployeeTbx)
        Me.Controls.Add(Me.App1Tbx)
        Me.Controls.Add(Me.DeptCombox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmailTbx)
        Me.Controls.Add(Me.LocationCombox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PositionCombox)
        Me.Name = "PMS_RehireEmployee"
        Me.Text = "Rehire Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DivCombox As ComboBox
    Friend WithEvents IsApprove As ComboBox
    Friend WithEvents NameTbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents App2Tbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EmployeeTbx As TextBox
    Friend WithEvents App1Tbx As TextBox
    Friend WithEvents DeptCombox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailTbx As TextBox
    Friend WithEvents LocationCombox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PositionCombox As ComboBox
    Friend WithEvents IDLabel As Label
End Class
