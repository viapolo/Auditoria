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
        CicloLabel.Location = New System.Drawing.Point(176, 15)
        CicloLabel.Name = "CicloLabel"
        CicloLabel.Size = New System.Drawing.Size(33, 13)
        CicloLabel.TabIndex = 4
        CicloLabel.Text = "Ciclo:"
        '
        'FechaCreacionLabel
        '
        FechaCreacionLabel.AutoSize = True
        FechaCreacionLabel.Location = New System.Drawing.Point(11, 490)
        FechaCreacionLabel.Name = "FechaCreacionLabel"
        FechaCreacionLabel.Size = New System.Drawing.Size(85, 13)
        FechaCreacionLabel.TabIndex = 6
        FechaCreacionLabel.Text = "Fecha Creacion:"
        '
        'UltimaActualizacionLabel
        '
        UltimaActualizacionLabel.AutoSize = True
        UltimaActualizacionLabel.Location = New System.Drawing.Point(312, 490)
        UltimaActualizacionLabel.Name = "UltimaActualizacionLabel"
        UltimaActualizacionLabel.Size = New System.Drawing.Size(105, 13)
        UltimaActualizacionLabel.TabIndex = 8
        UltimaActualizacionLabel.Text = "Ultima Actualizacion:"
        '
        'FechaRelizacionLabel
        '
        FechaRelizacionLabel.AutoSize = True
        FechaRelizacionLabel.Location = New System.Drawing.Point(28, 69)
        FechaRelizacionLabel.Name = "FechaRelizacionLabel"
        FechaRelizacionLabel.Size = New System.Drawing.Size(92, 13)
        FechaRelizacionLabel.TabIndex = 10
        FechaRelizacionLabel.Text = "Fecha Relizacion:"
        '
        'ObervacionesLabel
        '
        ObervacionesLabel.AutoSize = True
        ObervacionesLabel.Location = New System.Drawing.Point(44, 128)
        ObervacionesLabel.Name = "ObervacionesLabel"
        ObervacionesLabel.Size = New System.Drawing.Size(76, 13)
        ObervacionesLabel.TabIndex = 12
        ObervacionesLabel.Text = "Obervaciones:"
        '
        'EstatusLabel
        '
        EstatusLabel.AutoSize = True
        EstatusLabel.Location = New System.Drawing.Point(629, 488)
        EstatusLabel.Name = "EstatusLabel"
        EstatusLabel.Size = New System.Drawing.Size(45, 13)
        EstatusLabel.TabIndex = 14
        EstatusLabel.Text = "Estatus:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(511, 15)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 16
        UsuarioLabel.Text = "Usuario:"
        '
        'ConsecutivoLabel
        '
        ConsecutivoLabel.AutoSize = True
        ConsecutivoLabel.Location = New System.Drawing.Point(331, 15)
        ConsecutivoLabel.Name = "ConsecutivoLabel"
        ConsecutivoLabel.Size = New System.Drawing.Size(69, 13)
        ConsecutivoLabel.TabIndex = 19
        ConsecutivoLabel.Text = "Consecutivo:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(807, 483)
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
        Me.AUDIT_AuditoriasDataGridView.Location = New System.Drawing.Point(12, 201)
        Me.AUDIT_AuditoriasDataGridView.Name = "AUDIT_AuditoriasDataGridView"
        Me.AUDIT_AuditoriasDataGridView.ReadOnly = True
        Me.AUDIT_AuditoriasDataGridView.Size = New System.Drawing.Size(1081, 272)
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
        Me.AnexoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnexoTextBox.Enabled = False
        Me.AnexoTextBox.Location = New System.Drawing.Point(61, 15)
        Me.AnexoTextBox.Name = "AnexoTextBox"
        Me.AnexoTextBox.Size = New System.Drawing.Size(100, 13)
        Me.AnexoTextBox.TabIndex = 1
        '
        'CicloTextBox
        '
        Me.CicloTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CicloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CicloTextBox.Enabled = False
        Me.CicloTextBox.Location = New System.Drawing.Point(215, 15)
        Me.CicloTextBox.Name = "CicloTextBox"
        Me.CicloTextBox.Size = New System.Drawing.Size(100, 13)
        Me.CicloTextBox.TabIndex = 2
        '
        'FechaCreacionDateTimePicker
        '
        Me.FechaCreacionDateTimePicker.Enabled = False
        Me.FechaCreacionDateTimePicker.Location = New System.Drawing.Point(102, 486)
        Me.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker"
        Me.FechaCreacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaCreacionDateTimePicker.TabIndex = 5
        '
        'UltimaActualizacionDateTimePicker
        '
        Me.UltimaActualizacionDateTimePicker.Enabled = False
        Me.UltimaActualizacionDateTimePicker.Location = New System.Drawing.Point(423, 486)
        Me.UltimaActualizacionDateTimePicker.Name = "UltimaActualizacionDateTimePicker"
        Me.UltimaActualizacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.UltimaActualizacionDateTimePicker.TabIndex = 6
        '
        'FechaRelizacionDateTimePicker
        '
        Me.FechaRelizacionDateTimePicker.Enabled = False
        Me.FechaRelizacionDateTimePicker.Location = New System.Drawing.Point(126, 65)
        Me.FechaRelizacionDateTimePicker.Name = "FechaRelizacionDateTimePicker"
        Me.FechaRelizacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRelizacionDateTimePicker.TabIndex = 0
        '
        'ObervacionesTextBox
        '
        Me.ObervacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "Obervaciones", True))
        Me.ObervacionesTextBox.Enabled = False
        Me.ObervacionesTextBox.Location = New System.Drawing.Point(126, 125)
        Me.ObervacionesTextBox.Multiline = True
        Me.ObervacionesTextBox.Name = "ObervacionesTextBox"
        Me.ObervacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ObervacionesTextBox.Size = New System.Drawing.Size(789, 65)
        Me.ObervacionesTextBox.TabIndex = 2
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsuarioTextBox.Enabled = False
        Me.UsuarioTextBox.Location = New System.Drawing.Point(563, 15)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 13)
        Me.UsuarioTextBox.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(888, 483)
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
        Me.ConsecutivoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConsecutivoTextBox.Enabled = False
        Me.ConsecutivoTextBox.Location = New System.Drawing.Point(405, 15)
        Me.ConsecutivoTextBox.Name = "ConsecutivoTextBox"
        Me.ConsecutivoTextBox.Size = New System.Drawing.Size(100, 13)
        Me.ConsecutivoTextBox.TabIndex = 3
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataSource = Me.AUDITParametrosBindingSource1
        Me.cmbEstatus.DisplayMember = "Descripcion"
        Me.cmbEstatus.Enabled = False
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(680, 485)
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
        Me.btnSalir.Location = New System.Drawing.Point(1019, 483)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtAuditoria
        '
        Me.txtAuditoria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "folAuditoria", True))
        Me.txtAuditoria.Location = New System.Drawing.Point(126, 91)
        Me.txtAuditoria.Name = "txtAuditoria"
        Me.txtAuditoria.Size = New System.Drawing.Size(150, 20)
        Me.txtAuditoria.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Folio de Auditoría:"
        '
        'frmAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 527)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAuditoria)
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
        Me.Text = "Auditorias"
        CType(Me.AUDIT_AuditoriasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDIT_AuditoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
