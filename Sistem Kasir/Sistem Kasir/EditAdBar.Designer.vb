<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAdBar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.idmaksud2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.canceleditadbar = New System.Windows.Forms.Button()
        Me.editadbar2 = New System.Windows.Forms.Button()
        Me.namaeditadbar = New System.Windows.Forms.TextBox()
        Me.hargaeditadbar = New System.Windows.Forms.TextBox()
        Me.jumlaheditadbar = New System.Windows.Forms.TextBox()
        Me.pteditadbar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tgleditadbar = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(497, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 14)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Untuk Admin"
        '
        'idmaksud2
        '
        Me.idmaksud2.Location = New System.Drawing.Point(421, 116)
        Me.idmaksud2.MaxLength = 6
        Me.idmaksud2.Name = "idmaksud2"
        Me.idmaksud2.Size = New System.Drawing.Size(99, 20)
        Me.idmaksud2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ID yang dimaksud"
        '
        'canceleditadbar
        '
        Me.canceleditadbar.Location = New System.Drawing.Point(482, 154)
        Me.canceleditadbar.Name = "canceleditadbar"
        Me.canceleditadbar.Size = New System.Drawing.Size(75, 23)
        Me.canceleditadbar.TabIndex = 8
        Me.canceleditadbar.Text = "Cancel"
        Me.canceleditadbar.UseVisualStyleBackColor = True
        '
        'editadbar2
        '
        Me.editadbar2.Location = New System.Drawing.Point(386, 154)
        Me.editadbar2.Name = "editadbar2"
        Me.editadbar2.Size = New System.Drawing.Size(75, 23)
        Me.editadbar2.TabIndex = 7
        Me.editadbar2.Text = "Edit"
        Me.editadbar2.UseVisualStyleBackColor = True
        '
        'namaeditadbar
        '
        Me.namaeditadbar.Location = New System.Drawing.Point(113, 40)
        Me.namaeditadbar.MaxLength = 19
        Me.namaeditadbar.Name = "namaeditadbar"
        Me.namaeditadbar.Size = New System.Drawing.Size(208, 20)
        Me.namaeditadbar.TabIndex = 2
        '
        'hargaeditadbar
        '
        Me.hargaeditadbar.Location = New System.Drawing.Point(113, 75)
        Me.hargaeditadbar.MaxLength = 10
        Me.hargaeditadbar.Name = "hargaeditadbar"
        Me.hargaeditadbar.Size = New System.Drawing.Size(208, 20)
        Me.hargaeditadbar.TabIndex = 3
        '
        'jumlaheditadbar
        '
        Me.jumlaheditadbar.Location = New System.Drawing.Point(113, 110)
        Me.jumlaheditadbar.MaxLength = 10
        Me.jumlaheditadbar.Name = "jumlaheditadbar"
        Me.jumlaheditadbar.Size = New System.Drawing.Size(208, 20)
        Me.jumlaheditadbar.TabIndex = 4
        '
        'pteditadbar
        '
        Me.pteditadbar.Location = New System.Drawing.Point(113, 145)
        Me.pteditadbar.MaxLength = 39
        Me.pteditadbar.Name = "pteditadbar"
        Me.pteditadbar.Size = New System.Drawing.Size(208, 20)
        Me.pteditadbar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "PT Pembuat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Tanggal Barang"
        '
        'tgleditadbar
        '
        Me.tgleditadbar.Location = New System.Drawing.Point(113, 183)
        Me.tgleditadbar.Name = "tgleditadbar"
        Me.tgleditadbar.Size = New System.Drawing.Size(208, 20)
        Me.tgleditadbar.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(576, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 214)
        Me.DataGridView1.TabIndex = 33
        '
        'EditAdBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 238)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tgleditadbar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pteditadbar)
        Me.Controls.Add(Me.jumlaheditadbar)
        Me.Controls.Add(Me.hargaeditadbar)
        Me.Controls.Add(Me.namaeditadbar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.idmaksud2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.canceleditadbar)
        Me.Controls.Add(Me.editadbar2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditAdBar"
        Me.Text = "EditAdBar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents idmaksud2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents canceleditadbar As Button
    Friend WithEvents editadbar2 As Button
    Friend WithEvents namaeditadbar As TextBox
    Friend WithEvents hargaeditadbar As TextBox
    Friend WithEvents jumlaheditadbar As TextBox
    Friend WithEvents pteditadbar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tgleditadbar As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
End Class
