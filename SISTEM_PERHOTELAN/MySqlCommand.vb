Friend Class MySqlCommand
    Private sqlQuery As String
    Private dbConn As MySqlConnection

    Public Sub New(sqlQuery As String, dbConn As MySqlConnection)
        Me.sqlQuery = sqlQuery
        Me.dbConn = dbConn
    End Sub
End Class
