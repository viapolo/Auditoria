<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscaContratosSuc
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
        Me.cmbSucursales = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet1 = New Auditoria.ProductionDataSet()
        Me.lbxContratos = New System.Windows.Forms.ListBox()
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.VwAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.SucursalesTableAdapter()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblAnexos = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkConAuditorias = New System.Windows.Forms.CheckBox()
        Me.chkSinAuditorias = New System.Windows.Forms.CheckBox()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSucursales
        '
        Me.cmbSucursales.DataSource = Me.SucursalesBindingSource
        Me.cmbSucursales.DisplayMember = "Nombre_Sucursal"
        Me.cmbSucursales.FormattingEnabled = True
        Me.cmbSucursales.Location = New System.Drawing.Point(15, 43)
        Me.cmbSucursales.Name = "cmbSucursales"
        Me.cmbSucursales.Size = New System.Drawing.Size(340, 21)
        Me.cmbSucursales.TabIndex = 0
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.ProductionDataSet1
        '
        'ProductionDataSet1
        '
        Me.ProductionDataSet1.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbxContratos
        '
        Me.lbxContratos.FormattingEnabled = True
        Me.lbxContratos.Location = New System.Drawing.Point(361, 43)
        Me.lbxContratos.Name = "lbxContratos"
        Me.lbxContratos.Size = New System.Drawing.Size(402, 186)
        Me.lbxContratos.TabIndex = 3
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwAnexosBindingSource
        '
        Me.VwAnexosBindingSource.DataMember = "Vw_Anexos"
        Me.VwAnexosBindingSource.DataSource = Me.ProductionDataSet
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(12, 19)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(328, 16)
        Me.lblClientes.TabIndex = 3
        Me.lblClientes.Text = "Selecciona una sucursal de la siguiente Lista"
        '
        'lblAnexos
        '
        Me.lblAnexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexos.Location = New System.Drawing.Point(358, 19)
        Me.lblAnexos.Name = "lblAnexos"
        Me.lblAnexos.Size = New System.Drawing.Size(197, 16)
        Me.lblAnexos.TabIndex = 5
        Me.lblAnexos.Text = "Contratos de esta sucursal"
        Me.lblAnexos.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(688, 248)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente:"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(69, 246)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreCliente.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(358, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sucursal / Tipo de Crédito / Anexo / Ciclo / No. de Auditorías"
        '
        'chkConAuditorias
        '
        Me.chkConAuditorias.AutoSize = True
        Me.chkConAuditorias.Checked = True
        Me.chkConAuditorias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConAuditorias.Location = New System.Drawing.Point(17, 79)
        Me.chkConAuditorias.Name = "chkConAuditorias"
        Me.chkConAuditorias.Size = New System.Drawing.Size(95, 17)
        Me.chkConAuditorias.TabIndex = 1
        Me.chkConAuditorias.Text = "Con auditorías"
        Me.chkConAuditorias.UseVisualStyleBackColor = True
        '
        'chkSinAuditorias
        '
        Me.chkSinAuditorias.AutoSize = True
        Me.chkSinAuditorias.Checked = True
        Me.chkSinAuditorias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSinAuditorias.Location = New System.Drawing.Point(206, 79)
        Me.chkSinAuditorias.Name = "chkSinAuditorias"
        Me.chkSinAuditorias.Size = New System.Drawing.Size(91, 17)
        Me.chkSinAuditorias.TabIndex = 2
        Me.chkSinAuditorias.Text = "Sin auditorías"
        Me.chkSinAuditorias.UseVisualStyleBackColor = True
        '
        'frmBuscaContratosSuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 278)
        Me.Controls.Add(Me.chkSinAuditorias)
        Me.Controls.Add(Me.chkConAuditorias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblAnexos)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.lbxContratos)
        Me.Controls.Add(Me.cmbSucursales)
        Me.Name = "frmBuscaContratosSuc"
        Me.Text = "Buscar Contratos por Sucursal"
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbSucursales As ComboBox
    Friend WithEvents lbxContratos As ListBox
    Friend WithEvents VwAnexosBindingSource As BindingSource
    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ProductionDataSet1 As ProductionDataSet
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents SucursalesTableAdapter As ProductionDataSetTableAdapters.SucursalesTableAdapter
    Friend WithEvents lblClientes As Label
    Friend WithEvents lblAnexos As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkConAuditorias As CheckBox
    Friend WithEvents chkSinAuditorias As CheckBox
End Class
