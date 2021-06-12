Imports System.Data.SqlClient
Public Class EditDiskonTransaksi
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
        Da = New SqlDataAdapter("Select * from TabelDiskon", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelDiskon")
        DataGridView1.DataSource = (Ds.Tables("TabelDiskon"))
        jumlahdiskondit.Text = ""
        startdatedisdit.ResetText()
        expiredatadisdit.ResetText()
        namabardisdit.Enabled = False
        jumlahdiskondit.Enabled = False
        startdatedisdit.Enabled = False
        expiredatadisdit.Enabled = False
        Me.MdiParent = MainForm
    End Sub

    Sub KondisiAwal2()
        Dim pilihbar As String = "select nama_barang from TabelBarang"
        Cmd = New SqlCommand(pilihbar, Conn)
        Rd = Cmd.ExecuteReader()
        namabardisdit.Items.Clear()
        While Rd.Read()
            namabardisdit.Items.Add(Rd.GetString(0))
        End While
        Rd.Close()
    End Sub

    Private Sub EditDiskonTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call KondisiAwal2()
    End Sub

    Private Sub idmaksud3_TextChanged(sender As Object, e As EventArgs) Handles idmaksud3.TextChanged
        If Not idmaksud3.Text = "" And Not idmaksud3.Text.StartsWith(" ") Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value = idmaksud3.Text Then
                    namabardisdit.Text = row.Cells(1).Value.ToString()
                    jumlahdiskondit.Text = row.Cells(2).Value.ToString()
                    startdatedisdit.Value = row.Cells(3).Value.ToString()
                    expiredatadisdit.Value = row.Cells(4).Value.ToString()
                    namabardisdit.Enabled = True
                    jumlahdiskondit.Enabled = True
                    startdatedisdit.Enabled = True
                    expiredatadisdit.Enabled = True
                    Exit Sub
                Else
                    Call KondisiAwal()
                    Call KondisiAwal2()
                End If
            Next
        Else
            Call KondisiAwal()
            Call KondisiAwal2()
        End If
    End Sub

    Private Sub editadkar2_Click(sender As Object, e As EventArgs) Handles editadkar2.Click
        Call Koneksi()
        Dim update As String = "update TabelDiskon set nama_barang = '" & namabardisdit.Text & "', jumlah_diskon = '" & jumlahdiskondit.Text & "', start_date = @startdate, expired_date = @exdate where id_diskon = '" & idmaksud3.Text & "'"
        Cmd = New SqlCommand(update, Conn)
        Cmd.Parameters.AddWithValue("@startdate", startdatedisdit.Value)
        Cmd.Parameters.AddWithValue("@exdate", expiredatadisdit.Value)
        Cmd.ExecuteNonQuery()
        MsgBox("Anda Berhasil Mengedit Data")
        KondisiAwal()
        DiskonTransaksi.KondisiAwal()
    End Sub

    Private Sub canceleditadbar_Click(sender As Object, e As EventArgs) Handles canceleditadbar.Click
        Me.Close()
        Welcome.Show()
    End Sub
End Class