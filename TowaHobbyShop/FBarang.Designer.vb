<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBarang
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbnmjn = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnmbrg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.txthrbl = New System.Windows.Forms.TextBox()
        Me.txthrjl = New System.Windows.Forms.TextBox()
        Me.cmbbrg = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(23, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 25)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "NAMA JENIS"
        '
        'cmbnmjn
        '
        Me.cmbnmjn.FormattingEnabled = True
        Me.cmbnmjn.Location = New System.Drawing.Point(195, 63)
        Me.cmbnmjn.Name = "cmbnmjn"
        Me.cmbnmjn.Size = New System.Drawing.Size(237, 24)
        Me.cmbnmjn.TabIndex = 93
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(457, 104)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(780, 253)
        Me.dgv.TabIndex = 92
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.ForeColor = System.Drawing.Color.Blue
        Me.btkeluar.Location = New System.Drawing.Point(1121, 17)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(116, 39)
        Me.btkeluar.TabIndex = 86
        Me.btkeluar.Text = "KEMBALI"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(457, 76)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(653, 22)
        Me.txtfind.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(567, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(488, 29)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "CARI BARANG BERDASARKAN NAMA BARANG"
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.Blue
        Me.bthapus.Location = New System.Drawing.Point(346, 365)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(105, 39)
        Me.bthapus.TabIndex = 83
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.ForeColor = System.Drawing.Color.Blue
        Me.btbatal.Location = New System.Drawing.Point(123, 365)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(105, 39)
        Me.btbatal.TabIndex = 82
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.ForeColor = System.Drawing.Color.Blue
        Me.btsimpan.Location = New System.Drawing.Point(234, 365)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(105, 39)
        Me.btsimpan.TabIndex = 81
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambah.ForeColor = System.Drawing.Color.Blue
        Me.bttambah.Location = New System.Drawing.Point(12, 365)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(105, 39)
        Me.bttambah.TabIndex = 80
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(21, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "ID BARANG"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 47)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(439, 310)
        Me.RichTextBox1.TabIndex = 76
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(21, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 39)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Input Data Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(23, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "NAMA BARANG"
        '
        'txtnmbrg
        '
        Me.txtnmbrg.Location = New System.Drawing.Point(195, 151)
        Me.txtnmbrg.Name = "txtnmbrg"
        Me.txtnmbrg.Size = New System.Drawing.Size(237, 22)
        Me.txtnmbrg.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(23, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "STOK"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(23, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 25)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "HARGA BELI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(20, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 25)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "HARGA JUAL"
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(195, 199)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(237, 22)
        Me.txtstok.TabIndex = 105
        '
        'txthrbl
        '
        Me.txthrbl.Location = New System.Drawing.Point(195, 247)
        Me.txthrbl.Name = "txthrbl"
        Me.txthrbl.Size = New System.Drawing.Size(237, 22)
        Me.txthrbl.TabIndex = 106
        '
        'txthrjl
        '
        Me.txthrjl.Location = New System.Drawing.Point(195, 291)
        Me.txthrjl.Name = "txthrjl"
        Me.txthrjl.Size = New System.Drawing.Size(237, 22)
        Me.txthrjl.TabIndex = 107
        '
        'cmbbrg
        '
        Me.cmbbrg.FormattingEnabled = True
        Me.cmbbrg.Location = New System.Drawing.Point(195, 107)
        Me.cmbbrg.Name = "cmbbrg"
        Me.cmbbrg.Size = New System.Drawing.Size(237, 24)
        Me.cmbbrg.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(452, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(815, 25)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "_________________________________________________________________________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(457, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(238, 29)
        Me.Label12.TabIndex = 188
        Me.Label12.Text = "PRINT STOK BARANG"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(767, 364)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 34)
        Me.Button2.TabIndex = 187
        Me.Button2.Text = "Cetak"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 445)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbbrg)
        Me.Controls.Add(Me.txthrjl)
        Me.Controls.Add(Me.txthrbl)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnmbrg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbnmjn)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FBarang"
        Me.Text = "FBarang"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents cmbnmjn As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btkeluar As Button
    Friend WithEvents txtfind As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bthapus As Button
    Friend WithEvents btbatal As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents bttambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnmbrg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtstok As TextBox
    Friend WithEvents txthrbl As TextBox
    Friend WithEvents txthrjl As TextBox
    Friend WithEvents cmbbrg As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
