<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransaksiKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pilihanbarang = New System.Windows.Forms.ComboBox()
        Me.jumlahtran = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nomtran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kembaliantran = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hitungtrans = New System.Windows.Forms.Button()
        Me.simpantrans = New System.Windows.Forms.Button()
        Me.refreshtrans = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.hargatran = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AddTran = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Deletetran = New System.Windows.Forms.Button()
        Me.totalhargatran = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.harsetdistran = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.subtotalharga = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Nama_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga_Diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga_Pajak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hasil_Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pilihanbarang
        '
        Me.pilihanbarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pilihanbarang.FormattingEnabled = True
        Me.pilihanbarang.Location = New System.Drawing.Point(11, 47)
        Me.pilihanbarang.Name = "pilihanbarang"
        Me.pilihanbarang.Size = New System.Drawing.Size(217, 21)
        Me.pilihanbarang.TabIndex = 1
        '
        'jumlahtran
        '
        Me.jumlahtran.Location = New System.Drawing.Point(11, 173)
        Me.jumlahtran.MaxLength = 7
        Me.jumlahtran.Name = "jumlahtran"
        Me.jumlahtran.Size = New System.Drawing.Size(217, 20)
        Me.jumlahtran.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jumlah"
        '
        'nomtran
        '
        Me.nomtran.Location = New System.Drawing.Point(260, 44)
        Me.nomtran.MaxLength = 10
        Me.nomtran.Name = "nomtran"
        Me.nomtran.Size = New System.Drawing.Size(217, 20)
        Me.nomtran.TabIndex = 4
        Me.nomtran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nominal Pembayaran"
        '
        'kembaliantran
        '
        Me.kembaliantran.Enabled = False
        Me.kembaliantran.Location = New System.Drawing.Point(139, 109)
        Me.kembaliantran.Name = "kembaliantran"
        Me.kembaliantran.Size = New System.Drawing.Size(219, 20)
        Me.kembaliantran.TabIndex = 0
        Me.kembaliantran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kembalian"
        '
        'hitungtrans
        '
        Me.hitungtrans.Enabled = False
        Me.hitungtrans.Location = New System.Drawing.Point(121, 154)
        Me.hitungtrans.Name = "hitungtrans"
        Me.hitungtrans.Size = New System.Drawing.Size(75, 23)
        Me.hitungtrans.TabIndex = 5
        Me.hitungtrans.Text = "Hitung"
        Me.hitungtrans.UseVisualStyleBackColor = True
        '
        'simpantrans
        '
        Me.simpantrans.Enabled = False
        Me.simpantrans.Location = New System.Drawing.Point(211, 154)
        Me.simpantrans.Name = "simpantrans"
        Me.simpantrans.Size = New System.Drawing.Size(75, 23)
        Me.simpantrans.TabIndex = 6
        Me.simpantrans.Text = "Simpan"
        Me.simpantrans.UseVisualStyleBackColor = True
        '
        'refreshtrans
        '
        Me.refreshtrans.Location = New System.Drawing.Point(301, 154)
        Me.refreshtrans.Name = "refreshtrans"
        Me.refreshtrans.Size = New System.Drawing.Size(75, 23)
        Me.refreshtrans.TabIndex = 7
        Me.refreshtrans.Text = "Refresh"
        Me.refreshtrans.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nama_Barang, Me.Jumlah, Me.Harga_Total, Me.Harga_Diskon, Me.Harga_Pajak, Me.Hasil_Harga})
        Me.DataGridView3.Location = New System.Drawing.Point(0, 97)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(393, 193)
        Me.DataGridView3.TabIndex = 0
        '
        'hargatran
        '
        Me.hargatran.Enabled = False
        Me.hargatran.Location = New System.Drawing.Point(11, 110)
        Me.hargatran.Name = "hargatran"
        Me.hargatran.Size = New System.Drawing.Size(217, 20)
        Me.hargatran.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Transaksi"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(679, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'AddTran
        '
        Me.AddTran.Enabled = False
        Me.AddTran.Location = New System.Drawing.Point(35, 209)
        Me.AddTran.Name = "AddTran"
        Me.AddTran.Size = New System.Drawing.Size(75, 23)
        Me.AddTran.TabIndex = 3
        Me.AddTran.Text = "Add"
        Me.AddTran.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(407, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(393, 193)
        Me.DataGridView1.TabIndex = 0
        '
        'Deletetran
        '
        Me.Deletetran.Enabled = False
        Me.Deletetran.Location = New System.Drawing.Point(139, 209)
        Me.Deletetran.Name = "Deletetran"
        Me.Deletetran.Size = New System.Drawing.Size(75, 23)
        Me.Deletetran.TabIndex = 8
        Me.Deletetran.Text = "Delete"
        Me.Deletetran.UseVisualStyleBackColor = True
        '
        'totalhargatran
        '
        Me.totalhargatran.Enabled = False
        Me.totalhargatran.Location = New System.Drawing.Point(18, 44)
        Me.totalhargatran.Name = "totalhargatran"
        Me.totalhargatran.Size = New System.Drawing.Size(217, 20)
        Me.totalhargatran.TabIndex = 0
        Me.totalhargatran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, -6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Sub Total Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(58, 554)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Pajak : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(173, 554)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Diskon : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(47, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(161, 552)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.pilihanbarang)
        Me.GroupBox1.Controls.Add(Me.jumlahtran)
        Me.GroupBox1.Controls.Add(Me.hargatran)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AddTran)
        Me.GroupBox1.Controls.Add(Me.Deletetran)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 252)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert Barang"
        '
        'harsetdistran
        '
        Me.harsetdistran.Enabled = False
        Me.harsetdistran.Location = New System.Drawing.Point(260, 47)
        Me.harsetdistran.Name = "harsetdistran"
        Me.harsetdistran.Size = New System.Drawing.Size(217, 20)
        Me.harsetdistran.TabIndex = 0
        Me.harsetdistran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(300, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Jumlah Harga Setelah Diskon"
        '
        'subtotalharga
        '
        Me.subtotalharga.Enabled = False
        Me.subtotalharga.Location = New System.Drawing.Point(18, 48)
        Me.subtotalharga.Name = "subtotalharga"
        Me.subtotalharga.Size = New System.Drawing.Size(217, 20)
        Me.subtotalharga.TabIndex = 16
        Me.subtotalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.subtotalharga)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.harsetdistran)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 96)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Harga"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totalhargatran)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.nomtran)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.kembaliantran)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.simpantrans)
        Me.GroupBox3.Controls.Add(Me.hitungtrans)
        Me.GroupBox3.Controls.Add(Me.refreshtrans)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 393)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(495, 193)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Perhitungan Harga"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(98, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Total Harga"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label14.Location = New System.Drawing.Point(29, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(258, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Dengan pajak yang sesuai dengan PPN yang berlaku"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(18, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "*"
        '
        'Nama_Barang
        '
        Me.Nama_Barang.HeaderText = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.ReadOnly = True
        Me.Nama_Barang.Width = 116
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        Me.Jumlah.Width = 116
        '
        'Harga_Total
        '
        Me.Harga_Total.HeaderText = "Harga"
        Me.Harga_Total.Name = "Harga_Total"
        Me.Harga_Total.ReadOnly = True
        Me.Harga_Total.Width = 116
        '
        'Harga_Diskon
        '
        Me.Harga_Diskon.HeaderText = "Harga_Diskon"
        Me.Harga_Diskon.Name = "Harga_Diskon"
        Me.Harga_Diskon.ReadOnly = True
        '
        'Harga_Pajak
        '
        Me.Harga_Pajak.HeaderText = "Harga_Pajak"
        Me.Harga_Pajak.Name = "Harga_Pajak"
        Me.Harga_Pajak.ReadOnly = True
        '
        'Hasil_Harga
        '
        Me.Hasil_Harga.HeaderText = "Hasil_Harga"
        Me.Hasil_Harga.Name = "Hasil_Harga"
        Me.Hasil_Harga.ReadOnly = True
        '
        'TransaksiKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 592)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Name = "TransaksiKasir"
        Me.Text = "Transaksi"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pilihanbarang As ComboBox
    Friend WithEvents jumlahtran As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nomtran As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kembaliantran As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents hitungtrans As Button
    Friend WithEvents simpantrans As Button
    Friend WithEvents refreshtrans As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents hargatran As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AddTran As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Deletetran As Button
    Friend WithEvents totalhargatran As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents harsetdistran As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents subtotalharga As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Nama_Barang As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Harga_Total As DataGridViewTextBoxColumn
    Friend WithEvents Harga_Diskon As DataGridViewTextBoxColumn
    Friend WithEvents Harga_Pajak As DataGridViewTextBoxColumn
    Friend WithEvents Hasil_Harga As DataGridViewTextBoxColumn
End Class
