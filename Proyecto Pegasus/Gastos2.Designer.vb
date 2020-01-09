<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gastos2))
        Me.ID = New System.Windows.Forms.Label()
        Me.TextBoxSueldo1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxBuscaDetalleaparatos1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxBuscaDetallegasto1 = New System.Windows.Forms.TextBox()
        Me.ListViewSueldo1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ListViewGastos1 = New System.Windows.Forms.ListView()
        Me.fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListViewAparatos1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxIdAparato1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonModificarAparato1 = New System.Windows.Forms.Button()
        Me.ButtonEliminarAparato1 = New System.Windows.Forms.Button()
        Me.ButtonAgregarAparato1 = New System.Windows.Forms.Button()
        Me.TextBoxNombreAparato1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxDetalleAparato1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxIdSueldo1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonModificarSueldo1 = New System.Windows.Forms.Button()
        Me.ButtonEliminarSueldo1 = New System.Windows.Forms.Button()
        Me.ButtonAgregarSueldo1 = New System.Windows.Forms.Button()
        Me.TextBoxMontoSueldo1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonCerrarGastos = New System.Windows.Forms.Button()
        Me.TextBoxIDCompra1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonModificarCompra1 = New System.Windows.Forms.Button()
        Me.ButtonEliminarCompra1 = New System.Windows.Forms.Button()
        Me.ButtonAgregarCompra1 = New System.Windows.Forms.Button()
        Me.TextBoxFechaCompra1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDetalleCompra1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(176, 260)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 95
        Me.ID.Text = "ID"
        '
        'TextBoxSueldo1
        '
        Me.TextBoxSueldo1.Location = New System.Drawing.Point(230, 257)
        Me.TextBoxSueldo1.Name = "TextBoxSueldo1"
        Me.TextBoxSueldo1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSueldo1.TabIndex = 94
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 376)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Detalle"
        '
        'TextBoxBuscaDetalleaparatos1
        '
        Me.TextBoxBuscaDetalleaparatos1.Location = New System.Drawing.Point(138, 376)
        Me.TextBoxBuscaDetalleaparatos1.Name = "TextBoxBuscaDetalleaparatos1"
        Me.TextBoxBuscaDetalleaparatos1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscaDetalleaparatos1.TabIndex = 92
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(45, 385)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Detalle"
        '
        'TextBoxBuscaDetallegasto1
        '
        Me.TextBoxBuscaDetallegasto1.Location = New System.Drawing.Point(141, 385)
        Me.TextBoxBuscaDetallegasto1.Name = "TextBoxBuscaDetallegasto1"
        Me.TextBoxBuscaDetallegasto1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscaDetallegasto1.TabIndex = 90
        '
        'ListViewSueldo1
        '
        Me.ListViewSueldo1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewSueldo1.HideSelection = False
        Me.ListViewSueldo1.Location = New System.Drawing.Point(419, 28)
        Me.ListViewSueldo1.Name = "ListViewSueldo1"
        Me.ListViewSueldo1.Size = New System.Drawing.Size(211, 175)
        Me.ListViewSueldo1.TabIndex = 89
        Me.ListViewSueldo1.UseCompatibleStateImageBehavior = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(380, 485)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Sueldos"
        '
        'ListViewGastos1
        '
        Me.ListViewGastos1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.fecha, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewGastos1.HideSelection = False
        Me.ListViewGastos1.Location = New System.Drawing.Point(51, 204)
        Me.ListViewGastos1.Name = "ListViewGastos1"
        Me.ListViewGastos1.Size = New System.Drawing.Size(211, 175)
        Me.ListViewGastos1.TabIndex = 87
        Me.ListViewGastos1.UseCompatibleStateImageBehavior = False
        '
        'fecha
        '
        Me.fecha.Text = "fecha"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "id"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "detalle"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(103, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Compras / Gastos"
        '
        'ListViewAparatos1
        '
        Me.ListViewAparatos1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewAparatos1.HideSelection = False
        Me.ListViewAparatos1.Location = New System.Drawing.Point(45, 195)
        Me.ListViewAparatos1.Name = "ListViewAparatos1"
        Me.ListViewAparatos1.Size = New System.Drawing.Size(211, 175)
        Me.ListViewAparatos1.TabIndex = 85
        Me.ListViewAparatos1.UseCompatibleStateImageBehavior = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(118, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Aparatos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Aparatos"
        '
        'TextBoxIdAparato1
        '
        Me.TextBoxIdAparato1.Location = New System.Drawing.Point(117, 32)
        Me.TextBoxIdAparato1.Name = "TextBoxIdAparato1"
        Me.TextBoxIdAparato1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIdAparato1.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "ID"
        '
        'ButtonModificarAparato1
        '
        Me.ButtonModificarAparato1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarAparato1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarAparato1.Location = New System.Drawing.Point(99, 142)
        Me.ButtonModificarAparato1.Name = "ButtonModificarAparato1"
        Me.ButtonModificarAparato1.Size = New System.Drawing.Size(94, 23)
        Me.ButtonModificarAparato1.TabIndex = 80
        Me.ButtonModificarAparato1.Text = "Modificar"
        Me.ButtonModificarAparato1.UseVisualStyleBackColor = False
        '
        'ButtonEliminarAparato1
        '
        Me.ButtonEliminarAparato1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminarAparato1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarAparato1.Location = New System.Drawing.Point(199, 142)
        Me.ButtonEliminarAparato1.Name = "ButtonEliminarAparato1"
        Me.ButtonEliminarAparato1.Size = New System.Drawing.Size(85, 23)
        Me.ButtonEliminarAparato1.TabIndex = 79
        Me.ButtonEliminarAparato1.Text = "Eliminar"
        Me.ButtonEliminarAparato1.UseVisualStyleBackColor = False
        '
        'ButtonAgregarAparato1
        '
        Me.ButtonAgregarAparato1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarAparato1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarAparato1.Location = New System.Drawing.Point(4, 142)
        Me.ButtonAgregarAparato1.Name = "ButtonAgregarAparato1"
        Me.ButtonAgregarAparato1.Size = New System.Drawing.Size(89, 23)
        Me.ButtonAgregarAparato1.TabIndex = 78
        Me.ButtonAgregarAparato1.Text = "Agregar"
        Me.ButtonAgregarAparato1.UseVisualStyleBackColor = False
        '
        'TextBoxNombreAparato1
        '
        Me.TextBoxNombreAparato1.Location = New System.Drawing.Point(117, 65)
        Me.TextBoxNombreAparato1.Name = "TextBoxNombreAparato1"
        Me.TextBoxNombreAparato1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombreAparato1.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Aparato"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Detalle"
        '
        'TextBoxDetalleAparato1
        '
        Me.TextBoxDetalleAparato1.Location = New System.Drawing.Point(117, 96)
        Me.TextBoxDetalleAparato1.Name = "TextBoxDetalleAparato1"
        Me.TextBoxDetalleAparato1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDetalleAparato1.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(503, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Sueldos"
        '
        'TextBoxIdSueldo1
        '
        Me.TextBoxIdSueldo1.Location = New System.Drawing.Point(156, 42)
        Me.TextBoxIdSueldo1.Name = "TextBoxIdSueldo1"
        Me.TextBoxIdSueldo1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIdSueldo1.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "ID"
        '
        'ButtonModificarSueldo1
        '
        Me.ButtonModificarSueldo1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarSueldo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarSueldo1.Location = New System.Drawing.Point(130, 123)
        Me.ButtonModificarSueldo1.Name = "ButtonModificarSueldo1"
        Me.ButtonModificarSueldo1.Size = New System.Drawing.Size(94, 23)
        Me.ButtonModificarSueldo1.TabIndex = 70
        Me.ButtonModificarSueldo1.Text = "Modificar "
        Me.ButtonModificarSueldo1.UseVisualStyleBackColor = False
        '
        'ButtonEliminarSueldo1
        '
        Me.ButtonEliminarSueldo1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminarSueldo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarSueldo1.Location = New System.Drawing.Point(230, 123)
        Me.ButtonEliminarSueldo1.Name = "ButtonEliminarSueldo1"
        Me.ButtonEliminarSueldo1.Size = New System.Drawing.Size(85, 23)
        Me.ButtonEliminarSueldo1.TabIndex = 69
        Me.ButtonEliminarSueldo1.Text = "Eliminar"
        Me.ButtonEliminarSueldo1.UseVisualStyleBackColor = False
        '
        'ButtonAgregarSueldo1
        '
        Me.ButtonAgregarSueldo1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarSueldo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarSueldo1.Location = New System.Drawing.Point(35, 123)
        Me.ButtonAgregarSueldo1.Name = "ButtonAgregarSueldo1"
        Me.ButtonAgregarSueldo1.Size = New System.Drawing.Size(89, 23)
        Me.ButtonAgregarSueldo1.TabIndex = 68
        Me.ButtonAgregarSueldo1.Text = "Agregar "
        Me.ButtonAgregarSueldo1.UseVisualStyleBackColor = False
        '
        'TextBoxMontoSueldo1
        '
        Me.TextBoxMontoSueldo1.Location = New System.Drawing.Point(156, 71)
        Me.TextBoxMontoSueldo1.Name = "TextBoxMontoSueldo1"
        Me.TextBoxMontoSueldo1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMontoSueldo1.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Monto del Sueldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Compras / Gastos"
        '
        'ButtonCerrarGastos
        '
        Me.ButtonCerrarGastos.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCerrarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrarGastos.Image = CType(resources.GetObject("ButtonCerrarGastos.Image"), System.Drawing.Image)
        Me.ButtonCerrarGastos.Location = New System.Drawing.Point(705, 5)
        Me.ButtonCerrarGastos.Name = "ButtonCerrarGastos"
        Me.ButtonCerrarGastos.Size = New System.Drawing.Size(75, 72)
        Me.ButtonCerrarGastos.TabIndex = 64
        Me.ButtonCerrarGastos.UseVisualStyleBackColor = False
        '
        'TextBoxIDCompra1
        '
        Me.TextBoxIDCompra1.Location = New System.Drawing.Point(124, 45)
        Me.TextBoxIDCompra1.Name = "TextBoxIDCompra1"
        Me.TextBoxIDCompra1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDCompra1.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "ID"
        '
        'ButtonModificarCompra1
        '
        Me.ButtonModificarCompra1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarCompra1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarCompra1.Location = New System.Drawing.Point(117, 151)
        Me.ButtonModificarCompra1.Name = "ButtonModificarCompra1"
        Me.ButtonModificarCompra1.Size = New System.Drawing.Size(94, 23)
        Me.ButtonModificarCompra1.TabIndex = 61
        Me.ButtonModificarCompra1.Text = "Modificar "
        Me.ButtonModificarCompra1.UseVisualStyleBackColor = False
        '
        'ButtonEliminarCompra1
        '
        Me.ButtonEliminarCompra1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminarCompra1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarCompra1.Location = New System.Drawing.Point(217, 151)
        Me.ButtonEliminarCompra1.Name = "ButtonEliminarCompra1"
        Me.ButtonEliminarCompra1.Size = New System.Drawing.Size(91, 23)
        Me.ButtonEliminarCompra1.TabIndex = 60
        Me.ButtonEliminarCompra1.Text = "Eliminar "
        Me.ButtonEliminarCompra1.UseVisualStyleBackColor = False
        '
        'ButtonAgregarCompra1
        '
        Me.ButtonAgregarCompra1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarCompra1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarCompra1.Location = New System.Drawing.Point(11, 151)
        Me.ButtonAgregarCompra1.Name = "ButtonAgregarCompra1"
        Me.ButtonAgregarCompra1.Size = New System.Drawing.Size(100, 23)
        Me.ButtonAgregarCompra1.TabIndex = 59
        Me.ButtonAgregarCompra1.Text = "Agregar"
        Me.ButtonAgregarCompra1.UseVisualStyleBackColor = False
        '
        'TextBoxFechaCompra1
        '
        Me.TextBoxFechaCompra1.Location = New System.Drawing.Point(124, 74)
        Me.TextBoxFechaCompra1.Name = "TextBoxFechaCompra1"
        Me.TextBoxFechaCompra1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFechaCompra1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Fecha de compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Detalle"
        '
        'TextBoxDetalleCompra1
        '
        Me.TextBoxDetalleCompra1.Location = New System.Drawing.Point(124, 105)
        Me.TextBoxDetalleCompra1.Name = "TextBoxDetalleCompra1"
        Me.TextBoxDetalleCompra1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDetalleCompra1.TabIndex = 55
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListViewGastos1)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetalleCompra1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxFechaCompra1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregarCompra1)
        Me.GroupBox1.Controls.Add(Me.TextBoxBuscaDetallegasto1)
        Me.GroupBox1.Controls.Add(Me.ButtonEliminarCompra1)
        Me.GroupBox1.Controls.Add(Me.ButtonModificarCompra1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDCompra1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 426)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewAparatos1)
        Me.GroupBox2.Controls.Add(Me.TextBoxDetalleAparato1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBoxBuscaDetalleaparatos1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBoxNombreAparato1)
        Me.GroupBox2.Controls.Add(Me.ButtonAgregarAparato1)
        Me.GroupBox2.Controls.Add(Me.ButtonEliminarAparato1)
        Me.GroupBox2.Controls.Add(Me.ButtonModificarAparato1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBoxIdAparato1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 426)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ficha"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListViewSueldo1)
        Me.GroupBox3.Controls.Add(Me.ID)
        Me.GroupBox3.Controls.Add(Me.TextBoxSueldo1)
        Me.GroupBox3.Controls.Add(Me.TextBoxMontoSueldo1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBoxIdSueldo1)
        Me.GroupBox3.Controls.Add(Me.ButtonAgregarSueldo1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ButtonEliminarSueldo1)
        Me.GroupBox3.Controls.Add(Me.ButtonModificarSueldo1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 446)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 203)
        Me.GroupBox3.TabIndex = 92
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ficha"
        '
        'Gastos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 656)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ButtonCerrarGastos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Gastos2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gastos2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID As Label
    Friend WithEvents TextBoxSueldo1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxBuscaDetalleaparatos1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxBuscaDetallegasto1 As TextBox
    Friend WithEvents ListViewSueldo1 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label14 As Label
    Friend WithEvents ListViewGastos1 As ListView
    Friend WithEvents fecha As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents ListViewAparatos1 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxIdAparato1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonModificarAparato1 As Button
    Friend WithEvents ButtonEliminarAparato1 As Button
    Friend WithEvents ButtonAgregarAparato1 As Button
    Friend WithEvents TextBoxNombreAparato1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxDetalleAparato1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxIdSueldo1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonModificarSueldo1 As Button
    Friend WithEvents ButtonEliminarSueldo1 As Button
    Friend WithEvents ButtonAgregarSueldo1 As Button
    Friend WithEvents TextBoxMontoSueldo1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonCerrarGastos As Button
    Friend WithEvents TextBoxIDCompra1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonModificarCompra1 As Button
    Friend WithEvents ButtonEliminarCompra1 As Button
    Friend WithEvents ButtonAgregarCompra1 As Button
    Friend WithEvents TextBoxFechaCompra1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDetalleCompra1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
