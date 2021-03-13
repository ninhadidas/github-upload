Imports MySql.Data.MySqlClient
Public Class WelcomeMngFrm
    Private Sub ChangePwBtn_Click(sender As Object, e As EventArgs) Handles ChangePwBtn.Click
        ChangePwMng.Show()
    End Sub

    Private Sub ReviewTargetBtn_Click(sender As Object, e As EventArgs) Handles ReviewTargetBtn.Click
        DataGridUser.Show()
    End Sub

    Private Sub WelcomeMngFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT name FROM period;"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                PeriodCombox.Items.Add(reader("name").ToString)
            End While
            ' PeriodCombox.SelectedIndex = 0
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub OldPeriodBtn_Click(sender As Object, e As EventArgs) Handles OldPeriodBtn.Click

        DataGridUser.Show()
    End Sub
End Class