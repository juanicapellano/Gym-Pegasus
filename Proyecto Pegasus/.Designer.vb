<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.CiudadProfesor = New System.Windows.Forms.TextBox()
        Me.CelularProfesor = New System.Windows.Forms.TextBox()
        Me.DocumentoProfesor = New System.Windows.Forms.TextBox()
        Me.ApellidoProfesor = New System.Windows.Forms.TextBox()
        Me.NombreProfesor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonModificarProfesor = New System.Windows.Forms.Button()
        Me.ButtonEliminarProfesor = New System.Windows.Forms.Button()
        Me.ButtonAgregarProfesor = New System.Windows.Forms.Button()
        Me.ComboBoxSueldoProfesor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.ListBoxP = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Documento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Numero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ciudad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IDPROfesor = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxApellidolistado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Sueldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiudadProfesor
        '
        Me.CiudadProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadProfesor.Location = New System.Drawing.Point(215, 179)
        Me.CiudadProfesor.Name = "CiudadProfesor"
        Me.CiudadProfesor.Size = New System.Drawing.Size(100, 26)
        Me.CiudadProfesor.TabIndex = 31
        '
        'CelularProfesor
        '
        Me.CelularProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CelularProfesor.Location = New System.Drawing.Point(215, 149)
        Me.CelularProfesor.Name = "CelularProfesor"
        Me.CelularProfesor.Size = New System.Drawing.Size(100, 26)
        Me.CelularProfesor.TabIndex = 30
        '
        'DocumentoProfesor
        '
        Me.DocumentoProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentoProfesor.Location = New System.Drawing.Point(215, 120)
        Me.DocumentoProfesor.Name = "DocumentoProfesor"
        Me.DocumentoProfesor.Size = New System.Drawing.Size(100, 26)
        Me.DocumentoProfesor.TabIndex = 29
        '
        'ApellidoProfesor
        '
        Me.ApellidoProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoProfesor.Location = New System.Drawing.Point(215, 92)
        Me.ApellidoProfesor.Name = "ApellidoProfesor"
        Me.ApellidoProfesor.Size = New System.Drawing.Size(100, 26)
        Me.ApellidoProfesor.TabIndex = 28
        '
        'NombreProfesor
        '
        Me.NombreProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProfesor.Location = New System.Drawing.Point(215, 64)
        Me.NombreProfesor.Name = "NombreProfesor"
        Me.NombreProfesor.Size = New System.Drawing.Size(100, 26)
        Me.NombreProfesor.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Numero telefonico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Documento de identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nombres"
        '
        'ButtonModificarProfesor
        '
        Me.ButtonModificarProfesor.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarProfesor.Image = Global.Proyecto_Pegasus.My.Resources.Resources.users1
        Me.ButtonModificarProfesor.Location = New System.Drawing.Point(360, 315)
        Me.ButtonModificarProfesor.Name = "ButtonModificarProfesor"
        Me.ButtonModificarProfesor.Size = New System.Drawing.Size(85, 69)
        Me.ButtonModificarProfesor.TabIndex = 20
        Me.ButtonModificarProfesor.UseVisualStyleBackColor = False
        '
        'ButtonEliminarProfesor
        '
        Me.ButtonEliminarProfesor.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarProfesor.Image = Global.Proyecto_Pegasus.My.Resources.Resources.user_4_remove1
        Me.ButtonEliminarProfesor.Location = New System.Drawing.Point(468, 315)
        Me.ButtonEliminarProfesor.Name = "ButtonEliminarProfesor"
        Me.ButtonEliminarProfesor.Size = New System.Drawing.Size(85, 69)
        Me.ButtonEliminarProfesor.TabIndex = 19
        Me.ButtonEliminarProfesor.UseVisualStyleBackColor = False
        '
        'ButtonAgregarProfesor
        '
        Me.ButtonAgregarProfesor.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarProfesor.Image = Global.Proyecto_Pegasus.My.Resources.Resources.user_4_add1
        Me.ButtonAgregarProfesor.Location = New System.Drawing.Point(255, 315)
        Me.ButtonAgregarProfesor.Name = "ButtonAgregarProfesor"
        Me.ButtonAgregarProfesor.Size = New System.Drawing.Size(85, 69)
        Me.ButtonAgregarProfesor.TabIndex = 18
        Me.ButtonAgregarProfesor.UseVisualStyleBackColor = False
        '
        'ComboBoxSueldoProfesor
        '
        Me.ComboBoxSueldoProfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSueldoProfesor.FormattingEnabled = True
        Me.ComboBoxSueldoProfesor.Location = New System.Drawing.Point(215, 211)
        Me.ComboBoxSueldoProfesor.Name = "ComboBoxSueldoProfesor"
        Me.ComboBoxSueldoProfesor.Size = New System.Drawing.Size(100, 26)
        Me.ComboBoxSueldoProfesor.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(356, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Profesores"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Sueldo"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.Location = New System.Drawing.Point(725, -2)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 72)
        Me.ButtonCerrar.TabIndex = 37
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'ListBoxP
        '
        Me.ListBoxP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nombre, Me.Apellido, Me.Documento, Me.Numero, Me.Ciudad, Me.Sueldo})
        Me.ListBoxP.HideSelection = False
        Me.ListBoxP.Location = New System.Drawing.Point(-1, 413)
        Me.ListBoxP.Name = "ListBoxP"
        Me.ListBoxP.Size = New System.Drawing.Size(801, 224)
        Me.ListBoxP.TabIndex = 38
        Me.ListBoxP.UseCompatibleStateImageBehavior = False
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.Text = "Apellido"
        '
        'Documento
        '
        Me.Documento.Text = "Documento"
        '
        'Numero
        '
        Me.Numero.Text = "Numero"
        '
        'Ciudad
        '
        Me.Ciudad.Text = "Ciudad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.IDPROfesor)
        Me.GroupBox1.Controls.Add(Me.DocumentoProfesor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSueldoProfesor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CiudadProfesor)
        Me.GroupBox1.Controls.Add(Me.NombreProfesor)
        Me.GroupBox1.Controls.Add(Me.CelularProfesor)
        Me.GroupBox1.Controls.Add(Me.ApellidoProfesor)
        Me.GroupBox1.Location = New System.Drawing.Point(238, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 245)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 18)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "ID"
        '
        'IDPROfesor
        '
        Me.IDPROfesor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPROfesor.Location = New System.Drawing.Point(215, 32)
        Me.IDPROfesor.Name = "IDPROfesor"
        Me.IDPROfesor.Size = New System.Drawing.Size(100, 26)
        Me.IDPROfesor.TabIndex = 37
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(0, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 128)
        Me.Label8.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 32)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Empleados"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(436, 656)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "*Presione ENTER para restablecer"
        '
        'TextBoxApellidolistado
        '
        Me.TextBoxApellidolistado.Location = New System.Drawing.Point(330, 653)
        Me.TextBoxApellidolistado.Name = "TextBoxApellidolistado"
        Me.TextBoxApellidolistado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellidolistado.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(227, 656)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Buscar por apellido"
        '
        'Sueldo
        '
        Me.Sueldo.Text = "Sueldo"
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 700)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBoxApellidolistado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBoxP)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonModificarProfesor)
        Me.Controls.Add(Me.ButtonEliminarProfesor)
        Me.Controls.Add(Me.ButtonAgregarProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CiudadProfesor As TextBox
    Friend WithEvents CelularProfesor As TextBox
    Friend WithEvents DocumentoProfesor As TextBox
    Friend WithEvents ApellidoProfesor As TextBox
    Friend WithEvents NombreProfesor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonModificarProfesor As Button
    Friend WithEvents ButtonEliminarProfesor As Button
    Friend WithEvents ButtonAgregarProfesor As Button
    Friend WithEvents ComboBoxSueldoProfesor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents ListBoxP As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Apellido As ColumnHeader
    Friend WithEvents Documento As ColumnHeader
    Friend WithEvents Numero As ColumnHeader
    Friend WithEvents Ciudad As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxApellidolistado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents IDPROfesor As TextBox
    Friend WithEvents Sueldo As ColumnHeader
End Class
