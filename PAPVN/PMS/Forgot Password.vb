Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class ForgotPwFrm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub ResetPwBtn_Click(sender As Object, e As EventArgs) Handles ResetPwBtn.Click
        If EmailTbx1.Text <> EmailTbx2.Text Then
            MessageBox.Show("Your email do not matching, please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Randomize()
            ' Generate random value between 1 and 6.
            Dim temppw As Integer = CInt(Int((1000000 * Rnd()) + 1))
            Dim reader As MySqlDataReader
            Dim count As Integer
            Dim email As String
            Dim name As String
            Dim link As String
            link = "<a href=""C:\PAPVN\PAPVN.exe"">Click here</a>"
            email = EmailTbx1.Text
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
            }
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM employee WHERE email = '" & email & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    name = reader("Name").ToString
                    reader.Close()
                    Dim query2 As String = "SELECT * FROM manager where email = '" & email & "';"
                    command = New MySqlCommand(query2, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count = +1
                    End While
                    reader.Close()
                    If count = 1 Then
                        Dim query_update As String = "UPDATE employee, manager SET employee.password= '" & temppw & "', manager.password= '" & temppw & "' WHERE employee.email = '" & email & "' AND manager.email = '" & email & "';"
                        command = New MySqlCommand(query_update, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                    Else
                        Dim query_update As String = "UPDATE employee SET password= '" & temppw & "' WHERE email = '" & email & "';"
                        command = New MySqlCommand(query_update, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                    End If
                    Dim SmtpServer As New SmtpClient()
                    Dim sendmail As New MailMessage()
                    SmtpServer.Credentials = New _
                    Net.NetworkCredential("japan\70H9536", "Papvn17")
                    SmtpServer.Port = 25
                    SmtpServer.Host = "157.8.1.154"
                    sendmail = New MailMessage With {
                        .From = New MailAddress("helpdesk.papvn@vn.panasonic.com")
                    }
                    sendmail.To.Add(email)
                    sendmail.IsBodyHtml = True
                    sendmail.Subject = "Password Reset - Performance Management System (PMS)."
                    sendmail.Body = "Dear Mr/Ms " & name & ",<br> <br> Your PMS password was reset to " & temppw & " <br>Remember to use your EmployeeID (600xxxx - For Vietnamese) or GlobalID (For Japanese) as UserID!<br>" & link & " to open the app and review.<br>Thank you!<br><br>*This message is automatically sent from system."
                    SmtpServer.Send(sendmail)
                    MessageBox.Show("Your password was reset successfully, please check your email to get new password!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Could not find this email, please check again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            Me.Close()
        End If
    End Sub
End Class