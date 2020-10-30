﻿Imports MySql.Data.MySqlClient
Public Class PmsMngLoginFrm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim username As String
        Dim password As String
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("mboConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        username = UserIdTb.Text
        password = PwTb.Text
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM manager where employeeid = '" & username & "' and password = '" & password & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count = 1 Then
                Me.Hide()
                WelcomeMngFrm.Show()
                WelcomeMngFrm.NameLabel.Text = reader("name").ToString
                WelcomeMngFrm.EmployeeIdLabel.Text = reader("employeeid").ToString
                WelcomeMngFrm.DeptLabel.Text = reader("dept").ToString
                WelcomeMngFrm.DivLabel.Text = reader("division").ToString
            Else
                MessageBox.Show("Password incorrect, please try again!", "Wrong username or password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub PmsMngLoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PwTb_KeyDown(sender As Object, e As KeyEventArgs) Handles PwTb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login_Click(sender, e)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ForgotPwMngFrm.Show()
    End Sub
End Class