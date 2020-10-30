<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReleaseStatusFrm
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
        Me.PeriodLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeGrid = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDTbx = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NewStatusCombx = New System.Windows.Forms.ComboBox()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.StatusId = New System.Windows.Forms.Label()
        CType(Me.EmployeeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PeriodLabel
        '
        Me.PeriodLabel.AutoSize = True
        Me.PeriodLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PeriodLabel.Location = New System.Drawing.Point(78, 23)
        Me.PeriodLabel.Name = "PeriodLabel"
        Me.PeriodLabel.Size = New System.Drawing.Size(60, 16)
        Me.PeriodLabel.TabIndex = 32
        Me.PeriodLabel.Text = "PERIOD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "PERIOD:"
        '
        'EmployeeGrid
        '
        Me.EmployeeGrid.AllowUserToAddRows = False
        Me.EmployeeGrid.AllowUserToDeleteRows = False
        Me.EmployeeGrid.AllowUserToOrderColumns = True
        Me.EmployeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeGrid.Location = New System.Drawing.Point(15, 140)
        Me.EmployeeGrid.Name = "EmployeeGrid"
        Me.EmployeeGrid.ReadOnly = True
        Me.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeGrid.Size = New System.Drawing.Size(740, 77)
        Me.EmployeeGrid.TabIndex = 34
        '
        'EmployeeIDTbx
        '
        Me.EmployeeIDTbx.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTbx.Location = New System.Drawing.Point(149, 59)
        Me.EmployeeIDTbx.Name = "EmployeeIDTbx"
        Me.EmployeeIDTbx.Size = New System.Drawing.Size(121, 26)
        Me.EmployeeIDTbx.TabIndex = 35
        '
        'SearchBtn
        '
        Me.SearchBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(311, 58)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(83, 29)
        Me.SearchBtn.TabIndex = 36
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        Me.SearchBtn.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Input Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Employee Found:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Set new status to:"
        '
        'NewStatusCombx
        '
        Me.NewStatusCombx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewStatusCombx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewStatusCombx.FormattingEnabled = True
        Me.NewStatusCombx.Location = New System.Drawing.Point(149, 238)
        Me.NewStatusCombx.Name = "NewStatusCombx"
        Me.NewStatusCombx.Size = New System.Drawing.Size(485, 24)
        Me.NewStatusCombx.TabIndex = 40
        '
        'SetBtn
        '
        Me.SetBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetBtn.Location = New System.Drawing.Point(672, 235)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(83, 29)
        Me.SetBtn.TabIndex = 41
        Me.SetBtn.Text = "Set"
        Me.SetBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(518, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Current Status:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.Blue
        Me.StatusLabel.Location = New System.Drawing.Point(634, 110)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 16)
        Me.StatusLabel.TabIndex = 43
        '
        'StatusId
        '
        Me.StatusId.AutoSize = True
        Me.StatusId.Location = New System.Drawing.Point(588, 23)
        Me.StatusId.Name = "StatusId"
        Me.StatusId.Size = New System.Drawing.Size(43, 13)
        Me.StatusId.TabIndex = 44
        Me.StatusId.Text = "statusid"
        Me.StatusId.Visible = False
        '
        'ReleaseStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 312)
        Me.Controls.Add(Me.StatusId)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.NewStatusCombx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.EmployeeIDTbx)
        Me.Controls.Add(Me.EmployeeGrid)
        Me.Controls.Add(Me.PeriodLabel)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ReleaseStatusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Release/Reset Status"
        CType(Me.EmployeeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PeriodLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmployeeGrid As DataGridView
    Friend WithEvents EmployeeIDTbx As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NewStatusCombx As ComboBox
    Friend WithEvents SetBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents StatusId As Label
End Class
