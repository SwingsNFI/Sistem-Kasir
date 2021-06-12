<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiskonTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buatbutdis = New System.Windows.Forms.Button()
        Me.hapusbutdis = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jumlahdiskon = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kembali = New System.Windows.Forms.Button()
        Me.startdatedis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.namabardis = New System.Windows.Forms.ComboBox()
        Me.expiredatadis = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Diskon Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Untuk Admin"
        '
        'buatbutdis
        '
        Me.buatbutdis.Location = New System.Drawing.Point(85, 259)
        Me.buatbutdis.Name = "buatbutdis"
        Me.buatbutdis.Size = New System.Drawing.Size(75, 23)
        Me.buatbutdis.TabIndex = 19
        Me.buatbutdis.Text = "Buat"
        Me.buatbutdis.UseVisualStyleBackColor = True
        '
        'hapusbutdis
        '
        Me.hapusbutdis.Location = New System.Drawing.Point(190, 259)
        Me.hapusbutdis.Name = "hapusbutdis"
        Me.hapusbutdis.Size = New System.Drawing.Size(75, 23)
        Me.hapusbutdis.TabIndex = 21
        Me.hapusbutdis.Text = "Hapus"
        Me.hapusbutdis.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Jumlah Diskon"
        '
        'jumlahdiskon
        '
        Me.jumlahdiskon.Location = New System.Drawing.Point(120, 153)
        Me.jumlahdiskon.Name = "jumlahdiskon"
        Me.jumlahdiskon.Size = New System.Drawing.Size(208, 20)
        Me.jumlahdiskon.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(347, 118)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(328, 164)
        Me.DataGridView1.TabIndex = 27
        '
        'Kembali
        '
        Me.Kembali.Location = New System.Drawing.Point(-4, 40)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(106, 23)
        Me.Kembali.TabIndex = 30
        Me.Kembali.Text = "Start Page"
        Me.Kembali.UseVisualStyleBackColor = True
        '
        'startdatedis
        '
        Me.startdatedis.Enabled = False
        Me.startdatedis.Location = New System.Drawing.Point(120, 188)
        Me.startdatedis.Name = "startdatedis"
        Me.startdatedis.Size = New System.Drawing.Size(208, 20)
        Me.startdatedis.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Expired Date"
        '
        'namabardis
        '
        Me.namabardis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.namabardis.FormattingEnabled = True
        Me.namabardis.Location = New System.Drawing.Point(120, 118)
        Me.namabardis.Name = "namabardis"
        Me.namabardis.Size = New System.Drawing.Size(208, 21)
        Me.namabardis.TabIndex = 31
        '
        'expiredatadis
        '
        Me.expiredatadis.Location = New System.Drawing.Point(120, 221)
        Me.expiredatadis.Name = "expiredatadis"
        Me.expiredatadis.Size = New System.Drawing.Size(208, 20)
        Me.expiredatadis.TabIndex = 32
        '
        'DiskonTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 292)
        Me.Controls.Add(Me.expiredatadis)
        Me.Controls.Add(Me.namabardis)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.buatbutdis)
        Me.Controls.Add(Me.hapusbutdis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.startdatedis)
        Me.Controls.Add(Me.jumlahdiskon)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "DiskonTransaksi"
        Me.Text = "DiskonTransaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buatbutdis As Button
    Friend WithEvents hapusbutdis As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents jumlahdiskon As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Kembali As Button
    Friend WithEvents startdatedis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents namabardis As ComboBox
    Friend WithEvents expiredatadis As DateTimePicker
End Class
