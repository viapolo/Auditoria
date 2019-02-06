<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAuditoriaMod
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AnexoLabel As System.Windows.Forms.Label
        Dim CicloLabel As System.Windows.Forms.Label
        Dim ObervacionesLabel As System.Windows.Forms.Label
        Dim EstatusLabel As System.Windows.Forms.Label
        Dim FechaRelizacionLabel As System.Windows.Forms.Label
        Dim FolAuditoriaLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim SucursalLabel As System.Windows.Forms.Label
        Dim TipoCreditoLabel As System.Windows.Forms.Label
        Dim RecursosLabel As System.Windows.Forms.Label
        Dim FechaDisposicionLabel As System.Windows.Forms.Label
        Dim EjecutivoLabel As System.Windows.Forms.Label
        Dim DestinoLabel As System.Windows.Forms.Label
        Dim MontoFinanciadoLabel As System.Windows.Forms.Label
        Dim MontoSolicitadoLabel As System.Windows.Forms.Label
        Dim FechaSolicitudLabel As System.Windows.Forms.Label
        Dim FechaAutorizacionLabel As System.Windows.Forms.Label
        Dim AnalistaLabel As System.Windows.Forms.Label
        Dim OrganoDeAutorizacionLabel As System.Windows.Forms.Label
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.AUDIT_AuditoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_AuditoriasTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter()
        Me.TableAdapterManager = New Auditoria.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.AnexoTextBox = New System.Windows.Forms.TextBox()
        Me.CicloTextBox = New System.Windows.Forms.TextBox()
        Me.ObervacionesTextBox = New System.Windows.Forms.TextBox()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDITParametrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_ParametrosTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosTableAdapter()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.AUDIT_AuditoriasCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_AuditoriasCondicionesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter()
        Me.AUDIT_AuditoriasCondicionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id_Condicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Validacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaHallazgo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_auditoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deptoResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolventacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_auditoriaCondicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Cond = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.AUDITCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDITParametrosVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.AUDIT_CondicionesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_CondicionesTableAdapter()
        Me.AUDIT_ParametrosVTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosVTableAdapter()
        Me.AUDITParametrosHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_ParametrosHTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosHTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.FechaRelizacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FolAuditoriaTextBox = New System.Windows.Forms.TextBox()
        Me.gbxdatosDelCredito = New System.Windows.Forms.GroupBox()
        Me.OrganoDeAutorizacionTextBox = New System.Windows.Forms.TextBox()
        Me.AnalistaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaAutorizacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaSolicitudDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MontoSolicitadoTextBox = New System.Windows.Forms.TextBox()
        Me.MontoFinanciadoTextBox = New System.Windows.Forms.TextBox()
        Me.DestinoTextBox = New System.Windows.Forms.TextBox()
        Me.EjecutivoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDisposicionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RecursosTextBox = New System.Windows.Forms.TextBox()
        Me.TipoCreditoTextBox = New System.Windows.Forms.TextBox()
        Me.SucursalTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        AnexoLabel = New System.Windows.Forms.Label()
        CicloLabel = New System.Windows.Forms.Label()
        ObervacionesLabel = New System.Windows.Forms.Label()
        EstatusLabel = New System.Windows.Forms.Label()
        FechaRelizacionLabel = New System.Windows.Forms.Label()
        FolAuditoriaLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        SucursalLabel = New System.Windows.Forms.Label()
        TipoCreditoLabel = New System.Windows.Forms.Label()
        RecursosLabel = New System.Windows.Forms.Label()
        FechaDisposicionLabel = New System.Windows.Forms.Label()
        EjecutivoLabel = New System.Windows.Forms.Label()
        DestinoLabel = New System.Windows.Forms.Label()
        MontoFinanciadoLabel = New System.Windows.Forms.Label()
        MontoSolicitadoLabel = New System.Windows.Forms.Label()
        FechaSolicitudLabel = New System.Windows.Forms.Label()
        FechaAutorizacionLabel = New System.Windows.Forms.Label()
        AnalistaLabel = New System.Windows.Forms.Label()
        OrganoDeAutorizacionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDIT_AuditoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxdatosDelCredito.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnexoLabel
        '
        AnexoLabel.AutoSize = True
        AnexoLabel.Location = New System.Drawing.Point(49, 15)
        AnexoLabel.Name = "AnexoLabel"
        AnexoLabel.Size = New System.Drawing.Size(40, 13)
        AnexoLabel.TabIndex = 1
        AnexoLabel.Text = "Anexo:"
        '
        'CicloLabel
        '
        CicloLabel.AutoSize = True
        CicloLabel.Location = New System.Drawing.Point(224, 15)
        CicloLabel.Name = "CicloLabel"
        CicloLabel.Size = New System.Drawing.Size(33, 13)
        CicloLabel.TabIndex = 2
        CicloLabel.Text = "Ciclo:"
        '
        'ObervacionesLabel
        '
        ObervacionesLabel.AutoSize = True
        ObervacionesLabel.Location = New System.Drawing.Point(13, 175)
        ObervacionesLabel.Name = "ObervacionesLabel"
        ObervacionesLabel.Size = New System.Drawing.Size(76, 13)
        ObervacionesLabel.TabIndex = 4
        ObervacionesLabel.Text = "Obervaciones:"
        '
        'EstatusLabel
        '
        EstatusLabel.AutoSize = True
        EstatusLabel.Location = New System.Drawing.Point(23, 570)
        EstatusLabel.Name = "EstatusLabel"
        EstatusLabel.Size = New System.Drawing.Size(45, 13)
        EstatusLabel.TabIndex = 6
        EstatusLabel.Text = "Estatus:"
        '
        'FechaRelizacionLabel
        '
        FechaRelizacionLabel.AutoSize = True
        FechaRelizacionLabel.Location = New System.Drawing.Point(221, 572)
        FechaRelizacionLabel.Name = "FechaRelizacionLabel"
        FechaRelizacionLabel.Size = New System.Drawing.Size(92, 13)
        FechaRelizacionLabel.TabIndex = 12
        FechaRelizacionLabel.Text = "Fecha Relizacion:"
        '
        'FolAuditoriaLabel
        '
        FolAuditoriaLabel.AutoSize = True
        FolAuditoriaLabel.Location = New System.Drawing.Point(970, 201)
        FolAuditoriaLabel.Name = "FolAuditoriaLabel"
        FolAuditoriaLabel.Size = New System.Drawing.Size(68, 13)
        FolAuditoriaLabel.TabIndex = 14
        FolAuditoriaLabel.Text = "No Auditoria:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(11, 22)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 0
        ClienteLabel.Text = "Cliente:"
        '
        'SucursalLabel
        '
        SucursalLabel.AutoSize = True
        SucursalLabel.Location = New System.Drawing.Point(11, 48)
        SucursalLabel.Name = "SucursalLabel"
        SucursalLabel.Size = New System.Drawing.Size(51, 13)
        SucursalLabel.TabIndex = 2
        SucursalLabel.Text = "Sucursal:"
        '
        'TipoCreditoLabel
        '
        TipoCreditoLabel.AutoSize = True
        TipoCreditoLabel.Location = New System.Drawing.Point(11, 73)
        TipoCreditoLabel.Name = "TipoCreditoLabel"
        TipoCreditoLabel.Size = New System.Drawing.Size(82, 13)
        TipoCreditoLabel.TabIndex = 4
        TipoCreditoLabel.Text = "Tipo de Crédito:"
        '
        'RecursosLabel
        '
        RecursosLabel.AutoSize = True
        RecursosLabel.Location = New System.Drawing.Point(11, 99)
        RecursosLabel.Name = "RecursosLabel"
        RecursosLabel.Size = New System.Drawing.Size(55, 13)
        RecursosLabel.TabIndex = 6
        RecursosLabel.Text = "Recursos:"
        '
        'FechaDisposicionLabel
        '
        FechaDisposicionLabel.AutoSize = True
        FechaDisposicionLabel.Location = New System.Drawing.Point(373, 23)
        FechaDisposicionLabel.Name = "FechaDisposicionLabel"
        FechaDisposicionLabel.Size = New System.Drawing.Size(112, 13)
        FechaDisposicionLabel.TabIndex = 8
        FechaDisposicionLabel.Text = "Fecha de Disposicion:"
        '
        'EjecutivoLabel
        '
        EjecutivoLabel.AutoSize = True
        EjecutivoLabel.Location = New System.Drawing.Point(386, 51)
        EjecutivoLabel.Name = "EjecutivoLabel"
        EjecutivoLabel.Size = New System.Drawing.Size(54, 13)
        EjecutivoLabel.TabIndex = 10
        EjecutivoLabel.Text = "Ejecutivo:"
        '
        'DestinoLabel
        '
        DestinoLabel.AutoSize = True
        DestinoLabel.Location = New System.Drawing.Point(395, 74)
        DestinoLabel.Name = "DestinoLabel"
        DestinoLabel.Size = New System.Drawing.Size(46, 13)
        DestinoLabel.TabIndex = 12
        DestinoLabel.Text = "Destino:"
        '
        'MontoFinanciadoLabel
        '
        MontoFinanciadoLabel.AutoSize = True
        MontoFinanciadoLabel.Location = New System.Drawing.Point(944, 19)
        MontoFinanciadoLabel.Name = "MontoFinanciadoLabel"
        MontoFinanciadoLabel.Size = New System.Drawing.Size(95, 13)
        MontoFinanciadoLabel.TabIndex = 14
        MontoFinanciadoLabel.Text = "Monto Financiado:"
        '
        'MontoSolicitadoLabel
        '
        MontoSolicitadoLabel.AutoSize = True
        MontoSolicitadoLabel.Location = New System.Drawing.Point(705, 19)
        MontoSolicitadoLabel.Name = "MontoSolicitadoLabel"
        MontoSolicitadoLabel.Size = New System.Drawing.Size(89, 13)
        MontoSolicitadoLabel.TabIndex = 16
        MontoSolicitadoLabel.Text = "Monto Solicitado:"
        '
        'FechaSolicitudLabel
        '
        FechaSolicitudLabel.AutoSize = True
        FechaSolicitudLabel.Location = New System.Drawing.Point(843, 51)
        FechaSolicitudLabel.Name = "FechaSolicitudLabel"
        FechaSolicitudLabel.Size = New System.Drawing.Size(98, 13)
        FechaSolicitudLabel.TabIndex = 18
        FechaSolicitudLabel.Text = "Fecha de Solicitud:"
        '
        'FechaAutorizacionLabel
        '
        FechaAutorizacionLabel.AutoSize = True
        FechaAutorizacionLabel.Location = New System.Drawing.Point(825, 74)
        FechaAutorizacionLabel.Name = "FechaAutorizacionLabel"
        FechaAutorizacionLabel.Size = New System.Drawing.Size(116, 13)
        FechaAutorizacionLabel.TabIndex = 20
        FechaAutorizacionLabel.Text = "Fecha de Autorización:"
        '
        'AnalistaLabel
        '
        AnalistaLabel.AutoSize = True
        AnalistaLabel.Location = New System.Drawing.Point(393, 99)
        AnalistaLabel.Name = "AnalistaLabel"
        AnalistaLabel.Size = New System.Drawing.Size(47, 13)
        AnalistaLabel.TabIndex = 22
        AnalistaLabel.Text = "Analista:"
        '
        'OrganoDeAutorizacionLabel
        '
        OrganoDeAutorizacionLabel.AutoSize = True
        OrganoDeAutorizacionLabel.Location = New System.Drawing.Point(719, 99)
        OrganoDeAutorizacionLabel.Name = "OrganoDeAutorizacionLabel"
        OrganoDeAutorizacionLabel.Size = New System.Drawing.Size(121, 13)
        OrganoDeAutorizacionLabel.TabIndex = 24
        OrganoDeAutorizacionLabel.Text = "Organo de Autorizacion:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AUDIT_AuditoriasBindingSource
        '
        Me.AUDIT_AuditoriasBindingSource.DataMember = "AUDIT_Auditorias"
        Me.AUDIT_AuditoriasBindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDIT_AuditoriasTableAdapter
        '
        Me.AUDIT_AuditoriasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActifijoTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AnalistasTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasCondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasTableAdapter = Me.AUDIT_AuditoriasTableAdapter
        Me.TableAdapterManager.AUDIT_CondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_OrgAutorizacionTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosDTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosHTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosVTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auditoria.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AnexoTextBox
        '
        Me.AnexoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "Anexo", True))
        Me.AnexoTextBox.Location = New System.Drawing.Point(95, 12)
        Me.AnexoTextBox.Name = "AnexoTextBox"
        Me.AnexoTextBox.ReadOnly = True
        Me.AnexoTextBox.Size = New System.Drawing.Size(100, 13)
        Me.AnexoTextBox.TabIndex = 0
        '
        'CicloTextBox
        '
        Me.CicloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CicloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "Ciclo", True))
        Me.CicloTextBox.Location = New System.Drawing.Point(263, 12)
        Me.CicloTextBox.Name = "CicloTextBox"
        Me.CicloTextBox.ReadOnly = True
        Me.CicloTextBox.Size = New System.Drawing.Size(100, 13)
        Me.CicloTextBox.TabIndex = 1
        '
        'ObervacionesTextBox
        '
        Me.ObervacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "Obervaciones", True))
        Me.ObervacionesTextBox.Location = New System.Drawing.Point(95, 172)
        Me.ObervacionesTextBox.Multiline = True
        Me.ObervacionesTextBox.Name = "ObervacionesTextBox"
        Me.ObervacionesTextBox.Size = New System.Drawing.Size(862, 46)
        Me.ObervacionesTextBox.TabIndex = 16
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasBindingSource, "Estatus", True))
        Me.cmbEstatus.DataSource = Me.AUDITParametrosBindingSource1
        Me.cmbEstatus.DisplayMember = "Descripcion"
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(74, 567)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstatus.TabIndex = 19
        Me.cmbEstatus.ValueMember = "Descripcion"
        '
        'AUDITParametrosBindingSource1
        '
        Me.AUDITParametrosBindingSource1.DataMember = "AUDIT_Parametros"
        Me.AUDITParametrosBindingSource1.DataSource = Me.ProductionDataSet
        '
        'AUDITParametrosBindingSource
        '
        Me.AUDITParametrosBindingSource.DataMember = "AUDIT_Parametros"
        Me.AUDITParametrosBindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDIT_ParametrosTableAdapter
        '
        Me.AUDIT_ParametrosTableAdapter.ClearBeforeFill = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1038, 565)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 21
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'AUDIT_AuditoriasCondicionesBindingSource
        '
        Me.AUDIT_AuditoriasCondicionesBindingSource.DataSource = Me.ProductionDataSet
        Me.AUDIT_AuditoriasCondicionesBindingSource.Position = 0
        '
        'AUDIT_AuditoriasCondicionesTableAdapter
        '
        Me.AUDIT_AuditoriasCondicionesTableAdapter.ClearBeforeFill = True
        '
        'AUDIT_AuditoriasCondicionesBindingSource1
        '
        Me.AUDIT_AuditoriasCondicionesBindingSource1.DataSource = Me.ProductionDataSet
        Me.AUDIT_AuditoriasCondicionesBindingSource1.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Condicion, Me.Validacion, Me.CategoriaHallazgo, Me.id_auditoria, Me.Observaciones, Me.deptoResponsable, Me.FechaSolventacion, Me.Comentarios, Me.Id_auditoriaCondicion, Me.id_Cond, Me.eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1178, 331)
        Me.DataGridView1.TabIndex = 18
        '
        'Id_Condicion
        '
        Me.Id_Condicion.DataPropertyName = "Id_Condicion"
        Me.Id_Condicion.Frozen = True
        Me.Id_Condicion.HeaderText = "Condicion"
        Me.Id_Condicion.Name = "Id_Condicion"
        Me.Id_Condicion.ReadOnly = True
        Me.Id_Condicion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_Condicion.Width = 250
        '
        'Validacion
        '
        Me.Validacion.DataPropertyName = "Validacion"
        Me.Validacion.Frozen = True
        Me.Validacion.HeaderText = "Validacion"
        Me.Validacion.Name = "Validacion"
        Me.Validacion.ReadOnly = True
        Me.Validacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CategoriaHallazgo
        '
        Me.CategoriaHallazgo.DataPropertyName = "CategoriaHallazgo"
        Me.CategoriaHallazgo.Frozen = True
        Me.CategoriaHallazgo.HeaderText = "CategoriaHallazgo"
        Me.CategoriaHallazgo.Name = "CategoriaHallazgo"
        Me.CategoriaHallazgo.ReadOnly = True
        Me.CategoriaHallazgo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'id_auditoria
        '
        Me.id_auditoria.Frozen = True
        Me.id_auditoria.HeaderText = "id_auditoria"
        Me.id_auditoria.Name = "id_auditoria"
        Me.id_auditoria.ReadOnly = True
        Me.id_auditoria.Visible = False
        Me.id_auditoria.Width = 20
        '
        'Observaciones
        '
        Me.Observaciones.Frozen = True
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 200
        '
        'deptoResponsable
        '
        Me.deptoResponsable.Frozen = True
        Me.deptoResponsable.HeaderText = "Depto. Responsable"
        Me.deptoResponsable.Name = "deptoResponsable"
        Me.deptoResponsable.ReadOnly = True
        Me.deptoResponsable.Width = 80
        '
        'FechaSolventacion
        '
        Me.FechaSolventacion.Frozen = True
        Me.FechaSolventacion.HeaderText = "Fecha Solventacion"
        Me.FechaSolventacion.Name = "FechaSolventacion"
        Me.FechaSolventacion.ReadOnly = True
        '
        'Comentarios
        '
        Me.Comentarios.Frozen = True
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.ReadOnly = True
        Me.Comentarios.Width = 200
        '
        'Id_auditoriaCondicion
        '
        Me.Id_auditoriaCondicion.DataPropertyName = "Id_auditoriaCondicion"
        Me.Id_auditoriaCondicion.Frozen = True
        Me.Id_auditoriaCondicion.HeaderText = "Id"
        Me.Id_auditoriaCondicion.Name = "Id_auditoriaCondicion"
        Me.Id_auditoriaCondicion.ReadOnly = True
        Me.Id_auditoriaCondicion.Width = 50
        '
        'id_Cond
        '
        Me.id_Cond.DataPropertyName = "Id_Condicion"
        Me.id_Cond.Frozen = True
        Me.id_Cond.HeaderText = "id_Cond"
        Me.id_Cond.Name = "id_Cond"
        Me.id_Cond.ReadOnly = True
        Me.id_Cond.Visible = False
        '
        'eliminar
        '
        Me.eliminar.Frozen = True
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.eliminar.Width = 60
        '
        'AUDITCondicionesBindingSource
        '
        Me.AUDITCondicionesBindingSource.DataMember = "AUDIT_Condiciones"
        Me.AUDITCondicionesBindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDITParametrosVBindingSource
        '
        Me.AUDITParametrosVBindingSource.DataMember = "AUDIT_ParametrosV"
        Me.AUDITParametrosVBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(957, 565)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        Me.btnAgregar.Visible = False
        '
        'AUDIT_CondicionesTableAdapter
        '
        Me.AUDIT_CondicionesTableAdapter.ClearBeforeFill = True
        '
        'AUDIT_ParametrosVTableAdapter
        '
        Me.AUDIT_ParametrosVTableAdapter.ClearBeforeFill = True
        '
        'AUDITParametrosHBindingSource
        '
        Me.AUDITParametrosHBindingSource.DataMember = "AUDIT_ParametrosH"
        Me.AUDITParametrosHBindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDIT_ParametrosHTableAdapter
        '
        Me.AUDIT_ParametrosHTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1119, 565)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FechaRelizacionDateTimePicker
        '
        Me.FechaRelizacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasBindingSource, "FechaRelizacion", True))
        Me.FechaRelizacionDateTimePicker.Location = New System.Drawing.Point(319, 568)
        Me.FechaRelizacionDateTimePicker.Name = "FechaRelizacionDateTimePicker"
        Me.FechaRelizacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRelizacionDateTimePicker.TabIndex = 20
        '
        'FolAuditoriaTextBox
        '
        Me.FolAuditoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "folAuditoria", True))
        Me.FolAuditoriaTextBox.Location = New System.Drawing.Point(1044, 198)
        Me.FolAuditoriaTextBox.Name = "FolAuditoriaTextBox"
        Me.FolAuditoriaTextBox.Size = New System.Drawing.Size(150, 20)
        Me.FolAuditoriaTextBox.TabIndex = 17
        '
        'gbxdatosDelCredito
        '
        Me.gbxdatosDelCredito.Controls.Add(OrganoDeAutorizacionLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.OrganoDeAutorizacionTextBox)
        Me.gbxdatosDelCredito.Controls.Add(AnalistaLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.AnalistaTextBox)
        Me.gbxdatosDelCredito.Controls.Add(FechaAutorizacionLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.FechaAutorizacionDateTimePicker)
        Me.gbxdatosDelCredito.Controls.Add(FechaSolicitudLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.FechaSolicitudDateTimePicker)
        Me.gbxdatosDelCredito.Controls.Add(MontoSolicitadoLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.MontoSolicitadoTextBox)
        Me.gbxdatosDelCredito.Controls.Add(MontoFinanciadoLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.MontoFinanciadoTextBox)
        Me.gbxdatosDelCredito.Controls.Add(DestinoLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.DestinoTextBox)
        Me.gbxdatosDelCredito.Controls.Add(EjecutivoLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.EjecutivoTextBox)
        Me.gbxdatosDelCredito.Controls.Add(FechaDisposicionLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.FechaDisposicionDateTimePicker)
        Me.gbxdatosDelCredito.Controls.Add(RecursosLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.RecursosTextBox)
        Me.gbxdatosDelCredito.Controls.Add(TipoCreditoLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.TipoCreditoTextBox)
        Me.gbxdatosDelCredito.Controls.Add(SucursalLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.SucursalTextBox)
        Me.gbxdatosDelCredito.Controls.Add(ClienteLabel)
        Me.gbxdatosDelCredito.Controls.Add(Me.ClienteTextBox)
        Me.gbxdatosDelCredito.Location = New System.Drawing.Point(16, 31)
        Me.gbxdatosDelCredito.Name = "gbxdatosDelCredito"
        Me.gbxdatosDelCredito.Size = New System.Drawing.Size(1178, 135)
        Me.gbxdatosDelCredito.TabIndex = 2
        Me.gbxdatosDelCredito.TabStop = False
        Me.gbxdatosDelCredito.Text = "Datos del crédito"
        '
        'OrganoDeAutorizacionTextBox
        '
        Me.OrganoDeAutorizacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "organoDeAutorizacion", True))
        Me.OrganoDeAutorizacionTextBox.Location = New System.Drawing.Point(846, 96)
        Me.OrganoDeAutorizacionTextBox.Name = "OrganoDeAutorizacionTextBox"
        Me.OrganoDeAutorizacionTextBox.Size = New System.Drawing.Size(317, 20)
        Me.OrganoDeAutorizacionTextBox.TabIndex = 15
        '
        'AnalistaTextBox
        '
        Me.AnalistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "analista", True))
        Me.AnalistaTextBox.Location = New System.Drawing.Point(445, 96)
        Me.AnalistaTextBox.Name = "AnalistaTextBox"
        Me.AnalistaTextBox.Size = New System.Drawing.Size(268, 20)
        Me.AnalistaTextBox.TabIndex = 10
        '
        'FechaAutorizacionDateTimePicker
        '
        Me.FechaAutorizacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasBindingSource, "fechaAutorizacion", True))
        Me.FechaAutorizacionDateTimePicker.Location = New System.Drawing.Point(947, 71)
        Me.FechaAutorizacionDateTimePicker.Name = "FechaAutorizacionDateTimePicker"
        Me.FechaAutorizacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaAutorizacionDateTimePicker.TabIndex = 14
        '
        'FechaSolicitudDateTimePicker
        '
        Me.FechaSolicitudDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasBindingSource, "fechaSolicitud", True))
        Me.FechaSolicitudDateTimePicker.Location = New System.Drawing.Point(947, 48)
        Me.FechaSolicitudDateTimePicker.Name = "FechaSolicitudDateTimePicker"
        Me.FechaSolicitudDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaSolicitudDateTimePicker.TabIndex = 13
        '
        'MontoSolicitadoTextBox
        '
        Me.MontoSolicitadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "montoSolicitado", True))
        Me.MontoSolicitadoTextBox.Location = New System.Drawing.Point(799, 16)
        Me.MontoSolicitadoTextBox.Name = "MontoSolicitadoTextBox"
        Me.MontoSolicitadoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.MontoSolicitadoTextBox.TabIndex = 11
        '
        'MontoFinanciadoTextBox
        '
        Me.MontoFinanciadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "montoFinanciado", True))
        Me.MontoFinanciadoTextBox.Location = New System.Drawing.Point(1044, 16)
        Me.MontoFinanciadoTextBox.Name = "MontoFinanciadoTextBox"
        Me.MontoFinanciadoTextBox.Size = New System.Drawing.Size(119, 20)
        Me.MontoFinanciadoTextBox.TabIndex = 12
        '
        'DestinoTextBox
        '
        Me.DestinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "destino", True))
        Me.DestinoTextBox.Location = New System.Drawing.Point(445, 71)
        Me.DestinoTextBox.Name = "DestinoTextBox"
        Me.DestinoTextBox.Size = New System.Drawing.Size(268, 20)
        Me.DestinoTextBox.TabIndex = 9
        '
        'EjecutivoTextBox
        '
        Me.EjecutivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "ejecutivo", True))
        Me.EjecutivoTextBox.Location = New System.Drawing.Point(445, 48)
        Me.EjecutivoTextBox.Name = "EjecutivoTextBox"
        Me.EjecutivoTextBox.Size = New System.Drawing.Size(268, 20)
        Me.EjecutivoTextBox.TabIndex = 8
        '
        'FechaDisposicionDateTimePicker
        '
        Me.FechaDisposicionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasBindingSource, "fechaDisposicion", True))
        Me.FechaDisposicionDateTimePicker.Location = New System.Drawing.Point(491, 19)
        Me.FechaDisposicionDateTimePicker.Name = "FechaDisposicionDateTimePicker"
        Me.FechaDisposicionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDisposicionDateTimePicker.TabIndex = 7
        '
        'RecursosTextBox
        '
        Me.RecursosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "recursos", True))
        Me.RecursosTextBox.Location = New System.Drawing.Point(99, 96)
        Me.RecursosTextBox.Name = "RecursosTextBox"
        Me.RecursosTextBox.Size = New System.Drawing.Size(268, 20)
        Me.RecursosTextBox.TabIndex = 6
        '
        'TipoCreditoTextBox
        '
        Me.TipoCreditoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "tipoCredito", True))
        Me.TipoCreditoTextBox.Location = New System.Drawing.Point(99, 70)
        Me.TipoCreditoTextBox.Name = "TipoCreditoTextBox"
        Me.TipoCreditoTextBox.Size = New System.Drawing.Size(268, 20)
        Me.TipoCreditoTextBox.TabIndex = 5
        '
        'SucursalTextBox
        '
        Me.SucursalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "sucursal", True))
        Me.SucursalTextBox.Location = New System.Drawing.Point(99, 45)
        Me.SucursalTextBox.Name = "SucursalTextBox"
        Me.SucursalTextBox.Size = New System.Drawing.Size(268, 20)
        Me.SucursalTextBox.TabIndex = 4
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "cliente", True))
        Me.ClienteTextBox.Location = New System.Drawing.Point(99, 19)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(268, 20)
        Me.ClienteTextBox.TabIndex = 3
        '
        'frmAuditoriaMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 600)
        Me.Controls.Add(Me.gbxdatosDelCredito)
        Me.Controls.Add(FolAuditoriaLabel)
        Me.Controls.Add(Me.FolAuditoriaTextBox)
        Me.Controls.Add(FechaRelizacionLabel)
        Me.Controls.Add(Me.FechaRelizacionDateTimePicker)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.cmbEstatus)
        Me.Controls.Add(EstatusLabel)
        Me.Controls.Add(ObervacionesLabel)
        Me.Controls.Add(Me.ObervacionesTextBox)
        Me.Controls.Add(CicloLabel)
        Me.Controls.Add(Me.CicloTextBox)
        Me.Controls.Add(AnexoLabel)
        Me.Controls.Add(Me.AnexoTextBox)
        Me.Name = "frmAuditoriaMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condiciones"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDIT_AuditoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxdatosDelCredito.ResumeLayout(False)
        Me.gbxdatosDelCredito.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents AUDIT_AuditoriasBindingSource As BindingSource
    Friend WithEvents AUDIT_AuditoriasTableAdapter As ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnexoTextBox As TextBox
    Friend WithEvents CicloTextBox As TextBox
    Friend WithEvents ObervacionesTextBox As TextBox
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents AUDITParametrosBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosTableAdapter
    Friend WithEvents AUDITParametrosBindingSource1 As BindingSource
    Friend WithEvents btnActualizar As Button
    Friend WithEvents AUDIT_AuditoriasCondicionesBindingSource As BindingSource
    Friend WithEvents AUDIT_AuditoriasCondicionesTableAdapter As ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
    Friend WithEvents AUDIT_AuditoriasCondicionesBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents AUDITCondicionesBindingSource As BindingSource
    Friend WithEvents AUDIT_CondicionesTableAdapter As ProductionDataSetTableAdapters.AUDIT_CondicionesTableAdapter
    Friend WithEvents AUDITParametrosVBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosVTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosVTableAdapter
    Friend WithEvents AUDITParametrosHBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosHTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosHTableAdapter
    Friend WithEvents btnSalir As Button
    Friend WithEvents FechaRelizacionDateTimePicker As DateTimePicker
    Friend WithEvents FolAuditoriaTextBox As TextBox
    Friend WithEvents gbxdatosDelCredito As GroupBox
    Friend WithEvents OrganoDeAutorizacionTextBox As TextBox
    Friend WithEvents AnalistaTextBox As TextBox
    Friend WithEvents FechaAutorizacionDateTimePicker As DateTimePicker
    Friend WithEvents FechaSolicitudDateTimePicker As DateTimePicker
    Friend WithEvents MontoSolicitadoTextBox As TextBox
    Friend WithEvents MontoFinanciadoTextBox As TextBox
    Friend WithEvents DestinoTextBox As TextBox
    Friend WithEvents EjecutivoTextBox As TextBox
    Friend WithEvents FechaDisposicionDateTimePicker As DateTimePicker
    Friend WithEvents RecursosTextBox As TextBox
    Friend WithEvents TipoCreditoTextBox As TextBox
    Friend WithEvents SucursalTextBox As TextBox
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents Id_Condicion As DataGridViewTextBoxColumn
    Friend WithEvents Validacion As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaHallazgo As DataGridViewTextBoxColumn
    Friend WithEvents id_auditoria As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents deptoResponsable As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolventacion As DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As DataGridViewTextBoxColumn
    Friend WithEvents Id_auditoriaCondicion As DataGridViewTextBoxColumn
    Friend WithEvents id_Cond As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewLinkColumn
End Class
