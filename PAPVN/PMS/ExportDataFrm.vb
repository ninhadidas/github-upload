Imports MySql.Data.MySqlClient
Imports System.Data
Imports excel = Microsoft.Office.Interop.Excel
Public Class ExportDataFrm
    Private Sub ExportDataBtn_Click(sender As Object, e As EventArgs) Handles ExportDataBtn.Click
        Dim xlsApp As excel.Application
        Dim xlsWorkBook As excel.Workbook
        Dim xlsWorkSheet As excel.Worksheet
        Dim conn As MySqlConnection
        Dim division As String
        Dim period As String
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim i, j As Integer
        xlsApp = New excel.Application
        division = DivCombox.Text
        period = PeriodCombox.Text
        If division = "" And period = "" Then
            MessageBox.Show("Nothing to export!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim spath As String = ""
            Dim fo As New SaveFileDialog
            fo.Filter = "All files|*.xlsx"
            fo.CheckPathExists = True
            fo.OverwritePrompt = True
            If fo.ShowDialog() = DialogResult.OK Then
                spath = fo.FileName
            End If
            Try
                xlsApp = New Microsoft.Office.Interop.Excel.Application
                conn.Open()
                If division = "ALL" Then
                    Dim query As String = "SELECT targetdata.period, targetdata.dept, targetdata.employeeid, targetdata.name, targetdata.status, targetdata.title, targetdata.detail, targetdata.difficulty, targetdata.weight, targetdata.scomment1,Sachievement1, comment1, achievement1, title2, detail2, difficulty2, weight2, scomment2, Sachievement2, comment2, achievement2, title3, detail3, difficulty3, weight3, scomment3,Sachievement3, comment3, achievement3, result.difficulty, achievement, evaluation, Jir1, Jir2, Jiritsu, jin1, jin2, Jinsoku, ren1, ren2, Renkei, osc, ose, mbo, competency, total, notable, devplan FROM targetdata , result WHERE targetdata.employeeid = result.employeeid AND targetdata.period ='" & period & "' AND result.period ='" & period & "' ORDER BY targetdata.dept;"
                    Dim dscmd As New MySqlDataAdapter(query, conn)
                    Dim ds As New DataSet
                    dscmd.Fill(ds)

                    xlsWorkBook = xlsApp.Workbooks.Open("C:\PAPVN\Export_format.xlsx")
                    xlsWorkSheet = xlsWorkBook.Sheets(1)
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        For j = 0 To ds.Tables(0).Columns.Count - 1
                            xlsWorkSheet.Cells(i + 7, j + 1) =
                                ds.Tables(0).Rows(i).Item(j)
                        Next
                    Next
                    xlsWorkBook.SaveAs(spath)
                    MessageBox.Show("Successfully Exported!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    xlsWorkBook.Close()
                Else
                    Dim query As String = "SELECT DISTINCT targetdata.period, targetdata.dept, targetdata.employeeid, targetdata.name,targetdata.status, targetdata.title, targetdata.detail, targetdata.difficulty, targetdata.weight, targetdata.scomment1,Sachievement1, result.comment1, result.achievement1, title2, detail2, difficulty2, weight2, scomment2,Sachievement2, result.comment2, result.achievement2, title3, detail3, difficulty3, weight3, scomment3,Sachievement3, result.comment3, result.achievement3, result.difficulty, result.achievement,result.evaluation, Jir1, Jir2, Jiritsu, jin1, jin2, Jinsoku, ren1, ren2, Renkei, osc, ose, mbo, competency, total, notable, devplan FROM targetdata INNER JOIN employee ON targetdata.employeeid = employee.EmployeeID INNER JOIN result ON targetdata.employeeid = result.employeeid WHERE employee.Division ='" & division & "' AND targetdata.period ='" & period & "' AND result.period ='" & period & "' ORDER BY employee.dept;"
                    Dim dscmd As New MySqlDataAdapter(query, conn)
                    Dim ds As New DataSet
                    dscmd.Fill(ds)
                    xlsWorkBook = xlsApp.Workbooks.Open("C:\PAPVN\Export_format.xlsx")
                    xlsWorkSheet = xlsWorkBook.Sheets(1)
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        For j = 0 To ds.Tables(0).Columns.Count - 1
                            xlsWorkSheet.Cells(i + 7, j + 1) =
                            ds.Tables(0).Rows(i).Item(j)
                        Next
                    Next
                    xlsWorkBook.SaveAs(spath)
                    MessageBox.Show("Successfully Exported!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    xlsWorkBook.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                xlsApp.Quit()
            End Try
        End If
    End Sub

    Private Sub ExportDataFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
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
            While reader.Read
                DivCombox.Items.Add(reader("Division").ToString)
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

    Private Sub DivCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DivCombox.SelectedIndexChanged
        Dim division As String
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Try
            conn.Open()
            division = DivCombox.Text
            Dim query As String = "SELECT DISTINCT dept FROM employee WHERE division = '" & division & "' ORDER BY Dept;"
            command = New MySqlCommand(query, conn)
            reader = Command.ExecuteReader
            DeptCombox.Items.Clear()
            While reader.Read
                DeptCombox.Items.Add(reader("Dept").ToString)
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

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        MasterGridUser.Show()
    End Sub
End Class