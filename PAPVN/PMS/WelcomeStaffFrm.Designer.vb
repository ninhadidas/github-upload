<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeStaffFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeStaffFrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Button()
        Me.SelfAssessBtn = New System.Windows.Forms.Button()
        Me.ChangePwBtn = New System.Windows.Forms.Button()
        Me.OldPeriodBtn = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.EmployeeIdLabel = New System.Windows.Forms.Label()
        Me.DeptLabel = New System.Windows.Forms.Label()
        Me.DivLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PeriodCombox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome Mr/Mrs: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Division:"
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(16, 30)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(193, 55)
        Me.Login.TabIndex = 5
        Me.Login.Text = "Input Targets"
        Me.Login.UseVisualStyleBackColor = True
        '
        'SelfAssessBtn
        '
        Me.SelfAssessBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelfAssessBtn.Location = New System.Drawing.Point(245, 30)
        Me.SelfAssessBtn.Name = "SelfAssessBtn"
        Me.SelfAssessBtn.Size = New System.Drawing.Size(193, 55)
        Me.SelfAssessBtn.TabIndex = 6
        Me.SelfAssessBtn.Text = "Input Self-Assessment"
        Me.SelfAssessBtn.UseVisualStyleBackColor = True
        '
        'ChangePwBtn
        '
        Me.ChangePwBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePwBtn.Location = New System.Drawing.Point(16, 113)
        Me.ChangePwBtn.Name = "ChangePwBtn"
        Me.ChangePwBtn.Size = New System.Drawing.Size(193, 55)
        Me.ChangePwBtn.TabIndex = 7
        Me.ChangePwBtn.Text = "Change Password"
        Me.ChangePwBtn.UseVisualStyleBackColor = True
        '
        'OldPeriodBtn
        '
        Me.OldPeriodBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldPeriodBtn.Location = New System.Drawing.Point(245, 113)
        Me.OldPeriodBtn.Name = "OldPeriodBtn"
        Me.OldPeriodBtn.Size = New System.Drawing.Size(193, 55)
        Me.OldPeriodBtn.TabIndex = 8
        Me.OldPeriodBtn.Text = "Check Old Periods"
        Me.OldPeriodBtn.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(151, 30)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(77, 16)
        Me.NameLabel.TabIndex = 9
        Me.NameLabel.Text = "NameLabel"
        '
        'EmployeeIdLabel
        '
        Me.EmployeeIdLabel.AutoSize = True
        Me.EmployeeIdLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdLabel.Location = New System.Drawing.Point(123, 65)
        Me.EmployeeIdLabel.Name = "EmployeeIdLabel"
        Me.EmployeeIdLabel.Size = New System.Drawing.Size(116, 16)
        Me.EmployeeIdLabel.TabIndex = 10
        Me.EmployeeIdLabel.Text = "EmployeeIdLabel"
        '
        'DeptLabel
        '
        Me.DeptLabel.AutoSize = True
        Me.DeptLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptLabel.Location = New System.Drawing.Point(123, 100)
        Me.DeptLabel.Name = "DeptLabel"
        Me.DeptLabel.Size = New System.Drawing.Size(73, 16)
        Me.DeptLabel.TabIndex = 11
        Me.DeptLabel.Text = "DeptLabel"
        '
        'DivLabel
        '
        Me.DivLabel.AutoSize = True
        Me.DivLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivLabel.Location = New System.Drawing.Point(93, 135)
        Me.DivLabel.Name = "DivLabel"
        Me.DivLabel.Size = New System.Drawing.Size(62, 16)
        Me.DivLabel.TabIndex = 12
        Me.DivLabel.Text = "DivLabel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OldPeriodBtn)
        Me.GroupBox1.Controls.Add(Me.SelfAssessBtn)
        Me.GroupBox1.Controls.Add(Me.Login)
        Me.GroupBox1.Controls.Add(Me.ChangePwBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 181)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Functions"
        '
        'QuitBtn
        '
        Me.QuitBtn.BackColor = System.Drawing.Color.Red
        Me.QuitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBtn.ForeColor = System.Drawing.Color.White
        Me.QuitBtn.Location = New System.Drawing.Point(443, 3)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(23, 25)
        Me.QuitBtn.TabIndex = 16
        Me.QuitBtn.Text = "X"
        Me.QuitBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Period:"
        '
        'PeriodCombox
        '
        Me.PeriodCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodCombox.FormattingEnabled = True
        Me.PeriodCombox.Location = New System.Drawing.Point(89, 166)
        Me.PeriodCombox.Name = "PeriodCombox"
        Me.PeriodCombox.Size = New System.Drawing.Size(150, 24)
        Me.PeriodCombox.TabIndex = 18
        '
        'WelcomeStaffFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.PeriodCombox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.DivLabel)
        Me.Controls.Add(Me.DeptLabel)
        Me.Controls.Add(Me.EmployeeIdLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WelcomeStaffFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome!"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Login As Button
    Friend WithEvents SelfAssessBtn As Button
    Friend WithEvents ChangePwBtn As Button
    Friend WithEvents OldPeriodBtn As Button

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents EmployeeIdLabel As Label
    Friend WithEvents DeptLabel As Label
    Friend WithEvents DivLabel As Label
    Friend WithEvents GroupBox1 As GroupBox

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If PeriodCombox.Text = "" Then
            MessageBox.Show("Please select period!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            InputTargetFrm.Show()
            InputTargetFrm.NameLabel.Text = NameLabel.Text
            InputTargetFrm.EmployeeLabel.Text = EmployeeIdLabel.Text
            InputTargetFrm.DeptLabel.Text = DeptLabel.Text
            MessageBox.Show("To avoid system error, please DO NOT input single quote letter ' into any fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Friend WithEvents QuitBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PeriodCombox As ComboBox
End Class
