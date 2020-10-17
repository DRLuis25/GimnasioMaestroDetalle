Imports CapaAccesoDatos.My
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class ClienteAD
    Public Function BuscarCliente(objC As Cliente) As String
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_BuscarCliente"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNI", SqlDbType.Char, 8).Value = Trim(objC.DNI)
            Dim Lector As SqlDataReader
            Lector = cmd.ExecuteReader
            If Lector.HasRows = True Then
                While Lector.Read
                    objC.idCliente = Lector.Item(0)
                End While
            Else
                Return ""
            End If
            Return objC.idCliente.ToString()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try
    End Function
End Class
