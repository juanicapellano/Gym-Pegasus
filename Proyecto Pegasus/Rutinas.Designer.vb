<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rutinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rutinas))
        Me.ButtonModificarRutina = New System.Windows.Forms.Button()
        Me.ButtonEliminarRutina = New System.Windows.Forms.Button()
        Me.ButtonAgregarRutina = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.TextBoxDetalleRutina = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxIDrutina = New System.Windows.Forms.TextBox()
        Me.ListViewRutina = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxBuscaDetalleRutina = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonModificarRutina
        '
        Me.ButtonModificarRutina.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarRutina.Image = Global.Proyecto_Pegasus.My.Resources.Resources.browser_windows1
        Me.ButtonModificarRutina.Location = New System.Drawing.Point(321, 152)
        Me.ButtonModificarRutina.Name = "ButtonModificarRutina"
        Me.ButtonModificarRutina.Size = New System.Drawing.Size(86, 71)
        Me.ButtonModificarRutina.TabIndex = 6
        Me.ButtonModificarRutina.UseVisualStyleBackColor = False
        '
        'ButtonEliminarRutina
        '
        Me.ButtonEliminarRutina.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminarRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarRutina.Image = Global.Proyecto_Pegasus.My.Resources.Resources.cross1
        Me.ButtonEliminarRutina.Location = New System.Drawing.Point(413, 152)
        Me.ButtonEliminarRutina.Name = "ButtonEliminarRutina"
        Me.ButtonEliminarRutina.Size = New System.Drawing.Size(86, 71)
        Me.ButtonEliminarRutina.TabIndex = 5
        Me.ButtonEliminarRutina.UseVisualStyleBackColor = False
        '
        'ButtonAgregarRutina
        '
        Me.ButtonAgregarRutina.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarRutina.Image = Global.Proyecto_Pegasus.My.Resources.Resources.browser_new_window_21
        Me.ButtonAgregarRutina.Location = New System.Drawing.Point(229, 152)
        Me.ButtonAgregarRutina.Name = "ButtonAgregarRutina"
        Me.ButtonAgregarRutina.Size = New System.Drawing.Size(86, 71)
        Me.ButtonAgregarRutina.TabIndex = 4
        Me.ButtonAgregarRutina.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Rutinas"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.Location = New System.Drawing.Point(709, -4)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 72)
        Me.ButtonCerrar.TabIndex = 21
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'TextBoxDetalleRutina
        '
        Me.TextBoxDetalleRutina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDetalleRutina.Location = New System.Drawing.Point(130, 48)
        Me.TextBoxDetalleRutina.Name = "TextBoxDetalleRutina"
        Me.TextBoxDetalleRutina.Size = New System.Drawing.Size(134, 26)
        Me.TextBoxDetalleRutina.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Detalles"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "ID"
        '
        'TextBoxIDrutina
        '
        Me.TextBoxIDrutina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDrutina.Location = New System.Drawing.Point(130, 16)
        Me.TextBoxIDrutina.Name = "TextBoxIDrutina"
        Me.TextBoxIDrutina.Size = New System.Drawing.Size(134, 26)
        Me.TextBoxIDrutina.TabIndex = 31
        '
        'ListViewRutina
        '
        Me.ListViewRutina.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewRutina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewRutina.HideSelection = False
        Me.ListViewRutina.Location = New System.Drawing.Point(103, 272)
        Me.ListViewRutina.Name = "ListViewRutina"
        Me.ListViewRutina.Size = New System.Drawing.Size(533, 226)
        Me.ListViewRutina.TabIndex = 32
        Me.ListViewRutina.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 507)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Detalles"
        '
        'TextBoxBuscaDetalleRutina
        '
        Me.TextBoxBuscaDetalleRutina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscaDetalleRutina.Location = New System.Drawing.Point(284, 504)
        Me.TextBoxBuscaDetalleRutina.Name = "TextBoxBuscaDetalleRutina"
        Me.TextBoxBuscaDetalleRutina.Size = New System.Drawing.Size(134, 26)
        Me.TextBoxBuscaDetalleRutina.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDetalleRutina)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDrutina)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 78)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(424, 512)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "*Presione ENTER para restablecer"
        '
        'Rutinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBuscaDetalleRutina)
        Me.Controls.Add(Me.ListViewRutina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonModificarRutina)
        Me.Controls.Add(Me.ButtonEliminarRutina)
        Me.Controls.Add(Me.ButtonAgregarRutina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rutinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rutinas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonModificarRutina As Button
    Friend WithEvents ButtonEliminarRutina As Button
    Friend WithEvents ButtonAgregarRutina As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents TextBoxDetalleRutina As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxIDrutina As TextBox
    Friend WithEvents ListViewRutina As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxBuscaDetalleRutina As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
End Class
