Public Class FJenisbarang
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from jenis_barang"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "jenis_barang")
        dgv.DataSource = ds.Tables("jenis_barang")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "jenis_barang")
        dgv.DataSource = datas.Tables("jenis_barang")
        kon.Close()
    End Sub
    Sub idjenis()
        Dim kode, kodejenis As String
        Dim no As Integer
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select kode_jenis from jenis_barang order by kode_jenis desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("kode_jenis")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            kodejenis = "JN" + Format(no, "00000")
            txtidjn.Text = kodejenis
        Else
            txtidjn.Text = "JN" + "00001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Sub bersih()
        txtidjn.Text = ""
        txtnmjn.Text = ""
    End Sub
    Sub tidakaktif()
        txtidjn.Enabled = False
        txtnmjn.Enabled = False
    End Sub
    Sub aktif1()
        txtidjn.Enabled = True
        txtnmjn.Enabled = True
    End Sub
    Private Sub FJenisbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        tampildata()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        bthapus.Enabled = False
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 150
        dgv.Font = New Font("Comic Sans MS", 11)
        dgv.Columns(0).HeaderText = "ID JENIS"
        dgv.Columns(1).HeaderText = "NAMA JENIS"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        aktif1()
        idjenis()
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

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If txtidjn.Text = "" Or txtnmjn.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If btsimpan.Text = "SIMPAN" Then
                perintah.CommandText = "insert into jenis_barang values('" & txtidjn.Text & "','" & txtnmjn.Text & "')"
                perintah.ExecuteNonQuery()
            Else
                perintah.CommandText = "UPDATE jenis_barang SET nama_jenis='" & txtnmjn.Text & "'"
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
        txtidjn.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                bttambah.Enabled = False
                txtidjn.Text = .Cells(0).Value
                txtnmjn.Text = .Cells(1).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from jenis_barang where nama_jenis like '" & txtfind.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "jenis_barang")
        dgv.DataSource = ds.Tables("jenis_barang")
        kon.Close()
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        FMenu.Show()
        Me.Close()
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from jenis_barang where kode_jenis='" & txtidjn.Text & "'"
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
End Class