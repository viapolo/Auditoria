Imports System.Data.SqlClient
Imports System.IO
Imports System
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
    Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
    Dim taAuditoriasCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
    Private Sub frmAuditoriaCondiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AUDIT_ParametrosDTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosD)
        Me.AUDIT_ParametrosVTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosV)
        Me.AUDIT_ParametrosHTableAdapter.Fill(Me.ProductionDataSet.AUDIT_ParametrosH)
        Me.AUDIT_CondicionesTableAdapter.Fill(Me.ProductionDataSet.AUDIT_Condiciones)
        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)

        Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
        Dim DetalleMod As ProductionDataSet.AUDIT_AuditoriasCondicionesRow
        Dim taAuditoriasCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter

        Id_auditoriaTextBox.Text = var_idAuditoria.ToString
        btnActualizar.Enabled = var_estatusBtnActualizar
        btnGuardar.Enabled = var_estatusBtnGuardar

        var_num_celdasfrm1 = frmAuditorias.AUDIT_AuditoriasDataGridView.Rows.Count

        Me.AUDIT_AuditoriasCondicionesTableAdapter.ObtDetalleAuditCond_FillBy(Me.ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)

        If cmbRevisiones.Items.Count = 1 Then
            cmbRevisiones.Enabled = False
        End If

        If frmAuditoriaMod.cmbEstatus.Text = "ABIERTO" Then
            btnActualizar.Enabled = True
            cmbHallago.Enabled = True
            cmbValidacion.Enabled = True
            ObservacionesTextBox.Enabled = True
            ComentariosTextBox.Enabled = True
            btnGuardar.Enabled = True
            FechaVigenciaDateTimePicker.Enabled = True
            cmbDeptoResponsable.Enabled = True
            FechaSolventacionDateTimePicker.Enabled = True

            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Then
                FechaVigenciaDateTimePicker.Visible = True
                Label3.Visible = True
            Else
                FechaVigenciaDateTimePicker.Visible = False
                Label3.Visible = False
            End If
            If taAuditoriasCond.EsArchivo1_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir1.Visible = True
            End If
            If taAuditoriasCond.EsArchivo2_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir2.Visible = True
            End If
            If taAuditoriasCond.EsArchivo3_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir3.Visible = True
            End If
        Else
            If taAuditoriasCond.EsArchivo1_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir1.Visible = True
            End If
            If taAuditoriasCond.EsArchivo2_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir2.Visible = True
            End If
            If taAuditoriasCond.EsArchivo3_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir3.Visible = True
            End If
            btnArchivo1.Enabled = False
            btnArchivo2.Enabled = False
            btnArchivo3.Enabled = False
            cmbDeptoResponsable.Enabled = False
            btnAgregarRev.Enabled = False
            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Then
                FechaVigenciaDateTimePicker.Visible = True
                Label3.Visible = True
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
        If cmbCondicion.SelectedValue = 44 And frmAuditoriaMod.cmbEstatus.Text = "ABIERTO" Then
            NomOtrosTextBox.Enabled = True
        End If
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim taAuditCond As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        If cmbHallago.Text = "" Or cmbValidacion.Text = "" Or cmbCondicion.Text = "" Then
            MsgBox("No se ha selaccionado un parametro para hallazgo o validación...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmbValidacion.SelectedValue = 4 Or cmbHallago.SelectedValue = 5 Then
            AUDIT_AuditoriasCondicionesBindingSource.Current("estatus") = True
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

        If frmAuditoriaMod.cmbEstatus.Text = "ABIERTO" Then
            btnActualizar.Enabled = True
            cmbHallago.Enabled = True
            cmbValidacion.Enabled = True
            ObservacionesTextBox.Enabled = True
            ComentariosTextBox.Enabled = True
            btnGuardar.Enabled = True
            FechaVigenciaDateTimePicker.Enabled = True
            cmbDeptoResponsable.Enabled = True
            FechaSolventacionDateTimePicker.Enabled = True

            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Then
                FechaVigenciaDateTimePicker.Visible = True
                Label3.Visible = True
            Else
                FechaVigenciaDateTimePicker.Visible = False
                Label3.Visible = False
            End If
            If taAuditoriasCond.EsArchivo1_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir1.Visible = True
            End If
            If taAuditoriasCond.EsArchivo2_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir2.Visible = True
            End If
            If taAuditoriasCond.EsArchivo3_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir3.Visible = True
            End If
        Else
            If taAuditoriasCond.EsArchivo1_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir1.Visible = True
            End If
            If taAuditoriasCond.EsArchivo2_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir2.Visible = True
            End If
            If taAuditoriasCond.EsArchivo3_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) > 1 Then
                lklAbrir3.Visible = True
            End If
            btnAgregarRev.Enabled = False
            cmbDeptoResponsable.Enabled = False
            If cmbCondicion.SelectedValue = 39 Or cmbCondicion.SelectedValue = 40 Then
                FechaVigenciaDateTimePicker.Visible = True
                Label3.Visible = True
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
        End If
        Me.Update()
    End Sub

    Private Sub frmAuditoriaCondiciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmAuditoriaMod.Enabled = True
        frmAuditoriaMod.bandera = True
        frmAuditoriaMod.frmAuditoriaMod_Load(sender, e)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarRev_Click(sender As Object, e As EventArgs) Handles btnAgregarRev.Click
        var_revisiones = CInt(InputBox("Ingrese número de revisiones adicionales", "Revisiones periódicas", 0))

        taAuditoriasCond.ObtDetalleAuditCond_FillBy(ProductionDataSet.AUDIT_AuditoriasCondiciones, var_idAuditoriaCondiciones)
        Dim var_ini As Integer = taAuditoriasCond.CuentaRegistros_ScalarQuery(CInt(Id_auditoriaTextBox.Text), CInt(cmbCondicion.SelectedValue))
        For i = var_ini To var_ini + var_revisiones - 1
            taAuditoriasCond.Insert(Id_auditoriaTextBox.Text, CInt(cmbCondicion.SelectedValue), 1, "", 11, System.Data.SqlTypes.SqlDateTime.Null, "", i + 1, Date.Now, 32, False, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Next
    End Sub

    Private Sub btnArchivo1_Click(sender As Object, e As EventArgs) Handles btnArchivo1.Click
        Try
            Me.btnActualizar_Click(sender, e)
            If AUDIT_AuditoriasCondicionesTableAdapter.EsArchivo1_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) <= 1 Then
                If pfdCargarArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim archivo1 As Byte() = File.ReadAllBytes(pfdCargarArchivos.FileName)
                    Dim arch_files As FileStream = New FileStream(pfdCargarArchivos.FileName, FileMode.Open)
                    Dim nameExt() As String = arch_files.Name.Split(".")
                    AUDIT_AuditoriasCondicionesTableAdapter.Archivo1_UpdateQuery(archivo1, nameExt(1), Id_auditoriaCondicionTextBox.Text.Trim)
                    MsgBox("El archivo " & arch_files.Name & " se guardó correctamente...", MsgBoxStyle.Information)
                    arch_files.Close()
                End If
            Else
                If MsgBox("Se guardó un archivo anteriormente, ¿desea cargarlo nuevamente?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If pfdCargarArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        Dim archivo1 As Byte() = File.ReadAllBytes(pfdCargarArchivos.FileName)
                        Dim arch_files As FileStream = New FileStream(pfdCargarArchivos.FileName, FileMode.Open)
                        Dim nameExt() As String = arch_files.Name.Split(".")
                        AUDIT_AuditoriasCondicionesTableAdapter.Archivo1_UpdateQuery(archivo1, nameExt(1), Id_auditoriaCondicionTextBox.Text.Trim)
                        MsgBox("El archivo " & arch_files.Name & " se guardó correctamente...", MsgBoxStyle.Information)
                        arch_files.Close()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al actualizar registro...")
        End Try
        Me.Update()
        taActulizaAudit.UpdateFechaActualizacion(Date.Now, var_anexoAMC, var_consecAMC)
        Me.frmAuditoriaCondiciones_Load(sender, e)

    End Sub

    Private Sub btnArchivo2_Click(sender As Object, e As EventArgs) Handles btnArchivo2.Click
        Try
            Me.btnActualizar_Click(sender, e)
            If AUDIT_AuditoriasCondicionesTableAdapter.EsArchivo2_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) <= 1 Then
                If pfdCargarArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim archivo2 As Byte() = File.ReadAllBytes(pfdCargarArchivos.FileName)
                    Dim arch_files As FileStream = New FileStream(pfdCargarArchivos.FileName, FileMode.Open)
                    Dim nameExt() As String = arch_files.Name.Split(".")
                    AUDIT_AuditoriasCondicionesTableAdapter.Archivo2_UpdateQuery(archivo2, nameExt(1), Id_auditoriaCondicionTextBox.Text.Trim)
                    MsgBox("El archivo " & arch_files.Name & " se guardó correctamente...", MsgBoxStyle.Information)
                    arch_files.Close()
                End If
            Else
                If MsgBox("Se guardó un archivo anteriormente, ¿desea cargarlo nuevamente?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If pfdCargarArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        Dim archivo2 As Byte() = File.ReadAllBytes(pfdCargarArchivos.FileName)
                        Dim arch_files As FileStream = New FileStream(pfdCargarArchivos.FileName, FileMode.Open)
                        Dim nameExt() As String = arch_files.Name.Split(".")
                        AUDIT_AuditoriasCondicionesTableAdapter.Archivo2_UpdateQuery(archivo2, nameExt(1), Id_auditoriaCondicionTextBox.Text.Trim)
                        MsgBox("El archivo " & arch_files.Name & " se guardó correctamente...", MsgBoxStyle.Information)
                        arch_files.Close()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al actualizar registro...")
        End Try
        Me.Update()
        taActulizaAudit.UpdateFechaActualizacion(Date.Now, var_anexoAMC, var_consecAMC)
        Me.frmAuditoriaCondiciones_Load(sender, e)
    End Sub

    Private Sub btnArchivo3_Click(sender As Object, e As EventArgs) Handles btnArchivo3.Click
        Try
            Me.btnActualizar_Click(sender, e)
            If AUDIT_AuditoriasCondicionesTableAdapter.EsArchivo3_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim) <= 1 Then
                If pfdCargarArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim archivo3 As Byte() = File.ReadAllBytes(pfdCargarArchivos.FileName)
                    Dim arch_files As FileStream = New FileStream(pfdCargarArchivos.FileName, FileMode.Open)
                    Dim nameExt() As String = arch_files.Name.Split(".")
                    AUDIT_AuditoriasCondicionesTableAdapter.Archivo3_UpdateQuery(archivo3, nameExt(1), Id_auditoriaCondicionTextBox.Text.Trim)
                    MsgBox("El archivo " & arch_files.Name & " se guardó correctamente...", MsgBoxStyle.Information)
                    arch_files.Close()
                End If
            Else
                If MsgBox("Ya se guardó un archivo anteriormente, ¿desea cargarlo nuevamente?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If pfdCargarArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        Dim archivo3 As Byte() = File.ReadAllBytes(pfdCargarArchivos.FileName)
                        Dim arch_files As FileStream = New FileStream(pfdCargarArchivos.FileName, FileMode.Open)
                        Dim nameExt() As String = arch_files.Name.Split(".")
                        AUDIT_AuditoriasCondicionesTableAdapter.Archivo3_UpdateQuery(archivo3, nameExt(1), Id_auditoriaCondicionTextBox.Text.Trim)
                        MsgBox("El archivo " & arch_files.Name & " se guardó correctamente...", MsgBoxStyle.Information)
                        arch_files.Close()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al actualizar registro...")
        End Try
        Me.Update()
        taActulizaAudit.UpdateFechaActualizacion(Date.Now, var_anexoAMC, var_consecAMC)
        Me.frmAuditoriaCondiciones_Load(sender, e)
    End Sub

    Private Sub lklAbrir1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAbrir1.LinkClicked
        Dim guidv1 As String = Guid.NewGuid.ToString
        Try
            Dim archivoByte As Byte() = taAuditoriasCond.ObtArchivo1_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim)
            Dim ext1 As String = taAuditoriasCond.ObtExt1_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim)
            File.WriteAllBytes("C:\Files\" & guidv1 & "." + ext1, archivoByte)
            Process.Start("C:\Files\" & guidv1 & "." + ext1)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al abrir archivo...")
        End Try

    End Sub

    Private Sub lklAbrir2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAbrir2.LinkClicked
        Dim guidv2 As String = Guid.NewGuid.ToString
        Try
            Dim archivoByte As Byte() = taAuditoriasCond.ObtArchivo2_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim)
            Dim ext2 As String = taAuditoriasCond.ObtExt2_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim)
            File.WriteAllBytes("C:\Files\" & guidv2 & "." + ext2, archivoByte)
            Process.Start("C:\Files\" & guidv2 & "." + ext2)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al abrir archivo...")
        End Try
    End Sub

    Private Sub lklAbrir3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAbrir3.LinkClicked
        Dim guidv3 As String = Guid.NewGuid.ToString
        Try
            Dim archivoByte As Byte() = taAuditoriasCond.ObtArchivo3_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim)
            Dim ext3 As String = taAuditoriasCond.ObtExt3_ScalarQuery(Id_auditoriaCondicionTextBox.Text.Trim)
            File.WriteAllBytes("C:\Files\" & guidv3 & "." + ext3, archivoByte)
            Process.Start("C:\Files\" & guidv3 & "." + ext3)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al abrir archivo...")
        End Try
    End Sub
End Class