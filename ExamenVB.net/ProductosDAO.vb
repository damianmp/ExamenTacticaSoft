Imports MySql.Data.MySqlClient

Public Class ProductosDAO
    Inherits SingleCon
    Implements IGeneralDAO

    Public Sub Alta(Obj As Object) Implements IGeneralDAO.Alta
        If TypeOf Obj Is Productos Then
            Dim producto As New Productos(Obj)

            Dim comm As New MySqlCommand
            delInstance()
            comm.Connection = getInstance()
            comm.CommandText = "INSERT INTO `examen_vb.net`.`productos` (`Nombre`, `Precio`, `Categoria`) VALUES (@var1, @var2, @var3);"

            comm.Parameters.AddWithValue("@var1", producto.Nombre)
            comm.Parameters.AddWithValue("@var2", producto.Precio)
            comm.Parameters.AddWithValue("@var3", producto.Categoria)

            comm.Prepare()
            comm.ExecuteNonQuery()
        End If
    End Sub

    Public Sub Baja(Obj As Object) Implements IGeneralDAO.Baja
        Dim producto As New Productos(Obj)

        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "DELETE FROM `examen_vb.net`.`productos` WHERE (`Nombre` like @var1 and `Precio` like @var2 and `Categoria` like @var3);"

        comm.Parameters.AddWithValue("@var1", producto.Nombre)
        comm.Parameters.AddWithValue("@var2", producto.Precio)
        comm.Parameters.AddWithValue("@var3", producto.Categoria)

        comm.Prepare()
        comm.ExecuteNonQuery()
    End Sub

    Public Sub Modificacion(Obj As Object, Obj2 As Object) Implements IGeneralDAO.Modificacion
        Dim producto As New Productos(Obj)
        Dim producto2 As New Productos(Obj2)

        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "UPDATE `examen_vb.net`.`productos` SET `Nombre` = @var1 , `Precio` = @var2 , `Categoria` = @var3 WHERE (`Nombre` like @var4 and `Precio` like @var5 and `Categoria` like @var6);"

        comm.Parameters.AddWithValue("@var1", producto2.Nombre)
        comm.Parameters.AddWithValue("@var2", producto2.Precio)
        comm.Parameters.AddWithValue("@var3", producto2.Categoria)
        comm.Parameters.AddWithValue("@var4", producto.Nombre)
        comm.Parameters.AddWithValue("@var5", producto.Precio)
        comm.Parameters.AddWithValue("@var6", producto.Categoria)

        comm.Prepare()
        comm.ExecuteNonQuery()
    End Sub

    Public Function Listar() Implements IGeneralDAO.Listar
        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "SELECT * FROM `examen_vb.net`.productos;"

        Dim array As New List(Of Productos)
        Dim dr As MySqlDataReader
        dr = comm.ExecuteReader
        Do While dr.Read
            Dim auxc As New Productos(CType(dr(0).ToString, Integer), dr(1).ToString, dr(2).ToString, dr(3).ToString)

            array.Add(auxc)
        Loop

        Return array
    End Function

    Public Function Buscar(Filtro As String) Implements IGeneralDAO.Buscar
        Throw New NotImplementedException()
    End Function
End Class
