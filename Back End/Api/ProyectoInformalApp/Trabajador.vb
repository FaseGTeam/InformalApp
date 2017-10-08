Public Class Trabajador
    Inherits Persona
    Private _Id As Integer
    Private _NivelEstudios As String

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property NivelEstudios() As String
        Get
            Return _NivelEstudios
        End Get
        Set(ByVal value As String)
            _NivelEstudios = value
        End Set
    End Property

    Public Sub New(ByVal PApellidos,
                   ByVal PNombres,
                   ByVal PSexo,
                   ByVal PFechaNacimiento,
                   ByVal PDocumento,
                   ByVal PId,
                   ByVal PNivelEstudios)
        MyBase.New(
            PApellidos,
            PNombres,
            PSexo,
            PFechaNacimiento,
            PDocumento
        )

        Me.Id = PId
        Me.NivelEstudios = PNivelEstudios
    End Sub
End Class