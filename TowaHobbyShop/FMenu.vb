Imports MySql.Data.MySqlClient
Public Class FMenu
    Sub bersih()
        FLogin.TUSERNAME.Text = ""
        FLogin.TPASSWORD.Text = ""
    End Sub
    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Label3.Text = "Atasan" Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True

        ElseIf Label3.Text = "Gudang" Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = False
            Button5.Enabled = True

        Else Label3.Text = "Kasir"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FPengguna.Show()
        Me.Hide()
    End Sub

    Private Sub BtLogout_Click(sender As Object, e As EventArgs) Handles BtLogout.Click
        FLogin.Show()
        Me.Close()
        bersih()
        FLogin.TUSERNAME.Text = ""
        FLogin.TPASSWORD.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FBarang.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FDistributor.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FPemasok.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
End Class