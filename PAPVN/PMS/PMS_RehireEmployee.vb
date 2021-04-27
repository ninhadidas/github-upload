Imports MySql.Data.MySqlClient
Public Class PMS_RehireEmployee
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub PMS_RehireEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim div As String
        div = DivCombox.Text
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query2 As String = "SELECT DISTINCT Position FROM employee;"
            Command = New MySqlCommand(query2, conn)
            reader = Command.ExecuteReader
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
        Dim userid As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim count As Integer
        Dim reader As MySqlDataReader
        userid = EmployeeTbx.Text
        Dim app1 As String = App1Tbx.Text
        Dim app2 As String = App2Tbx.Text
        Dim position As String = PositionCombox.Text
        Dim dept As String = DeptCombox.Text
        Dim email As String = EmailTbx.Text
        Dim approver As String = IsApprove.Text
        Dim location As String = LocationCombox.Text
        Dim id As String = IDLabel.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to rehire new employee ID " & userid & " ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If userid = HRFunctionsFrm.IdLabel.Text Then
                MessageBox.Show("You could not rehire your ID, please as your system admin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
            Try
                conn.Open()
                'Dim query As String = "DELETE FROM employee, targetdata, result USING employee INNER JOIN targetdata INNER JOIN result WHERE employee.EmployeeID =  '" & userid & "' AND targetdata.employeeid = employee.EmployeeID AND result.employeeid=Employee.EmployeeID;"
                Dim query As String = "UPDATE employee SET App1 ='" & app1 & "', App2='" & app2 & "', email = '" & email & "', position = '" & position & "', dept = '" & dept & "', position = '" & position & "', approval = '" & approver & "', location = '" & location & "', employeeid = '" & userid & "', password = '' WHERE ID = '" & id & "'"
                MessageBox.Show("Employee " & userid & " is rehire successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub
End Class