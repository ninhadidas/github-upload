<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SBMS_BusSelect
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
        Me.BusyGridBus = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.today_lbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BusyGridBus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BusyGridBus
        '
        Me.BusyGridBus.AllowUserToAddRows = False
        Me.BusyGridBus.AllowUserToDeleteRows = False
        Me.BusyGridBus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BusyGridBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BusyGridBus.Location = New System.Drawing.Point(27, 54)
        Me.BusyGridBus.Name = "BusyGridBus"
        Me.BusyGridBus.ReadOnly = True
        Me.BusyGridBus.Size = New System.Drawing.Size(1290, 277)
        Me.BusyGridBus.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LIST OF TRIPS TODAY"
        '
        'today_lbl
        '
        Me.today_lbl.AutoSize = True
        Me.today_lbl.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.today_lbl.ForeColor = System.Drawing.Color.Indigo
        Me.today_lbl.Location = New System.Drawing.Point(1189, 25)
        Me.today_lbl.Name = "today_lbl"
        Me.today_lbl.Size = New System.Drawing.Size(99, 25)
        Me.today_lbl.TabIndex = 5
        Me.today_lbl.Text = "TODAY: "
        Me.today_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SBMS_BusSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.today_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BusyGridBus)
        Me.Name = "SBMS_BusSelect"
        Me.Text = "SBMS Bus Select"
        CType(Me.BusyGridBus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BusyGridBus As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents today_lbl As Label
    Friend WithEvents Button1 As Button
End Class
