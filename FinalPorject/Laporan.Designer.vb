<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPagePenjualan = New System.Windows.Forms.TabPage()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idtransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglpenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grandtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPagePembelian = New System.Windows.Forms.TabPage()
        Me.btnPrintPembelian = New System.Windows.Forms.Button()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Db_pemdesktblkategoridataset = New FinalPorject.db_pemdesktblkategoridataset()
        Me.DbpemdesktblkategoridatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.btnUtama = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnStok = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TabControl2.SuspendLayout()
        Me.TabPagePenjualan.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePembelian.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_pemdesktblkategoridataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbpemdesktblkategoridatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPagePenjualan)
        Me.TabControl2.Controls.Add(Me.TabPagePembelian)
        Me.TabControl2.Location = New System.Drawing.Point(306, 0)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(905, 657)
        Me.TabControl2.TabIndex = 63
        '
        'TabPagePenjualan
        '
        Me.TabPagePenjualan.Controls.Add(Me.btnPrint)
        Me.TabPagePenjualan.Controls.Add(Me.DateTimePicker3)
        Me.TabPagePenjualan.Controls.Add(Me.Button5)
        Me.TabPagePenjualan.Controls.Add(Me.DateTimePicker1)
        Me.TabPagePenjualan.Controls.Add(Me.DataGridView1)
        Me.TabPagePenjualan.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePenjualan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPagePenjualan.Name = "TabPagePenjualan"
        Me.TabPagePenjualan.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPagePenjualan.Size = New System.Drawing.Size(897, 628)
        Me.TabPagePenjualan.TabIndex = 0
        Me.TabPagePenjualan.Text = "Laporan Penjualan"
        Me.TabPagePenjualan.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(790, 23)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(91, 31)
        Me.btnPrint.TabIndex = 63
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(232, 24)
        Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 30)
        Me.DateTimePicker3.TabIndex = 62
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(445, 23)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 33)
        Me.Button5.TabIndex = 61
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(14, 24)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 30)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idtransaksi, Me.tglpenjualan, Me.grandtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 77)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(867, 524)
        Me.DataGridView1.TabIndex = 0
        '
        'idtransaksi
        '
        Me.idtransaksi.HeaderText = "ID Transaksi"
        Me.idtransaksi.MinimumWidth = 6
        Me.idtransaksi.Name = "idtransaksi"
        Me.idtransaksi.Width = 150
        '
        'tglpenjualan
        '
        Me.tglpenjualan.HeaderText = "Tanggal Penjualan"
        Me.tglpenjualan.MinimumWidth = 6
        Me.tglpenjualan.Name = "tglpenjualan"
        Me.tglpenjualan.Width = 200
        '
        'grandtotal
        '
        Me.grandtotal.HeaderText = "Grand Total"
        Me.grandtotal.MinimumWidth = 6
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.Width = 250
        '
        'TabPagePembelian
        '
        Me.TabPagePembelian.Controls.Add(Me.btnPrintPembelian)
        Me.TabPagePembelian.Controls.Add(Me.DateTimePicker4)
        Me.TabPagePembelian.Controls.Add(Me.Button6)
        Me.TabPagePembelian.Controls.Add(Me.DateTimePicker2)
        Me.TabPagePembelian.Controls.Add(Me.DataGridView2)
        Me.TabPagePembelian.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePembelian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPagePembelian.Name = "TabPagePembelian"
        Me.TabPagePembelian.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPagePembelian.Size = New System.Drawing.Size(897, 628)
        Me.TabPagePembelian.TabIndex = 1
        Me.TabPagePembelian.Text = "Laporan Pembelian"
        Me.TabPagePembelian.UseVisualStyleBackColor = True
        '
        'btnPrintPembelian
        '
        Me.btnPrintPembelian.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPembelian.Location = New System.Drawing.Point(785, 21)
        Me.btnPrintPembelian.Name = "btnPrintPembelian"
        Me.btnPrintPembelian.Size = New System.Drawing.Size(98, 32)
        Me.btnPrintPembelian.TabIndex = 66
        Me.btnPrintPembelian.Text = "Print"
        Me.btnPrintPembelian.UseVisualStyleBackColor = True
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(223, 23)
        Me.DateTimePicker4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(200, 30)
        Me.DateTimePicker4.TabIndex = 65
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(429, 21)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 33)
        Me.Button6.TabIndex = 64
        Me.Button6.Text = "Cari"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(17, 23)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 30)
        Me.DateTimePicker2.TabIndex = 63
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(14, 74)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(869, 526)
        Me.DataGridView2.TabIndex = 62
        '
        'Db_pemdesktblkategoridataset
        '
        Me.Db_pemdesktblkategoridataset.DataSetName = "db_pemdesktblkategoridataset"
        Me.Db_pemdesktblkategoridataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbpemdesktblkategoridatasetBindingSource
        '
        Me.DbpemdesktblkategoridatasetBindingSource.DataSource = Me.Db_pemdesktblkategoridataset
        Me.DbpemdesktblkategoridatasetBindingSource.Position = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox12)
        Me.Panel2.Controls.Add(Me.btnUtama)
        Me.Panel2.Controls.Add(Me.PictureBox10)
        Me.Panel2.Controls.Add(Me.PictureBox11)
        Me.Panel2.Controls.Add(Me.PictureBox9)
        Me.Panel2.Controls.Add(Me.btnLaporan)
        Me.Panel2.Controls.Add(Me.btnStok)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.PictureBox13)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.btnProduk)
        Me.Panel2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 654)
        Me.Panel2.TabIndex = 64
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.FinalPorject.My.Resources.Resources.home__1_
        Me.PictureBox12.Location = New System.Drawing.Point(18, 203)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 80
        Me.PictureBox12.TabStop = False
        '
        'btnUtama
        '
        Me.btnUtama.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtama.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUtama.Location = New System.Drawing.Point(-5, 196)
        Me.btnUtama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUtama.Name = "btnUtama"
        Me.btnUtama.Size = New System.Drawing.Size(322, 62)
        Me.btnUtama.TabIndex = 85
        Me.btnUtama.Text = "Menu Utama"
        Me.btnUtama.UseVisualStyleBackColor = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.FinalPorject.My.Resources.Resources.trolley
        Me.PictureBox10.Location = New System.Drawing.Point(18, 371)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 78
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.FinalPorject.My.Resources.Resources.cash_flow
        Me.PictureBox11.Location = New System.Drawing.Point(18, 428)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 79
        Me.PictureBox11.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.FinalPorject.My.Resources.Resources.pay
        Me.PictureBox9.Location = New System.Drawing.Point(18, 313)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 77
        Me.PictureBox9.TabStop = False
        '
        'btnLaporan
        '
        Me.btnLaporan.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLaporan.Location = New System.Drawing.Point(-6, 420)
        Me.btnLaporan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(323, 62)
        Me.btnLaporan.TabIndex = 84
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnStok
        '
        Me.btnStok.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStok.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStok.Location = New System.Drawing.Point(-6, 364)
        Me.btnStok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStok.Name = "btnStok"
        Me.btnStok.Size = New System.Drawing.Size(323, 62)
        Me.btnStok.TabIndex = 82
        Me.btnStok.Text = "Stok Barang"
        Me.btnStok.UseVisualStyleBackColor = False
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTransaksi.Location = New System.Drawing.Point(-6, 308)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(323, 62)
        Me.btnTransaksi.TabIndex = 83
        Me.btnTransaksi.Text = " Transaksi"
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox13.Image = Global.FinalPorject.My.Resources.Resources.logout__1_
        Me.PictureBox13.Location = New System.Drawing.Point(10, 603)
        Me.PictureBox13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(59, 47)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 67
        Me.PictureBox13.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(136, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(135, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang,"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.FinalPorject.My.Resources.Resources._60111
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(-6, 595)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(323, 62)
        Me.btnLogout.TabIndex = 86
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.FinalPorject.My.Resources.Resources.gadgets
        Me.PictureBox8.Location = New System.Drawing.Point(16, 257)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 76
        Me.PictureBox8.TabStop = False
        '
        'btnProduk
        '
        Me.btnProduk.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProduk.Location = New System.Drawing.Point(-6, 252)
        Me.btnProduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Size = New System.Drawing.Size(323, 62)
        Me.btnProduk.TabIndex = 81
        Me.btnProduk.Text = "Data Produk"
        Me.btnProduk.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 653)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "laporan"
        Me.Text = "Form1"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPagePenjualan.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePembelian.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_pemdesktblkategoridataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbpemdesktblkategoridatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPagePenjualan As TabPage
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPagePembelian As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Db_pemdesktblkategoridataset As db_pemdesktblkategoridataset
    Friend WithEvents DbpemdesktblkategoridatasetBindingSource As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents idtransaksi As DataGridViewTextBoxColumn
    Friend WithEvents tglpenjualan As DataGridViewTextBoxColumn
    Friend WithEvents grandtotal As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents btnUtama As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnStok As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnProduk As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrintPembelian As Button
End Class
