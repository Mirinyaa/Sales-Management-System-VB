Public Class FDistributor
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from distributor"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "distributor")
        dgv.DataSource = ds.Tables("distributor")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "distributor")
        dgv.DataSource = datas.Tables("distributor")
        kon.Close()
    End Sub
    Sub iddis()
        Dim kode, iddis As String
        Dim no As Integer
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_distributor from distributor order by id_distributor desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_distributor")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            iddis = "DS" + Format(no, "00000")
            txtiddis.Text = iddis
        Else
            txtiddis.Text = "DS" + "00001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Sub bersih()
        txtiddis.Text = ""
        txtnmdis.Text = ""
    End Sub
    Sub tidakaktif()
        txtiddis.Enabled = False
        txtnmdis.Enabled = False
    End Sub
    Sub aktif1()
        txtiddis.Enabled = True
        txtnmdis.Enabled = True
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub txtidus_TextChanged(sender As Object, e As EventArgs) Handles txtiddis.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtnmus_TextChanged(sender As Object, e As EventArgs) Handles txtnmdis.TextChanged

    End Sub

    Private Sub FDistributor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        tampildata()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        bthapus.Enabled = False
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 150
        dgv.Font = New Font("Comic Sans MS", 11)
        dgv.Columns(0).HeaderText = "ID DISTRIBUTOR"
        dgv.Columns(1).HeaderText = "NAMA DISTRIBUTOR"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
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
        perintah.CommandText = "delete from distributor where id_distributor='" & txtiddis.Text & "'"
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

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        aktif1()
        iddis()
        bttambah.Enabled = False
        btsimpan.Enabled = True
        bthapus.Enabled = True
        btsimpan.Text = "SIMPAN"
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        bersih()
        btsimpan.Text = "EDIT"
        txtiddis.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                bttambah.Enabled = False
                txtiddis.Text = .Cells(0).Value
                txtnmdis.Text = .Cells(1).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from distributor where id_distributor like '" & txtfind.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "distributor")
        dgv.DataSource = ds.Tables("distributor")
        kon.Close()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If txtiddis.Text = "" Or txtnmdis.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If btsimpan.Text = "SIMPAN" Then
                perintah.CommandText = "insert into distributor values ('" & txtiddis.Text & "','" & txtnmdis.Text & "')"
                perintah.ExecuteNonQuery()
            Else
                perintah.CommandText = "UPDATE distributor SET id_distributor='" & txtnmdis.Text & "' WHERE id_distributor='" & txtiddis.Text & "'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FMenu.Show()
        Me.Close()
    End Sub
End Class