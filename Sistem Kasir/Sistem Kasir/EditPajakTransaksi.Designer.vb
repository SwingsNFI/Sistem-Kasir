<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPajakTransaksi
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.idmaksud = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.canceleditadbar = New System.Windows.Forms.Button()
        Me.editadkar2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nicknamepajakdit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fullnamepajakdit = New System.Windows.Forms.TextBox()
        Me.jumlahpajakdit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(533, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 14)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Untuk Admin"
        '
        'idmaksud
        '
        Me.idmaksud.Location = New System.Drawing.Point(425, 93)
        Me.idmaksud.MaxLength = 6
        Me.idmaksud.Name = "idmaksud"
        Me.idmaksud.Size = New System.Drawing.Size(99, 20)
        Me.idmaksud.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(427, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ID yang dimaksud"
        '
        'canceleditadbar
        '
        Me.canceleditadbar.Location = New System.Drawing.Point(486, 131)
        Me.canceleditadbar.Name = "canceleditadbar"
        Me.canceleditadbar.Size = New System.Drawing.Size(75, 23)
        Me.canceleditadbar.TabIndex = 28
        Me.canceleditadbar.Text = "Cancel"
        Me.canceleditadbar.UseVisualStyleBackColor = True
        '
        'editadkar2
        '
        Me.editadkar2.Location = New System.Drawing.Point(390, 131)
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
        Me.Label1.Location = New System.Drawing.Point(358, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 27)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Edit Pajak Harga"
        '
        'nicknamepajakdit
        '
        Me.nicknamepajakdit.Location = New System.Drawing.Point(110, 52)
        Me.nicknamepajakdit.MaxLength = 39
        Me.nicknamepajakdit.Name = "nicknamepajakdit"
        Me.nicknamepajakdit.Size = New System.Drawing.Size(208, 20)
        Me.nicknamepajakdit.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nickname"
        '
        'fullnamepajakdit
        '
        Me.fullnamepajakdit.Location = New System.Drawing.Point(110, 87)
        Me.fullnamepajakdit.MaxLength = 39
        Me.fullnamepajakdit.Name = "fullnamepajakdit"
        Me.fullnamepajakdit.Size = New System.Drawing.Size(208, 20)
        Me.fullnamepajakdit.TabIndex = 32
        '
        'jumlahpajakdit
        '
        Me.jumlahpajakdit.Location = New System.Drawing.Point(110, 122)
        Me.jumlahpajakdit.MaxLength = 39
        Me.jumlahpajakdit.Name = "jumlahpajakdit"
        Me.jumlahpajakdit.Size = New System.Drawing.Size(208, 20)
        Me.jumlahpajakdit.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Full Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Jumlah Pajak"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(612, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(284, 160)
        Me.DataGridView1.TabIndex = 34
        '
        'EditPajakTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 184)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.jumlahpajakdit)
        Me.Controls.Add(Me.fullnamepajakdit)
        Me.Controls.Add(Me.nicknamepajakdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.idmaksud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.canceleditadbar)
        Me.Controls.Add(Me.editadkar2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditPajakTransaksi"
        Me.Text = "EditPajakTransaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents idmaksud As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents canceleditadbar As Button
    Friend WithEvents editadkar2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nicknamepajakdit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fullnamepajakdit As TextBox
    Friend WithEvents jumlahpajakdit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
