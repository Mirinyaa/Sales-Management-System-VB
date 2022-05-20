<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPengguna
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
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.txtalus = New System.Windows.Forms.TextBox()
        Me.txtnmus = New System.Windows.Forms.TextBox()
        Me.txtidus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttpus = New System.Windows.Forms.TextBox()
        Me.cmbst = New System.Windows.Forms.ComboBox()
        Me.txtusnm = New System.Windows.Forms.TextBox()
        Me.txtpwus = New System.Windows.Forms.TextBox()
        Me.cmbak = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.ForeColor = System.Drawing.Color.Blue
        Me.btkeluar.Location = New System.Drawing.Point(1191, 52)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(116, 39)
        Me.btkeluar.TabIndex = 34
        Me.btkeluar.Text = "KEMBALI"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(554, 65)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(590, 22)
        Me.txtfind.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(549, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(420, 29)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "CARI PENGGUNA BERDASARKAN NAMA"
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.Blue
        Me.bthapus.Location = New System.Drawing.Point(378, 383)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(105, 39)
        Me.bthapus.TabIndex = 31
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.ForeColor = System.Drawing.Color.Blue
        Me.btbatal.Location = New System.Drawing.Point(137, 383)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(105, 39)
        Me.btbatal.TabIndex = 30
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.ForeColor = System.Drawing.Color.Blue
        Me.btsimpan.Location = New System.Drawing.Point(258, 383)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(105, 39)
        Me.btsimpan.TabIndex = 29
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambah.ForeColor = System.Drawing.Color.Blue
        Me.bttambah.Location = New System.Drawing.Point(12, 383)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(105, 39)
        Me.bttambah.TabIndex = 28
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'txtalus
        '
        Me.txtalus.Location = New System.Drawing.Point(178, 133)
        Me.txtalus.Name = "txtalus"
        Me.txtalus.Size = New System.Drawing.Size(237, 22)
        Me.txtalus.TabIndex = 27
        '
        'txtnmus
        '
        Me.txtnmus.Location = New System.Drawing.Point(178, 96)
        Me.txtnmus.Name = "txtnmus"
        Me.txtnmus.Size = New System.Drawing.Size(237, 22)
        Me.txtnmus.TabIndex = 26
        '
        'txtidus
        '
        Me.txtidus.Location = New System.Drawing.Point(178, 62)
        Me.txtidus.Name = "txtidus"
        Me.txtidus.Size = New System.Drawing.Size(237, 22)
        Me.txtidus.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ID USER"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 46)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(466, 319)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 39)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Input Data Pengguna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(14, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "NAMA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ALAMAT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(14, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "TELEPON"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(14, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "STATUS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(14, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 25)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "USERNAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(14, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 25)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "PASSWORD"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(14, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 25)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "AKSES"
        '
        'txttpus
        '
        Me.txttpus.Location = New System.Drawing.Point(178, 172)
        Me.txttpus.Name = "txttpus"
        Me.txttpus.Size = New System.Drawing.Size(237, 22)
        Me.txttpus.TabIndex = 44
        '
        'cmbst
        '
        Me.cmbst.FormattingEnabled = True
        Me.cmbst.Items.AddRange(New Object() {"Atasan", "Kasir", "Gudang"})
        Me.cmbst.Location = New System.Drawing.Point(178, 210)
        Me.cmbst.Name = "cmbst"
        Me.cmbst.Size = New System.Drawing.Size(237, 24)
        Me.cmbst.TabIndex = 45
        '
        'txtusnm
        '
        Me.txtusnm.Location = New System.Drawing.Point(178, 249)
        Me.txtusnm.Name = "txtusnm"
        Me.txtusnm.Size = New System.Drawing.Size(237, 22)
        Me.txtusnm.TabIndex = 46
        '
        'txtpwus
        '
        Me.txtpwus.Location = New System.Drawing.Point(178, 287)
        Me.txtpwus.Name = "txtpwus"
        Me.txtpwus.Size = New System.Drawing.Size(237, 22)
        Me.txtpwus.TabIndex = 47
        '
        'cmbak
        '
        Me.cmbak.FormattingEnabled = True
        Me.cmbak.Items.AddRange(New Object() {"3", "2", "1"})
        Me.cmbak.Location = New System.Drawing.Point(178, 322)
        Me.cmbak.Name = "cmbak"
        Me.cmbak.Size = New System.Drawing.Size(237, 24)
        Me.cmbak.TabIndex = 48
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(554, 107)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(753, 258)
        Me.dgv.TabIndex = 50
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(433, 62)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(24, 22)
        Me.dtp.TabIndex = 51
        Me.dtp.Visible = False
        '
        'FPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 531)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cmbak)
        Me.Controls.Add(Me.txtpwus)
        Me.Controls.Add(Me.txtusnm)
        Me.Controls.Add(Me.cmbst)
        Me.Controls.Add(Me.txttpus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
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
        Me.Controls.Add(Me.txtalus)
        Me.Controls.Add(Me.txtnmus)
        Me.Controls.Add(Me.txtidus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPengguna"
        Me.Text = "FPengguna"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btkeluar As Button
    Friend WithEvents txtfind As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bthapus As Button
    Friend WithEvents btbatal As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents bttambah As Button
    Friend WithEvents txtalus As TextBox
    Friend WithEvents txtnmus As TextBox
    Friend WithEvents txtidus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txttpus As TextBox
    Friend WithEvents cmbst As ComboBox
    Friend WithEvents txtusnm As TextBox
    Friend WithEvents txtpwus As TextBox
    Friend WithEvents cmbak As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dtp As DateTimePicker
End Class
