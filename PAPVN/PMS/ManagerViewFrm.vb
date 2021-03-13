
Imports excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Public Class ManagerViewFrm
    Private Sub SupEvaCbx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupEvaCbx1.SelectedIndexChanged
        SupEvaTbx1.Text = SupEvaCbx1.Text
    End Sub

    Private Sub SupEvaCbx2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupEvaCbx2.SelectedIndexChanged
        SupEvaTbx2.Text = SupEvaCbx2.Text
    End Sub

    Private Sub SupEvaCbx3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupEvaCbx3.SelectedIndexChanged
        SupEvaTbx3.Text = SupEvaCbx3.Text
    End Sub
    Private Sub Statuslb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Statuslb.LinkClicked
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub ApproveBtn_Click(sender As Object, e As EventArgs) Handles ApproveBtn.Click
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim employeeid As String
        Dim period As String
        Dim status As Integer
        Dim appid As String
        Dim reader As MySqlDataReader
        Dim count As Integer

        appid = WelcomeMngFrm.EmployeeIdLabel.Text

        Dim result As DialogResult = MessageBox.Show("Are you sure to approve the targets?", "Approve Targets", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            status = Statuslb.Text
            employeeid = EmployeeLabel.Text
            period = PeriodLabel.Text

            If status = 2 Then '1st approval
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM employee WHERE employeeid = '" & employeeid & "' AND app1 = '" & appid & "' AND app2 = '0';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count += 1
                    End While
                    reader.Close()
                    If count = 1 Then
                        status = 4
                    Else
                        status = 3
                    End If
                    Dim query3 As String = "UPDATE targetdata SET status= '" & status & "', time=now() WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "' ;"
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
            End If

            If status = 3 Then '2nd approval
                Try
                    conn.Open()
                    Dim query2 As String = "SELECT * FROM employee WHERE employeeid = '" & employeeid & "' AND app2 = '" & appid & "';"
                    command = New MySqlCommand(query2, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count += 1
                    End While
                    reader.Close()
                    If count = 1 Then
                        status = 4
                    End If
                    Dim query3 As String = "UPDATE targetdata SET status= '" & status & "' WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "' ;"
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
            End If
            MessageBox.Show("Targets were submitted!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        End If
            DataGridUser.Controls.Clear() 'removes all the controls on the form
        DataGridUser.InitializeComponent() 'load all the controls again
        DataGridUser.DataGridUser_Load(e, e) 'Load everything in your form, load event again
    End Sub

    Private Sub RejectBtn_Click(sender As Object, e As EventArgs) Handles RejectBtn.Click
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim employeeid As String
        Dim period As String
        Dim status As Integer
        Dim appid As String
        Dim reader As MySqlDataReader
        appid = WelcomeMngFrm.EmployeeIdLabel.Text

        Dim result As DialogResult = MessageBox.Show("Are you sure to reject the targets?", "Reject Targets", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            status = Statuslb.Text
            employeeid = EmployeeLabel.Text
            period = PeriodLabel.Text
            conn.Open()

            If status = 2 Then '1st approval
                status = 1
                Dim query As String = "UPDATE targetdata SET status= '" & status & "', time=now() WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "' ;"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
                conn.Close()
            Else
                status = 2
                Dim query As String = "UPDATE targetdata SET status= '" & status & "', time=now() WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "' ;"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
                conn.Close()
            End If
            MessageBox.Show("Targets were rejected!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
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

    'Private Sub CalculateBtn_Click(sender As Object, e As EventArgs)
    '    Dim a As Integer
    '    Dim b As Integer
    '    Dim c As Integer
    '    Dim d As Integer
    '    Dim g As Integer
    '    Dim f As Integer
    '    Dim X As Double
    '    Dim Y As Double
    '    Dim z As Double
    '    Dim u As Integer
    '    Dim v As Integer
    '    Dim w As Integer

    '    If SupAchTbx3.Text = "" Then
    '        SupAchLb1.Text = "0"
    '    End If

    '    If SupAchTbx2.Text = "" Then
    '        SupAchLb2.Text = "0"
    '    End If

    '    'difficult * weight
    '    a = Val(DiffTbx1.Text) * Val(WeightTbx1.Text)
    '    b = Val(DiffTbx2.Text) * Val(WeightTbx2.Text)
    '    c = Val(DiffTbx3.Text) * Val(WeightTbx3.Text)

    '    'achieve * weight
    '    d = Val(WeightTbx1.Text) * Val(SupAchLb1.Text)
    '    g = Val(WeightTbx2.Text) * Val(SupAchLb2.Text)
    '    f = Val(WeightTbx2.Text) * Val(SupAchLb3.Text)

    '    X = (a + b + c) / 100 'Overall Difficulty
    '    Y = (d + g + f) / 100 'Overall Achievement

    '    If X >= 1.5 And X <= 1.9 Then
    '        X = 2
    '    ElseIf X >= 2.5 And X <= 2.9 Then
    '        X = 3
    '    Else X = 1
    '    End If

    '    If Y >= 1.5 And Y <= 1.9 Then
    '        Y = 2
    '    ElseIf Y >= 2.5 And Y <= 2.9 Then
    '        Y = 3
    '    Else Y = 1
    '    End If

    '    OvrDiffScore.Text = Y
    '    z = X + Y 'Evaluation

    '    v = Val(SupEvaLb1.Text) + Val(SupEvaLb2.Text) + Val(SupEvaLb3.Text) 'superior evaluation
    '    u = v / 3 'averange superior evaluation

    '    'Difficulty sum table
    '    If X >= 2.5 Then
    '        OvrDiffLbl.Text = "D3: Challenging for the position"
    '    Else
    '        If X >= 1.5 Then
    '            OvrDiffLbl.Text = "D2: Appropriate for the position"
    '        Else
    '            If X >= 0.5 Then
    '                OvrDiffLbl.Text = "D1: Easy for the position"
    '            End If

    '        End If

    '        'Achievement sum table
    '        If Y >= 2.5 Then
    '            OvrAchLbl.Text = "A3: Highly achieved"
    '        Else
    '            If Y >= 1.5 Then
    '                OvrAchLbl.Text = "A2: Achieved"
    '            Else
    '                If Y >= 0.5 Then
    '                    OvrAchLbl.Text = "A1: Not achieved"
    '                End If
    '            End If

    '        End If
    '        'MBO result table
    '        If z >= 5.5 Then
    '            OvrEvaLbl.Text = "M5: Outstanding"
    '            MBOScoreLb.Text = "5"
    '            MngObjLbl.Text = "M5"
    '        End If

    '        If z >= 4.5 And z < 5.5 Then
    '            OvrEvaLbl.Text = "M4: Exceeds expectation"
    '            MBOScoreLb.Text = "4"
    '            MngObjLbl.Text = "M4"
    '        End If

    '        If z >= 3.5 And z < 4.5 Then
    '            OvrEvaLbl.Text = "M3: Meets expectation"
    '            MBOScoreLb.Text = "3"
    '            MngObjLbl.Text = "M3"
    '        End If

    '        If z >= 2.5 And z < 3.5 Then
    '            OvrEvaLbl.Text = "M2: Under expectation"
    '            MBOScoreLb.Text = "2"
    '            MngObjLbl.Text = "M2"
    '        End If

    '        If z >= 1.5 And z < 2.5 Then
    '            OvrEvaLbl.Text = "M1: Unsatisfactory"
    '            MBOScoreLb.Text = "1"
    '            MngObjLbl.Text = "M1"
    '        End If

    '        'Overall Superior's Evaluation
    '        If u = 5 Then
    '            OvrSupEvaTbx.Text = "C5: Outstanding"
    '        End If

    '        If u = 4 Then
    '            OvrSupEvaTbx.Text = "C4: Excellent"
    '        End If

    '        If u = 3 Then
    '            OvrSupEvaTbx.Text = "C3: Standard"
    '        End If

    '        If u = 2 Then
    '            OvrSupEvaTbx.Text = "C2: Need Improvement"
    '        End If

    '        If u = 1 Then
    '            OvrSupEvaTbx.Text = "C1: Bad/Poor"
    '        End If

    '        'Total evaluation
    '        w = Val(MBOScoreLb.Text) * Val(CompetencyScore.Text)
    '        If w >= 20 Then
    '            TotalEvaLbl.Text = "5"
    '        End If

    '        If w >= 12 And w < 20 Then
    '            TotalEvaLbl.Text = "4"
    '        End If

    '        If w >= 6 And w < 12 Then
    '            TotalEvaLbl.Text = "3"
    '        End If

    '        If w >= 3 And w < 6 Then
    '            TotalEvaLbl.Text = "2"
    '        End If

    '        If w >= 1 And w < 3 Then
    '            TotalEvaLbl.Text = "1"
    '        End If
    '    End If
    'End Sub

    Private Sub DiffTbx1_TextChanged(sender As Object, e As EventArgs) Handles DiffTbx1.TextChanged

        If DiffTbx1.Text = "D1: Easy for the position" Then
            Diff1ValueLb.Text = "1"
        Else
            If DiffTbx1.Text = "D2: Appropriate for the position" Then
                Diff1ValueLb.Text = "2"
            Else
                If DiffTbx1.Text = "D3: Challenging for the position" Then
                    Diff1ValueLb.Text = "3"
                End If
            End If
        End If
    End Sub

    Private Sub DiffTbx2_TextChanged(sender As Object, e As EventArgs) Handles DiffTbx2.TextChanged
        If DiffTbx2.Text = "D1: Easy for the position" Then
            Diff2ValueLb.Text = "1"
        Else
            If DiffTbx2.Text = "D2: Appropriate for the position" Then
                Diff2ValueLb.Text = "2"
            Else
                If DiffTbx2.Text = "D3: Challenging for the position" Then
                    Diff2ValueLb.Text = "3"
                End If
            End If
        End If
    End Sub

    Private Sub DiffTbx3_TextChanged(sender As Object, e As EventArgs) Handles DiffTbx3.TextChanged
        If DiffTbx3.Text = "D1: Easy for the position" Then
            Diff3ValueLb.Text = "1"
        Else
            If DiffTbx3.Text = "D2: Appropriate for the position" Then
                Diff3ValueLb.Text = "2"
            Else
                If DiffTbx3.Text = "D3: Challenging for the position" Then
                    Diff3ValueLb.Text = "3"
                End If
            End If
        End If
    End Sub

    Private Sub SupAchTbx1_TextChanged(sender As Object, e As EventArgs) Handles SupAchTbx1.TextChanged
        If SupAchTbx1.Text = "A3: Highly achieved" Then
            SupAchLb1.Text = "3"
        Else
            If SupAchTbx1.Text = "A2: Achieved" Then
                SupAchLb1.Text = "2"
            Else
                If SupAchTbx1.Text = "A1: Not achieved" Then
                    SupAchLb1.Text = "1"
                End If
            End If
        End If
    End Sub

    Private Sub SupAchTbx2_TextChanged(sender As Object, e As EventArgs) Handles SupAchTbx2.TextChanged
        If SupAchTbx2.Text = "A3: Highly achieved" Then
            SupAchLb2.Text = "3"
        Else
            If SupAchTbx2.Text = "A2: Achieved" Then
                SupAchLb2.Text = "2"
            Else
                If SupAchTbx2.Text = "A1: Not achieved" Then
                    SupAchLb2.Text = "1"
                End If
            End If
        End If
    End Sub

    Private Sub SupAchTbx3_TextChanged(sender As Object, e As EventArgs) Handles SupAchTbx3.TextChanged
        If SupAchTbx3.Text = "A3: Highly achieved" Then
            SupAchLb3.Text = "3"
        Else
            If SupAchTbx3.Text = "A2: Achieved" Then
                SupAchLb3.Text = "2"
            Else
                If SupAchTbx3.Text = "A1: Not achieved" Then
                    SupAchLb3.Text = "1"
                End If
            End If
        End If
    End Sub

    Private Sub OvrSupEvaTbx_TextChanged(sender As Object, e As EventArgs) Handles OvrSupEvaTbx.TextChanged
        If OvrSupEvaTbx.Text = "C5: Outstanding" Then
            ComScrLbl.Text = "C5"
            CompetencyScore.Text = "5"
        Else
            If OvrSupEvaTbx.Text = "C4: Excellent" Then
                ComScrLbl.Text = "C4"
                CompetencyScore.Text = "4"
            Else
                If OvrSupEvaTbx.Text = "C3: Standard" Then
                    ComScrLbl.Text = "C3"
                    CompetencyScore.Text = "3"
                Else
                    If OvrSupEvaTbx.Text = "C2: Need Improvement" Then
                        ComScrLbl.Text = "C2"
                        CompetencyScore.Text = "2"
                    Else
                        If OvrSupEvaTbx.Text = "C1: Bad/Poor" Then
                            ComScrLbl.Text = "C1"
                            CompetencyScore.Text = "1"
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SupEvaTbx1_TextChanged(sender As Object, e As EventArgs) Handles SupEvaTbx1.TextChanged
        If SupEvaTbx1.Text = "C5: Outstanding" Then
            SupEvaLb1.Text = "5"
        Else
            If SupEvaTbx1.Text = "C4: Excellent" Then
                SupEvaLb1.Text = "4"
            Else
                If SupEvaTbx1.Text = "C3: Standard" Then
                    SupEvaLb1.Text = "3"
                Else
                    If SupEvaTbx1.Text = "C2: Need Improvement" Then
                        SupEvaLb1.Text = "2"
                    Else
                        If SupEvaTbx1.Text = "C1: Bad/Poor" Then
                            SupEvaLb1.Text = "1"
                        End If
                    End If
                End If
            End If
        End If
        Dim u As Integer
        Dim v As Integer
        v = Val(SupEvaLb1.Text) + Val(SupEvaLb2.Text) + Val(SupEvaLb3.Text) 'superior evaluation
        u = v / 3 'averange superior evaluation

        If u = 5 Then
            OvrSupEvaTbx.Text = "C5: Outstanding"
        End If

        If u = 4 Then
            OvrSupEvaTbx.Text = "C4: Excellent"
        End If

        If u = 3 Then
            OvrSupEvaTbx.Text = "C3: Standard"
        End If

        If u = 2 Then
            OvrSupEvaTbx.Text = "C2: Need Improvement"
        End If

        If u = 1 Then
            OvrSupEvaTbx.Text = "C1: Bad/Poor"
        End If

    End Sub

    Private Sub SupEvaTbx2_TextChanged(sender As Object, e As EventArgs) Handles SupEvaTbx2.TextChanged
        If SupEvaTbx2.Text = "C5: Outstanding" Then
            SupEvaLb2.Text = "5"
        Else
            If SupEvaTbx2.Text = "C4: Excellent" Then
                SupEvaLb2.Text = "4"
            Else
                If SupEvaTbx2.Text = "C3: Standard" Then
                    SupEvaLb2.Text = "3"
                Else
                    If SupEvaTbx2.Text = "C2: Need Improvement" Then
                        SupEvaLb2.Text = "2"
                    Else
                        If SupEvaTbx2.Text = "C1: Bad/Poor" Then
                            SupEvaLb2.Text = "1"
                        End If
                    End If
                End If
            End If
        End If
        Dim u As Integer
        Dim v As Integer
        v = Val(SupEvaLb1.Text) + Val(SupEvaLb2.Text) + Val(SupEvaLb3.Text) 'superior evaluation
        u = v / 3 'averange superior evaluation

        If u = 5 Then
            OvrSupEvaTbx.Text = "C5: Outstanding"
        End If

        If u = 4 Then
            OvrSupEvaTbx.Text = "C4: Excellent"
        End If

        If u = 3 Then
            OvrSupEvaTbx.Text = "C3: Standard"
        End If

        If u = 2 Then
            OvrSupEvaTbx.Text = "C2: Need Improvement"
        End If

        If u = 1 Then
            OvrSupEvaTbx.Text = "C1: Bad/Poor"
        End If
    End Sub

    Private Sub SupEvaTbx3_TextChanged(sender As Object, e As EventArgs) Handles SupEvaTbx3.TextChanged
        If SupEvaTbx3.Text = "C5: Outstanding" Then
            SupEvaLb3.Text = "5"
        Else
            If SupEvaTbx3.Text = "C4: Excellent" Then
                SupEvaLb3.Text = "4"
            Else
                If SupEvaTbx3.Text = "C3: Standard" Then
                    SupEvaLb3.Text = "3"
                Else
                    If SupEvaTbx3.Text = "C2: Need Improvement" Then
                        SupEvaLb3.Text = "2"
                    Else
                        If SupEvaTbx3.Text = "C1: Bad/Poor" Then
                            SupEvaLb3.Text = "1"
                        End If
                    End If
                End If
            End If
        End If
        Dim u As Integer
        Dim v As Integer
        v = Val(SupEvaLb1.Text) + Val(SupEvaLb2.Text) + Val(SupEvaLb3.Text) 'superior evaluation
        u = v / 3 'averange superior evaluation

        If u = 5 Then
            OvrSupEvaTbx.Text = "C5: Outstanding"
        End If

        If u = 4 Then
            OvrSupEvaTbx.Text = "C4: Excellent"
        End If

        If u = 3 Then
            OvrSupEvaTbx.Text = "C3: Standard"
        End If

        If u = 2 Then
            OvrSupEvaTbx.Text = "C2: Need Improvement"
        End If

        If u = 1 Then
            OvrSupEvaTbx.Text = "C1: Bad/Poor"
        End If
    End Sub

    Private Sub ApproveRstBtn_Click(sender As Object, e As EventArgs) Handles ApproveRstBtn.Click
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim employeeid As String
        Dim period As String
        Dim status As Integer
        Dim appid As String
        Dim reader As MySqlDataReader
        Dim count As Integer
        Dim mbo As String
        Dim competency As String
        Dim evaluation As String
        Dim difficulty As String
        Dim achievement1 As String
        Dim achievement As String
        Dim achievement2 As String
        Dim achievement3 As String
        Dim total As String
        Dim comment1 As String
        Dim comment2 As String
        Dim comment3 As String
        Dim ose As String
        Dim osc As String
        Dim jiritsu As String
        Dim jinsoku As String
        Dim renkei As String
        Dim notable As String

        appid = WelcomeMngFrm.EmployeeIdLabel.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to approve the result?", "Approve result", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            status = Statuslb.Text
            employeeid = EmployeeLabel.Text
            period = PeriodLabel.Text
            notable = NotableTbx.Text
            osc = OvrSupCmTbx.Text
            ose = OvrSupEvaTbx.Text
            comment1 = SupComTbx1.Text
            comment2 = SupComTbx2.Text
            comment3 = SupComTbx3.Text
            mbo = MngObjLbl.Text
            competency = ComScrLbl.Text
            total = TotalEvaLbl.Text
            jiritsu = SupEvaTbx1.Text
            jinsoku = SupEvaTbx2.Text
            renkei = SupEvaTbx3.Text
            difficulty = OvrDiffLbl.Text
            evaluation = OvrEvaLbl.Text
            achievement1 = SupAchTbx1.Text
            achievement2 = SupAchTbx2.Text
            achievement3 = SupAchTbx3.Text
            achievement = OvrAchLbl.Text

            If status = 5 Then '1st approval
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM employee WHERE employeeid = '" & employeeid & "' AND app1 = '" & appid & "' AND app2 = '0';"
                    command = New MySqlCommand(query, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count += 1
                    End While
                    reader.Close()
                    If count = 1 Then
                        status = 7
                    Else
                        status = 6
                    End If
                    Dim query3 As String = "UPDATE result, targetdata SET targetdata.status ='" & status & "', notable= '" & notable & "', osc= '" & osc & "', result.comment1= '" & comment1 & "', result.comment2= '" & comment2 & "', result.comment3= '" & comment3 & "' , mbo= '" & mbo & "' , competency= '" & competency & "', total= '" & total & "', ose= '" & ose & "', jiritsu= '" & jiritsu & "', jinsoku= '" & jinsoku & "', renkei= '" & renkei & "', result.difficulty= '" & difficulty & "', evaluation= '" & evaluation & "', achievement= '" & achievement & "', achievement1= '" & achievement1 & "',achievement2= '" & achievement2 & "',achievement3= '" & achievement3 & "' WHERE result.employeeid = '" & employeeid & "' AND result.period =  '" & period & "' AND targetdata.employeeid = '" & employeeid & "' AND targetdata.period =  '" & period & "' ;"
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
            End If

            If status = 6 Then '2nd approval
                Try
                    conn.Open()
                    Dim query2 As String = "SELECT * FROM employee WHERE employeeid = '" & employeeid & "' AND app2 = '" & appid & "';"
                    command = New MySqlCommand(query2, conn)
                    reader = command.ExecuteReader
                    count = 0
                    While reader.Read
                        count += 1
                    End While
                    reader.Close()
                    If count = 1 Then
                        status = 7
                    End If
                    Dim query3 As String = "UPDATE result, targetdata SET targetdata.status ='" & status & "', notable= '" & notable & "', osc= '" & osc & "', result.comment1= '" & comment1 & "', result.comment2= '" & comment2 & "', result.comment3= '" & comment3 & "' , mbo= '" & mbo & "' , competency= '" & competency & "', total= '" & total & "', ose= '" & ose & "', jiritsu= '" & jiritsu & "', jinsoku= '" & jinsoku & "', renkei= '" & renkei & "', result.difficulty= '" & difficulty & "', evaluation= '" & evaluation & "', achievement= '" & achievement & "', achievement1= '" & achievement1 & "',achievement2= '" & achievement2 & "',achievement3= '" & achievement3 & "' WHERE result.employeeid = '" & employeeid & "' AND result.period =  '" & period & "' AND targetdata.employeeid = '" & employeeid & "' AND targetdata.period =  '" & period & "';"
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
            End If
            If SupAchCbox1.Enabled = False Then
                MessageBox.Show("Targets result were evaluate successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Targets result were evaluate successfully! Comments and Result were updated successfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            conn.Close()
                Me.Close()
            End If
            DataGridUser.Controls.Clear() 'removes all the controls on the form
        DataGridUser.InitializeComponent() 'load all the controls again
        DataGridUser.DataGridUser_Load(e, e) 'Load everything in your form, load event again
    End Sub

    Private Sub Prev2Btn_Click(sender As Object, e As EventArgs) Handles Prev2Btn.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub RejectRstBtn_Click(sender As Object, e As EventArgs) Handles RejectRstBtn.Click
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim employeeid As String
        Dim period As String
        Dim status As Integer
        Dim appid As String
        Dim reader As MySqlDataReader
        appid = WelcomeMngFrm.EmployeeIdLabel.Text

        Dim result As DialogResult = MessageBox.Show("Are you sure to reject the result?", "Reject Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            employeeid = EmployeeLabel.Text
            period = PeriodLabel.Text
            conn.Open()
            status = Statuslb.Text
            If status = 5 Then
                Dim query As String = "UPDATE targetdata SET status= '4' WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "' ;"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
                conn.Close()
            Else
                Dim query As String = "UPDATE targetdata SET status= '5' WHERE employeeid = '" & employeeid & "' AND period =  '" & period & "' ;"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
                conn.Close()
            End If
            MessageBox.Show("Results were rejected!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim employeeid As String
        Dim period As String
        Dim status As Integer
        Dim appid As String
        Dim reader As MySqlDataReader
        Dim mbo As String
        Dim competency As String
        Dim evaluation As String
        Dim difficulty As String
        Dim achievement1 As String
        Dim achievement As String
        Dim achievement2 As String
        Dim achievement3 As String
        Dim total As String
        Dim comment1 As String
        Dim comment2 As String
        Dim comment3 As String
        Dim ose As String
        Dim osc As String
        Dim jiritsu As String
        Dim jinsoku As String
        Dim renkei As String
        Dim notable As String

        appid = WelcomeMngFrm.EmployeeIdLabel.Text
        status = Statuslb.Text
        employeeid = EmployeeLabel.Text
        period = PeriodLabel.Text
        notable = NotableTbx.Text
        osc = OvrSupCmTbx.Text
        ose = OvrSupEvaTbx.Text
        comment1 = SupComTbx1.Text
        comment2 = SupComTbx2.Text
        comment3 = SupComTbx3.Text
        mbo = MngObjLbl.Text
        competency = ComScrLbl.Text
        total = TotalEvaLbl.Text
        jiritsu = SupEvaTbx1.Text
        jinsoku = SupEvaTbx2.Text
        renkei = SupEvaTbx3.Text
        difficulty = OvrDiffLbl.Text
        evaluation = OvrEvaLbl.Text
        achievement1 = SupAchTbx1.Text
        achievement2 = SupAchTbx2.Text
        achievement3 = SupAchTbx3.Text
        achievement = OvrAchLbl.Text
        Try
            conn.Open()
            Dim query3 As String = "UPDATE result, targetdata SET notable= '" & notable & "', osc= '" & osc & "', result.comment1= '" & comment1 & "', result.comment2= '" & comment2 & "', result.comment3= '" & comment3 & "' , mbo= '" & mbo & "' , competency= '" & competency & "', total= '" & total & "', ose= '" & ose & "', jiritsu= '" & jiritsu & "', jinsoku= '" & jinsoku & "', renkei= '" & renkei & "', result.difficulty= '" & difficulty & "', evaluation= '" & evaluation & "', achievement= '" & achievement & "', achievement1= '" & achievement1 & "',achievement2= '" & achievement2 & "',achievement3= '" & achievement3 & "' WHERE result.employeeid = '" & employeeid & "' AND result.period =  '" & period & "' AND targetdata.employeeid = '" & employeeid & "' AND targetdata.period =  '" & period & "' ;"
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
        MessageBox.Show("Result were save successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Close()
    End Sub
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim g As Integer
        Dim f As Integer
        Dim X As Double
        Dim Y As Double
        Dim z As Double
        Dim u As Integer
        Dim v As Integer
        Dim w As Integer
        Dim status As Integer
        status = Statuslb.Text
        If status >= 5 Then

            If SupAchTbx3.Text = "" Then
                SupAchLb3.Text = "0"
            End If

            If SupAchTbx2.Text = "" Then
                SupAchLb2.Text = "0"
            End If

            'difficult * weight
            a = Val(Diff1ValueLb.Text) * Val(WeightTbx1.Text)
            b = Val(Diff2ValueLb.Text) * Val(WeightTbx2.Text)
            c = Val(Diff3ValueLb.Text) * Val(WeightTbx3.Text)
            'achieve * weight
            d = (WeightTbx1.Text) * (SupAchLb1.Text)
            g = (WeightTbx2.Text) * (SupAchLb2.Text)
            f = (WeightTbx3.Text) * (SupAchLb3.Text)

            ' MessageBox.Show("d= " & d & ", ""g= " & g & ", ""f= " & f & ", ""Z= " & z & ", ", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            X = (a + b + c) / 100 'Overall Difficulty
            Y = (d + g + f) / 100 'Overall Achievement

            If X >= 1.45 And X <= 2.44 Then
                X = 2
            Else
                If X >= 2.45 Then
                    X = 3
                Else
                    If X >= 0 And X < 1.45 Then
                        X = 1
                    End If
                End If
            End If
            If Y >= 1.45 And Y <= 2.44 Then
                Y = 2
            Else
                If Y >= 2.45 Then
                    Y = 3
                Else
                    If Y >= 0 And Y < 1.45 Then
                        Y = 1
                    End If
                End If
            End If

            OvrDiffScore.Text = Y
            z = X + Y 'Evaluation
            'Difficulty sum table
            If X = 3 Then
                OvrDiffLbl.Text = "D3: Challenging for the position"
            Else
                If X = 2 Then
                    OvrDiffLbl.Text = "D2: Appropriate for the position"
                Else
                    If X = 1 Then
                        OvrDiffLbl.Text = "D1: Easy for the position"
                    End If
                End If
            End If
            'Achievement sum table
            If Y = 3 Then
                OvrAchLbl.Text = "A3: Highly achieved"
            Else
                If Y = 2 Then
                    OvrAchLbl.Text = "A2: Achieved"
                Else
                    If Y >= 1 Then
                        OvrAchLbl.Text = "A1: Not achieved"
                    End If
                End If
            End If

            v = Val(SupEvaLb1.Text) + Val(SupEvaLb2.Text) + Val(SupEvaLb3.Text) 'superior evaluation
            u = v / 3 'averange superior evaluation

            'MBO result table
            If z = 6 Then
                OvrEvaLbl.Text = "M5: Outstanding"
                MBOScoreLb.Text = "5"
                MngObjLbl.Text = "M5"
            End If

            If z = 5 Then
                OvrEvaLbl.Text = "M4: Exceeds expectation"
                MBOScoreLb.Text = "4"
                MngObjLbl.Text = "M4"
            End If

            If z = 4 Then
                OvrEvaLbl.Text = "M3: Meets expectation"
                MBOScoreLb.Text = "3"
                MngObjLbl.Text = "M3"
            End If

            If z = 3 Then
                OvrEvaLbl.Text = "M2: Under expectation"
                MBOScoreLb.Text = "2"
                MngObjLbl.Text = "M2"
            End If

            If z = 2 Then
                OvrEvaLbl.Text = "M1: Unsatisfactory"
                MBOScoreLb.Text = "1"
                MngObjLbl.Text = "M1"
            End If

            'Overall Superior's Evaluation

            'If u = 5 Then
            '    OvrSupEvaTbx.Text = "C5: Outstanding"
            'End If

            'If u = 4 Then
            '    OvrSupEvaTbx.Text = "C4: Excellent"
            'End If

            'If u = 3 Then
            '    OvrSupEvaTbx.Text = "C3: Standard"
            'End If

            'If u = 2 Then
            '    OvrSupEvaTbx.Text = "C2: Need Improvement"
            'End If

            'If u = 1 Then
            '    OvrSupEvaTbx.Text = "C1: Bad/Poor"
            'End If

            'Total evaluation
            w = Val(MBOScoreLb.Text) * Val(CompetencyScore.Text)

            'MessageBox.Show("W= " & w & ", ""Y= " & Y & ", ""U= " & u & ", ""Z= " & z & ", ", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If w >= 20 Then
                TotalEvaLbl.Text = "5"
            End If

            If w >= 12 And w < 20 Then
                TotalEvaLbl.Text = "4"
            End If

            If w >= 6 And w < 12 Then
                TotalEvaLbl.Text = "3"
            End If

            If w >= 3 And w < 6 Then
                TotalEvaLbl.Text = "2"
            End If

            If w >= 1 And w < 3 Then
                TotalEvaLbl.Text = "1"
            End If
        End If

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        SupAchCbox1.Enabled = True
        SupAchCbox2.Enabled = True
        SupAchCbox3.Enabled = True
        SupComTbx1.ReadOnly = False
        SupComTbx2.ReadOnly = False
        SupComTbx3.ReadOnly = False
        NotableTbx.ReadOnly = False
        SupEvaCbx1.Enabled = True
        SupEvaCbx2.Enabled = True
        SupEvaCbx3.Enabled = True
        OvrSupCmTbx.ReadOnly = False
    End Sub
End Class