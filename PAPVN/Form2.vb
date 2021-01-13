Imports MySql.Data.MySqlClient
Imports QRCoder
Public Class Form2
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim time As Date
        'Dim dbDataSet As New DataTable
        'Dim SDA As New MySqlDataAdapter
        'conn = New MySqlConnection With {
        '.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        '    }
        'time = DateTimePicker1.Value
        'Try
        '    conn.Open()
        '    Dim query As String = "INSERT INTO tbl_order (order_id, start_time) VALUES (@order_id, @start_time);"
        '    Using conn
        '        command = New MySqlCommand(query, conn)
        '        command.Parameters.AddWithValue("@order_id", "")
        '        command.Parameters.AddWithValue("@start_time", time)
        '        command.ExecuteNonQuery()
        '    End Using
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    If conn IsNot Nothing Then
        '        conn.Close()
        '    End If
        'End Try
        Dim time As Date
        Dim dbDataSet As New DataTable
        Dim SDA As New MySqlDataAdapter

        conn = New MySqlConnection With {
        .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        time = DateTimePicker1.Value
        Try
            conn.Open()
            Dim query As String = "UPDATE tbl_order SET start_time= @start_time WHERE order_id =51;"
            Using conn
                command = New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@start_time", time)
                command.ExecuteNonQuery()
            End Using
            MessageBox.Show("Done!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(Label1.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        PictureBox1.Image = code.GetGraphic(6)
    End Sub
End Class