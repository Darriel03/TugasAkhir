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

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Laporan.Show()
        Me.Hide()
    End Sub

    Private Sub btnUtama_Click(sender As Object, e As EventArgs) Handles btnUtama.Click
        btnUtama.Enabled = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class