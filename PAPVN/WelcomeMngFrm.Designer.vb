<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeMngFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeMngFrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReviewTargetBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChangePwBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.EmployeeIdLabel = New System.Windows.Forms.Label()
        Me.DeptLabel = New System.Windows.Forms.Label()
        Me.DivLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PeriodLabel = New System.Windows.Forms.Label()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.PeriodCombox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        'ReviewTargetBtn
        '
        Me.ReviewTargetBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewTargetBtn.Location = New System.Drawing.Point(16, 30)
        Me.ReviewTargetBtn.Name = "ReviewTargetBtn"
        Me.ReviewTargetBtn.Size = New System.Drawing.Size(193, 55)
        Me.ReviewTargetBtn.TabIndex = 5
        Me.ReviewTargetBtn.Text = "Review Targets"
        Me.ReviewTargetBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(245, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 55)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "View Report"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(245, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 55)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Check Old Periods"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(159, 30)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(0, 16)
        Me.NameLabel.TabIndex = 9
        '
        'EmployeeIdLabel
        '
        Me.EmployeeIdLabel.AutoSize = True
        Me.EmployeeIdLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdLabel.Location = New System.Drawing.Point(123, 65)
        Me.EmployeeIdLabel.Name = "EmployeeIdLabel"
        Me.EmployeeIdLabel.Size = New System.Drawing.Size(70, 16)
        Me.EmployeeIdLabel.TabIndex = 10
        Me.EmployeeIdLabel.Text = "employee"
        '
        'DeptLabel
        '
        Me.DeptLabel.AutoSize = True
        Me.DeptLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptLabel.Location = New System.Drawing.Point(123, 100)
        Me.DeptLabel.Name = "DeptLabel"
        Me.DeptLabel.Size = New System.Drawing.Size(0, 16)
        Me.DeptLabel.TabIndex = 11
        '
        'DivLabel
        '
        Me.DivLabel.AutoSize = True
        Me.DivLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivLabel.Location = New System.Drawing.Point(93, 135)
        Me.DivLabel.Name = "DivLabel"
        Me.DivLabel.Size = New System.Drawing.Size(0, 16)
        Me.DivLabel.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ReviewTargetBtn)
        Me.GroupBox1.Controls.Add(Me.ChangePwBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 181)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Functions"
        '
        'PeriodLabel
        '
        Me.PeriodLabel.AutoSize = True
        Me.PeriodLabel.Location = New System.Drawing.Point(361, 148)
        Me.PeriodLabel.Name = "PeriodLabel"
        Me.PeriodLabel.Size = New System.Drawing.Size(37, 13)
        Me.PeriodLabel.TabIndex = 14
        Me.PeriodLabel.Text = "Period"
        Me.PeriodLabel.Visible = False
        '
        'QuitBtn
        '
        Me.QuitBtn.BackColor = System.Drawing.Color.Red
        Me.QuitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBtn.ForeColor = System.Drawing.Color.White
        Me.QuitBtn.Location = New System.Drawing.Point(443, 3)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(23, 25)
        Me.QuitBtn.TabIndex = 15
        Me.QuitBtn.Text = "X"
        Me.QuitBtn.UseVisualStyleBackColor = False
        '
        'PeriodCombox
        '
        Me.PeriodCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodCombox.FormattingEnabled = True
        Me.PeriodCombox.Location = New System.Drawing.Point(89, 164)
        Me.PeriodCombox.Name = "PeriodCombox"
        Me.PeriodCombox.Size = New System.Drawing.Size(150, 24)
        Me.PeriodCombox.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Period:"
        '
        'WelcomeMngFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.PeriodCombox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.PeriodLabel)
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
        Me.Name = "WelcomeMngFrm"
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
    Friend WithEvents ReviewTargetBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ChangePwBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents EmployeeIdLabel As Label
    Friend WithEvents DeptLabel As Label
    Friend WithEvents DivLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PeriodLabel As Label
    Friend WithEvents QuitBtn As Button
    Friend WithEvents PeriodCombox As ComboBox
    Friend WithEvents Label5 As Label
End Class
