Imports CapaEntidad
Imports CapaAccesoDatos
Public Class ClienteLN
    Public Shared Function BuscarCliente(objC As Cliente) As String
        Dim objAD As New ClienteAD
        Return objAD.BuscarCliente(objC)
    End Function
End Class
