<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Caja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMonto = New System.Windows.Forms.TextBox()
        Me.ButtonModificarPago = New System.Windows.Forms.Button()
        Me.ButtonEliminarPago = New System.Windows.Forms.Button()
        Me.ButtonAgregarPago = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.TextBoxCouta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DNI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NOMBRE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.APELLIDO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewPagos = New System.Windows.Forms.ListView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxBusca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxIdCliente = New System.Windows.Forms.ComboBox()
        Me.TextBoxFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NACIMIENTO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SEXO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TELEFONO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CIUDAD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewConsultaCaja = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto"
        '
        'TextBoxMonto
        '
        Me.TextBoxMonto.Location = New System.Drawing.Point(166, 103)
        Me.TextBoxMonto.Name = "TextBoxMonto"
        Me.TextBoxMonto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMonto.TabIndex = 1
        '
        'ButtonModificarPago
        '
        Me.ButtonModificarPago.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarPago.Location = New System.Drawing.Point(155, 151)
        Me.ButtonModificarPago.Name = "ButtonModificarPago"
        Me.ButtonModificarPago.Size = New System.Drawing.Size(110, 23)
        Me.ButtonModificarPago.TabIndex = 14
        Me.ButtonModificarPago.Text = "Modificar Pago"
        Me.ButtonModificarPago.UseVisualStyleBackColor = False
        '
        'ButtonEliminarPago
        '
        Me.ButtonEliminarPago.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarPago.Location = New System.Drawing.Point(271, 151)
        Me.ButtonEliminarPago.Name = "ButtonEliminarPago"
        Me.ButtonEliminarPago.Size = New System.Drawing.Size(110, 23)
        Me.ButtonEliminarPago.TabIndex = 13
        Me.ButtonEliminarPago.Text = "Eliminar Pago"
        Me.ButtonEliminarPago.UseVisualStyleBackColor = False
        '
        'ButtonAgregarPago
        '
        Me.ButtonAgregarPago.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarPago.Location = New System.Drawing.Point(39, 151)
        Me.ButtonAgregarPago.Name = "ButtonAgregarPago"
        Me.ButtonAgregarPago.Size = New System.Drawing.Size(110, 23)
        Me.ButtonAgregarPago.TabIndex = 12
        Me.ButtonAgregarPago.Text = "Agregar Pago"
        Me.ButtonAgregarPago.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.Location = New System.Drawing.Point(707, 2)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 72)
        Me.ButtonCerrar.TabIndex = 22
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'TextBoxCouta
        '
        Me.TextBoxCouta.Location = New System.Drawing.Point(166, 46)
        Me.TextBoxCouta.Name = "TextBoxCouta"
        Me.TextBoxCouta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCouta.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cuota"
        '
        'ID
        '
        Me.ID.Text = "ID_CLIENTE"
        '
        'DNI
        '
        Me.DNI.Text = "ID Cuota"
        '
        'NOMBRE
        '
        Me.NOMBRE.Text = "Fecha"
        '
        'APELLIDO
        '
        Me.APELLIDO.Text = "Monto"
        '
        'ListViewPagos
        '
        Me.ListViewPagos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.DNI, Me.NOMBRE, Me.APELLIDO})
        Me.ListViewPagos.HideSelection = False
        Me.ListViewPagos.Location = New System.Drawing.Point(396, 255)
        Me.ListViewPagos.Name = "ListViewPagos"
        Me.ListViewPagos.Size = New System.Drawing.Size(376, 318)
        Me.ListViewPagos.TabIndex = 29
        Me.ListViewPagos.UseCompatibleStateImageBehavior = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "ID CLIENTE"
        '
        'TextBoxBusca
        '
        Me.TextBoxBusca.Location = New System.Drawing.Point(308, 603)
        Me.TextBoxBusca.Name = "TextBoxBusca"
        Me.TextBoxBusca.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBusca.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(249, 606)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Apellido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxIdCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxMonto)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregarPago)
        Me.GroupBox1.Controls.Add(Me.ButtonEliminarPago)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ButtonModificarPago)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxCouta)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 201)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha"
        '
        'ComboBoxIdCliente
        '
        Me.ComboBoxIdCliente.FormattingEnabled = True
        Me.ComboBoxIdCliente.Location = New System.Drawing.Point(166, 14)
        Me.ComboBoxIdCliente.Name = "ComboBoxIdCliente"
        Me.ComboBoxIdCliente.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxIdCliente.TabIndex = 33
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.Location = New System.Drawing.Point(166, 72)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxFecha.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(414, 606)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "*Presione ENTER para restablecer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Clientes"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DNI"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "NOMBRE"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "APELLIDO"
        '
        'NACIMIENTO
        '
        Me.NACIMIENTO.Text = "NACIMIENTO"
        '
        'SEXO
        '
        Me.SEXO.Text = "SEXO"
        '
        'TELEFONO
        '
        Me.TELEFONO.Text = "TELEFONO"
        '
        'CIUDAD
        '
        Me.CIUDAD.Text = "CIUDAD"
        '
        'ListViewConsultaCaja
        '
        Me.ListViewConsultaCaja.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.NACIMIENTO, Me.SEXO, Me.TELEFONO, Me.CIUDAD})
        Me.ListViewConsultaCaja.HideSelection = False
        Me.ListViewConsultaCaja.Location = New System.Drawing.Point(12, 255)
        Me.ListViewConsultaCaja.Name = "ListViewConsultaCaja"
        Me.ListViewConsultaCaja.Size = New System.Drawing.Size(376, 318)
        Me.ListViewConsultaCaja.TabIndex = 44
        Me.ListViewConsultaCaja.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(592, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Pagos"
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListViewConsultaCaja)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBusca)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListViewPagos)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "n"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMonto As TextBox
    Friend WithEvents ButtonModificarPago As Button
    Friend WithEvents ButtonEliminarPago As Button
    Friend WithEvents ButtonAgregarPago As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents TextBoxCouta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents DNI As ColumnHeader
    Friend WithEvents NOMBRE As ColumnHeader
    Friend WithEvents APELLIDO As ColumnHeader
    Friend WithEvents ListViewPagos As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxBusca As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxFecha As DateTimePicker
    Friend WithEvents ComboBoxIdCliente As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents NACIMIENTO As ColumnHeader
    Friend WithEvents SEXO As ColumnHeader
    Friend WithEvents TELEFONO As ColumnHeader
    Friend WithEvents CIUDAD As ColumnHeader
    Friend WithEvents ListViewConsultaCaja As ListView
    Friend WithEvents Label5 As Label
End Class
