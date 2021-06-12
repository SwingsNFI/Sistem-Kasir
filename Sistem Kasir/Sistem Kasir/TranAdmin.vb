Imports System.Data.SqlClient
Public Class TranAdmin
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim rownumber As Integer
    Dim LokasiDB As String

    Sub Koneksi()
        LokasiDB = "Data Source = localhost\SQLEXPRESS;Initial Catalog = KasirDatabase;integrated security = true;"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub KondisiAwaltran1()
        Koneksi()
        Da = New SqlDataAdapter("Select * from TabelMasterTransaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelMasterTransaksi")
        DataGridView1.DataSource = (Ds.Tables("TabelMasterTransaksi"))
    End Sub

    Sub KondisiAwaltran2()
        Da = New SqlDataAdapter("Select * from TabelDetailTransaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelDetailTransaksi")
        DataGridView2.DataSource = (Ds.Tables("TabelDetailTransaksi"))
    End Sub

    Private Sub Kembali_Click(sender As Object, e As EventArgs) Handles Kembali.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub TranAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwaltran1()
        Call KondisiAwaltran2()
        Me.MdiParent = MainForm
    End Sub
End Class