Imports System.Text
Imports MySql.Data.MySqlClient

Public Class TAMU

    'Private listtamu As New List(Of String)

    'Database global variabel
    Private tamudatatable As New ArrayList()


    'UNTUK DATABASE
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "system_perhotelan"

    'DEKLARASI
    Private niktamu As String
    Private namatamu As String
    Private alamattamu As String
    Private jeniskelamintamu As String


    Public Property niktamuProperty() As String
        Get
            Return niktamu
        End Get
        Set(ByVal value As String)
            niktamu = value
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

    Public Property alamattamuProperty() As String
        Get
            Return alamattamu
        End Get
        Set(ByVal value As String)
            alamattamu = value
        End Set
    End Property

    Public Property jeniskelamintamuProperty() As String
        Get
            Return jeniskelamintamu
        End Get
        Set(ByVal value As String)
            jeniskelamintamu = value
        End Set
    End Property

    Public ReadOnly Property gettamudatatable() As ArrayList
        Get
            Return tamudatatable
        End Get
    End Property

    'Public Function converttamutostring(vals As List(Of String))
    'Dim builder As StringBuilder = New StringBuilder()
    'For Each val As String In vals
    'builder.Append(val).Append("|")
    'Next

    'Convert To String
    'Dim res = builder.ToString()
    'Return res
    'End Function

    'Public Function convertstringtotamu(value As String)
    'Dim arr() As String = value.Split("|")

    'Convert to List
    'Dim vals As List(Of String) = arr.ToList()
    'Return vals
    'End Function

    'Public Function addtamu(value As String)
    '   listtamu.Add(value)
    'Return ""
    'End Function


    Public Function GetDataTamuDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_tamu AS 'ID',
                                        NIK AS 'NIK',
                                        nama AS 'Nama Tamu',
                                        alamat AS 'Alamat Tamu',
                                        jenis_kelamin AS 'Jenis Kelamin' 
                                        FROM tamu"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function AddDataTamuDatabase(nik_tamu As String,
                                          nama_tamu As String,
                                          alamat_tamu As String,
                                          jenis_kelamin_tamu As String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO tamu(nik, nama, alamat, jenis_kelamin) 
                        VALUE ( '" & nik_tamu & "',
                                '" & nama_tamu & "',
                                '" & alamat_tamu & "',
                                '" & jenis_kelamin_tamu & "')"

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

    Public Function GetDataTamuByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_tamu,
                                        NIK,
                                        nama, 
                                        alamat,
                                        jenis_kelamin                                       
                                   FROM tamu
                                   WHERE id_tamu = '" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataTamuByIDDatabase(ID As Integer,
                                                   nik_tamu As String,
                                                   nama_tamu As String,
                                                   alamat_tamu As String,
                                                   jenis_kelamin_tamu As String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE tamu SET " &
                        "NIK='" & nik_tamu & "', " &
                        "nama='" & nama_tamu & "', " &
                        "alamat='" & alamat_tamu & "', " &
                        "jenis_kelamin='" & jenis_kelamin_tamu & "' " &
                        "WHERE id_tamu='" & ID & "'"
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

    Public Function DeleteDataTamuByIDDatabase(ID As Integer)


        dbConn.ConnectionString = "server =" + server + ";" + "user id = " + username + ";" _
           + "password=" + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM tamu  " &
                        "WHERE id_tamu='" & ID & "'"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


End Class
