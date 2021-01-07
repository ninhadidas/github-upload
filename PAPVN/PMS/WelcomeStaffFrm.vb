Imports MySql.Data.MySqlClient
Public Class WelcomeStaffFrm
    Private Sub SelfAssessBtn_Click(sender As Object, e As EventArgs) Handles SelfAssessBtn.Click
        SelfAssessFrm.Show()
        MessageBox.Show("To avoid system error, please DO NOT input single quote letter ' into any fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to quit the application?", "Quit the application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ChangePwBtn_Click(sender As Object, e As EventArgs) Handles ChangePwBtn.Click
        ChangeStaffPw.Show()
    End Sub

    Private Sub WelcomeStaffFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim username As String
        Dim period As String
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        username = EmployeeIdLabel.Text
        period = PeriodCombox.Text
        If period = "" Then
            MessageBox.Show("Please select period to show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM targetdata WHERE employeeid = '" & username & "' AND period = '" & period & "' AND status = '8';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    OldPeriodViewFrm.Show()
                Else
                    MessageBox.Show("No old period to show!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If

    End Sub
End Class