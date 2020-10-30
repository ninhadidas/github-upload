Imports excel = Microsoft.Office.Interop.Excel
Public Class InputTargetFrm
    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim xlsApp As excel.Application
        Dim xlsWorkBook As excel.Workbook
        Dim xlsWorkSheet As excel.Worksheet

        xlsApp = New excel.Application
        Try
            xlsApp = New Microsoft.Office.Interop.Excel.Application
            xlsWorkBook = xlsApp.Workbooks.Open("C:\PAPVN Performance Management Form.xlsx")
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
            xlsWorkBook.PrintOutEx()
            xlsWorkBook.Close(SaveChanges:=False)
            xlsApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Statuslb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Statuslb.LinkClicked
        'StatusForm.Show()
        StatusProgressFrm.Show()
        If Statuslb.Text = "1" Then
            StatusProgressFrm.Status1.Checked = True
            StatusProgressFrm.Status1.Enabled = True
            StatusProgressFrm.Status1.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status1.Checked = False
            StatusProgressFrm.Status1.Enabled = False
            StatusProgressFrm.Status1.ForeColor = Color.Black
        End If

        If Statuslb.Text = "2" Then
            StatusProgressFrm.Status2.Checked = True
            StatusProgressFrm.Status2.Enabled = True
            StatusProgressFrm.Status2.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status2.Checked = False
            StatusProgressFrm.Status2.Enabled = False
            StatusProgressFrm.Status2.ForeColor = Color.Black
        End If

        If Statuslb.Text = "3" Then
            StatusProgressFrm.Status3.Checked = True
            StatusProgressFrm.Status3.Enabled = True
            StatusProgressFrm.Status3.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status3.Checked = False
            StatusProgressFrm.Status3.Enabled = False
            StatusProgressFrm.Status3.ForeColor = Color.Black
        End If

        If Statuslb.Text = "4" Then
            StatusProgressFrm.Status4.Checked = True
            StatusProgressFrm.Status4.Enabled = True
            StatusProgressFrm.Status4.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status4.Checked = False
            StatusProgressFrm.Status4.Enabled = False
            StatusProgressFrm.Status4.ForeColor = Color.Black
        End If

        If Statuslb.Text = "5" Then
            StatusProgressFrm.Status5.Checked = True
            StatusProgressFrm.Status5.Enabled = True
            StatusProgressFrm.Status5.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status5.Checked = False
            StatusProgressFrm.Status5.Enabled = False
            StatusProgressFrm.Status5.ForeColor = Color.Black
        End If

        If Statuslb.Text = "6" Then
            StatusProgressFrm.Status6.Enabled = True
            StatusProgressFrm.Status6.Checked = False
            StatusProgressFrm.Status6.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status6.Checked = False
            StatusProgressFrm.Status6.Enabled = False
            StatusProgressFrm.Status6.ForeColor = Color.Black
        End If

        If Statuslb.Text = "7" Then
            StatusProgressFrm.Status7.Checked = True
            StatusProgressFrm.Status7.Enabled = True
            StatusProgressFrm.Status7.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status7.Checked = False
            StatusProgressFrm.Status7.Enabled = False
            StatusProgressFrm.Status7.ForeColor = Color.Black
        End If

        If Statuslb.Text = "8" Then
            StatusProgressFrm.Status8.Checked = True
            StatusProgressFrm.Status8.Enabled = True
            StatusProgressFrm.Status8.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status8.Checked = False
            StatusProgressFrm.Status8.Enabled = False
            StatusProgressFrm.Status8.ForeColor = Color.Black
        End If
    End Sub
End Class