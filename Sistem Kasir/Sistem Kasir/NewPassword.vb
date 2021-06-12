Imports System.Data.SqlClient
Public Class NewPassword
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
        newpass.Text = ""
        Me.MdiParent = MainForm
    End Sub

    Private Sub ganti_Click(sender As Object, e As EventArgs) Handles ganti.Click
        If newpass.Text = "" Then
            MsgBox("Harap isi password baru anda")
        Else
            Call Koneksi()
            Dim pengganti As String
            Dim baca As String = "Select password_karyawan from TabelKaryawan where id_karyawan = '" + ResetPassword.idreset.Text + "'"
            Cmd = New SqlCommand(baca, Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            pengganti = Rd.GetString(0)
            If Not newpass.Text = pengganti Then
                Call Koneksi()
                Dim update As String = "update TabelKaryawan Set password_karyawan = '" + newpass.Text + "' where id_karyawan = '" + ResetPassword.idreset.Text + "'"
                Cmd = New SqlCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Anda Berhasil Mengubah Password Anda!")
                ResetPassword.Close()
                Me.Close()
                Login.Show()
            Else
                MsgBox("Anda telah memakai Password tersebut!")
            End If
        End If
    End Sub

    Private Sub See4_CheckedChanged(sender As Object, e As EventArgs) Handles See4.CheckedChanged
        If See4.Checked Then
            newpass.PasswordChar = Nothing
        Else
            newpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub newpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles newpass.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim batal As DialogResult
        batal = MessageBox.Show("Apakah anda mau membatalkannya?", "Perhatian!", MessageBoxButtons.YesNo)
        If batal = DialogResult.Yes Then
            ResetPassword.Close()
            Me.Close()
            Login.Show()
        End If
    End Sub
End Class