Imports CapaEntidad
Imports CapaAccesoDatos
Public Class DetalleGrupoLN
    Public Shared Function ListarCupos(objDG As DetalleGrupo) As String
        Dim objAD As New DetalleGrupoAD
        Return objAD.ListarCupos(objDG)
    End Function
End Class
