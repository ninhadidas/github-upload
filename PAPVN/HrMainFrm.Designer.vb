﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HrMainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HrMainFrm))
        Me.BtnPMS = New System.Windows.Forms.Button()
        Me.copyRights = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnPMS
        '
        Me.BtnPMS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPMS.Location = New System.Drawing.Point(28, 12)
        Me.BtnPMS.Name = "BtnPMS"
        Me.BtnPMS.Size = New System.Drawing.Size(138, 49)
        Me.BtnPMS.TabIndex = 0
        Me.BtnPMS.Text = "Performance Management System"
        Me.BtnPMS.UseVisualStyleBackColor = True
        '
        'copyRights
        '
        Me.copyRights.AutoSize = True
        Me.copyRights.Location = New System.Drawing.Point(312, 428)
        Me.copyRights.Name = "copyRights"
        Me.copyRights.Size = New System.Drawing.Size(138, 13)
        Me.copyRights.TabIndex = 1
        Me.copyRights.Text = "Copy rights 2020 PAPVN-IT"
        '
        'HrMainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.copyRights)
        Me.Controls.Add(Me.BtnPMS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HrMainFrm"
        Me.Text = "HR System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPMS As Button
    Friend WithEvents copyRights As Label
End Class
