Imports MySql.Data.MySqlClient
Public Class SBMSStaffLoginFrm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim username As String
        Dim password As String
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        username = UserIdTb.Text
        password = PwTb.Text
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM tbl_user2 WHERE employee_id = '" & username & "' AND password = '" & password & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count = 1 Then
                Me.Hide()
                Dim approval As String
                approval = reader("is_approval").ToString
                Dim ga As String
                ga = reader("is_ga").ToString
                If approval <> True Then
                    SBMS_WCStaffFrm.GroupBox2.Visible = False
                End If
                If ga <> True Then
                    SBMS_WCStaffFrm.GroupBox3.Visible = False
                End If
                SBMS_WCStaffFrm.Show()
                SBMS_WCStaffFrm.NameLabel.Text = reader("name").ToString
                SBMS_WCStaffFrm.EmployeeIdLabel.Text = reader("employee_id").ToString
                SBMS_WCStaffFrm.DeptLabel.Text = reader("dept").ToString
                SBMS_WCStaffFrm.DivLabel.Text = reader("division").ToString
            Else
                MessageBox.Show("Password incorrect, please try again!", "Wrong username or password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SBMS_ForgotPassword.Show()
    End Sub
End Class