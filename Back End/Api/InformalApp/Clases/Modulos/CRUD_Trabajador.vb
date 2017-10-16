Public Class CRUD_Trabajador
    Dim Fecha As Date

    'Obtiene todos los contratistas de db'
    Public Sub ReadData(ByVal Cedula As Integer,
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
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "SELECT * FROM Trabajador WHERE Cédula = '" & Cedula & "' OR 
                                                                      Nombre = '" & Nombres & "' OR 
                                                                      Apellido = '" & Apellidos & "' OR
                                                                      Genero = '" & Genero & "' OR
                                                                      Fecha_Nacimiento = '" & FecNacimiento & "' OR
                                                                      Profesión = '" & Profesion & "' OR 
                                                                      LvlEducativo = '" & LvlEducativo & "' OR
                                                                      ExpTrabajo = '" & ExpLaboral & "' OR 
                                                                      HojaVida = " & HojaVida & ""
                ConexionGuardar.Query.CommandText = Query
                ConexionGuardar.Query.CommandType = Data.CommandType.Text
                ConexionGuardar.Query.Connection = ConexionGuardar.Conexion
                ConexionGuardar.MysqlReader = ConexionGuardar.Query.ExecuteReader()
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

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
                Dim Query As String = "INSERT INTO Trabajador (Cédula, 
                                                               Nombre, 
                                                               Apellido,
                                                               Genero,
                                                               Fecha_Nacimiento, 
                                                               Profesión, 
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
                          ByVal FecNacimiento As Date,
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
                                                             Profesión = '" & Profesion & "', 
                                                             LvlEducativo = '" & LvlEducativo & "',
                                                             ExpTrabajo = '" & ExpLaboral & "', 
                                                             HojaVida = '" & HojaVida & "' 
                                                         WHERE Cédula = '" & Cedula & "'"
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
                Dim Query As String = "DELETE FROM Trabajador WHERE Cédula = '" & Cedula & "'"

                Salida = ConexionGuardar.Ejecutar(Query)
                MsgBox(Salida)
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub 'Fin del Método DeleteData'

End Class
