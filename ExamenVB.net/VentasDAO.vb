Imports MySql.Data.MySqlClient

Public Class VentasDAO
    Inherits SingleCon
    Implements IGeneralDAO

    Public Sub Alta(Obj As Object) Implements IGeneralDAO.Alta
        If TypeOf Obj Is Ventas Then
            Dim venta As New Ventas(Obj)

            ''Primero agrego el cliente y su venta
            Dim comm As New MySqlCommand

            delInstance()
            comm.Connection = getInstance()
            comm.CommandText = "insert into ventas(ventas.IDCliente, ventas.Fecha, ventas.Total) VALUE (@var1, @var2, @var3);"
            comm.Parameters.AddWithValue("@var1", venta.VCliente.ID)
            comm.Parameters.AddWithValue("@var2", venta.Fecha.Date)
            comm.Parameters.AddWithValue("@var3", Double.Round(venta.Total, 2))
            comm.ExecuteNonQuery()

            ''Como el "diseño" de la db lo amerita...
            Dim lastid As Integer
            lastid = Last()

            For Each p As Productos In venta.Productos

                Dim precio As String
                Dim total As String

                precio = p.Precio
                total = (Double.Round(p.Precio * CType(p, ProductoDetallado).Cantidad, 2))

                precio = precio.Replace(",", ".")
                total = total.Replace(",", ".")

                comm.CommandText = "insert into ventasitems(idventa, idproducto, preciounitario,cantidad,preciototal) value(" _
                    & lastid & "," & p.ID & "," & precio & "," & CType(p, ProductoDetallado).Cantidad & "," & total & ")"

                delInstance()
                comm.Connection = getInstance()
                comm.ExecuteNonQuery()
            Next

        End If
    End Sub

    Public Sub Baja(Obj As Object) Implements IGeneralDAO.Baja
        Throw New NotImplementedException()
    End Sub

    Public Sub Modificacion(Obj As Object, Obj2 As Object) Implements IGeneralDAO.Modificacion
        Throw New NotImplementedException()
    End Sub

    Public Function Buscar(Filtro As String) Implements IGeneralDAO.Buscar
        Throw New NotImplementedException()
    End Function

    Public Function Listar() As Object Implements IGeneralDAO.Listar
        Throw New NotImplementedException()
    End Function

    Private Function Last() As Integer
        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "SELECT max(id) FROM `examen_vb.net`.ventas;"
        comm.Prepare()
        Dim read As MySqlDataReader
        read = comm.ExecuteReader()
        read.Read()
        Try
            Return read(0)
        Catch ex As System.InvalidCastException
            Return 0
        End Try
    End Function

    Public Function getVentaDelDia(fecha As String)
        Dim comm As New MySqlCommand
        delInstance()
        comm.Connection = getInstance()
        comm.CommandText = "Select Productos.ID ,Productos.Nombre, ventasitems.Cantidad ,ventas.Fecha FROM `examen_vb.net`.ventas Join ventasitems on Ventas.ID = ventasitems.IDVenta Join Productos on Productos.ID = ventasitems.IDProducto where Ventas.Fecha Like @var1"
        comm.Parameters.AddWithValue("@var1", fecha)

        Dim map As New Dictionary(Of ProductoDetallado, Date)
        Dim dr As MySqlDataReader
        dr = comm.ExecuteReader
        Do While dr.Read
            Dim auxp As New ProductoDetallado(dr(0), dr(1), 0, "", dr(2))
            map.Add(auxp, dr(3))
        Loop

        Return map
    End Function
End Class
