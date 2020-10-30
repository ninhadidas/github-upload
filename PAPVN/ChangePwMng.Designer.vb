<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePwMng
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurrentPwTbx = New System.Windows.Forms.TextBox()
        Me.NewPwTbx1 = New System.Windows.Forms.TextBox()
        Me.NewPwTbx2 = New System.Windows.Forms.TextBox()
        Me.ChangePwBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Re-enter new password"
        '
        'CurrentPwTbx
        '
        Me.CurrentPwTbx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPwTbx.Location = New System.Drawing.Point(194, 27)
        Me.CurrentPwTbx.Name = "CurrentPwTbx"
        Me.CurrentPwTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrentPwTbx.Size = New System.Drawing.Size(216, 23)
        Me.CurrentPwTbx.TabIndex = 3
        '
        'NewPwTbx1
        '
        Me.NewPwTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPwTbx1.Location = New System.Drawing.Point(194, 70)
        Me.NewPwTbx1.Name = "NewPwTbx1"
        Me.NewPwTbx1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPwTbx1.Size = New System.Drawing.Size(216, 23)
        Me.NewPwTbx1.TabIndex = 4
        '
        'NewPwTbx2
        '
        Me.NewPwTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPwTbx2.Location = New System.Drawing.Point(194, 116)
        Me.NewPwTbx2.Name = "NewPwTbx2"
        Me.NewPwTbx2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPwTbx2.Size = New System.Drawing.Size(216, 23)
        Me.NewPwTbx2.TabIndex = 5
        '
        'ChangePwBtn
        '
        Me.ChangePwBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePwBtn.Location = New System.Drawing.Point(144, 165)
        Me.ChangePwBtn.Name = "ChangePwBtn"
        Me.ChangePwBtn.Size = New System.Drawing.Size(145, 40)
        Me.ChangePwBtn.TabIndex = 6
        Me.ChangePwBtn.Text = "Change password"
        Me.ChangePwBtn.UseVisualStyleBackColor = True
        '
        'ChangePwMng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 222)
        Me.Controls.Add(Me.ChangePwBtn)
        Me.Controls.Add(Me.NewPwTbx2)
        Me.Controls.Add(Me.NewPwTbx1)
        Me.Controls.Add(Me.CurrentPwTbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ChangePwMng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CurrentPwTbx As TextBox
    Friend WithEvents NewPwTbx1 As TextBox
    Friend WithEvents NewPwTbx2 As TextBox
    Friend WithEvents ChangePwBtn As Button
End Class
