Imports System.String
Imports MySql.Data.MySqlClient
Public Class Penyewa
    Private nama As String
    Private nik As String
    Private alamat As String
    Private penyewaDataTable As New ArrayList()

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "penyewaan_mobil"

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Public Function GetDataPenyewaDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + "; user id = " + username + ";" _
            + "password = " + password + "; database = " + database + ";"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penyewa AS 'ID', nik AS 'NIK', nama AS 'Nama', alamat AS 'Alamat' FROM penyewa"

        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function AddPenyewaDatabase(nama_penyewa As String, nik_penyewa As String, alamat_penyewa As String)
        dbConn.ConnectionString = "server = " + server + "; user id = " + username + ";" _
            + "password = " + password + "; database = " + database + ";"

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "INSERT INTO penyewa(nik, nama, alamat) VALUES('" & nik_penyewa & "','" & nama_penyewa & "','" & alamat_penyewa & "')"

            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Sub UpdatePenyewaDatabase(id As Integer, nama_penyewa As String, nik_penyewa As String, alamat_penyewa As String)
        dbConn.ConnectionString = "server = " + server + "; user id = " + username + ";" _
            + "password = " + password + "; database = " + database + ";"

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "UPDATE penyewa SET nik = '" & nik_penyewa & "', nama = '" & nama_penyewa & "', alamat = '" & alamat_penyewa & "' WHERE id_penyewa = " & (id + 1) & " "

        sqlRead = sqlCommand.ExecuteReader

        sqlRead.Close()
        dbConn.Close()
    End Sub
    Public Property GSNamaPenyewa As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSNikPenyewa As String
        Get
            Return nik
        End Get
        Set(value As String)
            nik = value
        End Set
    End Property

    Public Property GSAlamatPenyewa As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
End Class
