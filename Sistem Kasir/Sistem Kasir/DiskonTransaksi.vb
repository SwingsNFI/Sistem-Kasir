Imports System.Data.SqlClient
Public Class DiskonTransaksi
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
        jumlahdiskon.Text = ""
        namabardis.Text = ""
        startdatedis.Text = DateTime.Now.ToString("dd/MM/yyyy")
        expiredatadis.ResetText()
        Me.MdiParent = MainForm
    End Sub

    Sub KondisiAwal2()
        Dim pilihbar As String = "select nama_barang from TabelBarang"
        Cmd = New SqlCommand(pilihbar, Conn)
        Rd = Cmd.ExecuteReader()
        namabardis.Items.Clear()
        While Rd.Read()
            namabardis.Items.Add(Rd.GetString(0))
        End While
        Rd.Close()
    End Sub

    Private Sub DiskonTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call KondisiAwal2()
    End Sub

    Private Sub buatbutdis_Click(sender As Object, e As EventArgs) Handles buatbutdis.Click
        If jumlahdiskon.Text = "" Then
            MsgBox("Harap isi jumlah diskon terlebih dahulu!")
        Else
            Koneksi()
            Dim masukin As String = "insert into TabelDiskon (nama_barang, jumlah_diskon, start_date, expired_date) values ('" & namabardis.Text & "','" & jumlahdiskon.Text & "',@startdate,@exdate)"
            Cmd = New SqlCommand(masukin, Conn)
            Cmd.Parameters.AddWithValue("@exdate", expiredatadis.Value)
            Cmd.Parameters.AddWithValue("@startdate", Convert.ToDateTime(startdatedis.Text))
            Cmd.ExecuteNonQuery()
            Dim idku As Int32
            Cmd = New SqlCommand("Select top 1 id_diskon from TabelDiskon order by id_diskon desc", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            idku = Rd.GetInt32(0)
            MessageBox.Show("Anda Berhasil Membuat Data" & vbNewLine & "ID = " & idku)
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Kembali_Click(sender As Object, e As EventArgs) Handles Kembali.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub hapusbutdis_Click(sender As Object, e As EventArgs) Handles hapusbutdis.Click
        Dim hapus As DialogResult
        hapus = MessageBox.Show("Apakah anda mau menghapus yang anda pilih?", "Perhatian!", MessageBoxButtons.YesNo)
        If hapus = DialogResult.Yes Then
            Call Koneksi()
            Dim column1 As Integer = DataGridView1.CurrentRow.Cells("id_diskon").Value.ToString
            Dim delete As String = "delete from TabelDiskon where id_diskon = '" & column1 & "'"
            Cmd = New SqlCommand(delete, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            KondisiAwal()
        End If
    End Sub
End Class