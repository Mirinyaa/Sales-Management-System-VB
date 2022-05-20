<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPenjualan
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.txtidjl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbbrg = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnmbrg = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtnmks = New System.Windows.Forms.TextBox()
        Me.txtjmlh = New System.Windows.Forms.TextBox()
        Me.txttot = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txthrbr = New System.Windows.Forms.TextBox()
        Me.lblsisabrg = New System.Windows.Forms.Label()
        Me.lblstokbrg = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdibyr = New System.Windows.Forms.TextBox()
        Me.txtkem = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdis = New System.Windows.Forms.TextBox()
        Me.txtppn = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btstruk = New System.Windows.Forms.Button()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.btcetak = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.txtbersih = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txthrbl = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(553, 107)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(753, 287)
        Me.dgv.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(14, 591)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 25)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "TANGGAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(12, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 25)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(14, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "JUMLAH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(14, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "NAMA KASIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(14, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "ID BARANG"
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.ForeColor = System.Drawing.Color.Blue
        Me.btkeluar.Location = New System.Drawing.Point(1190, 52)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(116, 39)
        Me.btkeluar.TabIndex = 63
        Me.btkeluar.Text = "KEMBALI"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(553, 65)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(590, 22)
        Me.txtfind.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(548, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(592, 29)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "CARI DATA PENJUALAN BERDASARKAN ID PENJUALAN"
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.Blue
        Me.bthapus.Location = New System.Drawing.Point(919, 402)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(105, 39)
        Me.bthapus.TabIndex = 60
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.ForeColor = System.Drawing.Color.Blue
        Me.btbatal.Location = New System.Drawing.Point(667, 402)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(105, 39)
        Me.btbatal.TabIndex = 59
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.ForeColor = System.Drawing.Color.Blue
        Me.btsimpan.Location = New System.Drawing.Point(792, 402)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(105, 39)
        Me.btsimpan.TabIndex = 58
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambah.ForeColor = System.Drawing.Color.Blue
        Me.bttambah.Location = New System.Drawing.Point(556, 402)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(105, 39)
        Me.bttambah.TabIndex = 57
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'txtidjl
        '
        Me.txtidjl.Location = New System.Drawing.Point(177, 62)
        Me.txtidjl.Name = "txtidjl"
        Me.txtidjl.Size = New System.Drawing.Size(237, 22)
        Me.txtidjl.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "ID PENJUALAN"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 46)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(449, 589)
        Me.RichTextBox1.TabIndex = 52
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 39)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Input Data Penjualan"
        '
        'cmbbrg
        '
        Me.cmbbrg.FormattingEnabled = True
        Me.cmbbrg.Location = New System.Drawing.Point(177, 98)
        Me.cmbbrg.Name = "cmbbrg"
        Me.cmbbrg.Size = New System.Drawing.Size(237, 24)
        Me.cmbbrg.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(14, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 25)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "NAMA BARANG"
        '
        'txtnmbrg
        '
        Me.txtnmbrg.Location = New System.Drawing.Point(177, 141)
        Me.txtnmbrg.Name = "txtnmbrg"
        Me.txtnmbrg.Size = New System.Drawing.Size(237, 22)
        Me.txtnmbrg.TabIndex = 75
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(177, 591)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(237, 22)
        Me.dtp.TabIndex = 76
        '
        'txtnmks
        '
        Me.txtnmks.Location = New System.Drawing.Point(177, 214)
        Me.txtnmks.Name = "txtnmks"
        Me.txtnmks.Size = New System.Drawing.Size(237, 22)
        Me.txtnmks.TabIndex = 77
        '
        'txtjmlh
        '
        Me.txtjmlh.Location = New System.Drawing.Point(177, 300)
        Me.txtjmlh.Name = "txtjmlh"
        Me.txtjmlh.Size = New System.Drawing.Size(237, 22)
        Me.txtjmlh.TabIndex = 78
        '
        'txttot
        '
        Me.txttot.Location = New System.Drawing.Point(177, 444)
        Me.txttot.Name = "txttot"
        Me.txttot.Size = New System.Drawing.Size(237, 22)
        Me.txttot.TabIndex = 79
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(14, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 25)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "HARGA BARANG"
        '
        'txthrbr
        '
        Me.txthrbr.Location = New System.Drawing.Point(177, 257)
        Me.txthrbr.Name = "txthrbr"
        Me.txthrbr.Size = New System.Drawing.Size(237, 22)
        Me.txthrbr.TabIndex = 81
        '
        'lblsisabrg
        '
        Me.lblsisabrg.AutoSize = True
        Me.lblsisabrg.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsisabrg.ForeColor = System.Drawing.Color.Blue
        Me.lblsisabrg.Location = New System.Drawing.Point(1192, 488)
        Me.lblsisabrg.Name = "lblsisabrg"
        Me.lblsisabrg.Size = New System.Drawing.Size(112, 19)
        Me.lblsisabrg.TabIndex = 82
        Me.lblsisabrg.Text = "SISA BARANG"
        '
        'lblstokbrg
        '
        Me.lblstokbrg.AutoSize = True
        Me.lblstokbrg.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstokbrg.ForeColor = System.Drawing.Color.Blue
        Me.lblstokbrg.Location = New System.Drawing.Point(1192, 469)
        Me.lblstokbrg.Name = "lblstokbrg"
        Me.lblstokbrg.Size = New System.Drawing.Size(114, 19)
        Me.lblstokbrg.TabIndex = 83
        Me.lblstokbrg.Text = "STOK BARANG"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(14, 491)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 25)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "DIBAYAR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(13, 543)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 25)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "KEMBALIAN"
        '
        'txtdibyr
        '
        Me.txtdibyr.Location = New System.Drawing.Point(177, 491)
        Me.txtdibyr.Name = "txtdibyr"
        Me.txtdibyr.Size = New System.Drawing.Size(237, 22)
        Me.txtdibyr.TabIndex = 86
        '
        'txtkem
        '
        Me.txtkem.Location = New System.Drawing.Point(177, 543)
        Me.txtkem.Name = "txtkem"
        Me.txtkem.Size = New System.Drawing.Size(237, 22)
        Me.txtkem.TabIndex = 87
        '
        'PrintDocument1
        '
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(14, 392)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 25)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "PPN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(12, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 25)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "DISKON"
        '
        'txtdis
        '
        Me.txtdis.Location = New System.Drawing.Point(177, 346)
        Me.txtdis.Name = "txtdis"
        Me.txtdis.Size = New System.Drawing.Size(237, 22)
        Me.txtdis.TabIndex = 90
        '
        'txtppn
        '
        Me.txtppn.Location = New System.Drawing.Point(177, 392)
        Me.txtppn.Name = "txtppn"
        Me.txtppn.Size = New System.Drawing.Size(237, 22)
        Me.txtppn.TabIndex = 91
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(551, 444)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(760, 25)
        Me.Label15.TabIndex = 189
        Me.Label15.Text = "____________________________________________________________________"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(551, 469)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(291, 29)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "PRINT LAPORAN PEMASOK"
        '
        'btstruk
        '
        Me.btstruk.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btstruk.ForeColor = System.Drawing.Color.Blue
        Me.btstruk.Location = New System.Drawing.Point(1038, 401)
        Me.btstruk.Margin = New System.Windows.Forms.Padding(4)
        Me.btstruk.Name = "btstruk"
        Me.btstruk.Size = New System.Drawing.Size(105, 39)
        Me.btstruk.TabIndex = 187
        Me.btstruk.Text = "STRUK"
        Me.btstruk.UseVisualStyleBackColor = True
        '
        'btcetak
        '
        Me.btcetak.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcetak.ForeColor = System.Drawing.Color.Blue
        Me.btcetak.Location = New System.Drawing.Point(1025, 510)
        Me.btcetak.Margin = New System.Windows.Forms.Padding(4)
        Me.btcetak.Name = "btcetak"
        Me.btcetak.Size = New System.Drawing.Size(143, 64)
        Me.btcetak.TabIndex = 194
        Me.btcetak.Text = "Cetak"
        Me.btcetak.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(550, 543)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 29)
        Me.Label17.TabIndex = 193
        Me.Label17.Text = "Akhir Bulan/Tahun"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(551, 504)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(183, 29)
        Me.Label18.TabIndex = 192
        Me.Label18.Text = "Awal Bulan/Tahun"
        '
        'dtp2
        '
        Me.dtp2.Location = New System.Drawing.Point(750, 548)
        Me.dtp2.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(265, 22)
        Me.dtp2.TabIndex = 191
        '
        'dtp1
        '
        Me.dtp1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtp1.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtp1.Location = New System.Drawing.Point(750, 509)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(265, 22)
        Me.dtp1.TabIndex = 190
        '
        'txtbersih
        '
        Me.txtbersih.AutoSize = True
        Me.txtbersih.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbersih.ForeColor = System.Drawing.Color.Blue
        Me.txtbersih.Location = New System.Drawing.Point(1194, 509)
        Me.txtbersih.Name = "txtbersih"
        Me.txtbersih.Size = New System.Drawing.Size(65, 19)
        Me.txtbersih.TabIndex = 195
        Me.txtbersih.Text = "BERSIH"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(14, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 25)
        Me.Label19.TabIndex = 196
        Me.Label19.Text = "HARGA BELI"
        '
        'txthrbl
        '
        Me.txthrbl.Location = New System.Drawing.Point(177, 176)
        Me.txthrbl.Name = "txthrbl"
        Me.txthrbl.Size = New System.Drawing.Size(237, 22)
        Me.txthrbl.TabIndex = 197
        '
        'FPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 647)
        Me.Controls.Add(Me.txthrbl)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtbersih)
        Me.Controls.Add(Me.btcetak)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btstruk)
        Me.Controls.Add(Me.txtppn)
        Me.Controls.Add(Me.txtdis)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtkem)
        Me.Controls.Add(Me.txtdibyr)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblstokbrg)
        Me.Controls.Add(Me.lblsisabrg)
        Me.Controls.Add(Me.txthrbr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txttot)
        Me.Controls.Add(Me.txtjmlh)
        Me.Controls.Add(Me.txtnmks)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtnmbrg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbbrg)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.txtidjl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPenjualan"
        Me.Text = "FPenjualan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btkeluar As Button
    Friend WithEvents txtfind As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bthapus As Button
    Friend WithEvents btbatal As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents bttambah As Button
    Friend WithEvents txtidjl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbbrg As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnmbrg As TextBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents txtnmks As TextBox
    Friend WithEvents txtjmlh As TextBox
    Friend WithEvents txttot As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txthrbr As TextBox
    Friend WithEvents lblsisabrg As Label
    Friend WithEvents lblstokbrg As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtdibyr As TextBox
    Friend WithEvents txtkem As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtdis As TextBox
    Friend WithEvents txtppn As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btstruk As Button
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents btcetak As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents txtbersih As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txthrbl As TextBox
End Class
