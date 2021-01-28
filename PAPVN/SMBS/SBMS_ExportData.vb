Imports MySql.Data.MySqlClient
Imports PAPVN.cdt7688
Public Class SBMS_ExportData
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        DataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Dim count As Integer
        Dim from_date As Date = FromDate.Value
        Dim to_date As Date = ToDate.Value
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT order_id, tbl_user_login.name, start_location, end_location, order_content, start_time, end_time, asset_bringout, tbl_order.employee_id, tbl_user_login.Dept, submit_time, mng_comment, is_taxi FROM tbl_order INNER JOIN tbl_user_login ON tbl_user_login.employee_id = tbl_order.employee_id WHERE start_time >= '" & ConvertToDateSQL(from_date) & "' AND start_time <= '" & ConvertToDateSQL(to_date) & "';"
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
                    .Columns(3).Width = 150
                    .Columns(4).HeaderCell.Value = "Purpose"
                    .Columns(4).Width = 150
                    .Columns(5).HeaderCell.Value = "Start Time"
                    .Columns(5).Width = 150
                    .Columns(6).HeaderCell.Value = "Comeback Time"
                    .Columns(6).Width = 150
                    .Columns(7).HeaderCell.Value = "Asset Bring Out"
                    .Columns(7).Width = 150
                    .Columns(8).HeaderCell.Value = "Employee ID"
                    .Columns(8).Width = 100
                    .Columns(9).HeaderCell.Value = "Deparment"
                    .Columns(9).Width = 150
                    '.Columns(10).HeaderCell.Value = "Position"
                    '.Columns(10).Width = 150
                    .Columns(10).HeaderCell.Value = "Submit Time"
                    .Columns(10).Width = 150
                    .Columns(11).HeaderCell.Value = "Manager Comment"
                    .Columns(11).Width = 150
                    .Columns(12).HeaderCell.Value = "Taxi"
                    .Columns(12).Width = 150
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

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        Try
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Columns.AutoFit()
            For i = 0 To DataGridView.RowCount - 2
                For j = 0 To DataGridView.ColumnCount - 1
                    For k As Integer = 1 To DataGridView.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView(j, i).Value.ToString()
                    Next
                Next
            Next
            xlWorkSheet.Columns.AutoFit()
            Dim fName As String = "Bus Report Data"
            Using sfd As New SaveFileDialog
                sfd.Title = "Save As"
                sfd.OverwritePrompt = True
                sfd.FileName = fName
                sfd.DefaultExt = ".xlsx"
                sfd.Filter = "Excel Workbook(*.xlsx)|"
                sfd.AddExtension = True
                If sfd.ShowDialog() = DialogResult.OK Then
                    xlWorkSheet.SaveAs(sfd.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()
                    ReleaseObject(xlApp)
                    ReleaseObject(xlWorkBook)
                    ReleaseObject(xlWorkSheet)
                    MessageBox.Show("Export Completed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class