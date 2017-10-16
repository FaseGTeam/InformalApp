Public Class DBLog
    ''Obtiene todos los contratistas de db'
    'Function Obtener() As Integer

    '    Return 0
    'End Function

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
    '            Dim Query As String = "INSERT INTO LOG (IdLog, 
    '                                                    DetalleLog, 
    '                                                    FechaLog, 
    '                                                    UsuLog) VALUES ('" & TextBoxIdLog.text & "',
    '                                                                    '" & TextBoxDetalleLog.Text & "', 
    '                                                                    '" & TextBoxFechaLog.Text & "', 
    '                                                                    '" & TextBoxUsuLog.Text & "')"
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
    '            Dim Query As String = "UPDATE LOG SET (DetalleLog = '" & TextBoxDetalleLog.Text & "', 
    '                                                   FechaLog = '" & TextBoxFechaLog.Text & "', 
    '                                                   UsuLog = '" & TextBoxUsuLog.Text & "')
    '                                              WHERE IdLog ='" & TextBoxIdLog.text & "'"
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
    '            Dim Query As String = "DELETE * FROM LOG WHERE IdLog = '" & TextBoxIdLog.Text & "'"
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
