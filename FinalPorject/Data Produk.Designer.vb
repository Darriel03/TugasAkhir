<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnStok = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.btnUtama = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpanBrg = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTambahBrg = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTambahKategori = New System.Windows.Forms.Button()
        Me.tbHrgJual = New System.Windows.Forms.TextBox()
        Me.cbKateboriBrg = New System.Windows.Forms.ComboBox()
        Me.TblkategoriBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_pemdesktblkategoridataset = New FinalPorject.db_pemdesktblkategoridataset()
        Me.tbKodeBrg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNamaBrg = New System.Windows.Forms.TextBox()
        Me.tbHrgBeli = New System.Windows.Forms.TextBox()
        Me.tbMerkBrg = New System.Windows.Forms.TextBox()
        Me.TblkategoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblkategoriTableAdapter = New FinalPorject.db_pemdesktblkategoridatasetTableAdapters.tblkategoriTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblkategoriBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_pemdesktblkategoridataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblkategoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox12)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.PictureBox10)
        Me.Panel2.Controls.Add(Me.PictureBox11)
        Me.Panel2.Controls.Add(Me.PictureBox9)
        Me.Panel2.Controls.Add(Me.btnLaporan)
        Me.Panel2.Controls.Add(Me.btnStok)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.btnProduk)
        Me.Panel2.Controls.Add(Me.btnUtama)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox13)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 508)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.FinalPorject.My.Resources.Resources.home__1_
        Me.PictureBox12.Location = New System.Drawing.Point(14, 156)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 70
        Me.PictureBox12.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.FinalPorject.My.Resources.Resources.gadgets
        Me.PictureBox8.Location = New System.Drawing.Point(12, 200)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 66
        Me.PictureBox8.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.FinalPorject.My.Resources.Resources.trolley
        Me.PictureBox10.Location = New System.Drawing.Point(14, 292)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 68
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.FinalPorject.My.Resources.Resources.cash_flow
        Me.PictureBox11.Location = New System.Drawing.Point(13, 339)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 69
        Me.PictureBox11.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.FinalPorject.My.Resources.Resources.pay
        Me.PictureBox9.Location = New System.Drawing.Point(13, 245)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 67
        Me.PictureBox9.TabStop = False
        '
        'btnLaporan
        '
        Me.btnLaporan.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLaporan.Location = New System.Drawing.Point(-4, 333)
        Me.btnLaporan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(231, 50)
        Me.btnLaporan.TabIndex = 74
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnStok
        '
        Me.btnStok.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStok.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStok.Location = New System.Drawing.Point(-4, 287)
        Me.btnStok.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStok.Name = "btnStok"
        Me.btnStok.Size = New System.Drawing.Size(231, 50)
        Me.btnStok.TabIndex = 72
        Me.btnStok.Text = "Stok Barang"
        Me.btnStok.UseVisualStyleBackColor = False
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTransaksi.Location = New System.Drawing.Point(-4, 241)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(231, 50)
        Me.btnTransaksi.TabIndex = 73
        Me.btnTransaksi.Text = " Transaksi"
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'btnProduk
        '
        Me.btnProduk.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProduk.Location = New System.Drawing.Point(-4, 196)
        Me.btnProduk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Size = New System.Drawing.Size(231, 50)
        Me.btnProduk.TabIndex = 71
        Me.btnProduk.Text = "Data Produk"
        Me.btnProduk.UseVisualStyleBackColor = False
        '
        'btnUtama
        '
        Me.btnUtama.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtama.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUtama.Location = New System.Drawing.Point(-4, 150)
        Me.btnUtama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUtama.Name = "btnUtama"
        Me.btnUtama.Size = New System.Drawing.Size(231, 50)
        Me.btnUtama.TabIndex = 75
        Me.btnUtama.Text = "Menu Utama"
        Me.btnUtama.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(93, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(92, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 19)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Selamat Datang,"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.FinalPorject.My.Resources.Resources._60111
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.FinalPorject.My.Resources.Resources.logout__1_
        Me.PictureBox13.Location = New System.Drawing.Point(9, 466)
        Me.PictureBox13.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 60
        Me.PictureBox13.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(-4, 459)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(229, 50)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(218, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 509)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnSimpanBrg)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.btnTambahBrg)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 205)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(651, 292)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(500, 164)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(78, 32)
        Me.btnBatal.TabIndex = 26
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        Me.btnBatal.Visible = False
        '
        'btnSimpanBrg
        '
        Me.btnSimpanBrg.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanBrg.Location = New System.Drawing.Point(500, 126)
        Me.btnSimpanBrg.Name = "btnSimpanBrg"
        Me.btnSimpanBrg.Size = New System.Drawing.Size(78, 32)
        Me.btnSimpanBrg.TabIndex = 25
        Me.btnSimpanBrg.Text = "SIMPAN"
        Me.btnSimpanBrg.UseVisualStyleBackColor = True
        Me.btnSimpanBrg.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 11)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(493, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'btnTambahBrg
        '
        Me.btnTambahBrg.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahBrg.Location = New System.Drawing.Point(500, 11)
        Me.btnTambahBrg.Name = "btnTambahBrg"
        Me.btnTambahBrg.Size = New System.Drawing.Size(78, 32)
        Me.btnTambahBrg.TabIndex = 22
        Me.btnTambahBrg.Text = "TAMBAH"
        Me.btnTambahBrg.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(500, 88)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(78, 32)
        Me.btnHapus.TabIndex = 24
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(500, 50)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(78, 32)
        Me.btnUbah.TabIndex = 23
        Me.btnUbah.Text = "UBAH"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTambahKategori)
        Me.GroupBox1.Controls.Add(Me.tbHrgJual)
        Me.GroupBox1.Controls.Add(Me.cbKateboriBrg)
        Me.GroupBox1.Controls.Add(Me.tbKodeBrg)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbNamaBrg)
        Me.GroupBox1.Controls.Add(Me.tbHrgBeli)
        Me.GroupBox1.Controls.Add(Me.tbMerkBrg)
        Me.GroupBox1.Font = New System.Drawing.Font("Constantia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(651, 202)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'btnTambahKategori
        '
        Me.btnTambahKategori.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahKategori.Location = New System.Drawing.Point(320, 45)
        Me.btnTambahKategori.Name = "btnTambahKategori"
        Me.btnTambahKategori.Size = New System.Drawing.Size(78, 27)
        Me.btnTambahKategori.TabIndex = 30
        Me.btnTambahKategori.Text = "TAMBAH"
        Me.btnTambahKategori.UseVisualStyleBackColor = True
        '
        'tbHrgJual
        '
        Me.tbHrgJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHrgJual.Location = New System.Drawing.Point(131, 167)
        Me.tbHrgJual.Name = "tbHrgJual"
        Me.tbHrgJual.Size = New System.Drawing.Size(143, 26)
        Me.tbHrgJual.TabIndex = 29
        '
        'cbKateboriBrg
        '
        Me.cbKateboriBrg.DataSource = Me.TblkategoriBindingSource1
        Me.cbKateboriBrg.DisplayMember = "namakategori"
        Me.cbKateboriBrg.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKateboriBrg.FormattingEnabled = True
        Me.cbKateboriBrg.Location = New System.Drawing.Point(131, 45)
        Me.cbKateboriBrg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbKateboriBrg.Name = "cbKateboriBrg"
        Me.cbKateboriBrg.Size = New System.Drawing.Size(170, 27)
        Me.cbKateboriBrg.TabIndex = 27
        Me.cbKateboriBrg.ValueMember = "idkategori"
        '
        'TblkategoriBindingSource1
        '
        Me.TblkategoriBindingSource1.DataMember = "tblkategori"
        Me.TblkategoriBindingSource1.DataSource = Me.Db_pemdesktblkategoridataset
        '
        'Db_pemdesktblkategoridataset
        '
        Me.Db_pemdesktblkategoridataset.DataSetName = "db_pemdesktblkategoridataset"
        Me.Db_pemdesktblkategoridataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbKodeBrg
        '
        Me.tbKodeBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKodeBrg.Location = New System.Drawing.Point(131, 15)
        Me.tbKodeBrg.Name = "tbKodeBrg"
        Me.tbKodeBrg.Size = New System.Drawing.Size(170, 26)
        Me.tbKodeBrg.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Harga Jual"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Kode Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Merek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Harga Beli"
        '
        'tbNamaBrg
        '
        Me.tbNamaBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaBrg.Location = New System.Drawing.Point(131, 76)
        Me.tbNamaBrg.Name = "tbNamaBrg"
        Me.tbNamaBrg.Size = New System.Drawing.Size(235, 26)
        Me.tbNamaBrg.TabIndex = 19
        '
        'tbHrgBeli
        '
        Me.tbHrgBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHrgBeli.Location = New System.Drawing.Point(131, 136)
        Me.tbHrgBeli.Name = "tbHrgBeli"
        Me.tbHrgBeli.Size = New System.Drawing.Size(143, 26)
        Me.tbHrgBeli.TabIndex = 21
        '
        'tbMerkBrg
        '
        Me.tbMerkBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMerkBrg.Location = New System.Drawing.Point(131, 106)
        Me.tbMerkBrg.Name = "tbMerkBrg"
        Me.tbMerkBrg.Size = New System.Drawing.Size(170, 26)
        Me.tbMerkBrg.TabIndex = 20
        '
        'TblkategoriBindingSource
        '
        Me.TblkategoriBindingSource.DataMember = "tblkategori"
        '
        'TblkategoriTableAdapter
        '
        Me.TblkategoriTableAdapter.ClearBeforeFill = True
        '
        'Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 506)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblkategoriBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_pemdesktblkategoridataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblkategoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbKateboriBrg As ComboBox
    Friend WithEvents tbKodeBrg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambahBrg As Button
    Friend WithEvents tbHrgBeli As TextBox
    Friend WithEvents tbMerkBrg As TextBox
    Friend WithEvents tbNamaBrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnStok As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnProduk As Button
    Friend WithEvents btnUtama As Button
    Friend WithEvents tbHrgJual As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TblkategoriBindingSource As BindingSource
    Friend WithEvents btnTambahKategori As Button
    Friend WithEvents btnSimpanBrg As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Db_pemdesktblkategoridataset As db_pemdesktblkategoridataset
    Friend WithEvents TblkategoriBindingSource1 As BindingSource
    Friend WithEvents TblkategoriTableAdapter As db_pemdesktblkategoridatasetTableAdapters.tblkategoriTableAdapter
End Class