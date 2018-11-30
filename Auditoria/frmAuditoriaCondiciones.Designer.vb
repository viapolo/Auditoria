<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoriaCondiciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_auditoriaLabel As System.Windows.Forms.Label
        Dim Id_CondicionLabel As System.Windows.Forms.Label
        Dim ValidacionLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim CategoriaHallazgoLabel As System.Windows.Forms.Label
        Dim FechaSolventacionLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.AUDIT_AuditoriasCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_AuditoriasCondicionesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter()
        Me.TableAdapterManager = New Auditoria.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.Id_auditoriaTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.FechaSolventacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbCondicion = New System.Windows.Forms.ComboBox()
        Me.AUDITCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_CondicionesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_CondicionesTableAdapter()
        Me.cmbHallago = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbValidacion = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_ParametrosHTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosHTableAdapter()
        Me.AUDIT_ParametrosVTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosVTableAdapter()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Id_auditoriaLabel = New System.Windows.Forms.Label()
        Id_CondicionLabel = New System.Windows.Forms.Label()
        ValidacionLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CategoriaHallazgoLabel = New System.Windows.Forms.Label()
        FechaSolventacionLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_auditoriaLabel
        '
        Id_auditoriaLabel.AutoSize = True
        Id_auditoriaLabel.Location = New System.Drawing.Point(52, 14)
        Id_auditoriaLabel.Name = "Id_auditoriaLabel"
        Id_auditoriaLabel.Size = New System.Drawing.Size(62, 13)
        Id_auditoriaLabel.TabIndex = 1
        Id_auditoriaLabel.Text = "Id auditoria:"
        '
        'Id_CondicionLabel
        '
        Id_CondicionLabel.AutoSize = True
        Id_CondicionLabel.Location = New System.Drawing.Point(273, 14)
        Id_CondicionLabel.Name = "Id_CondicionLabel"
        Id_CondicionLabel.Size = New System.Drawing.Size(69, 13)
        Id_CondicionLabel.TabIndex = 2
        Id_CondicionLabel.Text = "Id Condicion:"
        '
        'ValidacionLabel
        '
        ValidacionLabel.AutoSize = True
        ValidacionLabel.Location = New System.Drawing.Point(560, 41)
        ValidacionLabel.Name = "ValidacionLabel"
        ValidacionLabel.Size = New System.Drawing.Size(59, 13)
        ValidacionLabel.TabIndex = 4
        ValidacionLabel.Text = "Validacion:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(33, 66)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 6
        ObservacionesLabel.Text = "Observaciones:"
        '
        'CategoriaHallazgoLabel
        '
        CategoriaHallazgoLabel.AutoSize = True
        CategoriaHallazgoLabel.Location = New System.Drawing.Point(15, 40)
        CategoriaHallazgoLabel.Name = "CategoriaHallazgoLabel"
        CategoriaHallazgoLabel.Size = New System.Drawing.Size(99, 13)
        CategoriaHallazgoLabel.TabIndex = 8
        CategoriaHallazgoLabel.Text = "Categoria Hallazgo:"
        '
        'FechaSolventacionLabel
        '
        FechaSolventacionLabel.AutoSize = True
        FechaSolventacionLabel.Location = New System.Drawing.Point(237, 41)
        FechaSolventacionLabel.Name = "FechaSolventacionLabel"
        FechaSolventacionLabel.Size = New System.Drawing.Size(105, 13)
        FechaSolventacionLabel.TabIndex = 10
        FechaSolventacionLabel.Text = "Fecha Solventacion:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(46, 131)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 12
        ComentariosLabel.Text = "Comentarios:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AUDIT_AuditoriasCondicionesBindingSource
        '
        Me.AUDIT_AuditoriasCondicionesBindingSource.DataMember = "AUDIT_AuditoriasCondiciones"
        Me.AUDIT_AuditoriasCondicionesBindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDIT_AuditoriasCondicionesTableAdapter
        '
        Me.AUDIT_AuditoriasCondicionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUDIT_AuditoriasCondicionesTableAdapter = Me.AUDIT_AuditoriasCondicionesTableAdapter
        Me.TableAdapterManager.AUDIT_AuditoriasTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_CondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosHTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosVTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Auditoria.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_auditoriaTextBox
        '
        Me.Id_auditoriaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_auditoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Id_auditoria", True))
        Me.Id_auditoriaTextBox.Enabled = False
        Me.Id_auditoriaTextBox.Location = New System.Drawing.Point(120, 11)
        Me.Id_auditoriaTextBox.Name = "Id_auditoriaTextBox"
        Me.Id_auditoriaTextBox.ReadOnly = True
        Me.Id_auditoriaTextBox.Size = New System.Drawing.Size(100, 13)
        Me.Id_auditoriaTextBox.TabIndex = 1
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(120, 63)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(605, 59)
        Me.ObservacionesTextBox.TabIndex = 6
        '
        'FechaSolventacionDateTimePicker
        '
        Me.FechaSolventacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasCondicionesBindingSource, "FechaSolventacion", True))
        Me.FechaSolventacionDateTimePicker.Location = New System.Drawing.Point(348, 37)
        Me.FechaSolventacionDateTimePicker.Name = "FechaSolventacionDateTimePicker"
        Me.FechaSolventacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaSolventacionDateTimePicker.TabIndex = 4
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(120, 128)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(605, 58)
        Me.ComentariosTextBox.TabIndex = 7
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(737, 102)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(737, 158)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbCondicion
        '
        Me.cmbCondicion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "Id_Condicion", True))
        Me.cmbCondicion.DataSource = Me.AUDITCondicionesBindingSource
        Me.cmbCondicion.DisplayMember = "Condicion"
        Me.cmbCondicion.FormattingEnabled = True
        Me.cmbCondicion.Location = New System.Drawing.Point(349, 11)
        Me.cmbCondicion.Name = "cmbCondicion"
        Me.cmbCondicion.Size = New System.Drawing.Size(376, 21)
        Me.cmbCondicion.TabIndex = 2
        Me.cmbCondicion.ValueMember = "id_Condicion"
        '
        'AUDITCondicionesBindingSource
        '
        Me.AUDITCondicionesBindingSource.DataMember = "AUDIT_Condiciones"
        Me.AUDITCondicionesBindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDIT_CondicionesTableAdapter
        '
        Me.AUDIT_CondicionesTableAdapter.ClearBeforeFill = True
        '
        'cmbHallago
        '
        Me.cmbHallago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "CategoriaHallazgo", True))
        Me.cmbHallago.DataSource = Me.AUDITParametrosHBindingSource
        Me.cmbHallago.DisplayMember = "Descripcion"
        Me.cmbHallago.FormattingEnabled = True
        Me.cmbHallago.Location = New System.Drawing.Point(120, 37)
        Me.cmbHallago.Name = "cmbHallago"
        Me.cmbHallago.Size = New System.Drawing.Size(100, 21)
        Me.cmbHallago.TabIndex = 3
        Me.cmbHallago.ValueMember = "id_Parametro"
        '
        'AUDITParametrosHBindingSource
        '
        Me.AUDITParametrosHBindingSource.DataMember = "AUDIT_ParametrosH"
        Me.AUDITParametrosHBindingSource.DataSource = Me.ProductionDataSet
        '
        'cmbValidacion
        '
        Me.cmbValidacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "Validacion", True))
        Me.cmbValidacion.DataSource = Me.AUDITParametrosVBindingSource
        Me.cmbValidacion.DisplayMember = "Descripcion"
        Me.cmbValidacion.FormattingEnabled = True
        Me.cmbValidacion.Location = New System.Drawing.Point(625, 37)
        Me.cmbValidacion.Name = "cmbValidacion"
        Me.cmbValidacion.Size = New System.Drawing.Size(100, 21)
        Me.cmbValidacion.TabIndex = 5
        Me.cmbValidacion.ValueMember = "id_Parametro"
        '
        'AUDITParametrosVBindingSource
        '
        Me.AUDITParametrosVBindingSource.DataMember = "AUDIT_ParametrosV"
        Me.AUDITParametrosVBindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDIT_ParametrosHTableAdapter
        '
        Me.AUDIT_ParametrosHTableAdapter.ClearBeforeFill = True
        '
        'AUDIT_ParametrosVTableAdapter
        '
        Me.AUDIT_ParametrosVTableAdapter.ClearBeforeFill = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(737, 131)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmAuditoriaCondiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(824, 203)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbValidacion)
        Me.Controls.Add(Me.cmbHallago)
        Me.Controls.Add(Me.cmbCondicion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Controls.Add(FechaSolventacionLabel)
        Me.Controls.Add(Me.FechaSolventacionDateTimePicker)
        Me.Controls.Add(CategoriaHallazgoLabel)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(ValidacionLabel)
        Me.Controls.Add(Id_CondicionLabel)
        Me.Controls.Add(Id_auditoriaLabel)
        Me.Controls.Add(Me.Id_auditoriaTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAuditoriaCondiciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAuditoriaCondiciones"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents AUDIT_AuditoriasCondicionesBindingSource As BindingSource
    Friend WithEvents AUDIT_AuditoriasCondicionesTableAdapter As ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_auditoriaTextBox As TextBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents FechaSolventacionDateTimePicker As DateTimePicker
    Friend WithEvents ComentariosTextBox As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbCondicion As ComboBox
    Friend WithEvents AUDITCondicionesBindingSource As BindingSource
    Friend WithEvents AUDIT_CondicionesTableAdapter As ProductionDataSetTableAdapters.AUDIT_CondicionesTableAdapter
    Friend WithEvents cmbHallago As ComboBox
    Friend WithEvents cmbValidacion As ComboBox
    Friend WithEvents AUDITParametrosHBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosHTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosHTableAdapter
    Friend WithEvents AUDITParametrosVBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosVTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosVTableAdapter
    Friend WithEvents btnGuardar As Button
End Class
