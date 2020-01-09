Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form1

    '-------------------------------------------Botones del menú azul ------------------------------------------------
    ''Clientes
    Private Sub ButtonClientes_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClientes.MouseLeave
        ButtonClientes.BackColor = Color.White
        ButtonClientes.ForeColor = Color.Black
    End Sub

    Private Sub ButtonClientes_MouseMove(sender As Object, e As MouseEventArgs) Handles ButtonClientes.MouseMove
        ButtonClientes.BackColor = Color.Black
        ButtonClientes.ForeColor = Color.White
    End Sub
    ''Empleados
    Private Sub ButtonEmpleados_MouseLeave(sender As Object, e As EventArgs) Handles ButtonEmpleados.MouseLeave
        ButtonEmpleados.BackColor = Color.White
        ButtonEmpleados.ForeColor = Color.Black
    End Sub

    Private Sub ButtonEmpleados_MouseMove(sender As Object, e As MouseEventArgs) Handles ButtonEmpleados.MouseMove
        ButtonEmpleados.BackColor = Color.Black
        ButtonEmpleados.ForeColor = Color.White
    End Sub
    ''Caja
    Private Sub ButtonCaja_MouseLeave(sender As Object, e As EventArgs) Handles ButtonCaja.MouseLeave
        ButtonCaja.BackColor = Color.White
        ButtonCaja.ForeColor = Color.Black
    End Sub

    Private Sub ButtonCaja_MouseMove(sender As Object, e As MouseEventArgs) Handles ButtonCaja.MouseMove
        ButtonCaja.BackColor = Color.Black
        ButtonCaja.ForeColor = Color.White
    End Sub
    ''Rutinas
    Private Sub ButtonRutinas_MouseLeave(sender As Object, e As EventArgs) Handles ButtonRutinas.MouseLeave
        ButtonRutinas.BackColor = Color.White
        ButtonRutinas.ForeColor = Color.Black
    End Sub

    Private Sub ButtonRutinas_MouseMove(sender As Object, e As MouseEventArgs) Handles ButtonRutinas.MouseMove
        ButtonRutinas.BackColor = Color.Black
        ButtonRutinas.ForeColor = Color.White
    End Sub
    ''Gastos
    Private Sub ButtonGastos_MouseLeave(sender As Object, e As EventArgs) Handles ButtonGastos.MouseLeave
        ButtonGastos.BackColor = Color.White
        ButtonGastos.ForeColor = Color.Black
    End Sub

    Private Sub ButtonGastos_MouseMove(sender As Object, e As MouseEventArgs) Handles ButtonGastos.MouseMove
        ButtonGastos.BackColor = Color.Black
        ButtonGastos.ForeColor = Color.White
    End Sub

    '------------------------------------ Posicionamiento de ventanas ----------------------------'

    Private Sub ButtonEmpleados_Click(sender As Object, e As EventArgs) Handles ButtonEmpleados.Click
        Empleados.Location = New Point(180, 65)
        Empleados.Show()
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        Clientes.Location = New Point(180, 65)
        Clientes.Show()
    End Sub

    Private Sub ButtonRutinas_Click(sender As Object, e As EventArgs) Handles ButtonRutinas.Click
        Rutinas.Location = New Point(180, 65)
        Rutinas.Show()

    End Sub

    Private Sub ButtonGastos_Click(sender As Object, e As EventArgs) Handles ButtonGastos.Click
        Gastos2.Location = New Point(180, 65)
        Gastos2.Show()

    End Sub

    Private Sub ButtonCaja_Click(sender As Object, e As EventArgs) Handles ButtonCaja.Click
        Caja.Location = New Point(180, 65)
        Caja.Show()
    End Sub

    Private Sub cmdclinetes()

        BDconexion.Open()
        Dim cmdclientes As New MySqlCommand(BDconsulta, BDconexion)
        cmdclientes.ExecuteNonQuery()
        BDconsulta = "SELECT NombreEmpleado, SUM(Ganancia) As Ganancia  FROM tuTabla GROUP BY NombreEmpleado"
    End Sub

End Class
