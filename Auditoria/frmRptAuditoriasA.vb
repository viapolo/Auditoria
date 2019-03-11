Public Class frmRptAuditoriasA
    Private Sub frmRptAuditoriasA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New rptAuditoriasA
        Dim ta As New ProductionDataSetTableAdapters.Vw_AUDITrpt1TableAdapter
        Dim ds As New ProductionDataSet

        ta.Fill(ds.Vw_AUDITrpt1)
        rpt.SetDataSource(ds)
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.Refresh()
        WindowState = FormWindowState.Maximized
        'frmRptAuditoriasA.Show()
    End Sub
End Class