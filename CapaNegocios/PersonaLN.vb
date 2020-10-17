Imports CapaEntidad
Imports CapaAccesoDatos
Public Class PersonaLN
    Public Shared Function BuscarPersona(objA As Persona) As String
        Dim objAD As New PersonaAD
        Return objAD.BuscarPersona(objA)
    End Function
End Class
