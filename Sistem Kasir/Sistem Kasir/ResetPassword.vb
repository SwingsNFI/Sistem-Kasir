Imports System.Data.SqlClient
Public Class ResetPassword
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
        pertanyaanreset1.Text = ""
        pertanyaanreset2.Text = ""
        jawabanreset1.Text = ""
        jawabanreset2.Text = ""
        resetpass.Hide()
        Pkeamanan.Hide()
        Me.MdiParent = MainForm
    End Sub

    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub buka_Click(sender As Object, e As EventArgs) Handles buka.Click
        If idreset.Text = "" Then
            MsgBox("Tolong isi ID yang anda maksud")
        Else
            Call Koneksi()
            Dim baca As String = "Select id_karyawan from Tabelkaryawan where id_karyawan = '" + idreset.Text + "'"
            Dim Dt As DataTable
            Cmd = New SqlCommand(baca, Conn)
            Da = New SqlDataAdapter(Cmd)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                Rd = Cmd.ExecuteReader()
                Rd.Read()
                If Rd.Item("id_karyawan") = idreset.Text Then
                    Koneksi()
                    Call KondisiAwal()
                    Dim Rd2 As SqlDataReader
                    Cmd = New SqlCommand("Select Pertanyaan1, Pertanyaan2 from TabelKaryawan Where id_karyawan = '" + idreset.Text + "'", Conn)
                    Rd2 = Cmd.ExecuteReader()
                    Rd2.Read()
                    pertanyaanreset1.Text = Rd2.Item("Pertanyaan1").ToString
                    pertanyaanreset2.Text = Rd2.Item("Pertanyaan2").ToString
                    Pkeamanan.Show()
                    resetpass.Show()
                    idreset.Enabled = False
                End If
            Else
                MsgBox("ID yang anda maksud tidak ada dalam data kami")
                Pkeamanan.Hide()
                resetpass.Hide()
            End If
        End If
    End Sub

    Private Sub cancelreset_Click(sender As Object, e As EventArgs) Handles cancelreset.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub idreset_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idreset.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub jawabanreset1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jawabanreset1.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub jawabanreset2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jawabanreset2.KeyPress
        If Not Char.IsLetter(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True And Not Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub resetpass_Click(sender As Object, e As EventArgs) Handles resetpass.Click
        Call Koneksi()
        Dim baca As String = "Select id_karyawan, Jawaban1, Jawaban2 from Tabelkaryawan where id_karyawan = '" + idreset.Text + "'"
        Cmd = New SqlCommand(baca, Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If jawabanreset1.Text = Rd.Item("Jawaban1") And jawabanreset2.Text = Rd.Item("Jawaban2") Then
            NewPassword.Show()
            Me.Hide()
        Else
            MsgBox("Jawaban anda tidak sesuai dengan data anda!")
        End If
    End Sub
End Class