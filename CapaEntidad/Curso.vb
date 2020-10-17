Public Class Curso
    Private m_idCurso As Integer
    Public Property idCurso() As Integer
        Get
            Return m_idCurso
        End Get
        Set(ByVal value As Integer)
            m_idCurso = value
        End Set
    End Property
    Private m_nombreCurso As String
    Public Property nombreCurso() As String
        Get
            Return m_nombreCurso
        End Get
        Set(ByVal value As String)
            m_nombreCurso = value
        End Set
    End Property
    Private m_Estado As String
    Public Property Estado() As String
        Get
            Return m_Estado
        End Get
        Set(ByVal value As String)
            m_Estado = value
        End Set
    End Property
    Private m_idRutina As Integer
    Public Property idRutina() As Integer
        Get
            Return m_idRutina
        End Get
        Set(ByVal value As Integer)
            m_idRutina = value
        End Set
    End Property
End Class
