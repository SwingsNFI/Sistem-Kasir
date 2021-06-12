Imports System.Data.SqlClient
Public Class EditAdBar
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
        Da = New SqlDataAdapter("Select * from TabelBarang", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelBarang")
        DataGridView1.DataSource = (Ds.Tables("TabelBarang"))
        namaeditadbar.Text = ""
        hargaeditadbar.Text = ""
        jumlaheditadbar.Text = ""
        pteditadbar.Text = ""
        tgleditadbar.Text = ""
        namaeditadbar.Enabled = False
        hargaeditadbar.Enabled = False
        jumlaheditadbar.Enabled = False
        pteditadbar.Enabled = False
        tgleditadbar.Enabled = False
        Me.MdiParent = MainForm
    End Sub
    Private Sub editadbar2_Click(sender As Object, e As EventArgs) Handles editadbar2.Click
        If namaeditadbar.Text = "" Or hargaeditadbar.Text = "" Or jumlaheditadbar.Text = "" Or pteditadbar.Text = "" Or tgleditadbar.Text = "" Then
            MsgBox("Harap isi semua bidang")
        Else
            If namaeditadbar.Text.StartsWith(" ") Or pteditadbar.Text.StartsWith(" ") Then
                MessageBox.Show("Tidak boleh menaruh space di awal Nama atau PT Pembuat")
            Else
                Call Koneksi()
                Dim update As String = "update TabelBarang set nama_barang = '" & namaeditadbar.Text & "',harga_barang = '" & hargaeditadbar.Text & "',jumlah_barang = '" & jumlaheditadbar.Text & "',ptpembuat_barang = '" & pteditadbar.Text & "',tgl_barang = @tgleditadbar where id_barang ='" & idmaksud2.Text & "'"
                Cmd = New SqlCommand(update, Conn)
                Cmd.Parameters.AddWithValue("@tgleditadbar", tgleditadbar.Value)
                Cmd.ExecuteNonQuery()
                MsgBox("Anda Berhasil Mengedit Data")
                AdBarang.KondisiAwal()
            End If
        End If
    End Sub

    Private Sub EditAdBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub hargaeditadbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargaeditadbar.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub jumlaheditadbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlaheditadbar.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub ideditadbar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub idmaksud2_TextChanged(sender As Object, e As EventArgs) Handles idmaksud2.TextChanged
        If Not idmaksud2.Text = "" And Not idmaksud2.Text.StartsWith(" ") Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value = idmaksud2.Text Then
                    namaeditadbar.Text = row.Cells(1).Value.ToString()
                    hargaeditadbar.Text = row.Cells(2).Value.ToString()
                    jumlaheditadbar.Text = row.Cells(3).Value.ToString()
                    pteditadbar.Text = row.Cells(4).Value.ToString()
                    tgleditadbar.Value = row.Cells(5).Value.ToString()
                    namaeditadbar.Enabled = True
                    hargaeditadbar.Enabled = True
                    jumlaheditadbar.Enabled = True
                    pteditadbar.Enabled = True
                    tgleditadbar.Enabled = True
                    Exit Sub
                Else
                    Call KondisiAwal()
                End If
            Next
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub idmaksud2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idmaksud2.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub namaeditadbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaeditadbar.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub canceleditadbar_Click(sender As Object, e As EventArgs) Handles canceleditadbar.Click
        Me.Close()
        Welcome.Show()
    End Sub
End Class