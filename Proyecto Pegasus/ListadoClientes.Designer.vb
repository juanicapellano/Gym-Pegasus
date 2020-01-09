<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoClientes
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
        Me.ListViewClientes = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxApellidolistado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListViewClientes
        '
        Me.ListViewClientes.Location = New System.Drawing.Point(12, 93)
        Me.ListViewClientes.Name = "ListViewClientes"
        Me.ListViewClientes.Size = New System.Drawing.Size(298, 345)
        Me.ListViewClientes.TabIndex = 0
        Me.ListViewClientes.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apellido"
        '
        'TextBoxApellidolistado
        '
        Me.TextBoxApellidolistado.Location = New System.Drawing.Point(131, 26)
        Me.TextBoxApellidolistado.Name = "TextBoxApellidolistado"
        Me.TextBoxApellidolistado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellidolistado.TabIndex = 2
        '
        'ListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(322, 450)
        Me.Controls.Add(Me.TextBoxApellidolistado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewClientes)
        Me.Name = "ListadoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ListadoClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewClientes As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxApellidolistado As TextBox
End Class
