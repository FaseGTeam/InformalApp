Public Class Persona
    Private _Apellidos As String
    Private _Nombres As String
    Private _Sexo As String
    Private _FechaNacimiento As Date
    Private _Documento As Integer

    Public Property Apellidos() As String
        Get
            Return _Apellidos
        End Get
        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property

    Public Property Nombres() As String
        Get
            Return _Nombres
        End Get
        Set(ByVal value As String)
            _Nombres = value
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

    Public Property FechaNacimiento() As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal value As Date)
            _FechaNacimiento = value
        End Set
    End Property

    Public Property Documento() As Integer
        Get
            Return _Documento
        End Get
        Set(ByVal value As Integer)
            _Documento = value
        End Set
    End Property

    Public Sub New(ByVal PApellidos,
                   ByVal PNombres,
                   ByVal PSexo,
                   ByVal PFechaNacimiento,
                   ByVal PDocumento)
        Me.Apellidos = PApellidos
        Me.Nombres = PNombres
        Me.Sexo = PSexo
        Me.FechaNacimiento = PFechaNacimiento
        Me.Documento = PDocumento
    End Sub
End Class
