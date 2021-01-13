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
        GoBackTbx.Enabled = False
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
        GoBackTbx.Enabled = True
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
        Dim order_id As String = Id_Label.Text
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
        Dim attachment1 As String = EmployeeTbx1.Text
        Dim attachment2 As String = EmployeeTbx2.Text
        Dim attachment3 As String = EmployeeTbx3.Text
        Dim attachment4 As String = EmployeeTbx4.Text
        Dim attachment5 As String = EmployeeTbx5.Text
        Dim attachment6 As String = EmployeeTbx6.Text
        Dim attachment7 As String = EmployeeTbx7.Text
        Dim attachment8 As String = EmployeeTbx8.Text
        Dim attachment9 As String = EmployeeTbx9.Text
        Dim attachment10 As String = EmployeeTbx10.Text
        If depature = "" Or arrival = "" Or content = "" Then
            MessageBox.Show("Please fill in all fields to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure to submit this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim query As String = "UPDATE tbl_order SET start_location=@depature, end_location=@arrival, start_time=@pickuptime, end_time=@combacktime, order_content =@content, order_note=@note, asset_bringout=@asset, submit_time=@submit, status_id=@status WHERE order_id='" & order_id & "';"
                    Using conn
                        command = New MySqlCommand(query, conn)
                        command.Parameters.AddWithValue("@departure", depature)
                        command.Parameters.AddWithValue("@arrival", arrival)
                        command.Parameters.AddWithValue("@pickuptime", pickuptime)
                        command.Parameters.AddWithValue("@combacktime", combacktime)
                        command.Parameters.AddWithValue("@content", content)
                        command.Parameters.AddWithValue("@note", note)
                        command.Parameters.AddWithValue("@asset", asset)
                        command.Parameters.AddWithValue("@submit", Now)
                        command.Parameters.AddWithValue("@status", "1")
                        command.ExecuteNonQuery()
                        Dim query2 As String = "INSERT INTO tbl_attachment (order_id, Employee_ID) VALUES (@order_id, @Employee_ID);"
                        'Using conn
                        If attachment1 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment1)
                            command.ExecuteNonQuery()
                        End If
                        If attachment2 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment2)
                            command.ExecuteNonQuery()
                        End If
                        If attachment3 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment3)
                            command.ExecuteNonQuery()
                        End If
                        If attachment4 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment4)
                            command.ExecuteNonQuery()
                        End If
                        If attachment5 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment5)
                            command.ExecuteNonQuery()
                        End If
                        If attachment6 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment6)
                            command.ExecuteNonQuery()
                        End If
                        If attachment7 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment7)
                            command.ExecuteNonQuery()
                        End If
                        If attachment8 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment8)
                            command.ExecuteNonQuery()
                        End If
                        If attachment9 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment9)
                            command.ExecuteNonQuery()
                        End If
                        If attachment10 <> "" Then
                            command = New MySqlCommand(query2, conn)
                            command.Parameters.AddWithValue("@order_id", order_id)
                            command.Parameters.AddWithValue("@Employee_ID", attachment10)
                            command.ExecuteNonQuery()
                        End If
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
            End If
        End If
    End Sub

    Private Sub EmployeeTbx1_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx1.TextChanged
        Dim employee_id As String = EmployeeTbx1.Text
        Dim count As Integer
        If EmployeeTbx1.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx1.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx1.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx1.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx1_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx1.Leave
        If EmployeeTbx1.Text.Trim().Length() <> 7 Then
            EmployeeTbx1.Text = Nothing
        End If
    End Sub
    Private Sub NameTbx1_TextChanged(sender As Object, e As EventArgs) Handles NameTbx1.TextChanged
        If NameTbx1.Text <> "" Then
            EmployeeTbx2.ReadOnly = False
        Else
            EmployeeTbx2.ReadOnly = True
            EmployeeTbx2.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx2_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx2.TextChanged
        Dim employee_id As String = EmployeeTbx2.Text
        Dim count As Integer
        If EmployeeTbx2.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx2.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx2.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx2.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx2_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx2.Leave
        If EmployeeTbx2.Text.Trim().Length() <> 7 Then
            EmployeeTbx2.Text = Nothing
        End If
    End Sub

    Private Sub NameTbx2_TextChanged(sender As Object, e As EventArgs) Handles NameTbx2.TextChanged
        If NameTbx2.Text <> "" Then
            EmployeeTbx3.ReadOnly = False
        Else
            EmployeeTbx3.ReadOnly = True
            EmployeeTbx3.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx3_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx3.TextChanged
        Dim employee_id As String = EmployeeTbx3.Text
        Dim count As Integer
        If EmployeeTbx3.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx3.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx3.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx3.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx3_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx3.Leave
        If EmployeeTbx3.Text.Trim().Length() <> 7 Then
            EmployeeTbx3.Text = Nothing
        End If
    End Sub
    Private Sub NameTbx3_TextChanged(sender As Object, e As EventArgs) Handles NameTbx3.TextChanged
        If NameTbx3.Text <> "" Then
            EmployeeTbx4.ReadOnly = False
        Else
            EmployeeTbx4.ReadOnly = True
            EmployeeTbx4.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx4_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx4.TextChanged
        Dim employee_id As String = EmployeeTbx4.Text
        Dim count As Integer
        If EmployeeTbx4.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx4.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx4.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx4.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx4_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx4.Leave
        If EmployeeTbx4.Text.Trim().Length() <> 7 Then
            EmployeeTbx4.Text = Nothing
        End If
    End Sub
    Private Sub NameTbx4_TextChanged(sender As Object, e As EventArgs) Handles NameTbx4.TextChanged
        If NameTbx4.Text <> "" Then
            EmployeeTbx5.ReadOnly = False
        Else
            EmployeeTbx5.ReadOnly = True
            EmployeeTbx5.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx5_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx5.TextChanged
        Dim employee_id As String = EmployeeTbx5.Text
        Dim count As Integer
        If EmployeeTbx5.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx5.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx5.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx5.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx5_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx5.Leave
        If EmployeeTbx5.Text.Trim().Length() <> 7 Then
            EmployeeTbx5.Text = Nothing
        End If
    End Sub
    Private Sub NameTbx5_TextChanged(sender As Object, e As EventArgs) Handles NameTbx5.TextChanged
        If NameTbx5.Text <> "" Then
            EmployeeTbx6.ReadOnly = False
        Else
            EmployeeTbx6.ReadOnly = True
            EmployeeTbx6.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx6_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx6.TextChanged
        Dim employee_id As String = EmployeeTbx6.Text
        Dim count As Integer
        If EmployeeTbx6.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx6.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx6.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx6.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx6_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx6.Leave
        If EmployeeTbx6.Text.Trim().Length() <> 7 Then
            EmployeeTbx6.Text = Nothing
        End If
    End Sub
    Private Sub NameTbx6_TextChanged(sender As Object, e As EventArgs) Handles NameTbx6.TextChanged
        If NameTbx6.Text <> "" Then
            EmployeeTbx7.ReadOnly = False
        Else
            EmployeeTbx7.ReadOnly = True
            EmployeeTbx7.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx7_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx7.TextChanged
        Dim employee_id As String = EmployeeTbx7.Text
        Dim count As Integer
        If EmployeeTbx7.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx7.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx7.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx7.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx7_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx7.Leave
        If EmployeeTbx7.Text.Trim().Length() <> 7 Then
            EmployeeTbx7.Text = Nothing
        End If
    End Sub
    Private Sub NameTbx7_TextChanged(sender As Object, e As EventArgs) Handles NameTbx7.TextChanged
        If NameTbx7.Text <> "" Then
            EmployeeTbx8.ReadOnly = False
        Else
            EmployeeTbx8.ReadOnly = True
            EmployeeTbx8.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx8_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx8.TextChanged
        Dim employee_id As String = EmployeeTbx8.Text
        Dim count As Integer
        If EmployeeTbx8.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx8.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx8.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx8.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx8_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx8.Leave
        If EmployeeTbx8.Text.Trim().Length() <> 7 Then
            EmployeeTbx8.Text = Nothing
        End If
    End Sub
    Private Sub NameTbx8_TextChanged(sender As Object, e As EventArgs) Handles NameTbx8.TextChanged
        If NameTbx8.Text <> "" Then
            EmployeeTbx9.ReadOnly = False
        Else
            EmployeeTbx9.ReadOnly = True
            EmployeeTbx9.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx9_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx9.TextChanged
        Dim employee_id As String = EmployeeTbx9.Text
        Dim count As Integer
        If EmployeeTbx9.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx9.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx9.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx9.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx9_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx9.Leave
        If EmployeeTbx9.Text.Trim().Length() <> 7 Then
            EmployeeTbx9.Text = Nothing
        End If
    End Sub

    Private Sub NameTbx9_TextChanged(sender As Object, e As EventArgs) Handles NameTbx9.TextChanged
        If NameTbx9.Text <> "" Then
            EmployeeTbx10.ReadOnly = False
        Else
            EmployeeTbx10.ReadOnly = True
            EmployeeTbx10.Text = Nothing
        End If
    End Sub

    Private Sub EmployeeTbx10_TextChanged(sender As Object, e As EventArgs) Handles EmployeeTbx10.TextChanged
        Dim employee_id As String = EmployeeTbx10.Text
        Dim count As Integer
        If EmployeeTbx10.Text.Trim().Length() = 7 Then
            conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
            Dim reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String = "SELECT Name FROM tbl_user2 WHERE Employee_ID = '" & employee_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    NameTbx10.Text = reader("Name").ToString
                    reader.Close()
                Else
                    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EmployeeTbx10.Text = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        Else
            NameTbx10.Text = Nothing
        End If
    End Sub
    Private Sub EmployeeTbx10_Leave(sender As Object, e As EventArgs) Handles EmployeeTbx10.Leave
        If EmployeeTbx10.Text.Trim().Length() <> 7 Then
            EmployeeTbx10.Text = Nothing
        End If
    End Sub

    Private Sub SaveDraftBtn_Click(sender As Object, e As EventArgs) Handles SaveDraftBtn.Click
        Dim userid As String
        Dim depature As String
        Dim arrival As String
        Dim pickuptime As Date
        Dim combacktime As Date
        Dim Name As String
        Dim content As String
        Dim asset As String
        Dim note As String
        Dim order_id As String = Id_Label.Text
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
        Dim result As DialogResult = MessageBox.Show("Are you sure to save this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "UPDATE tbl_order SET start_location=@depature, end_location=@arrival, start_time=@pickuptime, end_time=@combacktime, order_content =@content, order_note=@note, asset_bringout=@asset, submit_time=@submit WHERE order_id='" & order_id & "';"
                Using conn
                    command = New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@depature", depature)
                    command.Parameters.AddWithValue("@arrival", arrival)
                    command.Parameters.AddWithValue("@pickuptime", pickuptime)
                    command.Parameters.AddWithValue("@combacktime", combacktime)
                    command.Parameters.AddWithValue("@content", content)
                    command.Parameters.AddWithValue("@note", note)
                    command.Parameters.AddWithValue("@asset", asset)
                    command.Parameters.AddWithValue("@submit", Now)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            MessageBox.Show("Your request were saved to draft successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Dim order_id As String
        Dim userid As String
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        order_id = Id_Label.Text
        userid = EmployeeIDTbx.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to cancel this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "DELETE FROM tbl_order WHERE order_id ='" & order_id & "' AND status_id= 0 AND employee_id='" & userid & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
                MessageBox.Show("Your request was cancel successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
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