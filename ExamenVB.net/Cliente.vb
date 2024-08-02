Public Class Cliente

    Private _ID As Integer
    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Private _Cliente As String
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property

    Private _Telefono As String
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Private _Correo As String
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property

    Public Sub New(id As Integer, cliente As String, telefono As String, correo As String)
        Me.ID = id
        Me.Cliente = cliente
        Me.Telefono = telefono
        Me.Correo = correo
    End Sub

    Public Sub New(Obj As Object)
        If TypeOf Obj Is Cliente Then
            Me.Cliente = CType(Obj, Cliente)._Cliente
            Me.Telefono = CType(Obj, Cliente)._Telefono
            Me.Correo = CType(Obj, Cliente)._Correo
        End If
    End Sub

    Public Overrides Function toString() As String
        Return Me.Cliente
    End Function

End Class
