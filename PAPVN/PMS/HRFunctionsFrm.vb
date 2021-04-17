Public Class HRFunctionsFrm
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to quit the application?", "Quit the application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub HRFunctionsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExportDataBtn_Click(sender As Object, e As EventArgs) Handles ExportDataBtn.Click
        ExportDataFrm.Show()
    End Sub

    Private Sub ReleaseTargetBtn_Click(sender As Object, e As EventArgs) Handles ReleaseTargetBtn.Click
        ReleaseStatusFrm.Show()
    End Sub

    Private Sub EmployeeMasterBtn_Click(sender As Object, e As EventArgs) Handles EmployeeMasterBtn.Click
        'EmployeeMasterForm.Show()
        PMS_UserMaster.Show()
    End Sub

    Private Sub ReviewResultBtn_Click(sender As Object, e As EventArgs) Handles ReviewResultBtn.Click
        HRApproveResultFrm.Show()
    End Sub
End Class