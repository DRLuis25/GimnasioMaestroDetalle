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
        Dim objP As New Persona
        objP.DNI = txtDNI.Text
        txtApyNom.Text = ClienteLN.BuscarCliente(objP)
    End Sub
End Class
