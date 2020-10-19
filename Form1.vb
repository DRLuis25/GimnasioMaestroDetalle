Imports CapaNegocios
Imports CapaEntidad
Imports System.IO
Imports System.Drawing.Imaging

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
        Me.Sp_ListarCursosTableAdapter.Fill(Me.GimnasioDataSet.sp_ListarCursos) '
        ActualizarLista()
    End Sub

    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Try
            Dim objP As New Cliente
            objP.DNI = txtDNI.Text
            Dim idCliente As String
            Dim nroFila As Integer
            Dim idGrupo As String
            Dim mPago As String
            idCliente = ClienteLN.BuscarCliente(objP)
            If dgvListaGrupos.SelectedRows.Count = 1 And txtApyNom.Text <> "" And cbmMPago.Text <> "" Then
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
            Else
                MessageBox.Show("Error: Seleccione todos los campos")
            End If
            ActualizarLista()
        Catch ex As Exception
            MessageBox.Show("Error en el registro")
        End Try
    End Sub

    Private Sub cmbCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCurso.SelectedIndexChanged
        ActualizarLista()
    End Sub
    Private Sub ActualizarLista()
        dgvListaGrupos.Rows.Clear()
        Dim objC As New Curso
        objC.nombreCurso = cmbCurso.Text ' "Curso de Spinning" ''
        Dim objH As New Horario
        Dim objDG As New DetalleGrupo
        Dim Lista
        Lista = GrupoLN.listarGrupos(objC)
        For Each item As Grupo In Lista
            objH.IdHorario = item.idHorario
            objDG.idGrupo = item.idGrupo
            dgvListaGrupos.Rows.Add(item.idGrupo, item.NombreGrupo, HorarioLN.ListarHoras(objH), item.fechaInicio, item.fechaFin, DetalleGrupoLN.ListarCupos(objDG))
        Next
        dgvListaGrupos.ClearSelection()
    End Sub

    Private Sub btnListarMiembros_Click(sender As Object, e As EventArgs) Handles btnListarMiembros.Click
        dgvListaClientes.Rows.Clear()
        Dim nroFila As Integer
        Dim idGrupo As String
        If dgvListaGrupos.SelectedRows.Count = 1 Then

            nroFila = dgvListaGrupos.CurrentRow.Index
            idGrupo = dgvListaGrupos.Rows(nroFila).Cells(0).Value
            Dim objG As New Grupo
            objG.idGrupo = idGrupo
            Dim Lista
            Lista = PersonaLN.listarClientesRegistrados(objG)
            For Each item As Persona In Lista
                dgvListaClientes.Rows.Add(item.DNI, item.ApPaterno, item.ApMaterno, item.Nombres, item.Telefono, item.Correo, DateAndTime.DateDiff(DateInterval.Year, item.FechaNac, DateAndTime.Today))
            Next
            dgvListaGrupos.ClearSelection()
        Else
            MessageBox.Show("Seleccione un grupo")
        End If
    End Sub
End Class
