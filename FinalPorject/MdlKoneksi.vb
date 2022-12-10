Imports MySql.Data.MySqlClient
Module MdlKoneksi
    Public conn As MySqlConnection
    Public adr As MySqlDataAdapter
    Public adt As DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String

    Public Sub koneksi()
        str = "Server=localhost;user id=root;password=;database=db_pemdesk"
        conn = New MySqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module