Public Class FPengguna
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from user"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "user")
        dgv.DataSource = ds.Tables("user")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "user")
        dgv.DataSource = datas.Tables("user")
        kon.Close()
    End Sub
    Sub iduser()
        Dim kode, iduser As String
        Dim no As Integer
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_user from user order by id_user desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_user")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            iduser = "US" + Format(no, "00000")
            txtidus.Text = iduser
        Else
            txtidus.Text = "US" + "00001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Sub bersih()
        txtidus.Text = ""
        txtnmus.Text = ""
        txtalus.Text = ""
        txttpus.Text = ""
        cmbst.Text = ""
        txtusnm.Text = ""
        txtpwus.Text = ""
        cmbak.Text = ""
    End Sub
    Sub tidakaktif()
        txtidus.Enabled = False
        txtnmus.Enabled = False
        txtalus.Enabled = False
        txttpus.Enabled = False
        cmbst.Enabled = False
        txtusnm.Enabled = False
        txtpwus.Enabled = False
        cmbak.Enabled = False
    End Sub
    Sub aktif1()
        txtidus.Enabled = True
        txtnmus.Enabled = True
        txtalus.Enabled = True
        txttpus.Enabled = True
        cmbst.Enabled = True
        txtusnm.Enabled = True
        txtpwus.Enabled = True
        cmbak.Enabled = True
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        aktif1()
        iduser()
        bttambah.Enabled = False
        btsimpan.Enabled = True
        bthapus.Enabled = True
        btsimpan.Text = "SIMPAN"
    End Sub

    Private Sub FPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dgv.Font = New Font("Comic Sans MS", 11)
        dgv.Columns(0).HeaderText = "ID USER"
        dgv.Columns(1).HeaderText = "NAMA"
        dgv.Columns(2).HeaderText = "ALAMAT"
        dgv.Columns(3).HeaderText = "TELEPHONE"
        dgv.Columns(4).HeaderText = "STATUS"
        dgv.Columns(5).HeaderText = "USERNAME"
        dgv.Columns(4).HeaderText = "PASSWORD"
        dgv.Columns(5).HeaderText = "AKSES"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        bersih()
        btsimpan.Text = "EDIT"
        txtidus.Enabled = False
        cmbak.Enabled = False
        cmbst.Enabled = False
        txtpwus.Text = ""
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                bttambah.Enabled = False
                txtidus.Text = .Cells(0).Value
                txtnmus.Text = .Cells(1).Value
                txtalus.Text = .Cells(2).Value
                txttpus.Text = .Cells(3).Value
                cmbst.Text = .Cells(4).Value
                txtusnm.Text = .Cells(5).Value
                txtpwus.Text = .Cells(6).Value
                cmbak.Text = .Cells(7).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btbatal_Click(sender As Object, e As EventArgs) Handles btbatal.Click
        bersih()
        tidakaktif()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        bthapus.Enabled = False
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If txtidus.Text = "" Or txtnmus.Text = "" Or txtalus.Text = "" Or txttpus.Text = "" Or txtusnm.Text = "" Or txtpwus.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If btsimpan.Text = "SIMPAN" Then
                perintah.CommandText = "insert into user values ('" & txtidus.Text & "','" & txtnmus.Text & "','" & txtalus.Text & "','" & txttpus.Text & "','" & cmbst.Text & "','" & txtusnm.Text & "',MD5('" & txtpwus.Text & "'),'" & cmbak.Text & "')"
                perintah.ExecuteNonQuery()
            Else
                perintah.CommandText = "UPDATE user SET nama='" & txtnmus.Text & "',alamat='" & txtalus.Text & "',telepon='" & txttpus.Text & "',status='" & cmbst.Text & "',username='" & txtusnm.Text & "',password= md5 ('" & txtpwus.Text & "'),akses='" & cmbak.Text & "' WHERE id_user='" & txtidus.Text & "'"
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

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from user where id_user='" & txtidus.Text & "'"
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

    Private Sub txtusnm_TextChanged(sender As Object, e As EventArgs) Handles txtusnm.TextChanged

    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from user where nama like '" & txtfind.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "user")
        dgv.DataSource = ds.Tables("user")
        kon.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged

    End Sub

    Private Sub cmbst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbst.SelectedIndexChanged

    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        FMenu.Show()
        Me.Close()
    End Sub

    Private Sub btedit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtidus_TextChanged(sender As Object, e As EventArgs) Handles txtidus.TextChanged

    End Sub
End Class