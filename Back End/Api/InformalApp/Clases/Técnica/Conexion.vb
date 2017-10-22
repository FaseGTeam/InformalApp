Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Conexion
    Public Cadena As String = "Database='db_informalapp' ;Data Source='localhost' ;User Id=uapp;password=12345678"
    Public Registro As Integer
    Public Salida As String


    Public Conexion As New MySql.Data.MySqlClient.MySqlConnection(Cadena)
    Public Query As New MySql.Data.MySqlClient.MySqlCommand
    Public MysqlReader As MySql.Data.MySqlClient.MySqlDataReader


    Public Function Conectar(Optional ByVal isTest = False) As String
        Try
            Me.Conexion.Open()
            Me.Salida = "00, Conexion Exitosa"

            If isTest Then
                MsgBox(Me.Salida, MsgBoxStyle.Information)
            End If

        Catch ax As MySqlClient.MySqlException
            Me.Salida = ax.Message

        End Try
        Return Salida

    End Function

    Public Sub CerraConection(Optional ByVal isTest = False)
        Try
            Me.Query.Dispose() 'Bajando de memoria el elemento del query'
            Me.Conexion.Close() 'Cerrando la conexión'
            Me.Conexion.Dispose() 'Bajando la conexión de memoria'

            If isTest Then
                MsgBox("Conexión cerrada correctamente.", MsgBoxStyle.Information)
            End If
        Catch ax As MySqlClient.MySqlException
            Me.Salida = ax.Message
        End Try

    End Sub

    'Ejecuta un query de consulta de datos '
    Public Function EjecutarConsultaDatos(comando) As MySqlDataReader
        Try
            Me.Query.CommandType = Data.CommandType.Text
            Me.Query.CommandText = comando
            Me.Query.Connection = Me.Conexion
            Me.MysqlReader = Me.Query.ExecuteReader()

        Catch Sqlex As MySqlClient.MySqlException
            MsgBox($"Un error inesperado ha ocurrido: {Sqlex.Message}", MsgBoxStyle.Critical, $"Error número {Sqlex.Number}")
        End Try

        Return Me.MysqlReader
    End Function

    'Ejecuta una query en base de datos'
    Public Function Ejecutar(text) As String
        Try
            Me.Query.CommandType = Data.CommandType.Text
            Me.Query.CommandText = text
            Me.Query.Connection = Me.Conexion
            Registro = Me.Query.ExecuteNonQuery()
            If Registro <> 0 Then
                Salida = "Sentecia exitosa"
            ElseIf Registro = 0 Then
                Salida = "Sentecia ejecutada con advertencias"
            Else
                Salida = "Registro Fallido"
            End If
        Catch Sqlex As MySqlClient.MySqlException
            If Sqlex.Number = 1088 Then
                Salida = "Registro Duplicado"
            Else
                MsgBox($"Un error inesperado ha ocurrido: {Sqlex.Message}")
                'Dim log01 As New Log(1, $"Error {Sqlex.Message}", Date.Today, "")
            End If
        End Try

        Return Salida
    End Function
End Class
