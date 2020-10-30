<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRFunctionsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRFunctionsFrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReviewResultBtn = New System.Windows.Forms.Button()
        Me.ExportDataBtn = New System.Windows.Forms.Button()
        Me.EmployeeMasterBtn = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DeptLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReleaseTargetBtn = New System.Windows.Forms.Button()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome Mr/Mrs: "
        '
        'ReviewResultBtn
        '
        Me.ReviewResultBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewResultBtn.Location = New System.Drawing.Point(245, 35)
        Me.ReviewResultBtn.Name = "ReviewResultBtn"
        Me.ReviewResultBtn.Size = New System.Drawing.Size(193, 55)
        Me.ReviewResultBtn.TabIndex = 5
        Me.ReviewResultBtn.Text = "Review Results"
        Me.ReviewResultBtn.UseVisualStyleBackColor = True
        '
        'ExportDataBtn
        '
        Me.ExportDataBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportDataBtn.Location = New System.Drawing.Point(16, 35)
        Me.ExportDataBtn.Name = "ExportDataBtn"
        Me.ExportDataBtn.Size = New System.Drawing.Size(193, 55)
        Me.ExportDataBtn.TabIndex = 6
        Me.ExportDataBtn.Text = "Export Data"
        Me.ExportDataBtn.UseVisualStyleBackColor = True
        '
        'EmployeeMasterBtn
        '
        Me.EmployeeMasterBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeMasterBtn.Location = New System.Drawing.Point(245, 113)
        Me.EmployeeMasterBtn.Name = "EmployeeMasterBtn"
        Me.EmployeeMasterBtn.Size = New System.Drawing.Size(193, 55)
        Me.EmployeeMasterBtn.TabIndex = 8
        Me.EmployeeMasterBtn.Text = "Employee Master"
        Me.EmployeeMasterBtn.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(142, 30)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(43, 16)
        Me.NameLabel.TabIndex = 9
        Me.NameLabel.Text = "Name"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EmployeeMasterBtn)
        Me.GroupBox1.Controls.Add(Me.ExportDataBtn)
        Me.GroupBox1.Controls.Add(Me.ReviewResultBtn)
        Me.GroupBox1.Controls.Add(Me.ReleaseTargetBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 181)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Functions"
        '
        'ReleaseTargetBtn
        '
        Me.ReleaseTargetBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReleaseTargetBtn.Location = New System.Drawing.Point(16, 113)
        Me.ReleaseTargetBtn.Name = "ReleaseTargetBtn"
        Me.ReleaseTargetBtn.Size = New System.Drawing.Size(193, 55)
        Me.ReleaseTargetBtn.TabIndex = 7
        Me.ReleaseTargetBtn.Text = "Release/Reset Status"
        Me.ReleaseTargetBtn.UseVisualStyleBackColor = True
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
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLabel.Location = New System.Drawing.Point(142, 65)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(43, 16)
        Me.IdLabel.TabIndex = 16
        Me.IdLabel.Text = "Name"
        Me.IdLabel.Visible = False
        '
        'HRFunctionsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.IdLabel)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.DeptLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HRFunctionsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR Functions"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ReviewResultBtn As Button
    Friend WithEvents ExportDataBtn As Button
    Friend WithEvents EmployeeMasterBtn As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents DeptLabel As Label
    Friend WithEvents GroupBox1 As GroupBox

    Friend WithEvents QuitBtn As Button
    Friend WithEvents ReleaseTargetBtn As Button
    Friend WithEvents IdLabel As Label
End Class
