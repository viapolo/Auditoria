Public Class frmBuscaContratosSuc
    Private Sub frmBuscaContratosSuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SucursalesTableAdapter.Fill(Me.ProductionDataSet1.Sucursales)
    End Sub

    Private Sub cmbSucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursales.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Dim taAnexosSucursales As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter
        Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter

        If Not cmbSucursales.SelectedValue Is Nothing Then
            taAnexosSucursales.ObtSuc_FillBy(ProductionDataSet.Vw_Anexos, cmbSucursales.Text)
            lbxContratos.Items.Clear()
            For Each rows As ProductionDataSet.Vw_AnexosRow In ProductionDataSet.Vw_Anexos.Rows
                Dim noAuditorias As Integer = 0
                noAuditorias = taAuditorias.ContadorAuditorias(rows.Anexo.Trim, rows.Ciclo.Trim)
                If chkConAuditorias.Checked = True Then
                    If noAuditorias > 0 Then
                        If rows.TipoCredito = "CUENTA CORRIENTE" Then
                            If rows.Ciclo <> "" Then
                                If rows.Ciclo = "01" Then
                                    lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + " /" + rows.Ciclo + " / " + noAuditorias.ToString) '+ " / " + rows.Ciclo)
                                End If
                            End If
                        Else
                            If rows.Ciclo <> "" Then
                                lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + " / " + rows.Ciclo + " / " + noAuditorias.ToString)
                            Else
                                lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + " / / " + noAuditorias.ToString)
                            End If
                        End If
                    End If
                End If
                If chkSinAuditorias.Checked = True Then
                    If noAuditorias = 0 Then
                        If rows.TipoCredito = "CUENTA CORRIENTE" Then
                            If rows.Ciclo <> "" Then
                                If rows.Ciclo = "01" Then
                                    lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + " / " + rows.Ciclo + "/ " + noAuditorias.ToString) '+ " / " + rows.Ciclo)
                                End If
                            End If
                        Else
                            If rows.Ciclo <> "" Then
                                lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + " / " + rows.Ciclo + " / " + noAuditorias.ToString)
                            Else
                                lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + " / / " + noAuditorias.ToString)
                            End If
                        End If
                    End If
                End If
            Next
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub lbxContratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxContratos.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        cmbSucursales.Enabled = False

        If lbxContratos.Items.Count > 0 Then
            Dim taCiclo As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter
            Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
            Dim taActfijo As New ProductionDataSetTableAdapters.ActifijoTableAdapter
            Dim datos(3) As String
            datos = lbxContratos.SelectedItem.ToString.Split("/")
            If datos.Length = 3 Then
                ReDim Preserve datos(3)
                datos(3) = " "
            Else
                datos(3) = datos(3).Trim
            End If
            frmAuditorias.var_anexo = datos(2)
            frmAuditorias.var_ciclo = datos(3)
            lblNombreCliente.Text = taCiclo.ObtNomCliente_ScalarQuery(datos(2).Trim)
            frmAuditorias.var_consecutivo = taAuditorias.ContadorAuditorias(datos(2).Trim, datos(3).Trim)
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, datos(2).Trim, datos(3).Trim)

            frmAuditorias.var_cliente = taCiclo.ObtNomCliente_ScalarQuery(datos(2).Trim).Trim
            frmAuditorias.var_sucursal = taCiclo.ObtNomSuc_ScalarQuery(datos(2).Trim, datos(3))
            frmAuditorias.var_tipoCredito = taCiclo.ObtTipoCred_ScalarQuery(datos(2).Trim, datos(3))
            frmAuditorias.var_recursos = taCiclo.ObtFondeotit_ScalarQuery(datos(2).Trim, datos(3))
            frmAuditorias.var_fechaDispo = taCiclo.ObtFecha_Pago_ScalarQuery(datos(2).Trim, datos(3))
            frmAuditorias.var_promotor = taCiclo.ObtNombre_Promotor_ScalarQuery(datos(2).Trim, datos(3))
            frmAuditorias.var_destino = taActfijo.Obtdestino_ScalarQuery(lblAnexos.Text)

            Me.Enabled = False
            If ProductionDataSet.AUDIT_Auditorias.Rows.Count = 0 Then
                If MsgBox("El contrato no tiene auditorias relacionadas, ¿Deséa auditar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    frmAuditorias.MdiParent = MDIAuditoria
                    frmAuditorias.Show()
                Else
                    Me.Enabled = True
                End If
            Else
                frmAuditorias.MdiParent = MDIAuditoria
                frmAuditorias.Show()
            End If
        End If
        Me.Cursor = Cursors.Default
        cmbSucursales.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class