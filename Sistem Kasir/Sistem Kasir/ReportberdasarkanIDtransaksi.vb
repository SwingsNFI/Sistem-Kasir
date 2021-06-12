Imports System.Data.SqlClient
Public Class ReportberdasarkanIDtransaksi
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

    Sub KondisiAwal()
        Koneksi()
        Pilihidtransaksi.Items.Clear()
        Dim baca As String
        baca = "Select id_transaksi from TabelMasterTransaksi"
        Cmd = New SqlCommand(baca, Conn)
        Rd = Cmd.ExecuteReader()
        While Rd.Read()
            Pilihidtransaksi.Items.Add(Rd.GetInt32(0))
        End While
        Rd.Close()
        Me.MdiParent = MainForm
    End Sub

    Private Sub ReportberdasarkanIDkasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Reportbutt_Click(sender As Object, e As EventArgs) Handles Reportbutt.Click
        ReportTransaksiIDtransaksiViewer.Show()
    End Sub
End Class