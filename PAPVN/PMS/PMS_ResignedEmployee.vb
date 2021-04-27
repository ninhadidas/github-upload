Imports MySql.Data.MySqlClient
Public Class PMS_ResignedEmployee
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Sub PMS_ResignedEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT Name, EmployeeID, Dept, Division, Location, position, ID FROM employee WHERE email = 'Resigned';"
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
                    .Columns(3).HeaderCell.Value = "Division"
                    .Columns(3).Width = 150
                    .Columns(4).HeaderCell.Value = "Location"
                    .Columns(5).HeaderCell.Value = "Postition"
                    .Columns(6).HeaderCell.Value = "No"
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

    Private Sub RehireBtn_Click(sender As Object, e As EventArgs) Handles RehireBtn.Click
        PMS_RehireEmployee.Show()
        PMS_RehireEmployee.NameTbx.Text = DataGridView.CurrentRow.Cells(0).Value.ToString
        PMS_RehireEmployee.IDLabel.Text = DataGridView.CurrentRow.Cells(6).Value.ToString
    End Sub
End Class