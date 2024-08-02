Imports Nueva_Venta
Imports Objetos

Public Class Form

    Private cliente As Cliente
    Private Sub HideAll()
        For Each c As Control In Me.Controls
            If TypeOf c Is GroupBox Then
                c.Visible = False
            End If
        Next
    End Sub

    Private Sub OnClickAltaClienteTSMI(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        HideAll()
        gbAltaCliente.Visible = True
    End Sub

    Private Sub OnClickBajaClienteTSMI(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        HideAll()
        gbBajaCliente.Visible = True

        Dim daocliente As New ClienteDAO()
        DataGridView1.DataSource = daocliente.Listar()
    End Sub

    Private Sub btnAgregarClienteEvent(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click

        Dim cliente As New Cliente(0, txtbNombre.Text, txtbTelefono.Text, txtbCorreo.Text)
        Dim daocliente As New ClienteDAO()

        daocliente.Alta(cliente)

        MessageBox.Show("Cliente agregado con exito!")
    End Sub

    Private Sub btnBajaClienteEvent(sender As Object, e As EventArgs) Handles btnBajaCliente.Click
        Dim daocliente As New ClienteDAO
        daocliente.Baja(cliente)


        OnClickBajaClienteTSMI(sender, e)
        MessageBox.Show("Cliente eliminado con exito!")
    End Sub

    Private Sub OnClickDataGridView(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim fila As New DataGridViewRow

        Dim nombre As String
        Dim telefono As String
        Dim correo As String

        fila = DataGridView1.CurrentRow
        nombre = DataGridView1.Item(0, fila.Index).Value
        telefono = DataGridView1.Item(1, fila.Index).Value
        correo = DataGridView1.Item(2, fila.Index).Value

        cliente = New Cliente(0, nombre, telefono, correo)
    End Sub

    Private Sub OnClickModificarClienteTSMI(sender As Object, e As EventArgs) Handles ModificacionToolStripMenuItem.Click
        HideAll()
        gbModificarCliente.Visible = True

        Dim daocliente As New ClienteDAO()
        DataGridView2.DataSource = daocliente.Listar()
    End Sub

    Private Sub OnCellEndEditModificarCliente(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit

        Dim fila As Integer
        'valor nuevo'
        fila = DataGridView2.CurrentCell.RowIndex

        Dim daocliente As New ClienteDAO()
        Dim lista As New List(Of Cliente)
        lista = daocliente.Listar()

        Dim nombre As String
        Dim telefono As String
        Dim correo As String
        nombre = DataGridView2.Item(0, fila).Value
        telefono = DataGridView2.Item(1, fila).Value
        correo = DataGridView2.Item(2, fila).Value

        Dim lcliente As New Cliente(0, nombre, telefono, correo)
        Dim oldcliente As New Cliente(lista(fila))

        daocliente.Modificacion(oldcliente, lcliente)

        MessageBox.Show("Cliente actualizado con exito!")
    End Sub

    Private Sub OnClickAltaProductoTSMI(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        HideAll()
        gbAltaProducto.Visible = True
    End Sub

    Private Sub btnAgregarProductoEvent(sender As Object, e As EventArgs) Handles btnAltaProducto.Click

        Dim numero As Double

        If Double.TryParse(txtbPrecio.Text, numero) Then
            Dim producto As New Productos(0, txtbProducto.Text, numero, txtbCategoria.Text)
            Dim daoproducto As New ProductosDAO()

            daoproducto.Alta(producto)

            MessageBox.Show("Producto agregado con exito!")

            labelError.Text = ""
        Else
            labelError.Text = "No se admiten letras"
        End If

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        HideAll()
        gbVentas.Visible = True

        Dim datedate As Date
        datedate = MonthCalendar1.TodayDate

    End Sub

    Private Sub OnClickbtnNuevaVenta(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        Dim nueva_venta As New System.Windows.Forms.Form
        nueva_venta = New Form1

        nueva_venta.Activate()
        nueva_venta.Show()

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim fecha As Date
        fecha = MonthCalendar1.SelectionRange.Start

        Dim strfecha As String
        strfecha = String.Format("{0:0000}", fecha.Year) & "-" & String.Format("{0:00}", fecha.Month) & "-" & String.Format("{0:00}", fecha.Day)


        Dim ventasdao As New VentasDAO
        Dim listaproducto As New List(Of ProductoDetallado)
        For Each par In ventasdao.getVentaDelDia(strfecha)
            listaproducto.Add(par.key)
        Next

        DataGridView3.DataSource = listaproducto

    End Sub
End Class
