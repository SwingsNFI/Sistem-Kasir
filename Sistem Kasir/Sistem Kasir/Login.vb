Imports System.Data.SqlClient
Public Class Login
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim LokasiDB As String
    Public idorang As String
    Public namaorang As String

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
        ID.Text = ""
        Password.Text = ""
        Me.MdiParent = MainForm
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles logbut.Click
        If ID.Text = "" And Password.Text = "" Then

            MsgBox("Harap isi ID dan Password")
        ElseIf ID.Text = "" Then
            MsgBox("Harap isi ID")
        ElseIf Password.Text = "" Then
            MsgBox("Harap isi Password")
        Else
            Call Koneksi()
            Dim login As String = "select * from TabelKaryawan where id_karyawan = '" + ID.Text + "' and password_karyawan = '" + Password.Text + "'"
            Dim Da2 As SqlDataAdapter
            Dim Dt As DataTable
            Cmd = New SqlCommand(login, Conn)
            Da2 = New SqlDataAdapter(Cmd)
            Dt = New DataTable
            Da2.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                Dim Cmd2 As SqlCommand
                Cmd2 = New SqlCommand(login, Conn)
                Rd = Cmd2.ExecuteReader()
                Rd.Read()
                If Rd.Item("jabatan_karyawan") = "Admin" Then
                    namaorang = Rd.Item("nama_karyawan")
                    idorang = Rd.Item("id_karyawan")
                    Me.Hide()
                    Welcome.Show()
                    MainForm.Karyawants.Visible = True
                    MainForm.barangts.Visible = True
                    MainForm.transaksits.Visible = True
                    MainForm.reportts.Visible = True
                    MainForm.namakamu.Visible = True
                    MainForm.diskonts.Visible = True
                    MainForm.pajakts.Visible = True
                    MainForm.namakamu.Text = Rd.Item("nama_karyawan")
                ElseIf Rd.Item("jabatan_karyawan") = "Kasir" Then
                    namaorang = Rd.Item("nama_karyawan")
                    idorang = Rd.Item("id_karyawan")
                    Me.Hide()
                    TransaksiKasir.Show()
                    MainForm.namakamu.Visible = True
                    MainForm.namakamu.Text = "Selamat Datang " + Rd.Item("nama_karyawan")
                End If
            Else
                MsgBox("Anda salah memasukkan ID atau Password")
            End If
        End If
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ID.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub See2_CheckedChanged(sender As Object, e As EventArgs) Handles See2.CheckedChanged
        If See2.Checked Then
            Password.PasswordChar = Nothing
        Else
            Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        ResetPassword.Show()
    End Sub

    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub
End Class
