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
End Class