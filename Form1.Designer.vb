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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbmMPago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApyNom = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvListaGrupos = New System.Windows.Forms.DataGridView()
        Me.colidGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaTerm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCupos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.SpListarCursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GimnasioDataSet = New ProgramaMaestroDetalle.GimnasioDataSet()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.btnListarMiembros = New System.Windows.Forms.Button()
        Me.Sp_ListarCursosTableAdapter = New ProgramaMaestroDetalle.GimnasioDataSetTableAdapters.sp_ListarCursosTableAdapter()
        Me.dgvListaClientes = New System.Windows.Forms.DataGridView()
        Me.colDNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListaGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpListarCursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GimnasioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbmMPago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtApyNom)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 142)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente"
        '
        'cbmMPago
        '
        Me.cbmMPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmMPago.FormattingEnabled = True
        Me.cbmMPago.Items.AddRange(New Object() {"", "Contado", "Tarjeta Debito", "Tarjeta Crédito"})
        Me.cbmMPago.Location = New System.Drawing.Point(148, 70)
        Me.cbmMPago.Name = "cbmMPago"
        Me.cbmMPago.Size = New System.Drawing.Size(127, 21)
        Me.cbmMPago.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Método de Pago"
        '
        'txtApyNom
        '
        Me.txtApyNom.Location = New System.Drawing.Point(148, 106)
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
        Me.Label2.Location = New System.Drawing.Point(21, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos y Nombres"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListaGrupos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbCurso)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 223)
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
        Me.dgvListaGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidGrupo, Me.colNombCurso, Me.colHorario, Me.colFechaInicio, Me.colFechaTerm, Me.colCupos})
        Me.dgvListaGrupos.Location = New System.Drawing.Point(15, 49)
        Me.dgvListaGrupos.MultiSelect = False
        Me.dgvListaGrupos.Name = "dgvListaGrupos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvListaGrupos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaGrupos.Size = New System.Drawing.Size(770, 160)
        Me.dgvListaGrupos.TabIndex = 3
        '
        'colidGrupo
        '
        Me.colidGrupo.HeaderText = "ID Grupo"
        Me.colidGrupo.Name = "colidGrupo"
        Me.colidGrupo.ReadOnly = True
        '
        'colNombCurso
        '
        Me.colNombCurso.HeaderText = "Nombre Grupo"
        Me.colNombCurso.Name = "colNombCurso"
        Me.colNombCurso.ReadOnly = True
        Me.colNombCurso.Width = 150
        '
        'colHorario
        '
        Me.colHorario.HeaderText = "Horario"
        Me.colHorario.Name = "colHorario"
        Me.colHorario.ReadOnly = True
        Me.colHorario.Width = 120
        '
        'colFechaInicio
        '
        Me.colFechaInicio.HeaderText = "Fecha Inicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.ReadOnly = True
        Me.colFechaInicio.Width = 120
        '
        'colFechaTerm
        '
        Me.colFechaTerm.HeaderText = "Fecha Término"
        Me.colFechaTerm.Name = "colFechaTerm"
        Me.colFechaTerm.ReadOnly = True
        Me.colFechaTerm.Width = 120
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
        Me.Label3.Location = New System.Drawing.Point(516, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Curso"
        '
        'cmbCurso
        '
        Me.cmbCurso.DataSource = Me.SpListarCursosBindingSource
        Me.cmbCurso.DisplayMember = "nombreCurso"
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(571, 14)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(214, 21)
        Me.cmbCurso.TabIndex = 1
        Me.cmbCurso.ValueMember = "nombreCurso"
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
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(559, 50)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(146, 23)
        Me.btnRegistrarCliente.TabIndex = 5
        Me.btnRegistrarCliente.Text = "Registrar Cliente en Grupo"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = True
        '
        'btnListarMiembros
        '
        Me.btnListarMiembros.Location = New System.Drawing.Point(559, 94)
        Me.btnListarMiembros.Name = "btnListarMiembros"
        Me.btnListarMiembros.Size = New System.Drawing.Size(146, 23)
        Me.btnListarMiembros.TabIndex = 6
        Me.btnListarMiembros.Text = "Listar miembros"
        Me.btnListarMiembros.UseVisualStyleBackColor = True
        '
        'Sp_ListarCursosTableAdapter
        '
        Me.Sp_ListarCursosTableAdapter.ClearBeforeFill = True
        '
        'dgvListaClientes
        '
        Me.dgvListaClientes.AllowUserToAddRows = False
        Me.dgvListaClientes.AllowUserToDeleteRows = False
        Me.dgvListaClientes.AllowUserToResizeColumns = False
        Me.dgvListaClientes.AllowUserToResizeRows = False
        Me.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDNI, Me.colApPaterno, Me.colApMaterno, Me.colNombres, Me.coltelefono, Me.colcorreo, Me.colEdad})
        Me.dgvListaClientes.Location = New System.Drawing.Point(15, 28)
        Me.dgvListaClientes.MultiSelect = False
        Me.dgvListaClientes.Name = "dgvListaClientes"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvListaClientes.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaClientes.Size = New System.Drawing.Size(755, 150)
        Me.dgvListaClientes.TabIndex = 8
        '
        'colDNI
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDNI.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDNI.HeaderText = "DNI"
        Me.colDNI.Name = "colDNI"
        Me.colDNI.ReadOnly = True
        Me.colDNI.Width = 90
        '
        'colApPaterno
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colApPaterno.DefaultCellStyle = DataGridViewCellStyle3
        Me.colApPaterno.HeaderText = "Ap. Paterno"
        Me.colApPaterno.Name = "colApPaterno"
        Me.colApPaterno.ReadOnly = True
        Me.colApPaterno.Width = 90
        '
        'colApMaterno
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colApMaterno.DefaultCellStyle = DataGridViewCellStyle4
        Me.colApMaterno.HeaderText = "Ap. Materno"
        Me.colApMaterno.Name = "colApMaterno"
        Me.colApMaterno.ReadOnly = True
        Me.colApMaterno.Width = 90
        '
        'colNombres
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNombres.DefaultCellStyle = DataGridViewCellStyle5
        Me.colNombres.HeaderText = "Nombres"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        Me.colNombres.Width = 90
        '
        'coltelefono
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.coltelefono.DefaultCellStyle = DataGridViewCellStyle6
        Me.coltelefono.HeaderText = "Teléfono"
        Me.coltelefono.Name = "coltelefono"
        Me.coltelefono.ReadOnly = True
        Me.coltelefono.Width = 90
        '
        'colcorreo
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colcorreo.DefaultCellStyle = DataGridViewCellStyle7
        Me.colcorreo.HeaderText = "Correo"
        Me.colcorreo.Name = "colcorreo"
        Me.colcorreo.ReadOnly = True
        Me.colcorreo.Width = 210
        '
        'colEdad
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colEdad.DefaultCellStyle = DataGridViewCellStyle8
        Me.colEdad.HeaderText = "Edad"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.ReadOnly = True
        Me.colEdad.Width = 50
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvListaClientes)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 389)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(785, 199)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clientes registrados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 604)
        Me.Controls.Add(Me.GroupBox3)
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
        CType(Me.dgvListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtApyNom As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCurso As ComboBox
    Friend WithEvents btnRegistrarCliente As Button
    Friend WithEvents btnListarMiembros As Button
    Friend WithEvents dgvListaGrupos As DataGridView
    Friend WithEvents GimnasioDataSet As GimnasioDataSet
    Friend WithEvents SpListarCursosBindingSource As BindingSource
    Friend WithEvents Sp_ListarCursosTableAdapter As GimnasioDataSetTableAdapters.sp_ListarCursosTableAdapter
    Friend WithEvents cbmMPago As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvListaClientes As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents colidGrupo As DataGridViewTextBoxColumn
    Friend WithEvents colNombCurso As DataGridViewTextBoxColumn
    Friend WithEvents colHorario As DataGridViewTextBoxColumn
    Friend WithEvents colFechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents colFechaTerm As DataGridViewTextBoxColumn
    Friend WithEvents colCupos As DataGridViewTextBoxColumn
    Friend WithEvents colDNI As DataGridViewTextBoxColumn
    Friend WithEvents colApPaterno As DataGridViewTextBoxColumn
    Friend WithEvents colApMaterno As DataGridViewTextBoxColumn
    Friend WithEvents colNombres As DataGridViewTextBoxColumn
    Friend WithEvents coltelefono As DataGridViewTextBoxColumn
    Friend WithEvents colcorreo As DataGridViewTextBoxColumn
    Friend WithEvents colEdad As DataGridViewTextBoxColumn
End Class
