
Imports excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Imports outlook = Microsoft.Office.Interop.Outlook
Public Class SelfAssessFrm
    Private Sub Statuslb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Statuslb.LinkClicked
        TabControl1.SelectedIndex = 2
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
        Dim count As Integer
        Dim name As String = NameLabel.Text
        Dim jir1 As String
        Dim jir2 As String
        Dim jin1 As String
        Dim jin2 As String
        Dim ren1 As String
        Dim ren2 As String
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
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
                Dim query_mail As String = "SELECT manager.email FROM manager INNER JOIN employee ON manager.employeeid = employee.app1 WHERE employee.employeeid ='" & employeeid & "';"
                command = New MySqlCommand(query_mail, conn)
                reader = command.ExecuteReader
                count = 0
                While reader.Read
                    count = +1
                End While
                If count = 1 Then
                    Try
                        OutlookMessage = AppOutlook.CreateItem(outlook.OlItemType.olMailItem)
                        Dim Recipents As outlook.Recipients = OutlookMessage.Recipients
                        Dim address As String
                        address = reader("email").ToString
                        Recipents.Add(address)
                        OutlookMessage.Subject = "Self-Assessment Submitted - Performance Management System."
                        OutlookMessage.Body = "Dear Manager, " & vbNewLine & " " & vbNewLine & "Your team member, " & name & " (Employee ID: " & employeeid & ") submitted self-assessment on Performance Management System." & vbNewLine & "Please open the system, check it and have discussion with him/her." & vbNewLine & "" & vbNewLine & "*This message is automatically sent from system."
                        OutlookMessage.BodyFormat = outlook.OlBodyFormat.olFormatHTML
                        OutlookMessage.Send()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        OutlookMessage = Nothing
                        AppOutlook = Nothing
                    End Try
                Else
                    MessageBox.Show("Mail could not be sent") 'if you dont want this message, simply delete this line 
                End If
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
            'StatusProgressFrm.app1.Text = "Next reviewer:" & vbNewLine & "" & reviewer & ""
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
            Status6.Checked = True
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
                App1IDLbl.Text = reader("App1").ToString
                App2IDLbl.Text = reader("App2").ToString
                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
        app1 = App1IDLbl.Text
        app2 = App2IDLbl.Text
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

    Private Sub CompetencyBtn_Click(sender As Object, e As EventArgs) Handles CompetencyBtn.Click
        Competency.Show()
    End Sub
End Class