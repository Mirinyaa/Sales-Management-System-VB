Imports System.Drawing.Printing
Public Class FPemasok
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pemasok"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pemasok")
        dgv.DataSource = ds.Tables("pemasok")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "pemasok")
        dgv.DataSource = datas.Tables("pemasok")
        kon.Close()
    End Sub
    Sub idmasok()
        Dim kode, idpemasok As String
        Dim no As Integer
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_pemasok from pemasok order by id_pemasok desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_pemasok")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            idpemasok = "PM" + Format(no, "00000")
            txtidpm.Text = idpemasok
        Else
            txtidpm.Text = "PM" + "00001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Sub idbrg()
        Dim kode, idbarang As String
        Dim no As Integer
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_barang from pemasok order by id_barang desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_barang")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            idbarang = "BR" + Format(no, "00000")
            txtidbrg.Text = idbarang
        Else
            txtidbrg.Text = "BR" + "00001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Sub ambiliddis()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_distributor from distributor"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbdis.Items.Add(cek.Item("id_distributor"))
        End While
        kon.Close()
    End Sub
    Sub bersih()
        cmbdis.Text = ""
        txtnmdis.Text = ""
        txtidpm.Text = ""
        txtnmpm.Text = ""
        txtidbrg.Text = ""
        txtjml.Text = ""
        dtp.Text = ""
    End Sub
    Sub tidakaktif()
        cmbdis.Enabled = False
        txtnmdis.Enabled = False
        txtidpm.Enabled = False
        txtnmpm.Enabled = False
        txtidbrg.Enabled = False
        txtjml.Enabled = False
        dtp.Enabled = False
    End Sub
    Sub aktif1()
        cmbdis.Enabled = True
        txtnmdis.Enabled = True
        txtidpm.Enabled = True
        txtnmpm.Enabled = True
        txtidbrg.Enabled = True
        txtjml.Enabled = True
        dtp.Enabled = True
    End Sub

    Private Sub FPemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambiliddis()
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
        dgv.Font = New Font("Comic Sans MS", 11)
        dgv.Columns(0).HeaderText = "ID DISTRIBUTOR"
        dgv.Columns(1).HeaderText = "NAMA DISTRIBUTOR"
        dgv.Columns(2).HeaderText = "ID PEMASOK"
        dgv.Columns(3).HeaderText = "NAMA PEMASOK"
        dgv.Columns(4).HeaderText = "ID BARANG"
        dgv.Columns(5).HeaderText = "JUMLAH"
        dgv.Columns(6).HeaderText = "TANGGAL"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        aktif1()
        idmasok()
        idbrg()
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
        perintah.CommandText = "delete from pemasok where id_pemasok='" & txtidpm.Text & "'"
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

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If txtidpm.Text = "" Or txtnmpm.Text = "" Or cmbdis.Text = "" Or txtidbrg.Text = "" Or txtjml.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If btsimpan.Text = "SIMPAN" Then
                perintah.CommandText = "insert into pemasok values('" & cmbdis.Text & "','" & txtnmdis.Text & "','" & txtidpm.Text & "','" & txtnmpm.Text & "','" & txtidbrg.Text & "','" & txtjml.Text & "','" & Format(dtp.Value, "yyyy-MM-dd") & "')"
                perintah.ExecuteNonQuery()
            Else
                perintah.CommandText = "UPDATE pemasok SET jumlah='" & txtjml.Text & "',tanggal='" & Format(dtp.Value, "yyyy-MM-dd") & "',nama_distributor ='" & txtnmdis.Text & "',nama_pemasok ='" & txtnmpm.Text & "' WHERE id_pemasok='" & txtidpm.Text & "'"
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

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        bersih()
        btsimpan.Text = "EDIT"
        txtidpm.Enabled = False
        cmbdis.Enabled = False
        txtidpm.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                bttambah.Enabled = False
                cmbdis.Text = .Cells(0).Value
                txtnmdis.Text = .Cells(1).Value
                txtidpm.Text = .Cells(2).Value
                txtnmpm.Text = .Cells(3).Value
                txtidbrg.Text = .Cells(4).Value
                txtjml.Text = .Cells(5).Value
                dtp.Text = .Cells(6).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbdis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdis.SelectedIndexChanged
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from distributor where id_distributor = '" & cmbdis.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()

        If cek.HasRows Then
            cmbdis.Text = cek.Item("id_distributor")
            txtnmdis.Text = cek.Item("nama_distributor")
        End If
        kon.Close()
    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pemasok where id_pemasok like '" & txtfind.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pemasok")
        dgv.DataSource = ds.Tables("pemasok")
        kon.Close()
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        FMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtnmdis_TextChanged(sender As Object, e As EventArgs) Handles txtnmdis.TextChanged

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
        garis = "============================================================================================================================"

        e.Graphics.DrawString("TOWA HOBBY SHOP", f14b, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Konyappi", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Hakata-ku, Fukuoka, Japan", f10, Brushes.Black, centermargin, 40, tengah)
        e.Graphics.DrawString("021-34556632", f10, Brushes.Black, centermargin, 55, tengah)
        e.Graphics.DrawString("www.towahobbyshop.jp", f10, Brushes.Black, centermargin, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 80, tengah)

        e.Graphics.DrawString("ID Distributor", f10b, Brushes.Black, 10, 100)
        e.Graphics.DrawString("Nama Distributor", f10b, Brushes.Black, 120, 100)
        e.Graphics.DrawString("ID Pemasok", f10b, Brushes.Black, 250, 100)
        e.Graphics.DrawString("Nama Pemasok", f10b, Brushes.Black, 380, 100)
        e.Graphics.DrawString("ID Barang", f10b, Brushes.Black, 520, 100)
        e.Graphics.DrawString("Jumlah", f10b, Brushes.Black, 610, 100)
        e.Graphics.DrawString("Tanggal", f10b, Brushes.Black, 710, 100)
        dgv.AllowUserToAddRows = True
        Dim tinggi As New Integer
        Dim i As New Long
        For baris As Integer = 0 To dgv.RowCount - 2
            tinggi += 15

            e.Graphics.DrawString(dgv.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 10, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 120, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 250, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 380, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 520, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 610, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(baris).Cells(6).Value.ToString, f10, Brushes.Black, 710, 100 + tinggi)
        Next
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 900, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class