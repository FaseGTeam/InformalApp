Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Conexion
    Public Cadena As String = "Database='db_informalapp' ;DataSource='localhost' ; UserID = 'root' ; Password = '' "
    Public Registro As Integer
    Public Salida As String


    Public Conexion As New MySql.Data.MySqlClient.MySqlConnection(Cadena)
    Public Query As New MySql.Data.MySqlClient.MySqlCommand
    Public MysqlReader As MySql.Data.MySqlClient.MySqlDataReader


    Public Function Conectar() As String
        Try
            Me.Conexion.Open()
            Me.Salida = "00, Conexion Exitosa"

        Catch ax As MySqlClient.MySqlException
            Me.Salida = ax.Message
        Catch ex As Exception
            Me.Salida = ex.Message

        End Try
        Return Salida

    End Function

    Public Sub CerraConection()
        Me.Query.Dispose() 'Bajando de memoria el elemento del query'
        Me.Conexion.Close() 'Cerrando la conexión'
        Me.Conexion.Dispose() 'Bajando la conexión de memoria'

    End Sub

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
                Dim log01 As New Log(1, $"Error {Sqlex.Message}", Date.Today, "")

            End If
        End Try
        Return Salida
    End Function

End Class
