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
        Me.FechaSolventacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_auditoriaCondicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Cond = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        AnexoLabel = New System.Windows.Forms.Label()
        CicloLabel = New System.Windows.Forms.Label()
        ObervacionesLabel = New System.Windows.Forms.Label()
        EstatusLabel = New System.Windows.Forms.Label()
        FechaRelizacionLabel = New System.Windows.Forms.Label()
        FolAuditoriaLabel = New System.Windows.Forms.Label()
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
        ObervacionesLabel.Location = New System.Drawing.Point(13, 41)
        ObervacionesLabel.Name = "ObervacionesLabel"
        ObervacionesLabel.Size = New System.Drawing.Size(76, 13)
        ObervacionesLabel.TabIndex = 4
        ObervacionesLabel.Text = "Obervaciones:"
        '
        'EstatusLabel
        '
        EstatusLabel.AutoSize = True
        EstatusLabel.Location = New System.Drawing.Point(44, 109)
        EstatusLabel.Name = "EstatusLabel"
        EstatusLabel.Size = New System.Drawing.Size(45, 13)
        EstatusLabel.TabIndex = 6
        EstatusLabel.Text = "Estatus:"
        '
        'FechaRelizacionLabel
        '
        FechaRelizacionLabel.AutoSize = True
        FechaRelizacionLabel.Location = New System.Drawing.Point(773, 42)
        FechaRelizacionLabel.Name = "FechaRelizacionLabel"
        FechaRelizacionLabel.Size = New System.Drawing.Size(92, 13)
        FechaRelizacionLabel.TabIndex = 12
        FechaRelizacionLabel.Text = "Fecha Relizacion:"
        '
        'FolAuditoriaLabel
        '
        FolAuditoriaLabel.AutoSize = True
        FolAuditoriaLabel.Location = New System.Drawing.Point(797, 67)
        FolAuditoriaLabel.Name = "FolAuditoriaLabel"
        FolAuditoriaLabel.Size = New System.Drawing.Size(68, 13)
        FolAuditoriaLabel.TabIndex = 14
        FolAuditoriaLabel.Text = "No Auditoria:"
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
        Me.TableAdapterManager.AUDIT_AuditoriasCondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasTableAdapter = Me.AUDIT_AuditoriasTableAdapter
        Me.TableAdapterManager.AUDIT_CondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosHTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosVTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.AnexoTextBox.TabIndex = 2
        '
        'CicloTextBox
        '
        Me.CicloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CicloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "Ciclo", True))
        Me.CicloTextBox.Location = New System.Drawing.Point(263, 12)
        Me.CicloTextBox.Name = "CicloTextBox"
        Me.CicloTextBox.ReadOnly = True
        Me.CicloTextBox.Size = New System.Drawing.Size(100, 13)
        Me.CicloTextBox.TabIndex = 3
        '
        'ObervacionesTextBox
        '
        Me.ObervacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "Obervaciones", True))
        Me.ObervacionesTextBox.Location = New System.Drawing.Point(95, 38)
        Me.ObervacionesTextBox.Multiline = True
        Me.ObervacionesTextBox.Name = "ObervacionesTextBox"
        Me.ObervacionesTextBox.Size = New System.Drawing.Size(623, 62)
        Me.ObervacionesTextBox.TabIndex = 5
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasBindingSource, "Estatus", True))
        Me.cmbEstatus.DataSource = Me.AUDITParametrosBindingSource1
        Me.cmbEstatus.DisplayMember = "Descripcion"
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(95, 106)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstatus.TabIndex = 6
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
        Me.btnActualizar.Location = New System.Drawing.Point(1038, 505)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 11
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Condicion, Me.Validacion, Me.CategoriaHallazgo, Me.id_auditoria, Me.Observaciones, Me.FechaSolventacion, Me.Comentarios, Me.Id_auditoriaCondicion, Me.id_Cond})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1178, 366)
        Me.DataGridView1.TabIndex = 9
        '
        'Id_Condicion
        '
        Me.Id_Condicion.DataPropertyName = "Id_Condicion"
        Me.Id_Condicion.HeaderText = "Condicion"
        Me.Id_Condicion.Name = "Id_Condicion"
        Me.Id_Condicion.ReadOnly = True
        Me.Id_Condicion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_Condicion.Width = 300
        '
        'Validacion
        '
        Me.Validacion.DataPropertyName = "Validacion"
        Me.Validacion.HeaderText = "Validacion"
        Me.Validacion.Name = "Validacion"
        Me.Validacion.ReadOnly = True
        Me.Validacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Validacion.Width = 150
        '
        'CategoriaHallazgo
        '
        Me.CategoriaHallazgo.DataPropertyName = "CategoriaHallazgo"
        Me.CategoriaHallazgo.HeaderText = "CategoriaHallazgo"
        Me.CategoriaHallazgo.Name = "CategoriaHallazgo"
        Me.CategoriaHallazgo.ReadOnly = True
        Me.CategoriaHallazgo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoriaHallazgo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CategoriaHallazgo.Width = 150
        '
        'id_auditoria
        '
        Me.id_auditoria.HeaderText = "id_auditoria"
        Me.id_auditoria.Name = "id_auditoria"
        Me.id_auditoria.ReadOnly = True
        Me.id_auditoria.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 328
        '
        'FechaSolventacion
        '
        Me.FechaSolventacion.HeaderText = "FechaSolventacion"
        Me.FechaSolventacion.Name = "FechaSolventacion"
        Me.FechaSolventacion.ReadOnly = True
        '
        'Comentarios
        '
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.ReadOnly = True
        Me.Comentarios.Width = 328
        '
        'Id_auditoriaCondicion
        '
        Me.Id_auditoriaCondicion.DataPropertyName = "Id_auditoriaCondicion"
        Me.Id_auditoriaCondicion.HeaderText = "Id_auditoriaCondicion"
        Me.Id_auditoriaCondicion.Name = "Id_auditoriaCondicion"
        Me.Id_auditoriaCondicion.ReadOnly = True
        Me.Id_auditoriaCondicion.Visible = False
        '
        'id_Cond
        '
        Me.id_Cond.DataPropertyName = "Id_Condicion"
        Me.id_Cond.HeaderText = "id_Cond"
        Me.id_Cond.Name = "id_Cond"
        Me.id_Cond.ReadOnly = True
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
        Me.btnAgregar.Location = New System.Drawing.Point(957, 505)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        Me.btnSalir.Location = New System.Drawing.Point(1119, 505)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FechaRelizacionDateTimePicker
        '
        Me.FechaRelizacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasBindingSource, "FechaRelizacion", True))
        Me.FechaRelizacionDateTimePicker.Location = New System.Drawing.Point(871, 38)
        Me.FechaRelizacionDateTimePicker.Name = "FechaRelizacionDateTimePicker"
        Me.FechaRelizacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRelizacionDateTimePicker.TabIndex = 7
        '
        'FolAuditoriaTextBox
        '
        Me.FolAuditoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasBindingSource, "folAuditoria", True))
        Me.FolAuditoriaTextBox.Location = New System.Drawing.Point(871, 64)
        Me.FolAuditoriaTextBox.Name = "FolAuditoriaTextBox"
        Me.FolAuditoriaTextBox.Size = New System.Drawing.Size(150, 20)
        Me.FolAuditoriaTextBox.TabIndex = 8
        '
        'frmAuditoriaMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 548)
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
    Friend WithEvents Id_Condicion As DataGridViewTextBoxColumn
    Friend WithEvents Validacion As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaHallazgo As DataGridViewTextBoxColumn
    Friend WithEvents id_auditoria As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolventacion As DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As DataGridViewTextBoxColumn
    Friend WithEvents Id_auditoriaCondicion As DataGridViewTextBoxColumn
    Friend WithEvents id_Cond As DataGridViewTextBoxColumn
End Class
