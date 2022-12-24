Imports MySql.Data.MySqlClient

Public Class laporan
    Private Sub tampillappembeliannow()
        Call koneksi()
        adr = New MySqlDataAdapter("SELECT s.idstok,tglpembelian,sd.kodebarang,b.namabarang,b.merekbarang,sd.qtystok,sd.stokdhrgbeli,sd.stokdhrgjual,sd.totalhrgbeli,s.grandtotal FROM tblstok s JOIN tblstokdetail sd ON s.idstok = sd.idstok 
                                    JOIN tblbarang b ON sd.kodebarang = b.kodebarang WHERE s.tglpembelian BETWEEN CURRENT_DATE AND CURRENT_TIMESTAMP;", conn)
        adt = New DataSet
        adr.Fill(adt, "tblstok")
        DataGridView2.DataSource = adt.Tables("tblstok")
        DataGridView2.AllowUserToAddRows = False
    End Sub

    Private Sub tampillappembeliandate()
        Call koneksi()
        adr = New MySqlDataAdapter("SELECT s.idstok,tglpembelian,sd.kodebarang,b.namabarang,b.merekbarang,sd.qtystok,sd.stokdhrgbeli,sd.stokdhrgjual,sd.totalhrgbeli,s.grandtotal FROM tblstok s JOIN tblstokdetail sd ON s.idstok = sd.idstok 
                                    JOIN tblbarang b ON sd.kodebarang = b.kodebarang WHERE s.tglpembelian BETWEEN '" & DateTimePicker2.Value & " 00:00:00' AND '" & DateTimePicker4.Value & " 23:59:59'", conn)
        adt = New DataSet
        adr.Fill(adt, "tblstok")
        DataGridView2.DataSource = adt.Tables("tblstok")
        DataGridView2.AllowUserToAddRows = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub TabControl2_Click(sender As Object, e As EventArgs) Handles TabControl2.Click
        Call tampillappembeliannow()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call tampillappembeliandate()

    End Sub
End Class