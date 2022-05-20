<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPemasok
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtjml = New System.Windows.Forms.TextBox()
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
        Me.txtidbrg = New System.Windows.Forms.TextBox()
        Me.txtidpm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.cmbdis = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnmdis = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnmpm = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(563, 93)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(538, 214)
        Me.dgv.TabIndex = 70
        '
        'txtjml
        '
        Me.txtjml.Location = New System.Drawing.Point(265, 273)
        Me.txtjml.Name = "txtjml"
        Me.txtjml.Size = New System.Drawing.Size(237, 22)
        Me.txtjml.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(14, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 25)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "TANGGAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(14, 273)
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
        Me.Label4.Location = New System.Drawing.Point(14, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "ID BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "ID DISTRIBUTOR"
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.ForeColor = System.Drawing.Color.Blue
        Me.btkeluar.Location = New System.Drawing.Point(1073, 16)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(116, 39)
        Me.btkeluar.TabIndex = 63
        Me.btkeluar.Text = "KEMBALI"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(563, 62)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(538, 22)
        Me.txtfind.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(558, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(473, 29)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "CARI PEMASOK BERDASARKAN ID PEMASOK"
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.Blue
        Me.bthapus.Location = New System.Drawing.Point(345, 387)
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
        Me.btbatal.Location = New System.Drawing.Point(123, 387)
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
        Me.btsimpan.Location = New System.Drawing.Point(234, 387)
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
        Me.bttambah.Location = New System.Drawing.Point(12, 387)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(105, 39)
        Me.bttambah.TabIndex = 57
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'txtidbrg
        '
        Me.txtidbrg.Location = New System.Drawing.Point(265, 225)
        Me.txtidbrg.Name = "txtidbrg"
        Me.txtidbrg.Size = New System.Drawing.Size(237, 22)
        Me.txtidbrg.TabIndex = 56
        '
        'txtidpm
        '
        Me.txtidpm.Location = New System.Drawing.Point(265, 139)
        Me.txtidpm.Name = "txtidpm"
        Me.txtidpm.Size = New System.Drawing.Size(237, 22)
        Me.txtidpm.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(14, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 25)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "NAMA PEMASOK"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 46)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(549, 318)
        Me.RichTextBox1.TabIndex = 52
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 39)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Input Data Pemasok"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(265, 322)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(237, 22)
        Me.dtp.TabIndex = 71
        '
        'cmbdis
        '
        Me.cmbdis.FormattingEnabled = True
        Me.cmbdis.Location = New System.Drawing.Point(265, 65)
        Me.cmbdis.Name = "cmbdis"
        Me.cmbdis.Size = New System.Drawing.Size(237, 24)
        Me.cmbdis.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(12, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 25)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "NAMA DISTRIBUTOR"
        '
        'txtnmdis
        '
        Me.txtnmdis.Location = New System.Drawing.Point(265, 106)
        Me.txtnmdis.Name = "txtnmdis"
        Me.txtnmdis.Size = New System.Drawing.Size(237, 22)
        Me.txtnmdis.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(14, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 25)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "ID PEMASOK"
        '
        'txtnmpm
        '
        Me.txtnmpm.Location = New System.Drawing.Point(265, 181)
        Me.txtnmpm.Name = "txtnmpm"
        Me.txtnmpm.Size = New System.Drawing.Size(237, 22)
        Me.txtnmpm.TabIndex = 76
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(875, 322)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 34)
        Me.Button2.TabIndex = 183
        Me.Button2.Text = "Cetak"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(558, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 29)
        Me.Label10.TabIndex = 185
        Me.Label10.Text = "PRINT LAPORAN PEMASOK"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(558, 351)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(551, 25)
        Me.Label11.TabIndex = 186
        Me.Label11.Text = "_________________________________________________"
        '
        'FPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 433)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtnmpm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnmdis)
        Me.Controls.Add(Me.cmbdis)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtjml)
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
        Me.Controls.Add(Me.txtidbrg)
        Me.Controls.Add(Me.txtidpm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPemasok"
        Me.Text = "FPemasok"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtjml As TextBox
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
    Friend WithEvents txtidbrg As TextBox
    Friend WithEvents txtidpm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents cmbdis As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnmdis As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnmpm As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
