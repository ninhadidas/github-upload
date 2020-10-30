
Imports excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Public Class SelfAssessFrm
    Private Sub SttLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SttLabel.LinkClicked
        'StatusForm.Show()
        StatusProgressFrm.Show()
        If SttLabel.Text = "1" Then
            StatusProgressFrm.Status1.Checked = True
            StatusProgressFrm.Status1.Enabled = True
            StatusProgressFrm.Status1.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status1.Checked = False
            StatusProgressFrm.Status1.Enabled = False
            StatusProgressFrm.Status1.ForeColor = Color.Black
        End If

        If SttLabel.Text = "2" Then
            StatusProgressFrm.Status2.Checked = True
            StatusProgressFrm.Status2.Enabled = True
            StatusProgressFrm.Status2.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status2.Checked = False
            StatusProgressFrm.Status2.Enabled = False
            StatusProgressFrm.Status2.ForeColor = Color.Black
        End If

        If SttLabel.Text = "3" Then
            StatusProgressFrm.Status3.Checked = True
            StatusProgressFrm.Status3.Enabled = True
            StatusProgressFrm.Status3.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status3.Checked = False
            StatusProgressFrm.Status3.Enabled = False
            StatusProgressFrm.Status3.ForeColor = Color.Black
        End If

        If SttLabel.Text = "4" Then
            StatusProgressFrm.Status4.Checked = True
            StatusProgressFrm.Status4.Enabled = True
            StatusProgressFrm.Status4.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status4.Checked = False
            StatusProgressFrm.Status4.Enabled = False
            StatusProgressFrm.Status4.ForeColor = Color.Black
        End If

        If SttLabel.Text = "5" Then
            StatusProgressFrm.Status5.Checked = True
            StatusProgressFrm.Status5.Enabled = True
            StatusProgressFrm.Status5.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status5.Checked = False
            StatusProgressFrm.Status5.Enabled = False
            StatusProgressFrm.Status5.ForeColor = Color.Black
        End If

        If SttLabel.Text = "6" Then
            StatusProgressFrm.Status6.Enabled = True
            StatusProgressFrm.Status6.Checked = False
            StatusProgressFrm.Status6.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status6.Checked = False
            StatusProgressFrm.Status6.Enabled = False
            StatusProgressFrm.Status6.ForeColor = Color.Black
        End If

        If SttLabel.Text = "7" Then
            StatusProgressFrm.Status7.Checked = True
            StatusProgressFrm.Status7.Enabled = True
            StatusProgressFrm.Status7.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status7.Checked = False
            StatusProgressFrm.Status7.Enabled = False
            StatusProgressFrm.Status7.ForeColor = Color.Black
        End If

        If SttLabel.Text = "8" Then
            StatusProgressFrm.Status8.Checked = True
            StatusProgressFrm.Status8.Enabled = True
            StatusProgressFrm.Status8.ForeColor = Color.Red
        Else
            StatusProgressFrm.Status8.Checked = False
            StatusProgressFrm.Status8.Enabled = False
            StatusProgressFrm.Status8.ForeColor = Color.Black
        End If
    End Sub


    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        TabControl1.SelectedIndex = 1
    End Sub
    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Prev2Btn_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim employeeid As String
        Dim period As String
        Dim appid As String
        Dim reader As MySqlDataReader
        Dim achievement1 As String
        Dim achievement2 As String
        Dim achievement3 As String
        Dim comment1 As String
        Dim comment2 As String
        Dim comment3 As String
        Dim jir1 As String
        Dim jir2 As String
        Dim jin1 As String
        Dim jin2 As String
        Dim ren1 As String
        Dim ren2 As String

        appid = WelcomeMngFrm.EmployeeIdLabel.Text
        employeeid = EmployeeLabel.Text
        period = PeriodLabel.Text
        achievement1 = EmpAchTbx1.Text
        achievement2 = EmpAchTbx2.Text
        achievement3 = EmpAchTbx3.Text
        comment1 = SelComTbx1.Text
        comment2 = SelComTbx2.Text
        comment3 = SelComTbx3.Text
        jir1 = JirTbx1.Text
        jir2 = JirTbx2.Text
        jin1 = JinTbx1.Text
        jin2 = JinTbx2.Text
        ren1 = RenTbx1.Text
        ren2 = RenTbx2.Text
        Try
            conn.Open()
            Dim query3 As String = "UPDATE targetdata SET Sachievement1= '" & achievement1 & "', Sachievement2= '" & achievement2 & "', Sachievement3= '" & achievement3 & "', Scomment1= '" & comment1 & "', Scomment2= '" & comment2 & "', Scomment3= '" & comment3 & "', Jir1= '" & jir1 & "', Jir2= '" & jir2 & "', Jin1= '" & jin1 & "', Jin2= '" & jin2 & "', Ren1= '" & ren1 & "', Ren2= '" & ren2 & "' WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "';"
            command = New MySqlCommand(query3, conn)
            reader = command.ExecuteReader
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
        MessageBox.Show("Self-Assessment were save successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Close()
    End Sub
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

            'Scomment
            xlsWorkSheet.Range("F10").Value = SelComTbx1.Text
            xlsWorkSheet.Range("F12").Value = SelComTbx2.Text
            xlsWorkSheet.Range("F14").Value = SelComTbx3.Text

            xlsWorkSheet.Range("J10").Value = EmpAchTbx1.Text
            xlsWorkSheet.Range("J12").Value = EmpAchTbx2.Text
            xlsWorkSheet.Range("J14").Value = EmpAchTbx3.Text
            xlsApp.Visible = True
            xlsWorkBook.PrintOutEx()
            xlsWorkBook.Close(SaveChanges:=False)
            xlsApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        conn = New MySqlConnection With {
           .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
       }
        Dim employeeid As String
        Dim period As String
        Dim status As Integer
        Dim appid As String
        Dim reader As MySqlDataReader
        Dim achievement1 As String
        Dim achievement2 As String
        Dim achievement3 As String
        Dim comment1 As String
        Dim comment2 As String
        Dim comment3 As String
        Dim jir1 As String
        Dim jir2 As String
        Dim jin1 As String
        Dim jin2 As String
        Dim ren1 As String
        Dim ren2 As String
        Dim result As DialogResult = MessageBox.Show("Are you sure to submit self-assessment?", "Submit self-assessment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            appid = WelcomeMngFrm.EmployeeIdLabel.Text
            status = 5
            employeeid = EmployeeLabel.Text
            period = PeriodLabel.Text
            achievement1 = EmpAchTbx1.Text
            achievement2 = EmpAchTbx2.Text
            achievement3 = EmpAchTbx3.Text
            comment1 = SelComTbx1.Text
            comment2 = SelComTbx2.Text
            comment3 = SelComTbx3.Text
            jir1 = JirTbx1.Text
            jir2 = JirTbx2.Text
            jin1 = JinTbx1.Text
            jin2 = JinTbx2.Text
            ren1 = RenTbx1.Text
            ren2 = RenTbx2.Text
            Try
                conn.Open()
                Dim query3 As String = "UPDATE targetdata SET status = '" & status & "', Sachievement1= '" & achievement1 & "', Sachievement2= '" & achievement2 & "', Sachievement3= '" & achievement3 & "', Scomment1= '" & comment1 & "', Scomment2= '" & comment2 & "', Scomment3= '" & comment3 & "', Jir1= '" & jir1 & "', Jir2= '" & jir2 & "', Jin1= '" & jin1 & "', Jin2= '" & jin2 & "', Ren1= '" & ren1 & "', Ren2= '" & ren2 & "' WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "';"
                command = New MySqlCommand(query3, conn)
                reader = command.ExecuteReader
                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            MessageBox.Show("Sel-Assessment were submit successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub AchieveCbox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AchieveCbox1.SelectedIndexChanged
        EmpAchTbx1.Text = AchieveCbox1.Text
    End Sub

    Private Sub AchieveCbox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AchieveCbox2.SelectedIndexChanged
        EmpAchTbx2.Text = AchieveCbox2.Text
    End Sub

    Private Sub AchieveCbox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AchieveCbox3.SelectedIndexChanged
        EmpAchTbx3.Text = AchieveCbox3.Text
    End Sub
End Class