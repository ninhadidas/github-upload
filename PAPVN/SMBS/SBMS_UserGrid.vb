Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class SBMS_UserGrid
    Dim conn As MySqlConnection
    Dim command As MySqlCommand


    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim employeeid As String = EmployeeIDTbx.Text
        Dim name As String = NameTbx.Text
        Dim dept As String = DeptCombox.Text
        Dim Pick_up_time As Date = PickUpTime1.Value
        Dim email As String = EmailTbx.Text
        Dim addr As String = AddrTbx.Text
        Dim mobile As String = MobileTbx.Text
        Dim position As String = TitleCombox.Text
        Dim approver As Boolean = isApprove.Text
        Dim bus_id As String = BusID.Text
        Dim location As String = LocationCombox.Text
        Dim ga As Boolean = GACombox.Text
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        Dim result As DialogResult = MessageBox.Show("Are you sure to add new employee?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes And (employeeid <> "" Or name <> "" Or dept = "" Or addr = "" Or mobile = "" Or email = "" Or position = "" Or approver = Nothing Or bus_id = "") Then
            Try
                conn.Open()
                Using conn
                    Dim query As String = "INSERT INTO tbl_user2 (employee_id, bus_ID, name, dept, position, is_approval, is_ga, password, email, home_address, user_mobile, location, pickup_time) VALUES (@employee_id, @bus_ID, @name, @dept, @position, @is_approval, @is_ga, @password, @email, @home_address, @user_mobile, @location, @pickup_time);"
                    command = New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@employee_id", employeeid)
                    command.Parameters.AddWithValue("@bus_ID", bus_id)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@dept", dept)
                    command.Parameters.AddWithValue("@position", position)
                    command.Parameters.AddWithValue("@is_approval", approver)
                    command.Parameters.AddWithValue("@is_ga", ga)
                    command.Parameters.AddWithValue("@password", "")
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@home_address", addr)
                    command.Parameters.AddWithValue("@user_mobile", mobile)
                    command.Parameters.AddWithValue("@location", location)
                    command.Parameters.AddWithValue("@pickup_time", Pick_up_time)
                    command.ExecuteNonQuery()
                    MessageBox.Show("New employee added successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            Me.Controls.Clear() 'removes all the controls on the form
            Me.InitializeComponent() 'load all the controls again
            Me.SBMS_UserGrid_Load(e, e) 'Load everything in your form, load event again
        End If
    End Sub
    Private Sub EmployeeIDTbx_Validated(sender As Object, e As EventArgs) Handles EmployeeIDTbx.Validated
        If EmployeeIDTbx.Text.Trim().Length() <> 7 Then
            MessageBox.Show("Employee ID must be contain 7 digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            EmployeeIDTbx.Text = Nothing
        End If
    End Sub

    Private Sub MobileTbx_Validated(sender As Object, e As EventArgs) Handles MobileTbx.Validated
        If Not Regex.Match(MobileTbx.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MobileTbx.Focus()
            MobileTbx.Clear()
        End If
    End Sub

    Private Sub BusNameCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BusNameCombox.SelectedIndexChanged
        Dim busname As String = BusNameCombox.Text
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_id FROM tbl_businfo WHERE bus_name = '" & busname & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count >= 1 Then
                BusID.Text = reader("bus_id").ToString
                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub SBMS_UserGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub ShowListBtn_Click(sender As Object, e As EventArgs) Handles ShowListBtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query2 As String = "SELECT employee_id, Name, Dept, Location, Position, email, home_address, pickup_time, user_mobile, is_approval, is_ga, bus_name, tbl_user2.bus_id FROM tbl_user2 INNER JOIN tbl_businfo ON tbl_user2.bus_id = tbl_businfo.bus_id;"
            command = New MySqlCommand(query2, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            reader.Close()
            If count >= 1 Then
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                UserListGridView.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With UserListGridView
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Employee ID"
                    .Columns(0).Width = 120
                    .Columns(1).HeaderCell.Value = "Full Name"
                    .Columns(1).Width = 200
                    .Columns(2).HeaderCell.Value = "Department"
                    .Columns(2).Width = 200
                    .Columns(3).HeaderCell.Value = "Location"
                    .Columns(3).Width = 70
                    .Columns(4).HeaderCell.Value = "Position"
                    .Columns(4).Width = 150
                    .Columns(5).HeaderCell.Value = "Email"
                    .Columns(5).Width = 250
                    .Columns(6).HeaderCell.Value = "Home Address"
                    .Columns(6).Width = 250
                    .Columns(7).HeaderCell.Value = "Pickup Time"
                    .Columns(7).Width = 100
                    .Columns(8).HeaderCell.Value = "Mobile Phone"
                    .Columns(8).Width = 100
                    .Columns(9).HeaderCell.Value = "Is Approver"
                    .Columns(9).Width = 100
                    .Columns(10).HeaderCell.Value = "Is GA"
                    .Columns(10).Width = 80
                    .Columns(11).HeaderCell.Value = "Bus Name"
                    .Columns(11).Width = 100
                    .Columns(12).HeaderCell.Value = "Bus ID"
                    .Columns(12).Width = 80
                End With
                'conn.Close()
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
    End Sub

    Private Sub UserListGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserListGridView.CellMouseDoubleClick
        If TabControl1.SelectedIndex = 1 Then
            EmployeeIDTbx2.Text = UserListGridView.CurrentRow.Cells(0).Value.ToString
            MobileTbx2.Text = UserListGridView.CurrentRow.Cells(8).Value.ToString
            BusNameCombox2.Text = UserListGridView.CurrentRow.Cells(11).Value.ToString
            NameTbx2.Text = UserListGridView.CurrentRow.Cells(1).Value.ToString
            EmailTbx2.Text = UserListGridView.CurrentRow.Cells(5).Value.ToString
            TitleCombox2.Text = UserListGridView.CurrentRow.Cells(4).Value.ToString
            DeptCombox2.Text = UserListGridView.CurrentRow.Cells(2).Value.ToString
            PickUpTime2.Text = UserListGridView.CurrentRow.Cells(7).Value.ToString
            isApprove2.Text = UserListGridView.CurrentRow.Cells(9).Value.ToString
            LocationCombox2.Text = UserListGridView.CurrentRow.Cells(3).Value.ToString
            GACombox2.Text = UserListGridView.CurrentRow.Cells(10).Value.ToString
            AddrTbx2.Text = UserListGridView.CurrentRow.Cells(6).Value.ToString
        End If
    End Sub
    Private Sub DownloadBtn_Click(sender As Object, e As EventArgs) Handles DownloadBtn.Click
        'Dim xlsApp As Excel.Application
        'Dim xlsWorkBook As Excel.Workbook
        'Dim xlsWorkSheet As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value
        'Dim conn As MySqlConnection
        'conn = New MySqlConnection With {
        '    .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        '}
        'Dim i, j As Integer
        'xlsApp = New Excel.Application
        'Dim spath As String = ""
        'Dim fo As New SaveFileDialog With {
        '        .Filter = "Excel files|*.xlsx",
        '        .CheckPathExists = True,
        '        .OverwritePrompt = True
        '    }
        'If fo.ShowDialog() = DialogResult.OK Then
        '        spath = fo.FileName
        '    End If
        'Try
        '    xlsApp = New Microsoft.Office.Interop.Excel.Application
        '    conn.Open()
        '    Dim query As String = "SELECT * FROM tbl_user2 ORDER BY dept;"
        '    Dim dscmd As New MySqlDataAdapter(query, conn)
        '    Dim ds As New DataSet
        '    dscmd.Fill(ds)
        '    xlsWorkBook = xlsApp.Workbooks.Add(misValue)
        '    xlsWorkSheet = xlsWorkBook.Sheets(1)
        '    For i = 0 To ds.Tables(0).Rows.Count - 1
        '        For j = 0 To ds.Tables(0).Columns.Count - 1
        '            xlsWorkSheet.Cells(i + 1, j + 1) =
        '                    ds.Tables(0).Rows(i).Item(j).ToString()
        '        Next
        '    Next
        '    xlsWorkSheet.Columns.AutoFit()
        '    xlsWorkBook.SaveAs(spath)
        '    MessageBox.Show("Successfully Exported!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    xlsWorkBook.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    xlsApp.Quit()
        'End Try


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
            For i = 0 To UserListGridView.RowCount - 1
                For j = 0 To UserListGridView.ColumnCount - 1
                    For k As Integer = 1 To UserListGridView.Columns.Count
                        xlWorkSheet.Cells(1, k) = UserListGridView.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = UserListGridView(j, i).Value.ToString()
                    Next
                Next
            Next
            xlWorkSheet.Columns.AutoFit()
            Dim fName As String = "Bus User List"
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

    Private Sub EmployeeIDTbx2_TextChanged(sender As Object, e As EventArgs) Handles EmployeeIDTbx2.TextChanged
        Dim employee_id As String = EmployeeIDTbx2.Text
        Dim count As Integer
        If EmployeeIDTbx2.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx2.Text = reader("Name").ToString
                    DeptCombox2.Text = reader("dept").ToString
                    EmailTbx2.Text = reader("email").ToString
                    LocationCombox2.Text = reader("location").ToString
                    TitleCombox2.Text = reader("position").ToString
                    isApprove2.Text = reader("is_approval").ToString
                    GACombox2.Text = reader("is_ga").ToString
                    AddrTbx2.Text = reader("home_address").ToString
                    MobileTbx2.Text = reader("user_mobile").ToString
                    BusID2.Text = reader("bus_id").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Controls.Clear() 'removes all the controls on the form
                    Me.InitializeComponent() 'load all the controls again
                    Me.SBMS_UserGrid_Load(e, e) 'Load everything in your form, load event again
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

    Private Sub BusID2_TextChanged(sender As Object, e As EventArgs) Handles BusID2.TextChanged
        Dim busid As String = BusID2.Text
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name FROM tbl_businfo WHERE bus_id = '" & busid & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count >= 1 Then
                BusNameCombox2.Text = reader("bus_name").ToString
                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub EmployeeIDTbx2_Validated(sender As Object, e As EventArgs) Handles EmployeeIDTbx2.Validated
        If EmployeeIDTbx2.Text.Trim().Length() <> 7 Then
            MessageBox.Show("Could not find this employee, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Controls.Clear() 'removes all the controls on the form
            Me.InitializeComponent() 'load all the controls again
            Me.SBMS_UserGrid_Load(e, e) 'Load everything in your form, load event again
        End If
    End Sub

    Private Sub MobileTbx2_Validated(sender As Object, e As EventArgs) Handles MobileTbx2.Validated
        If Not Regex.Match(MobileTbx.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MobileTbx.Focus()
            MobileTbx.Clear()
        End If
    End Sub

    Private Sub UserListGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles UserListGridView.KeyDown
        If TabControl1.SelectedIndex = 1 Then
            EmployeeIDTbx2.Text = UserListGridView.CurrentRow.Cells(0).Value.ToString
            MobileTbx2.Text = UserListGridView.CurrentRow.Cells(8).Value.ToString
            BusNameCombox2.Text = UserListGridView.CurrentRow.Cells(11).Value.ToString
            NameTbx2.Text = UserListGridView.CurrentRow.Cells(1).Value.ToString
            EmailTbx2.Text = UserListGridView.CurrentRow.Cells(5).Value.ToString
            TitleCombox2.Text = UserListGridView.CurrentRow.Cells(4).Value.ToString
            DeptCombox2.Text = UserListGridView.CurrentRow.Cells(2).Value.ToString
            PickUpTime2.Text = UserListGridView.CurrentRow.Cells(7).Value.ToString
            isApprove2.Text = UserListGridView.CurrentRow.Cells(9).Value.ToString
            LocationCombox2.Text = UserListGridView.CurrentRow.Cells(3).Value.ToString
            GACombox2.Text = UserListGridView.CurrentRow.Cells(10).Value.ToString
            AddrTbx2.Text = UserListGridView.CurrentRow.Cells(6).Value.ToString
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim employeeid As String = EmployeeIDTbx2.Text
        Dim name As String = NameTbx2.Text
        Dim dept As String = DeptCombox2.Text
        Dim email As String = EmailTbx2.Text
        Dim addr As String = AddrTbx2.Text
        Dim mobile As String = MobileTbx2.Text
        Dim position As String = TitleCombox2.Text
        Dim pick_up_time As Date = PickUpTime2.Value
        Dim approver As Boolean = Convert.ToBoolean(isApprove2.Text)
        Dim bus_id As String = BusID2.Text
        Dim location As String = LocationCombox2.Text
        Dim ga As Boolean = Convert.ToBoolean(GACombox2.Text.ToString)
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        Dim result As DialogResult = MessageBox.Show("Are you sure to update employee's information?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try
                conn.Open()
                Using conn
                    Dim query As String = "UPDATE tbl_user2 SET bus_ID=@bus_ID, name=@name, dept=@dept, position=@position, is_approval=@is_approval, email=@email, home_address=@home_address, user_mobile=@user_mobile, is_ga=@is_ga, location=@location, pickup_time=@pickup_time WHERE employee_id='" & employeeid & "';"
                    command = New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@bus_ID", bus_id)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@dept", dept)
                    command.Parameters.AddWithValue("@position", position)
                    command.Parameters.AddWithValue("@is_approval", approver)
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@home_address", addr)
                    command.Parameters.AddWithValue("@user_mobile", mobile)
                    command.Parameters.AddWithValue("@is_ga", ga)
                    command.Parameters.AddWithValue("@location", location)
                    command.Parameters.AddWithValue("@pickup_time", pick_up_time)
                    command.ExecuteNonQuery()
                    MessageBox.Show("New employee updated successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            Me.Controls.Clear() 'removes all the controls on the form
            Me.InitializeComponent() 'load all the controls again
            Me.SBMS_UserGrid_Load(e, e) 'Load everything in your form, load event again
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim userid As String
        Dim count As Integer
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        userid = EmployeeIDTbx2.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to delete this employee?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Please update the routing if this employee is the approver level", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Try
                conn.Open()
                Dim query As String = "DELETE tbl_user2, tbl_approval FROM tbl_user2 INNER JOIN tbl_approval WHERE tbl_user2.employee_id = tbl_approval.employee_id AND tbl_user2.employee_id='" & userid & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                reader.Close()
                If count >= 1 Then
                    MessageBox.Show("This employee was deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Could not find this employee, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            Me.Controls.Clear() 'removes all the controls on the form
            Me.InitializeComponent() 'load all the controls again
            Me.SBMS_UserGrid_Load(e, e) 'Load everything in your form, load event again
        End If
    End Sub
End Class