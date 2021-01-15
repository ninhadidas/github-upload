Imports MySql.Data.MySqlClient

Public Class SBMS_WCStaffFrm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to quit the application?", "Quit the application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ChangeStaffPw.Show()
    End Sub

    Private Sub OTRequestBtn_Click(sender As Object, e As EventArgs) Handles OTRequestBtn.Click

    End Sub

    Private Sub NormalRequestBtn_Click(sender As Object, e As EventArgs) Handles NormalRequestBtn.Click
        Dim employee_id As String = EmployeeIdLabel.Text
        Dim reader As MySqlDataReader
        Dim count As Integer
        conn = New MySqlConnection With {
        .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        Try
            conn.Open()
            Dim query As String = "INSERT INTO tbl_order (order_id, employee_id, start_time, end_time, submit_time) VALUES (@order_id, @employee_id, @start_time, @end_time, @submit_time);"
            Using conn
                command = New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@order_id", "")
                command.Parameters.AddWithValue("@employee_id", employee_id)
                command.Parameters.AddWithValue("@start_time", Now)
                command.Parameters.AddWithValue("@end_time", Now)
                command.Parameters.AddWithValue("@submit_time", Now)
                command.ExecuteNonQuery()
                Dim query2 As String = "SELECT MAX(order_id) FROM tbl_order WHERE employee_id ='" & employee_id & "';"
                command = New MySqlCommand(query2, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    BusRequestFrm.Id_Label.Text = reader("MAX(order_id)").ToString
                    BusRequestFrm.EmployeeIDTbx.Text = employee_id
                    reader.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
        BusRequestFrm.Show()
    End Sub

    Private Sub CheckRequestBtn_Click(sender As Object, e As EventArgs) Handles CheckRequestBtn.Click
        RequestGrid.Show()
    End Sub

    Private Sub GAReviewBtn_Click(sender As Object, e As EventArgs) Handles GAReviewBtn.Click
        SBMS_GAControlPanel.Show()
    End Sub

    Private Sub ReviewRequestBtn_Click(sender As Object, e As EventArgs) Handles ReviewRequestBtn.Click
        ReviewGridMng.Show()
    End Sub
End Class