
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class ClienteDAO
    Inherits SingleCon
    Implements IGeneralDAO

    ''Alta baja y modificacion acá ''
    Public Sub Alta(Obj As Object) Implements IGeneralDAO.Alta
        If TypeOf Obj Is Cliente Then
            Dim cliente As New Cliente(Obj)

            Dim comm As New MySqlCommand
            delInstance()
            comm.Connection = getInstance()
            comm.CommandText = "INSERT INTO `examen_vb.net`.`clientes` (`Cliente`, `Telefono`, `Correo`) VALUES (@var1, @var2, @var3);"

            comm.Parameters.AddWithValue("@var1", cliente.Cliente)
            comm.Parameters.AddWithValue("@var2", cliente.Telefono)
            comm.Parameters.AddWithValue("@var3", cliente.Correo)

            comm.Prepare()
            comm.ExecuteNonQuery()
        End If

    End Sub

    Public Sub Baja(Obj As Object) Implements IGeneralDAO.Baja
        Dim cliente As New Cliente(Obj)

        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "DELETE FROM `examen_vb.net`.`clientes` WHERE (`Cliente` like @var1 and `Telefono` like @var2 and `Correo` like @var3);"

        comm.Parameters.AddWithValue("@var1", cliente.Cliente)
        comm.Parameters.AddWithValue("@var2", cliente.Telefono)
        comm.Parameters.AddWithValue("@var3", cliente.Correo)

        comm.Prepare()
        comm.ExecuteNonQuery()
    End Sub

    Public Sub Modificacion(Obj As Object, Obj2 As Object) Implements IGeneralDAO.Modificacion
        Dim cliente As New Cliente(Obj)
        Dim cliente2 As New Cliente(Obj2)

        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "UPDATE `examen_vb.net`.`clientes` SET `Cliente` = @var1 , `Telefono` = @var2 , `Correo` = @var3 WHERE (`Cliente` like @var4 and `Telefono` like @var5 and `Correo` like @var6);"

        comm.Parameters.AddWithValue("@var1", cliente2.Cliente)
        comm.Parameters.AddWithValue("@var2", cliente2.Telefono)
        comm.Parameters.AddWithValue("@var3", cliente2.Correo)
        comm.Parameters.AddWithValue("@var4", cliente.Cliente)
        comm.Parameters.AddWithValue("@var5", cliente.Telefono)
        comm.Parameters.AddWithValue("@var6", cliente.Correo)

        comm.Prepare()
        comm.ExecuteNonQuery()
    End Sub

    Public Function Listar() Implements IGeneralDAO.Listar
        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "SELECT * FROM `examen_vb.net`.clientes;"

        Dim array As New List(Of Cliente)
        Dim dr As MySqlDataReader
        dr = comm.ExecuteReader
        Do While dr.Read
            Dim auxc As New Cliente(dr(0).ToString, dr(1).ToString, dr(2).ToString, dr(3).ToString)

            array.Add(auxc)
        Loop

        Return array
    End Function

    Public Function Buscar(Filtro As String) Implements IGeneralDAO.Buscar
        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "Select c2.ID FROM `examen_vb.net`.clientes Join Clientes as c2 on c2.cliente = `examen_vb.net`.clientes.Cliente And c2.telefono = `examen_vb.net`.clientes.Telefono And c2.correo = `examen_vb.net`.clientes.Correo where c2.cliente Like @var1 Or c2.telefono Like @var1 Or c2.correo Like @var1"
        comm.Parameters.AddWithValue("@var1", Filtro)

        comm.Prepare()
        Dim dr As MySqlDataReader
        dr = comm.ExecuteReader

        Return dr(0).ToString
    End Function

End Class
