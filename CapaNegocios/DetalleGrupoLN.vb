Imports CapaEntidad
Imports CapaAccesoDatos
Public Class DetalleGrupoLN
    Public Shared Sub RegistrarNuevoDetalle(objDG As DetalleGrupo)
        Dim objAD As New DetalleGrupoAD
        objAD.RegistrarNuevoDetalle(objDG)
    End Sub
End Class
