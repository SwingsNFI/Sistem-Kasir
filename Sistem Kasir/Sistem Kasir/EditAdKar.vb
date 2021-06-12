Imports System.Data.SqlClient
Public Class EditAdKar
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
        Da = New SqlDataAdapter("Select * from TabelKaryawan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelKaryawan")
        DataGridView1.DataSource = (Ds.Tables("TabelKaryawan"))
        passeditadkar.Text = ""
        namaeditadkar.Text = ""
        tgleditadkar.ResetText()
        jkeditadkar.Text = ""
        jkeditadkar.Items.Clear()
        jkeditadkar.Items.Add("Laki-laki")
        jkeditadkar.Items.Add("Perempuan")
        noteleditadkar.Text = ""
        jabeditadkar.Items.Clear()
        jabeditadkar.Items.Add("Admin")
        jabeditadkar.Items.Add("Kasir")
        emaileditadkar.Text = ""
        pertanyaanedit1.Items.Clear()
        pertanyaanedit2.Items.Clear()
        pertanyaanedit1.Items.Add("Siapa nama ibumu?")
        pertanyaanedit1.Items.Add("Siapa nama hewan peliharaanmu?")
        pertanyaanedit2.Items.Add("Dimanakah kamu bersekolah?")
        pertanyaanedit2.Items.Add("Apa barang favorit kamu?")
        jawabanedit1.Text = ""
        jawabanedit2.Text = ""
        passeditadkar.Enabled = False
        namaeditadkar.Enabled = False
        jabeditadkar.Enabled = False
        emaileditadkar.Enabled = False
        noteleditadkar.Enabled = False
        tgleditadkar.Enabled = False
        jkeditadkar.Enabled = False
        pertanyaanedit1.Enabled = False
        jawabanedit1.Enabled = False
        pertanyaanedit2.Enabled = False
        jawabanedit2.Enabled = False
        See3.Enabled = False
        Me.MdiParent = MainForm
    End Sub

    Private Sub EditAdKar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub editadkar2_Click(sender As Object, e As EventArgs) Handles editadkar2.Click
        If passeditadkar.Text = "" Or namaeditadkar.Text = "" Or tgleditadkar.Text = "" Or jkeditadkar.Text = "" Or noteleditadkar.Text = "" Or jabeditadkar.Text = "" Or emaileditadkar.Text = "" Or pertanyaanedit1.Text = "" Or jawabanedit1.Text = "" Or pertanyaanedit2.Text = "" Or jawabanedit2.Text = "" Then
            MsgBox("Harap isi semua bidang")
        Else
            If namaeditadkar.Text.StartsWith(" ") Or jawabanedit1.Text.StartsWith(" ") Or jawabanedit2.Text.StartsWith(" ") Then
                MessageBox.Show("Tidak boleh menaruh space di awal Nama dan Jawaban")
            Else
                Call Koneksi()
                Dim update As String = "update TabelKaryawan set password_karyawan = '" & passeditadkar.Text & "',nama_karyawan = '" & namaeditadkar.Text & "',tgllahir_karyawan = @tgleditadkar,jk_karyawan = '" & jkeditadkar.Text & "',telepon_karyawan = '" & noteleditadkar.Text & "',jabatan_karyawan = '" & jabeditadkar.Text & "',email_karyawan = '" & emaileditadkar.Text & "',Pertanyaan1 = '" & pertanyaanedit1.Text & "',Jawaban1 = '" & jawabanedit1.Text & "',Pertanyaan2 = '" & pertanyaanedit2.Text & "',Jawaban2 = '" & jawabanedit2.Text & "' where id_karyawan ='" & idmaksud.Text & "'"
                Cmd = New SqlCommand(update, Conn)
                Cmd.Parameters.AddWithValue("@tgleditadkar", tgleditadkar.Value)
                Cmd.ExecuteNonQuery()
                MsgBox("Anda Berhasil Mengedit Data")
                KondisiAwal()
                AdKaryawan.KondisiAwal()
            End If
        End If
    End Sub

    Private Sub canceleditadbar_Click(sender As Object, e As EventArgs) Handles canceleditadbar.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub idmaksud_TextChanged(sender As Object, e As EventArgs) Handles idmaksud.TextChanged
        If Not idmaksud.Text = "" And Not idmaksud.Text.StartsWith(" ") Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value = idmaksud.Text Then
                    passeditadkar.Text = row.Cells(1).Value.ToString()
                    namaeditadkar.Text = row.Cells(2).Value.ToString()
                    jabeditadkar.Text = row.Cells(3).Value.ToString()
                    emaileditadkar.Text = row.Cells(4).Value.ToString()
                    noteleditadkar.Text = row.Cells(5).Value.ToString()
                    tgleditadkar.Value = row.Cells(6).Value.ToString()
                    jkeditadkar.Text = row.Cells(7).Value.ToString()
                    pertanyaanedit1.Text = row.Cells(8).Value.ToString()
                    jawabanedit1.Text = row.Cells(9).Value.ToString()
                    pertanyaanedit2.Text = row.Cells(10).Value.ToString()
                    jawabanedit2.Text = row.Cells(11).Value.ToString()
                    passeditadkar.Enabled = True
                    namaeditadkar.Enabled = True
                    jabeditadkar.Enabled = True
                    emaileditadkar.Enabled = True
                    noteleditadkar.Enabled = True
                    tgleditadkar.Enabled = True
                    jkeditadkar.Enabled = True
                    pertanyaanedit1.Enabled = True
                    jawabanedit1.Enabled = True
                    pertanyaanedit2.Enabled = True
                    jawabanedit2.Enabled = True
                    See3.Enabled = True
                    Exit Sub
                Else
                    Call KondisiAwal()
                End If
            Next
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub noteleditadkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noteleditadkar.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub namaeditadkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaeditadkar.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub See3_CheckedChanged(sender As Object, e As EventArgs) Handles See3.CheckedChanged
        If See3.Checked Then
            passeditadkar.PasswordChar = Nothing
        Else
            passeditadkar.PasswordChar = "*"
        End If
    End Sub

    Private Sub passeditadkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passeditadkar.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub emaileditadkar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emaileditadkar.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub idmaksud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idmaksud.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub jawabanedit1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jawabanedit1.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub jawabanedit2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jawabanedit2.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub
End Class