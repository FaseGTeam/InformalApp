Public Class Empleador
    Inherits Persona
    Private _Id As Integer
    Private _ActividadEconomica As String

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property ActividadEconomica() As String
        Get
            Return _ActividadEconomica
        End Get
        Set(ByVal value As String)
            _ActividadEconomica = value
        End Set
    End Property

    Public Sub New(ByVal PApellidos,
                   ByVal PNombres,
                   ByVal PSexo,
                   ByVal PFechaNacimiento,
                   ByVal PDocumento,
                   ByVal PId,
                   ByVal PActividadEconomica)
        MyBase.New(
            PApellidos,
            PNombres,
            PSexo,
            PFechaNacimiento,
            PDocumento
        )

        Me.Id = PId
        Me.ActividadEconomica = PActividadEconomica
    End Sub
End Class
