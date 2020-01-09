Imports MySql.Data.MySqlClient
Module ModuloConexion
    Public BDconexion As New MySqlConnection("server=127.0.0.1;uid=root;pwd=12345678;database=gimnasio;SslMode=none")
    Public BDopcion As Integer 'Guardo si es alta, eliminacion o modificacion'
    Public BDconsulta As String
    Public BDcombo As Integer ' Guardo id_modalidad con clave foranea de la tabla cliente

End Module

