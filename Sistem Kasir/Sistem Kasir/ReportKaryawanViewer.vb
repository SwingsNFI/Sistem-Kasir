Public Class ReportKaryawanViewer
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer2.Load
        Dim reportkaryawan As New ReportKaryawan
        CrystalReportViewer2.ReportSource = reportkaryawan
        CrystalReportViewer2.Refresh()
        CrystalReportViewer2.RefreshReport()
    End Sub

    Private Sub ReportKaryawanViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MainForm
    End Sub
End Class