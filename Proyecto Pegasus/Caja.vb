Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Caja
    'opciones de cierre
    Private Sub Caja_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub
    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub


    '----------------------AMB de CAJA----------------------------'
    ' Case 1: Agregar Case 2: Modificar Case 3 Eliminar
    Private Sub ambcaja()
        Select Case BDopcion

            Case 0 : BDconsulta = "insert into pago value'( " + ComboBoxIdCliente.SelectedValue.ToString + "," + TextBoxCouta.Text + ",'" + TextBoxFecha.Value.ToString("yyyy-MM-dd") + "'," + TextBoxMonto.Text + ")"
            Case 1 : BDconsulta = "update pago set id_cliente='id_cliente= " + ComboBoxIdCliente.SelectedValue.ToString + ",id_cuota=" + TextBoxCouta.Text + ",fecha=" + TextBoxFecha.Value.ToString("yyyy-MM-dd") + ",monto=" + TextBoxMonto.Text
            Case 2 : BDconsulta = "delete from pago where id_cliente=" + ComboBoxIdCliente.SelectedValue.ToString
        End Select

        Try

            BDconexion.Open()
            Dim cmdcaja As New MySqlCommand(BDconsulta, BDconexion)
            cmdcaja.ExecuteNonQuery()
            Select Case BDopcion
                Case 0 : MsgBox(" Agregado", MsgBoxStyle.Information)
                Case 1 : MsgBox("Actualizado", MsgBoxStyle.Information)
                Case 2 : MsgBox("Eliminado", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()

        End Try
        'Blanquear los texbox .clear y poner el focus
    End Sub

    '----- Cargar combo de Cliente ID -------'


    Sub CargarComboCliente()
        Try
            Dim AModalidad As New MySqlDataAdapter("select * from cliente order by id_cliente", ModuloConexion.BDconexion)
            Dim tablamodalidad As New DataTable("id_cliente")
            AModalidad.Fill(tablamodalidad)
            ComboBoxIdCliente.DataSource = tablamodalidad
            ComboBoxIdCliente.DisplayMember = "id_cliente"
            ComboBoxIdCliente.ValueMember = "id_cliente"
            ComboBoxIdCliente.SelectedValue = ModuloConexion.BDcombo

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub


    '--------- Botones -----------'
    Private Sub ButtonAgregarPago_Click(sender As Object, e As EventArgs) Handles ButtonAgregarPago.Click
        If ComboBoxIdCliente.Text = "" Or TextBoxCouta.Text = "" Or TextBoxFecha.Text = "" Or TextBoxMonto.Text Then
            MsgBox("Hay datos sin completar, revise los campos")
        Else
            BDopcion = 0 ' 0 es agregar
            ambcaja()
        End If
    End Sub

    Private Sub ButtonModificarPago_Click(sender As Object, e As EventArgs) Handles ButtonModificarPago.Click
        If ComboBoxIdCliente.Text = "" Or TextBoxCouta.Text = "" Or TextBoxFecha.Text = "" Or TextBoxMonto.Text Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 1 ' 1 es modificar
            ambcaja()
        End If
    End Sub

    Private Sub ButtonEliminarPago_Click(sender As Object, e As EventArgs) Handles ButtonEliminarPago.Click
        If ComboBoxIdCliente.Text = "" Or TextBoxCouta.Text = "" Or TextBoxFecha.Text = "" Or TextBoxMonto.Text Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 2 ' 2 es eliminar
            ambcaja()
        End If
    End Sub

    ' ------------------------------LISTA DE CLIENTES---------------------------------'

    Private Sub Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewPagos.View = View.Details
        ListViewPagos.GridLines = True
        ListViewPagos.HideSelection = False
        ListViewPagos.FullRowSelect = True
        ListViewPagos.MultiSelect = False
        ListViewPagos.Items.Clear()
        BDconsulta = "select * from pago"
        listarcaja() ' sub
        CargarComboCliente() ''Cargo combo id cliente
        '''''''''''''''''''''' CAJA '''''''''''''''''''''''''''''''
        ListViewConsultaCaja.View = View.Details
        ListViewConsultaCaja.GridLines = True
        ListViewConsultaCaja.HideSelection = False
        ListViewConsultaCaja.FullRowSelect = True
        ListViewConsultaCaja.MultiSelect = False
        ListViewConsultaCaja.Items.Clear()
        BDconsulta = "select * from cliente"
        listarclientes() ' sub
    End Sub

    Private Sub listarclientes()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdclientes As New MySqlCommand(BDconsulta, BDconexion)
            Dim readclientes As MySqlDataReader
            readclientes = cmdclientes.ExecuteReader()
            ListViewConsultaCaja.Items.Clear()
            Do While readclientes.Read()
                Dim fila As ListViewItem
                fila = ListViewConsultaCaja.Items.Add(readclientes("id_cliente"))
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

    ' ------------------------------LISTA DE caja---------------------------------'

    Private Sub listarcaja()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdclientes As New MySqlCommand(BDconsulta, BDconexion)
            Dim readclientes As MySqlDataReader
            readclientes = cmdclientes.ExecuteReader()
            ListViewPagos.Items.Clear()
            Do While readclientes.Read()
                Dim fila As ListViewItem
                fila = ListViewPagos.Items.Add(readclientes("id_cliente"))
                fila.SubItems.Add(readclientes("id_cuota"))
                fila.SubItems.Add(readclientes("fecha"))
                fila.SubItems.Add(readclientes("monto"))
            Loop
            readclientes.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
    End Sub

    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        If Char.IsLetter(TextBoxBusca.Text) Then
            BDconsulta = "select * from cliente where apellido like '" + TextBoxBusca.Text + "%'order by apellido"
            listarclientes()
        ElseIf Not Char.IsControl(TextBoxBusca.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxBusca.Clear()
        End If
    End Sub
    Private Sub TextBoxBusca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBusca.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Cuando el USUARIO presiona ENTER
            BDconsulta = "select * from cliente"
            listarclientes()
        End If
    End Sub

    Private Sub ListViewConsultaCaja_DoubleClick(sender As Object, e As EventArgs) Handles ListViewConsultaCaja.DoubleClick
        If ListViewConsultaCaja.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewConsultaCaja.SelectedIndices
                ComboBoxIdCliente.SelectedValue.ToString()
            Next
        End If
    End Sub

    Private Sub ListViewPagos_DoubleClick(sender As Object, e As EventArgs) Handles ListViewPagos.DoubleClick
        If ListViewPagos.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewPagos.SelectedIndices
                CargarComboCliente()
                TextBoxCouta.Text = ListViewPagos.Items(i).SubItems(1).Text
                TextBoxFecha.Text = ListViewPagos.Items(i).SubItems(2).Text
                TextBoxMonto.Text = ListViewPagos.Items(i).SubItems(3).Text
            Next
        End If
    End Sub
End Class