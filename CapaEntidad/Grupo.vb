Imports CapaEntidad.DetalleGrupo
Public Class Grupo
    Private m_idGrupo As Integer
    Private m_NombreGrupo As String
    Private m_fechaInicio As Date
    Private m_fechaFin As Date
    Private m_idInstructor As Integer
    Private m_idHorario As Integer
    Private m_idCurso As Integer
    Private m_detalles As List(Of DetalleGrupo)


    Public Property ListDetalle() As List(Of DetalleGrupo)
        Get
            Return m_detalles
        End Get
        Set(ByVal value As List(Of DetalleGrupo))
            m_detalles = value
        End Set
    End Property

    Public Property idCurso() As Integer
        Get
            Return m_idCurso
        End Get
        Set(ByVal value As Integer)
            m_idCurso = value
        End Set
    End Property

    Public Property idHorario() As Integer
        Get
            Return m_idHorario
        End Get
        Set(ByVal value As Integer)
            m_idHorario = value
        End Set
    End Property

    Public Property idInstructor() As Integer
        Get
            Return m_idInstructor
        End Get
        Set(ByVal value As Integer)
            m_idInstructor = value
        End Set
    End Property

    Public Property fechaFin() As Date
        Get
            Return m_fechaFin
        End Get
        Set(ByVal value As Date)
            m_fechaFin = value
        End Set
    End Property

    Public Property fechaInicio() As Date
        Get
            Return m_fechaInicio
        End Get
        Set(ByVal value As Date)
            m_fechaInicio = value
        End Set
    End Property

    Public Property NombreGrupo() As String
        Get
            Return m_NombreGrupo
        End Get
        Set(ByVal value As String)
            m_NombreGrupo = value
        End Set
    End Property


    Public Property idGrupo() As Integer
        Get
            Return m_idGrupo
        End Get
        Set(ByVal value As Integer)
            m_idGrupo = value
        End Set
    End Property
End Class
