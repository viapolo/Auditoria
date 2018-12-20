Public Class frmBuscaContratosSuc
    Private Sub frmBuscaContratosSuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet1.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.ProductionDataSet1.Sucursales)

    End Sub

    Private Sub cmbSucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursales.SelectedIndexChanged
        Dim taAnexosSucursales As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter
        If Not cmbSucursales.SelectedValue Is Nothing Then
            taAnexosSucursales.ObtSuc_FillBy(ProductionDataSet.Vw_Anexos, cmbSucursales.Text)
            lbxContratos.Items.Clear()

            For Each rows As ProductionDataSet.Vw_AnexosRow In ProductionDataSet.Vw_Anexos.Rows
                If rows.Ciclo <> "" Then
                    lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo + " / " + rows.Ciclo)
                Else
                    lbxContratos.Items.Add(rows.Nombre_Sucursal.Trim + " / " + rows.TipoCredito + " / " + rows.Anexo)
                End If
            Next
        End If
    End Sub


    Private Sub lbxContratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxContratos.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        cmbSucursales.Enabled = False
        If lbxContratos.Items.Count > 0 Then
            Dim taCiclo As New ProductionDataSetTableAdapters.Vw_AnexosTableAdapter
            Dim taAuditorias As New ProductionDataSetTableAdapters.AUDIT_AuditoriasTableAdapter
            'Dim fAudi As New frmAuditorias
            Dim datos(3) As String
            datos = lbxContratos.SelectedItem.ToString.Split("/")
            If datos.Length = 3 Then
                ReDim Preserve datos(3)
                datos(3) = " "
            Else
                datos(3) = datos(3).Trim
            End If
            frmAuditorias.var_anexo = datos(2) 'lbxContratos.SelectedItem
            frmAuditorias.var_ciclo = datos(3) 'taCiclo.ObtCicloScalar(datos(2).Trim)
            frmAuditorias.var_consecutivo = taAuditorias.ContadorAuditorias(datos(2).Trim, datos(3).Trim)
            taAuditorias.ObtAudit_FillBy(ProductionDataSet.AUDIT_Auditorias, datos(2).Trim, datos(3).Trim)
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
        cmbSucursales.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class