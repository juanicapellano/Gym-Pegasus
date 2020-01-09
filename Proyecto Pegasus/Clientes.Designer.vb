<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.ButtonEliminarCliente = New System.Windows.Forms.Button()
        Me.ButtonModificarCliente = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxApellidolistado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListViewClientes = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DNI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NOMBRE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.APELLIDO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NACIMIENTO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SEXO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TELEFONO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CIUDAD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBoxCliente = New System.Windows.Forms.PictureBox()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.ButtonAgregarCliente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxIDCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimeCliente = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonMasculinoCliente = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemeninoCliente = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxCiudadCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxDNICliente = New System.Windows.Forms.TextBox()
        Me.TextBoxApellidoCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.ComboBoxRutinaCliente = New System.Windows.Forms.ComboBox()
        Me.ComboBoxModalidadCliente = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonEliminarCliente
        '
        Me.ButtonEliminarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarCliente.Image = Global.Proyecto_Pegasus.My.Resources.Resources.user_4_remove1
        Me.ButtonEliminarCliente.Location = New System.Drawing.Point(457, 284)
        Me.ButtonEliminarCliente.Name = "ButtonEliminarCliente"
        Me.ButtonEliminarCliente.Size = New System.Drawing.Size(78, 72)
        Me.ButtonEliminarCliente.TabIndex = 1
        Me.ButtonEliminarCliente.UseVisualStyleBackColor = False
        '
        'ButtonModificarCliente
        '
        Me.ButtonModificarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarCliente.Image = Global.Proyecto_Pegasus.My.Resources.Resources.database_add1
        Me.ButtonModificarCliente.Location = New System.Drawing.Point(355, 284)
        Me.ButtonModificarCliente.Name = "ButtonModificarCliente"
        Me.ButtonModificarCliente.Size = New System.Drawing.Size(85, 72)
        Me.ButtonModificarCliente.TabIndex = 2
        Me.ButtonModificarCliente.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(0, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 128)
        Me.Label9.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 32)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Clientes"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxApellidolistado
        '
        Me.TextBoxApellidolistado.Location = New System.Drawing.Point(335, 613)
        Me.TextBoxApellidolistado.Name = "TextBoxApellidolistado"
        Me.TextBoxApellidolistado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellidolistado.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(232, 616)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Buscar por apellido"
        '
        'ListViewClientes
        '
        Me.ListViewClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.DNI, Me.NOMBRE, Me.APELLIDO, Me.NACIMIENTO, Me.SEXO, Me.TELEFONO, Me.CIUDAD})
        Me.ListViewClientes.HideSelection = False
        Me.ListViewClientes.Location = New System.Drawing.Point(0, 362)
        Me.ListViewClientes.Name = "ListViewClientes"
        Me.ListViewClientes.Size = New System.Drawing.Size(800, 204)
        Me.ListViewClientes.TabIndex = 39
        Me.ListViewClientes.UseCompatibleStateImageBehavior = False
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'DNI
        '
        Me.DNI.Text = "DNI"
        '
        'NOMBRE
        '
        Me.NOMBRE.Text = "NOMBRE"
        '
        'APELLIDO
        '
        Me.APELLIDO.Text = "APELLIDO"
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(441, 616)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "*Presione ENTER para restablecer"
        '
        'PictureBoxCliente
        '
        Me.PictureBoxCliente.Image = CType(resources.GetObject("PictureBoxCliente.Image"), System.Drawing.Image)
        Me.PictureBoxCliente.Location = New System.Drawing.Point(21, 49)
        Me.PictureBoxCliente.Name = "PictureBoxCliente"
        Me.PictureBoxCliente.Size = New System.Drawing.Size(64, 64)
        Me.PictureBoxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxCliente.TabIndex = 30
        Me.PictureBoxCliente.TabStop = False
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.Location = New System.Drawing.Point(725, 0)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 72)
        Me.ButtonCerrar.TabIndex = 20
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'ButtonAgregarCliente
        '
        Me.ButtonAgregarCliente.AutoSize = True
        Me.ButtonAgregarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarCliente.Image = Global.Proyecto_Pegasus.My.Resources.Resources.user_2_add1
        Me.ButtonAgregarCliente.Location = New System.Drawing.Point(268, 284)
        Me.ButtonAgregarCliente.Name = "ButtonAgregarCliente"
        Me.ButtonAgregarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonAgregarCliente.Size = New System.Drawing.Size(72, 72)
        Me.ButtonAgregarCliente.TabIndex = 0
        Me.ButtonAgregarCliente.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxIDCliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DateTimeCliente)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMasculinoCliente)
        Me.GroupBox1.Controls.Add(Me.RadioButtonFemeninoCliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBoxCiudadCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelefonoCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxDNICliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxApellidoCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombreCliente)
        Me.GroupBox1.Controls.Add(Me.ComboBoxRutinaCliente)
        Me.GroupBox1.Controls.Add(Me.ComboBoxModalidadCliente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 272)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha"
        '
        'TextBoxIDCliente
        '
        Me.TextBoxIDCliente.Location = New System.Drawing.Point(163, 36)
        Me.TextBoxIDCliente.Name = "TextBoxIDCliente"
        Me.TextBoxIDCliente.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxIDCliente.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 18)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Número de Cliente"
        '
        'DateTimeCliente
        '
        Me.DateTimeCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeCliente.Location = New System.Drawing.Point(453, 67)
        Me.DateTimeCliente.Name = "DateTimeCliente"
        Me.DateTimeCliente.Size = New System.Drawing.Size(121, 26)
        Me.DateTimeCliente.TabIndex = 63
        Me.DateTimeCliente.Value = New Date(2019, 8, 26, 21, 51, 18, 0)
        '
        'RadioButtonMasculinoCliente
        '
        Me.RadioButtonMasculinoCliente.AutoSize = True
        Me.RadioButtonMasculinoCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMasculinoCliente.Location = New System.Drawing.Point(188, 189)
        Me.RadioButtonMasculinoCliente.Name = "RadioButtonMasculinoCliente"
        Me.RadioButtonMasculinoCliente.Size = New System.Drawing.Size(96, 22)
        Me.RadioButtonMasculinoCliente.TabIndex = 62
        Me.RadioButtonMasculinoCliente.TabStop = True
        Me.RadioButtonMasculinoCliente.Text = "Masculino"
        Me.RadioButtonMasculinoCliente.UseVisualStyleBackColor = True
        '
        'RadioButtonFemeninoCliente
        '
        Me.RadioButtonFemeninoCliente.AutoSize = True
        Me.RadioButtonFemeninoCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFemeninoCliente.Location = New System.Drawing.Point(76, 189)
        Me.RadioButtonFemeninoCliente.Name = "RadioButtonFemeninoCliente"
        Me.RadioButtonFemeninoCliente.Size = New System.Drawing.Size(96, 22)
        Me.RadioButtonFemeninoCliente.TabIndex = 61
        Me.RadioButtonFemeninoCliente.TabStop = True
        Me.RadioButtonFemeninoCliente.Text = "Femenino"
        Me.RadioButtonFemeninoCliente.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Sexo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(313, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 18)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Fecha Nacimiento"
        '
        'TextBoxCiudadCliente
        '
        Me.TextBoxCiudadCliente.Location = New System.Drawing.Point(453, 110)
        Me.TextBoxCiudadCliente.Name = "TextBoxCiudadCliente"
        Me.TextBoxCiudadCliente.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxCiudadCliente.TabIndex = 58
        '
        'TextBoxTelefonoCliente
        '
        Me.TextBoxTelefonoCliente.Location = New System.Drawing.Point(453, 36)
        Me.TextBoxTelefonoCliente.Name = "TextBoxTelefonoCliente"
        Me.TextBoxTelefonoCliente.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxTelefonoCliente.TabIndex = 57
        '
        'TextBoxDNICliente
        '
        Me.TextBoxDNICliente.Location = New System.Drawing.Point(163, 148)
        Me.TextBoxDNICliente.Name = "TextBoxDNICliente"
        Me.TextBoxDNICliente.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxDNICliente.TabIndex = 56
        '
        'TextBoxApellidoCliente
        '
        Me.TextBoxApellidoCliente.Location = New System.Drawing.Point(163, 113)
        Me.TextBoxApellidoCliente.Name = "TextBoxApellidoCliente"
        Me.TextBoxApellidoCliente.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxApellidoCliente.TabIndex = 55
        '
        'TextBoxNombreCliente
        '
        Me.TextBoxNombreCliente.Location = New System.Drawing.Point(163, 74)
        Me.TextBoxNombreCliente.Name = "TextBoxNombreCliente"
        Me.TextBoxNombreCliente.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxNombreCliente.TabIndex = 54
        '
        'ComboBoxRutinaCliente
        '
        Me.ComboBoxRutinaCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRutinaCliente.FormattingEnabled = True
        Me.ComboBoxRutinaCliente.Location = New System.Drawing.Point(453, 190)
        Me.ComboBoxRutinaCliente.Name = "ComboBoxRutinaCliente"
        Me.ComboBoxRutinaCliente.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxRutinaCliente.TabIndex = 53
        '
        'ComboBoxModalidadCliente
        '
        Me.ComboBoxModalidadCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxModalidadCliente.FormattingEnabled = True
        Me.ComboBoxModalidadCliente.Location = New System.Drawing.Point(453, 148)
        Me.ComboBoxModalidadCliente.Name = "ComboBoxModalidadCliente"
        Me.ComboBoxModalidadCliente.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxModalidadCliente.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Rutina"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 18)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Número telefónico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Modalidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Nombres"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 700)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBoxApellidolistado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ListViewClientes)
        Me.Controls.Add(Me.PictureBoxCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonModificarCliente)
        Me.Controls.Add(Me.ButtonEliminarCliente)
        Me.Controls.Add(Me.ButtonAgregarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clientes"
        CType(Me.PictureBoxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAgregarCliente As Button
    Friend WithEvents ButtonEliminarCliente As Button
    Friend WithEvents ButtonModificarCliente As Button
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents PictureBoxCliente As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxApellidolistado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ListViewClientes As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents DNI As ColumnHeader
    Friend WithEvents NOMBRE As ColumnHeader
    Friend WithEvents APELLIDO As ColumnHeader
    Friend WithEvents NACIMIENTO As ColumnHeader
    Friend WithEvents SEXO As ColumnHeader
    Friend WithEvents TELEFONO As ColumnHeader
    Friend WithEvents Label14 As Label
    Friend WithEvents CIUDAD As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxIDCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimeCliente As DateTimePicker
    Friend WithEvents RadioButtonMasculinoCliente As RadioButton
    Friend WithEvents RadioButtonFemeninoCliente As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxCiudadCliente As TextBox
    Friend WithEvents TextBoxTelefonoCliente As TextBox
    Friend WithEvents TextBoxDNICliente As TextBox
    Friend WithEvents TextBoxApellidoCliente As TextBox
    Friend WithEvents TextBoxNombreCliente As TextBox
    Friend WithEvents ComboBoxRutinaCliente As ComboBox
    Friend WithEvents ComboBoxModalidadCliente As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
