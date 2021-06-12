Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReportTransaksiIDtransaksiViewer
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
        baca = "Select * from TabelMasterTransaksi where id_transaksi = '" & ReportberdasarkanIDtransaksi.Pilihidtransaksi.Text & "'"
        Da = New SqlDataAdapter(baca, Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "TabelMasterTransaksi")
        Dt = Ds.Tables("TabelMasterTransaksi")
        Dim reporttransaksiidtransaksi As ReportTransaksiIDtransaksi = New ReportTransaksiIDtransaksi()
        reporttransaksiidtransaksi.SetDataSource(Ds)
        CrystalReportViewer1.ReportSource = reporttransaksiidtransaksi
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class