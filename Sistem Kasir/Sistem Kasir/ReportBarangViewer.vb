Public Class ReportBarangViewer
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim reportbarang As New ReportBarang
        CrystalReportViewer1.ReportSource = reportbarang
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportBarangViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MainForm
    End Sub
End Class