Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class FPenjualan
    Dim sisabrg, jmlhrg, dis, totbay, ppn, kembali As Double
    Dim WithEvents PD, DP As New PrintDocument
    Dim PPD, DDD As New PrintPreviewDialog
    Dim dibayarr, sisaa, clean, hrgbrg, total, totjual
    Sub dbyr()
        Dim hitung As Long = 0
        For baris As Long = 0 To dgv.RowCount - 1
            hitung = hitung + dgv.Rows(baris).Cells(13).Value
        Next
        dibayarr = hitung
    End Sub
    Sub sis()
        Dim hitung As Long = 0
        For baris As Long = 0 To dgv.RowCount - 1
            hitung = hitung + dgv.Rows(baris).Cells(7).Value
        Next
        sisaa = hitung
    End Sub
    Sub totharga()
        Dim hitung As Long = 0
        For baris As Long = 0 To dgv.RowCount - 1
            hitung = hitung + dgv.Rows(baris).Cells(9).Value
        Next
        total = hitung
    End Sub
    Sub totpenjualan()
        Dim hitung As Long = 0
        For baris As Long = 0 To dgv.RowCount - 1
            hitung = hitung + dgv.Rows(baris).Cells(13).Value
        Next
        totjual = hitung
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from penjualan"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "penjualan")
        dgv.DataSource = ds.Tables("penjualan")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "penjualan")
        dgv.DataSource = datas.Tables("penjualan")
        kon.Close()
    End Sub
    Sub idjual()
        Dim kode, idpenjualan As String
        Dim no As Integer
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_penjualan from penjualan order by id_penjualan desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_penjualan")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            idpenjualan = "PM" + Format(no, "00000")
            txtidjl.Text = idpenjualan
        Else
            txtidjl.Text = "JL" + "00001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Sub ambilidbrg()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_barang from barang"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbbrg.Items.Add(cek.Item("id_barang"))
        End While
        kon.Close()
    End Sub
    Sub bersih()
        txtidjl.Text = ""
        cmbbrg.Text = ""
        txtnmbrg.Text = ""
        txthrbl.Text = ""
        txthrbr.Text = ""
        txtjmlh.Text = ""
        txttot.Text = ""
        txtdis.Text = ""
        txtppn.Text = ""
        txtdibyr.Text = ""
        txtkem.Text = ""
        dtp.Text = ""
        txtbersih.Text = ""
        lblsisabrg.Text = ""
        lblstokbrg.Text = ""
        txtbersih.Text = ""
    End Sub
    Sub tidakaktif()
        txtidjl.Enabled = False
        cmbbrg.Enabled = False
        txtnmbrg.Enabled = False
        txthrbl.Enabled = False
        txtnmks.Enabled = False
        txthrbr.Enabled = False
        txtjmlh.Enabled = False
        txttot.Enabled = False
        txtdis.Enabled = False
        txtppn.Enabled = False
        txtdibyr.Enabled = False
        txtkem.Enabled = False
        dtp.Enabled = False
    End Sub
    Sub aktif1()
        txtidjl.Enabled = True
        cmbbrg.Enabled = True
        txtnmbrg.Enabled = False
        txthrbl.Enabled = False
        txtnmks.Enabled = False
        txthrbr.Enabled = False
        txtjmlh.Enabled = True
        txttot.Enabled = False
        txtdis.Enabled = True
        txtppn.Enabled = True
        txtdibyr.Enabled = True
        txtkem.Enabled = True
        dtp.Enabled = True
        txtbersih.Enabled = True
    End Sub

    Private Sub FPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilidbrg()
        tidakaktif()
        tampildata()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        bthapus.Enabled = False
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 150
        dgv.Columns(2).Width = 150
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 150
        dgv.Columns(5).Width = 150
        dgv.Columns(6).Width = 150
        dgv.Columns(7).Width = 150
        dgv.Columns(8).Width = 150
        dgv.Columns(9).Width = 150
        dgv.Columns(10).Width = 150
        dgv.Columns(11).Width = 150
        dgv.Columns(12).Width = 150
        dgv.Columns(13).Width = 150
        dgv.Font = New Font("Comic Sans MS", 11)
        dgv.Columns(0).HeaderText = "ID PENJUALAN"
        dgv.Columns(1).HeaderText = "ID BARANG"
        dgv.Columns(2).HeaderText = "NAMA BARANG"
        dgv.Columns(3).HeaderText = "HARGA BELI"
        dgv.Columns(4).HeaderText = "NAMA KASIR"
        dgv.Columns(5).HeaderText = "HARGA BARANG"
        dgv.Columns(6).HeaderText = "JUMLAH"
        dgv.Columns(7).HeaderText = "DISKON"
        dgv.Columns(8).HeaderText = "PPN"
        dgv.Columns(9).HeaderText = "TOTAL"
        dgv.Columns(10).HeaderText = "DIBAYAR"
        dgv.Columns(11).HeaderText = "KEMBALIAN"
        dgv.Columns(12).HeaderText = "TANGGAL"
        dgv.Columns(13).HeaderText = "BERSIH"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        aktif1()
        idjual()
        bttambah.Enabled = False
        btsimpan.Enabled = True
        bthapus.Enabled = True
        btsimpan.Text = "SIMPAN"
    End Sub

    Private Sub btbatal_Click(sender As Object, e As EventArgs) Handles btbatal.Click
        bersih()
        tidakaktif()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        bthapus.Enabled = False
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from penjualan where id_penjualan='" & txtidjl.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
        bersih()
        tidakaktif()
        bttambah.Enabled = True
        btsimpan.Enabled = True
        bthapus.Enabled = True
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        bersih()
        btsimpan.Text = "EDIT"
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                bttambah.Enabled = False
                txtidjl.Text = .Cells(0).Value
                cmbbrg.Text = .Cells(1).Value
                txtnmbrg.Text = .Cells(2).Value
                txthrbl.Text = .Cells(3).Value
                txtnmks.Text = .Cells(4).Value
                txthrbr.Text = .Cells(5).Value
                txtjmlh.Text = .Cells(6).Value
                txtdis.Text = .Cells(7).Value
                txtppn.Text = .Cells(8).Value
                txttot.Text = .Cells(9).Value
                txtdibyr.Text = .Cells(10).Value
                txtkem.Text = .Cells(11).Value
                dtp.Text = .Cells(12).Value
                txtbersih.Text = .Cells(13).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbbrg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbrg.SelectedIndexChanged
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang where id_barang = '" & cmbbrg.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()

        If cek.HasRows Then
            cmbbrg.Text = cek.Item("id_barang")
            txtnmbrg.Text = cek.Item("nama_barang")
            txthrbl.Text = cek.Item("harga_beli")
            txthrbr.Text = cek.Item("harga_jual")
            lblstokbrg.Text = cek.Item("stok")
        End If
        kon.Close()
    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from penjualan where id_penjualan like '" & txtfind.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "penjualan")
        dgv.DataSource = ds.Tables("penjualan")
        kon.Close()
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE barang SET stok='" & sisabrg & "' WHERE id_barang='" & cmbbrg.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        FBarang.tampildata()

        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into penjualan values ('" & txtidjl.Text & "','" & cmbbrg.Text & "','" & txtnmbrg.Text & "','" & txthrbl.Text & "','" & txtnmks.Text & "','" & txthrbr.Text & "','" & txtjmlh.Text & "','" & txtdis.Text & "','" & txtppn.Text & "','" & txttot.Text & "','" & txtdibyr.Text & "','" & txtkem.Text & "','" & Format(dtp.Value, "yyyy-MM-dd") & "','" & txtbersih.Text & "')"
        PPD.Document = PD
        PPD.ShowDialog()
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
        bersih()
        tidakaktif()
        bttambah.Enabled = True
        bthapus.Enabled = False
    End Sub

    Private Sub txttot_TextChanged(sender As Object, e As EventArgs) Handles txttot.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblsisabrg.Click

    End Sub

    Private Sub lblstokbrg_Click(sender As Object, e As EventArgs) Handles lblstokbrg.Click

    End Sub

    Private Sub txtnmks_TextChanged(sender As Object, e As EventArgs) Handles txtnmks.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub txtkem_TextChanged(sender As Object, e As EventArgs) Handles txtkem.TextChanged

    End Sub

    Private Sub txtdis_TextChanged(sender As Object, e As EventArgs) Handles txtdis.TextChanged
        dis = Val(txthrbr.Text) * Val(txtdis.Text) / 100
        totbay = jmlhrg - dis
        txttot.Text = Format(totbay, "#########")
        txtbersih.Text = clean
    End Sub

    Private Sub txthrbr_TextChanged(sender As Object, e As EventArgs) Handles txthrbr.TextChanged

    End Sub

    Private Sub btcetak_Click(sender As Object, e As EventArgs) Handles btcetak.Click
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from penjualan where tanggal between'" & Format(dtp1.Value, "yyyy-MM-dd") & "' and '" & Format(dtp2.Value, "yyyy-MM-dd") & "'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "penjualan")
        dgv.DataSource = ds.Tables("penjualan")
        perintah.CommandText = "select * from penjualan where tanggal between'" & Format(dtp1.Value, "yyyy-MM-dd") & "' and '" & Format(dtp2.Value, "yyyy-MM-dd") & "'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "penjualan")
        dgv.DataSource = ds.Tables("penjualan")
        kon.Close()
        DDD.Document = DP
        DDD.ShowDialog()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtbersih_Click(sender As Object, e As EventArgs) Handles txtbersih.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btstruk.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub DP_PrintPage(sender As Object, e As PrintPageEventArgs) Handles DP.PrintPage
        Dim f10 As New Font("Comic Sans MS", 10, FontStyle.Regular)
        Dim f10b As New Font("Comic Sans MS", 10, FontStyle.Bold)
        Dim f14b As New Font("Comic Sans MS", 14, FontStyle.Bold)
        Dim f8 As New Font("Comic Sans MS", 8, FontStyle.Regular)

        Dim leftmargin As Integer = DP.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = DP.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = DP.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "================================================================================================================================================================================"
        totpenjualan()

        e.Graphics.DrawString("TOWA HOBBY SHOP", f14b, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Konyappi", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Hakata-ku, Fukuoka, Japan", f10, Brushes.Black, centermargin, 40, tengah)
        e.Graphics.DrawString("021-34556632", f10, Brushes.Black, centermargin, 55, tengah)
        e.Graphics.DrawString("www.towamart.jp", f10, Brushes.Black, centermargin, 70, tengah)
        e.Graphics.DrawString("Laporan Penjualan", f14b, Brushes.Black, centermargin, 85, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 105, tengah)

        e.Graphics.DrawString(Format(dtp1.Value, "dd MMMM yyyy"), f10b, Brushes.Black, 10, 95)
        e.Graphics.DrawString("-", f10b, Brushes.Black, 130, 95)
        e.Graphics.DrawString(Format(dtp2.Value, "dd MMMM yyyy"), f10b, Brushes.Black, 150, 95)

        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 115, tengah)

        e.Graphics.DrawString("ID Penjualan", f10b, Brushes.Black, 10, 125)
        e.Graphics.DrawString("ID Barang", f10b, Brushes.Black, 130, 125)
        e.Graphics.DrawString("Nama Barang", f10b, Brushes.Black, 230, 125)
        e.Graphics.DrawString("Nama Kasir", f10b, Brushes.Black, 350, 125)
        e.Graphics.DrawString("Harga Barang", f10b, Brushes.Black, 460, 125)
        e.Graphics.DrawString("Jumlah", f10b, Brushes.Black, 580, 125)
        e.Graphics.DrawString("Diskon", f10b, Brushes.Black, 650, 125)
        e.Graphics.DrawString("PPN", f10b, Brushes.Black, 720, 125)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, 770, 125)
        e.Graphics.DrawString("Dibayar", f10b, Brushes.Black, 840, 125)
        e.Graphics.DrawString("Kembalian", f10b, Brushes.Black, 920, 125)

        'e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 500, tengah)

        'e.Graphics.DrawString("Total Penjualan : ", f10, Brushes.Black, 750, 520)
        'e.Graphics.DrawString(Format(totjual, "Rp"), f10, Brushes.Black, 870, 520)

        dgv.AllowUserToAddRows = False
        Dim tinggi As New Integer
        Dim i As New Long
        For baris As Integer = 0 To dgv.RowCount - 1
            tinggi += 15

            e.Graphics.DrawString(dgv.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 10, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 130, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 230, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 350, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 460, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(6).Value.ToString, f10, Brushes.Black, 580, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(7).Value.ToString, f10, Brushes.Black, 650, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(8).Value.ToString, f10, Brushes.Black, 720, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(9).Value.ToString, f10, Brushes.Black, 770, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(10).Value.ToString, f10, Brushes.Black, 840, 130 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(11).Value.ToString, f10, Brushes.Black, 920, 130 + tinggi)
        Next

    End Sub

    Private Sub txtppn_TextChanged(sender As Object, e As EventArgs) Handles txtppn.TextChanged
        ppn = Val(txthrbr.Text) * Val(txtppn.Text) / 100
        totbay = jmlhrg + ppn - dis
        txttot.Text = Format(totbay, "#########")
        txtbersih.Text = totbay
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Comic Sans MS", 10, FontStyle.Regular)
        Dim f10b As New Font("Comic Sans MS", 10, FontStyle.Bold)
        Dim f14b As New Font("Comic Sans MS", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "================================================================================================================="

        sis()
        dbyr()
        e.Graphics.DrawString("Towa Hobby Shop", f14b, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Konyappi", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Hataku-ku, Fukuoka, Japan", f10, Brushes.Black, centermargin, 40, tengah)
        e.Graphics.DrawString("021-34556632", f10, Brushes.Black, centermargin, 60, tengah)
        e.Graphics.DrawString("www.towahobbyshop.jp", f10, Brushes.Black, centermargin, 75, tengah)
        e.Graphics.DrawString("Kasir", f10b, Brushes.Black, 10, 100)
        e.Graphics.DrawString(txtnmks.Text, f10, Brushes.Black, 100, 100)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 120, tengah)
        e.Graphics.DrawString("No Struk", f10b, Brushes.Black, 10, 140)
        e.Graphics.DrawString(dtp.Value, f10, Brushes.Black, 10, 160)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 180, tengah)

        e.Graphics.DrawString("Nama Barang", f10b, Brushes.Black, 10, 200)
        e.Graphics.DrawString("Harga Barang", f10b, Brushes.Black, 10, 220)
        e.Graphics.DrawString("Jumlah", f10b, Brushes.Black, 10, 240)
        e.Graphics.DrawString("Diskon", f10b, Brushes.Black, 10, 260)
        e.Graphics.DrawString("PPN", f10b, Brushes.Black, 10, 280)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, 10, 300)
        e.Graphics.DrawString("Dibayar", f10b, Brushes.Black, 10, 320)
        e.Graphics.DrawString("Kembalian", f10b, Brushes.Black, 10, 340)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 360, tengah)
        e.Graphics.DrawString("ありがとう", f10b, Brushes.Black, centermargin, 380, tengah)
        e.Graphics.DrawString("また来てください！", f10b, Brushes.Black, centermargin, 400, tengah)

        Dim tinggi As New Integer
        Dim i As New Long

        e.Graphics.DrawString(txtidjl.Text, f10, Brushes.Black, 200, 140 + tinggi)
        e.Graphics.DrawString(txtnmbrg.Text, f10, Brushes.Black, 200, 200 + tinggi)
        e.Graphics.DrawString(txthrbr.Text, f10, Brushes.Black, 200, 220 + tinggi)
        e.Graphics.DrawString(txtjmlh.Text, f10, Brushes.Black, 200, 240 + tinggi)
        e.Graphics.DrawString(txtdis.Text, f10, Brushes.Black, 200, 260 + tinggi)
        e.Graphics.DrawString(txtppn.Text, f10, Brushes.Black, 200, 280 + tinggi)
        e.Graphics.DrawString(txttot.Text, f10, Brushes.Black, 200, 300 + tinggi)
        e.Graphics.DrawString(txtdibyr.Text, f10, Brushes.Black, 200, 320 + tinggi)
        e.Graphics.DrawString(txtkem.Text, f10, Brushes.Black, 200, 340 + tinggi)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub txtdibyr_TextChanged(sender As Object, e As EventArgs) Handles txtdibyr.TextChanged
        kembali = Val(txtdibyr.Text) - totbay
        txtkem.Text = kembali
    End Sub

    Private Sub txtjmlh_TextChanged(sender As Object, e As EventArgs) Handles txtjmlh.TextChanged
        sisabrg = Val(lblstokbrg.Text) - Val(txtjmlh.Text)
        lblsisabrg.Text = sisabrg

        jmlhrg = Val(txtjmlh.Text) * Val(txthrbr.Text)
        txttot.Text = jmlhrg
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub DP_BeginPrint(sender As Object, e As PrintEventArgs) Handles DP.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 1000, 600)
        DP.DefaultPageSettings = pagesetup
    End Sub
End Class