
Imports MySql.Data.MySqlClient
Public Class SBMS_UserGrid
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Sub SBMS_UserGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim username As String
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        username = SBMSStaffLoginFrm.UserIdTb.Text
        Try
            conn.Open()
            Dim query As String = "SELECT employee_id, tbl_businfo.bus_name, name, dept, division, location, Position, email, user_mobile FROM tbl_user2 INNER JOIN tbl_businfo ON tbl_user2.bus_id = tbl_businfo.bus_id;"
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
                    .Columns(0).HeaderCell.Value = "Employee ID"
                    .Columns(0).Width = 100
                    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).HeaderCell.Value = "Bus Name"
                    .Columns(1).Width = 150
                    .Columns(2).HeaderCell.Value = "Full Name"
                    .Columns(2).Width = 150
                    .Columns(3).HeaderCell.Value = "Department"
                    .Columns(4).HeaderCell.Value = "Division"
                    .Columns(5).HeaderCell.Value = "Location"
                    .Columns(6).HeaderCell.Value = "Position"
                    .Columns(7).HeaderCell.Value = "Email"
                    .Columns(8).HeaderCell.Value = "Mobile"
                    .Columns(8).Width = 100
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

End Class