Imports MySql.Data.MySqlClient
Public Class stokBarang
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
        btnStok.Enabled = False
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Laporan.Show()
        Me.Hide()
    End Sub

    Private Sub tampilBrg()
        Call koneksi()
        adr = New MySqlDataAdapter("SELECT kodebarang, namabarang, merekbarang, k.namakategori, hargajual, hargabeli FROM tblbarang b INNER JOIN tblkategori k ON b.idkategori = k.idkategori", conn)
        adt = New DataSet
        adr.Fill(adt, "tblbarang")
        dgvListBarang.DataSource = adt.Tables("tblbarang")
        dgvListBarang.AllowUserToAddRows = False
        Dim checkboxcol As New DataGridViewCheckBoxColumn
        With checkboxcol
            .Width = 70
            .Name = "checkboxcol"
            .HeaderText = "Pilih Barang"
        End With
        dgvListBarang.Columns.Insert(0, checkboxcol)
    End Sub

    Sub hitungItem()
        Dim cari As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            cari = cari + DataGridView1.Rows(i).Cells(4).Value
            tbJumlahItem.Text = cari
        Next
    End Sub

    Sub hitungTotal()
        Dim cari As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            cari = cari + DataGridView1.Rows(i).Cells(6).Value
            tbGrandTotal.Text = cari
        Next
    End Sub

    Sub noteditable()
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(5).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
    End Sub

    Sub clear()
        tbNoFakturPmb.Text = ""
        tbJumlahItem.Text = 0
        tbGrandTotal.Text = 0
        TextBox1.Text = 0
        TextBox2.Text = 0
    End Sub

    Private Sub stokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilBrg()
        Call clear()
    End Sub

    Private Sub tbCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCari.TextChanged
        Call koneksi()
        cmd = New MySqlCommand("select * from tblbarang where namabarang like '%" & tbCari.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            adr = New MySqlDataAdapter("select * from tblbarang where namabarang like '%" & tbCari.Text & "%'", conn)
            adt = New DataSet
            adr.Fill(adt)
            dgvListBarang.DataSource = adt.Tables(0)
        Else
            MsgBox("Data Tidak ditemukan")
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 4 Then
            DataGridView1.Rows(e.RowIndex).Cells(6).Value =
                DataGridView1.Rows(e.RowIndex).Cells(3).Value *
                DataGridView1.Rows(e.RowIndex).Cells(4).Value
        End If
        Call hitungItem()
        Call hitungTotal()
    End Sub

    Private Sub dgvListBarang_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListBarang.CellValueChanged
        Dim dt2 As New DataTable
        dt2.Columns.Add("Kode Barang")
        dt2.Columns.Add("Nama Barang")
        dt2.Columns.Add("Merek Barang")
        dt2.Columns.Add("Harga Beli")
        dt2.Columns.Add("Jumlah Beli")
        dt2.Columns.Add("Harga Jual")
        dt2.Columns.Add("Subtotal")
        For Each row As DataGridViewRow In dgvListBarang.Rows
            Dim ischecked As Boolean = Convert.ToBoolean(row.Cells(0).Value)
            If ischecked Then
                dt2.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(6).Value, 0, row.Cells(5).Value, 0)
            End If
        Next
        DataGridView1.DataSource = dt2
        Call noteditable()

    End Sub

    Private Sub dgvListBarang_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvListBarang.CurrentCellDirtyStateChanged
        If dgvListBarang.IsCurrentCellDirty Then
            dgvListBarang.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub btnSimpanPemb_Click(sender As Object, e As EventArgs) Handles btnSimpanPemb.Click
        If tbNoFakturPmb.Text = "" Then
            MsgBox("Nomor Pembelian Belum di isi !! ", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Dim simpan1, simpan As String
            Call koneksi()
            simpan = "INSERT INTO tblstok (idstok,tglpembelian,grandtotal) VALUES (@p1,@p2,@p3)"
            simpan1 = "INSERT INTO tblstokdetail (idstok,kodebarang,qtystok,stokdhrgbeli,stokdhrgjual,totalhrgbeli) VALUES (@p4,@p5,@p6,@p7,@p8,@p9) "

            cmd = conn.CreateCommand
            With cmd
                .CommandText = simpan
                .Connection = conn
                .Parameters.Add("p1", MySqlDbType.VarChar, 20).Value = tbNoFakturPmb.Text
                .Parameters.Add("p2", MySqlDbType.DateTime).Value = datePicker1.Value
                .Parameters.Add("p3", MySqlDbType.Int32).Value = Convert.ToInt32(tbGrandTotal.Text)
                .ExecuteNonQuery()
            End With
            For i As Integer = 0 To DataGridView1.Rows.Count - 2

                cmd = conn.CreateCommand
                With cmd
                    .CommandText = simpan1
                    .Connection = conn
                    .Parameters.Add("p4", MySqlDbType.VarChar, 20).Value = tbNoFakturPmb.Text
                    .Parameters.Add("p5", MySqlDbType.VarChar, 20).Value = DataGridView1.Rows(i).Cells(0).Value
                    .Parameters.Add("p6", MySqlDbType.Int32).Value = DataGridView1.Rows(i).Cells(4).Value
                    .Parameters.Add("p7", MySqlDbType.Int32).Value = DataGridView1.Rows(i).Cells(3).Value
                    .Parameters.Add("p8", MySqlDbType.Int32).Value = DataGridView1.Rows(i).Cells(5).Value
                    .Parameters.Add("p9", MySqlDbType.Int32).Value = DataGridView1.Rows(i).Cells(6).Value
                    .ExecuteNonQuery()
                End With
            Next
            conn.Close()
            cmd.Dispose()
            For Each row As DataGridViewRow In dgvListBarang.Rows
                Dim ischecked As Boolean = Convert.ToBoolean(row.Cells(0).Value)
                If ischecked Then
                    row.Cells(0).Value = False
                End If
            Next
            Call hitungItem()
            Call hitungTotal()
            Call clear()

        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If TextBox1.Text.Length = 1 AndAlso e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim gt As Integer
        Dim byr As Integer
        gt = Convert.ToInt32(tbGrandTotal.Text)
        byr = Convert.ToInt32(TextBox1.Text)
        TextBox2.Text = byr - gt
    End Sub
End Class