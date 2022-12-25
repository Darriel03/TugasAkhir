﻿Imports MySql.Data.MySqlClient

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

    Private Sub TabControl2lick(sender As Object, e As EventArgs) Handles TabControl2.Click
        Call tampillappembeliannow()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call tampillappembeliandate()

    End Sub

    ''syntax print
    Private bitmap As Bitmap
    Private Sub iPrintPenjualan()
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        iPrintPenjualan()
    End Sub
    Private Sub iPrintPembeliann()
        Dim height As Integer = DataGridView2.Height
        DataGridView2.Height = DataGridView2.RowCount * DataGridView2.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView2.Width, Me.DataGridView2.Height)
        DataGridView2.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView2.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
    End Sub
    Private Sub btnPrintPembelian_Click(sender As Object, e As EventArgs) Handles btnPrintPembelian.Click
        iPrintPembeliann()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnUtama_Click(sender As Object, e As EventArgs) Handles btnUtama.Click
        Utama.Show()
        Me.Hide()
    End Sub

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
        btnLaporan.Enabled = False
    End Sub

End Class