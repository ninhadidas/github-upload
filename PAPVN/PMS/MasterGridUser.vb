Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Data
Imports outlook = Microsoft.Office.Interop.Outlook
Public Class MasterGridUser
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Sub MasterGridUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        PeriodLabel.Text = ExportDataFrm.PeriodCombox.Text
        Dim period As String
        Dim count As Integer
        Dim dept As String
        Dim div As String
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        div = ExportDataFrm.DivCombox.Text
        dept = ExportDataFrm.DeptCombox.Text
        period = PeriodLabel.Text
        Try
            conn.Open()
            Dim query As String = "SELECT targetdata.Name, targetdata.EmployeeID, targetdata.Dept, employee.position, status.name FROM targetdata INNER JOIN employee ON targetdata.employeeid = employee.employeeid INNER JOIN status ON targetdata.status = status.id WHERE employee.division = '" & div & "' AND  employee.dept = '" & dept & "' AND targetdata.period = '" & period & "';"
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
        HRMasterViewFrm.Show()
        HRMasterViewFrm.NameLabel.Text = DataGridView.CurrentRow.Cells(0).Value.ToString
        HRMasterViewFrm.EmployeeLabel.Text = DataGridView.CurrentRow.Cells(1).Value.ToString
        HRMasterViewFrm.DeptLabel.Text = DataGridView.CurrentRow.Cells(2).Value.ToString
    End Sub
    Private Sub DataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            HRMasterViewFrm.Show()
            HRMasterViewFrm.NameLabel.Text = DataGridView.CurrentRow.Cells(0).Value.ToString
            HRMasterViewFrm.EmployeeLabel.Text = DataGridView.CurrentRow.Cells(1).Value.ToString
            HRMasterViewFrm.DeptLabel.Text = DataGridView.CurrentRow.Cells(2).Value.ToString
        End If
    End Sub
End Class