Imports CapaEntidad
Imports CapaAccesoDatos
Public Class GrupoLN
    Public Shared Function listarGrupos(objC As Curso) As List(Of Grupo)
        Dim objAD As New GrupoAD
        Return objAD.listarGrupos(objC)
    End Function
End Class
