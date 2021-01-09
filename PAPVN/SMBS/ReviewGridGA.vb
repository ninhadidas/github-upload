Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Data
Imports outlook = Microsoft.Office.Interop.Outlook
Public Class ReviewGridGA
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Sub ReviewGridGA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Dim count As Integer
        Dim dept As String
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim username As String
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        dept = SBMS_WCStaffFrm.DeptLabel.Text
        username = SBMSStaffLoginFrm.UserIdTb.Text
        Try
            conn.Open()
            Dim query As String = "SELECT order_id, tbl_user2.name, start_location, end_location, order_content, start_time, end_time, asset_bringout, tbl_order.employee_id, submit_time FROM tbl_order INNER JOIN tbl_user2 ON tbl_user2.employee_id = tbl_order.employee_id INNER JOIN tbl_approval ON tbl_user2.employee_id = tbl_approval.employee_id WHERE tbl_approval.app2 = '" & username & "' AND status_id='2';"
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
                    .Columns(0).HeaderCell.Value = "Request ID"
                    .Columns(0).Width = 100
                    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).HeaderCell.Value = "Full Name"
                    .Columns(1).Width = 150
                    .Columns(2).HeaderCell.Value = "Departure"
                    .Columns(2).Width = 150
                    .Columns(3).HeaderCell.Value = "Arrival"
                    .Columns(4).HeaderCell.Value = "Purpose"
                    .Columns(5).HeaderCell.Value = "Start Time"
                    .Columns(6).HeaderCell.Value = "Comeback Time"
                    .Columns(7).HeaderCell.Value = "Asset Bring Out"
                    .Columns(8).HeaderCell.Value = "Employee ID"
                    .Columns(8).Width = 100
                    .Columns(9).HeaderCell.Value = "Submit Time"
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
        SBMS_GAView.Show()
        SBMS_GAView.Id_Label.Text = DataGridView.CurrentRow.Cells(0).Value.ToString
        SBMS_GAView.EmployeeIDTbx.Text = DataGridView.CurrentRow.Cells(8).Value.ToString
        SBMS_GAView.NameTbx.Text = DataGridView.CurrentRow.Cells(1).Value.ToString
        SBMS_GAView.DepatureTbx.Text = DataGridView.CurrentRow.Cells(2).Value.ToString
        SBMS_GAView.ArrivalTbx.Text = DataGridView.CurrentRow.Cells(3).Value.ToString
        SBMS_GAView.ContentTbx.Text = DataGridView.CurrentRow.Cells(4).Value.ToString
        SBMS_GAView.PickUpTimeTbx.Text = DataGridView.CurrentRow.Cells(5).Value.ToString
        SBMS_GAView.ComebackTimeTbx.Text = DataGridView.CurrentRow.Cells(6).Value.ToString
        SBMS_GAView.AssetTbx.Text = DataGridView.CurrentRow.Cells(7).Value.ToString
    End Sub
    Private Sub DataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            SBMS_GAView.Show()
            SBMS_GAView.Id_Label.Text = DataGridView.CurrentRow.Cells(0).Value.ToString
            SBMS_GAView.EmployeeIDTbx.Text = DataGridView.CurrentRow.Cells(8).Value.ToString
            SBMS_GAView.NameTbx.Text = DataGridView.CurrentRow.Cells(1).Value.ToString
            SBMS_GAView.DepatureTbx.Text = DataGridView.CurrentRow.Cells(2).Value.ToString
            SBMS_GAView.ArrivalTbx.Text = DataGridView.CurrentRow.Cells(3).Value.ToString
            SBMS_GAView.ContentTbx.Text = DataGridView.CurrentRow.Cells(4).Value.ToString
            SBMS_GAView.PickUpTimeTbx.Text = DataGridView.CurrentRow.Cells(5).Value.ToString
            SBMS_GAView.ComebackTimeTbx.Text = DataGridView.CurrentRow.Cells(6).Value.ToString
            SBMS_MngView.AssetTbx.Text = DataGridView.CurrentRow.Cells(7).Value.ToString
        End If
    End Sub
End Class