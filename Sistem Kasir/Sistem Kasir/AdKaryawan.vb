Imports System.Data.SqlClient
Public Class AdKaryawan
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim LokasiDB As String

    Sub Koneksi()
        LokasiDB = "Data Source = localhost\SQLEXPRESS;Initial Catalog = KasirDatabase;integrated security = true;"
        'LokasiDB = IO.File.ReadAllText("KoneksiDB.udl").Remove(0, 83)
        'MsgBox(LokasiDB)
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub KondisiAwal()
        Koneksi()
        Da = New SqlDataAdapter("Select * from TabelKaryawan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelKaryawan")
        DataGridView1.DataSource = (Ds.Tables("TabelKaryawan"))
        passadkar.Text = ""
        namaadkar.Text = ""
        tgladkar.ResetText()
        jkadkar.Text = ""
        jkadkar.Items.Clear()
        jkadkar.Items.Add("Laki-laki")
        jkadkar.Items.Add("Perempuan")
        jabadkar.Items.Clear()
        jabadkar.Items.Add("Kasir")
        jabadkar.Items.Add("Admin")
        noteladkar.Text = ""
        jabadkar.Text = ""
        emailadkar.Text = ""
        pertanyaan1.Items.Clear()
        pertanyaan2.Items.Clear()
        pertanyaan1.Items.Add("Siapa nama ibumu?")
        pertanyaan1.Items.Add("Siapa nama hewan peliharaanmu?")
        pertanyaan2.Items.Add("Dimanakah kamu bersekolah?")
        pertanyaan2.Items.Add("Apa barang favorit kamu?")
        jawaban1.Text = ""
        jawaban2.Text = ""
        Me.MdiParent = MainForm
    End Sub

    Private Sub buatbutadkar_Click(sender As Object, e As EventArgs) Handles buatbutadkar.Click
        If passadkar.Text = "" Or namaadkar.Text = "" Or tgladkar.Text = "" Or jkadkar.Text = "" Or noteladkar.Text = "" Or jabadkar.Text = "" Or emailadkar.Text = "" Or pertanyaan1.Text = "" Or pertanyaan2.Text = "" Or jawaban1.Text = "" Or jawaban2.Text = "" Then
            MsgBox("Harap isi semua bidang!")
        Else
            If namaadkar.Text.StartsWith(" ") Or jawaban1.Text.StartsWith(" ") Or jawaban2.Text.StartsWith(" ") Then
                MessageBox.Show("Tidak boleh menaruh space di awal Nama dan Jawaban")
            Else
                Call Koneksi()
                Dim simpan As String = "insert into TabelKaryawan (password_karyawan, nama_karyawan, jabatan_karyawan, email_karyawan, telepon_karyawan, tgllahir_karyawan, jk_karyawan, Pertanyaan1, Jawaban1, Pertanyaan2, Jawaban2) values ('" & passadkar.Text & "','" & namaadkar.Text & "','" & jabadkar.Text & "','" & emailadkar.Text & "','" & noteladkar.Text & "',@tgladkar,'" & jkadkar.Text & "','" & pertanyaan1.Text & "','" & jawaban1.Text & "','" & pertanyaan2.Text & "','" & jawaban2.Text & "')"
                Cmd = New SqlCommand(simpan, Conn)
                Cmd.Parameters.AddWithValue("@tgladkar", tgladkar.Value)
                Cmd.ExecuteNonQuery()
                Dim idbla As Int32
                Cmd = New SqlCommand("Select top 1 id_karyawan from TabelKaryawan order by id_karyawan desc", Conn)
                Rd = Cmd.ExecuteReader()
                Rd.Read()
                idbla = Rd.GetInt32(0)
                MessageBox.Show("Anda Berhasil Membuat Data" & vbNewLine & "ID = " & idbla)
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub AdKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub editbutadkar_Click(sender As Object, e As EventArgs)
        EditAdKar.Show()
    End Sub

    Private Sub hapusbutadkar_Click(sender As Object, e As EventArgs) Handles hapusbutadkar.Click
        Dim hapus As DialogResult
        hapus = MessageBox.Show("Apakah anda mau menghapus yang anda pilih?", "Perhatian!", MessageBoxButtons.YesNo)
        If hapus = DialogResult.Yes Then
            Call Koneksi()
            Dim column1 As Integer = DataGridView1.CurrentRow.Cells("id_karyawan").Value.ToString
            Dim delete As String = "delete from TabelKaryawan where id_karyawan = '" & column1 & "'"
            Cmd = New SqlCommand(delete, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            KondisiAwal()
        End If
    End Sub

    Private Sub Kembali_Click(sender As Object, e As EventArgs) Handles Kembali.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub idadkar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub noteladkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noteladkar.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub namaadkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaadkar.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub passadkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passadkar.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub emailadkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emailadkar.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub See_CheckedChanged(sender As Object, e As EventArgs) Handles See.CheckedChanged
        If See.Checked Then
            passadkar.PasswordChar = Nothing
        Else
            passadkar.PasswordChar = "*"
        End If
    End Sub

    Private Sub jawaban1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jawaban1.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub jawaban2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jawaban2.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub
End Class