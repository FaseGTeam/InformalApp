Public Class Log
    Private _Id As Integer
    Private _Accion As String
    Private _Fecha As Date

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Accion() As String
        Get
            Return _Accion
        End Get
        Set(ByVal value As String)
            _Accion = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Public Sub New(ByVal PId,
                   ByVal PAccion,
                   ByVal PFecha)
        Me._Id = PId
        Me._Accion = PAccion
        Me._Fecha = PFecha
    End Sub
End Class