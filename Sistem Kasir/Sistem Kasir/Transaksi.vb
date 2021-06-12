Imports System.Data.SqlClient
Public Class TransaksiKasir
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As SqlCommand
    Dim Cmd2 As SqlCommand
    Dim Cmd3 As SqlCommand
    Dim Cmd4 As SqlCommand
    Dim Rd As SqlDataReader
    Dim Rd2 As SqlDataReader
    Dim Rd3 As SqlDataReader
    Dim Rd4 As SqlDataReader
    Dim rownumber As Integer
    Dim LokasiDB As String
    Dim persen As String = Convert.ToString("%")

    Sub Koneksi()
        LokasiDB = "Data Source = localhost\SQLEXPRESS;Initial Catalog = KasirDatabase;integrated security = true;"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub KondisiAwal()
        Koneksi()
        Da = New SqlDataAdapter("Select * from TabelMasterTransaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TabelMasterTransaksi")
        DataGridView1.DataSource = (Ds.Tables("TabelMasterTransaksi"))
        DataGridView3.Rows.Clear()
        harsetdistran.Text = ""
        rownumber = 0
        ComboBox1.Hide()
        hargatran.Text = ""
        Convert.ToString(jumlahtran.Text)
        jumlahtran.Text = ""
        kembaliantran.Text = ""
        subtotalharga.Text = ""
        totalhargatran.Text = ""
        Convert.ToString(nomtran.Text)
        nomtran.Text = ""
        pilihanbarang.Enabled = True
        jumlahtran.Enabled = True
        Dim buatpajak As String = "Select jumlah_pajak from TabelPajak where nickname_pajak = 'PPN'"
        Cmd = New SqlCommand(buatpajak, Conn)
        Rd2 = Cmd.ExecuteReader()
        Rd2.Read()
        Dim nambahteks As String = Convert.ToString(Rd2.GetInt32(0))
        Label9.Text = "Diskon : "
        Label8.Text = "Pajak : "
        Label8.Text += nambahteks + persen
        Me.MdiParent = MainForm
        Rd2.Close()
    End Sub

    Sub KondisiAwalcb()
        Dim pilihbar As String = "select nama_barang from TabelBarang"
        Cmd = New SqlCommand(pilihbar, Conn)
        Rd = Cmd.ExecuteReader()
        pilihanbarang.Items.Clear()
        While Rd.Read()
            pilihanbarang.Items.Add(Rd.GetString(0))
        End While
        Rd.Close()
    End Sub

    Sub KondisAwalcb2()
        Dim queryharga As String = "select harga_barang from TabelBarang"
        Dim dt As DataTable
        Da = New SqlDataAdapter(queryharga, Conn)
        dt = New DataTable()
        Da.Fill(dt)
        ComboBox1.DisplayMember = "harga_barang"
        ComboBox1.DataSource = dt
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call KondisiAwalcb()
        Call KondisAwalcb2()
    End Sub

    Private Sub hitungtrans_Click(sender As Object, e As EventArgs) Handles hitungtrans.Click
        Dim kemtran As Double
        If nomtran.Text = "" Then
            MsgBox("Nominal Pembayaran masih belum terisi!")
        Else
            kemtran = Convert.ToDouble(nomtran.Text - totalhargatran.Text)
            kembaliantran.Text = kemtran
            simpantrans.Enabled = True
            jumlahtran.Enabled = False
            pilihanbarang.Enabled = False
            simpantrans.Select()
        End If
    End Sub

    Private Sub pilihanbarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pilihanbarang.SelectedIndexChanged
        ComboBox1.SelectedIndex = pilihanbarang.SelectedIndex
        hargatran.Text = ComboBox1.Text
        Dim buatdiskon As String = "Select jumlah_diskon from TabelDiskon where nama_barang = '" & pilihanbarang.Text & "'"
        Dim Dt As DataTable
        Cmd = New SqlCommand(buatdiskon, Conn)
        Da = New SqlDataAdapter(Cmd)
        Dt = New DataTable
        Da.Fill(Dt)
        If Dt.Rows.Count > 0 Then
            Rd2 = Cmd.ExecuteReader()
            Rd2.Read()
            Dim nambahteks2 As String = Convert.ToString(Rd2.GetInt32(0).ToString) 'nggak usah dipakai buat ngambil data ke form lain
            Label9.Text = "Diskon : "
            Label9.Text += nambahteks2 + persen
        Else
            Label9.Text = "Diskon : "
        End If
        Rd2.Close()
    End Sub

    Sub diskonbro()
        Koneksi()
        Dim tambah As Double
        Dim tambah2 As Double
        Dim pengganti As Integer
        Dim hardis As Double
        Dim diskonlagi As String = "select jumlah_diskon from TabelDiskon where nama_barang = '" & pilihanbarang.Text & "'"
        Cmd = New SqlCommand(diskonlagi, Conn)
        Dim Da2 As SqlDataAdapter
        Dim Dt As DataTable
        Da2 = New SqlDataAdapter(Cmd)
        Dt = New DataTable
        Da2.Fill(Dt)
        If Dt.Rows.Count > 0 Then
            Call Koneksi()
            Dim diskonlagi2 As String = "select jumlah_diskon from TabelDiskon where nama_barang = '" & pilihanbarang.Text & "'"
            Cmd = New SqlCommand(diskonlagi2, Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            For Each row As DataGridViewRow In DataGridView3.Rows
                If row.Cells(0).Value = pilihanbarang.Text Then
                    pengganti = Rd.GetInt32(0)
                    tambah = Convert.ToDouble(100 - pengganti)
                    tambah2 = Convert.ToDouble(row.Cells(2).Value.ToString * tambah / 100)
                    harsetdistran.Text = tambah2
                    hardis = Convert.ToDouble(row.Cells(2).Value * pengganti / 100)
                    row.Cells(3).Value = hardis
                End If
            Next
        Else
            For Each row As DataGridViewRow In DataGridView3.Rows
                If pilihanbarang.Text = row.Cells(0).Value Then
                    row.Cells(3).Value = 0
                    harsetdistran.Text = row.Cells(2).Value
                End If
            Next
        End If
        Rd.Close()
    End Sub

    Sub pajakbro()
        Koneksi()
        Dim buatpajak As String = "Select jumlah_pajak from TabelPajak where nickname_pajak = 'PPN'"
        Cmd = New SqlCommand(buatpajak, Conn)
        Rd2 = Cmd.ExecuteReader()
        Rd2.Read()
        For Each row As DataGridViewRow In DataGridView3.Rows
            row.Cells(4).Value = Rd2.GetInt32(0) / 100 * (row.Cells(2).Value - row.Cells(3).Value)
        Next
        Rd2.Close()
    End Sub

    Private Sub AddTran_Click(sender As Object, e As EventArgs) Handles AddTran.Click
        If jumlahtran.Text = "" Or pilihanbarang.Text = "" Then
            MsgBox("Masih ada yang belum terisi! Isi terlebih dahulu!")
        Else
            Dim harga As Integer
            Dim jumlah As Integer
            harga = Convert.ToInt32(hargatran.Text)
            jumlah = Convert.ToInt32(jumlahtran.Text)
            If DataGridView3.Rows.Count = Nothing Then
                DataGridView3.Rows.Add()
                DataGridView3.Rows(rownumber).Cells(0).Value = pilihanbarang.Text
                DataGridView3.Rows(rownumber).Cells(1).Value = jumlahtran.Text
                DataGridView3.Rows(rownumber).Cells(2).Value = harga * jumlah
                diskonbro()


                rownumber += 1
                pajakbro()
                TotalHarga()
                TotalHarga2()
                hasilharga()
            Else
                For Each row As DataGridViewRow In DataGridView3.Rows
                    If row.Cells(0).Value = pilihanbarang.Text Then
                        Dim kali As Int32
                        kali = harga * jumlah
                        row.Cells(2).Value += kali
                        row.Cells(1).Value += jumlah
                        diskonbro()
                        pajakbro()
                        hasilharga()
                        TotalHarga()
                        TotalHarga2()
                        Exit Sub
                    End If
                Next
                DataGridView3.Rows.Add()
                DataGridView3.Rows(rownumber).Cells(0).Value = pilihanbarang.Text
                DataGridView3.Rows(rownumber).Cells(1).Value = jumlahtran.Text
                DataGridView3.Rows(rownumber).Cells(2).Value = harga * jumlah
                diskonbro()


                rownumber += 1
                pajakbro()
                hasilharga()
                TotalHarga()
                TotalHarga2()
            End If
        End If
    End Sub

    Private Sub Deletetran_Click(sender As Object, e As EventArgs) Handles Deletetran.Click
        If DataGridView3.Rows.Count > 1 Then
            DataGridView3.Rows.RemoveAt(DataGridView3.CurrentCell.RowIndex)
            rownumber -= 1
            TotalHarga()
            diskonbro()
        Else
            If DataGridView3.Rows.Count = 0 Then
                totalhargatran.Text = ""
                subtotalharga.Text = ""
                harsetdistran.Text = ""
            Else
                DataGridView3.Rows.RemoveAt(DataGridView3.CurrentCell.RowIndex)
                rownumber -= 1
                totalhargatran.Text = ""
                subtotalharga.Text = ""
                harsetdistran.Text = ""
            End If
        End If
    End Sub

    Sub TotalHarga()
        Dim nambah As Integer
        Dim nambah2 As Integer
        For Each row As DataGridViewRow In DataGridView3.Rows
            nambah2 = Convert.ToInt32(row.Cells(2).Value)
            nambah = nambah + nambah2
            subtotalharga.Text = nambah
        Next
    End Sub

    Sub TotalHarga2()
        Dim nambah As Integer
        Dim nambah2 As Integer
        Dim buatpajak As String = "Select jumlah_pajak from TabelPajak where nickname_pajak = 'PPN'"
        Cmd = New SqlCommand(buatpajak, Conn)
        Rd2 = Cmd.ExecuteReader()
        Rd2.Read()
        For Each row As DataGridViewRow In DataGridView3.Rows
            nambah2 = Convert.ToInt32(row.Cells(5).Value)
            nambah = nambah + nambah2
            totalhargatran.Text = nambah
        Next
        Rd2.Close()
    End Sub

    Sub hasilharga()
        For Each row As DataGridViewRow In DataGridView3.Rows
            row.Cells(5).Value = row.Cells(2).Value - row.Cells(3).Value + row.Cells(4).Value
        Next
    End Sub

    Private Sub simpantrans_Click(sender As Object, e As EventArgs) Handles simpantrans.Click
        If pilihanbarang.Text = "" Or jumlahtran.Text = "" Or hargatran.Text = "" Or totalhargatran.Text = "" Or nomtran.Text = "" Or kembaliantran.Text = "" Then
            MsgBox("Harap isi semua bidang")
        Else
            If Convert.ToInt32(nomtran.Text >= totalhargatran.Text) Then
                Call Koneksi()
                Dim baca As String = "select id_karyawan, nama_karyawan from TabelKaryawan where id_karyawan = '" & Login.ID.Text & "'"
                Cmd = New SqlCommand(baca, Conn)
                Rd = Cmd.ExecuteReader()
                Rd.Read()
                Dim simpan As String = "insert into TabelMasterTransaksi (subtotal_harga, total_harga, nominal_pembayaran, kembalian, tgl_transaksi, id_karyawan, nama_karyawan) values ('" & subtotalharga.Text & "','" & totalhargatran.Text & "','" & nomtran.Text & "','" & kembaliantran.Text & "',GETDATE(),'" & Rd.Item("id_karyawan") & "','" & Rd.Item("nama_karyawan") & "')"
                Cmd = New SqlCommand(simpan, Conn)
                Rd.Close()
                Cmd.ExecuteNonQuery()
                Dim pengganti As Int32
                Dim baca2 As String = "Select top 1 id_transaksi from TabelMasterTransaksi order by id_transaksi desc"
                Cmd = New SqlCommand(baca2, Conn)
                Rd = Cmd.ExecuteReader()
                Rd.Read()
                pengganti = Rd.GetInt32(0)
                Rd.Close()
                For Each row As DataGridViewRow In DataGridView3.Rows
                    Dim pengganti2 As Int32
                    Dim pengganti3 As Int32
                    Dim baca3 As String = "select id_barang from TabelBarang where nama_barang = '" & row.Cells(0).Value & "'"
                    Cmd2 = New SqlCommand(baca3, Conn)
                    Rd2 = Cmd2.ExecuteReader()
                    Rd2.Read()
                    pengganti2 = Rd2.GetInt32(0)
                    Rd2.Close()
                    Dim baca4 As String = "Select harga_barang from TabelBarang where nama_barang = '" & row.Cells(0).Value & "'"
                    Cmd3 = New SqlCommand(baca4, Conn)
                    Rd3 = Cmd3.ExecuteReader()
                    Rd3.Read()
                    pengganti3 = Rd3.GetInt32(0)
                    Rd3.Close()
                    Dim simpan2 As String = "insert into TabelDetailTransaksi values ('" & pengganti & "','" & pengganti2 & "','" & row.Cells(0).Value.ToString & "','" & pengganti3 & "','" & row.Cells(1).Value.ToString & "','" & row.Cells(3).Value.ToString & "','" & row.Cells(4).Value.ToString & "','" & row.Cells(5).Value.ToString & "')"
                    Cmd = New SqlCommand(simpan2, Conn)
                    Cmd.ExecuteNonQuery()
                Next
                MsgBox("Anda Berhasil Memasukan Data")
            Else
                MsgBox("Nominal pembayaran tidak boleh kurang dari total harga!")
            End If
        End If
    End Sub

    Private Sub refreshtrans_Click(sender As Object, e As EventArgs) Handles refreshtrans.Click
        Call KondisiAwal()
        Call KondisiAwalcb()
        Call KondisAwalcb2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.namakamu.Visible = False
        Me.Close()
        Login.Show()
    End Sub

    Private Sub jumlahtran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahtran.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub nomtran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomtran.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True And Not Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub totalhargatran_TextChanged(sender As Object, e As EventArgs) Handles totalhargatran.TextChanged
        If totalhargatran.Text > "" Then
            hitungtrans.Enabled = True
        Else
            hitungtrans.Enabled = False
        End If
    End Sub

    Private Sub jumlahtran_TextChanged(sender As Object, e As EventArgs) Handles jumlahtran.TextChanged
        While True
            If Not jumlahtran.Text = "" Then
                Dim pengganti1 As Integer = Convert.ToInt32(jumlahtran.Text)
                Dim pengganti2 As Integer = Convert.ToInt32(hargatran.Text)
                If pengganti1 > 0 And pengganti2 > 0 Then
                    AddTran.Enabled = True
                    Deletetran.Enabled = True
                    Exit While
                End If
            Else
                AddTran.Enabled = False
                Deletetran.Enabled = False
                Exit While
            End If
        End While
    End Sub
End Class