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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BusyGridBus = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.today_lbl = New System.Windows.Forms.Label()
        Me.ShowBusBtn = New System.Windows.Forms.Button()
        Me.BusListGrid = New System.Windows.Forms.DataGridView()
        CType(Me.BusyGridBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BusyGridBus
        '
        Me.BusyGridBus.AllowUserToAddRows = False
        Me.BusyGridBus.AllowUserToDeleteRows = False
        Me.BusyGridBus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BusyGridBus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BusyGridBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BusyGridBus.DefaultCellStyle = DataGridViewCellStyle2
        Me.BusyGridBus.Location = New System.Drawing.Point(27, 54)
        Me.BusyGridBus.Name = "BusyGridBus"
        Me.BusyGridBus.ReadOnly = True
        Me.BusyGridBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BusyGridBus.Size = New System.Drawing.Size(1290, 231)
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
        'ShowBusBtn
        '
        Me.ShowBusBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBusBtn.Location = New System.Drawing.Point(27, 308)
        Me.ShowBusBtn.Name = "ShowBusBtn"
        Me.ShowBusBtn.Size = New System.Drawing.Size(169, 31)
        Me.ShowBusBtn.TabIndex = 6
        Me.ShowBusBtn.Text = "Show Full Bus List"
        Me.ShowBusBtn.UseVisualStyleBackColor = True
        '
        'BusListGrid
        '
        Me.BusListGrid.AllowUserToAddRows = False
        Me.BusListGrid.AllowUserToDeleteRows = False
        Me.BusListGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BusListGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BusListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BusListGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.BusListGrid.Location = New System.Drawing.Point(27, 345)
        Me.BusListGrid.Name = "BusListGrid"
        Me.BusListGrid.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BusListGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.BusListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BusListGrid.Size = New System.Drawing.Size(1290, 304)
        Me.BusListGrid.TabIndex = 7
        '
        'SBMS_BusSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 661)
        Me.Controls.Add(Me.BusListGrid)
        Me.Controls.Add(Me.ShowBusBtn)
        Me.Controls.Add(Me.today_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BusyGridBus)
        Me.Name = "SBMS_BusSelect"
        Me.Text = "SBMS Bus Select"
        CType(Me.BusyGridBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BusyGridBus As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents today_lbl As Label
    Friend WithEvents ShowBusBtn As Button
    Friend WithEvents BusListGrid As DataGridView
End Class
