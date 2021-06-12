Imports System.Data.SqlClient
Public Class TransaksiAdmin
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

    Sub KondisiAwal()
        Koneksi()
        Da = New SqlDataAdapter("Select * from TabelTransaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelTransaksi")
        DataGridView1.DataSource = (Ds.Tables("TabelTransaksi"))
        DataGridView3.Rows.Clear()
        ComboBox1.Hide()
        jumlahtran.Text = ""
        hargatran.Text = ""
        nomtran.Text = ""
        kembaliantran.Text = ""
    End Sub