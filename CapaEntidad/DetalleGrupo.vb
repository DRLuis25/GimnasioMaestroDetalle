Public Class DetalleGrupo
    Private m_idGrupo As Integer
    Public Property idGrupo() As Integer
        Get
            Return m_idGrupo
        End Get
        Set(ByVal value As Integer)
            m_idGrupo = value
        End Set
    End Property
    Private m_idCliente As Integer
    Public Property idCliente() As Integer
        Get
            Return m_idCliente
        End Get
        Set(ByVal value As Integer)
            m_idCliente = value
        End Set
    End Property
    Private m_FechaInscripcion As Date
    Public Property FechaInscripcion() As Date
        Get
            Return m_FechaInscripcion
        End Get
        Set(ByVal value As Date)
            m_FechaInscripcion = value
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
    Private m_MedioDePago As String
    Public Property MedioDePago() As String
        Get
            Return m_MedioDePago
        End Get
        Set(ByVal value As String)
            m_MedioDePago = value
        End Set
    End Property
    Private m_Monto As Double
    Public Property Monto() As Double
        Get
            Return m_Monto
        End Get
        Set(ByVal value As Double)
            m_Monto = value
        End Set
    End Property
    Private m_idPrecio As Integer
    Public Property idPrecio() As Integer
        Get
            Return m_idPrecio
        End Get
        Set(ByVal value As Integer)
            m_idPrecio = value
        End Set
    End Property
End Class
