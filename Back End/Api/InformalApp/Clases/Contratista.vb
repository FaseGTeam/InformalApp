Public Class Contratista
    Inherits Persona 'Herencia de la Clase Persona'

    'Atributos de la Clase Contratista'
    Private _Id As Integer 'Código del Contratista'
    Private _EmpContatista As String 'Empresa a la que pertenece el contratista (Opcional)'
    Private _Cargo As String 'Carqo que posee el Contratista

    'Propiedades de la Clase Contratista'

    'Propiedad Código de Contratista'
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property 'Fin Propieddad Id'

    'Propiedad Empresa a la que pertence el Contratista'
    Public Property EmpContratista() As String
        Get
            Return _EmpContatista
        End Get
        Set(ByVal value As String)
            _EmpContatista = value
        End Set
    End Property 'Fin Propiedad EmpContratista'

    'Propiedad Cargo de Contratista'
    Public Property Cargo() As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property 'Fin Propiedad Cargo'

    'CONSTRUCTOR de la Clase Contratista'
    Public Sub New(ByVal P1DocIdentidad As Integer,
                   ByVal P2Nombres As String,
                   ByVal P3Apellidos As String,
                   ByVal P4Genero As String,
                   ByVal P5FecNacimiento As String,
                   ByVal P6Id As Integer,
                   ByVal P8EmpContratista As String,
                   ByVal P9Cargo As String)

        'Atributos heredados de la Clase Persona'
        MyBase.New(P1DocIdentidad,
                   P2Nombres,
                   P3Apellidos,
                   P4Genero,
                   P5FecNacimiento)
        'Atributos de la Clase Contratista'
        Me.Id = P6Id
        Me.EmpContratista = P8EmpContratista
        Me.Cargo = P9Cargo

    End Sub 'Fin CONSTRUTOR'

End Class 'Fin Clase Contratista'
