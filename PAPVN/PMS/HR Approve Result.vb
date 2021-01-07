Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class HRApproveResultFrm
    Private Sub SubmitResultBtn_Click(sender As Object, e As EventArgs) Handles SubmitResultBtn.Click
        Dim division As String
        Dim period As String
        Dim conn As MySqlConnection
        Dim reader As MySqlDataReader
        Dim command As MySqlCommand
        Dim count As Integer
        conn = New MySqlConnection
        Dim answer As Integer
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        division = DivCombox.Text
        period = PeriodCombox.Text
        If period = "Select Period" Or division = "Select Division" Then
            MessageBox.Show("Please select Period and/or Division", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            answer = MessageBox.Show("Are you sure to approve the final result for Division " & division & " ?", "Please confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                Try
                    conn.Open()
                    Dim query As String = "SELECT employee.Name, targetdata.Status, employee.division FROM targetdata, employee WHERE targetdata.Status ='7' AND targetdata.period='" & period & "' AND targetdata.employeeid=employee.EmployeeID AND employee.division='" & division & "';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count = +1
                    End While
                    reader.Close()
                    If count >= 1 Then
                        Dim query2 As String = "UPDATE targetdata,employee SET status= '8' WHERE targetdata.Status ='7' AND targetdata.period='" & period & "' AND targetdata.employeeid=employee.EmployeeID AND employee.division='" & division & "';"
                        command = New MySqlCommand(query2, conn)
                        reader = command.ExecuteReader
                        reader.Close()
                        MessageBox.Show("The final results for Division " & division & " successfully submited!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No record found to submit the final result!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
            End If
        End If
        conn.Close()
    End Sub

    Private Sub HRApproveResultFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim division As String
        'Dim period As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        'division = DivCombox.Text
        'period = PeriodCombox.Text
        Try
            conn.Open()
            Dim query As String = "SELECT DISTINCT period FROM targetdata;"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            PeriodCombox.Items.Clear()
            While reader.Read
                PeriodCombox.Items.Add(reader("period").ToString)
            End While
            reader.Close()

            Dim query2 As String = "SELECT DISTINCT division FROM employee WHERE division <>'' ORDER BY division;"
            command = New MySqlCommand(query2, conn)
            reader = command.ExecuteReader
            DivCombox.Items.Clear()
            DivChartCombox.Items.Clear()
            While reader.Read
                DivCombox.Items.Add(reader("Division").ToString)
                DivChartCombox.Items.Add(reader("Division").ToString)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DivChartCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DivChartCombox.SelectedIndexChanged
        DeptChartCombox.Items.Clear()
        DeptChartCombox.Text = "Select Department"
        Dim division As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        division = DivChartCombox.Text
        Try
            conn.Open()
            Dim query2 As String = "SELECT DISTINCT dept FROM employee WHERE division ='" & division & "' ORDER BY dept;"
            command = New MySqlCommand(query2, conn)
            reader = command.ExecuteReader
            While reader.Read
                DeptChartCombox.Items.Add(reader("dept").ToString)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ViewChartBtn_Click(sender As Object, e As EventArgs) Handles ViewChartBtn.Click

    End Sub

    Sub Load_chart()
        With ByDeptChart
            .Series.Clear()
            .Series.Add("Dept")
        End With
        Dim DA As New MySqlDataAdapter()


    End Sub
End Class