Public Class ReportTransaksiViewer
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer3.Load
        Dim reportransaksi As New ReportTransaksi
        CrystalReportViewer3.ReportSource = reportransaksi
        CrystalReportViewer3.Refresh()
        CrystalReportViewer3.RefreshReport()
    End Sub

    Private Sub ReportTransaksiViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MainForm
    End Sub
End Class