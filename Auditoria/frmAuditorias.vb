Option Explicit On
Imports System
Imports System.Collections
Imports System.Globalization
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections.Specialized
Imports System.Web
Imports System.Deployment.Application

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
    Public var_montoFinanciado As Decimal
    Public var_montoSolicitado As Decimal
    Public var_fechaSolicitd As Date
    Public var_fechaAutorizacion As Date
    Public var_analista As String
    Public var_organoAutorizacion As String
    Dim myIdentity As Principal.WindowsIdentity
    Dim cUsuario As String

    Public taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Public Sub frmAuditorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AUDIT_OrgAutorizacionTableAdapter.Fill(Me.ProductionDataSet1.AUDIT_OrgAutorizacion)
        Me.AUDIT_AnalistasTableAdapter.Fill(Me.ProductionDataSet1.AUDIT_Analistas)

        Me.AUDIT_ParametrosTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Parametros)
        AnexoTextBox.Text = var_anexo.Trim
        CicloTextBox.Text = var_ciclo.Trim


        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser
        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
        rkTest.Close()
        rkCurrentUser.Close()
        rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
        rkTest.Close()
        rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA", True)
        Dim cadenacon As String
        cadenacon = rkTest.GetValue("FINANCIERA").ToString
        UsuarioTextBox.Text = rkTest.GetValue("Usuario").ToString.Trim
        rkTest.Close()

        ConsecutivoTextBox.Text = (var_consecutivo + 1).ToString
        frmBuscaContratos.Enabled = False
        taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo.Trim, var_ciclo.Trim)

        If ConsecutivoTextBox.Text = "1" Or txtCliente.Text = "" Then
            FechaRelizacionDateTimePicker.Enabled = True
            ObervacionesTextBox.Enabled = True
            txtAuditoria.Enabled = True
            btnAgregar.Enabled = False
            btnGuardar.Enabled = True
            txtCliente.Text = var_cliente
            txtTipoCredito.Text = var_tipoCredito
            txtRecursos.Text = var_recursos
            If var_fechaDispo.Trim <> "" Then
                dtpFechaDispo.Value = DateTime.ParseExact(var_fechaDispo, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None)
            Else
                dtpFechaDispo.Visible = False
            End If
            txtSucursal.Text = var_sucursal
            txtEjecutivo.Text = var_promotor
            txtDestino.Text = var_destino
        Else
            FechaRelizacionDateTimePicker.Enabled = False
            ObervacionesTextBox.ReadOnly = True
            btnAgregar.Enabled = True
            btnGuardar.Enabled = False
            txtAuditoria.ReadOnly = True
            txtDestino.ReadOnly = True
            txtMontoFinanciado.ReadOnly = True
            txtMontoSolicitado.ReadOnly = True
            dtpFechaDispo.Enabled = False
            dtpFechaSolicitud.Enabled = False
            dtpFechaAutorizacion.Enabled = False
            cmbAnalista.Enabled = False
            cmbOrganoDeAutorizacion.Enabled = False
        End If
        formato_moneda()
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
            Me.AUDIT_AuditoriasTableAdapter.Insert(AnexoTextBox.Text.Trim, CicloTextBox.Text.Trim, FechaCreacionDateTimePicker.Value, UltimaActualizacionDateTimePicker.Value, AUDIT_AuditoriasBindingSource.Current("FechaRelizacion"), AUDIT_AuditoriasBindingSource.Current("Obervaciones"), cmbEstatus.Text, UsuarioTextBox.Text, ConsecutivoTextBox.Text, AUDIT_AuditoriasBindingSource.Current("folAuditoria"), AUDIT_AuditoriasBindingSource.Current("nRevInfFinanciera"), AUDIT_AuditoriasBindingSource.Current("nRevRepSup"), AUDIT_AuditoriasBindingSource.Current("nRevPagare"), AUDIT_AuditoriasBindingSource.Current("ncedVerific"), txtCliente.Text.Trim, txtSucursal.Text.Trim, txtTipoCredito.Text.Trim, txtRecursos.Text.Trim, dtpFechaDispo.Value, txtEjecutivo.Text.Trim, txtDestino.Text.Trim, CDec(txtMontoFinanciado.Text), CDec(txtMontoSolicitado.Text), dtpFechaSolicitud.Value, dtpFechaAutorizacion.Value, cmbAnalista.Text, cmbOrganoDeAutorizacion.Text)
            For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                Dim arch1, arch2, arch3 As Byte()
                Dim ex1, ex2, ex3 As String

                If taAuditoriasCond.EsArchivo1_ScalarQuery(DetalleMod.Id_auditoriaCondicion) > 1 Then
                    arch1 = DetalleMod.archivo1
                    ex1 = DetalleMod.ext1
                Else
                    arch1 = {0}
                    ex1 = Nothing
                End If
                If taAuditoriasCond.EsArchivo2_ScalarQuery(DetalleMod.Id_auditoriaCondicion) > 1 Then
                    arch2 = DetalleMod.archivo2
                    ex2 = DetalleMod.ext2
                Else
                    arch2 = {0}
                    ex2 = Nothing
                End If
                If taAuditoriasCond.EsArchivo3_ScalarQuery(DetalleMod.Id_auditoriaCondicion) > 1 Then
                    arch3 = DetalleMod.archivo3
                    ex3 = DetalleMod.ext3
                Else
                    arch3 = {0}
                    ex3 = Nothing
                End If

                taAuditoriasCond.Insert(taAuditorias.UltimoReg_ScalarQuery(var_anexo.Trim, var_ciclo), DetalleMod.Id_Condicion, DetalleMod.Validacion, DetalleMod.Observaciones, DetalleMod.CategoriaHallazgo, System.Data.SqlTypes.SqlDateTime.Null, DetalleMod.Comentarios, DetalleMod.ConsecRevisiones, Date.Now, DetalleMod.deptoResponsable, DetalleMod.estatus, arch1, arch2, arch3, ex1, ex2, ex3, DetalleMod.nomOtros, DetalleMod.usuarioResponsable, DetalleMod.fechaCompromiso, DetalleMod.estatusCond, 37)
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
            Me.AUDIT_AuditoriasTableAdapter.Insert(AnexoTextBox.Text.Trim, CicloTextBox.Text.Trim, FechaCreacionDateTimePicker.Value, UltimaActualizacionDateTimePicker.Value, FechaRelizacionDateTimePicker.Value, ObervacionesTextBox.Text.Trim, cmbEstatus.Text, UsuarioTextBox.Text, ConsecutivoTextBox.Text, txtAuditoria.Text, 1, 1, 1, 1, txtCliente.Text.Trim, txtSucursal.Text.Trim, txtTipoCredito.Text.Trim, txtRecursos.Text.Trim, dtpFechaDispo.Value, txtEjecutivo.Text.Trim, txtDestino.Text.Trim, txtMontoFinanciado.Text, txtMontoSolicitado.Text, dtpFechaSolicitud.Value, dtpFechaAutorizacion.Value, cmbAnalista.Text, cmbOrganoDeAutorizacion.Text)

            For Each DetalleMod In ProductionDataSet.AUDIT_Condiciones.Rows
                taAuditoriasCond.Insert(taAuditorias.UltimoReg_ScalarQuery(var_anexo.Trim, var_ciclo), DetalleMod.id_Condicion, 1, "", 11, System.Data.SqlTypes.SqlDateTime.Null, "", 1, Date.Now, 32, False, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, System.Data.SqlTypes.SqlDateTime.Null, 36, 37)
            Next

            MsgBox("Actualización existosa...", MsgBoxStyle.Information)
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo.Trim, CicloTextBox.Text)
            Me.Update()

            FechaRelizacionDateTimePicker.Enabled = False
            ObervacionesTextBox.Enabled = False
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

    Private Sub btnCopiarAuditoria_Click(sender As Object, e As EventArgs) Handles btnCopiarAuditoria.Click
        Dim taAuditoriasCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
        Dim taAnexos As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter
        Dim EncabezadoMod As ProductionDataSet.AUDIT_AuditoriasRow
        Dim DetalleMod As ProductionDataSet.AUDIT_AuditoriasCondicionesRow
        Dim var_anexo_copiar As String
        var_anexo_copiar = InputBox("Copiar última auditoría del anexo " & var_anexo.Trim & " al ", "Copiar anexo", 0)
        If taAuditorias.ContadorAuditorias(var_anexo_copiar.Trim, var_ciclo.Trim) = 0 Then

            If taAnexos.ObtNumCliente_ScalarQuery(var_anexo.Trim) = taAnexos.ObtNumCliente_ScalarQuery(var_anexo_copiar.Trim) Then
                Try
                    taAuditorias.ObtieneUltimaAuditoriaParCopia_FillBy(ProductionDataSet.AUDIT_Auditorias, var_anexo.Trim)
                    For Each EncabezadoMod In ProductionDataSet.AUDIT_Auditorias.Rows
                        If Not IsNothing(EncabezadoMod.cliente) Then
                            taAuditorias.Insert(var_anexo_copiar.Trim, EncabezadoMod.Ciclo, EncabezadoMod.FechaCreacion, Date.Now, EncabezadoMod.FechaRelizacion, EncabezadoMod.Obervaciones, "ABIERTO", UsuarioTextBox.Text, 1, EncabezadoMod.folAuditoria, 1, 1, 1, 1, EncabezadoMod.cliente, EncabezadoMod.sucursal, EncabezadoMod.tipoCredito, EncabezadoMod.recursos, EncabezadoMod.fechaDisposicion, EncabezadoMod.ejecutivo, EncabezadoMod.destino, EncabezadoMod.montoFinanciado, EncabezadoMod.montoSolicitado, EncabezadoMod.fechaSolicitud, EncabezadoMod.fechaAutorizacion, EncabezadoMod.analista, EncabezadoMod.organoDeAutorizacion)
                        Else
                            taAuditorias.Insert(var_anexo_copiar.Trim, EncabezadoMod.Ciclo, EncabezadoMod.FechaCreacion, Date.Now, EncabezadoMod.FechaRelizacion, EncabezadoMod.Obervaciones, "ABIERTO", UsuarioTextBox.Text, 1, EncabezadoMod.folAuditoria, 1, 1, 1, 1, txtCliente.Text.Trim, txtSucursal.Text.Trim, txtTipoCredito.Text.Trim, txtRecursos.Text.Trim, dtpFechaDispo.Value, txtEjecutivo.Text.Trim, txtDestino.Text.Trim, txtMontoFinanciado.Text.Trim, txtMontoSolicitado.Text.Trim, dtpFechaSolicitud.Value, dtpFechaAutorizacion.Value, cmbAnalista.Text.Trim, cmbOrganoDeAutorizacion.Text.Trim)
                        End If
                    Next

                    taAuditoriasCond.Obt_AllDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, taAuditorias.UltimoReg_ScalarQuery(var_anexo.Trim, var_ciclo.Trim))
                    For Each DetalleMod In ProductionDataSet.AUDIT_AuditoriasCondiciones.Rows
                        Dim arch1, arch2, arch3 As Byte()
                        Dim ex1, ex2, ex3, var_deptoResponsable, var_usuarioResponsable, var_estatusEnv As String

                        If taAuditoriasCond.EsArchivo1_ScalarQuery(DetalleMod.Id_auditoriaCondicion) > 1 Then
                            arch1 = DetalleMod.archivo1
                            ex1 = DetalleMod.ext1
                        Else
                            arch1 = {0}
                            ex1 = Nothing
                        End If
                        If taAuditoriasCond.EsArchivo2_ScalarQuery(DetalleMod.Id_auditoriaCondicion) > 1 Then
                            arch2 = DetalleMod.archivo2
                            ex2 = DetalleMod.ext2
                        Else
                            arch2 = {0}
                            ex2 = Nothing
                        End If
                        If taAuditoriasCond.EsArchivo3_ScalarQuery(DetalleMod.Id_auditoriaCondicion) > 1 Then
                            arch3 = DetalleMod.archivo3
                            ex3 = DetalleMod.ext3
                        Else
                            arch3 = {0}
                            ex3 = Nothing
                        End If

                        If IsNothing(DetalleMod.deptoResponsable) Then
                            var_deptoResponsable = ""
                        Else
                            var_deptoResponsable = DetalleMod.deptoResponsable
                        End If

                        If IsNothing(DetalleMod.usuarioResponsable) Then
                            var_usuarioResponsable = ""
                        Else
                            var_usuarioResponsable = DetalleMod.usuarioResponsable
                        End If

                        If IsNothing(DetalleMod.estatusEnv) Then
                            var_estatusEnv = ""
                        Else
                            var_estatusEnv = DetalleMod.estatusEnv
                        End If

                        taAuditoriasCond.Insert(taAuditorias.UltimoReg_ScalarQuery(var_anexo_copiar.Trim, var_ciclo), DetalleMod.Id_Condicion, DetalleMod.Validacion, DetalleMod.Observaciones, DetalleMod.CategoriaHallazgo, System.Data.SqlTypes.SqlDateTime.Null, DetalleMod.Comentarios, DetalleMod.ConsecRevisiones, Date.Now, var_deptoResponsable, DetalleMod.estatus, arch1, arch2, arch3, ex1, ex2, ex3, Nothing, var_usuarioResponsable, DetalleMod.fechaCompromiso, DetalleMod.estatusCond, var_estatusEnv)
                    Next
                    MsgBox("Copia existosa...", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al copiar registros registro...")
                End Try
            Else
                MsgBox("El cliente del anexo a copiar no corresponde con el anexo destino...", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("El anexo detino ya contiene auditorias...", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub formato_moneda()
        If txtMontoFinanciado.Text <> "" Then
            txtMontoFinanciado.Text = Format(CDec(txtMontoFinanciado.Text), "C")
        End If
        If txtMontoSolicitado.Text <> "" Then
            txtMontoSolicitado.Text = Format(CDec(txtMontoSolicitado.Text), "C")
        End If
    End Sub

    Private Sub txtMontoFinanciado_LostFocus(sender As Object, e As EventArgs) Handles txtMontoFinanciado.LostFocus
        formato_moneda()
    End Sub
    Private Sub txtMontoSolicitado_LostFocus(sender As Object, e As EventArgs) Handles txtMontoSolicitado.LostFocus
        formato_moneda()
    End Sub
End Class