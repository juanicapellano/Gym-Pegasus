Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Rutinas
    'opciones de cierre
    Private Sub Rutinas_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub
    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub TextBoxIDrutina_LostFocus(sender As Object, e As EventArgs) Handles TextBoxIDrutina.LostFocus
        If IsNumeric(TextBoxIDrutina.Text) Then

        ElseIf Not Char.IsControl(TextBoxIDrutina.Text) Then
            MsgBox("Debe ingresar un rutina existente", MsgBoxStyle.Information, "JCapellano")
        End If

    End Sub

    '----------------------AMB de Rutinas----------------------------'
    ' Case 1: Agregar Case 2: Modificar Case 3 Eliminar
    Private Sub ambrutina()
        Select Case BDopcion
            Case 1 : BDconsulta = "insert into rutina value'( " + TextBoxIDrutina.Text + ",'" + TextBoxDetalleRutina.Text + "')"
            Case 2 : BDconsulta = "update rutina set idrutina='detalle=" + TextBoxDetalleRutina.Text + "where idrutina=" + TextBoxIDrutina.Text
            Case 3 : BDconsulta = "delete from rutina where idrutina=" + TextBoxIDrutina.Text
        End Select
        Try

            BDconexion.Open()
            Dim cmdrutina As New MySqlCommand(BDconsulta, BDconexion)
            cmdrutina.ExecuteNonQuery()
            Select Case BDopcion
                Case 0 : MsgBox("Rutina agregada", MsgBoxStyle.Information)
                Case 1 : MsgBox("Rutina actualizada", MsgBoxStyle.Information)
                Case 2 : MsgBox("Rutina eliminada", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
        TextBoxDetalleRutina.Clear()
        TextBoxIDrutina.Clear()
        TextBoxIDrutina.Focus()
    End Sub

    '--------- Botones -----------'

    Private Sub TextBoxNombreRutina_Click(sender As Object, e As EventArgs) Handles TextBoxIDrutina.Click
        If TextBoxDetalleRutina.Text = "" Or TextBoxIDrutina.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")
        Else
            BDopcion = 0 ' 0 es agregar
            ambrutina()
        End If
    End Sub


    Private Sub ButtonModificarRutina_Click(sender As Object, e As EventArgs) Handles ButtonModificarRutina.Click
        If TextBoxDetalleRutina.Text = "" Or TextBoxIDrutina.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 1 ' 1 es modificar
            ambrutina()
        End If
    End Sub

    Private Sub ButtonEliminarRutina_Click(sender As Object, e As EventArgs) Handles ButtonEliminarRutina.Click
        If TextBoxDetalleRutina.Text = "" Or TextBoxIDrutina.Text = "" Then
            MsgBox("Hay datos sin completar, revise los campos")

        Else
            BDopcion = 3 ' 3 es eliminar
            ambrutina()
        End If
    End Sub

    ' ------------------------------LISTA DE RUTINAS---------------------------------'

    Private Sub Rutinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewRutina.View = View.Details
        ListViewRutina.GridLines = True
        ListViewRutina.HideSelection = False
        ListViewRutina.FullRowSelect = True
        ListViewRutina.MultiSelect = False
        ListViewRutina.Items.Clear()
        BDconsulta = "select * from rutina"
        listarrutina() ' sub
    End Sub

    Private Sub listarrutina()
        Try
            ModuloConexion.BDconexion.Open()

            Dim cmdrutina As New MySqlCommand(BDconsulta, BDconexion)
            Dim readrutina As MySqlDataReader
            readrutina = cmdrutina.ExecuteReader()
            ListViewRutina.Items.Clear()
            Do While readrutina.Read()
                Dim fila As ListViewItem
                fila = ListViewRutina.Items.Add(readrutina("id_rutina"))
                fila.SubItems.Add(readrutina("detalle"))
                fila.SubItems.Add(readrutina("id_aparato"))
            Loop
            readrutina.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            BDconexion.Close()
        End Try
    End Sub
    Private Sub TextBoxDetalleRutina_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDetalleRutina.TextChanged
        If Char.IsLetter(TextBoxDetalleRutina.Text) Then
            BDconsulta = "select * from rutina where detalle like '" + TextBoxDetalleRutina.Text + "%'order by detalle"
            listarrutina()
        ElseIf Not Char.IsControl(TextBoxDetalleRutina.Text) Then
            MsgBox("Debe ingresar una letra")
            TextBoxDetalleRutina.Clear()
        End If
    End Sub
    Private Sub TextBoxIDrutina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxIDrutina.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Cuando el USUARIO presiona ENTER
            BDconsulta = "select * from rutina"
            listarrutina()
        End If
    End Sub

End Class
