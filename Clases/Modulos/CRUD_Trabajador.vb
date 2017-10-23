Public Class CRUD_Trabajador
    Dim Fecha As Date
    Dim DataReader As MySql.Data.MySqlClient.MySqlDataReader
    'Obtiene todos los contratistas de db'
    Public Function ReadData(ByVal Cedula As Integer)
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "SELECT * FROM Trabajador WHERE Cedula = '" & Cedula & "'"

                ConexionGuardar.Query.CommandText = Query
                ConexionGuardar.Query.CommandType = Data.CommandType.Text
                ConexionGuardar.Query.Connection = ConexionGuardar.Conexion
                DataReader = ConexionGuardar.Query.ExecuteReader()
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return DataReader
    End Function

    'Método Insert para agregar registros a la tabla Trabajador en la BD'
    Public Sub InsertData(ByVal Cedula As Integer,
                          ByVal Nombres As String,
                          ByVal Apellidos As String,
                          ByVal Genero As String,
                          ByVal FecNacimiento As String,
                          ByVal Profesion As String,
                          ByVal LvlEducativo As String,
                          ByVal ExpLaboral As String,
                          ByVal HojaVida As Boolean)

        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "INSERT INTO Trabajador (Cedula, 
                                                               Nombre, 
                                                               Apellido,
                                                               Genero,
                                                               Fecha_Nacimiento, 
                                                               Profesion, 
                                                               LvlEducativo,
                                                               ExpTrabajo, 
                                                               HojaVida) VALUES ('" & Cedula & "',
                                                                                 '" & Nombres & "', 
                                                                                 '" & Apellidos & "', 
                                                                                 '" & Genero & "', 
                                                                                 '" & FecNacimiento & "',
                                                                                 '" & Profesion & "',
                                                                                 '" & LvlEducativo & "',
                                                                                 '" & ExpLaboral & "',
                                                                                 " & HojaVida & ")"
                Salida = ConexionGuardar.Ejecutar(Query)
                MsgBox(Salida)
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub 'Fin del Método InsertData'

    'Método Update para actualizar registros a la tabla Trabajador en la BD'
    Public Sub UpdateData(ByVal Cedula As Integer,
                          ByVal Nombres As String,
                          ByVal Apellidos As String,
                          ByVal Genero As String,
                          ByVal FecNacimiento As String,
                          ByVal Profesion As String,
                          ByVal LvlEducativo As String,
                          ByVal ExpLaboral As String,
                          ByVal HojaVida As Boolean)
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "UPDATE Trabajador SET Nombre = '" & Nombres & "', 
                                                             Apellido = '" & Apellidos & "',
                                                             Genero = '" & Genero & "',
                                                             Fecha_Nacimiento = '" & FecNacimiento & "', 
                                                             Profesion = '" & Profesion & "', 
                                                             LvlEducativo = '" & LvlEducativo & "',
                                                             ExpTrabajo = '" & ExpLaboral & "', 
                                                             HojaVida = '" & HojaVida & "' 
                                                         WHERE Cedula = '" & Cedula & "'"
                Salida = ConexionGuardar.Ejecutar(Query)
                MsgBox(Salida)
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub 'Fin del Método UpdateData'

    'Método Insert para eliminar registros a la tabla Trabajador en la BD'
    Public Sub DeleteData(ByVal Cedula As Integer)
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "DELETE FROM Trabajador WHERE Cedula = '" & Cedula & "'"

                Salida = ConexionGuardar.Ejecutar(Query)
                MsgBox(Salida)
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub 'Fin del Método DeleteData'


    Public Function ReadDataList()
        Dim dtTrabajador As New DataTable
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String

            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "SELECT Cedula, Nombre FROM Trabajador  " '"

                ConexionGuardar.Query.CommandText = Query
                ConexionGuardar.Query.CommandType = Data.CommandType.Text
                ConexionGuardar.Query.Connection = ConexionGuardar.Conexion
                DataReader = ConexionGuardar.Query.ExecuteReader()
                dtTrabajador.Load(DataReader)
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return dtTrabajador
    End Function
End Class
