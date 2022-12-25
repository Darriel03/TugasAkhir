Imports System.Drawing.Printing
Imports System.DateTime
Public Class Transaksi
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
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

    Private Sub printStruk_Click(sender As Object, e As EventArgs) Handles printStruk.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 8, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center


        Dim waktu As DateTime = DateTime.Now
        Dim waktuformat As String = waktu.ToString("DD:MM:yy")
        Dim garis As String
        garis = "....................................................................................................."

        e.Graphics.DrawString("RETINA DIGICAM", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("JL.PENJARINGAN ASRI XVII NO. 19, PS I-E 29M", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("TELP: +6231-87862493 / HP: +6282111160035", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 55, tengah)
        e.Graphics.DrawString("No Faktur ", f10, Brushes.Black, 10, 70)
        e.Graphics.DrawString(txtFaktur.Text, f10, Brushes.Black, 80, 70)
        e.Graphics.DrawString("Kasir     ", f10, Brushes.Black, 10, 85)
        e.Graphics.DrawString("10/ANDIN ", f10, Brushes.Black, 80, 85)

        e.Graphics.DrawString(waktu, f10, Brushes.Black, centermargin, 105, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 115, tengah)

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To DataGridView2.Rows.Count - 1
            tinggi += 15
            e.Graphics.DrawString(DataGridView2.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 10, 120 + tinggi)
            e.Graphics.DrawString(DataGridView2.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 20, 120 + tinggi)

            i = DataGridView2.Rows(baris).Cells(2).Value
            DataGridView2.Rows(baris).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView2.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 220, 120 + tinggi)

        Next
        tinggi = 120 + tinggi
        'hitungtotal() --> belom ada methodnya

        e.Graphics.DrawString("THANK YOU", f10, Brushes.Black, centermargin, 35 + tinggi, tengah)
        e.Graphics.DrawString("Please Come Again...", f10, Brushes.Black, centermargin, 50 + tinggi, tengah)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class