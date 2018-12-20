Imports System.Data.SqlClient
Public Class frmAuditoriaCondiciones

    Public var_idAuditoria As Integer
    Public var_idAuditoriaCondiciones As Integer
    Public var_estatusBtnActualizar As Boolean
    Public var_estatusBtnGuardar As Boolean
    Public var_anexoAMC As String
    Public var_consecAMC As String
    Public var_num_celdas As Integer
    Public var_num_celdasfrm1 As Integer
    Public var_idCondicion As Integer
    Dim var_revisiones As Integer = 0

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
        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)
        'MsgBox(AUDIT_AuditoriasCondicionesBindingSource.Current("Id_auditoriaCondicion"))

        Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
        Dim DetalleMod As ProductionDataSet.AUDIT_AuditoriasCondicionesRow
        Dim taAuditoriasCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter


        Id_auditoriaTextBox.Text = var_idAuditoria.ToString
        btnActualizar.Enabled = var_estatusBtnActualizar
        btnGuardar.Enabled = var_estatusBtnGuardar

        var_num_celdasfrm1 = frmAuditorias.AUDIT_AuditoriasDataGridView.Rows.Count

        Try
            If cmbCondicion.SelectedValue = 33 And var_num_celdasfrm1 = 1 And taAuditorias.ObtnRevInfFinanciera_ScalarQuery(Id_auditoriaTextBox.Text) = 1 Then
                var_revisiones = CInt(InputBox("Ingrese número de revisiones por condición adicionales (por defaul se registra una revisión)", "Revisiones periódicas", 0))
                'taAuditoriasCond.Obt_AllDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, Id_auditoriaTextBox.Text)

                taAuditoriasCond.ObtDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)
                For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                    For i = 1 To var_revisiones
                        taAuditoriasCond.Insert(Id_auditoriaTextBox.Text, DetalleMod.Id_Condicion, DetalleMod.Validacion, DetalleMod.Observaciones, DetalleMod.CategoriaHallazgo, Date.Now, DetalleMod.Comentarios, i + 1, Date.Now, DetalleMod.deptoResponsable, DetalleMod.estatus)
                    Next
                Next
                If var_revisiones = 0 Then
                    taAuditorias.nRevInfFinanciera_UpdateQuery(0, Id_auditoriaTextBox.Text)
                Else
                    taAuditorias.nRevInfFinanciera_UpdateQuery(var_revisiones + 1, Id_auditoriaTextBox.Text)
                End If

            ElseIf cmbCondicion.SelectedValue = 37 And var_num_celdasfrm1 = 1 And taAuditorias.ObtnRevRepSup_ScalarQuery(Id_auditoriaTextBox.Text) = 1 Then
                var_revisiones = CInt(InputBox("Ingrese número de revisiones por condición (por defaul se registra una revisión)", "Revisiones periódicas", 0))

                taAuditoriasCond.ObtDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)
                For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                    For i = 1 To var_revisiones
                        taAuditoriasCond.Insert(Id_auditoriaTextBox.Text, DetalleMod.Id_Condicion, DetalleMod.Validacion, DetalleMod.Observaciones, DetalleMod.CategoriaHallazgo, Date.Now, DetalleMod.Comentarios, i + 1, Date.Now, DetalleMod.deptoResponsable, DetalleMod.estatus)
                    Next
                Next
                If var_revisiones = 0 Then
                    taAuditorias.nRevRepSup_UpdateQuery(0, Id_auditoriaTextBox.Text)
                Else
                    taAuditorias.nRevRepSup_UpdateQuery(var_revisiones + 1, Id_auditoriaTextBox.Text)
                End If

            ElseIf cmbCondicion.SelectedValue = 35 And var_num_celdasfrm1 = 1 And taAuditorias.ObtnRevPagare_ScalarQuery(Id_auditoriaTextBox.Text) = 1 Then
                var_revisiones = CInt(InputBox("Ingrese número de revisiones por condición (por defaul se registra una revisión)", "Revisiones periódicas", 0))

                taAuditoriasCond.ObtDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)
                For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                    For i = 1 To var_revisiones
                        taAuditoriasCond.Insert(Id_auditoriaTextBox.Text, DetalleMod.Id_Condicion, DetalleMod.Validacion, DetalleMod.Observaciones, DetalleMod.CategoriaHallazgo, Date.Now, DetalleMod.Comentarios, i + 1, Date.Now, DetalleMod.deptoResponsable, DetalleMod.estatus)
                    Next
                Next
                If var_revisiones = 0 Then
                    taAuditorias.nRevPagare_UpdateQuery(0, Id_auditoriaTextBox.Text)
                Else
                    taAuditorias.nRevPagare_UpdateQuery(var_revisiones + 1, Id_auditoriaTextBox.Text)
                End If

            ElseIf cmbCondicion.SelectedValue = 36 And var_num_celdasfrm1 = 1 And taAuditorias.ObtncedVerific_ScalarQuery(Id_auditoriaTextBox.Text) = 1 Then
                var_revisiones = CInt(InputBox("Ingrese número de revisiones por condición (por defaul se registra una revisión)", "Revisiones periódicas", 0))

                taAuditoriasCond.ObtDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)
                For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                    For i = 1 To var_revisiones
                        taAuditoriasCond.Insert(Id_auditoriaTextBox.Text, DetalleMod.Id_Condicion, DetalleMod.Validacion, DetalleMod.Observaciones, DetalleMod.CategoriaHallazgo, Date.Now, DetalleMod.Comentarios, i + 1, Date.Now, DetalleMod.deptoResponsable, DetalleMod.estatus)
                    Next
                Next
                If var_revisiones = 0 Then
                    taAuditorias.ncedVerific_UpdateQuery(0, Id_auditoriaTextBox.Text)
                Else
                    taAuditorias.ncedVerific_UpdateQuery(var_revisiones + 1, Id_auditoriaTextBox.Text)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)

        'If frmAuditoriaMod.cmbEstatus.Text = "CERRADO" Then
        '    btnActualizar.Enabled = True
        '    cmbCondicion.Enabled = False
        '    cmbHallago.Enabled = False
        '    cmbValidacion.Enabled = False
        '    ObservacionesTextBox.Enabled = False
        '    ComentariosTextBox.Enabled = True
        '    btnGuardar.Enabled = False
        '    FechaVigenciaDateTimePicker.Enabled = False
        '    cmbDeptoResponsable.Enabled = False
        'Else
        '    cmbHallago.Enabled = True
        '    cmbValidacion.Enabled = True
        '    cmbDeptoResponsable.Enabled = True
        '    If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Or cmbCondicion.SelectedValue = 41 Then
        '        FechaVigenciaDateTimePicker.Enabled = True
        '    End If
        'End If
        If cmbRevisiones.Items.Count = 1 Then
            cmbRevisiones.Enabled = False
        End If

        'If cmbValidacion.SelectedValue = 4 Or cmbHallago.SelectedValue = 5 Then
        '    cmbHallago.Enabled = False
        '    cmbValidacion.Enabled = False
        '    ObservacionesTextBox.Enabled = False
        '    ComentariosTextBox.Enabled = False
        '    FechaSolventacionDateTimePicker.Enabled = False
        '    cmbDeptoResponsable.Enabled = False
        'Else
        '    cmbDeptoResponsable.Enabled = True
        'End If

        If frmAuditoriaMod.cmbEstatus.Text = "CERRADO" Then
            btnActualizar.Enabled = True
            cmbHallago.Enabled = False
            cmbValidacion.Enabled = False
            ObservacionesTextBox.Enabled = False
            ComentariosTextBox.Enabled = True
            btnGuardar.Enabled = False
            FechaVigenciaDateTimePicker.Enabled = False
            cmbDeptoResponsable.Enabled = False
            FechaSolventacionDateTimePicker.Enabled = True
        Else
            btnActualizar.Enabled = True
            cmbHallago.Enabled = True
            cmbValidacion.Enabled = True
            ObservacionesTextBox.Enabled = True
            ComentariosTextBox.Enabled = True
            btnGuardar.Enabled = True
            cmbDeptoResponsable.Enabled = True
            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Or cmbCondicion.SelectedValue = 41 Then
                FechaVigenciaDateTimePicker.Enabled = True
            Else
                FechaVigenciaDateTimePicker.Visible = False
                Label3.Visible = False
            End If
            If cmbHallago.SelectedValue = 5 And cmbValidacion.SelectedValue = 2 Then
                ObservacionesTextBox.Enabled = True
                cmbDeptoResponsable.Enabled = True
                ComentariosTextBox.Enabled = False
                FechaSolventacionDateTimePicker.Enabled = False
            End If
            If cmbValidacion.SelectedValue = 2 And (cmbHallago.SelectedValue = 7 Or cmbHallago.SelectedValue = 6 Or cmbHallago.SelectedValue = 8) Then
                ComentariosTextBox.Enabled = True
                FechaSolventacionDateTimePicker.Enabled = True
                ObservacionesTextBox.Enabled = False
                cmbDeptoResponsable.Enabled = False
            End If
            If cmbValidacion.SelectedValue = 4 Then
                btnActualizar.Enabled = True
                cmbHallago.Enabled = False
                cmbValidacion.Enabled = False
                ObservacionesTextBox.Enabled = True
                ComentariosTextBox.Enabled = False
                btnGuardar.Enabled = False
                FechaVigenciaDateTimePicker.Enabled = False
                cmbDeptoResponsable.Enabled = False
            End If
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
            MsgBox("No se ha selaccionado un parametro para hallazgo o validación...", MsgBoxStyle.Exclamation)
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

        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, Id_auditoriaCondicionTextBox.Text)

        If cmbValidacion.SelectedValue = 4 Then
            btnActualizar.Enabled = True
            cmbHallago.Enabled = False
            cmbValidacion.Enabled = False
            ObservacionesTextBox.Enabled = True
            ComentariosTextBox.Enabled = False
            btnGuardar.Enabled = False
            FechaVigenciaDateTimePicker.Enabled = False
            cmbDeptoResponsable.Enabled = False
        End If

        If frmAuditoriaMod.cmbEstatus.Text = "CERRADO" Then
            btnActualizar.Enabled = True
            cmbHallago.Enabled = False
            cmbValidacion.Enabled = False
            ObservacionesTextBox.Enabled = False
            ComentariosTextBox.Enabled = True
            btnGuardar.Enabled = False
            FechaVigenciaDateTimePicker.Enabled = False
            cmbDeptoResponsable.Enabled = False
            FechaSolventacionDateTimePicker.Enabled = True
        Else
            btnActualizar.Enabled = True
            cmbHallago.Enabled = True
            cmbValidacion.Enabled = True
            ObservacionesTextBox.Enabled = True
            ComentariosTextBox.Enabled = True
            btnGuardar.Enabled = True
            cmbDeptoResponsable.Enabled = True
            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Or cmbCondicion.SelectedValue = 41 Then
                FechaVigenciaDateTimePicker.Enabled = True
            End If
            If cmbHallago.SelectedValue = 5 And cmbValidacion.SelectedValue = 2 Then
                ObservacionesTextBox.Enabled = True
                cmbDeptoResponsable.Enabled = True
                ComentariosTextBox.Enabled = False
                FechaSolventacionDateTimePicker.Enabled = False
            End If
            If cmbValidacion.SelectedValue = 2 And (cmbHallago.SelectedValue = 7 Or cmbHallago.SelectedValue = 6 Or cmbHallago.SelectedValue = 8) Then
                ComentariosTextBox.Enabled = True
                FechaSolventacionDateTimePicker.Enabled = True
                ObservacionesTextBox.Enabled = False
                cmbDeptoResponsable.Enabled = False
            End If
        End If

        'Me.Close()
        Me.Update()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbHallago.Text = "" Or cmbValidacion.Text = "" Or cmbCondicion.Text = "" Then
            MsgBox("No se ha selaccionado un parametro para hallazgo o validación...", MsgBoxStyle.Exclamation)
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
        'Dim taEstatus As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        'If Id_auditoriaCondicionTextBox.Text <> "" Then
        '    If taEstatus.ObtEstatus_ScalarQuery(CInt(Id_auditoriaCondicionTextBox.Text)) = "True" Then
        '        cmbHallago.Enabled = False
        '        cmbValidacion.Enabled = False
        '        ObservacionesTextBox.Enabled = False
        '        ComentariosTextBox.Enabled = False
        '        FechaSolventacionDateTimePicker.Enabled = False
        '        'btnActualizar.Enabled = False
        '        'cmbDeptoResponsable.Enabled = True
        '    Else
        '        If frmAuditoriaMod.cmbEstatus.Text <> "CERRADO" Then
        '            cmbHallago.Enabled = True
        '            cmbValidacion.Enabled = True
        '            ObservacionesTextBox.Enabled = True
        '            ComentariosTextBox.Enabled = True
        '            'btnActualizar.Enabled = True
        '            cmbDeptoResponsable.Enabled = True
        '            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Or cmbCondicion.SelectedValue = 41 Then
        '                FechaVigenciaDateTimePicker.Enabled = True
        '            End If
        '        End If
        '    End If
        'End If
        'Me.Update()
    End Sub

    Private Sub cmbValidacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbValidacion.SelectedIndexChanged

    End Sub

    Private Sub FechaVigenciaLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class