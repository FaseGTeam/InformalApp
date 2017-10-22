Public Class Labor
    'Atributos de la clase Labor'
    Private _Id As Integer     'Código de la labor'
    Private _LabDes As String  'Descripción de la labor'
    Private _FecIniLab As Date 'Fecha de inicio de la labor'
    Private _FecFinLab As Date 'Fecha de finalización de la labor'
    Private _TipLab As Integer  'Tipo de labor'
    Private _Idcontratista As Integer  ' id contratista' 
    Private _Idtrabajador As Integer  'Id trabajador' 

    'Propiedades de los Atributos de la Clase Labor'

    'Propiedad Código Labor'
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property 'Fin Propiedad Id Labor'

    'Propiedad Descripción de Labor'
    Public Property LabDes() As String
        Get
            Return _LabDes
        End Get
        Set(ByVal value As String)
            _LabDes = value
        End Set
    End Property 'Fin Propiedad LabDes'

    'Propiedad Fecha de inicio de Labor'
    Public Property FecIniLab() As Date
        Get
            Return _FecIniLab
        End Get
        Set(ByVal value As Date)
            _FecIniLab = value
        End Set
    End Property ''Fin Propiedad FecIniLab

    'Propiedad Fecha de finalización de Labor'
    Public Property FecFinLab() As Date
        Get
            Return _FecFinLab
        End Get
        Set(ByVal value As Date)
            _FecFinLab = value
        End Set
    End Property 'Fin Propiedad FecFinLab'

    'Propiedad tipo de Labor'
    Public Property TipLab() As Integer
        Get
            Return _TipLab
        End Get
        Set(ByVal value As Integer)
            _TipLab = value
        End Set
    End Property 'Fin Propiedad TipLab'


    Public Property Idcontratista() As String
        Get
            Return _Idcontratista
        End Get
        Set(ByVal value As String)
            _Idcontratista = value
        End Set
    End Property

    Public Property Idtrabajador() As String
        Get
            Return _Idtrabajador
        End Get
        Set(ByVal value As String)
            _Idtrabajador = value
        End Set
    End Property

    'CONSTRUCTOR de la clase Labor'
    Sub New(ByVal P1Id As Integer,
            ByVal P2LabDes As String,
            ByVal P3FecIniLab As Date,
            ByVal P4FecFinLab As Date,
            ByVal P5TipLab As Integer,
            ByVal P6Idcontra As Integer,
            ByVal P7Idtrabajador As Integer)

        Me.Id = P1Id
        Me.LabDes = P2LabDes
        Me.FecIniLab = P3FecIniLab
        Me.FecFinLab = P4FecFinLab
        Me.TipLab = P5TipLab
        Me.Idcontratista = P6Idcontra
        Me.Idtrabajador = P7Idtrabajador
    End Sub 'Fin CONSTRUTOR'

End Class 'Fin clase Labor'
