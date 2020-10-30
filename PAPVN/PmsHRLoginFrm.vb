Imports MySql.Data.MySqlClient
Public Class PmsHRLoginFrm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim username As String
        Dim password As String
        Dim count As Integer
        conn = New MySqlConnection
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        Dim reader As MySqlDataReader
        Dim reader2 As MySqlDataReader
        username = UserIdTb.Text
        password = PwTb.Text
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM employee where employeeid = '" & username & "' and password = '" & password & "' AND dept='HR';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count = 1 Then
                Me.Hide()
                HRFunctionsFrm.Show()
                HRFunctionsFrm.NameLabel.Text = reader("name").ToString & "!"
                HRFunctionsFrm.IdLabel.Text = reader("employeeid").ToString
            Else
                reader.Close()
                Dim query2 As String = "SELECT * FROM manager where employeeid = '" & username & "' and password = '" & password & "' AND dept='HR';"
                command = New MySqlCommand(query2, conn)
                reader2 = command.ExecuteReader
                count = 0
                While reader2.Read
                    count = +1
                End While
                If count = 1 Then
                    Me.Hide()
                    HRFunctionsFrm.Show()
                    HRFunctionsFrm.NameLabel.Text = reader2("name").ToString & "!"
                    HRFunctionsFrm.IdLabel.Text = reader2("employeeid").ToString
                    reader2.Close()
                Else
                    MessageBox.Show("Password incorrect, please try again!", "Wrong username or password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub PwTb_KeyDown(sender As Object, e As KeyEventArgs) Handles PwTb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login_Click(sender, e)
        End If
    End Sub
End Class