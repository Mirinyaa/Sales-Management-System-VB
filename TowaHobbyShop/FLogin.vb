Public Class FLogin
    Private Sub BLOGIN_Click(sender As Object, e As EventArgs) Handles BLOGIN.Click
        Try
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from user where username =('" & TUSERNAME.Text & "') and password=MD5('" & TPASSWORD.Text & "')"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                user = TUSERNAME.Text
                FMenu.Label2.Text = cek.Item("nama")
                FMenu.Label3.Text = cek.Item("status")
                FPenjualan.txtnmks.Text = cek.Item("nama")
                cek.Close()
                MsgBox("Selamat Datang... Anda Telah Bisa Mengakses Halaman Menu Utama",
               MsgBoxStyle.Information, "Konfirmasi")
                FMenu.Show()
                Me.Hide()
            Else
                MsgBox("ANDA TIDAK BISA LOGIN", MsgBoxStyle.Critical, "INFORMATION")
                TUSERNAME.Clear()
                TPASSWORD.Clear()
                TUSERNAME.Focus()
            End If
            kon.Close()
        Catch ex As Exception
            MsgBox("TIDAK ADA KONEKSI", MsgBoxStyle.Critical, "INFORMATION")
        End Try
    End Sub
End Class
