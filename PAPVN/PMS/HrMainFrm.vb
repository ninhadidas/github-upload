Imports PAPVN.App_Connect
Public Class HrMainFrm
    Private Sub BMS_Click(sender As Object, e As EventArgs) Handles BMS.Click
        SBMSStaffLoginFrm.Show()
    End Sub
    Private Sub PMS_Click(sender As Object, e As EventArgs) Handles PMS.Click
        PmsMainFrm.Show()
    End Sub

    Private Sub HrMainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
