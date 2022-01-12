Imports System.Text
Imports MySql.Data.MySqlClient

Public Class CLASS_KAMAR


    Private id_jenis_kamar As String
    Private nama_kamar As String
    Private tambah_status As String
    Private jenis_kamar As String
    Private harga_permalam As Integer




    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "system_perhotelan"


    Public Property id_jenis_kamarProperty() As String
        Get
            Return id_jenis_kamar
        End Get
        Set(ByVal value As String)
            id_jenis_kamar = value
        End Set
    End Property

    Public Property nama_kamarProperty() As String
        Get
            Return nama_kamar
        End Get
        Set(ByVal value As String)
            nama_kamar = value
        End Set
    End Property

    Public Property tambah_statusProperty() As String
        Get
            Return tambah_status
        End Get
        Set(ByVal value As String)
            tambah_status = value
        End Set
    End Property

    Public Property HargaPerMalamProperty() As Integer
        Get
            Return harga_permalam
        End Get
        Set(ByVal value As Integer)
            harga_permalam = value
        End Set
    End Property

    Public Property jeniskamarProperty() As String
        Get
            Return jenis_kamar
        End Get
        Set(ByVal value As String)
            jenis_kamar = value
        End Set
    End Property


    Public Function ConvertKamarToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert To String
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKamar(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to List

        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKamarDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = " server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT km.id_kamar AS 'ID' , 
                                  km.nama_kamar AS 'Nama Kamar',
                                  km.status AS 'Status',
                                  jk.id_jenis_kamar AS 'Id Jenis Kamar',
                                  jk.jenis_kamar AS 'Jenis Kamar'
                                  FROM kamar AS km 
                                  JOIN jenis_kamar AS jk ON km.id_jenis_kamar=jk.id_jenis_kamar"




        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        dbConn.Dispose()
        Return result
    End Function

    Public Function AddDataKamarDatabase(id_jenis_kamar As Integer,
                                         nama_kamar As String,
                                           status As String)



        dbConn.ConnectionString = " server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO kamar(id_jenis_kamar, nama_kamar,
                                        status) VALUE('" _
                                        & id_jenis_kamar & "', '" _
                                        & nama_kamar & "', '" _
                                        & status & "')"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            Debug.WriteLine(sqlQuery)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Form_Kamar.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKamarByIDDatabase(ID As Integer)

        dbConn.ConnectionString = " server =" + server + ";" + "user id=" + username + ";" _
         + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM kamar " &
                        "WHERE id_kamar='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Form_Kamar.sqlDt.Load(sqlRead)

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKamarByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = " server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_kamar,
                                  id_jenis_kamar, 
                                  nama_kamar,
                                  status
                                 
                                  FROM kamar
                                  WHERE id_kamar='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read

            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKamarByIDDatabase(ID As Integer,
                                                id_jenis_kamar As Integer,
                                                nama_kamar As String,
                                                status As String)

        dbConn.ConnectionString = " server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE kamar SET " &
                        "id_jenis_kamar='" & id_jenis_kamar & "', " &
                        "nama_kamar='" & nama_kamar & "', " &
                        "status='" & status & "' " &
                        "WHERE id_kamar='" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Kamar.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataJenisKamarDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = " server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_kamar AS 'ID' , 
                                  jenis_kamar AS 'Jenis Kamar',
                                  harga_permalam AS 'Harga_Permalam'
                                  FROM jenis_kamar"


        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        dbConn.Dispose()
        Return result
    End Function



End Class