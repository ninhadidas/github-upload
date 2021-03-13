Imports MySql.Data.MySqlClient
Public Class SBMS_GAControlPanel
    Private Sub ReviewBtn_Click(sender As Object, e As EventArgs) Handles ReviewBtn.Click
        ReviewGridGA.Show()
    End Sub

    Private Sub UserMasterBtn_Click(sender As Object, e As EventArgs) Handles UserMasterBtn.Click
        SBMS_UserGrid.Show()
    End Sub

    Private Sub BusMasterBtn_Click(sender As Object, e As EventArgs) Handles BusMasterBtn.Click
        SBMS_BusInfoMaster.Show()
    End Sub

    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click
        SBMS_ExportData.Show()
    End Sub

    Private Sub BusQuotaBtn_Click(sender As Object, e As EventArgs) Handles BusQuotaBtn.Click
        SBMS_BusQuotaMaster.Show()
    End Sub
    Private Sub RoutingBtn_Click(sender As Object, e As EventArgs) Handles RoutingBtn.Click
        SBMS_ApprovalRoute.Show()
    End Sub
    Sub SBMS_GAControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count As Integer
        Dim username As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        username = SBMSStaffLoginFrm.UserIdTb.Text
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(order_id) FROM tbl_order INNER JOIN tbl_user_login ON tbl_user_login.employee_id = tbl_order.employee_id INNER JOIN tbl_approval ON tbl_user_login.employee_id = tbl_approval.employee_id WHERE tbl_approval.app2 = '" & username & "' AND status_id='2';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count >= 1 Then
                Label7.Text = reader("COUNT(order_id)").ToString
                If Label7.Text = 0 Then
                    Label7.Visible = False
                End If
                reader.Close()
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