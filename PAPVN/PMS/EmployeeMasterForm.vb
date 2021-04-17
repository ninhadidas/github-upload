Imports MySql.Data.MySqlClient
Public Class EmployeeMasterForm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub EmployeeMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim div As String
        div = DivCombox.Text
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query2 As String = "SELECT DISTINCT Position FROM employee;"
            command = New MySqlCommand(query2, conn)
            reader = command.ExecuteReader
            While reader.Read
                PositionCombox.Items.Add(reader("Position").ToString)
            End While
            ' PeriodCombox.SelectedIndex = 0
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DivCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DivCombox.SelectedIndexChanged
        DeptCombox.Text = ""
        DeptCombox.Items.Clear()
        Dim div As String
        div = DivCombox.Text
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT DISTINCT Dept FROM employee Where division = '" & div & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                DeptCombox.Items.Add(reader("Dept").ToString)
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

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim username As String
        Dim division As String
        Dim dept As String
        Dim userid As String
        Dim email As String
        Dim position As String
        Dim app1 As String
        Dim app2 As String
        Dim location As String
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
            }
        username = NameTbx.Text
        userid = EmployeeTbx.Text
        dept = DeptCombox.Text
        email = EmailTbx.Text
        position = PositionCombox.Text
        location = LocationCombox.Text
        app1 = App1Tbx.Text
        app2 = App2Tbx.Text
        division = DivCombox.Text

        If IsApprove.Text = "Regular Employee" Then
            If EmployeeTbx.Text = "" Or DivCombox.Text = "" Or DeptCombox.Text = "" Or LocationCombox.Text = "" Or NameTbx.Text = "" Or EmailTbx.Text = "" Or PositionCombox.Text = "" Or App1Tbx.Text = "" Or App2Tbx.Text = "" Then
                MessageBox.Show("Please fill in all fields to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure to add this new employee?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        Dim query As String = "INSERT INTO employee (id, EmployeeID, App1, App2, Name, Dept, Division, Location, Position, email) VALUES (@id, @EmployeeID, @App1, @App2, @Name, @Dept, @Division, @Location, @Position, @email);"
                        Using conn
                            command = New MySqlCommand(query, conn)
                            command.Parameters.AddWithValue("@id", "")
                            command.Parameters.AddWithValue("@EmployeeID", userid)
                            command.Parameters.AddWithValue("@App1", app1)
                            command.Parameters.AddWithValue("@Location", location)
                            command.Parameters.AddWithValue("@App2", app2)
                            command.Parameters.AddWithValue("@Position", position)
                            command.Parameters.AddWithValue("@email", email)
                            command.Parameters.AddWithValue("@Name", username)
                            command.Parameters.AddWithValue("@Dept", dept)
                            command.Parameters.AddWithValue("@Division", division)
                            command.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Employee " & userid & " -" & username & " is added to system successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                    Me.Controls.Clear() 'removes all the controls on the form
                    Me.InitializeComponent() 'load all the controls again
                    Me.EmployeeMasterForm_Load(e, e) 'Load everything in your form, load event again
                End If
            End If
        End If
        If IsApprove.Text = "Approver (JP)" Then
            If EmployeeTbx.Text = "" Or DivCombox.Text = "" Or DeptCombox.Text = "" Or LocationCombox.Text = "" Or NameTbx.Text = "" Or EmailTbx.Text = "" Or PositionCombox.Text = "" Then
                MessageBox.Show("Please fill in all fields to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure to add this new employee?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        Dim query As String = "INSERT INTO manager (id, EmployeeID, Name, Dept, Division, Location, Position, email) VALUES (@id, @EmployeeID, @Name, @Dept, @Division, @Location, @Position, @email);"
                        Using conn
                            command = New MySqlCommand(query, conn)
                            command.Parameters.AddWithValue("@id", "")
                            command.Parameters.AddWithValue("@EmployeeID", userid)
                            command.Parameters.AddWithValue("@Location", location)
                            command.Parameters.AddWithValue("@Position", position)
                            command.Parameters.AddWithValue("@email", email)
                            command.Parameters.AddWithValue("@Name", username)
                            command.Parameters.AddWithValue("@Dept", dept)
                            command.Parameters.AddWithValue("@Division", division)
                            ' command.Connection.Open()
                            command.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Employee " & userid & " - " & username & " is added to system successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                    Me.Controls.Clear() 'removes all the controls on the form
                    Me.InitializeComponent() 'load all the controls again
                    Me.EmployeeMasterForm_Load(e, e) 'Load everything in your form, load event again
                End If
            End If
        End If
        If IsApprove.Text = "Approver (VN)" Then
            If EmployeeTbx.Text = "" Or DivCombox.Text = "" Or DeptCombox.Text = "" Or LocationCombox.Text = "" Or NameTbx.Text = "" Or EmailTbx.Text = "" Or PositionCombox.Text = "" Or App1Tbx.Text = "" Or App2Tbx.Text = "" Then
                MessageBox.Show("Please fill in all fields to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure to add this new employee?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        Dim query As String = "INSERT INTO employee (id, EmployeeID, App1, App2, Name, Dept, Division, Location, Position, email) VALUES (@id, @EmployeeID, @App1, @App2, @Name, @Dept, @Division, @Location, @Position, @email);"
                        Using conn
                            command = New MySqlCommand(query, conn)
                            command.Parameters.AddWithValue("@id", "")
                            command.Parameters.AddWithValue("@EmployeeID", userid)
                            command.Parameters.AddWithValue("@App1", app1)
                            command.Parameters.AddWithValue("@Location", location)
                            command.Parameters.AddWithValue("@App2", app2)
                            command.Parameters.AddWithValue("@Position", position)
                            command.Parameters.AddWithValue("@email", email)
                            command.Parameters.AddWithValue("@Name", username)
                            command.Parameters.AddWithValue("@Dept", dept)
                            command.Parameters.AddWithValue("@Division", division)
                            command.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                    Try
                        conn.Open()
                        Dim query2 As String = "INSERT INTO manager (id, EmployeeID, Name, Dept, Division, Location, Position, email) VALUES (@id, @EmployeeID, @Name, @Dept, @Division, @Location, @Position, @email);"
                        Using conn
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@id", "")
                            command.Parameters.AddWithValue("@EmployeeID", userid)
                            command.Parameters.AddWithValue("@Location", location)
                            command.Parameters.AddWithValue("@Position", position)
                            command.Parameters.AddWithValue("@email", email)
                            command.Parameters.AddWithValue("@Name", username)
                            command.Parameters.AddWithValue("@Dept", dept)
                            command.Parameters.AddWithValue("@Division", division)
                            command.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Employee " & userid & " - " & username & " is added to system successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                    Me.Controls.Clear() 'removes all the controls on the form
                    Me.InitializeComponent() 'load all the controls again
                    Me.EmployeeMasterForm_Load(e, e) 'Load everything in your form, load event again
                End If
            End If
        End If

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
                Dim query As String = "DELETE FROM employee, targetdata, result USING employee INNER JOIN targetdata INNER JOIN result WHERE employee.EmployeeID =  '" & userid & "' AND targetdata.employeeid = employee.EmployeeID AND result.employeeid=Employee.EmployeeID;"
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

    Private Sub IsApprove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IsApprove.SelectedIndexChanged
        If IsApprove.Text = "Approver (JP)" Then
            App1Tbx.Visible = False
            App2Tbx.Visible = False
            Label7.Visible = False
            Label8.Visible = False
        Else
            App1Tbx.Visible = True
            App2Tbx.Visible = True
            Label7.Visible = True
            Label8.Visible = True
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

    Private Sub UpdateTypeCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateTypeCombox.SelectedIndexChanged
        If UpdateTypeCombox.Text = "Change Approver 1" Then
            App1NewTbx.Visible = True
            App2NewTbx.Visible = True
            App1NewTbx.Visible = True
            App2NewTbx.Visible = True
            Label14.Visible = True
            App1NewNameTbx.Visible = True
            Label19.Visible = True
            Label21.Visible = True
            App2NewNameTbx.Visible = True

            UpdateIdTbx.ReadOnly = False
            App1NewTbx.ReadOnly = False
            App1NewTbx.Text = Nothing

            App2NewTbx.ReadOnly = True
            App2NewTbx.Text = Nothing

            Label22.Visible = False
            NewDeptCombox.Visible = False
            NewDivCombox.Visible = False
        End If
        If UpdateTypeCombox.Text = "Change Approver 2" Then
            App1NewTbx.Visible = True
            App2NewTbx.Visible = True
            App1NewTbx.Visible = True
            App2NewTbx.Visible = True
            Label14.Visible = True
            App1NewNameTbx.Visible = True
            Label19.Visible = True
            Label21.Visible = True
            App2NewNameTbx.Visible = True

            UpdateIdTbx.ReadOnly = False
            App2NewTbx.ReadOnly = False
            App2NewTbx.Text = Nothing

            App1NewTbx.ReadOnly = True
            App1NewTbx.Text = Nothing

            Label22.Visible = False
            NewDeptCombox.Visible = False
            NewDivCombox.Visible = False
        End If
        If UpdateTypeCombox.Text = "Change Both Approvers" Then
            App1NewTbx.Visible = True
            App2NewTbx.Visible = True
            App1NewTbx.Visible = True
            App2NewTbx.Visible = True
            Label14.Visible = True
            App1NewNameTbx.Visible = True
            Label19.Visible = True
            Label21.Visible = True
            App2NewNameTbx.Visible = True

            UpdateIdTbx.ReadOnly = False
            App1NewTbx.ReadOnly = False
            App2NewTbx.ReadOnly = False
            App1NewTbx.Text = Nothing
            App2NewTbx.Text = Nothing

            Label22.Visible = False
            NewDeptCombox.Visible = False
            NewDivCombox.Visible = False
        End If
        If UpdateTypeCombox.Text = "Update Employee's Information" Then
            Label22.Visible = True
            NewDeptCombox.Visible = True
            NewDivCombox.Visible = True
            App1NewTbx.Visible = False
            App2NewTbx.Visible = False
            App1NewTbx.Visible = False
            App2NewTbx.Visible = False
            Label14.Visible = False
            App1NewNameTbx.Visible = False
            Label19.Visible = False
            Label21.Visible = False
            App2NewNameTbx.Visible = False
            UpdateIdTbx.ReadOnly = False
        End If
    End Sub

    Private Sub UpdateIdTbx_TextChanged(sender As Object, e As EventArgs) Handles UpdateIdTbx.TextChanged
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim username As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        If UpdateIdTbx.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            username = UpdateIdTbx.Text
            If username = "" Then
                MessageBox.Show("Please input employee ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Try
                    conn.Open()
                    Dim query As String = "SELECT EmployeeID, Name, Dept, Position, App1, App2 FROM employee WHERE EmployeeID = '" & username & "';"
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
                        UpdateUserGid.DataSource = dbDataSet
                        SDA.Update(dbDataSet)
                        With UpdateUserGid
                            .RowHeadersVisible = False
                            .Columns(0).HeaderCell.Value = "Employee ID"
                            .Columns(0).Width = 90
                            .Columns(1).HeaderCell.Value = "Full Name"
                            .Columns(1).Width = 120
                            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            .Columns(2).HeaderCell.Value = "Dept"
                            .Columns(2).Width = 130
                            .Columns(3).HeaderCell.Value = "Position"
                            .Columns(3).Width = 130
                            .Columns(4).HeaderCell.Value = "Approver 1"
                            .Columns(4).Width = 80
                            .Columns(5).HeaderCell.Value = "Approver 2"
                            .Columns(5).Width = 90
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
                NewInfoDataGrid.DataSource = Nothing
            End If
        Else
            UpdateUserGid.DataSource = Nothing
        End If
    End Sub

    Private Sub App1NewTbx_TextChanged(sender As Object, e As EventArgs) Handles App1NewTbx.TextChanged
        Dim newapp1 As String
        Dim count As Integer
        newapp1 = App1NewTbx.Text
        If App1NewTbx.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM manager WHERE EmployeeID = '" & newapp1 & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    App1NewNameTbx.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            App1NewNameTbx.Text = Nothing
        End If
    End Sub

    Private Sub App2NewTbx_TextChanged(sender As Object, e As EventArgs) Handles App2NewTbx.TextChanged
        Dim newapp2 As String
        Dim count As Integer
        newapp2 = App2NewTbx.Text
        If App2NewTbx.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM manager WHERE EmployeeID = '" & newapp2 & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    App2NewNameTbx.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            App2NewNameTbx.Text = Nothing
        End If
    End Sub

    Private Sub ChangeInfoBtn_Click(sender As Object, e As EventArgs) Handles ChangeInfoBtn.Click
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim app1 As String
        Dim app2 As String
        Dim div As String
        Dim dept As String
        Dim employeeid As String
        Dim reader As MySqlDataReader
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        employeeid = UpdateIdTbx.Text
        app1 = App1NewTbx.Text
        app2 = App2NewTbx.Text
        dept = NewDeptCombox.Text
        div = NewDivCombox.Text
        If UpdateTypeCombox.Text = "Change Approver 1" Then
            If app1 <> "" And employeeid <> "" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure to update new Approver 1 to " & app1 & " ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        Dim query As String = "UPDATE employee SET App1= '" & app1 & "' WHERE employeeid = '" & employeeid & "';"
                        command = New MySqlCommand(query, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("New information updated successfully!", "Please confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateIdTbx.Text = Nothing
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                End If
            Else
                MessageBox.Show("Please input Employee or Approver 1's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If UpdateTypeCombox.Text = "Change Approver 2" Then
            If app2 <> "" And employeeid <> "" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure to update new Approver 2 to " & app2 & " ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        Dim query As String = "UPDATE employee SET App2= '" & app2 & "' WHERE employeeid = '" & employeeid & "';"
                        command = New MySqlCommand(query, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("New information updated successfully!", "Please confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateIdTbx.Text = Nothing
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                End If
            Else
                MessageBox.Show("Please input Employee or Approver 2's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If UpdateTypeCombox.Text = "Change Both Approvers" Then
            If app1 <> "" And app2 <> "" And employeeid <> "" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure to update new Approver 1 to " & app1 & " and Approver 2 to " & app2 & " ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        Dim query As String = "UPDATE employee SET App1= '" & app1 & "', App2= '" & app2 & "' WHERE employeeid = '" & employeeid & "';"
                        command = New MySqlCommand(query, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("New information updated successfully!", "Please confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateIdTbx.Text = Nothing
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                End If
            Else
                MessageBox.Show("Please input Employee or Approver 1 or Approver 2's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
            If UpdateTypeCombox.Text = "Update Employee's Information" Then
            If div = "Select Division" Or dept = "Select Department" Or employeeid = "" Then
                MessageBox.Show("Please input EmployeeID and select new Division and Department!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure to update new Division to " & div & " and Department 2 to " & dept & " ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        Dim query As String = "UPDATE employee SET Division= '" & div & "', Dept= '" & dept & "' WHERE employeeid = '" & employeeid & "';"
                        command = New MySqlCommand(query, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("New information updated successfully!", "Please confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateIdTbx.Text = Nothing
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        If conn IsNot Nothing Then
                            conn.Close()
                        End If
                    End Try
                End If
            End If
        End If
        Try
            conn.Open()
            Dim query As String = "SELECT EmployeeID, Name, Division, Dept, Position, App1, App2 FROM employee WHERE EmployeeID = '" & employeeid & "';"
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
                NewInfoDataGrid.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With NewInfoDataGrid
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Employee ID"
                    .Columns(0).Width = 90
                    .Columns(1).HeaderCell.Value = "Full Name"
                    .Columns(1).Width = 120
                    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(2).HeaderCell.Value = "Division"
                    .Columns(2).Width = 100
                    .Columns(3).HeaderCell.Value = "Dept"
                    .Columns(3).Width = 110
                    .Columns(4).HeaderCell.Value = "Position"
                    .Columns(4).Width = 100
                    .Columns(5).HeaderCell.Value = "Approver 1"
                    .Columns(5).Width = 80
                    .Columns(6).HeaderCell.Value = "Approver 2"
                    .Columns(6).Width = 90
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
        App1NewTbx.Text = Nothing
        App2NewTbx.Text = Nothing
    End Sub

    Private Sub NewDivCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NewDivCombox.SelectedIndexChanged
        NewDeptCombox.Text = "Select Department"
        NewDeptCombox.Items.Clear()
        Dim div As String
        div = NewDivCombox.Text
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT DISTINCT Dept FROM employee Where division = '" & div & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                NewDeptCombox.Items.Add(reader("Dept").ToString)
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub EmployeeGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeGrid.CellContentClick

    End Sub
End Class