Public Class Log
    'Atributos de la Clase Log'
    Private _Id As Integer 'Código del Log'
    Private _Accion As String 'Acción que se realizó y es Registrada en el Log'
    Private _FechaAccion As Date 'Fecha en la que se realizó la correspondiente Acción'
    Private _Usuario As String 'Usuario responsable de la acción que se realizó'

    'Propiedades de los Atributos de la Clase Log'

    'Propiedad Código de Log'
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property 'Fin Propiedad Id'

    'Propiedad Acción Realizada de Log'
    Public Property Accion() As String
        Get
            Return _Accion
        End Get
        Set(ByVal value As String)
            _Accion = value
        End Set
    End Property 'Fin Propiedad Acción'

    'Propiedad Fecha de la Acción de Log'
    Public Property FechaAccion() As Date
        Get
            Return _FechaAccion
        End Get
        Set(ByVal value As Date)
            _FechaAccion = value
        End Set
    End Property 'Fin Propiedad FechaAccion'

    'Propiedad Usuario de la Acción de Log'
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property 'Fin Propiedad Usuario'

    'CONSTRUCTOR de la Clase Log'
    Public Sub New(ByVal P1Id As Integer,
                   ByVal P2Accion As String,
                   ByVal P3FechaAccion As Date,
                   ByVal P4Usuario As String)

        Me.Id = P1Id
        Me.Accion = P2Accion
        Me.FechaAccion = P3FechaAccion
        Me.Usuario = P4Usuario
    End Sub 'Fin CONSTRUCTOR'

End Class 'Fin de la Clase Log'