Imports System.Text
Imports MySql.Data.MySqlClient

Public Class BUKU_TAMU

    Private daftartamudatatable As New ArrayList()

    'UNTUK DATABASE
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "system_perhotelan"

    'Deklarasi Variabel
    Private idtamu As String
    Private namatamu As String
    Private idjeniskamar As String
    Private jeniskamar As String
    Private idkamar As String
    Private namakamar As String
    Private tanggal_checkin As String
    Private tanggal_checkout As String
    Private total_bayar As String


    Public Property idtamuProperty() As Integer
        Get
            Return idtamu
        End Get
        Set(ByVal value As Integer)
            idtamu = value
        End Set
    End Property

    Public Property namatamuProperty() As String
        Get
            Return namatamu
        End Get
        Set(ByVal value As String)
            namatamu = value
        End Set
    End Property

    Public Property idjeniskamarProperty() As Integer
        Get
            Return idjeniskamar
        End Get
        Set(ByVal value As Integer)
            idjeniskamar = value
        End Set
    End Property

    Public Property jeniskamarProperty() As String
        Get
            Return jeniskamar
        End Get
        Set(ByVal value As String)
            jeniskamar = value
        End Set
    End Property

    Public Property idkamarProperty() As Integer
        Get
            Return idkamar
        End Get
        Set(ByVal value As Integer)
            idkamar = value
        End Set
    End Property

    Public Property namakamarProperty() As String
        Get
            Return namakamar
        End Get
        Set(ByVal value As String)
            namakamar = value
        End Set
    End Property

    Public Property tanggalcheckinProperty() As String
        Get
            Return tanggal_checkin
        End Get
        Set(ByVal value As String)
            tanggal_checkin = value
        End Set
    End Property

    Public Property tanggalcheckoutProperty() As String
        Get
            Return tanggal_checkout
        End Get
        Set(ByVal value As String)
            tanggal_checkout = value
        End Set
    End Property

    Public Property totalbayarProperty() As Integer
        Get
            Return total_bayar
        End Get
        Set(ByVal value As Integer)
            total_bayar = value
        End Set
    End Property

    Public Function GetDataDaftarTamuDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT bk.id_booking AS 'ID',
                                        tm.id_tamu AS 'ID Tamu',
                                        tm.nama AS 'Nama Tamu',
                                        jk.id_jenis_kamar AS 'Id Jenis Kamar',
                                        jk.jenis_kamar AS 'Jenis Kamar',
                                        km.id_kamar AS 'Id Kamar',
                                        km.nama_kamar AS 'Nama Kamar',
                                        bk.check_in AS 'Tanggal Check In',
                                        bk.check_out AS 'Tanggal Check Out',
                                        jk.harga_permalam AS 'Harga Permalam',
                                        bk.total_bayar AS 'Nominal Pembayaran'
                                        FROM booking_kamar AS bk
                                        JOIN tamu AS tm ON bk.id_tamu=tm.id_tamu
                                        JOIN jenis_kamar AS jk ON bk.id_jenis_kamar=jk.id_jenis_kamar
                                        JOIN kamar AS km ON bk.id_kamar=km.id_kamar"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function AddDataDaftarTamuDatabase(id_tamu As Integer,
                                              id_jenis_kamar As Integer,
                                              id_kamar As Integer,
                                              tanggal_check_in As Date)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO booking_kamar(id_tamu, id_jenis_kamar, id_kamar, check_in) 
                        VALUE ( '" & id_tamu & "',
                                '" & id_jenis_kamar & "',
                                '" & id_kamar & "',
                                '" & tanggal_check_in.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateDataDaftarTamuByIDDatabase(ID As Integer,
                                                    tanggal_check_out As String,
                                                    total_bayar As Integer)


        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE booking_kamar SET " &
                        "check_out='" & tanggal_check_out & "', " &
                        "total_bayar='" & total_bayar & "' " &
                        "WHERE id_booking='" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqIDt.load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try


    End Function

    Public Function DeleteDataDaftarTamuByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM booking_kamar " &
                        "WHERE id_booking='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
