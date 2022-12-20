Imports MySql.Data.MySqlClient
Public Class FTambahKategori
    Private Sub btnSimpanBrg_Click(sender As Object, e As EventArgs) Handles btnSimpanBrg.Click
        Call koneksi()
        Dim tambahkat As String = "insert into tblkategori (namakategori) values('" & tbNewKat.Text & "')"
        cmd = New MySqlCommand(tambahkat, conn)
        cmd.ExecuteNonQuery()
        tbNewKat.Text = ""
        'TODO: This line of code loads data into the 'Db_pemdesktblkategoridataset.tblkategori' table. You can move, or remove it, as needed.
        Produk.TblkategoriTableAdapter.Fill(Produk.Db_pemdesktblkategoridataset.tblkategori)
        Produk.Show()
        Me.Hide()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        tbNewKat.Text = ""
        Produk.Show()
        Me.Hide()
    End Sub
End Class