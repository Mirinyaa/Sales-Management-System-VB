Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FBarang
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim total
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "barang")
        dgv.DataSource = ds.Tables("barang")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "barang")
        dgv.DataSource = datas.Tables("barang")
        kon.Close()
    End Sub
    Sub ambilnmjn()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select nama_jenis from jenis_barang"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbnmjn.Items.Add(cek.Item("nama_jenis"))
        End While
        kon.Close()
    End Sub
    Sub ambilidbrg()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_barang from pemasok"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbbrg.Items.Add(cek.Item("id_barang"))
        End While
        kon.Close()
    End Sub
    Sub bersih()
        cmbnmjn.Text = ""
        cmbbrg.Text = ""
        txtnmbrg.Text = ""
        txtstok.Text = ""
        txthrbl.Text = ""
        txthrjl.Text = ""
    End Sub
    Sub tidakaktif()
        cmbnmjn.Enabled = False
        cmbbrg.Enabled = False
        txtnmbrg.Enabled = False
        txtstok.Enabled = False
        txthrbl.Enabled = False
        txthrjl.Enabled = False
    End Sub
    Sub aktif1()
        cmbnmjn.Enabled = True
        cmbbrg.Enabled = True
        txtnmbrg.Enabled = True
        txtstok.Enabled = True
        txthrbl.Enabled = True
        txthrjl.Enabled = True
    End Sub

    Private Sub FBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilidbrg()
        ambilnmjn()
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
        dgv.Font = New Font("Comic Sans MS", 11)
        dgv.Columns(0).HeaderText = "NAMA JENIS"
        dgv.Columns(1).HeaderText = "ID BARANG"
        dgv.Columns(2).HeaderText = "NAMA BARANG"
        dgv.Columns(3).HeaderText = "STOK"
        dgv.Columns(4).HeaderText = "HARGA BELI"
        dgv.Columns(5).HeaderText = "HARGA JUAL"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        aktif1()
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
        perintah.CommandText = "delete from barang where nama_barang='" & txtnmbrg.Text & "'"
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
        cmbbrg.Enabled = False
        cmbnmjn.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                bttambah.Enabled = False
                cmbnmjn.Text = .Cells(0).Value
                cmbbrg.Text = .Cells(1).Value
                txtnmbrg.Text = .Cells(2).Value
                txtstok.Text = .Cells(3).Value
                txthrbl.Text = .Cells(4).Value
                txthrjl.Text = .Cells(5).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbjn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnmjn.SelectedIndexChanged
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from jenis_barang where nama_jenis = '" & cmbnmjn.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()

        If cek.HasRows Then
            cmbnmjn.Text = cek.Item("nama_jenis")
        End If
        kon.Close()
    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang where nama_barang like '" & txtfind.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "barang")
        dgv.DataSource = ds.Tables("barang")
        kon.Close()
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        FMenu.Show()
        Me.Close()
    End Sub

    Private Sub cmbbrg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbrg.SelectedIndexChanged
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pemasok where id_barang = '" & cmbbrg.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()

        If cek.HasRows Then
            cmbbrg.Text = cek.Item("id_barang")
        End If
        kon.Close()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If cmbnmjn.Text = "" Or cmbbrg.Text = "" Or txtnmbrg.Text = "" Or txtstok.Text = "" Or txthrbl.Text = "" Or txthrjl.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If btsimpan.Text = "SIMPAN" Then
                perintah.CommandText = "insert into barang values('" & cmbnmjn.Text & "','" & cmbbrg.Text & "','" & txtnmbrg.Text & "','" & txtstok.Text & "','" & txthrbl.Text & "','" & txthrjl.Text & "')"
                perintah.ExecuteNonQuery()
            Else
                perintah.CommandText = "UPDATE barang SET stok ='" & txtstok.Text & "',harga_beli ='" & txthrbl.Text & "',harga_jual ='" & txthrjl.Text & "' WHERE id_pemasok='" & cmbbrg.Text & "'"
                perintah.ExecuteNonQuery()
            End If
            kon.Close()
            tampildata()
            MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
            bersih()
            tidakaktif()
            bttambah.Enabled = True
            bthapus.Enabled = False
        End If
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD.PrintPage
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
        garis = "============================================================================================================================"
        e.Graphics.DrawString("TOWA HOBBY SHOP", f14b, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Konyappi", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Hakata-ku, Fukuoka, Japan", f10, Brushes.Black, centermargin, 40, tengah)
        e.Graphics.DrawString("021-34556632", f10, Brushes.Black, centermargin, 55, tengah)
        e.Graphics.DrawString("www.towahobbyshop.jp", f10, Brushes.Black, centermargin, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 80, tengah)

        e.Graphics.DrawString("Nama Jenis", f10b, Brushes.Black, 10, 100)
        e.Graphics.DrawString("ID Barang", f10b, Brushes.Black, 120, 100)
        e.Graphics.DrawString("Nama Barang", f10b, Brushes.Black, 220, 100)
        e.Graphics.DrawString("Stok", f10b, Brushes.Black, 350, 100)
        e.Graphics.DrawString("Harga Beli", f10b, Brushes.Black, 420, 100)
        e.Graphics.DrawString("Harga Jual", f10b, Brushes.Black, 520, 100)

        dgv.AllowUserToAddRows = True
        Dim tinggi As New Integer
        Dim i As New Long
        For baris As Integer = 0 To dgv.RowCount - 2
            tinggi += 15

            e.Graphics.DrawString(dgv.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 10, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 120, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 220, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 350, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 420, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 520, 100 + tinggi)
        Next
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 650, 400)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
End Class