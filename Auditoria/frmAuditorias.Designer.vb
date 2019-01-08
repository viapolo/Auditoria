<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAuditorias
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
        Dim FechaCreacionLabel As System.Windows.Forms.Label
        Dim UltimaActualizacionLabel As System.Windows.Forms.Label
        Dim FechaRelizacionLabel As System.Windows.Forms.Label
        Dim ObervacionesLabel As System.Windows.Forms.Label
        Dim EstatusLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ConsecutivoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.AUDIT_AuditoriasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUDIT_AuditoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.AnexoTextBox = New System.Windows.Forms.TextBox()
        Me.CicloTextBox = New System.Windows.Forms.TextBox()
        Me.FechaCreacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UltimaActualizacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaRelizacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ObervacionesTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.AUDIT_AuditoriasTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter()
        Me.TableAdapterManager = New Auditoria.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.ConsecutivoTextBox = New System.Windows.Forms.TextBox()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDITParametrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_ParametrosTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtAuditoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbOrganoDeAutorizacion = New System.Windows.Forms.ComboBox()
        Me.cmbAnalista = New System.Windows.Forms.ComboBox()
        Me.dtpFechaAutorizacion = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.txtMontoSolicitado = New System.Windows.Forms.TextBox()
        Me.txtMontoFinanciado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.txtEjecutivo = New System.Windows.Forms.TextBox()
        Me.dtpFechaDispo = New System.Windows.Forms.DateTimePicker()
        Me.txtRecursos = New System.Windows.Forms.TextBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        AnexoLabel = New System.Windows.Forms.Label()
        CicloLabel = New System.Windows.Forms.Label()
        FechaCreacionLabel = New System.Windows.Forms.Label()
        UltimaActualizacionLabel = New System.Windows.Forms.Label()
        FechaRelizacionLabel = New System.Windows.Forms.Label()
        ObervacionesLabel = New System.Windows.Forms.Label()
        EstatusLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        ConsecutivoLabel = New System.Windows.Forms.Label()
        CType(Me.AUDIT_AuditoriasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDIT_AuditoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnexoLabel
        '
        AnexoLabel.AutoSize = True
        AnexoLabel.Location = New System.Drawing.Point(15, 15)
        AnexoLabel.Name = "AnexoLabel"
        AnexoLabel.Size = New System.Drawing.Size(40, 13)
        AnexoLabel.TabIndex = 2
        AnexoLabel.Text = "Anexo:"
        '
        'CicloLabel
        '
        CicloLabel.AutoSize = True
        CicloLabel.Location = New System.Drawing.Point(163, 15)
        CicloLabel.Name = "CicloLabel"
        CicloLabel.Size = New System.Drawing.Size(33, 13)
        CicloLabel.TabIndex = 4
        CicloLabel.Text = "Ciclo:"
        '
        'FechaCreacionLabel
        '
        FechaCreacionLabel.AutoSize = True
        FechaCreacionLabel.Location = New System.Drawing.Point(11, 524)
        FechaCreacionLabel.Name = "FechaCreacionLabel"
        FechaCreacionLabel.Size = New System.Drawing.Size(85, 13)
        FechaCreacionLabel.TabIndex = 6
        FechaCreacionLabel.Text = "Fecha Creacion:"
        '
        'UltimaActualizacionLabel
        '
        UltimaActualizacionLabel.AutoSize = True
        UltimaActualizacionLabel.Location = New System.Drawing.Point(312, 524)
        UltimaActualizacionLabel.Name = "UltimaActualizacionLabel"
        UltimaActualizacionLabel.Size = New System.Drawing.Size(105, 13)
        UltimaActualizacionLabel.TabIndex = 8
        UltimaActualizacionLabel.Text = "Ultima Actualizacion:"
        '
        'FechaRelizacionLabel
        '
        FechaRelizacionLabel.AutoSize = True
        FechaRelizacionLabel.Location = New System.Drawing.Point(776, 274)
        FechaRelizacionLabel.Name = "FechaRelizacionLabel"
        FechaRelizacionLabel.Size = New System.Drawing.Size(92, 13)
        FechaRelizacionLabel.TabIndex = 10
        FechaRelizacionLabel.Text = "Fecha Relizacion:"
        '
        'ObervacionesLabel
        '
        ObervacionesLabel.AutoSize = True
        ObervacionesLabel.Location = New System.Drawing.Point(20, 270)
        ObervacionesLabel.Name = "ObervacionesLabel"
        ObervacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObervacionesLabel.TabIndex = 12
        ObervacionesLabel.Text = "Observaciones:"
        '
        'EstatusLabel
        '
        EstatusLabel.AutoSize = True
        EstatusLabel.Location = New System.Drawing.Point(629, 522)
        EstatusLabel.Name = "EstatusLabel"
        EstatusLabel.Size = New System.Drawing.Size(45, 13)
        EstatusLabel.TabIndex = 14
        EstatusLabel.Text = "Estatus:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(411, 15)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 16
        UsuarioLabel.Text = "Usuario:"
        '
        'ConsecutivoLabel
        '
        ConsecutivoLabel.AutoSize = True
        ConsecutivoLabel.Location = New System.Drawing.Point(273, 15)
        ConsecutivoLabel.Name = "ConsecutivoLabel"
        ConsecutivoLabel.Size = New System.Drawing.Size(69, 13)
        ConsecutivoLabel.TabIndex = 19
        ConsecutivoLabel.Text = "Consecutivo:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(807, 517)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'AUDIT_AuditoriasDataGridView
        '
        Me.AUDIT_AuditoriasDataGridView.AllowUserToAddRows = False
        Me.AUDIT_AuditoriasDataGridView.AllowUserToDeleteRows = False
        Me.AUDIT_AuditoriasDataGridView.AutoGenerateColumns = False
        Me.AUDIT_AuditoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AUDIT_AuditoriasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.AUDIT_AuditoriasDataGridView.DataSource = Me.AUDIT_AuditoriasBindingSource
        Me.AUDIT_AuditoriasDataGridView.Location = New System.Drawing.Point(12, 319)
        Me.AUDIT_AuditoriasDataGridView.Name = "AUDIT_AuditoriasDataGridView"
        Me.AUDIT_AuditoriasDataGridView.ReadOnly = True
        Me.AUDIT_AuditoriasDataGridView.Size = New System.Drawing.Size(1081, 189)
        Me.AUDIT_AuditoriasDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Consecutivo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Consecutivo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 91
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaCreacion"
        DataGridViewCellStyle1.Format = "G"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "FechaCreacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UltimaActualizacion"
        DataGridViewCellStyle2.Format = "G"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "UltimaActualizacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaRelizacion"
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "FechaRelizacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 5
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Obervaciones"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Obervaciones"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 300
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 5
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 5
        '
        'AUDIT_AuditoriasBindingSource
        '
        Me.AUDIT_AuditoriasBindingSource.DataMember = "AUDIT_Auditorias"
        Me.AUDIT_AuditoriasBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexoTextBox
        '
        Me.AnexoTextBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.AnexoTextBox.Enabled = False
        Me.AnexoTextBox.Location = New System.Drawing.Point(61, 12)
        Me.AnexoTextBox.Name = "AnexoTextBox"
        Me.AnexoTextBox.Size = New System.Drawing.Size(84, 20)
        Me.AnexoTextBox.TabIndex = 1
        '
        'CicloTextBox
        '
        Me.CicloTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CicloTextBox.Enabled = False
        Me.CicloTextBox.Location = New System.Drawing.Point(202, 12)
        Me.CicloTextBox.Name = "CicloTextBox"
        Me.CicloTextBox.Size = New System.Drawing.Size(54, 20)
        Me.CicloTextBox.TabIndex = 2
        '
        'FechaCreacionDateTimePicker
        '
        Me.FechaCreacionDateTimePicker.Enabled = False
        Me.FechaCreacionDateTimePicker.Location = New System.Drawing.Point(102, 520)
        Me.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker"
        Me.FechaCreacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaCreacionDateTimePicker.TabIndex = 5
        '
        'UltimaActualizacionDateTimePicker
        '
        Me.UltimaActualizacionDateTimePicker.Enabled = False
        Me.UltimaActualizacionDateTimePicker.Location = New System.Drawing.Point(423, 520)
        Me.UltimaActualizacionDateTimePicker.Name = "UltimaActualizacionDateTimePicker"
        Me.UltimaActualizacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.UltimaActualizacionDateTimePicker.TabIndex = 6
        '
        'FechaRelizacionDateTimePicker
        '
        Me.FechaRelizacionDateTimePicker.Enabled = False
        Me.FechaRelizacionDateTimePicker.Location = New System.Drawing.Point(874, 270)
        Me.FechaRelizacionDateTimePicker.Name = "FechaRelizacionDateTimePicker"
        Me.FechaRelizacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRelizacionDateTimePicker.TabIndex = 0
        '
        'ObervacionesTextBox
        '
        Me.ObervacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "Obervaciones", True))
        Me.ObervacionesTextBox.Enabled = False
        Me.ObervacionesTextBox.Location = New System.Drawing.Point(102, 270)
        Me.ObervacionesTextBox.Multiline = True
        Me.ObervacionesTextBox.Name = "ObervacionesTextBox"
        Me.ObervacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ObervacionesTextBox.Size = New System.Drawing.Size(658, 43)
        Me.ObervacionesTextBox.TabIndex = 2
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.UsuarioTextBox.Enabled = False
        Me.UsuarioTextBox.Location = New System.Drawing.Point(462, 12)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(888, 517)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'AUDIT_AuditoriasTableAdapter
        '
        Me.AUDIT_AuditoriasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActifijoTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasCondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasTableAdapter = Me.AUDIT_AuditoriasTableAdapter
        Me.TableAdapterManager.AUDIT_CondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosDTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosHTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosVTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auditoria.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsecutivoTextBox
        '
        Me.ConsecutivoTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ConsecutivoTextBox.Enabled = False
        Me.ConsecutivoTextBox.Location = New System.Drawing.Point(347, 12)
        Me.ConsecutivoTextBox.Name = "ConsecutivoTextBox"
        Me.ConsecutivoTextBox.Size = New System.Drawing.Size(46, 20)
        Me.ConsecutivoTextBox.TabIndex = 3
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataSource = Me.AUDITParametrosBindingSource1
        Me.cmbEstatus.DisplayMember = "Descripcion"
        Me.cmbEstatus.Enabled = False
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(680, 519)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstatus.TabIndex = 8
        Me.cmbEstatus.ValueMember = "Descripcion"
        '
        'AUDITParametrosBindingSource1
        '
        Me.AUDITParametrosBindingSource1.DataMember = "AUDIT_Parametros"
        Me.AUDITParametrosBindingSource1.DataSource = Me.ProductionDataSet
        '
        'AUDIT_ParametrosTableAdapter
        '
        Me.AUDIT_ParametrosTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1019, 517)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtAuditoria
        '
        Me.txtAuditoria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "folAuditoria", True))
        Me.txtAuditoria.Location = New System.Drawing.Point(583, 180)
        Me.txtAuditoria.Name = "txtAuditoria"
        Me.txtAuditoria.Size = New System.Drawing.Size(270, 20)
        Me.txtAuditoria.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(452, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Folio de Auditoría:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbOrganoDeAutorizacion)
        Me.GroupBox1.Controls.Add(Me.cmbAnalista)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAutorizacion)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSolicitud)
        Me.GroupBox1.Controls.Add(Me.txtMontoSolicitado)
        Me.GroupBox1.Controls.Add(Me.txtMontoFinanciado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAuditoria)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Controls.Add(Me.txtEjecutivo)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDispo)
        Me.GroupBox1.Controls.Add(Me.txtRecursos)
        Me.GroupBox1.Controls.Add(Me.txtTipoCredito)
        Me.GroupBox1.Controls.Add(Me.txtSucursal)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1075, 218)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del crédito:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(452, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Organo de autorización:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(452, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Analista:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(452, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Fecha de autorización:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(452, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Fecha de solicitud:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(452, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Monto solicitado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(452, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Monto financiado:"
        '
        'cmbOrganoDeAutorizacion
        '
        Me.cmbOrganoDeAutorizacion.FormattingEnabled = True
        Me.cmbOrganoDeAutorizacion.Location = New System.Drawing.Point(583, 153)
        Me.cmbOrganoDeAutorizacion.Name = "cmbOrganoDeAutorizacion"
        Me.cmbOrganoDeAutorizacion.Size = New System.Drawing.Size(270, 21)
        Me.cmbOrganoDeAutorizacion.TabIndex = 29
        '
        'cmbAnalista
        '
        Me.cmbAnalista.FormattingEnabled = True
        Me.cmbAnalista.Location = New System.Drawing.Point(583, 125)
        Me.cmbAnalista.Name = "cmbAnalista"
        Me.cmbAnalista.Size = New System.Drawing.Size(270, 21)
        Me.cmbAnalista.TabIndex = 28
        '
        'dtpFechaAutorizacion
        '
        Me.dtpFechaAutorizacion.Location = New System.Drawing.Point(583, 99)
        Me.dtpFechaAutorizacion.Name = "dtpFechaAutorizacion"
        Me.dtpFechaAutorizacion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaAutorizacion.TabIndex = 27
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(583, 72)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaSolicitud.TabIndex = 26
        '
        'txtMontoSolicitado
        '
        Me.txtMontoSolicitado.Location = New System.Drawing.Point(583, 46)
        Me.txtMontoSolicitado.Name = "txtMontoSolicitado"
        Me.txtMontoSolicitado.Size = New System.Drawing.Size(270, 20)
        Me.txtMontoSolicitado.TabIndex = 24
        '
        'txtMontoFinanciado
        '
        Me.txtMontoFinanciado.Location = New System.Drawing.Point(583, 19)
        Me.txtMontoFinanciado.Name = "txtMontoFinanciado"
        Me.txtMontoFinanciado.Size = New System.Drawing.Size(270, 20)
        Me.txtMontoFinanciado.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Destino:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ejecutivo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha de disposición:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Recursos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de crédito:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente:"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(133, 180)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.ReadOnly = True
        Me.txtDestino.Size = New System.Drawing.Size(270, 20)
        Me.txtDestino.TabIndex = 6
        '
        'txtEjecutivo
        '
        Me.txtEjecutivo.Location = New System.Drawing.Point(133, 153)
        Me.txtEjecutivo.Name = "txtEjecutivo"
        Me.txtEjecutivo.ReadOnly = True
        Me.txtEjecutivo.Size = New System.Drawing.Size(270, 20)
        Me.txtEjecutivo.TabIndex = 5
        '
        'dtpFechaDispo
        '
        Me.dtpFechaDispo.Enabled = False
        Me.dtpFechaDispo.Location = New System.Drawing.Point(133, 126)
        Me.dtpFechaDispo.Name = "dtpFechaDispo"
        Me.dtpFechaDispo.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaDispo.TabIndex = 4
        '
        'txtRecursos
        '
        Me.txtRecursos.Location = New System.Drawing.Point(133, 100)
        Me.txtRecursos.Name = "txtRecursos"
        Me.txtRecursos.ReadOnly = True
        Me.txtRecursos.Size = New System.Drawing.Size(270, 20)
        Me.txtRecursos.TabIndex = 3
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.Location = New System.Drawing.Point(133, 73)
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(270, 20)
        Me.txtTipoCredito.TabIndex = 2
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(133, 46)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(270, 20)
        Me.txtSucursal.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(133, 20)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(270, 20)
        Me.txtCliente.TabIndex = 0
        '
        'frmAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbEstatus)
        Me.Controls.Add(ConsecutivoLabel)
        Me.Controls.Add(Me.ConsecutivoTextBox)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(EstatusLabel)
        Me.Controls.Add(ObervacionesLabel)
        Me.Controls.Add(Me.ObervacionesTextBox)
        Me.Controls.Add(FechaRelizacionLabel)
        Me.Controls.Add(Me.FechaRelizacionDateTimePicker)
        Me.Controls.Add(UltimaActualizacionLabel)
        Me.Controls.Add(Me.UltimaActualizacionDateTimePicker)
        Me.Controls.Add(FechaCreacionLabel)
        Me.Controls.Add(Me.FechaCreacionDateTimePicker)
        Me.Controls.Add(CicloLabel)
        Me.Controls.Add(Me.CicloTextBox)
        Me.Controls.Add(AnexoLabel)
        Me.Controls.Add(Me.AnexoTextBox)
        Me.Controls.Add(Me.AUDIT_AuditoriasDataGridView)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "frmAuditorias"
        Me.Text = "win"
        CType(Me.AUDIT_AuditoriasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDIT_AuditoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents AUDIT_AuditoriasBindingSource As BindingSource
    Friend WithEvents AUDIT_AuditoriasTableAdapter As ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnAgregar As Button
    Friend WithEvents AUDIT_AuditoriasDataGridView As DataGridView
    Friend WithEvents AnexoTextBox As TextBox
    Friend WithEvents CicloTextBox As TextBox
    Friend WithEvents FechaCreacionDateTimePicker As DateTimePicker
    Friend WithEvents UltimaActualizacionDateTimePicker As DateTimePicker
    Friend WithEvents FechaRelizacionDateTimePicker As DateTimePicker
    Friend WithEvents ObervacionesTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ConsecutivoTextBox As TextBox
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents AUDITParametrosBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosTableAdapter
    Friend WithEvents AUDITParametrosBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtAuditoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtEjecutivo As TextBox
    Friend WithEvents dtpFechaDispo As DateTimePicker
    Friend WithEvents txtRecursos As TextBox
    Friend WithEvents txtTipoCredito As TextBox
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtMontoFinanciado As TextBox
    Friend WithEvents txtMontoSolicitado As TextBox
    Friend WithEvents dtpFechaSolicitud As DateTimePicker
    Friend WithEvents dtpFechaAutorizacion As DateTimePicker
    Friend WithEvents cmbAnalista As ComboBox
    Friend WithEvents cmbOrganoDeAutorizacion As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
