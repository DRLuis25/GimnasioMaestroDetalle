Imports CapaEntidad
Imports CapaAccesoDatos
Public Class DetalleGrupoLN
    Public Shared Sub RegistrarNuevoDetalle(objDG As DetalleGrupo)
        Dim objAD As New DetalleGrupoAD
        objAD.RegistrarNuevoDetalle(objDG)
    End Sub
    Public Shared Function ListarCupos(objDG As DetalleGrupo) As String
        Dim objAD As New DetalleGrupoAD
        Return objAD.ListarCupos(objDG)
    End Function
End Class
