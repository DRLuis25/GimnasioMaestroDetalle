Imports CapaAccesoDatos.My
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class GrupoAD
    Public Function listarGrupos(objC As Curso) As List(Of Grupo)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand
        Dim Lista As New List(Of Grupo)
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_Grupos_Curso"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@curso", SqlDbType.VarChar, 50).Value = Trim(objC.nombreCurso)
            Dim Lector As SqlDataReader
            Lector = cmd.ExecuteReader
            While Lector.Read
                Lista.Add(New Grupo With {.idGrupo = Lector.Item(0), .fechaInicio = Lector.Item(1),
                          .fechaFin = Lector.Item(2), .idHorario = Lector(3)})
            End While
            Return Lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try


    End Function
End Class