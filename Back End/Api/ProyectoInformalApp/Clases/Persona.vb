﻿Public Class Persona
    'Atributos de la Clase Persona'
    Private _DocIdentidad As Integer 'Documento de Identidad de la persona'
    Private _Nombres As String 'Nombres de la Persona'
    Private _Apellidos As String 'Apelllidos de la Persona'
    Private _Genero As String 'Género de la persona'
    Private _FecNacimiento As Date 'Fecha de Nacimiento de la Persona'

    'Propiedades de los Atributos de la clase Persona'

    'Propiedad Documento de Identidad de Persona'
    Public Property DocIdentidad() As String
        Get
            Return _DocIdentidad
        End Get
        Set(ByVal value As String)
            _DocIdentidad = value
        End Set
    End Property 'Fin Propiedad DocIdentidad'

    'Propiedad Nombres de Persona'
    Public Property Nombres() As String
        Get
            Return _Nombres
        End Get
        Set(ByVal value As String)
            _Nombres = value
        End Set
    End Property 'Fin Propiedad Nombres'

    'Propiedad Apellidos de Persona'
    Public Property Apellidos() As String
        Get
            Return _Apellidos
        End Get
        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property 'Fin Propiedad Apellidos'

    'Propiedad Género de Persona'
    Public Property Genero() As String
        Get
            Return _Genero
        End Get
        Set(ByVal value As String)
            _Genero = value
        End Set
    End Property 'Fin Propiedad Género'

    'Propiedad Fecha de Nacimiento de Persona'
    Public Property FecNacimiento() As Date
        Get
            Return _FecNacimiento
        End Get
        Set(ByVal value As Date)
            _FecNacimiento = value
        End Set
    End Property 'Fin Propiedad FechaNacimiento'

    'CONSTRUCTOR de la Clase Persona'
    Public Sub New(ByVal p1DocIdentidad As Integer,
                   ByVal P2Nombres As String,
                   ByVal P3Apellidos As String,
                   ByVal p4Genero As String,
                   ByVal p5FecNacimiento As Date)
        Me.DocIdentidad = p1DocIdentidad
        Me.Nombres = P2Nombres
        Me.Apellidos = P3Apellidos
        Me.Genero = p4Genero
        Me.FecNacimiento = p5FecNacimiento

    End Sub 'Fin CONSTRUCTOR'

End Class 'Fin Clase Persona'
