
Imports excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Public Class OldPeriodViewFrm
    Private Sub Statuslb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Statuslb.LinkClicked

    End Sub
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Next2Btn_Click(sender As Object, e As EventArgs) Handles Next2Btn.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Prev2Btn_Click(sender As Object, e As EventArgs) Handles Prev2Btn.Click
        TabControl1.SelectedIndex = 1
    End Sub
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

            'Scomment
            xlsWorkSheet.Range("F10").Value = SelComTbx1.Text
            xlsWorkSheet.Range("F12").Value = SelComTbx2.Text
            xlsWorkSheet.Range("F14").Value = SelComTbx3.Text

            xlsWorkSheet.Range("J10").Value = EmpAchTbx1.Text
            xlsWorkSheet.Range("J12").Value = EmpAchTbx2.Text
            xlsWorkSheet.Range("J14").Value = EmpAchTbx3.Text

            xlsWorkSheet.Range("K10").Value = SupComTbx1.Text
            xlsWorkSheet.Range("K12").Value = SupComTbx2.Text
            xlsWorkSheet.Range("K14").Value = SupComTbx3.Text

            xlsWorkSheet.Range("O10").Value = SupAchTbx1.Text
            xlsWorkSheet.Range("O12").Value = SupAchTbx2.Text
            xlsWorkSheet.Range("O14").Value = SupAchTbx3.Text

            xlsWorkSheet.Range("D28").Value = JirTbx1.Text
            xlsWorkSheet.Range("D31").Value = JinTbx1.Text
            xlsWorkSheet.Range("D34").Value = RenTbx1.Text

            xlsWorkSheet.Range("I28").Value = JirTbx2.Text
            xlsWorkSheet.Range("I31").Value = JinTbx2.Text
            xlsWorkSheet.Range("I34").Value = RenTbx2.Text

            xlsWorkSheet.Range("M28").Value = SupEvaTbx1.Text
            xlsWorkSheet.Range("M31").Value = SupEvaTbx2.Text
            xlsWorkSheet.Range("M34").Value = SupEvaTbx3.Text

            xlsWorkSheet.Range("B39").Value = OvrSupCmTbx.Text
            xlsWorkSheet.Range("B61").Value = NotableTbx.Text
            xlsWorkSheet.Range("B66").Value = DevPlanTbx.Text
            ' xlsWorkSheet.Range("D45").Value = MngObjLbl.Text
            ' xlsWorkSheet.Range("N45").Value = TotalEvaLbl.Text
            xlsApp.Visible = True
            xlsWorkBook.PrintPreview()
            xlsWorkBook.Close(SaveChanges:=False)
            xlsApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class