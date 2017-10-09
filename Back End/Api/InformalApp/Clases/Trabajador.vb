Public Class Trabajador
    Inherits Persona 'Herencia de la Clase Persona'

    'Atributos de la Clase Trabajador'
    Private _Id As Integer 'Código del Trabajador'
    Private _ExpLaboral As String 'Experiencia Laboral del Trabajador'
    Private _Profesion As String 'Profesión que ejerce el Trabajador'
    Private _LvlEducativo As String 'Nivel Educativo del Trabajador (Primaria, Bachiller, Entre otros)'
    Private _HojVid As Boolean 'Indica si el trabajador tiene Hoja de Vida (Si/No)'

    'Propiedades de la Clase'

    'Propiedad Código de Trabajador'
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property 'Fin Propiedad Id'

    'Propiedad Experiencia Laboral de Trabajador'
    Public Property ExpLaboral() As String
        Get
            Return _ExpLaboral
        End Get
        Set(ByVal value As String)
            _ExpLaboral = value
        End Set
    End Property 'Fin Propiedad ExpLaboral'

    'Propiedad Profesión de Trabajador'
    Public Property Profesion() As String
        Get
            Return _Profesion
        End Get
        Set(ByVal value As String)
            _Profesion = value
        End Set
    End Property 'Fin Propiedad Profesion'

    'Propiedad Nivel Educativo de Trabajador'
    Public Property LvlEducativo() As String
        Get
            Return _LvlEducativo
        End Get
        Set(ByVal value As String)
            _LvlEducativo = value
        End Set
    End Property 'Fin Propiedad lvlEducativo'

    'Propiedad Hoja de Vida de Trabajador'
    Public Property HojVid() As Boolean
        Get
            Return _HojVid
        End Get
        Set(ByVal value As Boolean)
            _HojVid = value
        End Set
    End Property 'Fin Propiedad HojVid'

    'CONSTRUCTOR de la Clase Trabajador'
    Public Sub New(ByVal P1DocIdentidad,
                   ByVal P2Nombres,
                   ByVal P3Apellidos,
                   ByVal P4Genero,
                   ByVal P5FecNacimiento,
                   ByVal P6Id,
                   ByVal P7ExpLaboral,
                   ByVal P8Profesion,
                   ByVal P9LvlEducativo,
                   ByVal P10HojVid)

        'Atributos heredados de la Clase Persona'
        MyBase.New(P1DocIdentidad,
                   P2Nombres,
                   P3Apellidos,
                   P4Genero,
                   P5FecNacimiento)
        'Atributos de la Clase Trabajador'
        Me.Id = P6Id
        Me.ExpLaboral = P7ExpLaboral
        Me.Profesion = P8Profesion
        Me.LvlEducativo = P9LvlEducativo
        Me.HojVid = P10HojVid

    End Sub 'Fin CONSTRUTOR'
End Class 'Fin Clase Trabajador'