<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaContratos
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
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.lbxContratos = New System.Windows.Forms.ListBox()
        Me.ClientesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.ClientesTableAdapter()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblAnexos = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbClientes
        '
        Me.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClientes.DataSource = Me.ClientesBindingSource
        Me.cmbClientes.DisplayMember = "Descr"
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(12, 32)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(533, 21)
        Me.cmbClientes.TabIndex = 0
        Me.cmbClientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ProductionDataSetBindingSource
        '
        'ProductionDataSetBindingSource
        '
        Me.ProductionDataSetBindingSource.DataSource = Me.ProductionDataSet
        Me.ProductionDataSetBindingSource.Position = 0
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbxContratos
        '
        Me.lbxContratos.FormattingEnabled = True
        Me.lbxContratos.Location = New System.Drawing.Point(551, 32)
        Me.lbxContratos.Name = "lbxContratos"
        Me.lbxContratos.Size = New System.Drawing.Size(168, 173)
        Me.lbxContratos.TabIndex = 1
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(9, 13)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 2
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'lblAnexos
        '
        Me.lblAnexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexos.Location = New System.Drawing.Point(548, 9)
        Me.lblAnexos.Name = "lblAnexos"
        Me.lblAnexos.Size = New System.Drawing.Size(149, 16)
        Me.lblAnexos.TabIndex = 4
        Me.lblAnexos.Text = "Contratos de este cliente"
        Me.lblAnexos.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(644, 211)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmBuscaContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 241)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblAnexos)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.lbxContratos)
        Me.Controls.Add(Me.cmbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscaContratos"
        Me.Text = "Busca Contratos por Nombre"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents lbxContratos As ListBox
    Friend WithEvents ProductionDataSetBindingSource As BindingSource
    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ProductionDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents lblClientes As Label
    Friend WithEvents lblAnexos As Label
    Friend WithEvents btnSalir As Button
End Class
