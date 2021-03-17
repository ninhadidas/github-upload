Public Class MainFrm
    Private Sub BMS_Click(sender As Object, e As EventArgs) Handles BMS.Click
        SBMS_WCStaffFrm.Show()
    End Sub
    Private Sub PMS_Click(sender As Object, e As EventArgs) Handles PMS.Click
        PmsMainFrm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        LoginFrm.Show()
    End Sub
End Class
