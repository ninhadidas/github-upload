Imports MySql.Data.MySqlClient
Public Class SBMS_BusSelect
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Sub DataGridBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name, tbl_order.order_id, tbl_order.start_time, tbl_order.end_time, tbl_order.start_location, tbl_order.end_location, tbl_order.order_content, tbl_bus_quota.quota, tbl_order.order_note, bks, name, mobile1 FROM tbl_businfo INNER JOIN tbl_order ON tbl_order.bus_id = tbl_businfo.bus_id INNER JOIN tbl_bus_quota ON tbl_order.bus_id = tbl_bus_quota.bus_id INNER JOIN tbl_driverinfo ON tbl_businfo.bus_id=tbl_driverinfo.bus_id WHERE tbl_order.end_time >= now();"
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
                BusyGridBus.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With BusyGridBus
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Bus Name"
                    .Columns(1).HeaderCell.Value = "Trip ID"
                    .Columns(1).Width = 50
                    .Columns(2).HeaderCell.Value = "Start Time"
                    .Columns(2).Width = 120
                    .Columns(3).HeaderCell.Value = "End Time"
                    .Columns(3).Width = 120
                    .Columns(4).HeaderCell.Value = "Start Location"
                    .Columns(4).Width = 100
                    .Columns(5).HeaderCell.Value = "End Location"
                    .Columns(5).Width = 150
                    .Columns(6).HeaderCell.Value = "Purpose"
                    .Columns(6).Width = 200
                    .Columns(7).HeaderCell.Value = "Km Remain"
                    .Columns(7).Width = 80
                    .Columns(8).HeaderCell.Value = "Note"
                    .Columns(8).Width = 200
                    .Columns(9).HeaderCell.Value = "Plate No"
                    .Columns(9).Width = 80
                    .Columns(10).HeaderCell.Value = "Driver's Name"
                    .Columns(10).Width = 100
                    .Columns(11).HeaderCell.Value = "Driver's Mobile"
                    .Columns(11).Width = 100
                End With
                conn.Close()
            Else
                MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub FreeGridBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name, tbl_order.order_id, tbl_order.start_time, tbl_order.end_time, tbl_order.start_location, tbl_order.end_location, tbl_order.order_content, tbl_bus_quota.quota, tbl_order.order_note, bks, name, mobile1 FROM tbl_businfo INNER JOIN tbl_order ON tbl_order.bus_id = tbl_businfo.bus_id INNER JOIN tbl_bus_quota ON tbl_order.bus_id = tbl_bus_quota.bus_id INNER JOIN tbl_driverinfo ON tbl_businfo.bus_id=tbl_driverinfo.bus_id WHERE DATE(tbl_order.end_time) = CURDATE();"
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
                FreeGridBus.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With FreeGridBus
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Bus Name"
                    .Columns(1).HeaderCell.Value = "Trip ID"
                    .Columns(1).Width = 50
                    .Columns(2).HeaderCell.Value = "Start Time"
                    .Columns(2).Width = 120
                    .Columns(3).HeaderCell.Value = "End Time"
                    .Columns(3).Width = 120
                    .Columns(4).HeaderCell.Value = "Start Location"
                    .Columns(4).Width = 100
                    .Columns(5).HeaderCell.Value = "End Location"
                    .Columns(5).Width = 150
                    .Columns(6).HeaderCell.Value = "Purpose"
                    .Columns(6).Width = 200
                    .Columns(7).HeaderCell.Value = "Km Remain"
                    .Columns(7).Width = 80
                    .Columns(8).HeaderCell.Value = "Note"
                    .Columns(8).Width = 200
                    .Columns(9).HeaderCell.Value = "Plate No"
                    .Columns(9).Width = 80
                    .Columns(10).HeaderCell.Value = "Driver's Name"
                    .Columns(10).Width = 100
                    .Columns(11).HeaderCell.Value = "Driver's Mobile"
                    .Columns(11).Width = 100
                End With
                conn.Close()
            Else
                MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BusyGridBus_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BusyGridBus.CellMouseDoubleClick
        SBMS_GAView.BusNameTbx.Text = BusyGridBus.CurrentRow.Cells(0).Value.ToString
        SBMS_GAView.KmRemainTbx.Text = BusyGridBus.CurrentRow.Cells(7).Value.ToString
        SBMS_GAView.PlateNoTbx.Text = BusyGridBus.CurrentRow.Cells(9).Value.ToString
        SBMS_GAView.DriverNameTbx.Text = BusyGridBus.CurrentRow.Cells(10).Value.ToString
        SBMS_GAView.DriverMobileTbx.Text = BusyGridBus.CurrentRow.Cells(11).Value.ToString
        Me.Close()
    End Sub

    Private Sub BusyGridBus_KeyDown(sender As Object, e As KeyEventArgs) Handles BusyGridBus.KeyDown
        If e.KeyCode = Keys.Enter Then
            SBMS_GAView.BusNameTbx.Text = BusyGridBus.CurrentRow.Cells(0).Value.ToString
            SBMS_GAView.KmRemainTbx.Text = BusyGridBus.CurrentRow.Cells(7).Value.ToString
            SBMS_GAView.PlateNoTbx.Text = BusyGridBus.CurrentRow.Cells(9).Value.ToString
            SBMS_GAView.DriverNameTbx.Text = BusyGridBus.CurrentRow.Cells(10).Value.ToString
            SBMS_GAView.DriverMobileTbx.Text = BusyGridBus.CurrentRow.Cells(11).Value.ToString
            Me.Close()
        End If
    End Sub
End Class