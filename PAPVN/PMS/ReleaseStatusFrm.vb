Imports MySql.Data.MySqlClient
Public Class ReleaseStatusFrm
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim period As String
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim username As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        Dim reader As MySqlDataReader
        period = PeriodLabel.Text
        username = EmployeeIDTbx.Text
        If username = "" Then
            MessageBox.Show("Please input employee ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conn.Open()
                Dim query As String = "SELECT targetdata.Name, targetdata.EmployeeID, targetdata.Dept, employee.position, status.id, status.name FROM targetdata INNER JOIN employee ON targetdata.employeeid = employee.employeeid INNER JOIN status ON targetdata.status = status.id WHERE employee.employeeid = '" & username & "' AND targetdata.period = '" & period & "';"
                command = New MySqlCommand(query, conn)
                reader = Command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                reader.Close()
                If count >= 1 Then
                    SDA.SelectCommand = command
                    SDA.Fill(dbDataSet)
                    EmployeeGrid.DataSource = dbDataSet
                    SDA.Update(dbDataSet)
                    With EmployeeGrid
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Full Name"
                        .Columns(0).Width = 130
                        .Columns(1).HeaderCell.Value = "Employee ID"
                        .Columns(1).Width = 120
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns(2).HeaderCell.Value = "Dept"
                        .Columns(2).Width = 140
                        .Columns(3).HeaderCell.Value = "Position"
                        .Columns(3).Width = 140
                        .Columns(4).HeaderCell.Value = "Status ID"
                        .Columns(4).Width = 100
                        .Columns(5).HeaderCell.Value = "Status"
                        .Columns(5).Width = 200
                    End With
                    conn.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeGrid.DataSource = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub ReleaseStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeGrid.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        EmployeeGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        If DateValue("May 1, 2020") <= Now And Now <= DateValue("October 31, 2020") Then
            PeriodLabel.Text = "1 st Half / FY20"
        ElseIf DateValue("November 1, 2020") <= Now And Now <= DateValue("April 30, 2021") Then
            PeriodLabel.Text = "2 nd Half / FY20"
        ElseIf DateValue("May 1, 2021") <= Now And Now <= DateValue("October 31, 2021") Then
            PeriodLabel.Text = "1 st Half / FY21"
        ElseIf DateValue("November 1, 2021") <= Now And Now <= DateValue("April 30, 2022") Then
            PeriodLabel.Text = "2 nd Half / FY21"
        End If
    End Sub

    Private Sub EmployeeGrid_SelectionChanged(sender As Object, e As EventArgs) Handles EmployeeGrid.SelectionChanged
        StatusLabel.Text = EmployeeGrid.CurrentRow.Cells(4).Value.ToString

        Dim status As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString

        status = StatusLabel.Text
        Try
            conn.Open()
            Dim query As String = "SELECT name FROM status WHERE id <>'" & status & "' ;"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            NewStatusCombx.Items.Clear()
            While reader.Read
                NewStatusCombx.Items.Add(reader("name").ToString)
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click
        Dim username As String
        Dim period As String
        Dim status As String
        Dim statusname As String
        Dim conn As MySqlConnection
        Dim reader As MySqlDataReader
        Dim command As MySqlCommand
        Dim count As Integer
        conn = New MySqlConnection
        Dim answer As Integer
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        username = EmployeeIDTbx.Text
        period = PeriodLabel.Text
        statusname = NewStatusCombx.Text
        If NewStatusCombx.Text = "" Then
            MessageBox.Show("Please select new status to reset", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            answer = MessageBox.Show("Are you sure to reset the status?", "Please confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                Try
                    conn.Open()
                    Dim query As String = "SELECT id FROM status WHERE name = '" & statusname & "';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count = +1
                    End While
                    If count = 1 Then
                        StatusId.Text = reader("id").ToString
                        status = StatusId.Text
                        reader.Close()
                        Dim query2 As String = "UPDATE targetdata SET status= '" & status & "' WHERE employeeid = '" & username & "' AND period ='" & period & "';"
                        command = New MySqlCommand(query2, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("Status set successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Could not set new status!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
            End If
        End If
        conn.Close()
        Me.Controls.Clear() 'removes all the controls on the form
        Me.InitializeComponent() 'load all the controls again
        Me.ReleaseStatusFrm_Load(e, e) 'Load everything in your form, load event again
    End Sub

    Private Sub EmployeeIDTbx_TextChanged(sender As Object, e As EventArgs) Handles EmployeeIDTbx.TextChanged
        Dim period As String
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim username As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        Dim reader As MySqlDataReader
        period = PeriodLabel.Text
        username = EmployeeIDTbx.Text
        If EmployeeIDTbx.Text.Trim().Length() = 7 Then
            Try
                conn.Open()
                Dim query As String = "SELECT targetdata.Name, targetdata.EmployeeID, targetdata.Dept, employee.position, status.id, status.name FROM targetdata INNER JOIN employee ON targetdata.employeeid = employee.employeeid INNER JOIN status ON targetdata.status = status.id WHERE employee.employeeid = '" & username & "' AND targetdata.period = '" & period & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                reader.Close()
                If count >= 1 Then
                    SDA.SelectCommand = command
                    SDA.Fill(dbDataSet)
                    EmployeeGrid.DataSource = dbDataSet
                    SDA.Update(dbDataSet)
                    With EmployeeGrid
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Full Name"
                        .Columns(0).Width = 140
                        .Columns(1).HeaderCell.Value = "Employee ID"
                        .Columns(1).Width = 120
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns(2).HeaderCell.Value = "Dept"
                        .Columns(2).Width = 150
                        .Columns(3).HeaderCell.Value = "Position"
                        .Columns(3).Width = 140
                        .Columns(4).HeaderCell.Value = "Status ID"
                        .Columns(4).Width = 80
                        .Columns(5).HeaderCell.Value = "Status"
                        .Columns(5).Width = 280
                    End With
                    conn.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeGrid.DataSource = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            EmployeeGrid.DataSource = Nothing
        End If
    End Sub
End Class