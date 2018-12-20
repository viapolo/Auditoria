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
End Class
