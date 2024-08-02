Imports Objetos

Public Class Form1
    Private ventadetallada As Ventas

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim daoclientes As New ClienteDAO
        Dim daoproductos As New ProductosDAO
        cbCliente.DataSource = daoclientes.Listar
        cbProducto.DataSource = daoproductos.Listar

        lTotal.Text = CType(cbProducto.SelectedItem, Productos).Precio & "$"

        ventadetallada = New Ventas(Date.Now, CType(cbCliente.SelectedItem, Cliente), 0, New List(Of Productos))
    End Sub

    Private Sub OnChangeComboBox(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Dim daoproductos As New ProductosDAO
        lTotal.Text = CType(cbProducto.SelectedItem, Productos).Precio & "$"
    End Sub

    Private Sub OnClickVentaProducto(sender As Object, e As EventArgs) Handles btnAgregarProductoVenta.Click
        Dim numero As Double

        If Double.TryParse(txtbCantidad.Text, numero) Then

            lbListaDeProductos.DataSource = Nothing

            Dim pdetalle As New ProductoDetallado(cbProducto.SelectedItem)
            pdetalle.Cantidad = txtbCantidad.Text
            pdetalle.Precio = Double.Round(pdetalle.Precio, 2)
            ventadetallada.Productos.Add(pdetalle)

            lbListaDeProductos.DataSource = ventadetallada.Productos

            labelError.Text = ""

            ''sumatoria productos
            Dim total As Double
            For Each p In ventadetallada.Productos
                total = total + p.Precio * CType(p, ProductoDetallado).Cantidad
            Next

            lTotalVenta.Text = Double.Round(total, 2) & "$"

            ventadetallada.Total = Double.Round(total, 2)

        Else
            labelError.Text = "No se admiten letras"
        End If
    End Sub

    Private Sub OnChangedCliente(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        lbListaDeProductos.DataSource = Nothing

        ventadetallada = New Ventas(Date.Now, CType(cbCliente.SelectedItem, Cliente), 0, New List(Of Productos))
    End Sub

    Private Sub OnClickbtnProcesarVenta(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventasdao As New VentasDAO

        ventasdao.Alta(ventadetallada)

        MessageBox.Show("Se registró la venta!")
        Me.Dispose()
    End Sub
End Class
