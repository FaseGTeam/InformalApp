Public Class DbContratista
    ''Obtiene todos los contratistas de db'
    Function Obtener() As Integer

        Return 0
    End Function

    ''Obtiene un contratista por id desde db'
    'Function ObtenerId() As Integer

    '    Return 0
    'End Function

    ''inserta uno o varios contratistas a db'
    'Function Insertar() As Integer
    '    Try
    '        Dim ConexionGuardar As New Conexion
    '        Dim Llamado As String
    '        Dim Salida As String
    '        Llamado = ConexionGuardar.Conectar()
    '        If Llamado = "00, Conexion Exitosa" Then
    '            Dim Query As String = "INSERT INTO Contratista (IdConstratista, 
    '                                                            Cédula, 
    '                                                            Nombre, 
    '                                                            Apellido, 
    '                                                            Fecha_Nacimiento,
    '                                                            Cargo,
    '                                                            EmpresaCon) VALUES ('" & TextBoxIdConstratista.text & "',
    '                                                                                '" & TextBoxCédula.Text & "', 
    '                                                                                '" & TextBoxNombre.Text & "', 
    '                                                                                '" & TextBoxApellido.Text & "',
    '                                                                                '" & TextBoxFecha_Nacimiento.Text & "',  
    '                                                                                '" & TextBoxCargo.Text & "',
    '                                                                                '" & TextBoxEmpresaCon.Text & "')"
    '            Salida = ConexionGuardar.Ejecutar(Query)
    '            MsgBox(Salida)
    '        Else
    '            MsgBox(Llamado)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex)
    '    End Try
    '    Return 0
    'End Function

    ''actualiza uno o varios contratistas a db'
    'Function Actualizar() As Integer
    '    Try
    '        Dim ConexionGuardar As New Conexion
    '        Dim Llamado As String
    '        Dim Salida As String
    '        Llamado = ConexionGuardar.Conectar()
    '        If Llamado = "00, Conexion Exitosa" Then
    '            Dim Query As String = "UPDATE Contratista SET (Cédula = '" & TextBoxCédula.Text & "', 
    '                                                           Nombre = '" & TextBoxNombre.Text & "', 
    '                                                           Apellido = '" & TextBoxApellido.Text & "', 
    '                                                           Fecha_Nacimiento = '" & TextBoxFecha_Nacimiento.Text & "',
    '                                                           Cargo = '" & TextBoxCargo.Text & "',
    '                                                           EmpresaCon = '" & TextBoxEmpresaCon.Text & "') 
    '                                                      WHERE IdConstratista = '" & TextBoxIdConstratista.text & "'"
    '            Salida = ConexionGuardar.Ejecutar(Query)
    '            MsgBox(Salida)
    '        Else
    '            MsgBox(Llamado)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex)
    '    End Try
    '    Return 0
    'End Function

    ''elimina uno o varios contratistas de db'
    'Function Eliminar() As Integer
    '    Try
    '        Dim ConexionGuardar As New Conexion
    '        Dim Llamado As String
    '        Dim Salida As String
    '        Llamado = ConexionGuardar.Conectar()
    '        If Llamado = "00, Conexion Exitosa" Then
    '            Dim Query As String = "DELETE * FROM Contratista WHERE IdConstratista = '" & TextBoxIdConstratista.text & "'"
    '            Salida = ConexionGuardar.Ejecutar(Query)
    '            MsgBox(Salida)
    '        Else
    '            MsgBox(Llamado)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex)
    '    End Try
    '    Return 0
    'End Function

End Class
