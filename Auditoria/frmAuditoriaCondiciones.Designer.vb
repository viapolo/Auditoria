﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim NomOtrosLabel As System.Windows.Forms.Label
        Dim FechaCompromisoLabel As System.Windows.Forms.Label
        Dim ComAreaRespLabel As System.Windows.Forms.Label
        Dim RecomendacionesLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.Id_auditoriaTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.AUDIT_AuditoriasCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.FechaSolventacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbCondicion = New System.Windows.Forms.ComboBox()
        Me.AUDITCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbHallago = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbValidacion = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cmbRevisiones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaVigenciaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.cmbDeptoResponsable = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id_auditoriaCondicionTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarRev = New System.Windows.Forms.Button()
        Me.grbDocumentosAdjuntos = New System.Windows.Forms.GroupBox()
        Me.lklAbrir3 = New System.Windows.Forms.LinkLabel()
        Me.lklAbrir2 = New System.Windows.Forms.LinkLabel()
        Me.lklAbrir1 = New System.Windows.Forms.LinkLabel()
        Me.btnArchivo3 = New System.Windows.Forms.Button()
        Me.btnArchivo2 = New System.Windows.Forms.Button()
        Me.btnArchivo1 = New System.Windows.Forms.Button()
        Me.pfdCargarArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.NomOtrosTextBox = New System.Windows.Forms.TextBox()
        Me.cmbUsuarioResponsable = New System.Windows.Forms.ComboBox()
        Me.USUARIOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Seguridad = New Auditoria.Seguridad()
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOTableAdapter = New Auditoria.SeguridadTableAdapters.USUARIOTableAdapter()
        Me.AUDIT_CondicionesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_CondicionesTableAdapter()
        Me.AUDIT_ParametrosHTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosHTableAdapter()
        Me.AUDIT_ParametrosVTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosVTableAdapter()
        Me.AUDIT_AuditoriasCondicionesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter()
        Me.TableAdapterManager = New Auditoria.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.AUDIT_ParametrosDTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosDTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaCompromisoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AUDITEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.AUDIT_ParametrosTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bsoEstatusEnvio = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AUDIT_ParametrosAllTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosAllTableAdapter()
        Me.ComAreaRespTextBox = New System.Windows.Forms.TextBox()
        Me.RecomendacionesTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.AUDITParametrosABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUDIT_ParametrosRTableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosRTableAdapter()
        Me.AUDIT_ParametrosATableAdapter = New Auditoria.ProductionDataSetTableAdapters.AUDIT_ParametrosATableAdapter()
        Id_auditoriaLabel = New System.Windows.Forms.Label()
        Id_CondicionLabel = New System.Windows.Forms.Label()
        ValidacionLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CategoriaHallazgoLabel = New System.Windows.Forms.Label()
        FechaSolventacionLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Id_auditoriaCondicionLabel = New System.Windows.Forms.Label()
        NomOtrosLabel = New System.Windows.Forms.Label()
        FechaCompromisoLabel = New System.Windows.Forms.Label()
        ComAreaRespLabel = New System.Windows.Forms.Label()
        RecomendacionesLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDocumentosAdjuntos.SuspendLayout()
        CType(Me.USUARIOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Seguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsoEstatusEnvio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITParametrosABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_auditoriaLabel
        '
        Id_auditoriaLabel.AutoSize = True
        Id_auditoriaLabel.Location = New System.Drawing.Point(316, 467)
        Id_auditoriaLabel.Name = "Id_auditoriaLabel"
        Id_auditoriaLabel.Size = New System.Drawing.Size(62, 13)
        Id_auditoriaLabel.TabIndex = 1
        Id_auditoriaLabel.Text = "Id auditoria:"
        '
        'Id_CondicionLabel
        '
        Id_CondicionLabel.AutoSize = True
        Id_CondicionLabel.Location = New System.Drawing.Point(155, 465)
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
        ObservacionesLabel.Location = New System.Drawing.Point(15, 118)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(51, 13)
        ObservacionesLabel.TabIndex = 6
        ObservacionesLabel.Text = "Hallazgo:"
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
        FechaSolventacionLabel.Location = New System.Drawing.Point(556, 16)
        FechaSolventacionLabel.Name = "FechaSolventacionLabel"
        FechaSolventacionLabel.Size = New System.Drawing.Size(105, 13)
        FechaSolventacionLabel.TabIndex = 10
        FechaSolventacionLabel.Text = "Fecha Solventacion:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(15, 372)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(138, 13)
        ComentariosLabel.TabIndex = 12
        ComentariosLabel.Text = "Comentarios para solventar:"
        '
        'Id_auditoriaCondicionLabel
        '
        Id_auditoriaCondicionLabel.AutoSize = True
        Id_auditoriaCondicionLabel.Location = New System.Drawing.Point(18, 465)
        Id_auditoriaCondicionLabel.Name = "Id_auditoriaCondicionLabel"
        Id_auditoriaCondicionLabel.Size = New System.Drawing.Size(66, 13)
        Id_auditoriaCondicionLabel.TabIndex = 23
        Id_auditoriaCondicionLabel.Text = "Id AudCond:"
        '
        'NomOtrosLabel
        '
        NomOtrosLabel.AutoSize = True
        NomOtrosLabel.Location = New System.Drawing.Point(257, 66)
        NomOtrosLabel.Name = "NomOtrosLabel"
        NomOtrosLabel.Size = New System.Drawing.Size(75, 13)
        NomOtrosLabel.TabIndex = 27
        NomOtrosLabel.Text = "Nombre Otros:"
        '
        'FechaCompromisoLabel
        '
        FechaCompromisoLabel.AutoSize = True
        FechaCompromisoLabel.Location = New System.Drawing.Point(561, 66)
        FechaCompromisoLabel.Name = "FechaCompromisoLabel"
        FechaCompromisoLabel.Size = New System.Drawing.Size(100, 13)
        FechaCompromisoLabel.TabIndex = 31
        FechaCompromisoLabel.Text = "Fecha Compromiso:"
        '
        'ComAreaRespLabel
        '
        ComAreaRespLabel.AutoSize = True
        ComAreaRespLabel.Location = New System.Drawing.Point(15, 203)
        ComAreaRespLabel.Name = "ComAreaRespLabel"
        ComAreaRespLabel.Size = New System.Drawing.Size(169, 13)
        ComAreaRespLabel.TabIndex = 37
        ComAreaRespLabel.Text = "Comentarios del área responsable:"
        '
        'RecomendacionesLabel
        '
        RecomendacionesLabel.AutoSize = True
        RecomendacionesLabel.Location = New System.Drawing.Point(15, 287)
        RecomendacionesLabel.Name = "RecomendacionesLabel"
        RecomendacionesLabel.Size = New System.Drawing.Size(99, 13)
        RecomendacionesLabel.TabIndex = 39
        RecomendacionesLabel.Text = "Recomendaciones:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(29, 95)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(85, 13)
        Label7.TabIndex = 43
        Label7.Text = "Nivel de Riesgo:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(296, 95)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(82, 13)
        Label8.TabIndex = 44
        Label8.Text = "Tipo de Acción:"
        '
        'Id_auditoriaTextBox
        '
        Me.Id_auditoriaTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Id_auditoriaTextBox.Enabled = False
        Me.Id_auditoriaTextBox.Location = New System.Drawing.Point(384, 464)
        Me.Id_auditoriaTextBox.Name = "Id_auditoriaTextBox"
        Me.Id_auditoriaTextBox.ReadOnly = True
        Me.Id_auditoriaTextBox.Size = New System.Drawing.Size(63, 20)
        Me.Id_auditoriaTextBox.TabIndex = 0
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Enabled = False
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(18, 134)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(707, 64)
        Me.ObservacionesTextBox.TabIndex = 11
        '
        'AUDIT_AuditoriasCondicionesBindingSource
        '
        Me.AUDIT_AuditoriasCondicionesBindingSource.DataMember = "AUDIT_AuditoriasCondiciones"
        Me.AUDIT_AuditoriasCondicionesBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaSolventacionDateTimePicker
        '
        Me.FechaSolventacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasCondicionesBindingSource, "FechaSolventacion", True))
        Me.FechaSolventacionDateTimePicker.Enabled = False
        Me.FechaSolventacionDateTimePicker.Location = New System.Drawing.Point(667, 12)
        Me.FechaSolventacionDateTimePicker.Name = "FechaSolventacionDateTimePicker"
        Me.FechaSolventacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaSolventacionDateTimePicker.TabIndex = 2
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Enabled = False
        Me.ComentariosTextBox.Location = New System.Drawing.Point(18, 389)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(707, 67)
        Me.ComentariosTextBox.TabIndex = 14
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(748, 345)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 23)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(748, 401)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 23)
        Me.btnSalir.TabIndex = 25
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
        Me.cmbCondicion.Location = New System.Drawing.Point(231, 462)
        Me.cmbCondicion.Name = "cmbCondicion"
        Me.cmbCondicion.Size = New System.Drawing.Size(80, 21)
        Me.cmbCondicion.TabIndex = 5
        Me.cmbCondicion.ValueMember = "id_Condicion"
        '
        'AUDITCondicionesBindingSource
        '
        Me.AUDITCondicionesBindingSource.DataMember = "AUDIT_Condiciones"
        Me.AUDITCondicionesBindingSource.DataSource = Me.ProductionDataSet
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
        Me.cmbHallago.TabIndex = 6
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
        Me.cmbValidacion.TabIndex = 3
        Me.cmbValidacion.ValueMember = "id_Parametro"
        '
        'AUDITParametrosVBindingSource
        '
        Me.AUDITParametrosVBindingSource.DataMember = "AUDIT_ParametrosV"
        Me.AUDITParametrosVBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(748, 374)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(119, 23)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'cmbRevisiones
        '
        Me.cmbRevisiones.DataSource = Me.AUDIT_AuditoriasCondicionesBindingSource
        Me.cmbRevisiones.DisplayMember = "ConsecRevisiones"
        Me.cmbRevisiones.Enabled = False
        Me.cmbRevisiones.FormattingEnabled = True
        Me.cmbRevisiones.Location = New System.Drawing.Point(120, 8)
        Me.cmbRevisiones.Name = "cmbRevisiones"
        Me.cmbRevisiones.Size = New System.Drawing.Size(100, 21)
        Me.cmbRevisiones.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Revisiones:"
        '
        'FechaVigenciaDateTimePicker
        '
        Me.FechaVigenciaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasCondicionesBindingSource, "fechaVigencia", True))
        Me.FechaVigenciaDateTimePicker.Enabled = False
        Me.FechaVigenciaDateTimePicker.Location = New System.Drawing.Point(667, 38)
        Me.FechaVigenciaDateTimePicker.Name = "FechaVigenciaDateTimePicker"
        Me.FechaVigenciaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaVigenciaDateTimePicker.TabIndex = 5
        Me.FechaVigenciaDateTimePicker.Visible = False
        '
        'cmbDeptoResponsable
        '
        Me.cmbDeptoResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbDeptoResponsable.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "deptoResponsable", True))
        Me.cmbDeptoResponsable.DataSource = Me.AUDITParametrosDBindingSource
        Me.cmbDeptoResponsable.DisplayMember = "descripcionCompleta"
        Me.cmbDeptoResponsable.Enabled = False
        Me.cmbDeptoResponsable.FormattingEnabled = True
        Me.cmbDeptoResponsable.Location = New System.Drawing.Point(338, 8)
        Me.cmbDeptoResponsable.Name = "cmbDeptoResponsable"
        Me.cmbDeptoResponsable.Size = New System.Drawing.Size(210, 21)
        Me.cmbDeptoResponsable.TabIndex = 1
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
        Me.Label2.Location = New System.Drawing.Point(228, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Depto Responsable:"
        '
        'Id_auditoriaCondicionTextBox
        '
        Me.Id_auditoriaCondicionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "Id_auditoriaCondicion", True))
        Me.Id_auditoriaCondicionTextBox.Enabled = False
        Me.Id_auditoriaCondicionTextBox.Location = New System.Drawing.Point(90, 462)
        Me.Id_auditoriaCondicionTextBox.Name = "Id_auditoriaCondicionTextBox"
        Me.Id_auditoriaCondicionTextBox.Size = New System.Drawing.Size(63, 20)
        Me.Id_auditoriaCondicionTextBox.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(563, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Fecha de Vigencia:"
        Me.Label3.Visible = False
        '
        'btnAgregarRev
        '
        Me.btnAgregarRev.Location = New System.Drawing.Point(748, 316)
        Me.btnAgregarRev.Name = "btnAgregarRev"
        Me.btnAgregarRev.Size = New System.Drawing.Size(119, 23)
        Me.btnAgregarRev.TabIndex = 22
        Me.btnAgregarRev.Text = "Agregar Revisiones"
        Me.btnAgregarRev.UseVisualStyleBackColor = True
        '
        'grbDocumentosAdjuntos
        '
        Me.grbDocumentosAdjuntos.Controls.Add(Me.lklAbrir3)
        Me.grbDocumentosAdjuntos.Controls.Add(Me.lklAbrir2)
        Me.grbDocumentosAdjuntos.Controls.Add(Me.lklAbrir1)
        Me.grbDocumentosAdjuntos.Controls.Add(Me.btnArchivo3)
        Me.grbDocumentosAdjuntos.Controls.Add(Me.btnArchivo2)
        Me.grbDocumentosAdjuntos.Controls.Add(Me.btnArchivo1)
        Me.grbDocumentosAdjuntos.Location = New System.Drawing.Point(731, 124)
        Me.grbDocumentosAdjuntos.Name = "grbDocumentosAdjuntos"
        Me.grbDocumentosAdjuntos.Size = New System.Drawing.Size(136, 169)
        Me.grbDocumentosAdjuntos.TabIndex = 27
        Me.grbDocumentosAdjuntos.TabStop = False
        Me.grbDocumentosAdjuntos.Text = "Documentos adjuntos"
        '
        'lklAbrir3
        '
        Me.lklAbrir3.AutoSize = True
        Me.lklAbrir3.Location = New System.Drawing.Point(101, 144)
        Me.lklAbrir3.Name = "lklAbrir3"
        Me.lklAbrir3.Size = New System.Drawing.Size(28, 13)
        Me.lklAbrir3.TabIndex = 21
        Me.lklAbrir3.TabStop = True
        Me.lklAbrir3.Text = "Abrir"
        Me.lklAbrir3.Visible = False
        '
        'lklAbrir2
        '
        Me.lklAbrir2.AutoSize = True
        Me.lklAbrir2.Location = New System.Drawing.Point(101, 98)
        Me.lklAbrir2.Name = "lklAbrir2"
        Me.lklAbrir2.Size = New System.Drawing.Size(28, 13)
        Me.lklAbrir2.TabIndex = 19
        Me.lklAbrir2.TabStop = True
        Me.lklAbrir2.Text = "Abrir"
        Me.lklAbrir2.Visible = False
        '
        'lklAbrir1
        '
        Me.lklAbrir1.AutoSize = True
        Me.lklAbrir1.Location = New System.Drawing.Point(102, 51)
        Me.lklAbrir1.Name = "lklAbrir1"
        Me.lklAbrir1.Size = New System.Drawing.Size(28, 13)
        Me.lklAbrir1.TabIndex = 17
        Me.lklAbrir1.TabStop = True
        Me.lklAbrir1.Text = "Abrir"
        Me.lklAbrir1.Visible = False
        '
        'btnArchivo3
        '
        Me.btnArchivo3.Location = New System.Drawing.Point(6, 118)
        Me.btnArchivo3.Name = "btnArchivo3"
        Me.btnArchivo3.Size = New System.Drawing.Size(123, 23)
        Me.btnArchivo3.TabIndex = 20
        Me.btnArchivo3.Text = "Adjuntar archivo..."
        Me.btnArchivo3.UseVisualStyleBackColor = True
        '
        'btnArchivo2
        '
        Me.btnArchivo2.Location = New System.Drawing.Point(6, 72)
        Me.btnArchivo2.Name = "btnArchivo2"
        Me.btnArchivo2.Size = New System.Drawing.Size(124, 23)
        Me.btnArchivo2.TabIndex = 18
        Me.btnArchivo2.Text = "Adjuntar archivo..."
        Me.btnArchivo2.UseVisualStyleBackColor = True
        '
        'btnArchivo1
        '
        Me.btnArchivo1.Location = New System.Drawing.Point(6, 25)
        Me.btnArchivo1.Name = "btnArchivo1"
        Me.btnArchivo1.Size = New System.Drawing.Size(124, 23)
        Me.btnArchivo1.TabIndex = 16
        Me.btnArchivo1.Text = "Adjuntar archivo..."
        Me.btnArchivo1.UseVisualStyleBackColor = True
        '
        'pfdCargarArchivos
        '
        Me.pfdCargarArchivos.FileName = "OpenFileDialog1"
        '
        'NomOtrosTextBox
        '
        Me.NomOtrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "nomOtros", True))
        Me.NomOtrosTextBox.Enabled = False
        Me.NomOtrosTextBox.Location = New System.Drawing.Point(338, 63)
        Me.NomOtrosTextBox.Name = "NomOtrosTextBox"
        Me.NomOtrosTextBox.Size = New System.Drawing.Size(210, 20)
        Me.NomOtrosTextBox.TabIndex = 7
        '
        'cmbUsuarioResponsable
        '
        Me.cmbUsuarioResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbUsuarioResponsable.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "usuarioResponsable", True))
        Me.cmbUsuarioResponsable.DataSource = Me.USUARIOBindingSource1
        Me.cmbUsuarioResponsable.DisplayMember = "nombre"
        Me.cmbUsuarioResponsable.FormattingEnabled = True
        Me.cmbUsuarioResponsable.Location = New System.Drawing.Point(367, 36)
        Me.cmbUsuarioResponsable.Name = "cmbUsuarioResponsable"
        Me.cmbUsuarioResponsable.Size = New System.Drawing.Size(181, 21)
        Me.cmbUsuarioResponsable.TabIndex = 4
        Me.cmbUsuarioResponsable.ValueMember = "cve_empleado"
        '
        'USUARIOBindingSource1
        '
        Me.USUARIOBindingSource1.DataMember = "USUARIO"
        Me.USUARIOBindingSource1.DataSource = Me.SeguridadBindingSource
        '
        'SeguridadBindingSource
        '
        Me.SeguridadBindingSource.DataSource = Me.Seguridad
        Me.SeguridadBindingSource.Position = 0
        '
        'Seguridad
        '
        Me.Seguridad.DataSetName = "Seguridad"
        Me.Seguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me.SeguridadBindingSource
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'AUDIT_CondicionesTableAdapter
        '
        Me.AUDIT_CondicionesTableAdapter.ClearBeforeFill = True
        '
        'AUDIT_ParametrosHTableAdapter
        '
        Me.AUDIT_ParametrosHTableAdapter.ClearBeforeFill = True
        '
        'AUDIT_ParametrosVTableAdapter
        '
        Me.AUDIT_ParametrosVTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.AUDIT_ParametrosAllTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosATableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosDTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosHTableAdapter = Me.AUDIT_ParametrosHTableAdapter
        Me.TableAdapterManager.AUDIT_ParametrosRTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosVTableAdapter = Me.AUDIT_ParametrosVTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auditoria.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AUDIT_ParametrosDTableAdapter
        '
        Me.AUDIT_ParametrosDTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Responsable de solventar:"
        '
        'FechaCompromisoDateTimePicker
        '
        Me.FechaCompromisoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AUDIT_AuditoriasCondicionesBindingSource, "fechaCompromiso", True))
        Me.FechaCompromisoDateTimePicker.Location = New System.Drawing.Point(667, 63)
        Me.FechaCompromisoDateTimePicker.Name = "FechaCompromisoDateTimePicker"
        Me.FechaCompromisoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaCompromisoDateTimePicker.TabIndex = 8
        '
        'AUDITEstatusBindingSource
        '
        Me.AUDITEstatusBindingSource.DataMember = "AUDIT_Parametros"
        Me.AUDITEstatusBindingSource.DataSource = Me.ProductionDataSet
        Me.AUDITEstatusBindingSource.Filter = "Tipo = 'ESTATUSC'"
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "estatusCond", True))
        Me.cmbEstatus.DataSource = Me.AUDITEstatusBindingSource
        Me.cmbEstatus.DisplayMember = "Descripcion"
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(512, 463)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(181, 21)
        Me.cmbEstatus.TabIndex = 15
        Me.cmbEstatus.ValueMember = "id_Parametro"
        '
        'AUDIT_ParametrosTableAdapter
        '
        Me.AUDIT_ParametrosTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 465)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Estatus:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "estatusEnv", True))
        Me.ComboBox1.DataSource = Me.bsoEstatusEnvio
        Me.ComboBox1.DisplayMember = "Descripcion"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(765, 464)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox1.TabIndex = 26
        Me.ComboBox1.ValueMember = "id_Parametro"
        Me.ComboBox1.Visible = False
        '
        'bsoEstatusEnvio
        '
        Me.bsoEstatusEnvio.DataMember = "AUDIT_ParametrosAll"
        Me.bsoEstatusEnvio.DataSource = Me.ProductionDataSet
        Me.bsoEstatusEnvio.Filter = "Tipo='ESTATUSE' and Activo=1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(709, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Est. Env:"
        Me.Label6.Visible = False
        '
        'AUDIT_ParametrosAllTableAdapter
        '
        Me.AUDIT_ParametrosAllTableAdapter.ClearBeforeFill = True
        '
        'ComAreaRespTextBox
        '
        Me.ComAreaRespTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "comAreaResp", True))
        Me.ComAreaRespTextBox.Location = New System.Drawing.Point(18, 219)
        Me.ComAreaRespTextBox.Multiline = True
        Me.ComAreaRespTextBox.Name = "ComAreaRespTextBox"
        Me.ComAreaRespTextBox.Size = New System.Drawing.Size(707, 64)
        Me.ComAreaRespTextBox.TabIndex = 12
        '
        'RecomendacionesTextBox
        '
        Me.RecomendacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUDIT_AuditoriasCondicionesBindingSource, "recomendaciones", True))
        Me.RecomendacionesTextBox.Location = New System.Drawing.Point(18, 303)
        Me.RecomendacionesTextBox.Multiline = True
        Me.RecomendacionesTextBox.Name = "RecomendacionesTextBox"
        Me.RecomendacionesTextBox.Size = New System.Drawing.Size(707, 64)
        Me.RecomendacionesTextBox.TabIndex = 13
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "nivelRiesgo", True))
        Me.ComboBox2.DataSource = Me.AUDITParametrosRBindingSource
        Me.ComboBox2.DisplayMember = "Descripcion"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(120, 92)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(153, 21)
        Me.ComboBox2.TabIndex = 9
        Me.ComboBox2.ValueMember = "id_Parametro"
        '
        'AUDITParametrosRBindingSource
        '
        Me.AUDITParametrosRBindingSource.DataMember = "AUDIT_ParametrosR"
        Me.AUDITParametrosRBindingSource.DataSource = Me.ProductionDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AUDIT_AuditoriasCondicionesBindingSource, "tipoAccion", True))
        Me.ComboBox3.DataSource = Me.AUDITParametrosABindingSource
        Me.ComboBox3.DisplayMember = "Descripcion"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(384, 92)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox3.TabIndex = 10
        Me.ComboBox3.ValueMember = "id_Parametro"
        '
        'AUDITParametrosABindingSource
        '
        Me.AUDITParametrosABindingSource.DataMember = "AUDIT_ParametrosA"
        Me.AUDITParametrosABindingSource.DataSource = Me.ProductionDataSet
        '
        'AUDIT_ParametrosRTableAdapter
        '
        Me.AUDIT_ParametrosRTableAdapter.ClearBeforeFill = True
        '
        'AUDIT_ParametrosATableAdapter
        '
        Me.AUDIT_ParametrosATableAdapter.ClearBeforeFill = True
        '
        'frmAuditoriaCondiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(895, 498)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(RecomendacionesLabel)
        Me.Controls.Add(Me.RecomendacionesTextBox)
        Me.Controls.Add(ComAreaRespLabel)
        Me.Controls.Add(Me.ComAreaRespTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbEstatus)
        Me.Controls.Add(FechaCompromisoLabel)
        Me.Controls.Add(Me.FechaCompromisoDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbUsuarioResponsable)
        Me.Controls.Add(NomOtrosLabel)
        Me.Controls.Add(Me.NomOtrosTextBox)
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
        CType(Me.AUDIT_AuditoriasCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDocumentosAdjuntos.ResumeLayout(False)
        Me.grbDocumentosAdjuntos.PerformLayout()
        CType(Me.USUARIOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Seguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsoEstatusEnvio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITParametrosABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lklAbrir1 As LinkLabel
    Friend WithEvents lklAbrir3 As LinkLabel
    Friend WithEvents lklAbrir2 As LinkLabel
    Friend WithEvents NomOtrosTextBox As TextBox
    Friend WithEvents cmbUsuarioResponsable As ComboBox
    Friend WithEvents SeguridadBindingSource As BindingSource
    Friend WithEvents Seguridad As Seguridad
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As SeguridadTableAdapters.USUARIOTableAdapter
    Friend WithEvents USUARIOBindingSource1 As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents FechaCompromisoDateTimePicker As DateTimePicker
    Friend WithEvents AUDITEstatusBindingSource As BindingSource
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents AUDIT_ParametrosTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bsoEstatusEnvio As BindingSource
    Friend WithEvents AUDIT_ParametrosAllTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosAllTableAdapter
    Friend WithEvents ComAreaRespTextBox As TextBox
    Friend WithEvents RecomendacionesTextBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents AUDITParametrosRBindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosRTableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosRTableAdapter
    Friend WithEvents AUDITParametrosABindingSource As BindingSource
    Friend WithEvents AUDIT_ParametrosATableAdapter As ProductionDataSetTableAdapters.AUDIT_ParametrosATableAdapter
End Class
