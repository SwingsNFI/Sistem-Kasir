<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PajakTransaksi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jumlahpajak = New System.Windows.Forms.TextBox()
        Me.fullnamepajak = New System.Windows.Forms.TextBox()
        Me.buatbutdis = New System.Windows.Forms.Button()
        Me.hapusbutdis = New System.Windows.Forms.Button()
        Me.nicknamepajak = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(391, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Untuk Admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(271, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 27)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Pajak Harga"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(347, 127)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(328, 128)
        Me.DataGridView1.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Jumlah Pajak"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Nickname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Full Name"
        '
        'jumlahpajak
        '
        Me.jumlahpajak.Location = New System.Drawing.Point(123, 197)
        Me.jumlahpajak.Name = "jumlahpajak"
        Me.jumlahpajak.Size = New System.Drawing.Size(208, 20)
        Me.jumlahpajak.TabIndex = 32
        '
        'fullnamepajak
        '
        Me.fullnamepajak.Location = New System.Drawing.Point(123, 162)
        Me.fullnamepajak.Name = "fullnamepajak"
        Me.fullnamepajak.Size = New System.Drawing.Size(208, 20)
        Me.fullnamepajak.TabIndex = 33
        '
        'buatbutdis
        '
        Me.buatbutdis.Location = New System.Drawing.Point(94, 232)
        Me.buatbutdis.Name = "buatbutdis"
        Me.buatbutdis.Size = New System.Drawing.Size(75, 23)
        Me.buatbutdis.TabIndex = 38
        Me.buatbutdis.Text = "Buat"
        Me.buatbutdis.UseVisualStyleBackColor = True
        '
        'hapusbutdis
        '
        Me.hapusbutdis.Location = New System.Drawing.Point(199, 232)
        Me.hapusbutdis.Name = "hapusbutdis"
        Me.hapusbutdis.Size = New System.Drawing.Size(75, 23)
        Me.hapusbutdis.TabIndex = 39
        Me.hapusbutdis.Text = "Hapus"
        Me.hapusbutdis.UseVisualStyleBackColor = True
        '
        'nicknamepajak
        '
        Me.nicknamepajak.Location = New System.Drawing.Point(123, 127)
        Me.nicknamepajak.Name = "nicknamepajak"
        Me.nicknamepajak.Size = New System.Drawing.Size(208, 20)
        Me.nicknamepajak.TabIndex = 33
        '
        'PajakTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 267)
        Me.Controls.Add(Me.buatbutdis)
        Me.Controls.Add(Me.hapusbutdis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jumlahpajak)
        Me.Controls.Add(Me.nicknamepajak)
        Me.Controls.Add(Me.fullnamepajak)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "PajakTransaksi"
        Me.Text = "PajakTransaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents jumlahpajak As TextBox
    Friend WithEvents fullnamepajak As TextBox
    Friend WithEvents buatbutdis As Button
    Friend WithEvents hapusbutdis As Button
    Friend WithEvents nicknamepajak As TextBox
End Class
