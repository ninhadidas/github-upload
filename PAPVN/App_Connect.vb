Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class App_Connect
    Public Shared conn As New MySqlConnection
    Private cmd As New MySqlCommand
    Private ConnectionState As ConnectionState
    Public Shared ConnectServer As String
    Public Shared ConnectID As String
    Public Shared ConnectPass As String
    Public Shared ConnectDatabaseName As String
    Public Shared Function Open_Connection() As Boolean
        Dim str As String = "Server=" & ConnectServer & "; UserID='" & ConnectID & "'; Password='" & ConnectPass & "'; Database=" & ConnectDatabaseName
        conn.ConnectionString = str
        conn.Open()
        Open_Connection = True
    End Function
    Public Shared Function CloseConnection() As Boolean
        If conn.State = Data.ConnectionState.Open Then
            conn.Close()
        End If
        CloseConnection = True
    End Function

    Public Shared Function filldataset(ByVal objdataset As System.Data.DataSet, ByVal tablename As String, ByVal stroreprocedurename As String, Optional ByVal arrParams() As String = Nothing, Optional ByVal arrValues() As Object = Nothing) As Boolean
        Dim da As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim nIndex As Integer = 0
        Try
            If Not (arrParams Is Nothing) Then
                For nIndex = 0 To (arrParams.Length - 1)
                    If arrValues(nIndex) = Nothing Then
                        arrValues(nIndex) = DBNull.Value
                    End If
                    cmd.Parameters.AddWithValue(arrParams(nIndex), arrValues(nIndex))
                Next
            End If
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = stroreprocedurename
            da.SelectCommand = cmd
            da.Fill(objdataset, tablename)
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If
            ' huyketnoi()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cmd.Dispose() 'hủy cmd
            'huyketnoi()
        End Try
    End Function
    Public Shared Function GetDataTable(ByVal StoreProcedureName As String, Optional ByVal arrParams() As String = Nothing, Optional ByVal arrValues() As Object = Nothing) As DataTable
        Dim da As New MySqlDataAdapter
        Dim objTable As New DataTable
        Dim cmd As New MySqlCommand
        Dim nIndex As Integer = 0
        cmd.Connection = conn
        Try
            If Not (arrParams Is Nothing) Then
                'MsgBox(arrParams.Length)
                For nIndex = 0 To (arrParams.Length - 1)
                    If arrValues(nIndex) = Nothing Then
                        arrValues(nIndex) = ""
                    End If
                    cmd.Parameters.AddWithValue(arrParams(nIndex), arrValues(nIndex))
                Next
            End If
            cmd.CommandText = StoreProcedureName
            cmd.CommandType = CommandType.StoredProcedure
            da.SelectCommand = cmd
            da.Fill(objTable)
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If
            Return objTable
        Catch ex As Exception
            Return Nothing
        Finally
            cmd.Dispose()
        End Try
    End Function
    Public Shared Function ExecuteNonQuery(ByVal StoreProcedureName As String, Optional ByVal arrParams() As String = Nothing, Optional ByVal arrValues() As Object = Nothing) As Integer
        Dim rowCount As Integer = 0
        Dim nIndex As Integer = 0
        Dim Cmd As New MySqlCommand
        Cmd.Connection = conn
        Try
            If Not (arrParams Is Nothing) Then
                For nIndex = 0 To (arrParams.Length - 1)
                    If arrValues(nIndex) = Nothing Then
                        arrValues(nIndex) = ""
                    End If
                    Cmd.Parameters.AddWithValue(arrParams(nIndex), arrValues(nIndex))
                Next
            End If
            conn.Open()
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = StoreProcedureName
            rowCount = Cmd.ExecuteNonQuery()
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If
            Return rowCount
        Catch ex As Exception
            Return -1
        Finally
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If
            Cmd.Dispose()
        End Try
    End Function
    ' dùng để lấy dữ liệu được đổ vào 1 DataSet có Quan hệ giữa 2 Table
    ' thường dùng dể đổ dữ liệu vào DataGriview - Combobox - bindingSource...
    ' </summary>
    Public Function GetDataSetDataRelation(ByVal TableName() As String, ByVal RalationID As String, ByVal StoreProceureName() As String) As DataSet
        Dim ds As New DataSet
        Try
            cmd.CommandText = StoreProceureName(0)
            Dim daParent As New MySqlDataAdapter(StoreProceureName(0), conn)
            daParent.SelectCommand = cmd
            daParent.Fill(ds, TableName(0))

            cmd.CommandText = StoreProceureName(1)
            Dim daChild As New MySqlDataAdapter(StoreProceureName(1), conn)
            daChild.SelectCommand = cmd
            daChild.Fill(ds, TableName(1))

            Dim ColumnParent, ColumnChild As DataColumn
            ColumnParent = ds.Tables(TableName(0)).Columns(RalationID)
            ColumnChild = ds.Tables(TableName(1)).Columns(RalationID)

            Dim relation As New DataRelation(TableName(2), ColumnParent, ColumnChild)
            ds.Relations.Add(relation)

            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    'Public Shared Function FillGv(ByVal DataTable As System.Data.DataTable, ByVal Gv As DataGridView) As Boolean
    'Gv.DataSource = DataTable
    'End Function
    Public Function GetBinDingSource(ByVal TableName As String, ByVal StoreProceureName As String, Optional ByVal arrParams() As String = Nothing, Optional ByVal arrValues() As Object = Nothing) As BindingSource
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim bds As New BindingSource
        Dim nIndex As Integer = 0
        Try
            If Not (arrParams Is Nothing) Then
                For nIndex = 0 To (arrParams.Length - 1)
                    If arrValues(nIndex) = Nothing Then
                        arrValues(nIndex) = ""
                    End If
                    cmd.Parameters.AddWithValue(arrParams(nIndex), arrValues(nIndex))
                Next
            End If
            cmd.CommandText = StoreProceureName
            'cmd.CommandType = CommandType.StoredProcedure
            da.SelectCommand = cmd
            da.Fill(ds, TableName)
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If
            ' lấy nguồn dữ liệu của BindingSource từ DataSet 
            bds.DataSource = ds
            Return bds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            cmd.Dispose()
        End Try
    End Function
    'Trả về một DataReader
    '</summary>
    Public Function GetDataReader(ByVal StoreProceureName As String, Optional ByVal arrParams() As String = Nothing, Optional ByVal arrValues() As Object = Nothing) As MySqlDataReader
        Dim rd As MySqlDataReader
        Try
            If Not (arrParams Is Nothing) Then
                For nIndex As Integer = 0 To (arrParams.Length - 1)
                    cmd.Parameters.AddWithValue(arrParams(nIndex), arrValues(nIndex))
                Next
            End If
            cmd.CommandText = StoreProceureName
            cmd.CommandType = CommandType.StoredProcedure
            ' Doc xong Reader thi auto dong ket noi khi dung tham so CommandBehavior.CloseConnection
            rd = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return rd
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ' Neu Dong Ket noi thi Reader khong doc duoc
            cmd.Dispose()
        End Try
    End Function


    ''' <summary>UpdateDataSet  
    ''' dùng để Update Dataset - kết hợp với Update trực tiếp trên DataGridView
    ''' &lt; Đối với Access thì dùng Query - Đối với SQL Server thì dùng đước cả Query và StoredProcedure &gt;
    ''' &lt; Nghĩa là dùng StoreProcedure SQL server thì chạy - Access báo lỗi &gt;
    ''' </summary>
    Public Function UpdateDataSet(ByVal queryString As String, ByVal ds As DataSet, ByVal tableName As String) As DataSet
        Try
            Dim da As New MySqlDataAdapter
            ' Khi dung StoreProcedure SQL server thì chạy - Access báo lỗi
            'Cmd.CommandText = "sp_SanPham"
            'Cmd.CommandType = CommandType.StoredProcedure

            cmd.CommandText = queryString
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

            ' Neu Fill thi Dataset sẽ tăng gấp đôi
            'da.Fill(ds, tableName)
            da.Update(ds, tableName)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ds
        End Try
    End Function
    'Public Shared Function Fillcbo(ByVal DataTable As System.Data.DataTable, ByVal value As String, ByVal display As String, ByVal cbo As ComboBox) As Boolean
    '    cbo.DisplayMember = display
    '    cbo.ValueMember = value
    '    cbo.DataSource = DataTable
    'End Function
End Class
