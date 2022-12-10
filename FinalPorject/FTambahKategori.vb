Imports MySql.Data.MySqlClient
Public Class tambahKategori
    Private Sub btnSimpanBrg_Click(sender As Object, e As EventArgs) Handles btnSimpanBrg.Click
        Call koneksi()
        Dim tambahkat As String = "insert into tblkategori (namakategori) values('" & tbNewKat.Text & "')"
        cmd = New MySqlCommand(tambahkat, conn)
        cmd.ExecuteNonQuery()
        tbNewKat.Text = ""
        Produk.TblkategoriTableAdapter.Fill(Produk.Db_pemdeskDataSet1.tblkategori)
        Produk.Show()
        Me.Hide()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        tbNewKat.Text = ""
        Produk.Show()
        Me.Hide()
    End Sub
End Class