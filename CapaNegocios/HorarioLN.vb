Imports CapaEntidad
Imports CapaAccesoDatos
Public Class HorarioLN
    Public Shared Function ListarHoras(objH As Horario) As String
        Dim objAD As New HorarioAD
        Return objAD.ListarHoras(objH)
    End Function
End Class
