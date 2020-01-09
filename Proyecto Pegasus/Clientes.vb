Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Clientes
    '---------------------opciones de cierre----------------------------'
    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
    Private Sub Clientes_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub
    Private Sub TextBoxNombreCliente_LostFocus(sender As Object, e As EventArgs)
        If Not IsNumeric(TextBoxApellidoCliente.Text) Then

        ElseIf Not Char.IsControl(TextBoxNombreCliente.Text) Then
            MsgBox("Debe ingresar un cliente existente", MsgBoxStyle.Information, "JCapellano")
        End If

    End Sub

    '----------------------AMB de Clientes----------------------------'
    ' Case 1: Agregar Case 2: Modificar Case 3 Eliminar
    Private Sub ambclientes()

        Select Case BDopcion 'No funciona modificar

            Case 0 : BDconsulta = "insert into cliente value ( " + TextBoxIDCliente.Text + ",'" + TextBoxNombreCliente.Text + "','" + TextBoxApellidoCliente.Text + "'," + TextBoxDNICliente.Text + "," + TextBoxTelefonoCliente.Text + ",'" + TextBoxCiudadCliente.Text + "','" + DateTimeCliente.Value.ToString("yyyy-MM-dd") + "','" + vargenero.ToString + "','" + ComboBoxModalidadCliente.SelectedValue.ToString + "','" + ComboBoxRutinaCliente.SelectedValue.ToString + "')"
            Case 1 : BDconsulta = "update cliente set id_cliente='nombre=" + TextBoxNombreCliente.Text + "',apellido='" + TextBoxApellidoCliente.Text + "',dni=" + TextBoxDNICliente.Text + ",telefono=" + TextBoxTelefonoCliente.Text + ",ciudad='" + TextBoxCiudadCliente.Text + "',fechanac='" + DateTimeCliente.Value.ToString("yyyy-MM-dd") + "',sexo='" + vargenero.ToString + "',id_modalidad='" + ComboBoxModalidadCliente.SelectedValue.ToString + "',id_rutina='" + ComboBoxRutinaCliente.SelectedValue.ToString + "'where id_cliente=" + TextBoxIDCliente.Text
            Case 2 : BDconsulta = "delete from cliente where id_cliente=" + TextBoxIDCliente.Text
        End Select

        Try

            BDconexion.Open()
            Dim cmdcliente As New MySqlCommand(BDconsulta, BDconexion)
            cmdcliente.ExecuteNonQuery()
            Select Case BDopcion
                Case 0 : MsgBox("Cliente agregado", MsgBoxStyle.Information)
                Case 1 : MsgBox("Cliente actualizado", MsgBoxStyle.Information)
                    TextBoxIDCliente.Enabled = False
                    ButtonAgregarCliente.Enabled = False
                Case 2 : MsgBox("Cliente eliminado", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()

        End Try
        'Blanquear los texbox .clear y poner el focus
    End Sub
    'Busco la ficha del cliente para cargar
    Private Sub cliente()

    End Sub

    '----- Cargar combo de Modalidad -------'


    Sub CargarComboModalidad()
        Try
            Dim AModalidad As New MySqlDataAdapter("select * from modalidad order by id_modalidad", ModuloConexion.BDconexion)
            Dim tablamodalidad As New DataTable("id_modalidad")
            AModalidad.Fill(tablamodalidad)
            ComboBoxModalidadCliente.DataSource = tablamodalidad
            ComboBoxModalidadCliente.DisplayMember = "detalle"
            ComboBoxModalidadCliente.ValueMember = "id_modalidad"
            ComboBoxModalidadCliente.SelectedValue = ModuloConexion.BDcombo

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    '----- Cargar combo de Rutina -------'
    Sub cargarComboRutina()
        Try
            Dim aRutina As New MySqlDataAdapter("select * from rutina order by id_rutina", ModuloConexion.BDconexion)
            Dim tablarutina As New DataTable("id_rutina")
            aRutina.Fill(tablarutina)
            ComboBoxRutinaCliente.DataSource = tablarutina
            ComboBoxRutinaCliente.DisplayMember = "detalle"
            ComboBoxRutinaCliente.ValueMember = "id_rutina"
            ComboBoxRutinaCliente.SelectedValue = ModuloConexion.BDcombo
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    '--------- Botones -----------'
    Private Sub ButtonAgregarCliente_Click(sender As Object, e As EventArgs) Handles ButtonAgregarCliente.Click
        If TextBoxApellidoCliente.Text = "" Or TextBoxCiudadCliente.Text = "" Or TextBoxDNICliente.Text = "" Or TextBoxNombreCliente.Text = "" Or TextBoxTelefonoCliente.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")
        Else
            BDopcion = 0 ' 0 es agregar
            ambclientes()
        End If
    End Sub

    Private Sub ButtonModificarCliente_Click(sender As Object, e As EventArgs) Handles ButtonModificarCliente.Click
        If TextBoxApellidoCliente.Text = "" Or TextBoxCiudadCliente.Text = "" Or TextBoxDNICliente.Text = "" Or TextBoxNombreCliente.Text = "" Or TextBoxTelefonoCliente.Text = "" Or ComboBoxModalidadCliente.Text = "" Or ComboBoxRutinaCliente.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 1 ' 1 es modificar
            ambclientes()
        End If
    End Sub

    Private Sub ButtonEliminarCliente_Click(sender As Object, e As EventArgs) Handles ButtonEliminarCliente.Click
        If TextBoxApellidoCliente.Text = "" Or TextBoxCiudadCliente.Text = "" Or TextBoxDNICliente.Text = "" Or TextBoxNombreCliente.Text = "" Or TextBoxTelefonoCliente.Text = "" Or ComboBoxModalidadCliente.Text = "" Or ComboBoxRutinaCliente.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 2 ' 3 es eliminar
            ambclientes()
        End If
    End Sub

    Private Sub ButtonConsultaCliente_Click(sender As Object, e As EventArgs)
        ListadoClientes.Location = New Point(180, 65)
        ListadoClientes.Show() ' mostrar ventana lista
    End Sub

    '------------radio button GENERO------------'
    Dim vargenero As String = "Femenino"
    Private Sub RadioButtonFemeninoCliente_CheckedChanged(sender As Object, e As EventArgs)
        vargenero = "Femenino"
    End Sub

    Private Sub RadioButtonMasculinoCliente_CheckedChanged(sender As Object, e As EventArgs)
        vargenero = "Masculino"
    End Sub

    ' ------------------------------LISTA DE CLIENTES---------------------------------'


    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewClientes.View = View.Details
        ListViewClientes.GridLines = True
        ListViewClientes.HideSelection = False
        ListViewClientes.FullRowSelect = True
        ListViewClientes.MultiSelect = False
        ListViewClientes.Items.Clear()
        BDconsulta = "select * from cliente"
        listarclientes() ' sub
        CargarComboModalidad() 'Cargo el combo Modalidad
        cargarComboRutina() ' Cargo el combo Rutina


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
                fila = ListViewClientes.Items.Add(readclientes("id_cliente"))
                fila.SubItems.Add(readclientes("dni"))
                fila.SubItems.Add(readclientes("nombre"))
                fila.SubItems.Add(readclientes("apellido"))
                fila.SubItems.Add(readclientes("fechanac"))
                fila.SubItems.Add(readclientes("sexo"))
                fila.SubItems.Add(readclientes("telefono"))
                fila.SubItems.Add(readclientes("ciudad"))
            Loop
            readclientes.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
    End Sub

    Private Sub TextBoxApellidolistado_TextChanged(sender As Object, e As EventArgs) Handles TextBoxApellidolistado.TextChanged
        If Char.IsLetter(TextBoxApellidolistado.Text) Then
            BDconsulta = "select * from cliente where apellido like '" + TextBoxApellidolistado.Text + "%'order by apellido"
            listarclientes()
        ElseIf Not Char.IsControl(TextBoxApellidolistado.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxApellidolistado.Clear()
        End If
    End Sub
    Private Sub TextBoxproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxApellidolistado.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Cuando el USUARIO presiona ENTER
            BDconsulta = "select * from cliente"
            listarclientes()
        End If
    End Sub

    Private Sub ListViewClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewClientes.SelectedIndexChanged

    End Sub

    Private Sub ListViewClientes_DoubleClick(sender As Object, e As EventArgs) Handles ListViewClientes.DoubleClick
        If ListViewClientes.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewClientes.SelectedIndices
                TextBoxIDCliente.Text = ListViewClientes.Items(i).SubItems(0).Text
                TextBoxNombreCliente.Text = ListViewClientes.Items(i).SubItems(2).Text
                TextBoxApellidoCliente.Text = ListViewClientes.Items(i).SubItems(3).Text
                TextBoxDNICliente.Text = ListViewClientes.Items(i).SubItems(1).Text
                vargenero = ListViewClientes.Items(i).SubItems(5).Text
                TextBoxTelefonoCliente.Text = ListViewClientes.Items(i).SubItems(6).Text
                DateTimeCliente.Text = ListViewClientes.Items(i).SubItems(4).Text
                TextBoxCiudadCliente.Text = ListViewClientes.Items(i).SubItems(7).Text
                CargarComboModalidad()
                cargarComboRutina()
            Next
        End If
    End Sub


End Class
