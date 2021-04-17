<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginStoreProcedure
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
        Me.Login = New System.Windows.Forms.Button()
        Me.PwTb = New System.Windows.Forms.TextBox()
        Me.UserIdTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(145, 143)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(110, 33)
        Me.Login.TabIndex = 9
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'PwTb
        '
        Me.PwTb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PwTb.Location = New System.Drawing.Point(155, 90)
        Me.PwTb.Name = "PwTb"
        Me.PwTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PwTb.Size = New System.Drawing.Size(149, 23)
        Me.PwTb.TabIndex = 8
        '
        'UserIdTb
        '
        Me.UserIdTb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIdTb.Location = New System.Drawing.Point(155, 44)
        Me.UserIdTb.Name = "UserIdTb"
        Me.UserIdTb.Size = New System.Drawing.Size(149, 23)
        Me.UserIdTb.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee ID"
        '
        'LoginStoreProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 206)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.PwTb)
        Me.Controls.Add(Me.UserIdTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginStoreProcedure"
        Me.Text = "Login Store Procedure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login As Button
    Friend WithEvents PwTb As TextBox
    Friend WithEvents UserIdTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
