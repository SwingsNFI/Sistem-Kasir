Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReportTransaksikasirViewer
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim LokasiDB As String

    Sub Koneksi()
        LokasiDB = "Data Source = localhost\SQLEXPRESS;Initial Catalog = KasirDatabase;integrated security = true;"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Koneksi()
        Dim Dt As DataTable
        Dim baca As String
        baca = "Select * from TabelMasterTransaksi where nama_karyawan = '" & Reportberdasarkankasir.Pilihkasir.Text & "'"
        Da = New SqlDataAdapter(baca, Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "TabelMasterTransaksi")
        Dt = Ds.Tables("TabelMasterTransaksi")
        If Dt.Rows.Count > 0 Then
            Dim reporttransaksikasir As ReportTransaksikasir = New ReportTransaksikasir()
            reporttransaksikasir.SetDataSource(Ds)
            CrystalReportViewer1.ReportSource = reporttransaksikasir
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
        Else
            MessageBox.Show("Belum ada transaksi dari kasir ini!")
            Me.Close()
        End If
    End Sub
End Class