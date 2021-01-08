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
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        order_id = Id_Label.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to submit this request?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes And BusNameTbx.Text <> "" And DistanceTbx.Text <> "" Then
            Try
                conn.Open()
                Dim query As String = "UPDATE tbl_order SET status_id='3', bus_id='" & bus & "' WHERE order_id='" & order_id & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
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
        'ReviewGridMng.Controls.Clear() 'removes all the controls on the form
        'ReviewGridMng.InitializeComponent() 'load all the controls again
        'ReviewGridMng.ReviewGridMng_Load(e, e) 'Load everything in your form, load event again
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

    Private Sub TabControl1_Enter(sender As Object, e As EventArgs) Handles TabControl1.Enter
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT TBL_USER2.employee_id, name, Dept FROM tbl_user2 INNER JOIN tbl_attachment ON tbl_user2.employee_id = tbl_attachment.employee_id INNER JOIN tbl_order WHERE tbl_order.order_id = tbl_attachment.order_id;"
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