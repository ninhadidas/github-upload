<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatusProgressFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatusProgressFrm))
        Me.Status1 = New System.Windows.Forms.RadioButton()
        Me.Status2 = New System.Windows.Forms.RadioButton()
        Me.Status3 = New System.Windows.Forms.RadioButton()
        Me.Status4 = New System.Windows.Forms.RadioButton()
        Me.Status5 = New System.Windows.Forms.RadioButton()
        Me.Status6 = New System.Windows.Forms.RadioButton()
        Me.Status7 = New System.Windows.Forms.RadioButton()
        Me.Status8 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.app1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Status1
        '
        Me.Status1.AutoSize = True
        Me.Status1.BackColor = System.Drawing.Color.Transparent
        Me.Status1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status1.Enabled = False
        Me.Status1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status1.ForeColor = System.Drawing.Color.Black
        Me.Status1.Location = New System.Drawing.Point(41, 29)
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(106, 33)
        Me.Status1.TabIndex = 0
        Me.Status1.TabStop = True
        Me.Status1.Text = "Target Setting"
        Me.Status1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status1.UseVisualStyleBackColor = False
        '
        'Status2
        '
        Me.Status2.AutoSize = True
        Me.Status2.BackColor = System.Drawing.Color.Transparent
        Me.Status2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status2.Enabled = False
        Me.Status2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status2.ForeColor = System.Drawing.Color.Black
        Me.Status2.Location = New System.Drawing.Point(245, 31)
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(165, 65)
        Me.Status2.TabIndex = 1
        Me.Status2.TabStop = True
        Me.Status2.Text = "Submitted Target" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 1st Approver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv1 Approval)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Status2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status2.UseVisualStyleBackColor = False
        '
        'Status3
        '
        Me.Status3.AutoSize = True
        Me.Status3.BackColor = System.Drawing.Color.Transparent
        Me.Status3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status3.Enabled = False
        Me.Status3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status3.ForeColor = System.Drawing.Color.Black
        Me.Status3.Location = New System.Drawing.Point(512, 29)
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(165, 65)
        Me.Status3.TabIndex = 2
        Me.Status3.TabStop = True
        Me.Status3.Text = "Submitted Target" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 2nd Approver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv2 Approval)"
        Me.Status3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status3.UseVisualStyleBackColor = False
        '
        'Status4
        '
        Me.Status4.AutoSize = True
        Me.Status4.BackColor = System.Drawing.Color.Transparent
        Me.Status4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status4.Enabled = False
        Me.Status4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status4.ForeColor = System.Drawing.Color.Black
        Me.Status4.Location = New System.Drawing.Point(777, 29)
        Me.Status4.Name = "Status4"
        Me.Status4.Size = New System.Drawing.Size(169, 49)
        Me.Status4.TabIndex = 3
        Me.Status4.TabStop = True
        Me.Status4.Text = "Targets Approved " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Input self-assessment)"
        Me.Status4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status4.UseVisualStyleBackColor = False
        '
        'Status5
        '
        Me.Status5.AutoSize = True
        Me.Status5.BackColor = System.Drawing.Color.Transparent
        Me.Status5.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status5.Enabled = False
        Me.Status5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status5.ForeColor = System.Drawing.Color.Black
        Me.Status5.Location = New System.Drawing.Point(769, 142)
        Me.Status5.Name = "Status5"
        Me.Status5.Size = New System.Drawing.Size(188, 65)
        Me.Status5.TabIndex = 4
        Me.Status5.TabStop = True
        Me.Status5.Text = "Submitted self-assessment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 1st Approver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv1 Approval)"
        Me.Status5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status5.UseVisualStyleBackColor = False
        '
        'Status6
        '
        Me.Status6.AutoSize = True
        Me.Status6.BackColor = System.Drawing.Color.Transparent
        Me.Status6.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status6.Enabled = False
        Me.Status6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status6.ForeColor = System.Drawing.Color.Black
        Me.Status6.Location = New System.Drawing.Point(496, 145)
        Me.Status6.Name = "Status6"
        Me.Status6.Size = New System.Drawing.Size(228, 65)
        Me.Status6.TabIndex = 5
        Me.Status6.TabStop = True
        Me.Status6.Text = "Submitted superior's assessment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to 2nd Approver " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending Lv2 Approval)"
        Me.Status6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status6.UseVisualStyleBackColor = False
        '
        'Status7
        '
        Me.Status7.AutoSize = True
        Me.Status7.BackColor = System.Drawing.Color.Transparent
        Me.Status7.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status7.Enabled = False
        Me.Status7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status7.ForeColor = System.Drawing.Color.Black
        Me.Status7.Location = New System.Drawing.Point(219, 145)
        Me.Status7.Name = "Status7"
        Me.Status7.Size = New System.Drawing.Size(232, 65)
        Me.Status7.TabIndex = 6
        Me.Status7.TabStop = True
        Me.Status7.Text = "Submitted superior's assessment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to HR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pending HR Approval)"
        Me.Status7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status7.UseVisualStyleBackColor = False
        '
        'Status8
        '
        Me.Status8.AutoSize = True
        Me.Status8.BackColor = System.Drawing.Color.Transparent
        Me.Status8.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Status8.Enabled = False
        Me.Status8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status8.ForeColor = System.Drawing.Color.Black
        Me.Status8.Location = New System.Drawing.Point(12, 145)
        Me.Status8.Name = "Status8"
        Me.Status8.Size = New System.Drawing.Size(162, 49)
        Me.Status8.TabIndex = 7
        Me.Status8.TabStop = True
        Me.Status8.Text = "Completed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Final result Approved)"
        Me.Status8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Status8.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 12)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(337, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 12)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(604, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(251, 12)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(855, 75)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 52)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(618, 146)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(235, 12)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(344, 146)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(258, 12)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(101, 146)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(225, 12)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 14
        Me.PictureBox7.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(852, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(855, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(601, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(327, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'app1
        '
        Me.app1.AutoSize = True
        Me.app1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.app1.Location = New System.Drawing.Point(151, 90)
        Me.app1.Name = "app1"
        Me.app1.Size = New System.Drawing.Size(50, 16)
        Me.app1.TabIndex = 23
        Me.app1.Text = "Label9"
        Me.app1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.app1.Visible = False
        '
        'StatusProgressFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 230)
        Me.Controls.Add(Me.app1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Status1)
        Me.Controls.Add(Me.Status2)
        Me.Controls.Add(Me.Status8)
        Me.Controls.Add(Me.Status7)
        Me.Controls.Add(Me.Status6)
        Me.Controls.Add(Me.Status5)
        Me.Controls.Add(Me.Status4)
        Me.Controls.Add(Me.Status3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "StatusProgressFrm"
        Me.Text = "Status Progress"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Status1 As RadioButton
    Friend WithEvents Status2 As RadioButton
    Friend WithEvents Status3 As RadioButton
    Friend WithEvents Status4 As RadioButton
    Friend WithEvents Status5 As RadioButton
    Friend WithEvents Status6 As RadioButton
    Friend WithEvents Status7 As RadioButton
    Friend WithEvents Status8 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents app1 As Label
End Class
