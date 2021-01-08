Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports outlook = Microsoft.Office.Interop.Outlook

Public Class BusRequestFrm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub BusRequestFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeIDTbx.Text = SBMS_WCStaffFrm.EmployeeIdLabel.Text
    End Sub

    Private Sub Radio_btn_No1_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_btn_No1.CheckedChanged
        TabControl1.TabPages(1).Enabled = False
    End Sub

    Private Sub Radio_btn_Yes1_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_btn_Yes1.CheckedChanged
        TabControl1.TabPages(1).Enabled = True
    End Sub

    Private Sub Radio_btn_No3_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_btn_No3.CheckedChanged
        ComebackTimePicker.Enabled = False
        Radio_btn_Yes2.Enabled = False
        Radio_btn_No2.Enabled = False
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
                    count = +1
                End While
                If count = 1 Then
                    NameTbx.Text = reader("Name").ToString
                    DeptTbx.Text = reader("dept").ToString
                    MobileTbx.Text = reader("user_mobile").ToString
                    EmailTbx.Text = reader("email").ToString
                    PositionTbx.Text = reader("Position").ToString
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
            DeptTbx.Text = Nothing
            MobileTbx.Text = Nothing
            EmailTbx.Text = Nothing
            PositionTbx.Text = Nothing
        End If
    End Sub

    Private Sub Radio_btn_Yes3_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_btn_Yes3.CheckedChanged
        ComebackTimePicker.Enabled = True
        Radio_btn_Yes2.Enabled = True
        Radio_btn_No2.Enabled = True
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim userid As String
        Dim email As New List(Of String)()
        Dim depature As String
        Dim arrival As String
        Dim pickuptime As Date
        Dim combacktime As Date
        Dim Name As String
        Dim content As String
        Dim asset As String
        Dim note As String
        Dim reader As MySqlDataReader
        Dim dbDataSet As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim count As Integer
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        userid = EmployeeIDTbx.Text
        Name = NameTbx.Text
        depature = DepatureTbx.Text
        arrival = ArrivalTbx.Text
        pickuptime = PickupTimePicker.Value
        combacktime = ComebackTimePicker.Value
        content = ContentTbx.Text
        asset = AssetTbx.Text
        note = NoteTbx.Text
        If depature = "" Or arrival = "" Or content = "" Then
            MessageBox.Show("Please fill in all fields to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure to submit this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim query As String = "INSERT INTO tbl_order (order_id, Employee_ID, start_location, end_location, start_time, end_time, order_content, order_note, asset_bringout, submit_time, status_id) VALUES (@id, @Employee_ID, @start_location, @end_location, @start_time, @end_time, @order_content, @order_note, @asset_bringout, @submit_time, @status_id);"
                    Using conn
                        command = New MySqlCommand(query, conn)
                        command.Parameters.AddWithValue("@order_id", "")
                        command.Parameters.AddWithValue("@Employee_ID", userid)
                        command.Parameters.AddWithValue("@start_location", depature)
                        command.Parameters.AddWithValue("@end_location", arrival)
                        command.Parameters.AddWithValue("@start_time", pickuptime)
                        command.Parameters.AddWithValue("@end_time", combacktime)
                        command.Parameters.AddWithValue("@order_content", content)
                        command.Parameters.AddWithValue("@order_note", note)
                        command.Parameters.AddWithValue("@asset_bringout", asset)
                        command.Parameters.AddWithValue("@submit_time", Now)
                        command.Parameters.AddWithValue("@status_id", "1")
                        command.ExecuteNonQuery()
                        'End Using
                        'MessageBox.Show("Your request was submitted to manager successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim query_mail As String = "SELECT tbl_user2.email FROM tbl_user2 INNER JOIN tbl_approval ON tbl_approval.app1 = tbl_user2.employee_id WHERE tbl_approval.employee_id ='" & userid & "';"
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
                                sendmail.Body = "Dear Approver, <br> <br> Your team member, " & Name & " (Employee ID: " & userid & ") submitted request to Order Company Bus on System.<br> Please open the system and review.<br><br>*This message is automatically sent from system."
                                SmtpServer.Send(sendmail)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            Finally
                                OutlookMessage = Nothing
                            AppOutlook = Nothing
                        End Try
                    Else
                        MessageBox.Show("Mail could not be sent") 'if you dont want this message, simply delete this line 
                    End If
                    End Using
                    MessageBox.Show("Your request were submitted to your manager successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
                Me.Controls.Clear() 'removes all the controls on the form
                Me.InitializeComponent() 'load all the controls again
                Me.BusRequestFrm_Load(e, e) 'Load everything in your form, load event again
            End If
        End If
    End Sub
End Class