Public Class PmsMainFrm
    Private Sub BtnStaffView_Click(sender As Object, e As EventArgs) Handles BtnStaffView.Click
        PmsStaffLoginFrm.Show()
    End Sub

    Private Sub BtnMngView_Click(sender As Object, e As EventArgs) Handles BtnMngView.Click
        PmsMngLoginFrm.Show()
    End Sub

    Private Sub BtnHrFunc_Click(sender As Object, e As EventArgs) Handles BtnHrFunc.Click
        PmsHRLoginFrm.Show()
    End Sub
End Class