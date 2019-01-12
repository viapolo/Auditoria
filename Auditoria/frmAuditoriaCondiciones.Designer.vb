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
        Dim Id_auditoriaCondicionLabel As System.Windows.Forms.Label
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.Id_auditoriaTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.AUDIT_AuditoriasCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.cmbRevisiones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AUDIT_AuditoriasCondicionesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter()
        Me.TableAdapterManager = New Auditoria.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.FechaVigenciaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.cmbDeptoResponsable = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AUDIT_ParametrosDTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosDTableAdapter()
        Me.Id_auditoriaCondicionTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarRev = New System.Windows.Forms.Button()
        Me.grbDocumentosAdjuntos = New System.Windows.Forms.GroupBox()
        Me.btnArchivo1 = New System.Windows.Forms.Button()
        Me.btnArchivo2 = New System.Windows.Forms.Button()
        Me.btnArchivo3 = New System.Windows.Forms.Button()
        Me.pfdCargarArchivos = New System.Windows.Forms.OpenFileDialog()
        Id_auditoriaLabel = New System.Windows.Forms.Label()
        Id_CondicionLabel = New System.Windows.Forms.Label()
        ValidacionLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CategoriaHallazgoLabel = New System.Windows.Forms.Label()
        FechaSolventacionLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Id_auditoriaCondicionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDocumentosAdjuntos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_auditoriaLabel
        '
        Id_auditoriaLabel.AutoSize = True
        Id_auditoriaLabel.Location = New System.Drawing.Point(52, 11)
        Id_auditoriaLabel.Name = "Id_auditoriaLabel"
        Id_auditoriaLabel.Size = New System.Drawing.Size(62, 13)
        Id_auditoriaLabel.TabIndex = 1
        Id_auditoriaLabel.Text = "Id auditoria:"
        '
        'Id_CondicionLabel
        '
        Id_CondicionLabel.AutoSize = True
        Id_CondicionLabel.Location = New System.Drawing.Point(273, 40)
        Id_CondicionLabel.Name = "Id_CondicionLabel"
        Id_CondicionLabel.Size = New System.Drawing.Size(69, 13)
        Id_CondicionLabel.TabIndex = 2
        Id_CondicionLabel.Text = "Id Condicion:"
        '
        'ValidacionLabel
        '
        ValidacionLabel.AutoSize = True
        ValidacionLabel.Location = New System.Drawing.Point(55, 41)
        ValidacionLabel.Name = "ValidacionLabel"
        ValidacionLabel.Size = New System.Drawing.Size(59, 13)
        ValidacionLabel.TabIndex = 4
        ValidacionLabel.Text = "Validacion:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(33, 95)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 6
        ObservacionesLabel.Text = "Observaciones:"
        '
        'CategoriaHallazgoLabel
        '
        CategoriaHallazgoLabel.AutoSize = True
        CategoriaHallazgoLabel.Location = New System.Drawing.Point(15, 67)
        CategoriaHallazgoLabel.Name = "CategoriaHallazgoLabel"
        CategoriaHallazgoLabel.Size = New System.Drawing.Size(99, 13)
        CategoriaHallazgoLabel.TabIndex = 8
        CategoriaHallazgoLabel.Text = "Categoria Hallazgo:"
        '
        'FechaSolventacionLabel
        '
        FechaSolventacionLabel.AutoSize = True
        FechaSolventacionLabel.Location = New System.Drawing.Point(237, 70)
        FechaSolventacionLabel.Name = "FechaSolventacionLabel"
        FechaSolventacionLabel.Size = New System.Drawing.Size(105, 13)
        FechaSolventacionLabel.TabIndex = 10
        FechaSolventacionLabel.Text = "Fecha Solventacion:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(46, 259)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 12
        ComentariosLabel.Text = "Comentarios:"
        '
        'Id_auditoriaCondicionLabel
        '
        Id_auditoriaCondicionLabel.AutoSize = True
        Id_auditoriaCondicionLabel.Location = New System.Drawing.Point(48, 423)
        Id_auditoriaCondicionLabel.Name = "Id_auditoriaCondicionLabel"
        Id_auditoriaCondicionLabel.Size = New System.Drawing.Size(66, 13)
        Id_auditoriaCondicionLabel.TabIndex = 23
        Id_auditoriaCondicionLabel.Text = "Id AudCond:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_auditoriaTextBox
        '
        Me.Id_auditoriaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.ObservacionesTextBox.Enabled = False
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(120, 92)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(605, 158)
        Me.ObservacionesTextBox.TabIndex = 9
        '
        'AUDIT_AuditoriasCondicionesBindingSource
        '
        Me.AUDIT_AuditoriasCondicionesBindingSource.DataMember = "AUDIT_AuditoriasCondiciones"
        Me.AUDIT_AuditoriasCondicionesBindingSource.DataSource = Me.ProductionDataSet
        '
        'FechaSolventacionDateTimePicker
        '
        Me.FechaSolventacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasCondicionesBindingSource, "FechaSolventacion", True))
        Me.FechaSolventacionDateTimePicker.Enabled = False
        Me.FechaSolventacionDateTimePicker.Location = New System.Drawing.Point(348, 66)
        Me.FechaSolventacionDateTimePicker.Name = "FechaSolventacionDateTimePicker"
        Me.FechaSolventacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaSolventacionDateTimePicker.TabIndex = 7
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Enabled = False
        Me.ComentariosTextBox.Location = New System.Drawing.Point(120, 256)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(605, 158)
        Me.ComentariosTextBox.TabIndex = 10
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(748, 330)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 23)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(748, 386)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbCondicion
        '
        Me.cmbCondicion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "Id_Condicion", True))
        Me.cmbCondicion.DataSource = Me.AUDITCondicionesBindingSource
        Me.cmbCondicion.DisplayMember = "Condicion"
        Me.cmbCondicion.Enabled = False
        Me.cmbCondicion.FormattingEnabled = True
        Me.cmbCondicion.Location = New System.Drawing.Point(349, 37)
        Me.cmbCondicion.Name = "cmbCondicion"
        Me.cmbCondicion.Size = New System.Drawing.Size(518, 21)
        Me.cmbCondicion.TabIndex = 5
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
        Me.cmbHallago.Enabled = False
        Me.cmbHallago.FormattingEnabled = True
        Me.cmbHallago.Location = New System.Drawing.Point(120, 64)
        Me.cmbHallago.Name = "cmbHallago"
        Me.cmbHallago.Size = New System.Drawing.Size(100, 21)
        Me.cmbHallago.TabIndex = 4
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
        Me.cmbValidacion.Enabled = False
        Me.cmbValidacion.FormattingEnabled = True
        Me.cmbValidacion.Location = New System.Drawing.Point(120, 37)
        Me.cmbValidacion.Name = "cmbValidacion"
        Me.cmbValidacion.Size = New System.Drawing.Size(100, 21)
        Me.cmbValidacion.TabIndex = 6
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
        Me.btnGuardar.Location = New System.Drawing.Point(748, 359)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(119, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cmbRevisiones
        '
        Me.cmbRevisiones.DataSource = Me.AUDIT_AuditoriasCondicionesBindingSource
        Me.cmbRevisiones.DisplayMember = "ConsecRevisiones"
        Me.cmbRevisiones.Enabled = False
        Me.cmbRevisiones.FormattingEnabled = True
        Me.cmbRevisiones.Location = New System.Drawing.Point(349, 10)
        Me.cmbRevisiones.Name = "cmbRevisiones"
        Me.cmbRevisiones.Size = New System.Drawing.Size(79, 21)
        Me.cmbRevisiones.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Revisiones:"
        '
        'AUDIT_AuditoriasCondicionesTableAdapter
        '
        Me.AUDIT_AuditoriasCondicionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActifijoTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AnalistasTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasCondicionesTableAdapter = Me.AUDIT_AuditoriasCondicionesTableAdapter
        Me.TableAdapterManager.AUDIT_AuditoriasTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_CondicionesTableAdapter = Me.AUDIT_CondicionesTableAdapter
        Me.TableAdapterManager.AUDIT_OrgAutorizacionTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosDTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosHTableAdapter = Me.AUDIT_ParametrosHTableAdapter
        Me.TableAdapterManager.AUDIT_ParametrosTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosVTableAdapter = Me.AUDIT_ParametrosVTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auditoria.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FechaVigenciaDateTimePicker
        '
        Me.FechaVigenciaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasCondicionesBindingSource, "fechaVigencia", True))
        Me.FechaVigenciaDateTimePicker.Enabled = False
        Me.FechaVigenciaDateTimePicker.Location = New System.Drawing.Point(667, 66)
        Me.FechaVigenciaDateTimePicker.Name = "FechaVigenciaDateTimePicker"
        Me.FechaVigenciaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaVigenciaDateTimePicker.TabIndex = 8
        Me.FechaVigenciaDateTimePicker.Visible = False
        '
        'cmbDeptoResponsable
        '
        Me.cmbDeptoResponsable.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "deptoResponsable", True))
        Me.cmbDeptoResponsable.DataSource = Me.AUDITParametrosDBindingSource
        Me.cmbDeptoResponsable.DisplayMember = "descripcionCompleta"
        Me.cmbDeptoResponsable.Enabled = False
        Me.cmbDeptoResponsable.FormattingEnabled = True
        Me.cmbDeptoResponsable.Location = New System.Drawing.Point(551, 8)
        Me.cmbDeptoResponsable.Name = "cmbDeptoResponsable"
        Me.cmbDeptoResponsable.Size = New System.Drawing.Size(316, 21)
        Me.cmbDeptoResponsable.TabIndex = 22
        Me.cmbDeptoResponsable.ValueMember = "id_Parametro"
        '
        'AUDITParametrosDBindingSource
        '
        Me.AUDITParametrosDBindingSource.DataMember = "AUDIT_ParametrosD"
        Me.AUDITParametrosDBindingSource.DataSource = Me.ProductionDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Depto Responsable:"
        '
        'AUDIT_ParametrosDTableAdapter
        '
        Me.AUDIT_ParametrosDTableAdapter.ClearBeforeFill = True
        '
        'Id_auditoriaCondicionTextBox
        '
        Me.Id_auditoriaCondicionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Id_auditoriaCondicion", True))
        Me.Id_auditoriaCondicionTextBox.Enabled = False
        Me.Id_auditoriaCondicionTextBox.Location = New System.Drawing.Point(120, 420)
        Me.Id_auditoriaCondicionTextBox.Name = "Id_auditoriaCondicionTextBox"
        Me.Id_auditoriaCondicionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_auditoriaCondicionTextBox.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(563, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Fecha de vigencia:"
        Me.Label3.Visible = False
        '
        'btnAgregarRev
        '
        Me.btnAgregarRev.Location = New System.Drawing.Point(748, 301)
        Me.btnAgregarRev.Name = "btnAgregarRev"
        Me.btnAgregarRev.Size = New System.Drawing.Size(119, 23)
        Me.btnAgregarRev.TabIndex = 26
        Me.btnAgregarRev.Text = "Agregar Revisiones"
        Me.btnAgregarRev.UseVisualStyleBackColor = True
        '
        'grbDocumentosAdjuntos
        '
        Me.grbDocumentosAdjuntos.Controls.Add(Me.btnArchivo3)
        Me.grbDocumentosAdjuntos.Controls.Add(Me.btnArchivo2)
        Me.grbDocumentosAdjuntos.Controls.Add(Me.btnArchivo1)
        Me.grbDocumentosAdjuntos.Location = New System.Drawing.Point(731, 109)
        Me.grbDocumentosAdjuntos.Name = "grbDocumentosAdjuntos"
        Me.grbDocumentosAdjuntos.Size = New System.Drawing.Size(136, 121)
        Me.grbDocumentosAdjuntos.TabIndex = 27
        Me.grbDocumentosAdjuntos.TabStop = False
        Me.grbDocumentosAdjuntos.Text = "Documentos adjuntos"
        '
        'btnArchivo1
        '
        Me.btnArchivo1.Location = New System.Drawing.Point(6, 25)
        Me.btnArchivo1.Name = "btnArchivo1"
        Me.btnArchivo1.Size = New System.Drawing.Size(124, 23)
        Me.btnArchivo1.TabIndex = 0
        Me.btnArchivo1.Text = "Adjuntar archivo..."
        Me.btnArchivo1.UseVisualStyleBackColor = True
        '
        'btnArchivo2
        '
        Me.btnArchivo2.Location = New System.Drawing.Point(6, 54)
        Me.btnArchivo2.Name = "btnArchivo2"
        Me.btnArchivo2.Size = New System.Drawing.Size(124, 23)
        Me.btnArchivo2.TabIndex = 1
        Me.btnArchivo2.Text = "Adjuntar archivo..."
        Me.btnArchivo2.UseVisualStyleBackColor = True
        '
        'btnArchivo3
        '
        Me.btnArchivo3.Location = New System.Drawing.Point(7, 84)
        Me.btnArchivo3.Name = "btnArchivo3"
        Me.btnArchivo3.Size = New System.Drawing.Size(123, 23)
        Me.btnArchivo3.TabIndex = 2
        Me.btnArchivo3.Text = "Adjuntar archivo..."
        Me.btnArchivo3.UseVisualStyleBackColor = True
        '
        'pfdCargarArchivos
        '
        Me.pfdCargarArchivos.FileName = "OpenFileDialog1"
        '
        'frmAuditoriaCondiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(887, 449)
        Me.Controls.Add(Me.grbDocumentosAdjuntos)
        Me.Controls.Add(Me.btnAgregarRev)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Id_auditoriaCondicionLabel)
        Me.Controls.Add(Me.Id_auditoriaCondicionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbDeptoResponsable)
        Me.Controls.Add(Me.FechaVigenciaDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRevisiones)
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
        Me.Text = "Condición"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDocumentosAdjuntos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
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
    Friend WithEvents cmbRevisiones As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AUDIT_AuditoriasCondicionesBindingSource As BindingSource
    Friend WithEvents AUDIT_AuditoriasCondicionesTableAdapter As ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FechaVigenciaDateTimePicker As DateTimePicker
    Friend WithEvents cmbDeptoResponsable As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AUDITParametrosDBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosDTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosDTableAdapter
    Friend WithEvents Id_auditoriaCondicionTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregarRev As Button
    Friend WithEvents grbDocumentosAdjuntos As GroupBox
    Friend WithEvents btnArchivo3 As Button
    Friend WithEvents btnArchivo2 As Button
    Friend WithEvents btnArchivo1 As Button
    Friend WithEvents pfdCargarArchivos As OpenFileDialog
End Class
