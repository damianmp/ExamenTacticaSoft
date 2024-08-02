<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        OpcionesToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem = New ToolStripMenuItem()
        BajaToolStripMenuItem = New ToolStripMenuItem()
        ModificacionToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem1 = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        gbAltaCliente = New GroupBox()
        Label6 = New Label()
        txtbTelefono = New TextBox()
        txtbCorreo = New TextBox()
        txtbNombre = New TextBox()
        btnAgregarCliente = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        gbBajaCliente = New GroupBox()
        btnBajaCliente = New Button()
        DataGridView1 = New DataGridView()
        ClienteDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        TelefonoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CorreoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ClienteBindingSource = New BindingSource(components)
        Label5 = New Label()
        gbModificarCliente = New GroupBox()
        Label4 = New Label()
        DataGridView2 = New DataGridView()
        ClienteDataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        TelefonoDataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        CorreoDataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        gbAltaProducto = New GroupBox()
        labelError = New Label()
        Label10 = New Label()
        btnAltaProducto = New Button()
        txtbCategoria = New TextBox()
        txtbPrecio = New TextBox()
        txtbProducto = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        gbVentas = New GroupBox()
        btnNuevaVenta = New Button()
        DataGridView3 = New DataGridView()
        CantidadDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        NombreDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ProductoDetalladoBindingSource = New BindingSource(components)
        MonthCalendar1 = New MonthCalendar()
        VentasBindingSource = New BindingSource(components)
        MenuStrip1.SuspendLayout()
        gbAltaCliente.SuspendLayout()
        gbBajaCliente.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ClienteBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        gbModificarCliente.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        gbAltaProducto.SuspendLayout()
        gbVentas.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProductoDetalladoBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(VentasBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {OpcionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(387, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' OpcionesToolStripMenuItem
        ' 
        OpcionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ProductosToolStripMenuItem, VentasToolStripMenuItem})
        OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        OpcionesToolStripMenuItem.Size = New Size(69, 20)
        OpcionesToolStripMenuItem.Text = "Opciones"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem, BajaToolStripMenuItem, ModificacionToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(128, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' AltaToolStripMenuItem
        ' 
        AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        AltaToolStripMenuItem.Size = New Size(144, 22)
        AltaToolStripMenuItem.Text = "Alta"
        ' 
        ' BajaToolStripMenuItem
        ' 
        BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        BajaToolStripMenuItem.Size = New Size(144, 22)
        BajaToolStripMenuItem.Text = "Baja"
        ' 
        ' ModificacionToolStripMenuItem
        ' 
        ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        ModificacionToolStripMenuItem.Size = New Size(144, 22)
        ModificacionToolStripMenuItem.Text = "Modificación"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem1})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(128, 22)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' AltaToolStripMenuItem1
        ' 
        AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        AltaToolStripMenuItem1.Size = New Size(95, 22)
        AltaToolStripMenuItem1.Text = "Alta"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(128, 22)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' gbAltaCliente
        ' 
        gbAltaCliente.Controls.Add(Label6)
        gbAltaCliente.Controls.Add(txtbTelefono)
        gbAltaCliente.Controls.Add(txtbCorreo)
        gbAltaCliente.Controls.Add(txtbNombre)
        gbAltaCliente.Controls.Add(btnAgregarCliente)
        gbAltaCliente.Controls.Add(Label3)
        gbAltaCliente.Controls.Add(Label2)
        gbAltaCliente.Controls.Add(Label1)
        gbAltaCliente.Location = New Point(12, 27)
        gbAltaCliente.Name = "gbAltaCliente"
        gbAltaCliente.Size = New Size(363, 393)
        gbAltaCliente.TabIndex = 1
        gbAltaCliente.TabStop = False
        gbAltaCliente.Text = "Alta cliente"
        gbAltaCliente.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 15)
        Label6.TabIndex = 7
        Label6.Text = "Ingrese los datos del cliente"
        ' 
        ' txtbTelefono
        ' 
        txtbTelefono.Location = New Point(70, 101)
        txtbTelefono.Name = "txtbTelefono"
        txtbTelefono.Size = New Size(100, 23)
        txtbTelefono.TabIndex = 6
        ' 
        ' txtbCorreo
        ' 
        txtbCorreo.Location = New Point(69, 72)
        txtbCorreo.Name = "txtbCorreo"
        txtbCorreo.Size = New Size(100, 23)
        txtbCorreo.TabIndex = 5
        ' 
        ' txtbNombre
        ' 
        txtbNombre.Location = New Point(69, 43)
        txtbNombre.Name = "txtbNombre"
        txtbNombre.Size = New Size(100, 23)
        txtbNombre.TabIndex = 4
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Location = New Point(282, 364)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(75, 23)
        btnAgregarCliente.TabIndex = 3
        btnAgregarCliente.Text = "Agregar Cliente"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Correo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 1
        Label2.Text = "Telefono"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' gbBajaCliente
        ' 
        gbBajaCliente.Controls.Add(btnBajaCliente)
        gbBajaCliente.Controls.Add(DataGridView1)
        gbBajaCliente.Controls.Add(Label5)
        gbBajaCliente.Location = New Point(12, 27)
        gbBajaCliente.Name = "gbBajaCliente"
        gbBajaCliente.Size = New Size(363, 393)
        gbBajaCliente.TabIndex = 0
        gbBajaCliente.TabStop = False
        gbBajaCliente.Text = "Baja Cliente"
        gbBajaCliente.Visible = False
        ' 
        ' btnBajaCliente
        ' 
        btnBajaCliente.Location = New Point(282, 364)
        btnBajaCliente.Name = "btnBajaCliente"
        btnBajaCliente.Size = New Size(75, 23)
        btnBajaCliente.TabIndex = 1
        btnBajaCliente.Text = "Dar de Baja"
        btnBajaCliente.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ClienteDataGridViewTextBoxColumn, TelefonoDataGridViewTextBoxColumn, CorreoDataGridViewTextBoxColumn})
        DataGridView1.DataSource = ClienteBindingSource
        DataGridView1.Location = New Point(6, 37)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(351, 321)
        DataGridView1.TabIndex = 0
        ' 
        ' ClienteDataGridViewTextBoxColumn
        ' 
        ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        ClienteDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' TelefonoDataGridViewTextBoxColumn
        ' 
        TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' CorreoDataGridViewTextBoxColumn
        ' 
        CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        CorreoDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' ClienteBindingSource
        ' 
        ClienteBindingSource.DataSource = GetType(Objetos.Cliente)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(348, 15)
        Label5.TabIndex = 2
        Label5.Text = "Para dar de baja seleccione la casilla deseada y se eliminará la fila"
        ' 
        ' gbModificarCliente
        ' 
        gbModificarCliente.Controls.Add(Label4)
        gbModificarCliente.Controls.Add(DataGridView2)
        gbModificarCliente.Location = New Point(12, 27)
        gbModificarCliente.Name = "gbModificarCliente"
        gbModificarCliente.Size = New Size(363, 393)
        gbModificarCliente.TabIndex = 2
        gbModificarCliente.TabStop = False
        gbModificarCliente.Text = "Modificar Cliente"
        gbModificarCliente.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(235, 15)
        Label4.TabIndex = 1
        Label4.Text = "Para modificar seleccione la casilla deseada"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.AutoGenerateColumns = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {ClienteDataGridViewTextBoxColumn1, TelefonoDataGridViewTextBoxColumn1, CorreoDataGridViewTextBoxColumn1})
        DataGridView2.DataSource = ClienteBindingSource
        DataGridView2.Location = New Point(6, 37)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(351, 350)
        DataGridView2.TabIndex = 0
        ' 
        ' ClienteDataGridViewTextBoxColumn1
        ' 
        ClienteDataGridViewTextBoxColumn1.DataPropertyName = "Cliente"
        ClienteDataGridViewTextBoxColumn1.HeaderText = "Cliente"
        ClienteDataGridViewTextBoxColumn1.Name = "ClienteDataGridViewTextBoxColumn1"
        ' 
        ' TelefonoDataGridViewTextBoxColumn1
        ' 
        TelefonoDataGridViewTextBoxColumn1.DataPropertyName = "Telefono"
        TelefonoDataGridViewTextBoxColumn1.HeaderText = "Telefono"
        TelefonoDataGridViewTextBoxColumn1.Name = "TelefonoDataGridViewTextBoxColumn1"
        ' 
        ' CorreoDataGridViewTextBoxColumn1
        ' 
        CorreoDataGridViewTextBoxColumn1.DataPropertyName = "Correo"
        CorreoDataGridViewTextBoxColumn1.HeaderText = "Correo"
        CorreoDataGridViewTextBoxColumn1.Name = "CorreoDataGridViewTextBoxColumn1"
        ' 
        ' gbAltaProducto
        ' 
        gbAltaProducto.Controls.Add(labelError)
        gbAltaProducto.Controls.Add(Label10)
        gbAltaProducto.Controls.Add(btnAltaProducto)
        gbAltaProducto.Controls.Add(txtbCategoria)
        gbAltaProducto.Controls.Add(txtbPrecio)
        gbAltaProducto.Controls.Add(txtbProducto)
        gbAltaProducto.Controls.Add(Label9)
        gbAltaProducto.Controls.Add(Label8)
        gbAltaProducto.Controls.Add(Label7)
        gbAltaProducto.Location = New Point(12, 27)
        gbAltaProducto.Name = "gbAltaProducto"
        gbAltaProducto.Size = New Size(363, 393)
        gbAltaProducto.TabIndex = 3
        gbAltaProducto.TabStop = False
        gbAltaProducto.Text = "Alta Producto"
        gbAltaProducto.Visible = False
        ' 
        ' labelError
        ' 
        labelError.AutoSize = True
        labelError.ForeColor = Color.Red
        labelError.Location = New Point(190, 75)
        labelError.Name = "labelError"
        labelError.Size = New Size(0, 15)
        labelError.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(166, 15)
        Label10.TabIndex = 7
        Label10.Text = "Ingrese los datos del producto"
        ' 
        ' btnAltaProducto
        ' 
        btnAltaProducto.Location = New Point(279, 364)
        btnAltaProducto.Name = "btnAltaProducto"
        btnAltaProducto.Size = New Size(75, 23)
        btnAltaProducto.TabIndex = 6
        btnAltaProducto.Text = "Dar de alta"
        btnAltaProducto.UseVisualStyleBackColor = True
        ' 
        ' txtbCategoria
        ' 
        txtbCategoria.Location = New Point(84, 101)
        txtbCategoria.Name = "txtbCategoria"
        txtbCategoria.Size = New Size(100, 23)
        txtbCategoria.TabIndex = 5
        ' 
        ' txtbPrecio
        ' 
        txtbPrecio.Location = New Point(84, 72)
        txtbPrecio.Name = "txtbPrecio"
        txtbPrecio.Size = New Size(100, 23)
        txtbPrecio.TabIndex = 4
        ' 
        ' txtbProducto
        ' 
        txtbProducto.Location = New Point(84, 43)
        txtbProducto.Name = "txtbProducto"
        txtbProducto.Size = New Size(100, 23)
        txtbProducto.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(20, 104)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 15)
        Label9.TabIndex = 2
        Label9.Text = "Categoría"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(20, 75)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 15)
        Label8.TabIndex = 1
        Label8.Text = "Precio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(20, 46)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 15)
        Label7.TabIndex = 0
        Label7.Text = "Producto"
        ' 
        ' gbVentas
        ' 
        gbVentas.Controls.Add(btnNuevaVenta)
        gbVentas.Controls.Add(DataGridView3)
        gbVentas.Controls.Add(MonthCalendar1)
        gbVentas.Location = New Point(12, 27)
        gbVentas.Name = "gbVentas"
        gbVentas.Size = New Size(363, 393)
        gbVentas.TabIndex = 9
        gbVentas.TabStop = False
        gbVentas.Text = "Ventas"
        gbVentas.Visible = False
        ' 
        ' btnNuevaVenta
        ' 
        btnNuevaVenta.Location = New Point(266, 193)
        btnNuevaVenta.Name = "btnNuevaVenta"
        btnNuevaVenta.Size = New Size(96, 23)
        btnNuevaVenta.TabIndex = 3
        btnNuevaVenta.Text = "Nueva Venta"
        btnNuevaVenta.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.AllowUserToResizeColumns = False
        DataGridView3.AllowUserToResizeRows = False
        DataGridView3.AutoGenerateColumns = False
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {CantidadDataGridViewTextBoxColumn, NombreDataGridViewTextBoxColumn})
        DataGridView3.DataSource = ProductoDetalladoBindingSource
        DataGridView3.Location = New Point(12, 193)
        DataGridView3.MultiSelect = False
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView3.Size = New Size(248, 194)
        DataGridView3.TabIndex = 1
        ' 
        ' CantidadDataGridViewTextBoxColumn
        ' 
        CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        CantidadDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' NombreDataGridViewTextBoxColumn
        ' 
        NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        NombreDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' ProductoDetalladoBindingSource
        ' 
        ProductoDetalladoBindingSource.DataSource = GetType(Objetos.ProductoDetallado)
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(12, 19)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' VentasBindingSource
        ' 
        VentasBindingSource.DataSource = GetType(Objetos.Ventas)
        ' 
        ' Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(387, 432)
        Controls.Add(MenuStrip1)
        Controls.Add(gbVentas)
        Controls.Add(gbAltaProducto)
        Controls.Add(gbBajaCliente)
        Controls.Add(gbAltaCliente)
        Controls.Add(gbModificarCliente)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form"
        Text = "Examen"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        gbAltaCliente.ResumeLayout(False)
        gbAltaCliente.PerformLayout()
        gbBajaCliente.ResumeLayout(False)
        gbBajaCliente.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ClienteBindingSource, ComponentModel.ISupportInitialize).EndInit()
        gbModificarCliente.ResumeLayout(False)
        gbModificarCliente.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        gbAltaProducto.ResumeLayout(False)
        gbAltaProducto.PerformLayout()
        gbVentas.ResumeLayout(False)
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(ProductoDetalladoBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(VentasBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbAltaCliente As GroupBox
    Friend WithEvents gbBajaCliente As GroupBox
    Friend WithEvents txtbTelefono As TextBox
    Friend WithEvents txtbCorreo As TextBox
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnBajaCliente As Button
    Friend WithEvents gbModificarCliente As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ClienteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents gbAltaProducto As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAltaProducto As Button
    Friend WithEvents txtbCategoria As TextBox
    Friend WithEvents txtbPrecio As TextBox
    Friend WithEvents txtbProducto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents labelError As Label
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbVentas As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents ProductoDetalladoBindingSource As BindingSource
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn

End Class
