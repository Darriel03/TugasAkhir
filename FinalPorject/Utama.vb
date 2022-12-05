Public Class Utama
    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        Produk.Show()
        Me.Hide()
    End Sub
    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Transaksi.Show()
        Me.Hide()
    End Sub
    Private Sub btnStok_Click(sender As Object, e As EventArgs) Handles btnStok.Click
        stokBarang.Show()
        Me.Hide()
    End Sub

End Class