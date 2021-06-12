Imports System.Data.SqlClient
Public Class PajakTransaksi
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
        nicknamepajak.Text = ""
        fullnamepajak.Text = ""
        jumlahpajak.Text = ""
        Me.MdiParent = MainForm
    End Sub

    Private Sub buatbutdis_Click(sender As Object, e As EventArgs) Handles buatbutdis.Click
        If nicknamepajak.Text = "" Or fullnamepajak.Text = "" Or jumlahpajak.Text = "" Then
            MsgBox("Harap isi semua bidang!")
        Else
            If nicknamepajak.Text.StartsWith(" ") Or fullnamepajak.Text.StartsWith(" ") Then
                MessageBox.Show("Tidak boleh menaruh space di awal Nama dan Jawaban")
            Else
                Call Koneksi()
                Dim simpan As String = "insert into TabelPajak values ('" & nicknamepajak.Text & "','" & fullnamepajak.Text & "','" & jumlahpajak.Text & "')"
                Cmd = New SqlCommand(simpan, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Anda Berhasil Membuat Data")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub PajakTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub hapusbutdis_Click(sender As Object, e As EventArgs) Handles hapusbutdis.Click
        Dim hapus As DialogResult
        hapus = MessageBox.Show("Apakah anda mau menghapus yang anda pilih?", "Perhatian!", MessageBoxButtons.YesNo)
        If hapus = DialogResult.Yes Then
            Call Koneksi()
            Dim column1 As Integer = DataGridView1.CurrentRow.Cells("id_pajak").Value.ToString
            Dim delete As String = "delete from TabelPajak where id_pajak = '" & column1 & "'"
            Cmd = New SqlCommand(delete, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            KondisiAwal()
        End If
    End Sub
End Class