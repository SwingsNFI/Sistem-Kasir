Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Show()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        AdKaryawan.Show()
        Welcome.Hide()
    End Sub

    Private Sub BuatDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatDataBarangToolStripMenuItem.Click
        AdBarang.Show()
        Welcome.Hide()
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        TranAdmin.Show()
        Welcome.Hide()
    End Sub

    Private Sub ReportKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportKaryawanToolStripMenuItem.Click
        ReportKaryawanViewer.Show()
        Welcome.Hide()
    End Sub

    Private Sub ReportBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportBarangToolStripMenuItem.Click
        ReportBarangViewer.Show()
        Welcome.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Welcome.Close()
        TransaksiKasir.Close()
        Login.Show()
        Karyawants.Visible = False
        barangts.Visible = False
        transaksits.Visible = False
        reportts.Visible = False
        namakamu.Visible = False
        diskonts.Visible = False
        pajakts.Visible = False
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditAdKar.Show()
        Welcome.Hide()
    End Sub

    Private Sub EditDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDataBarangToolStripMenuItem.Click
        EditAdBar.Show()
        Welcome.Hide()
    End Sub

    Private Sub BuatDataDiskonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatDataDiskonToolStripMenuItem.Click
        Welcome.Hide()
        DiskonTransaksi.Show()
    End Sub

    Private Sub EditDataDiskonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDataDiskonToolStripMenuItem.Click
        Welcome.Hide()
        EditDiskonTransaksi.Show()
    End Sub

    Private Sub BuatDataPajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatDataPajakToolStripMenuItem.Click
        Welcome.Hide()
        PajakTransaksi.Show()
    End Sub

    Private Sub EditDataPajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDataPajakToolStripMenuItem.Click
        Welcome.Hide()
        EditPajakTransaksi.Show()
    End Sub

    Private Sub BerdasarkanKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BerdasarkanKasirToolStripMenuItem.Click
        Welcome.Hide()
        Reportberdasarkankasir.Show()
    End Sub

    Private Sub BerdasarkanIDTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BerdasarkanIDTransaksiToolStripMenuItem.Click
        Welcome.Hide()
        ReportberdasarkanIDtransaksi.Show()
    End Sub
End Class