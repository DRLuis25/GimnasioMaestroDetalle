Public Class Cliente
    Private m_idCliente As Integer
    Private m_DNI As String
    Private m_FechaCreacion As Date

    Public Property FechaCreacion() As Date
        Get
            Return m_FechaCreacion
        End Get
        Set(ByVal value As Date)
            m_FechaCreacion = value
        End Set
    End Property

    Public Property DNI() As String
        Get
            Return m_DNI
        End Get
        Set(ByVal value As String)
            m_DNI = value
        End Set
    End Property

    Public Property idCliente() As Integer
        Get
            Return m_idCliente
        End Get
        Set(ByVal value As Integer)
            m_idCliente = value
        End Set
    End Property
End Class
