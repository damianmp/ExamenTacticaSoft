Imports Objetos.Objetos
Imports MySql.Data.MySqlClient

Public Class SingleCon

    Private Shared _Conexion As MySqlConnection

    Public Shared Function getInstance() As MySqlConnection
        If _Conexion Is Nothing Then
            Try
                _Conexion = New MySqlConnection("Server=" + Propiedades.Default.Servidor + ";Uid=" + Propiedades.Default.uid + ";Pwd=" + Propiedades.Default.pwd + ";Database=" + Propiedades.Default.database)
                _Conexion.Open()
                Return _Conexion
            Catch ex As MySql.Data.MySqlClient.MySqlException
                Console.WriteLine(ex.ToString)
            End Try
        End If
        Return _Conexion
    End Function

    Public Shared Sub delInstance()
        If Not (_Conexion Is Nothing) Then
            _Conexion.Close()
            _Conexion = Nothing
        End If
    End Sub

End Class
