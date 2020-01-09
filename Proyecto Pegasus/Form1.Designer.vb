<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListViewClientesInicio = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ButtonEmpleados = New System.Windows.Forms.Button()
        Me.ButtonCaja = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LabelEmpleados = New System.Windows.Forms.Label()
        Me.LabelPagos = New System.Windows.Forms.Label()
        Me.LabelCaja = New System.Windows.Forms.Label()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.ButtonRutinas = New System.Windows.Forms.Button()
        Me.ButtonGastos = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Groupbox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewClientesInicio
        '
        Me.ListViewClientesInicio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Apellido, Me.Fecha})
        Me.ListViewClientesInicio.HideSelection = False
        Me.ListViewClientesInicio.Location = New System.Drawing.Point(187, 296)
        Me.ListViewClientesInicio.Name = "ListViewClientesInicio"
        Me.ListViewClientesInicio.Size = New System.Drawing.Size(450, 452)
        Me.ListViewClientesInicio.TabIndex = 0
        Me.ListViewClientesInicio.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(187, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(301, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Empleados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(415, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pagos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(529, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Caja"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(187, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 128)
        Me.Label5.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(301, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 128)
        Me.Label6.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(415, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 128)
        Me.Label7.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(529, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 128)
        Me.Label8.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(-8, -14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 845)
        Me.Label10.TabIndex = 10
        '
        'ButtonClientes
        '
        Me.ButtonClientes.FlatAppearance.BorderSize = 0
        Me.ButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClientes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientes.Location = New System.Drawing.Point(0, 163)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(158, 30)
        Me.ButtonClientes.TabIndex = 11
        Me.ButtonClientes.Text = "Clientes"
        Me.ButtonClientes.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(186, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 27)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Sumario"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ButtonEmpleados
        '
        Me.ButtonEmpleados.FlatAppearance.BorderSize = 0
        Me.ButtonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEmpleados.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ButtonEmpleados.Location = New System.Drawing.Point(0, 199)
        Me.ButtonEmpleados.Name = "ButtonEmpleados"
        Me.ButtonEmpleados.Size = New System.Drawing.Size(158, 30)
        Me.ButtonEmpleados.TabIndex = 13
        Me.ButtonEmpleados.Text = "Empleados"
        Me.ButtonEmpleados.UseVisualStyleBackColor = True
        '
        'ButtonCaja
        '
        Me.ButtonCaja.FlatAppearance.BorderSize = 0
        Me.ButtonCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCaja.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ButtonCaja.Location = New System.Drawing.Point(0, 235)
        Me.ButtonCaja.Name = "ButtonCaja"
        Me.ButtonCaja.Size = New System.Drawing.Size(158, 30)
        Me.ButtonCaja.TabIndex = 14
        Me.ButtonCaja.Text = "Caja"
        Me.ButtonCaja.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(185, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 33)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(158, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(322, 129)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(441, 129)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(551, 129)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'LabelEmpleados
        '
        Me.LabelEmpleados.AutoSize = True
        Me.LabelEmpleados.Location = New System.Drawing.Point(339, 209)
        Me.LabelEmpleados.Name = "LabelEmpleados"
        Me.LabelEmpleados.Size = New System.Drawing.Size(25, 13)
        Me.LabelEmpleados.TabIndex = 20
        Me.LabelEmpleados.Text = "100"
        '
        'LabelPagos
        '
        Me.LabelPagos.AutoSize = True
        Me.LabelPagos.Location = New System.Drawing.Point(454, 211)
        Me.LabelPagos.Name = "LabelPagos"
        Me.LabelPagos.Size = New System.Drawing.Size(25, 13)
        Me.LabelPagos.TabIndex = 21
        Me.LabelPagos.Text = "100"
        '
        'LabelCaja
        '
        Me.LabelCaja.AutoSize = True
        Me.LabelCaja.Location = New System.Drawing.Point(568, 211)
        Me.LabelCaja.Name = "LabelCaja"
        Me.LabelCaja.Size = New System.Drawing.Size(25, 13)
        Me.LabelCaja.TabIndex = 22
        Me.LabelCaja.Text = "100"
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Location = New System.Drawing.Point(222, 211)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(25, 13)
        Me.LabelClientes.TabIndex = 23
        Me.LabelClientes.Text = "100"
        '
        'ButtonRutinas
        '
        Me.ButtonRutinas.FlatAppearance.BorderSize = 0
        Me.ButtonRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRutinas.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ButtonRutinas.Location = New System.Drawing.Point(0, 271)
        Me.ButtonRutinas.Name = "ButtonRutinas"
        Me.ButtonRutinas.Size = New System.Drawing.Size(158, 30)
        Me.ButtonRutinas.TabIndex = 24
        Me.ButtonRutinas.Text = "Rutinas"
        Me.ButtonRutinas.UseVisualStyleBackColor = True
        '
        'ButtonGastos
        '
        Me.ButtonGastos.FlatAppearance.BorderSize = 0
        Me.ButtonGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGastos.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ButtonGastos.Location = New System.Drawing.Point(0, 307)
        Me.ButtonGastos.Name = "ButtonGastos"
        Me.ButtonGastos.Size = New System.Drawing.Size(158, 30)
        Me.ButtonGastos.TabIndex = 25
        Me.ButtonGastos.Text = "Gastos"
        Me.ButtonGastos.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(206, 129)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(42, 31)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(64, 46)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 27
        Me.PictureBox6.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(19, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 22)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Administrador"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(35, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 17)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "2352-482870"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(152, 145)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 30
        Me.PictureBox7.TabStop = False
        '
        'Groupbox1
        '
        Me.Groupbox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Groupbox1.Controls.Add(Me.PictureBox6)
        Me.Groupbox1.Controls.Add(Me.Label17)
        Me.Groupbox1.Controls.Add(Me.Label18)
        Me.Groupbox1.Location = New System.Drawing.Point(3, 614)
        Me.Groupbox1.Name = "Groupbox1"
        Me.Groupbox1.Size = New System.Drawing.Size(153, 134)
        Me.Groupbox1.TabIndex = 31
        Me.Groupbox1.TabStop = False
        Me.Groupbox1.Text = "Contaco"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1028, 749)
        Me.Controls.Add(Me.Groupbox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.ButtonGastos)
        Me.Controls.Add(Me.ButtonRutinas)
        Me.Controls.Add(Me.LabelClientes)
        Me.Controls.Add(Me.LabelCaja)
        Me.Controls.Add(Me.LabelPagos)
        Me.Controls.Add(Me.LabelEmpleados)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ButtonCaja)
        Me.Controls.Add(Me.ButtonEmpleados)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ButtonClientes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewClientesInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Pegasus"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupbox1.ResumeLayout(False)
        Me.Groupbox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewClientesInicio As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ButtonEmpleados As Button
    Friend WithEvents ButtonCaja As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LabelEmpleados As Label
    Friend WithEvents LabelPagos As Label
    Friend WithEvents LabelCaja As Label
    Friend WithEvents LabelClientes As Label
    Friend WithEvents ButtonRutinas As Button
    Friend WithEvents ButtonGastos As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Apellido As ColumnHeader
    Friend WithEvents Fecha As ColumnHeader
    Friend WithEvents Groupbox1 As GroupBox
End Class
