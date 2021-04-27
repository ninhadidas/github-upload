Imports MySql.Data.MySqlClient
Imports PAPVN.cdt7688

Public Class PMS_UserMaster
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Function saveData(sql As String)
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
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
            .Filter = "Excel files(*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data from Excel file"
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileLocation.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub UploadBtn_Click(sender As Object, e As EventArgs) Handles UploadBtn.Click
        Dim OLEcon As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & FileLocation.Text & " ; " & "Extended Properties='Excel 8.0;HDR=YES;';")
        Dim OLEcmd As New OleDb.OleDbCommand
        Dim OLEda As New OleDb.OleDbDataAdapter
        Dim OLEdt As New DataTable
        Dim sql As String
        Dim resul As Boolean

        Try
            OLEcon.Open()
            With OLEcmd
                .Connection = OLEcon
                .CommandText = "select * from [Sheet1$]"
            End With
            OLEda.SelectCommand = OLEcmd
            OLEda.Fill(OLEdt)
            For Each r As DataRow In OLEdt.Rows
                sql = "INSERT INTO employee (EmployeeID, Name, App1, App2, Dept, Division, Location, Position, Approval, email) VALUES ('" & r(0).ToString & "', '" & r(1).ToString & "', '" & r(2).ToString & "', '" & r(3).ToString & "', '" & r(4).ToString & "', '" & r(5).ToString & "', '" & r(6).ToString & "', '" & r(7).ToString & "', '" & r(8).ToString & "', '" & r(9).ToString & "')"
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
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT EmployeeID, Name, App1, App2, Dept, Division, Location, Position, email FROM employee ORDER BY ID DESC;"
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
                    .Columns(0).HeaderCell.Value = "Employee ID"
                    .Columns(0).Width = 70
                    .Columns(1).HeaderCell.Value = "Full Name"
                    .Columns(1).Width = 120
                    .Columns(2).HeaderCell.Value = "Approver 1 ID"
                    .Columns(2).Width = 70
                    .Columns(3).HeaderCell.Value = "Approver 2 ID"
                    .Columns(3).Width = 70
                    .Columns(4).HeaderCell.Value = "Department"
                    .Columns(4).Width = 120
                    .Columns(5).HeaderCell.Value = "Division"
                    .Columns(5).Width = 80
                    .Columns(6).HeaderCell.Value = "Location"
                    .Columns(6).Width = 40
                    .Columns(7).HeaderCell.Value = "Position"
                    .Columns(7).Width = 100
                    .Columns(8).HeaderCell.Value = "Email"
                    .Columns(8).Width = 180
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
        Label2.Text = "User List:"
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

    Private Sub BrowseBtn2_Click(sender As Object, e As EventArgs) Handles BrowseBtn2.Click
        With OpenFileDialog1
            .Filter = "Excel files(*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data from Excel file"
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileLocation.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub UploadBtn2_Click(sender As Object, e As EventArgs) Handles UploadBtn2.Click
        Dim OLEcon As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & FileLocation.Text & " ; " & "Extended Properties='Excel 8.0;HDR=YES;';")
        Dim OLEcmd As New OleDb.OleDbCommand
        Dim OLEda As New OleDb.OleDbDataAdapter
        Dim OLEdt As New DataTable
        Dim sql As String
        Dim resul As Boolean

        Try
            OLEcon.Open()
            With OLEcmd
                .Connection = OLEcon
                .CommandText = "select * from [Sheet1$]"
            End With
            OLEda.SelectCommand = OLEcmd
            OLEda.Fill(OLEdt)
            For Each r As DataRow In OLEdt.Rows
                sql = "UPDATE employee SET App1 = '" & r(1).ToString & "', App2 ='" & r(2).ToString & "', Dept ='" & r(3).ToString & "', Division ='" & r(4).ToString & "', Location='" & r(5).ToString & "', Position ='" & r(6).ToString & "', Approval ='" & r(7).ToString & "', email = '" & r(8).ToString & "' WHERE employeeid ='" & r(0).ToString & "' "
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
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT EmployeeID, Name, App1, App2, Dept, Division, Location, Position, email FROM employee ORDER BY ID DESC;"
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
                    .Columns(0).HeaderCell.Value = "Employee ID"
                    .Columns(0).Width = 70
                    .Columns(1).HeaderCell.Value = "Full Name"
                    .Columns(1).Width = 120
                    .Columns(2).HeaderCell.Value = "Approver 1 ID"
                    .Columns(2).Width = 70
                    .Columns(3).HeaderCell.Value = "Approver 2 ID"
                    .Columns(3).Width = 70
                    .Columns(4).HeaderCell.Value = "Department"
                    .Columns(4).Width = 120
                    .Columns(5).HeaderCell.Value = "Division"
                    .Columns(5).Width = 80
                    .Columns(6).HeaderCell.Value = "Location"
                    .Columns(6).Width = 40
                    .Columns(7).HeaderCell.Value = "Position"
                    .Columns(7).Width = 100
                    .Columns(8).HeaderCell.Value = "Email"
                    .Columns(8).Width = 180
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
        Label2.Text = "User List:"
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Dim userid As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim count As Integer
        Dim reader As MySqlDataReader
        userid = EmployeeGrid.CurrentRow.Cells(0).Value.ToString
        Dim result As DialogResult = MessageBox.Show("Are you sure to delete employee ID " & userid & " ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If userid = HRFunctionsFrm.IdLabel.Text Then
                MessageBox.Show("You could not delete your ID, please as your system admin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
            Try
                conn.Open()
                'Dim query As String = "DELETE FROM employee, targetdata, result USING employee INNER JOIN targetdata INNER JOIN result WHERE employee.EmployeeID =  '" & userid & "' AND targetdata.employeeid = employee.EmployeeID AND result.employeeid=Employee.EmployeeID;"
                Dim query As String = "UPDATE employee SET App1 =0, App2=0, email = 'Resigned' WHERE employeeid = '" & userid & "'"
                MessageBox.Show("Employee " & userid & " is deleted successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                reader.Close()
                EmployeeGrid.DataSource = Nothing
                DelEmployeeTbx.Text = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub DelEmployeeTbx_TextChanged(sender As Object, e As EventArgs) Handles DelEmployeeTbx.TextChanged
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim username As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        If DelEmployeeTbx.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            username = DelEmployeeTbx.Text
            If username = "" Then
                MessageBox.Show("Please input employee ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Try
                    conn.Open()
                    Dim query As String = "SELECT EmployeeID, Name, Dept, Position FROM employee WHERE EmployeeID = '" & username & "';"
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
                            .Columns(0).HeaderCell.Value = "Employee ID"
                            .Columns(0).Width = 100
                            .Columns(1).HeaderCell.Value = "Full Name"
                            .Columns(1).Width = 120
                            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            .Columns(2).HeaderCell.Value = "Dept"
                            .Columns(2).Width = 150
                            .Columns(3).HeaderCell.Value = "Position"
                            .Columns(3).Width = 150
                        End With
                        conn.Close()
                    Else
                        MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        '  EmployeeGrid.DataSource = Nothing
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
            End If
        Else
            EmployeeGrid.DataSource = Nothing
        End If
    End Sub
End Class