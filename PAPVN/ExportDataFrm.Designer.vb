﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportDataFrm
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
        Me.ExportDataBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PeriodCombox = New System.Windows.Forms.ComboBox()
        Me.DivCombox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ExportDataBtn
        '
        Me.ExportDataBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportDataBtn.Location = New System.Drawing.Point(135, 144)
        Me.ExportDataBtn.Name = "ExportDataBtn"
        Me.ExportDataBtn.Size = New System.Drawing.Size(107, 40)
        Me.ExportDataBtn.TabIndex = 9
        Me.ExportDataBtn.Text = "Export"
        Me.ExportDataBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select Division"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Period"
        '
        'PeriodCombox
        '
        Me.PeriodCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PeriodCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodCombox.FormattingEnabled = True
        Me.PeriodCombox.Location = New System.Drawing.Point(135, 26)
        Me.PeriodCombox.Name = "PeriodCombox"
        Me.PeriodCombox.Size = New System.Drawing.Size(196, 24)
        Me.PeriodCombox.TabIndex = 10
        '
        'DivCombox
        '
        Me.DivCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DivCombox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivCombox.FormattingEnabled = True
        Me.DivCombox.Location = New System.Drawing.Point(135, 79)
        Me.DivCombox.Name = "DivCombox"
        Me.DivCombox.Size = New System.Drawing.Size(196, 24)
        Me.DivCombox.TabIndex = 11
        '
        'ExportDataFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 204)
        Me.Controls.Add(Me.DivCombox)
        Me.Controls.Add(Me.PeriodCombox)
        Me.Controls.Add(Me.ExportDataBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ExportDataFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExportDataBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PeriodCombox As ComboBox
    Friend WithEvents DivCombox As ComboBox
End Class
