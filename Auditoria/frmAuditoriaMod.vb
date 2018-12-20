Public Class frmAuditoriaMod
    Public var_anexoAM As String
    Public var_consecAM As String
    Public var_numeceldas As Integer
    Public var_id_auditoria As Integer
    Public var_ciclo As String

    Public bandera As Boolean = False
    Dim dtpFecha As DateTimePicker
    Private Sub AUDIT_AuditoriasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AUDIT_AuditoriasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

    End Sub

    Public Sub frmAuditoriaMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_ParametrosH' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosHTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosH)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_ParametrosV' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosVTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosV)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_Condiciones' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_CondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Condiciones)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_AuditoriasCondiciones' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_AuditoriasCondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_Parametros' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Parametros)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_Auditorias' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_AuditoriasTableAdapter.ObtAuditConsec_FillBy(Me.ProductionDataSet.AUDIT_Auditorias, var_anexoAM.Trim, var_consecAM.Trim, var_ciclo)
        If cmbEstatus.Text = "ABIERTO" Then
            actdes("H")
        ElseIf cmbEstatus.Text = "CERRADO" Then
            actdes("D")
        End If
        'dtpFecha = New DateTimePicker
        'dtpFecha.Format = DateTimePickerFormat.Short
        'dtpFecha.Visible = False
        'dtpFecha.Width = 100
        'DataGridView1.Controls.Add(dtpFecha)

        Dim taDetalleAuditCondiciones As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        Dim Detalle As ProductionDataSet.AUDIT_AuditoriasCondicionesRow

        'taDetalleAuditCondiciones.Obt_AllDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, AUDIT_AuditoriasBindingSource.Current("id_Auditoria"))
        taDetalleAuditCondiciones.Obt_AllDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, var_id_auditoria)

        Dim cont As Integer = 0

        DataGridView1.Rows.Clear()

        For Each Detalle In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
            DataGridView1.Rows.Add()
            If Detalle.ConsecRevisiones <> 1 Then
                DataGridView1.Item(0, cont).Value = AUDIT_CondicionesTableAdapter.ObtCond_ScalarQuery(Detalle.Id_Condicion) + " (" + Detalle.ConsecRevisiones.ToString + ")" 'Detalle.Id_Condicion
            Else
                DataGridView1.Item(0, cont).Value = AUDIT_CondicionesTableAdapter.ObtCond_ScalarQuery(Detalle.Id_Condicion) 'Detalle.Id_Condicion
            End If
            DataGridView1.Item(1, cont).Value = AUDIT_ParametrosVTableAdapter.ObtDesc_ScalarQuery(Detalle.Validacion)  'CInt(Detalle.Validacion)
            DataGridView1.Item(2, cont).Value = AUDIT_ParametrosHTableAdapter.ObtDesc_ScalarQuery(Detalle.CategoriaHallazgo) 'CInt(Detalle.CategoriaHallazgo)
            DataGridView1.Item(3, cont).Value = Detalle.Id_auditoria
            DataGridView1.Item(4, cont).Value = Detalle.Observaciones
            DataGridView1.Item(5, cont).Value = AUDIT_ParametrosVTableAdapter.ObtDescComp_ScalarQuery(Detalle.deptoResponsable)
            DataGridView1.Item(6, cont).Value = Detalle.FechaSolventacion.ToString.Replace("01/01/1900 12:00:00 a. m.", "")
            DataGridView1.Item(7, cont).Value = Detalle.Comentarios
            DataGridView1.Item(8, cont).Value = Detalle.Id_auditoriaCondicion
            DataGridView1.Item(9, cont).Value = Detalle.Id_Condicion
            cont += 1
        Next
        If cont > 0 And cmbEstatus.Text <> "ABIERTO" = True Then
            btnAgregar.Enabled = False
        End If

    End Sub

    Public Sub actdes(parametro As String)
        If parametro = "H" Then
            AnexoTextBox.Enabled = True
            CicloTextBox.Enabled = True
            ObervacionesTextBox.Enabled = True
            cmbEstatus.Enabled = True
            'DataGridView1.Enabled = True
            FechaRelizacionDateTimePicker.Enabled = True
            FolAuditoriaTextBox.Enabled = True
            If bandera <> False Then
                btnAgregar.Enabled = True
            End If
            btnActualizar.Enabled = True
            ElseIf parametro = "D" Then
                AnexoTextBox.Enabled = False
            CicloTextBox.Enabled = False
            ObervacionesTextBox.Enabled = False
            cmbEstatus.Enabled = False
            'DataGridView1.Enabled = False
            btnAgregar.Enabled = False
            btnActualizar.Enabled = False
            FechaRelizacionDateTimePicker.Enabled = False
            FolAuditoriaTextBox.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Dim taActAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter

        'taActAuditorias.UpdateFechaActualizacion(Date.Now, var_anexoAM, var_consecAM)

        Me.AUDIT_AuditoriasBindingSource.Current("UltimaActualizacion") = Date.Now
        Me.AUDIT_AuditoriasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

        'Me.AUDIT_AuditoriasTableAdapter.ObtAuditConsec_FillBy(Me.ProductionDataSet.AUDIT_Auditorias, var_anexoAM, var_consecAM)
        'Me.Update()
        'Call frmAuditoriaMod_Load(sender, e)

        Me.AUDIT_AuditoriasTableAdapter.ObtAuditConsec_FillBy(Me.ProductionDataSet.AUDIT_Auditorias, var_anexoAM, var_consecAM, CicloTextBox.Text)
        If cmbEstatus.Text = "ABIERTO" Then
            actdes("H")
        ElseIf cmbEstatus.Text = "CERRADO" Then
            actdes("D")
        End If
        'frmAuditorias.taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexoAM)
    End Sub

    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        Try
            If DataGridView1.Focused And DataGridView1.CurrentCell.ColumnIndex = 5 Then
                dtpFecha.Location = DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
                dtpFecha.Visible = True
                If DataGridView1.CurrentCell.Value <> DBNull.Value Then
                    dtpFecha.Value = DataGridView1.CurrentCell.Value
                Else
                    dtpFecha.Value = DateTime.Today
                End If
            Else
                dtpFecha.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        'Try
        '    If DataGridView1.Focused And DataGridView1.CurrentCell.ColumnIndex = 5 Then
        '        DataGridView1.CurrentCell.Value = dtpFecha.Value.Date
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs)
        DataGridView1.CurrentCell.Value = dtpFecha.Text

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'DataGridView1.Rows.Add()
        frmAuditoriaCondiciones.var_estatusBtnActualizar = False
        frmAuditoriaCondiciones.var_estatusBtnGuardar = True
        frmAuditoriaCondiciones.var_idAuditoria = AUDIT_AuditoriasBindingSource.Current("id_Auditoria")
        frmAuditoriaCondiciones.var_anexoAMC = var_anexoAM
        frmAuditoriaCondiciones.var_consecAMC = var_consecAM
        frmAuditoriaCondiciones.MdiParent = MDIAuditoria
        frmAuditoriaCondiciones.Show()
        Me.Enabled = False
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        frmAuditoriaCondiciones.var_estatusBtnGuardar = False
        frmAuditoriaCondiciones.var_estatusBtnActualizar = True
        frmAuditoriaCondiciones.var_idAuditoriaCondiciones = DataGridView1.Item(8, e.RowIndex).Value

        If DataGridView1.Item(7, e.RowIndex).Value = Nothing Then
            frmAuditoriaCondiciones.var_idAuditoria = var_id_auditoria 'AUDIT_AuditoriasBindingSource.Current("id_Auditoria")
            frmAuditoriaCondiciones.var_idCondicion = DataGridView1.Item(9, e.RowIndex).Value
            frmAuditoriaCondiciones.MdiParent = MDIAuditoria
            frmAuditoriaCondiciones.Show()
        Else
            frmAuditoriaCondiciones.var_idAuditoria = var_id_auditoria 'AUDIT_AuditoriasBindingSource.Current("id_Auditoria")

            frmAuditoriaCondiciones.var_idCondicion = DataGridView1.Item(9, e.RowIndex).Value
            frmAuditoriaCondiciones.MdiParent = MDIAuditoria
            frmAuditoriaCondiciones.Show()
        End If
        Me.Enabled = False
        'If DataGridView1.Item(8, e.RowIndex).Value = 33 Or DataGridView1.Item(8, e.RowIndex).Value = 37 Or DataGridView1.Item(8, e.RowIndex).Value = 35 Or DataGridView1.Item(8, e.RowIndex).Value = 36 Then
        '    frmAuditoriaCondiciones.RevisionesTextBox.Enabled = True
        'End If
        frmAuditoriaCondiciones.var_anexoAMC = var_anexoAM
        frmAuditoriaCondiciones.var_consecAMC = var_consecAM
        frmAuditoriaCondiciones.var_num_celdas = DataGridView1.Rows.Count
        frmAuditoriaCondiciones.cmbCondicion.Enabled = False
        'frmAuditoriaCondiciones.var_idCondicion = DataGrid

    End Sub


    Private Sub frmAuditoriasMod_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'frmAuditorias.taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexoAM)
        frmAuditorias.Enabled = True
        Call frmAuditorias.frmAuditorias_Load(sender, e)
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class