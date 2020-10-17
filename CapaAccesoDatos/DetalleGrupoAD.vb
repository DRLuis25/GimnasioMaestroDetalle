Imports CapaAccesoDatos.My
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class DetalleGrupoAD
    Public Function ListarCupos(objDG As DetalleGrupo) As String
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_Cupos"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idGrupo", SqlDbType.Int).Value = Trim(objDG.idGrupo)
            Dim Lector As SqlDataReader
            Lector = cmd.ExecuteReader
            If Lector.HasRows = True Then
                While Lector.Read
                    Return Lector.Item(0)
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
Imports CapaAccesoDatos.My
Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DetalleGrupoAD
    Public Sub RegistrarNuevoDetalle(objDG As DetalleGrupo)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmdD As New SqlCommand("sp_RegistrarNuevoDetalleGrupo", cn)
        cmdD.CommandType = CommandType.StoredProcedure
        Dim tr As SqlTransaction = Nothing
        Try
            cn.Open()
            tr = cn.BeginTransaction
            cmdD.Transaction = tr
            cmdD.Parameters.Add("@idGrupo", SqlDbType.Int).Value = objDG.idGrupo
            cmdD.Parameters.Add("@idCliente", SqlDbType.Int).Value = objDG.idCliente
            cmdD.Parameters.Add("@MedioDePago", SqlDbType.Char, 1).Value = objDG.MedioDePago
            cmdD.ExecuteNonQuery()
            tr.Commit()
            MessageBox.Show("ingresado")
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub
End Class
