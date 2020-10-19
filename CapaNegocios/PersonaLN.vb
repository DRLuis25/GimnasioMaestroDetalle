Imports CapaEntidad
Imports CapaAccesoDatos
Public Class PersonaLN
    Public Shared Function BuscarPersona(objA As Persona) As String
        Dim objAD As New PersonaAD
        Return objAD.BuscarPersona(objA)
    End Function

    Public Shared Function ListarClientesRegistrados(objG As Grupo) As List(Of Persona)
        Dim objAD As New PersonaAD
        Return objAD.ListarClientesRegistrados(objG)
    End Function
End Class
