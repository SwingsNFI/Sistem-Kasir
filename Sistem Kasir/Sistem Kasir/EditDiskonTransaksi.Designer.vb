<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDiskonTransaksi
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.idmaksud3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.canceleditadbar = New System.Windows.Forms.Button()
        Me.editadkar2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.expiredatadisdit = New System.Windows.Forms.DateTimePicker()
        Me.namabardisdit = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jumlahdiskondit = New System.Windows.Forms.TextBox()
        Me.startdatedisdit = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(548, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 14)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Untuk Admin"
        '
        'idmaksud3
        '
        Me.idmaksud3.Location = New System.Drawing.Point(421, 113)
        Me.idmaksud3.MaxLength = 6
        Me.idmaksud3.Name = "idmaksud3"
        Me.idmaksud3.Size = New System.Drawing.Size(99, 20)
        Me.idmaksud3.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ID yang dimaksud"
        '
        'canceleditadbar
        '
        Me.canceleditadbar.Location = New System.Drawing.Point(482, 151)
        Me.canceleditadbar.Name = "canceleditadbar"
        Me.canceleditadbar.Size = New System.Drawing.Size(75, 23)
        Me.canceleditadbar.TabIndex = 28
        Me.canceleditadbar.Text = "Cancel"
        Me.canceleditadbar.UseVisualStyleBackColor = True
        '
        'editadkar2
        '
        Me.editadkar2.Location = New System.Drawing.Point(386, 151)
        Me.editadkar2.Name = "editadkar2"
        Me.editadkar2.Size = New System.Drawing.Size(75, 23)
        Me.editadkar2.TabIndex = 27
        Me.editadkar2.Text = "Edit"
        Me.editadkar2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 27)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Edit Diskon Harga"
        '
        'expiredatadisdit
        '
        Me.expiredatadisdit.Location = New System.Drawing.Point(111, 155)
        Me.expiredatadisdit.Name = "expiredatadisdit"
        Me.expiredatadisdit.Size = New System.Drawing.Size(208, 20)
        Me.expiredatadisdit.TabIndex = 40
        '
        'namabardisdit
        '
        Me.namabardisdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.namabardisdit.FormattingEnabled = True
        Me.namabardisdit.Location = New System.Drawing.Point(111, 52)
        Me.namabardisdit.Name = "namabardisdit"
        Me.namabardisdit.Size = New System.Drawing.Size(208, 21)
        Me.namabardisdit.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Expired Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Jumlah Diskon"
        '
        'jumlahdiskondit
        '
        Me.jumlahdiskondit.Location = New System.Drawing.Point(111, 87)
        Me.jumlahdiskondit.Name = "jumlahdiskondit"
        Me.jumlahdiskondit.Size = New System.Drawing.Size(208, 20)
        Me.jumlahdiskondit.TabIndex = 34
        '
        'startdatedisdit
        '
        Me.startdatedisdit.Location = New System.Drawing.Point(111, 121)
        Me.startdatedisdit.Name = "startdatedisdit"
        Me.startdatedisdit.Size = New System.Drawing.Size(208, 20)
        Me.startdatedisdit.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(627, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(269, 195)
        Me.DataGridView1.TabIndex = 41
        '
        'EditDiskonTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 219)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.startdatedisdit)
        Me.Controls.Add(Me.expiredatadisdit)
        Me.Controls.Add(Me.namabardisdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jumlahdiskondit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.idmaksud3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.canceleditadbar)
        Me.Controls.Add(Me.editadkar2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditDiskonTransaksi"
        Me.Text = "EditDiskonTransaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents idmaksud3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents canceleditadbar As Button
    Friend WithEvents editadkar2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents expiredatadisdit As DateTimePicker
    Friend WithEvents namabardisdit As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents jumlahdiskondit As TextBox
    Friend WithEvents startdatedisdit As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
End Class
