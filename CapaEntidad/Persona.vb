Public Class Persona
    Private m_DNI As String
    Public Property DNI() As String
        Get
            Return m_DNI
        End Get
        Set(ByVal value As String)
            m_DNI = value
        End Set
    End Property

    Private m_Nombres As String
    Public Property Nombres() As String
        Get
            Return m_Nombres
        End Get
        Set(ByVal value As String)
            m_Nombres = value
        End Set
    End Property
    Private m_ApPaterno As String
    Public Property ApPaterno() As String
        Get
            Return m_ApPaterno
        End Get
        Set(ByVal value As String)
            m_ApPaterno = value
        End Set
    End Property
    Private m_ApMaterno As String
    Public Property ApMaterno() As String
        Get
            Return m_ApMaterno
        End Get
        Set(ByVal value As String)
            m_ApMaterno = value
        End Set
    End Property
    Private m_FechaNac As Date
    Public Property FechaNac() As Date
        Get
            Return m_FechaNac
        End Get
        Set(ByVal value As Date)
            m_FechaNac = value
        End Set
    End Property
    Private m_Direccion As String
    Public Property Direccion() As String
        Get
            Return m_Direccion
        End Get
        Set(ByVal value As String)
            m_Direccion = value
        End Set
    End Property
    Private m_Telefono As String
    Public Property Telefono() As String
        Get
            Return m_Telefono
        End Get
        Set(ByVal value As String)
            m_Telefono = value
        End Set
    End Property
    Private m_Correo As String
    Public Property Correo() As String
        Get
            Return m_Correo
        End Get
        Set(ByVal value As String)
            m_Correo = value
        End Set
    End Property
    Private m_EstadoCivil As String
    Public Property EstadoCivil() As String
        Get
            Return m_EstadoCivil
        End Get
        Set(ByVal value As String)
            m_EstadoCivil = value
        End Set
    End Property
    Private m_Genero As String
    Public Property Genero() As String
        Get
            Return m_Genero
        End Get
        Set(ByVal value As String)
            m_Genero = value
        End Set
    End Property
End Class
