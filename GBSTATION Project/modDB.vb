Imports Microsoft.Data.SqlClient

Module modDB
    Public ReadOnly ConnString As String =
        "Server=(localdb)\MSSQLLocalDB;Database=GBStationDB;Integrated Security=True;TrustServerCertificate=True;"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnString)
    End Function
End Module
