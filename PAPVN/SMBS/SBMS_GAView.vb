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

    Private Sub SBMS_GAView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DistanceTbx_Leave(sender As Object, e As EventArgs) Handles DistanceTbx.Leave
        If Not Regex.Match(DistanceTbx.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DistanceTbx.Focus()
            DistanceTbx.Clear()
        End If
    End Sub

    Private Sub CompanyBusBtn_CheckedChanged(sender As Object, e As EventArgs) Handles CompanyBusBtn.CheckedChanged
        SBMS_BusSelect.Show()
    End Sub
End Class