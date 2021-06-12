<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.namaadbar = New System.Windows.Forms.TextBox()
        Me.hargaadbar = New System.Windows.Forms.TextBox()
        Me.jumlahadbar = New System.Windows.Forms.TextBox()
        Me.ptadbar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hapusbutadbar = New System.Windows.Forms.Button()
        Me.buatbutadbar = New System.Windows.Forms.Button()
        Me.tgladbar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Kembali2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Untuk Admin"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(347, 118)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(328, 203)
        Me.DataGridView2.TabIndex = 9
        '
        'namaadbar
        '
        Me.namaadbar.Location = New System.Drawing.Point(120, 118)
        Me.namaadbar.Name = "namaadbar"
        Me.namaadbar.Size = New System.Drawing.Size(208, 20)
        Me.namaadbar.TabIndex = 1
        '
        'hargaadbar
        '
        Me.hargaadbar.Location = New System.Drawing.Point(120, 153)
        Me.hargaadbar.Name = "hargaadbar"
        Me.hargaadbar.Size = New System.Drawing.Size(208, 20)
        Me.hargaadbar.TabIndex = 2
        '
        'jumlahadbar
        '
        Me.jumlahadbar.Location = New System.Drawing.Point(120, 188)
        Me.jumlahadbar.Name = "jumlahadbar"
        Me.jumlahadbar.Size = New System.Drawing.Size(208, 20)
        Me.jumlahadbar.TabIndex = 3
        '
        'ptadbar
        '
        Me.ptadbar.Location = New System.Drawing.Point(120, 223)
        Me.ptadbar.Name = "ptadbar"
        Me.ptadbar.Size = New System.Drawing.Size(208, 20)
        Me.ptadbar.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PT Pembuat"
        '
        'hapusbutadbar
        '
        Me.hapusbutadbar.Location = New System.Drawing.Point(190, 298)
        Me.hapusbutadbar.Name = "hapusbutadbar"
        Me.hapusbutadbar.Size = New System.Drawing.Size(75, 23)
        Me.hapusbutadbar.TabIndex = 7
        Me.hapusbutadbar.Text = "Hapus"
        Me.hapusbutadbar.UseVisualStyleBackColor = True
        '
        'buatbutadbar
        '
        Me.buatbutadbar.Location = New System.Drawing.Point(85, 298)
        Me.buatbutadbar.Name = "buatbutadbar"
        Me.buatbutadbar.Size = New System.Drawing.Size(75, 23)
        Me.buatbutadbar.TabIndex = 6
        Me.buatbutadbar.Text = "Buat"
        Me.buatbutadbar.UseVisualStyleBackColor = True
        '
        'tgladbar
        '
        Me.tgladbar.Enabled = False
        Me.tgladbar.Location = New System.Drawing.Point(120, 258)
        Me.tgladbar.Name = "tgladbar"
        Me.tgladbar.Size = New System.Drawing.Size(208, 20)
        Me.tgladbar.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tanggal Barang"
        '
        'Kembali2
        '
        Me.Kembali2.Location = New System.Drawing.Point(-4, 40)
        Me.Kembali2.Name = "Kembali2"
        Me.Kembali2.Size = New System.Drawing.Size(106, 23)
        Me.Kembali2.TabIndex = 8
        Me.Kembali2.Text = "Start Page"
        Me.Kembali2.UseVisualStyleBackColor = True
        '
        'AdBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 333)
        Me.Controls.Add(Me.Kembali2)
        Me.Controls.Add(Me.buatbutadbar)
        Me.Controls.Add(Me.hapusbutadbar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tgladbar)
        Me.Controls.Add(Me.ptadbar)
        Me.Controls.Add(Me.jumlahadbar)
        Me.Controls.Add(Me.hargaadbar)
        Me.Controls.Add(Me.namaadbar)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdBarang"
        Me.Text = "AdBarang"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents namaadbar As TextBox
    Friend WithEvents hargaadbar As TextBox
    Friend WithEvents jumlahadbar As TextBox
    Friend WithEvents ptadbar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents hapusbutadbar As Button
    Friend WithEvents buatbutadbar As Button
    Friend WithEvents tgladbar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Kembali2 As Button
End Class
