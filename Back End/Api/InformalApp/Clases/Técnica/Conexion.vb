Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Conexion
    Public Cadena As String
    Public Registro As Integer
    Public Salida As String
    Public QueryString As String


    Public Conexion As New MySql.Data.MySqlClient.MySqlConnection(Globales.CadenaConexion)
    Public Query As New MySql.Data.MySqlClient.MySqlCommand
    Public MysqlReader As MySql.Data.MySqlClient.MySqlDataReader
    Public MysqlDataAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
    Public DataTable As New DataTable()
    Public dbQuerys As New DbQuerys

    Sub ConfigurarConexion(ByVal host As String, ByVal user As String, ByVal password As String, Optional ByVal database As String = "")
        Globales.CadenaConexion = $"{IIf(database <> "", $"Database='{database}'", "")}; Data Source='{host}' ;User Id={user};password='{password}'"
        'cierra la conexión si está abierta'
        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If
        Conexion.ConnectionString = Globales.CadenaConexion
    End Sub


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

    Public Function CerraConection(Optional ByVal isTest = False)
        Try
            Me.Query.Dispose() 'Bajando de memoria el elemento del query'
            Me.Conexion.Close() 'Cerrando la conexión'
            Me.Conexion.Dispose() 'Bajando la conexión de memoria'

            Me.Salida = "Ok"
            If isTest = True Then
                MsgBox("Conexión cerrada correctamente.", MsgBoxStyle.Information)
            End If
        Catch ax As MySqlClient.MySqlException
            Me.Salida = ax.Message
        End Try

        Return Me.Salida
    End Function

    Function consultaSeleccion(ByVal comando As String) As MySqlDataReader
        If Me.Conexion.State = ConnectionState.Closed Then
            Me.Conectar()
        End If

        Me.Query.CommandType = Data.CommandType.Text
        Me.Query.CommandText = comando
        Me.Query.Connection = Me.Conexion
        Me.MysqlReader = Me.Query.ExecuteReader()
        Return Me.MysqlReader
    End Function

    'Ejecuta un query de consulta de datos y devulve un DataTale para ser usado en DataGridView'
    Public Function ObtenerTabla(ByVal comando As String) As DataTable
        Try
            Me.Query.CommandType = Data.CommandType.Text
            Me.Query.CommandText = comando
            Me.Query.Connection = Me.Conexion
            Me.MysqlDataAdapter = New MySqlDataAdapter(Me.Query.CommandText, Me.Query.Connection)
            Me.DataTable.Clear()
            Me.MysqlDataAdapter.Fill(Me.DataTable)
            CerraConection()
        Catch Sqlex As MySqlClient.MySqlException
            MsgBox($"Un error inesperado ha ocurrido: {Sqlex.Message}", MsgBoxStyle.Critical, $"Error número {Sqlex.Number}")
        End Try

        Return Me.DataTable
    End Function

    'Ejecuta una query en base de datos'
    Public Function Ejecutar(ByVal text As String, Optional ByVal mostrarMensaje As Boolean = True) As String
        Try
            Me.Query.CommandType = Data.CommandType.Text
            Me.Query.CommandText = text

            If Me.Conexion.State = ConnectionState.Closed Then
                Me.Conectar()
            End If

            Me.Query.Connection = Me.Conexion
            Registro = Me.Query.ExecuteNonQuery()
            If Registro <> 0 Then
                Salida = "Sentecia exitosa"
            ElseIf Registro = 0 Then
                Salida = "Sentecia ejecutada con advertencias"
            Else
                Salida = "Registro Fallido"
            End If

            CerraConection()
        Catch Sqlex As MySqlClient.MySqlException
            If Sqlex.Number = 1088 Then
                Salida = "Registro Duplicado"
            Else
                Salida = $"Un error inesperado ha ocurrido: {Sqlex.Number} - {Sqlex.Message}"

                If mostrarMensaje = True Then
                    MsgBox(Salida)
                End If
                'Dim log01 As New Log(1, $"Error {Sqlex.Message}", Date.Today, "")
            End If
        End Try

        Return Salida
    End Function

    Function CrearDb() As String
        Return Ejecutar(dbQuerys.getCrearDb(), False)
    End Function
End Class
