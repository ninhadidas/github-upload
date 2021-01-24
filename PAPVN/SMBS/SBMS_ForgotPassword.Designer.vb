<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SBMS_ForgotPassword
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
        Me.EmailTbx1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetPwBtn = New System.Windows.Forms.Button()
        Me.EmailTbx2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EmailTbx1
        '
        Me.EmailTbx1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTbx1.Location = New System.Drawing.Point(41, 47)
        Me.EmailTbx1.Name = "EmailTbx1"
        Me.EmailTbx1.Size = New System.Drawing.Size(239, 23)
        Me.EmailTbx1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input your email to reset password"
        '
        'ResetPwBtn
        '
        Me.ResetPwBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPwBtn.Location = New System.Drawing.Point(108, 160)
        Me.ResetPwBtn.Name = "ResetPwBtn"
        Me.ResetPwBtn.Size = New System.Drawing.Size(110, 33)
        Me.ResetPwBtn.TabIndex = 5
        Me.ResetPwBtn.Text = "Reset"
        Me.ResetPwBtn.UseVisualStyleBackColor = True
        '
        'EmailTbx2
        '
        Me.EmailTbx2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTbx2.Location = New System.Drawing.Point(41, 115)
        Me.EmailTbx2.Name = "EmailTbx2"
        Me.EmailTbx2.Size = New System.Drawing.Size(239, 23)
        Me.EmailTbx2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Re-type your email"
        '
        'SBMS_ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 207)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmailTbx2)
        Me.Controls.Add(Me.ResetPwBtn)
        Me.Controls.Add(Me.EmailTbx1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SBMS_ForgotPassword"
        Me.Text = "Self Reset Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmailTbx1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetPwBtn As Button
    Friend WithEvents EmailTbx2 As TextBox
    Friend WithEvents Label2 As Label
End Class
