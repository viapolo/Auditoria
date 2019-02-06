Public Class frmAuditoriaMod
    Public var_anexoAM As String
    Public var_consecAM As String
    Public var_numeceldas As Integer
    Public var_id_auditoria As Integer
    Public var_ciclo As String

    Public bandera As Boolean = False
    Dim dtpFecha As DateTimePicker

    Public Sub frmAuditoriaMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AUDIT_ParametrosHTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosH)
        Me.AUDIT_ParametrosVTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosV)
        Me.AUDIT_CondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Condiciones)
        Me.AUDIT_ParametrosTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Parametros)
        Me.AUDIT_AuditoriasTableAdapter.ObtAuditConsec_FillBy(Me.ProductionDataSet.AUDIT_Auditorias, var_anexoAM.Trim, var_consecAM.Trim, var_ciclo)
        If cmbEstatus.Text = "ABIERTO" Then
            actdes("H")
        ElseIf cmbEstatus.Text = "CERRADO" Then
            actdes("D")
        End If

        Dim taDetalleAuditCondiciones As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        Dim Detalle As ProductionDataSet.AUDIT_AuditoriasCondicionesRow

        taDetalleAuditCondiciones.Obt_AllDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, var_id_auditoria)
        Dim cont As Integer = 0
        DataGridView1.Rows.Clear()

        For Each Detalle In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
            DataGridView1.Rows.Add()
            If Detalle.ConsecRevisiones <> 1 Then
                DataGridView1.Item(0, cont).Value = AUDIT_CondicionesTableAdapter.ObtCond_ScalarQuery(Detalle.Id_Condicion) + " (" + Detalle.ConsecRevisiones.ToString + ")" 'Detalle.Id_Condicion
                If cmbEstatus.Text = "ABIERTO" Then
                    DataGridView1.Item(10, cont).Value = "Eliminar"
                End If
            Else
                DataGridView1.Item(0, cont).Value = AUDIT_CondicionesTableAdapter.ObtCond_ScalarQuery(Detalle.Id_Condicion)
            End If
            DataGridView1.Item(1, cont).Value = AUDIT_ParametrosVTableAdapter.ObtDesc_ScalarQuery(Detalle.Validacion)
            DataGridView1.Item(2, cont).Value = AUDIT_ParametrosHTableAdapter.ObtDesc_ScalarQuery(Detalle.CategoriaHallazgo)
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
            FechaRelizacionDateTimePicker.Enabled = True
            FolAuditoriaTextBox.Enabled = True
            If bandera <> False Then
                btnAgregar.Enabled = True
            End If
            btnActualizar.Enabled = True

            FechaRelizacionDateTimePicker.Enabled = False
            btnAgregar.Enabled = True

            ClienteTextBox.Enabled = True
            SucursalTextBox.Enabled = True
            TipoCreditoTextBox.Enabled = True
            RecursosTextBox.Enabled = True
            FechaDisposicionDateTimePicker.Enabled = True
            EjecutivoTextBox.Enabled = True
            DestinoTextBox.Enabled = True
            AnalistaTextBox.Enabled = True
            MontoSolicitadoTextBox.Enabled = True
            MontoFinanciadoTextBox.Enabled = True
            FechaSolicitudDateTimePicker.Enabled = True
            FechaAutorizacionDateTimePicker.Enabled = True
            OrganoDeAutorizacionTextBox.Enabled = True
        ElseIf parametro = "D" Then
            AnexoTextBox.Enabled = False
            CicloTextBox.Enabled = False
            ObervacionesTextBox.Enabled = False
            cmbEstatus.Enabled = False
            btnAgregar.Enabled = False
            btnActualizar.Enabled = False
            FechaRelizacionDateTimePicker.Enabled = False
            FolAuditoriaTextBox.Enabled = False

            ClienteTextBox.Enabled = False
            SucursalTextBox.Enabled = False
            TipoCreditoTextBox.Enabled = False
            RecursosTextBox.Enabled = False
            FechaDisposicionDateTimePicker.Enabled = False
            EjecutivoTextBox.Enabled = False
            DestinoTextBox.Enabled = False
            AnalistaTextBox.Enabled = False
            MontoSolicitadoTextBox.Enabled = False
            MontoFinanciadoTextBox.Enabled = False
            FechaSolicitudDateTimePicker.Enabled = False
            FechaAutorizacionDateTimePicker.Enabled = False
            OrganoDeAutorizacionTextBox.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Me.AUDIT_AuditoriasBindingSource.Current("UltimaActualizacion") = Date.Now
        Me.AUDIT_AuditoriasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

        Me.AUDIT_AuditoriasTableAdapter.ObtAuditConsec_FillBy(Me.ProductionDataSet.AUDIT_Auditorias, var_anexoAM, var_consecAM, CicloTextBox.Text)
        If cmbEstatus.Text = "ABIERTO" Then
            actdes("H")
        ElseIf cmbEstatus.Text = "CERRADO" Then
            actdes("D")
        End If
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

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs)
        DataGridView1.CurrentCell.Value = dtpFecha.Text
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
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
        If e.ColumnIndex < 10 Then
            If DataGridView1.Item(7, e.RowIndex).Value = Nothing Then
                frmAuditoriaCondiciones.var_idAuditoria = var_id_auditoria
                frmAuditoriaCondiciones.var_idCondicion = DataGridView1.Item(9, e.RowIndex).Value
                frmAuditoriaCondiciones.MdiParent = MDIAuditoria
                frmAuditoriaCondiciones.Show()
            Else
                frmAuditoriaCondiciones.var_idAuditoria = var_id_auditoria

                frmAuditoriaCondiciones.var_idCondicion = DataGridView1.Item(9, e.RowIndex).Value
                frmAuditoriaCondiciones.MdiParent = MDIAuditoria
                frmAuditoriaCondiciones.Show()
            End If
            Me.Enabled = False

            frmAuditoriaCondiciones.var_anexoAMC = var_anexoAM
            frmAuditoriaCondiciones.var_consecAMC = var_consecAM
            frmAuditoriaCondiciones.var_num_celdas = DataGridView1.Rows.Count
            frmAuditoriaCondiciones.cmbCondicion.Enabled = False
        ElseIf DataGridView1.Item("eliminar", e.RowIndex).Value = "Eliminar" And e.ColumnIndex = 10 And cmbEstatus.Text = "ABIERTO" Then
            If MsgBox("Eliminar condición, ¿Deséa eliminar el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                AUDIT_AuditoriasCondicionesTableAdapter.ElimCond_DeleteQuery(DataGridView1.Item(8, e.RowIndex).Value)
                frmAuditoriaMod_Load(sender, e)
            Else
                MsgBox("Proceso cancelado...", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub frmAuditoriasMod_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmAuditorias.Enabled = True
        Call frmAuditorias.frmAuditorias_Load(sender, e)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class