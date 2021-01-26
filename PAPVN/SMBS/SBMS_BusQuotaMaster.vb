Imports MySql.Data.MySqlClient
Imports PAPVN.cdt7688

Public Class SBMS_BusQuotaMaster
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Function saveData(sql As String)
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim resul As Boolean
        Try

            conn.Open()
            command = New MySqlCommand
            With command
                .Connection = conn
                .CommandText = sql
                resul = .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return resul
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("File upload successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub
    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        With OpenFileDialog1
            .Filter = "Excel files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data from Excel file"
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileLocation.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub UploadBtn_Click(sender As Object, e As EventArgs) Handles UploadBtn.Click
        Dim OLEcon As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & FileLocation.Text & " ; " & "Extended Properties=Excel 12.0;")
        Dim OLEcmd As New OleDb.OleDbCommand
        Dim OLEda As New OleDb.OleDbDataAdapter
        Dim OLEdt As New DataTable
        Dim sql As String
        Dim resul As Boolean

        Try
            OLEcon.Open()
            With OLEcmd
                .Connection = OLEcon
                .CommandText = "select * from [Sheet1$A1:E40]"
            End With
            OLEda.SelectCommand = OLEcmd
            OLEda.Fill(OLEdt)
            For Each r As DataRow In OLEdt.Rows
                sql = "INSERT INTO tbl_bus_quota (bus_id, date, quota, fixed_km, km_remain) VALUES ('" & r(0).ToString & "', '" & ConvertToDateSQL(r(1).ToString) & "', '" & r(2).ToString & "', '" & r(3).ToString & "', '" & r(4).ToString & "')"
                resul = saveData(sql)
                If resul Then
                    Timer1.Start()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OLEcon.Close()
        End Try

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name, tbl_businfo.bus_id, date, quota, fixed_km, km_remain FROM tbl_bus_quota INNER JOIN tbl_businfo ON tbl_bus_quota.bus_id = tbl_businfo.bus_id WHERE MONTH(date) = MONTH(NOW());"
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
                QuotaGridView.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With QuotaGridView
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Bus Name"
                    .Columns(0).Width = 70
                    .Columns(1).HeaderCell.Value = "Bus ID"
                    .Columns(1).Width = 50
                    .Columns(2).HeaderCell.Value = "Month"
                    .Columns(2).Width = 120
                    .Columns(3).HeaderCell.Value = "Quota This Month"
                    .Columns(3).Width = 100
                    .Columns(4).HeaderCell.Value = "Fixed Km"
                    .Columns(4).Width = 150
                    .Columns(5).HeaderCell.Value = "Km Remaining"
                    .Columns(5).Width = 150
                End With
                conn.Close()
                'Else
                '    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
        Label2.Text = "Recently Quota Uploaded:"
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        Dim frommonth As Date = FromDate.Value
        Dim tomonth As Date = ToDate.Value
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name, tbl_businfo.bus_id, MONTH(date), quota, fixed_km, km_remain FROM tbl_bus_quota INNER JOIN tbl_businfo ON tbl_bus_quota.bus_id = tbl_businfo.bus_id WHERE MONTH('" & ConvertToDateSQL(frommonth) & "') <= MONTH(date) AND MONTH(date) <= MONTH('" & ConvertToDateSQL(tomonth) & "') ;"
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
                QuotaGridView.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With QuotaGridView
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Bus Name"
                    .Columns(0).Width = 100
                    .Columns(1).HeaderCell.Value = "Bus ID"
                    .Columns(1).Width = 80
                    .Columns(2).HeaderCell.Value = "Month"
                    .Columns(2).Width = 100
                    .Columns(3).HeaderCell.Value = "Quota This Month"
                    .Columns(3).Width = 150
                    .Columns(4).HeaderCell.Value = "Fixed Km"
                    .Columns(4).Width = 100
                    .Columns(5).HeaderCell.Value = "Km Remaining"
                    .Columns(5).Width = 120
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
        Label2.Text = "Quota list found:"
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
            For i = 0 To QuotaGridView.RowCount - 1
                For j = 0 To QuotaGridView.ColumnCount - 1
                    For k As Integer = 1 To QuotaGridView.Columns.Count
                        xlWorkSheet.Cells(1, k) = QuotaGridView.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = QuotaGridView(j, i).Value.ToString()
                    Next
                Next
            Next
            xlWorkSheet.Columns.AutoFit()
            Dim fName As String = "Bus Quota List"
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