Imports MySql.Data.MySqlClient
Public Class SBMS_WCStaffFrm
    Private Sub SelfAssessBtn_Click(sender As Object, e As EventArgs) Handles OTRequestBtn.Click
        SelfAssessFrm.Show()
    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to quit the application?", "Quit the application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub NormalRequestBtn_Click(sender As Object, e As EventArgs) Handles NormalRequestBtn.Click
        BusRequestFrm.Show()

    End Sub

    Private Sub ReviewRequestBtn_Click(sender As Object, e As EventArgs) Handles ReviewRequestBtn.Click
        ReviewGridMng.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ChangeStaffPw.Show()
    End Sub
End Class