Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Gastos2
    'opciones de cierre
    Private Sub ButtonCerrarGastos_Click_1(sender As Object, e As EventArgs) Handles ButtonCerrarGastos.Click
        Me.Close()
    End Sub

    Private Sub Gastos2_Deactivate(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    '----------------------AMB de Compras/Gastos----------------------------'
    ' Case 1: Agregar Case 2: Modificar Case 3 Eliminar
    Private Sub ambgastos1()

        Select Case BDopcion
            Case 1 : BDconsulta = "insert into gastos value (" + TextBoxIDCompra1.Text + ",'" + TextBoxFechaCompra1.Text + "','" + TextBoxDetalleCompra1.Text + "')"
            Case 2 : BDconsulta = "update gastos set "
            Case 3 : BDconsulta = "delete from gastos where codigo="
        End Select

        Try

            BDconexion.Open()
            Dim cmdgasto As New MySqlCommand(BDconsulta, BDconexion)
            cmdgasto.ExecuteNonQuery()
            Select Case BDopcion
                Case 1 : MsgBox("Gasto Agregado", MsgBoxStyle.Information)
                Case 2 : MsgBox("Gasto actualizado", MsgBoxStyle.Information)
                Case 3 : MsgBox("Gasto eliminado", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()

        End Try
        'Blanquear los texbox .clear y poner el focus
    End Sub

    '----------------------AMB de Aparato----------------------------'
    ' Case 1: Agregar Case 2: Modificar Case 3 Eliminar
    Private Sub ambaparato1()

        Select Case BDopcion
            Case 1 : BDconsulta = "insert into gastos value (" + TextBoxIDCompra1.Text + ",'" + TextBoxFechaCompra1.Text + "','" + TextBoxDetalleCompra1.Text + "')"
            Case 2 : BDconsulta = "update gastos set "
            Case 3 : BDconsulta = "delete from gastos where codigo="
        End Select

        Try

            BDconexion.Open()
            Dim cmdaparato As New MySqlCommand(BDconsulta, BDconexion)
            cmdaparato.ExecuteNonQuery()
            Select Case BDopcion
                Case 1 : MsgBox("Aparato agregado", MsgBoxStyle.Information)
                Case 2 : MsgBox("Aparato actualizado", MsgBoxStyle.Information)
                Case 3 : MsgBox("Aparato eliminado", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()

        End Try
        'Blanquear los texbox .clear y poner el focus
    End Sub

    '----------------------AMB de Sueldos----------------------------'
    ' Case 1: Agregar Case 2: Modificar Case 3 Eliminar
    Private Sub ambsueldo1()

        Select Case BDopcion
            Case 1 : BDconsulta = "insert into gastos value (" + TextBoxIDCompra1.Text + ",'" + TextBoxFechaCompra1.Text + "','" + TextBoxDetalleCompra1.Text + "')"
            Case 2 : BDconsulta = "update gastos set "
            Case 3 : BDconsulta = "delete from gastos where codigo="
        End Select

        Try

            BDconexion.Open()
            Dim cmdrubro As New MySqlCommand(BDconsulta, BDconexion)
            cmdrubro.ExecuteNonQuery()
            Select Case BDopcion
                Case 1 : MsgBox("Sueldo agregado", MsgBoxStyle.Information)
                Case 2 : MsgBox("Sueldo actualizado", MsgBoxStyle.Information)
                Case 3 : MsgBox("Sueldo eliminado", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()

        End Try
        'Blanquear los texbox .clear y poner el focus
    End Sub



    '--------- Botones de GASTOS -----------'
    Private Sub ButtonAgregarCompra1_Click_1(sender As Object, e As EventArgs) Handles ButtonAgregarCompra1.Click
        If TextBoxDetalleCompra1.Text = "" Or TextBoxFechaCompra1.Text = "" Or TextBoxIDCompra1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")
        Else
            BDopcion = 0 ' 0 es agregar
            ambgastos1()
        End If
    End Sub

    Private Sub ButtonModificarCompra1_Click(sender As Object, e As EventArgs) Handles ButtonModificarCompra1.Click
        If TextBoxDetalleCompra1.Text = "" Or TextBoxFechaCompra1.Text = "" Or TextBoxIDCompra1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 1 ' 1 es modificar
            ambgastos1()
        End If
    End Sub

    Private Sub ButtonEliminarCompra1_Click(sender As Object, e As EventArgs) Handles ButtonEliminarCompra1.Click
        If TextBoxDetalleCompra1.Text = "" Or TextBoxFechaCompra1.Text = "" Or TextBoxIDCompra1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 3 ' 3 es eliminar
            ambgastos1()
        End If
    End Sub


    '--------- Botones de Sueldo -----------'
    Private Sub ButtonAgregarSueldo1_Click_1(sender As Object, e As EventArgs) Handles ButtonAgregarSueldo1.Click
        If TextBoxIdSueldo1.Text = "" Or TextBoxMontoSueldo1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")
        Else
            BDopcion = 0 ' 0 es agregar
            ambsueldo1()
        End If
    End Sub

    Private Sub ButtonModificarSueldo1_Click_1(sender As Object, e As EventArgs) Handles ButtonModificarSueldo1.Click
        If TextBoxIdSueldo1.Text = "" Or TextBoxMontoSueldo1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 1 ' 1 es modificar
            ambsueldo1()
        End If
    End Sub

    Private Sub ButtonEliminarSueldo1_Click_1(sender As Object, e As EventArgs) Handles ButtonEliminarSueldo1.Click
        If TextBoxIdSueldo1.Text = "" Or TextBoxMontoSueldo1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 3 ' 3 es eliminar
            ambsueldo1()
        End If
    End Sub

    '--------- Botones de Aparato -----------'
    Private Sub ButtonAgregarAparato1_Click_1(sender As Object, e As EventArgs) Handles ButtonAgregarAparato1.Click
        If TextBoxIdAparato1.Text = "" Or TextBoxNombreAparato1.Text = "" Or TextBoxDetalleAparato1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")
        Else
            BDopcion = 0 ' 0 es agregar
            ambsueldo1()
        End If
    End Sub

    Private Sub ButtonModificarAparato1_Click_1(sender As Object, e As EventArgs) Handles ButtonModificarAparato1.Click
        If TextBoxIdAparato1.Text = "" Or TextBoxNombreAparato1.Text = "" Or TextBoxDetalleAparato1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 1 ' 1 es modificar
            ambaparato1()
        End If
    End Sub

    Private Sub ButtonEliminarAparato1_Click_1(sender As Object, e As EventArgs) Handles ButtonEliminarAparato1.Click
        If TextBoxIdAparato1.Text = "" Or TextBoxNombreAparato1.Text = "" Or TextBoxDetalleAparato1.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 3 ' 3 es eliminar
            ambaparato1()
        End If
    End Sub

    ' ------------------------------LISTA DE gastos---------------------------------'

    Private Sub Gastos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewGastos1.View = View.Details
        ListViewGastos1.GridLines = True
        ListViewGastos1.HideSelection = False
        ListViewGastos1.FullRowSelect = True
        ListViewGastos1.MultiSelect = False
        ListViewGastos1.Items.Clear()
        BDconsulta = "select * from gastos"
        listargastos1() ' sub

        ListViewAparatos1.View = View.Details
        ListViewAparatos1.GridLines = True
        ListViewAparatos1.HideSelection = False
        ListViewAparatos1.FullRowSelect = True
        ListViewAparatos1.MultiSelect = False
        ListViewAparatos1.Items.Clear()
        BDconsulta = "select * from aparato"
        listaraparatos1() ' sub

        ListViewSueldo1.View = View.Details
        ListViewSueldo1.GridLines = True
        ListViewSueldo1.HideSelection = False
        ListViewSueldo1.FullRowSelect = True
        ListViewSueldo1.MultiSelect = False
        ListViewSueldo1.Items.Clear()
        BDconsulta = "select * from sueldo"
        listaraparatos1() ' sub
    End Sub

    Private Sub listargastos1()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdrutina As New MySqlCommand(BDconsulta, BDconexion)
            Dim readrutina As MySqlDataReader
            readrutina = cmdrutina.ExecuteReader()
            ListViewGastos1.Items.Clear()
            Do While readrutina.Read()
                Dim fila As ListViewItem
                fila = ListViewGastos1.Items.Add(readrutina("fecha"))
                fila.SubItems.Add(readrutina("id_gastos"))
                fila.SubItems.Add(readrutina("detalle"))
            Loop
            readrutina.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
    End Sub
    Private Sub TextBoxBuscaDetallegasto1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscaDetallegasto1.TextChanged
        If Char.IsLetter(TextBoxBuscaDetallegasto1.Text) Then
            BDconsulta = "select * from gastos where detalle like '" + TextBoxBuscaDetallegasto1.Text + "%'order by detalle"
            listargastos1()
        ElseIf Not Char.IsControl(TextBoxBuscaDetallegasto1.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxBuscaDetallegasto1.Clear()
        End If
    End Sub
    Private Sub TextBoxBuscaDetallegasto1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscaDetallegasto1.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Cuando el USUARIO presiona ENTER
            BDconsulta = "select * from rutina"
            listargastos1()
        End If
    End Sub

    ' ------------------------------LISTA DE aparatos---------------------------------'
    Private Sub listaraparatos1()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdrutina As New MySqlCommand(BDconsulta, BDconexion)
            Dim readrutina As MySqlDataReader
            readrutina = cmdrutina.ExecuteReader()
            ListViewGastos1.Items.Clear()
            Do While readrutina.Read()
                Dim fila As ListViewItem
                fila = ListViewGastos1.Items.Add(readrutina("id_aparato"))
                fila.SubItems.Add(readrutina("aparato"))
                fila.SubItems.Add(readrutina("detalle"))
            Loop
            readrutina.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
    End Sub
    Private Sub TextBoxBuscaDetalleaparatos1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscaDetalleaparatos1.TextChanged
        If Char.IsLetter(TextBoxBuscaDetalleaparatos1.Text) Then
            BDconsulta = "select * from aparato where detalle like '" + TextBoxBuscaDetalleaparatos1.Text + "%'order by detalle"
            listaraparatos1()
        ElseIf Not Char.IsControl(TextBoxBuscaDetalleaparatos1.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxBuscaDetallegasto1.Clear()
        End If
    End Sub
    Private Sub TextBoxBuscaDetalleaparatos1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscaDetalleaparatos1.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Cuando el USUARIO presiona ENTER
            BDconsulta = "select * from aparato"
            listaraparatos1()
        End If
    End Sub

    ' ------------------------------LISTA DE sueldo---------------------------------'

    Private Sub listarsueldo1()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdrutina As New MySqlCommand(BDconsulta, BDconexion)
            Dim readrutina As MySqlDataReader
            readrutina = cmdrutina.ExecuteReader()
            ListViewSueldo1.Items.Clear()
            Do While readrutina.Read()
                Dim fila As ListViewItem
                fila = ListViewSueldo1.Items.Add(readrutina("id_sueldo"))
                fila.SubItems.Add(readrutina("sueldo"))
            Loop
            readrutina.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
    End Sub
    Private Sub TextBoxSueldo1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSueldo1.TextChanged
        If Char.IsLetter(TextBoxSueldo1.Text) Then
            BDconsulta = "select * from sueldo where id_sueldo like '" + TextBoxSueldo1.Text + "%'order by id_sueldo"
            listarsueldo1()
        ElseIf Not Char.IsControl(TextBoxSueldo1.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxSueldo1.Clear()
        End If
    End Sub
    Private Sub TextBoxSueldo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSueldo1.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Cuando el USUARIO presiona ENTER
            BDconsulta = "select * from aparato"
            listarsueldo1()
        End If
    End Sub



End Class