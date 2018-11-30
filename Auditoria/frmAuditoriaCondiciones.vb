Public Class frmAuditoriaCondiciones

    Public var_idAuditoria As Integer
    Public var_idAuditoriaCondiciones As Integer
    Public var_estatusBtnActualizar As Boolean
    Public var_estatusBtnGuardar As Boolean
    Public var_anexoAMC As String
    Public var_consecAMC As String
    Public var_num_celdas As Integer
    Dim taActulizaAudit As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Private Sub frmAuditoriaCondiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_ParametrosV' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosVTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosV)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_ParametrosH' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosHTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosH)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_Condiciones' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_CondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Condiciones)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_AuditoriasCondiciones' Puede moverla o quitarla según sea necesario.
        'Me.AUDIT_AuditoriasCondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones)
        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)

        Id_auditoriaTextBox.Text = var_idAuditoria.ToString
        btnActualizar.Enabled = var_estatusBtnActualizar
        btnGuardar.Enabled = var_estatusBtnGuardar
        If frmAuditoriaMod.cmbEstatus.Text = "CERRADO" Then
            btnActualizar.Enabled = False
            btnGuardar.Enabled = False
        End If
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Dim taExisteCondicion As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        'If taExisteCondicion.ExisteCondicion_ScalarQuery(var_idAuditoria, cmbCondicion.SelectedValue) <> 0 Then
        '    MsgBox("Ya existe esta condición...", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        If cmbHallago.Text = "" Or cmbValidacion.Text = "" Or cmbCondicion.Text = "" Then
            MsgBox("No se ha selaccionado un parametro para hllazgo o validación...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Me.Validate()
        Me.AUDIT_AuditoriasCondicionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

        taActulizaAudit.UpdateFechaActualizacion(Date.Now, var_anexoAMC, var_consecAMC)
        frmAuditoriaMod.var_numeceldas = var_num_celdas
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbHallago.Text = "" Or cmbValidacion.Text = "" Or cmbCondicion.Text = "" Then
            MsgBox("No se ha selaccionado un parametro para hllazgo o validación...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim taExisteCondicion As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        If taExisteCondicion.ExisteCondicion_ScalarQuery(var_idAuditoria, cmbCondicion.SelectedValue) <> 0 Then
            MsgBox("Ya existe esta condición...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            AUDIT_AuditoriasCondicionesTableAdapter.Insert(Id_auditoriaTextBox.Text, cmbCondicion.SelectedValue, cmbValidacion.SelectedValue, ObservacionesTextBox.Text, cmbHallago.SelectedValue, FechaSolventacionDateTimePicker.Value, ComentariosTextBox.Text)
            taActulizaAudit.UpdateFechaActualizacion(Date.Now, var_anexoAMC, var_consecAMC)
            MsgBox("Actualización existosa...", MsgBoxStyle.Information)
            frmAuditoriaMod.bandera = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al actualizar registro...")
        End Try
    End Sub

    Private Sub cmbCondicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCondicion.SelectedIndexChanged

    End Sub
    Private Sub frmAuditoriaCondiciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmAuditoriaMod.Enabled = True
        'frmAuditoriaMod.AUDIT_AuditoriasTableAdapter.ObtAuditConsec_FillBy(Me.ProductionDataSet.AUDIT_Auditorias, var_anexoAMC, var_consecAMC)
        frmAuditoriaMod.bandera = True
        frmAuditoriaMod.frmAuditoriaMod_Load(sender, e)
    End Sub

    Private Sub cmbCondicion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCondicion.SelectedValueChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class