<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HRApproveResultFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ByDeptChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ByDivisionChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ViewChartBtn = New System.Windows.Forms.Button()
        Me.DeptChartCombox = New System.Windows.Forms.ComboBox()
        Me.DivChartCombox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PeriodCombox = New System.Windows.Forms.ComboBox()
        Me.SubmitResultBtn = New System.Windows.Forms.Button()
        Me.DivCombox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ByDeptChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ByDivisionChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ByDeptChart)
        Me.GroupBox1.Controls.Add(Me.ByDivisionChart)
        Me.GroupBox1.Controls.Add(Me.ViewChartBtn)
        Me.GroupBox1.Controls.Add(Me.DeptChartCombox)
        Me.GroupBox1.Controls.Add(Me.DivChartCombox)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(644, 286)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summarize Result"
        '
        'ByDeptChart
        '
        Me.ByDeptChart.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.ByDeptChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ByDeptChart.Legends.Add(Legend1)
        Me.ByDeptChart.Location = New System.Drawing.Point(401, 82)
        Me.ByDeptChart.Name = "ByDeptChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ByDeptChart.Series.Add(Series1)
        Me.ByDeptChart.Size = New System.Drawing.Size(214, 192)
        Me.ByDeptChart.TabIndex = 63
        Me.ByDeptChart.Text = "Chart2"
        '
        'ByDivisionChart
        '
        Me.ByDivisionChart.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.ByDivisionChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ByDivisionChart.Legends.Add(Legend2)
        Me.ByDivisionChart.Location = New System.Drawing.Point(30, 82)
        Me.ByDivisionChart.Name = "ByDivisionChart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ByDivisionChart.Series.Add(Series2)
        Me.ByDivisionChart.Size = New System.Drawing.Size(214, 192)
        Me.ByDivisionChart.TabIndex = 62
        Me.ByDivisionChart.Text = "Chart1"
        '
        'ViewChartBtn
        '
        Me.ViewChartBtn.BackColor = System.Drawing.Color.Blue
        Me.ViewChartBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewChartBtn.ForeColor = System.Drawing.Color.White
        Me.ViewChartBtn.Location = New System.Drawing.Point(531, 27)
        Me.ViewChartBtn.Name = "ViewChartBtn"
        Me.ViewChartBtn.Size = New System.Drawing.Size(84, 34)
        Me.ViewChartBtn.TabIndex = 61
        Me.ViewChartBtn.Text = "View"
        Me.ViewChartBtn.UseVisualStyleBackColor = False
        '
        'DeptChartCombox
        '
        Me.DeptChartCombox.ForeColor = System.Drawing.Color.Blue
        Me.DeptChartCombox.FormattingEnabled = True
        Me.DeptChartCombox.Items.AddRange(New Object() {"Division by Division", "Department by Department", "One by One"})
        Me.DeptChartCombox.Location = New System.Drawing.Point(280, 33)
        Me.DeptChartCombox.Margin = New System.Windows.Forms.Padding(4)
        Me.DeptChartCombox.Name = "DeptChartCombox"
        Me.DeptChartCombox.Size = New System.Drawing.Size(191, 24)
        Me.DeptChartCombox.TabIndex = 4
        Me.DeptChartCombox.Text = "Select Department"
        '
        'DivChartCombox
        '
        Me.DivChartCombox.ForeColor = System.Drawing.Color.Blue
        Me.DivChartCombox.FormattingEnabled = True
        Me.DivChartCombox.Items.AddRange(New Object() {"Division by Division", "Department by Department", "One by One"})
        Me.DivChartCombox.Location = New System.Drawing.Point(28, 33)
        Me.DivChartCombox.Margin = New System.Windows.Forms.Padding(4)
        Me.DivChartCombox.Name = "DivChartCombox"
        Me.DivChartCombox.Size = New System.Drawing.Size(191, 24)
        Me.DivChartCombox.TabIndex = 3
        Me.DivChartCombox.Text = "Select Division"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PeriodCombox)
        Me.GroupBox2.Controls.Add(Me.SubmitResultBtn)
        Me.GroupBox2.Controls.Add(Me.DivCombox)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 319)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(644, 117)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Approve Result"
        '
        'PeriodCombox
        '
        Me.PeriodCombox.ForeColor = System.Drawing.Color.Blue
        Me.PeriodCombox.FormattingEnabled = True
        Me.PeriodCombox.Items.AddRange(New Object() {"Division by Division", "Department by Department", "One by One"})
        Me.PeriodCombox.Location = New System.Drawing.Point(28, 54)
        Me.PeriodCombox.Margin = New System.Windows.Forms.Padding(4)
        Me.PeriodCombox.Name = "PeriodCombox"
        Me.PeriodCombox.Size = New System.Drawing.Size(191, 24)
        Me.PeriodCombox.TabIndex = 61
        Me.PeriodCombox.Text = "Select Period"
        '
        'SubmitResultBtn
        '
        Me.SubmitResultBtn.BackColor = System.Drawing.Color.Green
        Me.SubmitResultBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitResultBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitResultBtn.Location = New System.Drawing.Point(529, 48)
        Me.SubmitResultBtn.Name = "SubmitResultBtn"
        Me.SubmitResultBtn.Size = New System.Drawing.Size(84, 34)
        Me.SubmitResultBtn.TabIndex = 60
        Me.SubmitResultBtn.Text = "Submit"
        Me.SubmitResultBtn.UseVisualStyleBackColor = False
        '
        'DivCombox
        '
        Me.DivCombox.ForeColor = System.Drawing.Color.Blue
        Me.DivCombox.FormattingEnabled = True
        Me.DivCombox.Items.AddRange(New Object() {"Division by Division", "Department by Department", "One by One"})
        Me.DivCombox.Location = New System.Drawing.Point(278, 54)
        Me.DivCombox.Margin = New System.Windows.Forms.Padding(4)
        Me.DivCombox.Name = "DivCombox"
        Me.DivCombox.Size = New System.Drawing.Size(191, 24)
        Me.DivCombox.TabIndex = 1
        Me.DivCombox.Text = "Select Division"
        '
        'HRApproveResultFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HRApproveResultFrm"
        Me.Text = "Approve Result"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ByDeptChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ByDivisionChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DivCombox As ComboBox
    Friend WithEvents SubmitResultBtn As Button
    Friend WithEvents PeriodCombox As ComboBox
    Friend WithEvents ViewChartBtn As Button
    Friend WithEvents DeptChartCombox As ComboBox
    Friend WithEvents DivChartCombox As ComboBox
    Friend WithEvents ByDeptChart As DataVisualization.Charting.Chart
    Friend WithEvents ByDivisionChart As DataVisualization.Charting.Chart
End Class
