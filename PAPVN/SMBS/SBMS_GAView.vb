Imports MySql.Data.MySqlClient
Imports outlook = Microsoft.Office.Interop.Outlook
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Public Class SBMS_GAView
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles ApproveBtn.Click
        Dim order_id As String
        Dim reader As MySqlDataReader
        Dim bus As String = busID.Text
        Dim bus_name As String = BusNameTbx.Text
        Dim distance As String = DistanceTbx.Text
        Dim driver_name As String = DriverNameTbx.Text
        Dim driver_phone As String = DriverMobileTbx.Text
        Dim note As String = GANoteTbx.Text
        Dim newpicktime As Date = NewPickupTime.Value
        Dim newbacktime As Date = NewReturnTime.Value
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        order_id = Id_Label.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to submit this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes And BusNameTbx.Text <> "" And distance <> "" And TaxiCardBtn.Checked = False Then
            Try
                conn.Open()
                If NoBtn.Checked = True Then
                    Dim query As String = "UPDATE tbl_order SET status_id='3', bus_id='" & bus & "', distance='" & distance & "', ga_comment='" & note & "', ga_action_time=now() WHERE order_id='" & order_id & "';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    reader.Close()
                Else
                    Using conn
                        Dim query As String = "UPDATE tbl_order SET status_id=@status, bus_id=@bus, distance=@distance, start_time=@newpicktime, end_time=@newbacktime, ga_comment=@note, ga_action_time=@time WHERE order_id='" & order_id & "';"
                        command = New MySqlCommand(query, conn)
                        command.Parameters.AddWithValue("@status", 3)
                        command.Parameters.AddWithValue("@bus", bus)
                        command.Parameters.AddWithValue("@distance", distance)
                        command.Parameters.AddWithValue("@newpicktime", newpicktime)
                        command.Parameters.AddWithValue("@newbacktime", newbacktime)
                        command.Parameters.AddWithValue("@note", note)
                        command.Parameters.AddWithValue("@time", Now)
                        command.ExecuteNonQuery()
                    End Using
                End If
                Dim Name As String = NameTbx.Text
                Dim userid As String = EmployeeIDTbx.Text
                Dim email As String = EmailTbx.Text
                Try
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
                    sendmail.Subject = "Your Bus Request was Approved - Bus Management System."
                    sendmail.Body = "Dear Mr/Ms " & Name & " (Employee ID: " & userid & "), <br><br> Please check details your Bus Request as below.<br><br> Order Number: " & order_id & "<br><br> Bus Name: " & bus_name & "<br><br> Driver's Name: " & driver_name & "<br><br> Driver's Phone Number: " & driver_phone & "<br><br> Pickup Time: " & newpicktime & "<br><br> Please note the Order Number and Inform to Security Staff <br><br>*To save the environment,  DO NOT print this email. This message is automatically sent from system. (c) 2021 by IT Department"
                    SmtpServer.Send(sendmail)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    OutlookMessage = Nothing
                    AppOutlook = Nothing
                End Try
                MessageBox.Show("The request was submitted successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            Me.Close()
        Else
            If result = DialogResult.Yes And TaxiCardBtn.Checked = True Then
                Try
                    conn.Open()
                    Dim query As String = "UPDATE tbl_order SET status_id='3', bus_id=0, is_taxi = true WHERE order_id='" & order_id & "';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    reader.Close()

                    Dim Name As String = NameTbx.Text
                    Dim userid As String = EmployeeIDTbx.Text
                    Dim email As String = EmailTbx.Text
                    Try
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
                        sendmail.Subject = "Your Bus Request was Approved - Bus Management System."
                        sendmail.Body = "Dear Mr/Ms " & Name & " (Employee ID: " & userid & "), <br><br> Please check details your Bus Request as below.<br><br> Order Number: " & order_id & "<br><br> Bus Name: Taxi <br><br> Please note the Order Number and Inform to Security Staff <br><br>*To save the environment,  DO NOT print this email. This message is automatically sent from system. (c) 2021 by IT Department"
                        SmtpServer.Send(sendmail)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        OutlookMessage = Nothing
                        AppOutlook = Nothing
                    End Try
                    MessageBox.Show("The request was submitted successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
                Me.Close()

            Else
                MessageBox.Show("Please check data and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        ReviewGridGA.Controls.Clear() 'removes all the controls on the form
        ReviewGridGA.InitializeComponent() 'load all the controls again
        ReviewGridGA.ReviewGridGA_Load(e, e) 'Load everything in your form, load event again
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
                Dim query As String = "SELECT * FROM tbl_user_login WHERE Employee_ID = '" & employeeid & "';"
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

    Private Sub SBMS_GAView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub CompanyBusBtn_Click(sender As Object, e As EventArgs) Handles CompanyBusBtn.Click
        SBMS_BusSelect.Show()
    End Sub

    Private Sub TaxiCardBtn_CheckedChanged(sender As Object, e As EventArgs) Handles TaxiCardBtn.CheckedChanged
        If TaxiCardBtn.Checked = True Then
            BusNameTbx.Text = Nothing
            DriverMobileTbx.Text = Nothing
            DriverNameTbx.Text = Nothing
            PlateNoTbx.Text = Nothing
            KmRemainTbx.Text = Nothing
            DistanceTbx.Text = Nothing
            DistanceTbx.ReadOnly = True
        Else
            DistanceTbx.ReadOnly = False
        End If
    End Sub

    Private Sub DistanceTbx_TextChanged(sender As Object, e As EventArgs) Handles DistanceTbx.TextChanged
        If Not Regex.Match(DistanceTbx.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DistanceTbx.Focus()
            DistanceTbx.Clear()
        End If
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
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
            Dim query As String = "Select tbl_user_login.employee_id, Name, Dept FROM tbl_user_login INNER JOIN tbl_attachment ON tbl_user_login.employee_id = tbl_attachment.employee_id WHERE tbl_attachment.order_id='" & order_id & "';"
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

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim order_id As String
        Dim userid As String
        Dim reader As MySqlDataReader
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        order_id = Id_Label.Text
        userid = EmployeeIDTbx.Text
        Dim Name As String = NameTbx.Text
        Dim email As String = EmailTbx.Text
        Dim pickup As String = DepatureTbx.Text
        Dim note As String = GANoteTbx.Text
        Dim arrive As String = ArrivalTbx.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to delete this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If note = Nothing Then
                MessageBox.Show("Please input the reason to delete this request in GA's Note box", "Input the reason!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Try
                    conn.Open()
                    Try
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
                        sendmail.Subject = "Your Bus Request was Deleted - Bus Management System."
                        sendmail.Body = "Dear Mr/Ms " & Name & " (Employee ID: " & userid & "), <br><br> Your Bus Request as below was deleted by GA.<br><br> Order Number: " & order_id & "<br><br> Pickup Place: " & pickup & "<br><br>Destination Place: " & arrive & "<br><br> Reason: " & note & "<br><br> *To save the environment,  DO NOT print this email. This message is automatically sent from system. (c) 2021 by IT Department"
                        SmtpServer.Send(sendmail)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        OutlookMessage = Nothing
                        AppOutlook = Nothing
                    End Try
                    Dim query As String = "DELETE FROM tbl_order WHERE order_id ='" & order_id & "' AND employee_id='" & userid & "';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    reader.Close()
                    MessageBox.Show("This request was deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
                Me.Close()
            End If
        End If
        ReviewGridGA.Controls.Clear() 'removes all the controls on the form
        ReviewGridGA.InitializeComponent() 'load all the controls again
        ReviewGridGA.ReviewGridGA_Load(e, e) 'Load everything in your form, load event again
    End Sub

    Private Sub RejectBtn_Click(sender As Object, e As EventArgs) Handles RejectBtn.Click
        Dim order_id As String
        Dim userid As String
        Dim reader As MySqlDataReader
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        order_id = Id_Label.Text
        userid = EmployeeIDTbx.Text
        Dim Name As String = NameTbx.Text
        Dim email As String = EmailTbx.Text
        Dim pickup As String = DepatureTbx.Text
        Dim arrive As String = ArrivalTbx.Text
        Dim note As String = GANoteTbx.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to send back this request to Manager?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If note = Nothing Then
                MessageBox.Show("Please input the reason to send back this request in GA's Note box", "Input the reason!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Try
                    conn.Open()
                    Try
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
                        sendmail.Subject = "Bus Request was sent back to Manager - Bus Management System."
                        sendmail.Body = "Dear Manager, <br><br> The Bus request of your team member - Mr/Ms " & Name & " (Employee ID: " & userid & ") was sent back to you by GA to re-check, details information as below.<br><br> Order Number: " & order_id & "<br><br> Pickup Place: " & pickup & "<br><br> Destination Place: " & arrive & "<br><br> Reason: " & note & "<br><br> *To save the environment,  DO NOT print this email. This message is automatically sent from system. (c) 2021 by IT Department"
                        SmtpServer.Send(sendmail)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        OutlookMessage = Nothing
                        AppOutlook = Nothing
                    End Try
                    Dim query As String = "UPDATE tbl_order SET status_id='1', ga_comment='" & note & "', ga_action_time = now() WHERE order_id='" & order_id & "';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    reader.Close()
                    MessageBox.Show("This request was sent back successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
                Me.Close()
            End If
        End If
        ReviewGridGA.Controls.Clear() 'removes all the controls on the form
        ReviewGridGA.InitializeComponent() 'load all the controls again
        ReviewGridGA.ReviewGridGA_Load(e, e) 'Load everything in your form, load event again
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub NoBtn_CheckedChanged(sender As Object, e As EventArgs) Handles NoBtn.CheckedChanged
        If NoBtn.Checked = True Then
            NewPickupTime.Enabled = False
            NewPickupTime.CustomFormat = " "
            NewReturnTime.Enabled = False
            NewReturnTime.CustomFormat = " "
        Else
            NewPickupTime.Enabled = True
            NewPickupTime.Value = Convert.ToDateTime(PickUpTimeTbx.Text)
            NewPickupTime.CustomFormat = "dd-MMM-yyyy HH:mm"
            NewReturnTime.Enabled = True
            NewReturnTime.CustomFormat = "dd-MMM-yyyy HH:mm"
        End If
    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        NewPickupTime.Value = Convert.ToDateTime(PickUpTimeTbx.Text)
    End Sub

End Class