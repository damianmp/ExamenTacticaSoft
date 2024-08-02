Public Class Productos
    Private _ID As Integer
    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Private _Precio As Double
    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set(value As Double)
            _Precio = Double.Round(value, 2)
        End Set
    End Property

    Private _Categoria As String
    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
        End Set
    End Property

    Public Sub New(id As Integer, nombre As String, precio As Double, categoria As String)
        Me._ID = id
        Me._Nombre = nombre
        Me._Precio = precio
        Me._Categoria = categoria
    End Sub

    Public Sub New(Obj As Object)
        If TypeOf Obj Is Productos Then
            Me.ID = CType(Obj, Productos)._ID
            Me.Nombre = CType(Obj, Productos)._Nombre
            Me.Precio = CType(Obj, Productos)._Precio
            Me.Categoria = CType(Obj, Productos)._Categoria
        End If
    End Sub

    Public Overrides Function toString() As String
        Return Me.Nombre
    End Function

End Class
