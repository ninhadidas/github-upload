Imports MySql.Data.MySqlClient

Public Class SBMS_GAControlPanel
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Me.Close()
    End Sub

    Private Sub ReviewBtn_Click(sender As Object, e As EventArgs) Handles ReviewBtn.Click
        ReviewGridGA.Show()
    End Sub

    Private Sub UserMasterBtn_Click(sender As Object, e As EventArgs) Handles UserMasterBtn.Click

    End Sub

    Private Sub BusMasterBtn_Click(sender As Object, e As EventArgs) Handles BusMasterBtn.Click

    End Sub

    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click

    End Sub

    Private Sub BusQuotaBtn_Click(sender As Object, e As EventArgs) Handles BusQuotaBtn.Click

    End Sub
End Class