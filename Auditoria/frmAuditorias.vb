Public Class frmAuditorias
    Public var_anexo As String
    Public var_ciclo As String
    Public var_consecutivo As Integer
    Public taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Public Sub frmAuditorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.AUDIT_AuditoriasCondiciones' Puede moverla o quitarla según sea necesario.
        'Me.AUDIT_AuditoriasCondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet1.AUDIT_Parametros' Puede moverla o quitarla según sea necesario.

        Me.AUDIT_ParametrosTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Parametros)

        AnexoTextBox.Text = var_anexo
        CicloTextBox.Text = var_ciclo
        ConsecutivoTextBox.Text = (var_consecutivo + 1).ToString

        frmBuscaContratos.Enabled = False

        taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo)

        If ConsecutivoTextBox.Text = "1" Then
            FechaRelizacionDateTimePicker.Enabled = True
            ObervacionesTextBox.Enabled = True
            btnAgregar.Enabled = False
            btnGuardar.Enabled = True
        Else
            FechaRelizacionDateTimePicker.Enabled = False
            ObervacionesTextBox.Enabled = False
            btnAgregar.Enabled = True
            btnGuardar.Enabled = False
        End If

    End Sub

    Private Sub AUDIT_AuditoriasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AUDIT_AuditoriasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim taAuditoriasCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
        Dim DetalleMod As ProductionDataSet.AUDIT_AuditoriasCondicionesRow

        If taAuditorias.ObtieneEstatus_ScalarQuery(var_anexo) = "ABIERTO" Then
            MsgBox("Existe una auditoria con estatus " + taAuditorias.ObtieneEstatus_ScalarQuery(var_anexo) + "...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ConsecutivoTextBox.Text = (var_consecutivo + 1).ToString
        FechaCreacionDateTimePicker.Value = Date.Now
        btnGuardar.Enabled = True
        FechaRelizacionDateTimePicker.Enabled = True
        ObervacionesTextBox.Enabled = True
        btnAgregar.Enabled = False

        Try
            taAuditoriasCond.Obt_AllDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, taAuditorias.UltimoReg_ScalarQuery(var_anexo))
            Me.AUDIT_AuditoriasTableAdapter.Insert(AnexoTextBox.Text.Trim, CicloTextBox.Text.Trim, FechaCreacionDateTimePicker.Value, UltimaActualizacionDateTimePicker.Value, FechaRelizacionDateTimePicker.Value, ObervacionesTextBox.Text.Trim, cmbEstatus.Text, UsuarioTextBox.Text, ConsecutivoTextBox.Text)
            For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                taAuditoriasCond.Insert(taAuditorias.UltimoReg_ScalarQuery(var_anexo), DetalleMod.Id_Condicion, DetalleMod.Validacion, "", DetalleMod.CategoriaHallazgo, Date.Now, "")
            Next
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo)
            MsgBox("Se agregó una nueva auditoría...", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al actualizar registro...")
        End Try
    End Sub

    Private Sub frmAuditorias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmBuscaContratos.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Me.AUDIT_AuditoriasTableAdapter.Insert(AnexoTextBox.Text.Trim, CicloTextBox.Text.Trim, FechaCreacionDateTimePicker.Value, UltimaActualizacionDateTimePicker.Value, FechaRelizacionDateTimePicker.Value, ObervacionesTextBox.Text.Trim, cmbEstatus.Text, UsuarioTextBox.Text, ConsecutivoTextBox.Text)
            MsgBox("Actualización existosa...", MsgBoxStyle.Information)
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo)
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

        frmAuditoriaMod.var_anexoAM = var_anexo
        frmAuditoriaMod.var_consecAM = AUDIT_AuditoriasDataGridView.Item(0, e.RowIndex).Value
        frmAuditoriaMod.MdiParent = MDIAuditoria
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
End Class