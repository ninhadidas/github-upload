<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PmsMainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PmsMainFrm))
        Me.BtnStaffView = New System.Windows.Forms.Button()
        Me.BtnMngView = New System.Windows.Forms.Button()
        Me.BtnHrFunc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnStaffView
        '
        Me.BtnStaffView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnStaffView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaffView.Location = New System.Drawing.Point(23, 12)
        Me.BtnStaffView.Name = "BtnStaffView"
        Me.BtnStaffView.Size = New System.Drawing.Size(128, 57)
        Me.BtnStaffView.TabIndex = 0
        Me.BtnStaffView.Text = "Employee's View"
        Me.BtnStaffView.UseVisualStyleBackColor = False
        '
        'BtnMngView
        '
        Me.BtnMngView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMngView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMngView.Location = New System.Drawing.Point(345, 12)
        Me.BtnMngView.Name = "BtnMngView"
        Me.BtnMngView.Size = New System.Drawing.Size(128, 57)
        Me.BtnMngView.TabIndex = 1
        Me.BtnMngView.Text = "Manager's View"
        Me.BtnMngView.UseVisualStyleBackColor = False
        Me.BtnMngView.Visible = False
        '
        'BtnHrFunc
        '
        Me.BtnHrFunc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHrFunc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHrFunc.Location = New System.Drawing.Point(651, 12)
        Me.BtnHrFunc.Name = "BtnHrFunc"
        Me.BtnHrFunc.Size = New System.Drawing.Size(128, 57)
        Me.BtnHrFunc.TabIndex = 2
        Me.BtnHrFunc.Text = "HR'S Functions"
        Me.BtnHrFunc.UseVisualStyleBackColor = False
        Me.BtnHrFunc.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(544, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Version 2.0"
        '
        'PmsMainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHrFunc)
        Me.Controls.Add(Me.BtnMngView)
        Me.Controls.Add(Me.BtnStaffView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PmsMainFrm"
        Me.Text = "Performance Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnStaffView As Button
    Friend WithEvents BtnMngView As Button
    Friend WithEvents BtnHrFunc As Button
    Friend WithEvents Label1 As Label
End Class
