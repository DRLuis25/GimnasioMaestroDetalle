Imports CapaNegocios
Imports CapaEntidad
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged
        If txtDNI.Text.Length = 8 Then
            Dim objP As New Persona
            objP.DNI = txtDNI.Text
            txtApyNom.Text = PersonaLN.BuscarPersona(objP)
        Else
            txtApyNom.Text = ""
        End If
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GimnasioDataSet.sp_ListarCursos' Puede moverla o quitarla según sea necesario.
        Me.Sp_ListarCursosTableAdapter.Fill(Me.GimnasioDataSet.sp_ListarCursos)
        Dim row0 As String() = {"1", "29", "Revolution 9", "Beatles", "Beatles", "The Beatles [White Album]"}
        Dim row1 As String() = {"2", "6", "Fools Rush In", "Beatles", "Frank Sinatra", "Nice 'N' Easy"}
        dgvListaGrupos.Rows.Add(row0)
        dgvListaGrupos.Rows.Add(row1)
        'Me.Sp_ListarCursosTableAdapter.Fill(Me.GimnasioDataSet.sp_ListarCursos)'
        Dim objC As New Curso
        objC.nombreCurso = "Curso de Spinning" 'cmbCurso.SelectedIndex'
        Dim objH As New Horario
        Dim objDG As New DetalleGrupo
        Dim Lista As New List(Of Grupo)
        Lista = GrupoLN.listarGrupos(objC)
        For Each item As Grupo In Lista
            objH.IdHorario = item.idHorario
            objDG.idGrupo = item.idGrupo
            dgvListaGrupos.Rows.Add(item.idGrupo, item.NombreGrupo, HorarioLN.ListarHoras(objH),
                                    item.fechaInicio, item.fechaFin, DetalleGrupoLN.ListarCupos(objDG))
        Next


    End Sub

    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Dim objP As New Cliente
        objP.DNI = txtDNI.Text
        Dim idCliente As String
        Dim nroFila As Integer
        Dim idGrupo As String
        Dim mPago As String
        idCliente = ClienteLN.BuscarCliente(objP)
        If dgvListaGrupos.SelectedRows.Count > 0 Then
            nroFila = dgvListaGrupos.CurrentRow.Index
            idGrupo = dgvListaGrupos.Rows(nroFila).Cells(0).Value
            'Label4.Text = nroGrupo
            If cbmMPago.Text = "Contado" Then
                mPago = "2"
            ElseIf cbmMPago.Text = "Tarjeta Debito" Then
                mPago = "1"
            Else
                mPago = "0"
            End If
            Dim objDG As New DetalleGrupo
            objDG.idGrupo = idGrupo
            objDG.idCliente = idCliente
            objDG.MedioDePago = mPago
            DetalleGrupoLN.RegistrarNuevoDetalle(objDG)
        End If
    End Sub
End Class
