Imports System
Imports System.Collections
Imports System.Globalization


Public Class frmAuditorias
    Public var_anexo As String
    Public var_ciclo As String
    Public var_consecutivo As Integer
    Public var_cliente As String

    Public var_tipoCredito As String
    Public var_sucursal As String
    Public var_recursos As String
    Public var_fechaDispo As String 
    Public var_promotor As String
    Public var_destino As String


    Public taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Public Sub frmAuditorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCliente.Text = var_cliente
        txtTipoCredito.Text = var_tipoCredito
        txtRecursos.Text = var_recursos
        If var_fechaDispo.Trim <> "" Then
            dtpFechaDispo.Value = DateTime.ParseExact(var_fechaDispo, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None)
        Else
            dtpFechaDispo.Visible = False
        End If
        txtEjecutivo.Text = var_promotor
        txtDestino.Text = var_destino

        Me.AUDIT_ParametrosTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Parametros)
        AnexoTextBox.Text = var_anexo.Trim
        CicloTextBox.Text = var_ciclo.Trim
        ConsecutivoTextBox.Text = (var_consecutivo + 1).ToString
        frmBuscaContratos.Enabled = False
        taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo.Trim, var_ciclo.Trim)

        If ConsecutivoTextBox.Text = "1" Then
            FechaRelizacionDateTimePicker.Enabled = True
            ObervacionesTextBox.Enabled = True
            txtAuditoria.Enabled = True
            btnAgregar.Enabled = False
            btnGuardar.Enabled = True
        Else
            FechaRelizacionDateTimePicker.Enabled = False
            ObervacionesTextBox.Enabled = False
            btnAgregar.Enabled = True
            btnGuardar.Enabled = False
            txtAuditoria.Enabled = False
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim taAuditoriasCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
        Dim DetalleMod As ProductionDataSet.AUDIT_AuditoriasCondicionesRow

        If taAuditorias.ObtieneEstatus_ScalarQuery(var_anexo.Trim, var_ciclo) = "ABIERTO" Then
            MsgBox("Existe una auditoria con estatus " + taAuditorias.ObtieneEstatus_ScalarQuery(var_anexo.Trim, var_ciclo) + "...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ConsecutivoTextBox.Text = (var_consecutivo + 1).ToString
        FechaCreacionDateTimePicker.Value = Date.Now
        btnGuardar.Enabled = True
        FechaRelizacionDateTimePicker.Enabled = True
        ObervacionesTextBox.Enabled = True
        btnAgregar.Enabled = False

        Try
            taAuditoriasCond.Obt_AllDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, taAuditorias.UltimoReg_ScalarQuery(var_anexo.Trim, var_ciclo.Trim))
            Me.AUDIT_AuditoriasTableAdapter.Insert(AnexoTextBox.Text.Trim, CicloTextBox.Text.Trim, FechaCreacionDateTimePicker.Value, UltimaActualizacionDateTimePicker.Value, AUDIT_AuditoriasBindingSource.Current("FechaRelizacion"), AUDIT_AuditoriasBindingSource.Current("Obervaciones"), cmbEstatus.Text, UsuarioTextBox.Text, ConsecutivoTextBox.Text, AUDIT_AuditoriasBindingSource.Current("folAuditoria"), AUDIT_AuditoriasBindingSource.Current("nRevInfFinanciera"), AUDIT_AuditoriasBindingSource.Current("nRevRepSup"), AUDIT_AuditoriasBindingSource.Current("nRevPagare"), AUDIT_AuditoriasBindingSource.Current("ncedVerific"), txtCliente.Text.Trim, txtSucursal.Text.Trim, txtTipoCredito.Text.Trim, + _
                                                   txtRecursos.Text.Trim, dtpFechaDispo.Value, txtEjecutivo.Text.Trim, txtDestino.Text.Trim, CDec(txtMontoFinanciado.Text), + _
                                                   CDec(txtMontoSolicitado.Text), dtpFechaSolicitud.Value, dtpFechaAutorizacion.Value, cmbAnalista.Text, cmbOrganoDeAutorizacion.Text)
            For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                taAuditoriasCond.Insert(taAuditorias.UltimoReg_ScalarQuery(var_anexo.Trim, var_ciclo), DetalleMod.Id_Condicion, DetalleMod.Validacion, DetalleMod.Observaciones, DetalleMod.CategoriaHallazgo, System.Data.SqlTypes.SqlDateTime.Null, DetalleMod.Comentarios, DetalleMod.ConsecRevisiones, Date.Now, DetalleMod.deptoResponsable, DetalleMod.estatus)
            Next
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo.Trim, var_ciclo.Trim)
            MsgBox("Se agregó una nueva auditoría...", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al actualizar registro...")
        End Try
    End Sub

    Private Sub frmAuditorias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If frmBuscaContratos.Enabled = False Then
            frmBuscaContratos.Enabled = True
        End If
        If frmBuscaContratosSuc.Enabled = False Then
            frmBuscaContratosSuc.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim DetalleMod As ProductionDataSet.AUDIT_CondicionesRow
        Dim taAudt As New ProductionDataSetTableAdapters.AUDIT_CondicionesTableAdapter
        Dim taAuditoriasCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter

        If taAuditorias.ObtieneEstatus_ScalarQuery(var_anexo.Trim, var_ciclo) = "ABIERTO" Then
            MsgBox("Existe una auditoria con estatus " + taAuditorias.ObtieneEstatus_ScalarQuery(var_anexo.Trim, var_ciclo) + "...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        taAudt.Fill(ProductionDataSet.AUDIT_Condiciones)
        Try
            Me.AUDIT_AuditoriasTableAdapter.Insert(AnexoTextBox.Text.Trim, CicloTextBox.Text.Trim, FechaCreacionDateTimePicker.Value, UltimaActualizacionDateTimePicker.Value, FechaRelizacionDateTimePicker.Value, + _
                                                   ObervacionesTextBox.Text.Trim, cmbEstatus.Text, UsuarioTextBox.Text, + _
                                                   ConsecutivoTextBox.Text, txtAuditoria.Text, 1, 1, 1, 1, txtCliente.Text.Trim, txtSucursal.Text.Trim, txtTipoCredito.Text.Trim, + _
                                                   txtRecursos.Text.Trim, dtpFechaDispo.Value, txtEjecutivo.Text.Trim, txtDestino.Text.Trim, CDec(txtMontoFinanciado.Text), + _
                                                   CDec(txtMontoSolicitado.Text), dtpFechaSolicitud.Value, dtpFechaAutorizacion.Value, cmbAnalista.Text, cmbOrganoDeAutorizacion.Text)
            For Each DetalleMod In ProductionDataSet.AUDIT_Condiciones.Rows
                taAuditoriasCond.Insert(taAuditorias.UltimoReg_ScalarQuery(var_anexo.Trim, var_ciclo), DetalleMod.id_Condicion, 1, "", 11, System.Data.SqlTypes.SqlDateTime.Null, "", 1, Date.Now, 32, False)
            Next

            MsgBox("Actualización existosa...", MsgBoxStyle.Information)
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo.Trim, CicloTextBox.Text)
            Me.Update()

            FechaRelizacionDateTimePicker.Enabled = False
            ObervacionesTextBox.Enabled = False
            btnAgregar.Enabled = False
            btnAgregar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al actualizar registro...")
        End Try
    End Sub


    Private Sub ObtEstatus_FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.AUDIT_ParametrosTableAdapter.ObtEstatus_FillBy(Me.ProductionDataSet.AUDIT_Parametros)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ObtEstatus_FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.AUDIT_ParametrosTableAdapter.ObtEstatus_FillBy(Me.ProductionDataSet.AUDIT_Parametros)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AUDIT_AuditoriasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AUDIT_AuditoriasDataGridView.CellContentClick

        frmAuditoriaMod.var_id_auditoria = AUDIT_AuditoriasBindingSource.Current("id_Auditoria")
        frmAuditoriaMod.var_anexoAM = var_anexo.Trim
        frmAuditoriaMod.var_consecAM = AUDIT_AuditoriasDataGridView.Item(0, e.RowIndex).Value
        frmAuditoriaMod.var_ciclo = var_ciclo
        frmAuditoriaMod.MdiParent = MDIAuditoria
        frmAuditoriaCondiciones.var_num_celdasfrm1 = AUDIT_AuditoriasDataGridView.Rows.Count
        frmAuditoriaMod.Show()
        If AUDIT_AuditoriasDataGridView.Rows.Count > 1 Then
            frmAuditoriaMod.btnAgregar.Enabled = False
        ElseIf AUDIT_AuditoriasDataGridView.Rows.Count = 1 And cmbEstatus.Text <> "ABIERTO" Then
            frmAuditoriaMod.btnAgregar.Enabled = True
        End If
        Me.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class