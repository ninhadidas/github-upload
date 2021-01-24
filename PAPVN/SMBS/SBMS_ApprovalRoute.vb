Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class SBMS_ApprovalRoute
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Function saveData(sql As String)
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim resul As Boolean
        Try

            conn.Open()
            command = New MySqlCommand
            With command
                .Connection = conn
                .CommandText = sql
                resul = .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return resul
    End Function
    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        With OpenFileDialog1
            .Filter = "Excel files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data from Excel file"
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileLocation.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("File upload successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub

    Private Sub UploadBtn_Click(sender As Object, e As EventArgs) Handles UploadBtn.Click
        Dim OLEcon As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & FileLocation.Text & " ; " & "Extended Properties=Excel 12.0;")
        Dim OLEcmd As New OleDb.OleDbCommand
        Dim OLEda As New OleDb.OleDbDataAdapter
        Dim OLEdt As New DataTable
        Dim sql As String
        Dim resul As Boolean

        Try
            OLEcon.Open()
            With OLEcmd
                .Connection = OLEcon
                .CommandText = "select * from [Sheet1$A1:E40]"
            End With
            OLEda.SelectCommand = OLEcmd
            OLEda.Fill(OLEdt)
            For Each r As DataRow In OLEdt.Rows
                sql = "INSERT INTO tbl_approval (approval_id, employee_id, App1, App2, App3) VALUES ('" & r(0).ToString & "', '" & r(1).ToString & "', '" & r(2).ToString & "', '" & r(3).ToString & "', '" & r(4).ToString & "')"
                resul = saveData(sql)
                If resul Then
                    Timer1.Start()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OLEcon.Close()
        End Try

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT employee_id, App1, App2 FROM tbl_approval;"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            reader.Close()
            If count >= 1 Then
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                ApprovalRouteView.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With ApprovalRouteView
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Employee ID"
                    .Columns(0).Width = 150
                    .Columns(1).HeaderCell.Value = "Approver 1"
                    .Columns(1).Width = 150
                    .Columns(2).HeaderCell.Value = "Approver 2"
                    .Columns(2).Width = 150
                End With
                conn.Close()
                'Else
                '    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub
End Class