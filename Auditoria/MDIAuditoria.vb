Imports System
Imports System.IO
Imports System.Collections
Imports System.Windows.Forms

Public Class MDIAuditoria
    Private Sub ConsultaNombre_Click(sender As Object, e As EventArgs) Handles ConsultaNombre.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmBuscaContratos.MdiParent = Me
        frmBuscaContratos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SucursalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmBuscaContratosSuc.MdiParent = Me
        frmBuscaContratosSuc.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub AuditoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditoríasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmRptAuditoriasA.MdiParent = Me
        frmRptAuditoriasA.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub DetallesDeContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesDeContratoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False

        ofdActualizaDetallesContrato = New System.Windows.Forms.OpenFileDialog

        Dim stringLinea As String = ""
        Dim taAuditoriasContratos As New ProductionDataSetTableAdapters.AUDIT_AuditoriasCondicionesTableAdapter
        Dim taParametros As New ProductionDataSetTableAdapters.AUDIT_ParametrosAllTableAdapter
        ofdActualizaDetallesContrato.Filter = "Txt (*.txt) |*.txt|(*.txt) |*.txt"
        If ofdActualizaDetallesContrato.ShowDialog = DialogResult.OK Then
            Try
                Dim cadena As New StreamReader(ofdActualizaDetallesContrato.FileName.ToString)
                Do
                    stringLinea = ""
                    Dim arreglo() As String
                    stringLinea = cadena.ReadLine
                    If stringLinea <> "" Then
                        arreglo = stringLinea.Split("|")
                        taAuditoriasContratos.ActualizaPorTxt1_UpdateQuery(taParametros.ObtIdParametro_ScalarQuery("1", arreglo(2).ToString.ToUpper, "VALIDACION", arreglo(2).ToString.ToUpper), arreglo(1), taParametros.ObtIdParametro_ScalarQuery("11", arreglo(4).ToString.ToUpper, "HALLAZGO", arreglo(4).ToString.ToUpper), taParametros.ObtIdParametro_ScalarQuery("32", arreglo(3).ToString.ToUpper, "DEPTOS", arreglo(3).ToString.ToUpper), arreglo(0))
                    End If
                Loop Until stringLinea Is Nothing
                cadena.Close()
                stringLinea = ""
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString, MsgBoxStyle.Critical)
                Exit Sub
            End Try
            MsgBox("Proceso de actualización terminado...", MsgBoxStyle.Information)
        End If

        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
