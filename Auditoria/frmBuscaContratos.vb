Public Class frmBuscaContratos

    Private Sub frmBuscaContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ProductionDataSet.Clientes)

    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        Dim taVWAnexos As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter

        If Not cmbClientes.SelectedValue Is Nothing Then
            taVWAnexos.ObtCont_FillBy(ProductionDataSet.Vw_Anexos, cmbClientes.SelectedValue.ToString)
            lbxContratos.Items.Clear()

            For Each rows As ProductionDataSet.Vw_AnexosRow In ProductionDataSet.Vw_Anexos.Rows
                lbxContratos.Items.Add(rows.Anexo)
            Next
        End If
    End Sub

    Private Sub lbxContratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxContratos.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        cmbClientes.Enabled = False
        If lbxContratos.Items.Count > 0 And lbxContratos.SelectedItem = True Then
            Dim taCiclo As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter
            Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
            'Dim fAudi As New frmAuditorias
            frmAuditorias.var_anexo = lbxContratos.SelectedItem
            frmAuditorias.var_ciclo = taCiclo.ObtCicloScalar(lbxContratos.SelectedItem)
            frmAuditorias.var_consecutivo = taAuditorias.ContadorAuditorias(lbxContratos.SelectedItem)

            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, lbxContratos.SelectedItem)
            Me.Enabled = False
            If ProductionDataSet.AUDIT_Auditorias.Rows.Count = 0 Then
                If MsgBox("El contrato no tiene auditorias relacionadas, ¿Deséa auditar?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
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
