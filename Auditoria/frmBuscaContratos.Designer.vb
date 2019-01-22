<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscaContratos
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
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Auditoria.ProductionDataSet()
        Me.lbxContratos = New System.Windows.Forms.ListBox()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblAnexos = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New Auditoria.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.lblTipoCredito = New System.Windows.Forms.Label()
        Me.lblTipoDeCredito = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New Auditoria.ProductionDataSetTableAdapters.ClientesTableAdapter()
        Me.Vw_AnexosTableAdapter = New Auditoria.ProductionDataSetTableAdapters.Vw_AnexosTableAdapter()
        Me.Vw_AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkConAuditorias = New System.Windows.Forms.CheckBox()
        Me.chkSinAuditorias = New System.Windows.Forms.CheckBox()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbClientes
        '
        Me.cmbClientes.DataSource = Me.ClientesBindingSource
        Me.cmbClientes.DisplayMember = "Descr"
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(12, 32)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(504, 21)
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
        Me.lbxContratos.Location = New System.Drawing.Point(522, 32)
        Me.lbxContratos.Name = "lbxContratos"
        Me.lbxContratos.Size = New System.Drawing.Size(400, 186)
        Me.lbxContratos.TabIndex = 3
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActifijoTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AnalistasTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasCondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_AuditoriasTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_CondicionesTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_OrgAutorizacionTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosDTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosHTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosTableAdapter = Nothing
        Me.TableAdapterManager.AUDIT_ParametrosVTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auditoria.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblTipoCredito
        '
        Me.lblTipoCredito.AutoSize = True
        Me.lblTipoCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCredito.Location = New System.Drawing.Point(12, 245)
        Me.lblTipoCredito.Name = "lblTipoCredito"
        Me.lblTipoCredito.Size = New System.Drawing.Size(97, 13)
        Me.lblTipoCredito.TabIndex = 6
        Me.lblTipoCredito.Text = "Tipo de crédito:"
        '
        'lblTipoDeCredito
        '
        Me.lblTipoDeCredito.AutoSize = True
        Me.lblTipoDeCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDeCredito.Location = New System.Drawing.Point(112, 245)
        Me.lblTipoDeCredito.Name = "lblTipoDeCredito"
        Me.lblTipoDeCredito.Size = New System.Drawing.Size(0, 13)
        Me.lblTipoDeCredito.TabIndex = 7
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Vw_AnexosTableAdapter
        '
        Me.Vw_AnexosTableAdapter.ClearBeforeFill = True
        '
        'Vw_AnexosBindingSource
        '
        Me.Vw_AnexosBindingSource.DataMember = "Vw_Anexos"
        Me.Vw_AnexosBindingSource.DataSource = Me.ProductionDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Sucursal / Tipo de Crédito / Anexo / Ciclo / No. de Auditorías"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contratos de este cliente"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Selecciona un cliente de la siguiente lista"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(847, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkConAuditorias
        '
        Me.chkConAuditorias.AutoSize = True
        Me.chkConAuditorias.Checked = True
        Me.chkConAuditorias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConAuditorias.Location = New System.Drawing.Point(15, 72)
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
        Me.chkSinAuditorias.Location = New System.Drawing.Point(183, 72)
        Me.chkSinAuditorias.Name = "chkSinAuditorias"
        Me.chkSinAuditorias.Size = New System.Drawing.Size(91, 17)
        Me.chkSinAuditorias.TabIndex = 2
        Me.chkSinAuditorias.Text = "Sin auditorías"
        Me.chkSinAuditorias.UseVisualStyleBackColor = True
        '
        'frmBuscaContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 273)
        Me.Controls.Add(Me.chkSinAuditorias)
        Me.Controls.Add(Me.chkConAuditorias)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTipoDeCredito)
        Me.Controls.Add(Me.lblTipoCredito)
        Me.Controls.Add(Me.lblAnexos)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.lbxContratos)
        Me.Controls.Add(Me.cmbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscaContratos"
        Me.Text = "Buscar Contratos por Nombre"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents lbxContratos As ListBox
    Friend WithEvents ProductionDataSetBindingSource As BindingSource
    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ProductionDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents lblClientes As Label
    Friend WithEvents lblAnexos As Label
    Friend WithEvents Vw_AnexosTableAdapter As ProductionDataSetTableAdapters.Vw_AnexosTableAdapter
    Friend WithEvents Vw_AnexosBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblTipoCredito As Label
    Friend WithEvents lblTipoDeCredito As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkConAuditorias As CheckBox
    Friend WithEvents chkSinAuditorias As CheckBox
End Class
