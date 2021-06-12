Imports System.Data.SqlClient
Public Class AdBarang
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
        DataGridView2.DataSource = (Ds.Tables("TabelBarang"))
        namaadbar.Text = ""
        hargaadbar.Text = ""
        jumlahadbar.Text = ""
        ptadbar.Text = ""
        tgladbar.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Me.MdiParent = MainForm
    End Sub

    Private Sub buatbutadbar_Click(sender As Object, e As EventArgs) Handles buatbutadbar.Click
        If namaadbar.Text = "" Or hargaadbar.Text = "" Or jumlahadbar.Text = "" Or ptadbar.Text = "" Or tgladbar.Text = "" Then
            MsgBox("Harap isi semua bidang")
        Else
            If namaadbar.Text.StartsWith(" ") Or ptadbar.Text.StartsWith(" ") Then
                MessageBox.Show("Tidak boleh menaruh space di awal Nama atau PT Pembuat")
            Else
                Call Koneksi()
                Dim simpan2 As String = "insert into TabelBarang (nama_barang, harga_barang, jumlah_barang, ptpembuat_barang, tgl_barang) values ('" & namaadbar.Text & "','" & hargaadbar.Text & "','" & jumlahadbar.Text & "','" & ptadbar.Text & "',@tgladbar)"
                Cmd = New SqlCommand(simpan2, Conn)
                Cmd.Parameters.AddWithValue("@tgladbar", Convert.ToDateTime(tgladbar.Text))
                Cmd.ExecuteNonQuery()
                MsgBox("Anda Berhasil Membuat Data")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub AdBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub hapusbutadbar_Click(sender As Object, e As EventArgs) Handles hapusbutadbar.Click
        Dim hapus As DialogResult
        hapus = MessageBox.Show("Apakah anda mau menghapus yang anda pilih?", "Perhatian!", MessageBoxButtons.YesNo)
        If hapus = DialogResult.Yes Then
            Call Koneksi()
            Dim column2 As Integer = DataGridView2.CurrentRow.Cells("id_barang").Value.ToString
            Dim delete As String = "delete from TabelBarang where id_barang = '" & column2 & "'"
            Cmd = New SqlCommand(delete, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            KondisiAwal()
        End If
    End Sub

    Private Sub Kembali2_Click(sender As Object, e As EventArgs) Handles Kembali2.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub hargaadbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargaadbar.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub jumlahadbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahadbar.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub namaadbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaadbar.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub
End Class