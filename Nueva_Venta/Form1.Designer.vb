<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        lTotalVenta = New Label()
        Label5 = New Label()
        lbListaDeProductos = New ListBox()
        GroupBox2 = New GroupBox()
        labelError = New Label()
        lTotal = New Label()
        btnAgregarProductoVenta = New Button()
        txtbCantidad = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        cbProducto = New ComboBox()
        Label2 = New Label()
        cbCliente = New ComboBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(lTotalVenta)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(lbListaDeProductos)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(cbCliente)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(363, 408)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nueva venta"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(282, 379)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lTotalVenta
        ' 
        lTotalVenta.AutoSize = True
        lTotalVenta.Location = New Point(47, 379)
        lTotalVenta.Name = "lTotalVenta"
        lTotalVenta.Size = New Size(34, 15)
        lTotalVenta.TabIndex = 5
        lTotalVenta.Text = "0.00$"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 379)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 4
        Label5.Text = "Total:"
        ' 
        ' lbListaDeProductos
        ' 
        lbListaDeProductos.FormattingEnabled = True
        lbListaDeProductos.ItemHeight = 15
        lbListaDeProductos.Location = New Point(6, 171)
        lbListaDeProductos.Name = "lbListaDeProductos"
        lbListaDeProductos.Size = New Size(351, 199)
        lbListaDeProductos.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(labelError)
        GroupBox2.Controls.Add(lTotal)
        GroupBox2.Controls.Add(btnAgregarProductoVenta)
        GroupBox2.Controls.Add(txtbCantidad)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(cbProducto)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(6, 51)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(351, 114)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Producto"
        ' 
        ' labelError
        ' 
        labelError.AutoSize = True
        labelError.ForeColor = Color.Red
        labelError.Location = New Point(203, 57)
        labelError.Name = "labelError"
        labelError.Size = New Size(0, 15)
        labelError.TabIndex = 7
        ' 
        ' lTotal
        ' 
        lTotal.AutoSize = True
        lTotal.Location = New Point(252, 28)
        lTotal.Name = "lTotal"
        lTotal.Size = New Size(34, 15)
        lTotal.TabIndex = 6
        lTotal.Text = "0.00$"
        ' 
        ' btnAgregarProductoVenta
        ' 
        btnAgregarProductoVenta.Location = New Point(11, 83)
        btnAgregarProductoVenta.Name = "btnAgregarProductoVenta"
        btnAgregarProductoVenta.Size = New Size(162, 23)
        btnAgregarProductoVenta.TabIndex = 5
        btnAgregarProductoVenta.Text = "Agregar producto a la venta"
        btnAgregarProductoVenta.UseVisualStyleBackColor = True
        ' 
        ' txtbCantidad
        ' 
        txtbCantidad.Location = New Point(73, 54)
        txtbCantidad.Name = "txtbCantidad"
        txtbCantidad.Size = New Size(121, 23)
        txtbCantidad.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 3
        Label4.Text = "Cantidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(203, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Precio:"
        ' 
        ' cbProducto
        ' 
        cbProducto.FormattingEnabled = True
        cbProducto.Location = New Point(73, 25)
        cbProducto.Name = "cbProducto"
        cbProducto.Size = New Size(121, 23)
        cbProducto.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 0
        Label2.Text = "Producto"
        ' 
        ' cbCliente
        ' 
        cbCliente.FormattingEnabled = True
        cbCliente.Location = New Point(79, 22)
        cbCliente.Name = "cbCliente"
        cbCliente.Size = New Size(121, 23)
        cbCliente.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(387, 432)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "Form1"
        Text = "Nueva Venta"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtbCantidad As TextBox
    Friend WithEvents btnAgregarProductoVenta As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbListaDeProductos As ListBox
    Friend WithEvents lTotal As Label
    Friend WithEvents lTotalVenta As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents labelError As Label

End Class
