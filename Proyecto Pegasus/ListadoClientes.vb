Imports MySql.Data.MySqlClient
Public Class ListadoClientes
    Private Sub ListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListViewClientes.View = View.Details
        ListViewClientes.GridLines = True
        ListViewClientes.HideSelection = False
        ListViewClientes.FullRowSelect = True
        ListViewClientes.MultiSelect = False
        ListViewClientes.Items.Clear()
        BDconsulta = "" ' sql
        listarclientes() ' sub
    End Sub
    Private Sub listarclientes()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdclientes As New MySqlCommand(BDconsulta, BDconexion)
            Dim readclientes As MySqlDataReader
            readclientes = cmdclientes.ExecuteReader()
            ListViewClientes.Items.Clear()
            Do While readclientes.Read()
                Dim fila As ListViewItem
                fila = ListViewClientes.Items.Add(readclientes("codigo"))
                fila.SubItems.Add(readclientes("producto"))
                fila.SubItems.Add(readclientes("precio"))
                fila.SubItems.Add(readclientes("stock"))
                fila.SubItems.Add(readclientes("idrubro"))

            Loop
            readclientes.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
    End Sub

    Private Sub ListViewClientes_DoubleClick(sender As Object, e As EventArgs) Handles ListViewClientes.DoubleClick
        If ListViewClientes.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewClientes.SelectedIndices
                ' Clientes.TextBoxApellidoCliente = ListViewClientes.Items(i).SubItems(0).Text
                Clientes.TextBoxCiudadCliente.Text = ListViewClientes.Items(i).SubItems(1).Text
                Clientes.TextBoxDNICliente.Text = ListViewClientes.Items(i).SubItems(2).Text
                Clientes.TextBoxNombreCliente.Text = ListViewClientes.Items(i).SubItems(3).Text
                '   Clientes.TextBoxTelefonoCliente = ListViewClientes.Items(i).SubItems(4).Text
                Clientes.CargarComboModalidad()
                Clientes.CargarComboModalidad()
                BDopcion = 1 ' selecciona modificar

            Next
        End If
        Me.Close()
    End Sub

    Private Sub TextBoxApellidolistado_TextChanged(sender As Object, e As EventArgs) Handles TextBoxApellidolistado.TextChanged
        If Char.IsLetter(TextBoxApellidolistado.Text) Then
            BDconsulta = "select * from clientes where producto like '" + TextBoxApellidolistado.Text + "%'order by apellido"
            listarclientes()
        ElseIf Not Char.IsControl(TextBoxApellidolistado.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxApellidolistado.Clear()
        End If
    End Sub
    Private Sub TextBoxproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxApellidolistado.KeyPress
        If Asc(e.KeyChar) = 13 Then 'cuando el usuario presiona enter
            BDconsulta = "select * from clientes"
            listarclientes()
        End If
    End Sub
End Class