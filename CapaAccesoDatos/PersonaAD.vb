Imports CapaAccesoDatos.My
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class PersonaAD
    Public Function BuscarPersona(objA As Persona) As String
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_BuscarPersona"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNI", SqlDbType.Char, 8).Value = Trim(objA.DNI)
            Dim Lector As SqlDataReader
            Lector = cmd.ExecuteReader
            If Lector.HasRows = True Then
                While Lector.Read
                    objA.ApPaterno = Lector.Item(0)
                    objA.ApMaterno = Lector.Item(1)
                    objA.Nombres = Lector.Item(2)
                End While
            End If
            If objA.ApMaterno <> "" Then
                Return objA.ApPaterno + " " + objA.ApMaterno + ", " + objA.Nombres
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try
    End Function
End Class
