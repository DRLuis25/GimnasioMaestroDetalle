
Public Class Horario
    Private m_idHorario As Integer
    Private m_HoraInicio As DateTime
    Private m_HoraFin As DateTime

    Public Property IdHorario() As Integer
        Get
            Return m_idHorario
        End Get
        Set(ByVal value As Integer)
            m_idHorario = value
        End Set
    End Property

    Public Property HorarioInicio() As DateTime
        Get
            Return m_HoraInicio
        End Get
        Set(ByVal value As DateTime)
            m_HoraInicio = value
        End Set
    End Property


    Public Property HorarioFin() As DateTime
        Get
            Return m_HoraFin
        End Get
        Set(ByVal value As DateTime)
            m_HoraFin = value
        End Set
    End Property
End Class
