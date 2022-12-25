Imports MySql.Data.MySqlClient
Public Class Produk
    Private Sub clear()
        cbKateboriBrg.Text = ""
        tbNamaBrg.Text = ""
        tbMerkBrg.Text = ""
        tbHrgJual.Text = ""
        tbHrgBeli.Text = ""
    End Sub

    Sub auto()
        Call koneksi()
        cmd = New MySqlCommand("select * from tblbarang order by kodebarang desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            tbKodeBrg.Text = "BR" + "0001"
        Else
            tbKodeBrg.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("kodebarang").ToString, 4, 3)) + 1
            If Len(tbKodeBrg.Text) = 1 Then
                tbKodeBrg.Text = "BR000" & tbKodeBrg.Text & ""
            ElseIf Len(tbKodeBrg.Text) = 2 Then
                tbKodeBrg.Text = "BR00" & tbKodeBrg.Text & ""
            ElseIf Len(tbKodeBrg.Text) = 3 Then
                tbKodeBrg.Text = "BR0" & tbKodeBrg.Text & ""
            End If
        End If
    End Sub

    Private Sub views()
        Call koneksi()
        adr = New MySqlDataAdapter("SELECT tblbarang.kodebarang AS ""KODE BARANG"", tblkategori.namakategori AS ""KATEGORI"", tblbarang.namabarang AS ""NAMA BARANG"", tblbarang.merekbarang AS ""MERK BARANG"", tblbarang.hargabeli AS ""HARGA BELI"", tblbarang.hargajual AS ""HARGA JUAL"" FROM tblbarang INNER JOIN tblkategori ON tblbarang.idkategori = tblkategori.idkategori;", conn)
        adt = New DataSet
        adr.Fill(adt, "tblbarang")
        DataGridView1.DataSource = adt.Tables("tblbarang")
    End Sub

    Private Sub Produk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_pemdesktblkategoridataset.tblkategori' table. You can move, or remove it, as needed.
        Me.TblkategoriTableAdapter.Fill(Me.Db_pemdesktblkategoridataset.tblkategori)
        tbKodeBrg.Enabled = False
        Call views()
        Call auto()
    End Sub

    Private Sub btnTambahKategori_Click(sender As Object, e As EventArgs) Handles btnTambahKategori.Click
        FTambahKategori.Show()
        Me.Hide()
    End Sub

    Private Sub btnTambahBrg_Click(sender As Object, e As EventArgs) Handles btnTambahBrg.Click
        If tbKodeBrg.Text = "" Or cbKateboriBrg.Text = "" Or tbNamaBrg.Text = "" Or tbMerkBrg.Text = "" Or tbHrgBeli.Text = "" Or tbHrgJual.Text = "" Then
            MsgBox("Masih ada data yang belum dilengkapi")
            Exit Sub
        Else
            Call koneksi()

            Dim simpan As String = "insert into tblbarang values('" & tbKodeBrg.Text & "','" & cbKateboriBrg.SelectedValue & "','" & tbNamaBrg.Text & "','" & tbMerkBrg.Text & "','" & tbHrgBeli.Text & "','" & tbHrgJual.Text & "')"
            cmd = New MySqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()

            Call clear()
            Call views()
            Call auto()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        tbKodeBrg.Enabled = True
        tbKodeBrg.Text = ""
        btnBatal.Visible = True
        btnSimpanBrg.Visible = True
        btnTambahKategori.Visible = False
        btnHapus.Visible = False
        btnTambahBrg.Visible = False

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        tbKodeBrg.Enabled = True
        cbKateboriBrg.Enabled = False
        tbNamaBrg.Enabled = False
        tbMerkBrg.Enabled = False
        tbHrgJual.Enabled = False
        tbHrgBeli.Enabled = False
        btnUbah.Visible = False
        btnTambahKategori.Visible = False
        btnTambahBrg.Visible = False
        btnSimpanBrg.Visible = True
        btnBatal.Visible = True
    End Sub

    Private Sub btnSimpanBrg_Click(sender As Object, e As EventArgs) Handles btnSimpanBrg.Click
        If btnUbah.Visible = True Then
            Call koneksi()
            cmd = New MySqlCommand("select * from tblbarang where kodebarang='" & tbKodeBrg.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Call koneksi()
                Dim edit As String = "update tblbarang set idkategori='" & cbKateboriBrg.SelectedValue & "',namabarang='" & tbNamaBrg.Text & "',merekbarang='" & tbMerkBrg.Text & "',hargabeli='" & tbHrgBeli.Text & "',hargajual='" & tbHrgJual.Text & "' where kodebarang='" & tbKodeBrg.Text & "'"
                cmd = New MySqlCommand(edit, conn)
                cmd.ExecuteNonQuery()
            Else
                MsgBox("Kode Barang Tidak Ada!")
            End If
            Call clear()
            Call views()
            Call auto()
        Else
            Call koneksi()
            cmd = New MySqlCommand("select * from tblbarang where kodebarang='" & tbKodeBrg.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Call koneksi()
                Dim hapus As String = "delete from tblbarang where kodebarang='" & tbKodeBrg.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
            Else
                MsgBox("Kode Barang Tidak Ada!")
            End If
            Call clear()
            Call views()
            Call auto()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        tbKodeBrg.Enabled = False
        cbKateboriBrg.Enabled = True
        tbNamaBrg.Enabled = True
        tbMerkBrg.Enabled = True
        tbHrgJual.Enabled = True
        tbHrgBeli.Enabled = True
        btnUbah.Visible = True
        btnHapus.Visible = True
        btnTambahKategori.Visible = True
        btnSimpanBrg.Visible = False
        btnTambahBrg.Visible = True
        btnBatal.Visible = False
        Call clear()
        Call views()
        Call auto()
    End Sub

    Private Sub btnUtama_Click(sender As Object, e As EventArgs) Handles btnUtama.Click
        Utama.Show()
        Me.Hide()
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        btnProduk.Enabled = False
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnStok_Click(sender As Object, e As EventArgs) Handles btnStok.Click
        stokBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        laporan.Show()
        Me.Hide()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class