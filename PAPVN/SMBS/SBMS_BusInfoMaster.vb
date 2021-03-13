Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class SBMS_BusInfoMaster
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim busmodel As String = BusModelTbx.Text
        Dim busname As String = BusNameTbx.Text
        Dim busyear As String = BusYearTbx.Text
        Dim buscompany As String = BusCompanyTbx.Text
        Dim triproute As String = BusTripRouteTbx.Text
        Dim plateno As String = PlateNoTbx.Text
        Dim bus_id As String = BusID.Text
        Dim location As String = LocationCombox.Text
        Dim drivername As String = DriverNameTbx.Text
        Dim driverphone As String = DriverMobiNoTbx.Text
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        Dim result As DialogResult = MessageBox.Show("Are you sure to add new bus?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If busmodel <> "" And busyear <> "" And buscompany <> "" And triproute <> "" And plateno <> "" And location <> "" And drivername <> "" And driverphone <> "" Then
                Try
                    conn.Open()
                    Using conn
                        Dim query As String = "INSERT INTO tbl_businfo (bus_model, bus_ID, bus_name, year, bus_location, bks, driver_name, driver_phone, company, trip_route) VALUES (@bus_model, @bus_ID, @bus_name, @year, @bus_location, @bks, @driver_name, @driver_phone, @company, @trip_route);"
                        command = New MySqlCommand(query, conn)
                        command.Parameters.AddWithValue("@bus_model", busmodel)
                        command.Parameters.AddWithValue("@bus_ID", "")
                        command.Parameters.AddWithValue("@bus_name", busname)
                        command.Parameters.AddWithValue("@year", busyear)
                        command.Parameters.AddWithValue("@bus_location", location)
                        command.Parameters.AddWithValue("@bks", plateno)
                        command.Parameters.AddWithValue("@driver_name", drivername)
                        command.Parameters.AddWithValue("@driver_phone", driverphone)
                        command.Parameters.AddWithValue("@company", buscompany)
                        command.Parameters.AddWithValue("@trip_route", triproute)
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("New Bus added successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn IsNot Nothing Then
                        conn.Close()
                    End If
                End Try
                Me.Controls.Clear() 'removes all the controls on the form
                Me.InitializeComponent() 'load all the controls again
                Me.SBMS_BusInfoMaster_Load(e, e) 'Load everything in your form, load event again
            Else
                MessageBox.Show("Please check the data input and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim busmodel As String = BusModelTbx2.Text
        Dim busname As String = BusNameCombox2.Text
        Dim busyear As String = BusYearTbx2.Text
        Dim buscompany As String = BusCompanyTbx2.Text
        Dim triproute As String = BusTripRouteTbx2.Text
        Dim plateno As String = PlateNoTbx2.Text
        Dim bus_id As String = BusID2.Text
        Dim location As String = LocationCombox2.Text
        Dim drivername As String = DriverNameTbx2.Text
        Dim driverphone As String = DriverMobiNoTbx2.Text
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        Dim result As DialogResult = MessageBox.Show("Are you sure to update Bus's information?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try
                conn.Open()
                Using conn
                    Dim query As String = "UPDATE tbl_businfo SET bus_model=@bus_model, year=@year, bus_location=@bus_location, bks=@bks, driver_name=@driver_name, driver_phone=@driver_phone, company=@company, trip_route= @trip_route WHERE bus_name='" & busname & "';"
                    command = New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@bus_model", busmodel)
                    command.Parameters.AddWithValue("@year", busyear)
                    command.Parameters.AddWithValue("@bus_location", location)
                    command.Parameters.AddWithValue("@bks", plateno)
                    command.Parameters.AddWithValue("@driver_name", drivername)
                    command.Parameters.AddWithValue("@driver_phone", driverphone)
                    command.Parameters.AddWithValue("@company", buscompany)
                    command.Parameters.AddWithValue("@trip_route", triproute)
                    command.ExecuteNonQuery()
                    MessageBox.Show("New Bus updated successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            Me.Controls.Clear() 'removes all the controls on the form
            Me.InitializeComponent() 'load all the controls again
            Me.SBMS_BusInfoMaster_Load(e, e) 'Load everything in your form, load event again
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim busname As String
        Dim reader As MySqlDataReader
        conn = New MySqlConnection With {
                .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
            }
        busname = BusNameCombox2.Text
        Dim result As DialogResult = MessageBox.Show("Are you sure to delete this bus?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "DELETE FROM tbl_businfo WHERE bus_name='" & busname & "';"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                reader.Close()
                MessageBox.Show("This Bus was deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
            Me.Controls.Clear() 'removes all the controls on the form
            Me.InitializeComponent() 'load all the controls again
            Me.SBMS_BusInfoMaster_Load(e, e) 'Load everything in your form, load event again
        End If
    End Sub

    Private Sub SBMS_BusInfoMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT bus_name FROM tbl_businfo ORDER BY bus_id;"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            BusNameCombox2.Items.Clear()
            While reader.Read
                BusNameCombox2.Items.Add(reader("bus_name").ToString)
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

    Private Sub BusNameCombox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BusNameCombox2.SelectedIndexChanged
        Dim busname As String = BusNameCombox2.Text
        Dim count As Integer
        conn = New MySqlConnection With {
            .ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("busConnectionString").ConnectionString
        }
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM tbl_businfo WHERE bus_name = '" & busname & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            count = 0
            While reader.Read
                count = +1
            End While
            If count >= 1 Then
                PlateNoTbx2.Text = reader("bks").ToString
                BusModelTbx2.Text = reader("bus_model").ToString
                BusYearTbx2.Text = reader("year").ToString
                LocationCombox2.Text = reader("bus_location").ToString
                DriverNameTbx2.Text = reader("driver_name").ToString
                DriverMobiNoTbx2.Text = reader("driver_phone").ToString
                BusCompanyTbx2.Text = reader("company").ToString
                BusTripRouteTbx2.Text = reader("trip_route").ToString
                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DriverMobiNoTbx_Validated(sender As Object, e As EventArgs) Handles DriverMobiNoTbx.Validated
        If Not Regex.Match(DriverMobiNoTbx.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DriverMobiNoTbx.Focus()
            DriverMobiNoTbx.Clear()
        End If
    End Sub

    Private Sub DriverMobiNoTbx2_Validated(sender As Object, e As EventArgs) Handles DriverMobiNoTbx2.Validated
        If Not Regex.Match(DriverMobiNoTbx2.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter number only.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DriverMobiNoTbx2.Focus()
            DriverMobiNoTbx2.Clear()
        End If
    End Sub
End Class