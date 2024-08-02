Imports Objetos

Public Class ProductoDetallado
    Inherits Productos

    Private _Cantidad As Double
    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
        End Set
    End Property

    Public Sub New(Obj As Object)
        MyBase.New(Obj)
    End Sub

    Public Sub New(id As Integer, nombre As String, precio As Double, categoria As String, cantidad As Integer)
        MyBase.New(id, nombre, precio, categoria)
        Me._Cantidad = cantidad
    End Sub

    Public Sub New(id As Integer, nombre As String, precio As Double, categoria As String)
        MyBase.New(id, nombre, precio, categoria)
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.toString() & "................." & _cantidad * Me.Precio & "(" & _cantidad & ")"
    End Function

End Class
