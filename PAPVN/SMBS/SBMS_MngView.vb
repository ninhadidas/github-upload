Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports outlook = Microsoft.Office.Interop.Outlook
Public Class SBMS_MngView
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles ApproveBtn.Click
        Dim order_id As String
        Dim email As New List(Of String)()
        Dim reader As MySqlDataReader
        Dim dbDataSet As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim count As Integer
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
        Dim Name As String
        Dim userid As String
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        order_id = Id_Label.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to submit this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "UPDATE tbl_order SET status_id='2' WHERE order_id='" & order_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
                Name = NameTbx.Text
                userid = EmployeeIDTbx.Text
                Dim query_mail As String = "SELECT tbl_user2.email FROM tbl_user2 INNER JOIN tbl_approval ON tbl_approval.app2 = tbl_user2.employee_id WHERE tbl_approval.employee_id ='" & userid & "';"
                command = New MySqlCommand(query_mail, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                reader.Close()
                If count >= 1 Then
                    Try
                        SDA.SelectCommand = command
                        SDA.Fill(dbDataSet)
                        For Each row As DataRow In dbDataSet.Rows
                            email.Add(row.Item("email").ToString())
                        Next
                        Dim SmtpServer As New SmtpClient()
                        Dim sendmail As New MailMessage()
                        SmtpServer.Credentials = New _
                                Net.NetworkCredential("japan\70H9536", "Papvn17")
                        SmtpServer.Port = 25
                        SmtpServer.Host = "157.8.1.154"
                        sendmail = New MailMessage With {
                                    .From = New MailAddress("helpdesk.papvn@vn.panasonic.com")
                                    }
                        For Each r As String In email
                            sendmail.To.Add(New MailAddress(r))
                        Next
                        sendmail.IsBodyHtml = True
                        sendmail.Subject = "Request Pending Your Approval - Bus Management System."
                        sendmail.Body = "Dear GA Team, <br> <br> Our team member, " & Name & " (Employee ID: " & userid & ") submitted request to Order Company Bus on System.<br> Please open the system and review.<br><br>*This message is automatically sent from system."
                        SmtpServer.Send(sendmail)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        OutlookMessage = Nothing
                        AppOutlook = Nothing
                    End Try
                End If
                MessageBox.Show("The request was submitted to GA successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try

            Me.Close()
        End If
        ReviewGridMng.Controls.Clear() 'removes all the controls on the form
        ReviewGridMng.InitializeComponent() 'load all the controls again
        ReviewGridMng.ReviewGridMng_Load(e, e) 'Load everything in your form, load event again
    End Sub

    Private Sub EmployeeIDTbx_TextChanged(sender As Object, e As EventArgs) Handles EmployeeIDTbx.TextChanged
        Dim employeeid As String
        Dim count As Integer
        employeeid = EmployeeIDTbx.Text
        If EmployeeIDTbx.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString 'server=localhost;userid=ga_admin;password=Abc123;database=ga"
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM tbl_user2 WHERE Employee_ID = '" & employeeid & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count += 1
                End While
                If count = 1 Then
                    NameTbx.Text = reader("Name").ToString
                    MobileTbx.Text = reader("user_mobile").ToString
                    EmailTbx.Text = reader("email").ToString
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
            NameTbx.Text = Nothing
            MobileTbx.Text = Nothing
            EmailTbx.Text = Nothing
        End If
    End Sub

    Private Sub SBMS_MngView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabControl1_Enter(sender As Object, e As EventArgs) Handles TabControl1.Enter
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        Dim order_id As String = Id_Label.Text
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "Select tbl_user2.employee_id, Name, Dept FROM tbl_user2 INNER JOIN tbl_attachment ON tbl_user2.employee_id = tbl_attachment.employee_id WHERE tbl_attachment.order_id='" & order_id & "';"
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
                AttachedGridPerson.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With AttachedGridPerson
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Employee ID"
                    .Columns(0).Width = 120
                    .Columns(1).HeaderCell.Value = "Full Name"
                    .Columns(1).Width = 200
                    .Columns(2).HeaderCell.Value = "Department"
                    .Columns(2).Width = 200
                End With
                conn.Close()
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