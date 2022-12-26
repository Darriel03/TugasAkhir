Imports MySql.Data.MySqlClient
Public Class Transaksi
    Private Sub clear()
        TextBox1.Text = 0
        TextBox14.Text = 0

    End Sub

    Private Sub tampilBrg()
        Call koneksi()
        adr = New MySqlDataAdapter("SELECT a.kodebarang, b.namabarang, b.merekbarang, b.hargajual, SUM(a.qtystok) as stok FROM tblstokdetail a 
JOIN tblbarang b ON a.kodebarang = b.kodebarang WHERE b.kodebarang NOT IN (SELECT kodebarang FROM tbltransaksidetail)
UNION ALL
SELECT stok.kodebarang, b.namabarang, b.merekbarang, b.hargajual, (stok - jual) as Stok
     FROM ( 
    (SELECT SUM(qtystok) as stok,kodebarang FROM tblstokdetail GROUP BY kodebarang) as stok
       INNER JOIN 
    (SELECT SUM(qtypenjualan) as jual,kodebarang FROM tbltransaksidetail GROUP BY kodebarang) as jual 
     ON stok.kodebarang = jual.kodebarang) JOIN tblbarang b ON stok.kodebarang = b.kodebarang;", conn)
        adt = New DataSet
        adr.Fill(adt, "tblstokdetail")
        dgvListBarang.DataSource = adt.Tables("tblstokdetail")
        dgvListBarang.AllowUserToAddRows = False
        Dim checkboxcol As New DataGridViewCheckBoxColumn
        With checkboxcol
            .Width = 70
            .Name = "checkboxcol"
            .HeaderText = "Pilih Barang"
        End With
        dgvListBarang.Columns.Insert(0, checkboxcol)
        If dgvListBarang(0, 0).Value Is Nothing Then
            dgvListBarang.Rows.Remove(dgvListBarang.Rows(0))
        End If
    End Sub

    Private Sub tampilBrgUpdate()
        Call koneksi()
        adr = New MySqlDataAdapter("SELECT a.kodebarang, b.namabarang, b.merekbarang, b.hargajual, SUM(a.qtystok) as stok FROM tblstokdetail a 
JOIN tblbarang b ON a.kodebarang = b.kodebarang WHERE b.kodebarang NOT IN (SELECT kodebarang FROM tbltransaksidetail)
UNION ALL
SELECT stok.kodebarang, b.namabarang, b.merekbarang, b.hargajual, (stok - jual) as Stok
     FROM ( 
    (SELECT SUM(qtystok) as stok,kodebarang FROM tblstokdetail GROUP BY kodebarang) as stok
       INNER JOIN 
    (SELECT SUM(qtypenjualan) as jual,kodebarang FROM tbltransaksidetail GROUP BY kodebarang) as jual 
     ON stok.kodebarang = jual.kodebarang) JOIN tblbarang b ON stok.kodebarang = b.kodebarang;", conn)
        adt = New DataSet
        adr.Fill(adt, "tblstokdetail")
        dgvListBarang.DataSource = adt.Tables("tblstokdetail")
        dgvListBarang.AllowUserToAddRows = False
        If dgvListBarang(0, 0).Value Is Nothing Then
            dgvListBarang.Rows.Remove(dgvListBarang.Rows(0))
        End If
    End Sub

    Sub auto()
        Call koneksi()
        cmd = New MySqlCommand("select idtransaksi from tbltransaksi order by idtransaksi desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TextBox6.Text = "PJ" + "0001"
        Else
            TextBox6.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("idtransaksi").ToString, 4, 3)) + 1
            If Len(TextBox6.Text) = 1 Then
                TextBox6.Text = "PJ000" & TextBox6.Text & ""
            ElseIf Len(TextBox6.Text) = 2 Then
                TextBox6.Text = "PJ00" & TextBox6.Text & ""
            ElseIf Len(TextBox6.Text) = 3 Then
                TextBox6.Text = "PJ0" & TextBox6.Text & ""
            End If
        End If

    End Sub

    Sub hitungTotal()
        Dim cari As Integer = 0
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            cari = cari + DataGridView2.Rows(i).Cells(7).Value
            TextBox1.Text = cari
        Next
    End Sub

    Sub noteditable()
        DataGridView2.Columns(0).ReadOnly = True
        DataGridView2.Columns(1).ReadOnly = True
        DataGridView2.Columns(2).ReadOnly = True
        DataGridView2.Columns(3).ReadOnly = True
        DataGridView2.Columns(4).ReadOnly = True
        DataGridView2.Columns(6).ReadOnly = True
        DataGridView2.Columns(7).ReadOnly = True
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call auto()
        Call koneksi()
        Call clear()
        Call tampilBrg()

    End Sub



    Private Sub tbCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCari.TextChanged
        Call koneksi()
        cmd = New MySqlCommand("SELECT tblstokdetail.kodebarang, tblbarang.namabarang, tblbarang.merekbarang, tblbarang.hargajual, SUM(qtystok) AS 'STOK' FROM tblstokdetail,tblbarang WHERE tblstokdetail.kodebarang = tblbarang.kodebarang AND tblbarang.namabarang LIKE '%" & tbCari.Text & "%' GROUP BY tblstokdetail.kodebarang", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            adr = New MySqlDataAdapter("SELECT tblstokdetail.kodebarang, tblbarang.namabarang, tblbarang.merekbarang, tblbarang.hargajual, SUM(qtystok) AS 'STOK' FROM tblstokdetail,tblbarang WHERE tblstokdetail.kodebarang = tblbarang.kodebarang AND tblbarang.namabarang LIKE '%" & tbCari.Text & "%' GROUP BY tblstokdetail.kodebarang", conn)
            adt = New DataSet
            adr.Fill(adt)
            dgvListBarang.DataSource = adt.Tables(0)
        Else
            MsgBox("Data Tidak ditemukan")
        End If
    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        If e.ColumnIndex = 5 Then
            DataGridView2.Rows(e.RowIndex).Cells(7).Value =
                DataGridView2.Rows(e.RowIndex).Cells(3).Value *
                DataGridView2.Rows(e.RowIndex).Cells(5).Value
            DataGridView2.Rows(e.RowIndex).Cells(6).Value =
                DataGridView2.Rows(e.RowIndex).Cells(4).Value -
                DataGridView2.Rows(e.RowIndex).Cells(5).Value
        End If
        Dim min As Integer
        min = DataGridView2.Rows(e.RowIndex).Cells(4).Value - DataGridView2.Rows(e.RowIndex).Cells(5).Value
        If min < 0 Then
            MsgBox("Stok tidak mencukupi")
            DataGridView2.Rows(e.RowIndex).Cells(5).Value = 0
            DataGridView2.Rows(e.RowIndex).Cells(7).Value =
                DataGridView2.Rows(e.RowIndex).Cells(3).Value *
                DataGridView2.Rows(e.RowIndex).Cells(5).Value
            DataGridView2.Rows(e.RowIndex).Cells(6).Value =
                DataGridView2.Rows(e.RowIndex).Cells(4).Value -
                DataGridView2.Rows(e.RowIndex).Cells(5).Value
        End If
        Call hitungTotal()

    End Sub

    Private Sub dgvListBarang_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListBarang.CellValueChanged
        Dim dt2 As New DataTable
        dt2.Columns.Add("Kode Barang")
        dt2.Columns.Add("Nama Barang")
        dt2.Columns.Add("Merek Barang")
        dt2.Columns.Add("Harga")
        dt2.Columns.Add("Stok Awal")
        dt2.Columns.Add("Jumlah")
        dt2.Columns.Add("Stok Akhir")
        dt2.Columns.Add("Subtotal")
        For Each row As DataGridViewRow In dgvListBarang.Rows
            Dim ischecked As Boolean = Convert.ToBoolean(row.Cells(0).Value)
            If ischecked Then
                dt2.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, 0, row.Cells(5).Value, 0)
            End If
        Next
        DataGridView2.DataSource = dt2
        Call noteditable()

    End Sub

    Private Sub dgvListBarang_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvListBarang.CurrentCellDirtyStateChanged
        If dgvListBarang.IsCurrentCellDirty Then
            dgvListBarang.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If TextBox14.Text.Length = 1 AndAlso e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Dim gt As Integer
        Dim byr As Integer
        gt = Convert.ToInt32(TextBox1.Text)
        byr = Convert.ToInt32(TextBox14.Text)
        TextBox13.Text = byr - gt
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim simpan1, simpan As String
        Call koneksi()
        simpan = "INSERT INTO tbltransaksi (idtransaksi,tglpenjualan,grandtotal) VALUES (@p1,@p2,@p3)"
        simpan1 = "INSERT INTO tbltransaksidetail (idtransaksi,kodebarang,qtypenjualan,hargajual,totalhrgjual) VALUES (@p4,@p5,@p6,@p7,@p8) "

        cmd = conn.CreateCommand
        With cmd
            .CommandText = simpan
            .Connection = conn
            .Parameters.Add("p1", MySqlDbType.VarChar, 20).Value = TextBox6.Text
            .Parameters.Add("p2", MySqlDbType.DateTime).Value = DateTimePicker1.Value
            .Parameters.Add("p3", MySqlDbType.Int32).Value = Convert.ToInt32(TextBox1.Text)
            .ExecuteNonQuery()
        End With
        For i As Integer = 0 To DataGridView2.Rows.Count - 2

            cmd = conn.CreateCommand
            With cmd
                .CommandText = simpan1
                .Connection = conn
                .Parameters.Add("p4", MySqlDbType.VarChar, 20).Value = TextBox6.Text
                .Parameters.Add("p5", MySqlDbType.VarChar, 20).Value = DataGridView2.Rows(i).Cells(0).Value
                .Parameters.Add("p6", MySqlDbType.Int32).Value = DataGridView2.Rows(i).Cells(5).Value
                .Parameters.Add("p7", MySqlDbType.Int32).Value = DataGridView2.Rows(i).Cells(3).Value
                .Parameters.Add("p8", MySqlDbType.Int32).Value = DataGridView2.Rows(i).Cells(7).Value
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
        Call hitungTotal()
        Call auto()
        Call clear()
        Call tampilBrgUpdate()
    End Sub

    Private Sub btnUtama_Click(sender As Object, e As EventArgs) Handles btnUtama.Click
        Utama.Show()
        Me.Close()

    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        Produk.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stokBarang.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        laporan.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class