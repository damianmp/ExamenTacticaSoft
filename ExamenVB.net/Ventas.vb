Public Class Ventas
    Private _Fecha As Date
    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property
    Private _VCliente As Cliente
    Public Property VCliente As Cliente
        Get
            Return _VCliente
        End Get
        Set(value As Cliente)
            _VCliente = value
        End Set
    End Property
    Private _Total As Double
    Public Property Total As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            _Total = value
        End Set
    End Property

    Private _Productos As List(Of Productos)
    Public Property Productos As List(Of Productos)
        Get
            Return _Productos
        End Get
        Set(value As List(Of Productos))
            _Productos = value
        End Set
    End Property

    Public Sub New(fecha As Date, vCliente As Cliente, total As Double, productos As List(Of Productos))
        Me._Fecha = fecha
        Me._VCliente = vCliente
        Me._Total = total
        Me._Productos = productos
    End Sub
    Public Sub New(Obj As Object)
        If TypeOf Obj Is Ventas Then
            Me.Fecha = CType(Obj, Ventas).Fecha
            Me.VCliente = CType(Obj, Ventas).VCliente
            Me.Total = CType(Obj, Ventas).Total
            Me._Productos = CType(Obj, Ventas).Productos
        End If
    End Sub

End Class
