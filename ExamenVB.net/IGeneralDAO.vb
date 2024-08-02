Public Interface IGeneralDAO
    Sub Alta(Obj As Object)
    Sub Baja(Obj As Object)
    Sub Modificacion(Obj As Object, Obj2 As Object)
    Function Listar()
    Function Buscar(Filtro As String)

End Interface
