Imports System.Data.SqlClient
Public Class Reportberdasarkankasir
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
        Pilihkasir.Items.Clear()
        Dim baca As String
        baca = "Select nama_karyawan from TabelKaryawan"
        Cmd = New SqlCommand(baca, Conn)
        Rd = Cmd.ExecuteReader()
        While Rd.Read()
            Pilihkasir.Items.Add(Rd.GetString(0))
        End While
        Rd.Close()
        Me.MdiParent = MainForm
    End Sub

    Private Sub Reportberdasarkankasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Reportbutt_Click(sender As Object, e As EventArgs) Handles Reportbutt.Click
        ReportTransaksikasirViewer.Show()
    End Sub
End Class