Imports System.Drawing.Printing
Imports System.DateTime
Public Class Transaksi
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub btnUtama_Click(sender As Object, e As EventArgs) Handles btnUtama.Click
        Utama.Show()
        Me.Hide()
    End Sub
    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        Produk.Show()
        Me.Hide()
    End Sub
    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        btnTransaksi.Enabled = False
    End Sub
    Private Sub btnStok_Click(sender As Object, e As EventArgs) Handles btnStok.Click
        stokBarang.Show()
        Me.Hide()
    End Sub
    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        laporan.Show()
        Me.Hide()
    End Sub

    Sub ubahpjgkertas()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgvTransaksi.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 300
    End Sub

    Private Sub printStruk_Click(sender As Object, e As EventArgs) Handles printStruk.Click
        ubahpjgkertas()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print() 'Direct Print
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 300, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 350, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Times New Roman", 8, FontStyle.Regular)
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim kanan As New StringFormat
        Dim tengah As New StringFormat

        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "............................................................................................."

        'menampilkan datetime
        Dim waktu As DateTime = DateTime.Now
        Dim waktuformat As String = waktu.ToString("DD:MM:yy")


        e.Graphics.DrawString("RETINA DIGICAM", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.Penjaringan Asri XVII N0. 19, PS I-E 29M", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("Telp: +6231-87862493 / HP: +6282111160035", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 60, tengah)
        e.Graphics.DrawString("No Faktur" & vbTab & txtFaktur.Text, f10, Brushes.Black, 10, 75)
        e.Graphics.DrawString("Kasir" & vbTab & vbTab & "10/Andin", f10, Brushes.Black, 10, 90)
        e.Graphics.DrawString(waktu, f10, Brushes.Black, 10, 110)

        'DetailHeader
        e.Graphics.DrawString("Qty" & vbTab & "Item" & vbTab & vbTab & "Harga" & vbTab & vbTab & "  Total", f10, Brushes.Black, 10, 130)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 135, tengah)

        Dim tinggi As Integer 'DGV Posisi
        Dim i As Long

        For baris As Integer = 0 To dgvTransaksi.Rows.Count - 1
            tinggi += 15
            e.Graphics.DrawString(dgvTransaksi.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 10, 120 + tinggi)
            e.Graphics.DrawString(dgvTransaksi.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 25, 120 + tinggi)

            i = dgvTransaksi.Rows(baris).Cells(2).Value
            dgvTransaksi.Rows(baris).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(dgvTransaksi.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 220, 120 + tinggi)

            'total price
            Dim total As Long
            total = Val(dgvTransaksi.Rows(baris).Cells(1).Value * dgvTransaksi.Rows(baris).Cells(2).Value)
            e.Graphics.DrawString(total.ToString("##,##0"), f8, Brushes.Black, rightmargin, 115 + tinggi, kanan)

        Next
        Dim tinggi2 As Integer
        tinggi2 = 145 + tinggi

        hitungharga()

        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, tinggi2, tengah)
        e.Graphics.DrawString("Total" & Format(t_harga, "   ##,##0"), f10b, Brushes.Black, 245, 15 + tinggi2, kanan)
        e.Graphics.DrawString("Bayar" & Format(t_harga, "   ##,##0"), f10b, Brushes.Black, 245, 30 + tinggi2, kanan)
        e.Graphics.DrawString("Kembali" & Format(t_harga, "   ##,##0"), f10b, Brushes.Black, 245, 45 + tinggi2, kanan)
        e.Graphics.DrawString(t_qty & Format(t_qty, "#"), f10b, Brushes.Black, 10, 15 + tinggi2)
        e.Graphics.DrawString("Thanks for Shopping...", f10, Brushes.Black, centermargin, 100 + tinggi2, tengah)
        e.Graphics.DrawString(" ~ RETINA DIGICAM ~ ", f10, Brushes.Black, centermargin, 120 + tinggi2, tengah)
    End Sub

    Dim t_harga As Long
    Dim t_qty As Long
    Private Sub hitungharga()
        Dim hitung As Long = 0
        For rowitem As Long = 0 To dgvTransaksi.Rows.Count - 1
            hitung = hitung + Val(dgvTransaksi.Rows(rowitem).Cells(2).Value * dgvTransaksi.Rows(rowitem).Cells(1).Value)
        Next
        t_harga = hitung
        Dim countqty As Long = 0
        For rowitten As Long = 0 To dgvTransaksi.Rows.Count - 1
            countqty = countqty + dgvTransaksi.Rows(rowitten).Cells(1).Value
        Next
        t_qty = countqty
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class