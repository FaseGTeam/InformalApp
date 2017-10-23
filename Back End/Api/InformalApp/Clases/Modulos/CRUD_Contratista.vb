Public Class CRUD_Contratista
    Dim con As New Conexion

    ''Obtiene todos los contratistas de db'
    Function Obtener() As Integer

        Return 0
    End Function

    'Obtiene un contratista por id desde db'
    Function ObtenerPorId(ByVal id As Integer)
        Try
            Dim dataReader = con.consultaSeleccion($"select * from contratista where IdConstratista = {id}")

            If dataReader.Read() Then
                Return New Contratista(Integer.Parse(dataReader("Cedula")), dataReader("Nombre").ToString(), dataReader("Apellido").ToString(), Nothing, dataReader("Fecha_Nacimiento").ToString(), Integer.Parse(dataReader("IdConstratista")), Nothing, dataReader("Cargo"))
            End If
            con.CerraConection()
        Catch ex As Exception
            MsgBox($"error: {ex.Message}")
        End Try
    End Function

    'inserta uno o varios contratistas a db'
    Function Insertar(ByVal contratista As Contratista) As Integer
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = $"INSERT INTO contratista (IdConstratista,Cedula,Nombre,Apellido,Fecha_Nacimiento,Cargo,EmpresaCon) VALUES ({contratista.Id},{contratista.Cedula},'{contratista.Nombres}','{contratista.Apellidos}','{contratista.FecNacimiento}','{contratista.Cargo}','{contratista.EmpContratista}')"
                Salida = ConexionGuardar.Ejecutar(Query)
                MsgBox(Salida)
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return 0
    End Function

    'actualiza uno o varios contratistas a db'
    Function Actualizar(ByVal contratista As Contratista) As Integer
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = $"UPDATE contratista SET Cedula = '{contratista.Cedula}',
                                                               Nombre = '{contratista.Nombres}', 
                                                               Apellido = '{contratista.Apellidos}', 
                                                               Fecha_Nacimiento = '{contratista.FecNacimiento}',
                                                               Cargo = '{contratista.Cargo}',
                                                               EmpresaCon = '{contratista.EmpContratista}'
                                                          WHERE IdConstratista = {contratista.Id}"
                Salida = ConexionGuardar.Ejecutar(Query)
                MsgBox(Salida)
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return 0
    End Function

    'elimina uno o varios contratistas de db'
    Function Eliminar(ByVal Id As Integer) As Integer
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = $"DELETE FROM Contratista WHERE IdConstratista = {Id}"
                Salida = ConexionGuardar.Ejecutar(Query)
                MsgBox("Contratista Eliminado")
            Else
                MsgBox(Llamado)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return 0
    End Function

End Class
