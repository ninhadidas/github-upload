Imports MySql.Data.MySqlClient

Public Class ChangePwMng
    Private Sub ChangePwBtn_Click(sender As Object, e As EventArgs) Handles ChangePwBtn.Click
        Dim username As String
        Dim currentpw As String
        Dim newpw1 As String
        Dim newpw2 As String
        Dim count As Integer
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        username = WelcomeMngFrm.EmployeeIdLabel.Text

        currentpw = CurrentPwTbx.Text
        newpw1 = NewPwTbx1.Text
        newpw2 = NewPwTbx2.Text

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM manager WHERE employeeid = '" & username & "' AND password = '" & currentpw & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            reader.Close()
            If count = 1 Then
                Dim query2 As String = "SELECT * FROM employee WHERE employeeid = '" & username & "';"
                command = New MySqlCommand(query2, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                reader.Close()

                If count = 1 Then
                    If newpw1 = newpw2 Then
                        Dim query3 As String = "UPDATE manager, employee SET manager.password= '" & newpw1 & "', employee.password= '" & newpw1 & "' WHERE manager.employeeid = '" & username & "' AND employee.employeeid = '" & username & "';"
                        command = New MySqlCommand(query3, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("Password changed successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("New password not matching!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    If newpw1 = newpw2 Then
                        Dim query4 As String = "UPDATE manager SET password= '" & newpw1 & "' WHERE employeeid = '" & username & "';"
                        command = New MySqlCommand(query4, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("Password changed successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("New password not matching!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                MessageBox.Show("Incorrect current password, please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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