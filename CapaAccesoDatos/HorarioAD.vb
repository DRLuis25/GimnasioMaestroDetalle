Imports CapaAccesoDatos.My
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class HorarioAD
    Public Function ListarHoras(objH As Horario) As String
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_Horario"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idHorario", SqlDbType.Int).Value = Trim(objH.IdHorario)
            Dim Lector As SqlDataReader
            Lector = cmd.ExecuteReader
            If Lector.HasRows = True Then
                While Lector.Read
                    Return Lector.Item(0) + "  -" + Lector.Item(1)
                End While
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try
        Return ""
    End Function
End Class
