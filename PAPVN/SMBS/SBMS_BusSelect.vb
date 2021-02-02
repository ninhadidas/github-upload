Imports MySql.Data.MySqlClient
Public Class SBMS_BusSelect
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub SBMS_BusSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        today_lbl.Text = Today
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name, tbl_order.order_id, tbl_order.start_time, tbl_order.end_time, tbl_order.start_location, tbl_order.end_location, tbl_order.order_content, km_remain, tbl_order.order_note, bks, driver_name, driver_phone, tbl_businfo.bus_id FROM tbl_order INNER JOIN tbl_businfo ON tbl_order.bus_id = tbl_businfo.bus_id INNER JOIN tbl_bus_quota ON tbl_order.bus_id = tbl_bus_quota.bus_id WHERE DATE(tbl_order.start_time) = CURRENT_DATE AND status_id =4;"
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
                    .Columns(0).Width = 70
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
                    .Columns(10).Width = 150
                    .Columns(11).HeaderCell.Value = "Driver's Mobile"
                    .Columns(11).Width = 100
                    .Columns(12).HeaderCell.Value = "Bus ID"
                    .Columns(12).Width = 80
                End With
                conn.Close()
                'Else
                '    MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ShowBusBtn_Click(sender As Object, e As EventArgs) Handles ShowBusBtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name, km_remain, bks, driver_name, driver_phone, company, tbl_businfo.bus_id FROM tbl_businfo INNER JOIN tbl_bus_quota ON tbl_businfo.bus_id = tbl_bus_quota.bus_id;"
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
                BusListGrid.DataSource = dbDataSet
                SDA.Update(dbDataSet)
                With BusListGrid
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Bus Name"
                    .Columns(1).HeaderCell.Value = "Km Remain"
                    .Columns(1).Width = 200
                    .Columns(2).HeaderCell.Value = "Plate No"
                    .Columns(2).Width = 200
                    .Columns(3).HeaderCell.Value = "Driver's Name"
                    .Columns(3).Width = 200
                    .Columns(4).HeaderCell.Value = "Driver's Mobile"
                    .Columns(4).Width = 200
                    .Columns(5).HeaderCell.Value = "Company"
                    .Columns(5).Width = 200
                    .Columns(6).HeaderCell.Value = "Bus ID"
                    .Columns(6).Width = 150
                End With
                conn.Close()
            Else
                MessageBox.Show("No Data Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BusListGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BusListGrid.CellMouseDoubleClick
        SBMS_GAView.BusNameTbx.Text = BusListGrid.CurrentRow.Cells(0).Value.ToString
        SBMS_GAView.KmRemainTbx.Text = BusListGrid.CurrentRow.Cells(1).Value.ToString
        SBMS_GAView.PlateNoTbx.Text = BusListGrid.CurrentRow.Cells(2).Value.ToString
        SBMS_GAView.DriverNameTbx.Text = BusListGrid.CurrentRow.Cells(3).Value.ToString
        SBMS_GAView.DriverMobileTbx.Text = BusListGrid.CurrentRow.Cells(4).Value.ToString
        SBMS_GAView.busID.Text = BusListGrid.CurrentRow.Cells(6).Value.ToString
        Me.Close()
    End Sub

    Private Sub BusListGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles BusListGrid.KeyDown
        If e.KeyCode = Keys.Enter Then
            SBMS_GAView.BusNameTbx.Text = BusListGrid.CurrentRow.Cells(0).Value.ToString
            SBMS_GAView.KmRemainTbx.Text = BusListGrid.CurrentRow.Cells(1).Value.ToString
            SBMS_GAView.PlateNoTbx.Text = BusListGrid.CurrentRow.Cells(2).Value.ToString
            SBMS_GAView.DriverNameTbx.Text = BusListGrid.CurrentRow.Cells(3).Value.ToString
            SBMS_GAView.DriverMobileTbx.Text = BusListGrid.CurrentRow.Cells(4).Value.ToString
            SBMS_GAView.busID.Text = BusListGrid.CurrentRow.Cells(6).Value.ToString
            Me.Close()
        End If
    End Sub
    Private Sub BusyGridBus_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BusyGridBus.CellMouseDoubleClick
        SBMS_GAView.BusNameTbx.Text = BusyGridBus.CurrentRow.Cells(0).Value.ToString
        SBMS_GAView.KmRemainTbx.Text = BusyGridBus.CurrentRow.Cells(7).Value.ToString
        SBMS_GAView.PlateNoTbx.Text = BusyGridBus.CurrentRow.Cells(9).Value.ToString
        SBMS_GAView.DriverNameTbx.Text = BusyGridBus.CurrentRow.Cells(10).Value.ToString
        SBMS_GAView.DriverMobileTbx.Text = BusyGridBus.CurrentRow.Cells(11).Value.ToString
        SBMS_GAView.busID.Text = BusyGridBus.CurrentRow.Cells(12).Value.ToString
        Me.Close()
    End Sub

    Private Sub BusyGridBus_KeyDown(sender As Object, e As KeyEventArgs) Handles BusyGridBus.KeyDown
        If e.KeyCode = Keys.Enter Then
            SBMS_GAView.BusNameTbx.Text = BusyGridBus.CurrentRow.Cells(0).Value.ToString
            SBMS_GAView.KmRemainTbx.Text = BusyGridBus.CurrentRow.Cells(7).Value.ToString
            SBMS_GAView.PlateNoTbx.Text = BusyGridBus.CurrentRow.Cells(9).Value.ToString
            SBMS_GAView.DriverNameTbx.Text = BusyGridBus.CurrentRow.Cells(10).Value.ToString
            SBMS_GAView.DriverMobileTbx.Text = BusyGridBus.CurrentRow.Cells(11).Value.ToString
            SBMS_GAView.busID.Text = BusyGridBus.CurrentRow.Cells(12).Value.ToString
            Me.Close()
        End If
    End Sub
End Class