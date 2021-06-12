Imports System.Data.SqlClient
Public Class EditPajakTransaksi
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
        Da = New SqlDataAdapter("Select * from TabelPajak", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelPajak")
        DataGridView1.DataSource = (Ds.Tables("TabelPajak"))
        nicknamepajakdit.Text = ""
        fullnamepajakdit.Text = ""
        jumlahpajakdit.Text = ""
        nicknamepajakdit.Enabled = False
        fullnamepajakdit.Enabled = False
        jumlahpajakdit.Enabled = False
        Me.MdiParent = MainForm
    End Sub

    Private Sub EditPajakTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub idmaksud_TextChanged(sender As Object, e As EventArgs) Handles idmaksud.TextChanged
        If Not idmaksud.Text = "" And Not idmaksud.Text.StartsWith(" ") Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value = idmaksud.Text Then
                    nicknamepajakdit.Text = row.Cells(1).Value.ToString()
                    fullnamepajakdit.Text = row.Cells(2).Value.ToString()
                    jumlahpajakdit.Text = row.Cells(3).Value.ToString()
                    nicknamepajakdit.Enabled = True
                    fullnamepajakdit.Enabled = True
                    jumlahpajakdit.Enabled = True
                    Exit Sub
                Else
                    Call KondisiAwal()
                End If
            Next
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub editadkar2_Click(sender As Object, e As EventArgs) Handles editadkar2.Click
        If nicknamepajakdit.Text = "" Or fullnamepajakdit.Text = "" Or jumlahpajakdit.Text = "" Then
            MsgBox("Harap isi semua bidang!")
        Else
            If nicknamepajakdit.Text.StartsWith(" ") Or fullnamepajakdit.Text.StartsWith(" ") Then
                MessageBox.Show("Tidak boleh menaruh space di awal Nama dan Jawaban")
            Else
                Call Koneksi()
                Dim update As String = "update TabelPajak set nickname_pajak = '" & nicknamepajakdit.Text & "', namapanjang_pajak = '" & fullnamepajakdit.Text & "', jumlah_pajak = '" & jumlahpajakdit.Text & "' where id_pajak = '" & idmaksud.Text & "'"
                Cmd = New SqlCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Anda Berhasil Mengedit Data")
                Call KondisiAwal()
                PajakTransaksi.KondisiAwal()
            End If
        End If
    End Sub

    Private Sub canceleditadbar_Click(sender As Object, e As EventArgs) Handles canceleditadbar.Click
        Me.Close()
        Welcome.Show()
    End Sub
End Class