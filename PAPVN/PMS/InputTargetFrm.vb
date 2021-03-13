Imports excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Public Class InputTargetFrm
    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim xlsApp As excel.Application
        Dim xlsWorkBook As excel.Workbook
        Dim xlsWorkSheet As excel.Worksheet

        xlsApp = New excel.Application
        Try
            xlsApp = New Microsoft.Office.Interop.Excel.Application
            xlsWorkBook = xlsApp.Workbooks.Open("C:\PAPVN\PAPVN Performance Management Form.xlsx")
            xlsWorkSheet = xlsWorkBook.Sheets("Form")
            xlsWorkSheet.Cells(3, 3) = "Period: " & PeriodLabel.Text
            xlsWorkSheet.Range("F3").Value = DeptLabel.Text
            xlsWorkSheet.Range("O3").Value = EmployeeLabel.Text
            xlsWorkSheet.Range("J3").Value = NameLabel.Text

            'export target 1
            xlsWorkSheet.Range("C10").Value = "Title: " & TitleTbx1.Text
            xlsWorkSheet.Range("C11").Value = ContentTbx1.Text
            xlsWorkSheet.Range("E11").Value = Int32.Parse(WeightTbx1.Text) / 100
            xlsWorkSheet.Range("D11").Value = DiffTbx1.Text

            'export target 2
            xlsWorkSheet.Range("C12").Value = "Title: " & TitleTbx2.Text
            xlsWorkSheet.Range("C13").Value = ContentTbx2.Text
            xlsWorkSheet.Range("E13").Value = Int32.Parse(WeightTbx2.Text) / 100
            xlsWorkSheet.Range("D13").Value = DiffTbx2.Text

            'export target3
            xlsWorkSheet.Range("C14").Value = "Title: " & TitleTxb3.Text
            xlsWorkSheet.Range("C15").Value = ContentTbx3.Text
            xlsWorkSheet.Range("E15").Value = Int32.Parse(WeightTbx3.Text) / 100
            xlsWorkSheet.Range("D15").Value = DiffTbx3.Text
            xlsApp.Visible = True
            'xlsWorkBook.PrintOutEx()
            xlsWorkBook.PrintPreview()
            xlsWorkBook.Close(SaveChanges:=False)
            xlsApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Statuslb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Statuslb.LinkClicked
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub TabControl1_Enter(sender As Object, e As EventArgs) Handles TabControl1.Enter
        Dim status As String = Statuslb.Text
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim username As String = EmployeeLabel.Text
        Dim count As Integer
        Dim app1 As String
        Dim app2 As String

        If status = "1" Then
            Status1.Checked = True
            Status1.Enabled = True
            Status1.ForeColor = Color.Red
        Else
            Status1.Checked = False
            Status1.Enabled = False
            Status1.ForeColor = Color.Black
        End If

        If Statuslb.Text = "2" Then
            Status2.Checked = True
            Status2.Enabled = True
            Status2.ForeColor = Color.Red
        Else
            Status2.Checked = False
            Status2.Enabled = False
            Status2.ForeColor = Color.Black
        End If

        If Statuslb.Text = "3" Then
            Status3.Checked = True
            Status3.Enabled = True
            Status3.ForeColor = Color.Red
        Else
            Status3.Checked = False
            Status3.Enabled = False
            Status3.ForeColor = Color.Black
        End If

        If Statuslb.Text = "4" Then
            Status4.Checked = True
            Status4.Enabled = True
            Status4.ForeColor = Color.Red
        Else
            Status4.Checked = False
            Status4.Enabled = False
            Status4.ForeColor = Color.Black
        End If

        If Statuslb.Text = "5" Then
            Status5.Checked = True
            Status5.Enabled = True
            Status5.ForeColor = Color.Red
        Else
            Status5.Checked = False
            Status5.Enabled = False
            Status5.ForeColor = Color.Black
        End If

        If Statuslb.Text = "6" Then
            Status6.Enabled = True
            Status6.Checked = False
            Status6.ForeColor = Color.Red
        Else
            Status6.Checked = False
            Status6.Enabled = False
            Status6.ForeColor = Color.Black
        End If

        If Statuslb.Text = "7" Then
            Status7.Checked = True
            Status7.Enabled = True
            Status7.ForeColor = Color.Red
        Else
            Status7.Checked = False
            Status7.Enabled = False
            Status7.ForeColor = Color.Black
        End If

        If Statuslb.Text = "8" Then
            Status8.Checked = True
            Status8.Enabled = True
            Status8.ForeColor = Color.Red
        Else
            Status8.Checked = False
            Status8.Enabled = False
            Status8.ForeColor = Color.Black
        End If

        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT App1, App2 FROM employee WHERE EmployeeID = '" & username & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count = 1 Then
                App1Lbl.Text = reader("App1").ToString
                App2Lbl.Text = reader("App2").ToString
                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
        app1 = App1Lbl.Text
        app2 = App2Lbl.Text
        Try
            conn.Open()
            Dim query As String = "SELECT Name FROM manager WHERE EmployeeID = '" & app1 & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count = 1 Then
                App1Lbl.Text = reader("Name").ToString
                reader.Close()
            End If

            Dim query2 As String = "SELECT Name FROM manager WHERE EmployeeID = '" & app2 & "';"
            command = New MySqlCommand(query2, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count = 1 Then
                App2Lbl.Text = reader("Name").ToString
                reader.Close()
            Else
                App2Lbl.Text = "N/A"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim answer As Integer
        answer = MessageBox.Show("Are you sure to clear target No2? Target No3 (if available will replace No2)", "Please confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            TitleTbx2.Text = Nothing
            ContentTbx2.Text = Nothing
            WeightTbx2.Text = "0"
            DiffTbx2.Text = Nothing
            If TitleTxb3.Text <> Nothing Or ContentTbx3.Text <> Nothing Then
                TitleTbx2.Text = TitleTxb3.Text
                ContentTbx2.Text = ContentTbx3.Text
                WeightTbx2.Text = WeightTbx3.Text
                DiffTbx2.Text = DiffTbx3.Text
                TitleTxb3.Text = Nothing
                ContentTbx3.Text = Nothing
                WeightTbx3.Text = "0"
                DiffTbx3.Text = Nothing
            End If
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        TitleTxb3.Text = Nothing
        ContentTbx3.Text = Nothing
        WeightTbx3.Text = "0"
        DiffTbx3.Text = Nothing
    End Sub
End Class