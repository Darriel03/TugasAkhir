Imports MySql.Data.MySqlClient
Public Class stokBarang
    Private Sub tampilBrg()
        Call koneksi()
        adr = New MySqlDataAdapter("select * from tblbarang", conn)
        adt = New DataSet
        adr.Fill(adt, "tblbarang")
        dgvListBarang.DataSource = adt.Tables("tblbarang")
    End Sub

    Sub hitungItem()
        Dim cari As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            cari = cari + DataGridView1.Rows(i).Cells(3).Value
            tbJumlahItem.Text = cari
        Next
    End Sub

    Sub hitungTotal()
        Dim cari As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            cari = cari + DataGridView1.Rows(i).Cells(5).Value
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
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(0).Value =
                UCase(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Call koneksi()
            cmd = New MySqlCommand("SELECT * from tblbarang WHERE kodebarang = '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = dr.Item("namabarang")
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = dr.Item("hargabeli")
                DataGridView1.Rows(e.RowIndex).Cells(3).Value = dr.Item("hargajual")
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = 0
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = 0
            Else
                MsgBox("Maaf, Data  tidak Ditemukan", MsgBoxStyle.Exclamation, "Peringatan")
                DataGridView1.Focus()
            End If
        End If
        If e.ColumnIndex = 3 Then
            DataGridView1.Rows(e.RowIndex).Cells(5).Value =
                DataGridView1.Rows(e.RowIndex).Cells(2).Value *
                DataGridView1.Rows(e.RowIndex).Cells(3).Value
        End If
        Call hitungItem()
        Call hitungTotal()
    End Sub

    Private Sub dgvListBarang_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListBarang.CellMouseClick
        On Error Resume Next
        DataGridView1.Rows(e.RowIndex).Cells(0).Value = dgvListBarang.Rows(e.RowIndex).Cells(0).Value
        DataGridView1.Rows(e.RowIndex).Cells(1).Value = dgvListBarang.Rows(e.RowIndex).Cells(2).Value
        DataGridView1.Rows(e.RowIndex).Cells(2).Value = dgvListBarang.Rows(e.RowIndex).Cells(4).Value
        DataGridView1.Rows(e.RowIndex).Cells(4).Value = dgvListBarang.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub btnSimpanPemb_Click(sender As Object, e As EventArgs) Handles btnSimpanPemb.Click

    End Sub
End Class