Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Empleados
    'opciones de cierre
    Private Sub Empleados_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub
    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub


    '----------------------AMB de Profesor----------------------------'
    ' Case 1: Agregar Case 2: Modificar Case 3 Eliminar
    Private Sub ambprofesor()

        Select Case BDopcion
            Case 1 : BDconsulta = "insert into profesor value (" + IDPROfesor.Text + ",'" + NombreProfesor.Text + "','" + ApellidoProfesor.Text + "'," + DocumentoProfesor.Text + "," + CelularProfesor.Text + ",'" + CiudadProfesor.Text + "','" + ComboBoxSueldoProfesor.SelectedValue.ToString + "')"
            Case 2 : BDconsulta = "update profesor set id_profesor='nombre=" + NombreProfesor.Text + "',apellido='" + ApellidoProfesor.Text + "',documento=" + DocumentoProfesor.Text + ",celular=" + CelularProfesor.Text + ",ciudad='" + CiudadProfesor.Text + "',sueldo='" + ComboBoxSueldoProfesor.SelectedValue.ToString + "'where id_profesor" + IDPROfesor.Text
            Case 3 : BDconsulta = "delete from profesor where id_profesor=" + IDPROfesor.Text
        End Select

        Try

            BDconexion.Open()
            Dim cmdrubro As New MySqlCommand(BDconsulta, BDconexion)
            cmdrubro.ExecuteNonQuery()
            Select Case BDopcion
                Case 1 : MsgBox("Profesor agregado", MsgBoxStyle.Information)
                Case 2 : MsgBox("Profesor actualizado", MsgBoxStyle.Information)
                Case 3 : MsgBox("Profesor eliminado", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()

        End Try
        'Blanquear los texbox .clear y poner el focus
    End Sub

    '----- Cargar combo de suelldo -------'

    Private Sub CargarComboSueldo()

        Try
            Dim AProfesor As New MySqlDataAdapter("select * from sueldo order by id_sueldo ", ModuloConexion.BDconexion)
            Dim tablaProfesor As New DataTable("id_sueldo")
            AProfesor.Fill(tablaProfesor)

            ComboBoxSueldoProfesor.DataSource = tablaProfesor
            ComboBoxSueldoProfesor.DisplayMember = "sueldo"
            ComboBoxSueldoProfesor.ValueMember = "id_sueldo"
            ComboBoxSueldoProfesor.SelectedValue = ModuloConexion.BDcombo

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    '--------- Botones -----------'
    Private Sub ButtonAgregarProfesor_Click(sender As Object, e As EventArgs) Handles ButtonAgregarProfesor.Click
        If NombreProfesor.Text = "" Or ApellidoProfesor.Text = "" Or CiudadProfesor.Text = "" Or DocumentoProfesor.Text = "" Or CelularProfesor.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")
        Else
            BDopcion = 1 ' 1 es agregar
            ambprofesor()
        End If
    End Sub

    Private Sub ButtonModificarProfesor_Click(sender As Object, e As EventArgs) Handles ButtonModificarProfesor.Click
        If NombreProfesor.Text = "" Or ApellidoProfesor.Text = "" Or CiudadProfesor.Text = "" Or DocumentoProfesor.Text = "" Or CelularProfesor.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 2 ' 2 es modificar
            ambprofesor()
        End If
    End Sub

    Private Sub ButtonEliminarProfesor_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProfesor.Click
        If NombreProfesor.Text = "" Or ApellidoProfesor.Text = "" Or CiudadProfesor.Text = "" Or DocumentoProfesor.Text = "" Or CelularProfesor.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 3 ' 3 es eliminar
            ambprofesor()
        End If
    End Sub

    'Listar Profesor
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoxP.View = View.Details
        ListBoxP.GridLines = True
        ListBoxP.HideSelection = False
        ListBoxP.FullRowSelect = True
        ListBoxP.MultiSelect = False
        ListBoxP.Items.Clear()
        BDconsulta = "select * from profesor"
        listarprofesor() ' sub
        CargarComboSueldo()
    End Sub

    Public Sub listarprofesor()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdclientes As New MySqlCommand(BDconsulta, BDconexion)
            Dim readclientes As MySqlDataReader
            readclientes = cmdclientes.ExecuteReader()
            ListBoxP.Items.Clear()
            Do While readclientes.Read()
                Dim fila As ListViewItem
                fila = ListBoxP.Items.Add(readclientes("id_profesor"))

                fila.SubItems.Add(readclientes("nombre"))
                fila.SubItems.Add(readclientes("apellido"))
                fila.SubItems.Add(readclientes("documento"))
                fila.SubItems.Add(readclientes("celular"))
                fila.SubItems.Add(readclientes("ciudad"))
                fila.SubItems.Add(readclientes("sueldo"))
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
            listarprofesor()
        ElseIf Not Char.IsControl(TextBoxApellidolistado.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxApellidolistado.Clear()
        End If
    End Sub
    Private Sub TextBoxproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxApellidolistado.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Cuando el USUARIO presiona ENTER
            BDconsulta = "select * from profesor"
            listarprofesor()
        End If
    End Sub


    Private Sub ListBoxP_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxP.DoubleClick
        If ListBoxP.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListBoxP.SelectedIndices
                IDPROfesor.Text = ListBoxP.Items(i).SubItems(0).Text
                NombreProfesor.Text = ListBoxP.Items(i).SubItems(1).Text
                ApellidoProfesor.Text = ListBoxP.Items(i).SubItems(2).Text
                DocumentoProfesor.Text = ListBoxP.Items(i).SubItems(3).Text
                CelularProfesor.Text = ListBoxP.Items(i).SubItems(4).Text
                CiudadProfesor.Text = ListBoxP.Items(i).SubItems(5).Text
                CargarComboSueldo()
            Next
        End If
    End Sub
End Class