Imports MySql.Data.MySqlClient
Module Module1
    Public strkon As String = "server=localhost; userid=root; database=towahobbyshop;convert zero datetime=true"
    Public kon As New MySqlConnection(strkon)
    Public perintah As New MySqlCommand
    Public cek As MySqlDataReader
    Public simpan As Boolean
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
    Public user As String
    Public login
    Public dtp As String
End Module
