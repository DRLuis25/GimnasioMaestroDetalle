Imports CapaEntidad
Imports CapaAccesoDatos
Public Class PersonaLN
    Public Shared Function BuscarPersona(objA As Persona) As String
        Dim objAD As New PersonaAD
        Return objAD.BuscarPersona(objA)
    End Function

    Public Shared Function ListarClientesRegistrados(objG As Grupo) As List(Of Persona)
        Try
            Dim objAD As New PersonaAD
            Return objAD.ListarClientesRegistrados(objG)
        Catch ex2 As Exception
            Throw ex2
        End Try

    End Function
End Class
