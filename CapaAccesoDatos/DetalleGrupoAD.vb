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
