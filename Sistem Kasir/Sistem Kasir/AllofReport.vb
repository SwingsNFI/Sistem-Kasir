Public Class AllofReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ReportBarangViewer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        ReportKaryawanViewer.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        ReportTransaksiViewer.Show()
    End Sub

    Private Sub startpage_Click(sender As Object, e As EventArgs) Handles startpage.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub AllofReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MainForm

    End Sub
End Class