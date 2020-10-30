Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Data
Imports outlook = Microsoft.Office.Interop.Outlook
Public Class DataGridUser
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Sub DataGridUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        'If DateValue("May 1, 2020") <= Now And Now <= DateValue("October 31, 2020") Then
        '    PeriodLabel.Text = "1 st Half / FY20"
        'ElseIf DateValue("November 1, 2020") <= Now And Now <= DateValue("April 30, 2021") Then
        '    PeriodLabel.Text = "2 nd Half / FY20"
        'ElseIf DateValue("May 1, 2021") <= Now And Now <= DateValue("October 31, 2021") Then
        '    PeriodLabel.Text = "1 st Half / FY21"
        'ElseIf DateValue("November 1, 2021") <= Now And Now <= DateValue("April 30, 2022") Then
        '    PeriodLabel.Text = "2 nd Half / FY21"
        'End If
        PeriodLabel.Text = WelcomeMngFrm.PeriodCombox.Text
        Dim period As String
        Dim count As Integer
        Dim dept As String
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim username As String
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        Dim reader As MySqlDataReader
        dept = WelcomeMngFrm.DeptLabel.Text
        period = PeriodLabel.Text
        username = WelcomeMngFrm.EmployeeIdLabel.Text
        Try
            conn.Open()
            Dim query As String = "SELECT targetdata.Name, targetdata.EmployeeID, targetdata.Dept, employee.position, status.name FROM targetdata Inner join employee on targetdata.employeeid = employee.employeeid inner join status on targetdata.status = status.id WHERE employee.employeeid <> '" & username & "' and  (employee.app1 = '" & username & "' or employee.app2 ='" & username & "' ) and targetdata.period = '" & period & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = count + 1
            End While
            reader.Close()
            If count >= 1 Then
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                DataGridView.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With DataGridView
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Full Name"
                    .Columns(1).HeaderCell.Value = "Employee ID"
                    .Columns(1).Width = 120
                    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(2).HeaderCell.Value = "Dept"
                    .Columns(2).Width = 150
                    .Columns(3).HeaderCell.Value = "Position"
                    .Columns(3).Width = 150
                    .Columns(4).HeaderCell.Value = "Status"
                End With
                conn.Close()
            Else
                MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub DataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseDoubleClick 'click chuột vào row sẽ hiện lên bảng dữ liệu
        ManagerViewFrm.Show()
        ManagerViewFrm.NameLabel.Text = DataGridView.CurrentRow.Cells(0).Value.ToString
        ManagerViewFrm.EmployeeLabel.Text = DataGridView.CurrentRow.Cells(1).Value.ToString
        ManagerViewFrm.DeptLabel.Text = DataGridView.CurrentRow.Cells(2).Value.ToString
    End Sub
    Private Sub DataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            ManagerViewFrm.Show()
            ManagerViewFrm.NameLabel.Text = DataGridView.CurrentRow.Cells(0).Value.ToString
            ManagerViewFrm.EmployeeLabel.Text = DataGridView.CurrentRow.Cells(1).Value.ToString
            ManagerViewFrm.DeptLabel.Text = DataGridView.CurrentRow.Cells(2).Value.ToString
        End If
    End Sub
End Class