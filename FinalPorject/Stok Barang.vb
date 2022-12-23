Imports MySql.Data.MySqlClient
Public Class stokBarang
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

    Private Sub stokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilBrg()

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
            Dim simpan1, simpan, ubah As String
            Call koneksi()
            simpan = "INSERT INTO tblstok (idstok,tglpembelian,grandtotal) VALUES (@p1,@p2,@p3)"
            simpan1 = "INSERT INTO tblstokdetail (idstok,kodebarang,qtystok,stokdhrgbeli,stokdhrgjual,totalhrgbeli) VALUES (@p4,@p5,@p6,@p7,@p8,@p9) "
            ubah = "UPDATE barang SET jumlah=@p9 WHERE kodebrg = @p10"
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                cmd = conn.CreateCommand
                With cmd
                    .CommandText = simpan
                    .Connection = conn
                    .Parameters.Add("p1", MySqlDbType.String, 10).Value = tbNoFakturPmb.Text
                    .Parameters.Add("p2", MySqlDbType.String, 20).Value = datePicker1.Text
                    .ExecuteNonQuery()
                End With


                cmd = conn.CreateCommand
                With cmd
                    .CommandText = ubah
                    .Connection = conn
                    .Parameters.Add("p9", MySqlDbType.UInt32).Value =
                    DataGridView1.Rows(i).Cells(5).Value
                    .Parameters.Add("p10", MySqlDbType.String).Value =
                    DataGridView1.Rows(i).Cells(0).Value
                    .ExecuteNonQuery()
                End With
            Next
        End If
        conn.Close()
        cmd.Dispose()
        DataGridView1.Rows.Clear()
    End Sub
End Class