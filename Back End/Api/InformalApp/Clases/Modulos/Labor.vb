Public Class DbLabor
    'Obtiene todas las Labores de db'
    Function Obtener() As Integer

        Return 0
    End Function

    'Obtiene una Labor por id desde db'
    Function ObtenerId() As Integer

        Return 0
    End Function

    'inserta uno o varios Labores a db'
    Function Insertar() As Integer
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "INSERT INTO Labor (IdLabor , 
                                                          Descripción, 
                                                          FecIniLabor, 
                                                          FecFinLabor, 
                                                          IdTipoLabor) VALUES ('" & TextBoxIdLabor.text & "',
                                                                               '" & TextBoxLabDes.Text & "', 
                                                                               '" & TextBoxFecIniLab.Text & "', 
                                                                               '" & TextBoxFecFinLab.Text & "', 
                                                                               '" & TextBoxTipLab.Text & "')"
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

    'actualiza uno o varios Labores a db'
    Function Actualizar() As Integer
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "UPDATE Labor SET Descripción = '" & TextBoxLabDes.Text & "', 
                                                        FecIniLabor = '" & TextBoxFecIniLab.Text & "', 
                                                        FecFinLabor = '" & TextBoxFecFinLab.Text & "', 
                                                        IdTipoLabor = '" & TextBoxTipLab.Text & "' 
                                                    WHERE IdLabor  = '" & TextBoxIdLabor.Text & "'"
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

    'elimina uno o varios Labores de db'
    Function Eliminar() As Integer
        Try
            Dim ConexionGuardar As New Conexion
            Dim Llamado As String
            Dim Salida As String
            Llamado = ConexionGuardar.Conectar()
            If Llamado = "00, Conexion Exitosa" Then
                Dim Query As String = "DELETE * FROM Labor WHERE IdLabor = '" & TextBoxIdLabor.Text & "'"
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

End Class
