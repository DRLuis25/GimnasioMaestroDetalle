<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtApyNom = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvListaGrupos = New System.Windows.Forms.DataGridView()
        Me.colnomGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaTerm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCupos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SpListarCursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GimnasioDataSet = New ProgramaMaestroDetalle.GimnasioDataSet()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.btnListarMiembros = New System.Windows.Forms.Button()
        Me.Sp_ListarCursosTableAdapter = New ProgramaMaestroDetalle.GimnasioDataSetTableAdapters.sp_ListarCursosTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListaGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpListarCursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GimnasioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApyNom)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente"
        '
        'txtApyNom
        '
        Me.txtApyNom.Location = New System.Drawing.Point(151, 63)
        Me.txtApyNom.Name = "txtApyNom"
        Me.txtApyNom.ReadOnly = True
        Me.txtApyNom.Size = New System.Drawing.Size(229, 20)
        Me.txtApyNom.TabIndex = 3
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(151, 35)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos y Nombres"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListaGrupos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 270)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Grupo"
        '
        'dgvListaGrupos
        '
        Me.dgvListaGrupos.AllowUserToAddRows = False
        Me.dgvListaGrupos.AllowUserToDeleteRows = False
        Me.dgvListaGrupos.AllowUserToResizeColumns = False
        Me.dgvListaGrupos.AllowUserToResizeRows = False
        Me.dgvListaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnomGrupo, Me.colNombCurso, Me.colHorario, Me.colFechaInicio, Me.colFechaTerm, Me.colCupos})
        Me.dgvListaGrupos.Location = New System.Drawing.Point(15, 84)
        Me.dgvListaGrupos.Name = "dgvListaGrupos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvListaGrupos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaGrupos.Size = New System.Drawing.Size(697, 160)
        Me.dgvListaGrupos.TabIndex = 3
        '
        'colnomGrupo
        '
        Me.colnomGrupo.HeaderText = "Nombre Grupo"
        Me.colnomGrupo.Name = "colnomGrupo"
        Me.colnomGrupo.ReadOnly = True
        '
        'colNombCurso
        '
        Me.colNombCurso.HeaderText = "Nombre Curso"
        Me.colNombCurso.Name = "colNombCurso"
        Me.colNombCurso.ReadOnly = True
        Me.colNombCurso.Width = 150
        '
        'colHorario
        '
        Me.colHorario.HeaderText = "Horario"
        Me.colHorario.Name = "colHorario"
        Me.colHorario.ReadOnly = True
        '
        'colFechaInicio
        '
        Me.colFechaInicio.HeaderText = "Fecha Inicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.ReadOnly = True
        '
        'colFechaTerm
        '
        Me.colFechaTerm.HeaderText = "Fecha Término"
        Me.colFechaTerm.Name = "colFechaTerm"
        Me.colFechaTerm.ReadOnly = True
        '
        'colCupos
        '
        Me.colCupos.HeaderText = "Cupos Disp."
        Me.colCupos.Name = "colCupos"
        Me.colCupos.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Curso"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SpListarCursosBindingSource, "nombreCurso", True))
        Me.ComboBox1.DataSource = Me.SpListarCursosBindingSource
        Me.ComboBox1.DisplayMember = "nombreCurso"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(566, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "nombreCurso"
        '
        'SpListarCursosBindingSource
        '
        Me.SpListarCursosBindingSource.DataMember = "sp_ListarCursos"
        Me.SpListarCursosBindingSource.DataSource = Me.GimnasioDataSet
        '
        'GimnasioDataSet
        '
        Me.GimnasioDataSet.DataSetName = "GimnasioDataSet"
        Me.GimnasioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(589, 65)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrarCliente.TabIndex = 5
        Me.btnRegistrarCliente.Text = "Registrar Grupo"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = True
        '
        'btnListarMiembros
        '
        Me.btnListarMiembros.Location = New System.Drawing.Point(578, 98)
        Me.btnListarMiembros.Name = "btnListarMiembros"
        Me.btnListarMiembros.Size = New System.Drawing.Size(102, 23)
        Me.btnListarMiembros.TabIndex = 6
        Me.btnListarMiembros.Text = "Listar miembros"
        Me.btnListarMiembros.UseVisualStyleBackColor = True
        '
        'Sp_ListarCursosTableAdapter
        '
        Me.Sp_ListarCursosTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 445)
        Me.Controls.Add(Me.btnListarMiembros)
        Me.Controls.Add(Me.btnRegistrarCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Mantenimiento de Grupos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvListaGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpListarCursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GimnasioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtApyNom As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnRegistrarCliente As Button
    Friend WithEvents btnListarMiembros As Button
    Friend WithEvents dgvListaGrupos As DataGridView
    Friend WithEvents GimnasioDataSet As GimnasioDataSet
    Friend WithEvents SpListarCursosBindingSource As BindingSource
    Friend WithEvents Sp_ListarCursosTableAdapter As GimnasioDataSetTableAdapters.sp_ListarCursosTableAdapter
    Friend WithEvents colnomGrupo As DataGridViewTextBoxColumn
    Friend WithEvents colNombCurso As DataGridViewTextBoxColumn
    Friend WithEvents colHorario As DataGridViewTextBoxColumn
    Friend WithEvents colFechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents colFechaTerm As DataGridViewTextBoxColumn
    Friend WithEvents colCupos As DataGridViewTextBoxColumn
End Class
