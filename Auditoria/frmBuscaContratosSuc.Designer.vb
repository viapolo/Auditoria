<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaContratosSuc
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
        Me.cmbSucursales.Location = New System.Drawing.Point(15, 38)
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
        Me.lbxContratos.Location = New System.Drawing.Point(405, 43)
        Me.lbxContratos.Name = "lbxContratos"
        Me.lbxContratos.Size = New System.Drawing.Size(358, 186)
        Me.lbxContratos.TabIndex = 1
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
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 3
        Me.lblClientes.Text = "Selecciona una sucursal de la siguiente Lista"
        '
        'lblAnexos
        '
        Me.lblAnexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexos.Location = New System.Drawing.Point(402, 19)
        Me.lblAnexos.Name = "lblAnexos"
        Me.lblAnexos.Size = New System.Drawing.Size(149, 16)
        Me.lblAnexos.TabIndex = 5
        Me.lblAnexos.Text = "Contratos de esta sucursal"
        Me.lblAnexos.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(688, 236)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
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
        'frmBuscaContratosSuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 271)
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
End Class
