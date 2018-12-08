Public Class frmAuditoriaCondiciones

    Public var_idAuditoria As Integer
    Public var_idAuditoriaCondiciones As Integer
    Public var_estatusBtnActualizar As Boolean
    Public var_estatusBtnGuardar As Boolean
    Public var_anexoAMC As String
    Public var_consecAMC As String
    Public var_num_celdas As Integer
    Public var_idCondicion As Integer

    Dim taActulizaAudit As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Private Sub frmAuditoriaCondiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_ParametrosD' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosDTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosD)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_AuditoriasCondiciones' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_AuditoriasCondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_ParametrosV' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosVTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosV)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_ParametrosH' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_ParametrosHTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosH)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_Condiciones' Puede moverla o quitarla según sea necesario.
        Me.AUDIT_CondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Condiciones)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_AuditoriasCondiciones' Puede moverla o quitarla según sea necesario.
        'Me.AUDIT_AuditoriasCondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones)
        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idCondicion, var_idAuditoria)
        'MsgBox(AUDIT_AuditoriasCondicionesBindingSource.Current("Id_auditoriaCondicion"))
        Id_auditoriaTextBox.Text = var_idAuditoria.ToString
        btnActualizar.Enabled = var_estatusBtnActualizar
        btnGuardar.Enabled = var_estatusBtnGuardar
        If frmAuditoriaMod.cmbEstatus.Text = "CERRADO" Then
            btnActualizar.Enabled = True
            cmbCondicion.Enabled = False
            cmbHallago.Enabled = False
            cmbValidacion.Enabled = False
            ObservacionesTextBox.Enabled = False
            ComentariosTextBox.Enabled = True
            btnGuardar.Enabled = False
            FechaVigenciaDateTimePicker.Enabled = False
            cmbDeptoResponsable.Enabled = False
        Else
            cmbHallago.Enabled = True
            cmbValidacion.Enabled = True
            cmbDeptoResponsable.Enabled = True
            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Then
                FechaVigenciaDateTimePicker.Enabled = True
            End If
        End If
        If cmbRevisiones.Items.Count = 1 Then
            cmbRevisiones.Enabled = False
        End If
        If cmbValidacion.SelectedValue = 4 Or cmbHallago.SelectedValue = 5 Then
            cmbHallago.Enabled = False
            cmbValidacion.Enabled = False
            ObservacionesTextBox.Enabled = False
            ComentariosTextBox.Enabled = False
            FechaSolventacionDateTimePicker.Enabled = False
            'btnActualizar.Enabled = False
            cmbDeptoResponsable.Enabled = False
        End If
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim taAuditCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        'Dim taExisteCondicion As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        'If taExisteCondicion.ExisteCondicion_ScalarQuery(var_idAuditoria, cmbCondicion.SelectedValue) <> 0 Then
        '    MsgBox("Ya existe esta condición...", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        If cmbHallago.Text = "" Or cmbValidacion.Text = "" Or cmbCondicion.Text = "" Then
            MsgBox("No se ha selaccionado un parametro para hllazgo o validación...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmbValidacion.SelectedValue = 4 Or cmbHallago.SelectedValue = 5 Then
            'taAuditCond.ActualizaEstatus_UpdateQuery(CInt(Id_auditoriaCondicionTextBox.Text))
            AUDIT_AuditoriasCondicionesBindingSource.Current("estatus") = True
            'cmbHallago.Enabled = False
            'cmbValidacion.Enabled = False
            'ObservacionesTextBox.Enabled = False
            'ComentariosTextBox.Enabled = False
            'FechaSolventacionDateTimePicker.Enabled = False
            'btnActualizar.Enabled = False
            'cmbDeptoResponsable.Enabled = False
        End If

        Me.Validate()
        Me.AUDIT_AuditoriasCondicionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

        taActulizaAudit.UpdateFechaActualizacion(Date.Now, var_anexoAMC, var_consecAMC)
        frmAuditoriaMod.var_numeceldas = var_num_celdas

        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idCondicion, var_idAuditoria)
        'Me.Close()
        Me.Update()
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
            If cmbValidacion.SelectedValue = 4 Or cmbHallago.SelectedValue = 5 Then
                AUDIT_AuditoriasCondicionesTableAdapter.Insert(Id_auditoriaTextBox.Text, cmbCondicion.SelectedValue, cmbValidacion.SelectedValue, ObservacionesTextBox.Text, cmbHallago.SelectedValue, FechaSolventacionDateTimePicker.Value, ComentariosTextBox.Text, 1, FechaVigenciaDateTimePicker.Value, cmbDeptoResponsable.SelectedValue, True)
            Else
                AUDIT_AuditoriasCondicionesTableAdapter.Insert(Id_auditoriaTextBox.Text, cmbCondicion.SelectedValue, cmbValidacion.SelectedValue, ObservacionesTextBox.Text, cmbHallago.SelectedValue, FechaSolventacionDateTimePicker.Value, ComentariosTextBox.Text, 1, FechaVigenciaDateTimePicker.Value, cmbDeptoResponsable.SelectedValue, False)
            End If
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

    Private Sub cmbRevisiones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRevisiones.SelectedIndexChanged


        'MsgBox(AUDIT_AuditoriasCondicionesBindingSource.Current("Id_auditoriaCondicion"))


    End Sub

    Private Sub Id_auditoriaCondicionTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_auditoriaCondicionTextBox.TextChanged
        Dim taEstatus As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        If Id_auditoriaCondicionTextBox.Text <> "" Then
            If taEstatus.ObtEstatus_ScalarQuery(CInt(Id_auditoriaCondicionTextBox.Text)) = "True" Then
                cmbHallago.Enabled = False
                cmbValidacion.Enabled = False
                ObservacionesTextBox.Enabled = False
                ComentariosTextBox.Enabled = False
                FechaSolventacionDateTimePicker.Enabled = False
                'btnActualizar.Enabled = False
                cmbDeptoResponsable.Enabled = False
            Else
                If frmAuditoriaMod.cmbEstatus.Text <> "CERRADO" Then
                    cmbHallago.Enabled = True
                    cmbValidacion.Enabled = True
                    ObservacionesTextBox.Enabled = True
                    ComentariosTextBox.Enabled = True
                    'btnActualizar.Enabled = True
                    'cmbDeptoResponsable.Enabled = True
                    If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 39 Then
                        FechaVigenciaDateTimePicker.Enabled = True
                    End If
                End If
            End If
        End If
        Me.Update()
    End Sub
End Class