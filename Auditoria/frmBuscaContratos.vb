Public Class frmBuscaContratos

    Private Sub frmBuscaContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.Vw_Anexos' Puede moverla o quitarla según sea necesario.
        Me.Vw_AnexosTableAdapter.Fill(Me.ProductionDataSet.Vw_Anexos)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ProductionDataSet.Clientes)
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        Dim taVWAnexos As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter

        If Not cmbClientes.SelectedValue Is Nothing Then
            taVWAnexos.ObtCont_FillBy(ProductionDataSet.Vw_Anexos, cmbClientes.SelectedValue.ToString)
            lbxContratos.Items.Clear()
            For Each rows As ProductionDataSet.Vw_AnexosRow In ProductionDataSet.Vw_Anexos.Rows
                If rows.TipoCredito = "CUENTA CORRIENTE" Then
                    If rows.Ciclo <> "" Then
                        If rows.Ciclo = "01" Then
                            lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + "") '+ " / " + rows.Ciclo)
                        End If
                        'Else
                        '        lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim)
                    End If
                Else
                    If rows.Ciclo <> "" Then
                        lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim + " / " + rows.Ciclo)
                    Else
                        lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo.Trim)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub lbxContratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxContratos.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        cmbClientes.Enabled = False
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
            lblTipoDeCredito.Text = datos(1)
            frmAuditorias.var_consecutivo = taAuditorias.ContadorAuditorias(datos(2).Trim, datos(3))
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, datos(2).Trim, datos(3))

            frmAuditorias.var_cliente = taCiclo.ObtNomCliente_ScalarQuery(datos(2).Trim)
            frmAuditorias.var_sucursal = Vw_AnexosBindingSource.Current("Nombre_Sucursal")
            frmAuditorias.var_tipoCredito = Vw_AnexosBindingSource.Current("TipoCredito")
            frmAuditorias.var_recursos = Vw_AnexosBindingSource.Current("Fondeotit")
            frmAuditorias.var_fechaDispo = Vw_AnexosBindingSource.Current("Fecha_Pago")
            frmAuditorias.var_promotor = Vw_AnexosBindingSource.Current("Nombre_Promotor")
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
        cmbClientes.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
