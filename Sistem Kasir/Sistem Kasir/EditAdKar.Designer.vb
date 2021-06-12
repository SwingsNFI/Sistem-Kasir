<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditAdKar
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
        Me.jkeditadkar = New System.Windows.Forms.ComboBox()
        Me.emaileditadkar = New System.Windows.Forms.TextBox()
        Me.noteleditadkar = New System.Windows.Forms.TextBox()
        Me.namaeditadkar = New System.Windows.Forms.TextBox()
        Me.passeditadkar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.editadkar2 = New System.Windows.Forms.Button()
        Me.canceleditadbar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idmaksud = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.jabeditadkar = New System.Windows.Forms.ComboBox()
        Me.See3 = New System.Windows.Forms.CheckBox()
        Me.tgleditadkar = New System.Windows.Forms.DateTimePicker()
        Me.pertanyaanedit2 = New System.Windows.Forms.ComboBox()
        Me.jawabanedit2 = New System.Windows.Forms.TextBox()
        Me.pertanyaanedit1 = New System.Windows.Forms.ComboBox()
        Me.jawabanedit1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jkeditadkar
        '
        Me.jkeditadkar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jkeditadkar.FormattingEnabled = True
        Me.jkeditadkar.Location = New System.Drawing.Point(113, 123)
        Me.jkeditadkar.Name = "jkeditadkar"
        Me.jkeditadkar.Size = New System.Drawing.Size(208, 21)
        Me.jkeditadkar.TabIndex = 5
        '
        'emaileditadkar
        '
        Me.emaileditadkar.Location = New System.Drawing.Point(113, 229)
        Me.emaileditadkar.MaxLength = 39
        Me.emaileditadkar.Name = "emaileditadkar"
        Me.emaileditadkar.Size = New System.Drawing.Size(208, 20)
        Me.emaileditadkar.TabIndex = 8
        '
        'noteleditadkar
        '
        Me.noteleditadkar.Location = New System.Drawing.Point(113, 159)
        Me.noteleditadkar.MaxLength = 14
        Me.noteleditadkar.Name = "noteleditadkar"
        Me.noteleditadkar.Size = New System.Drawing.Size(208, 20)
        Me.noteleditadkar.TabIndex = 6
        '
        'namaeditadkar
        '
        Me.namaeditadkar.Location = New System.Drawing.Point(113, 18)
        Me.namaeditadkar.MaxLength = 39
        Me.namaeditadkar.Name = "namaeditadkar"
        Me.namaeditadkar.Size = New System.Drawing.Size(208, 20)
        Me.namaeditadkar.TabIndex = 2
        '
        'passeditadkar
        '
        Me.passeditadkar.Location = New System.Drawing.Point(113, 53)
        Me.passeditadkar.MaxLength = 19
        Me.passeditadkar.Name = "passeditadkar"
        Me.passeditadkar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passeditadkar.Size = New System.Drawing.Size(187, 20)
        Me.passeditadkar.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Jabatan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nomor Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 27)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Edit Karyawan"
        '
        'editadkar2
        '
        Me.editadkar2.Location = New System.Drawing.Point(386, 243)
        Me.editadkar2.Name = "editadkar2"
        Me.editadkar2.Size = New System.Drawing.Size(75, 23)
        Me.editadkar2.TabIndex = 13
        Me.editadkar2.Text = "Edit"
        Me.editadkar2.UseVisualStyleBackColor = True
        '
        'canceleditadbar
        '
        Me.canceleditadbar.Location = New System.Drawing.Point(482, 243)
        Me.canceleditadbar.Name = "canceleditadbar"
        Me.canceleditadbar.Size = New System.Drawing.Size(75, 23)
        Me.canceleditadbar.TabIndex = 14
        Me.canceleditadbar.Text = "Cancel"
        Me.canceleditadbar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ID yang dimaksud"
        '
        'idmaksud
        '
        Me.idmaksud.Location = New System.Drawing.Point(421, 205)
        Me.idmaksud.MaxLength = 6
        Me.idmaksud.Name = "idmaksud"
        Me.idmaksud.Size = New System.Drawing.Size(99, 20)
        Me.idmaksud.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(529, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 14)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Untuk Admin"
        '
        'jabeditadkar
        '
        Me.jabeditadkar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jabeditadkar.FormattingEnabled = True
        Me.jabeditadkar.Location = New System.Drawing.Point(113, 194)
        Me.jabeditadkar.Name = "jabeditadkar"
        Me.jabeditadkar.Size = New System.Drawing.Size(208, 21)
        Me.jabeditadkar.TabIndex = 7
        '
        'See3
        '
        Me.See3.AutoSize = True
        Me.See3.Location = New System.Drawing.Point(306, 56)
        Me.See3.Name = "See3"
        Me.See3.Size = New System.Drawing.Size(15, 14)
        Me.See3.TabIndex = 0
        Me.See3.UseVisualStyleBackColor = True
        '
        'tgleditadkar
        '
        Me.tgleditadkar.Location = New System.Drawing.Point(113, 87)
        Me.tgleditadkar.Name = "tgleditadkar"
        Me.tgleditadkar.Size = New System.Drawing.Size(208, 20)
        Me.tgleditadkar.TabIndex = 4
        '
        'pertanyaanedit2
        '
        Me.pertanyaanedit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pertanyaanedit2.FormattingEnabled = True
        Me.pertanyaanedit2.Location = New System.Drawing.Point(113, 336)
        Me.pertanyaanedit2.Name = "pertanyaanedit2"
        Me.pertanyaanedit2.Size = New System.Drawing.Size(208, 21)
        Me.pertanyaanedit2.TabIndex = 11
        '
        'jawabanedit2
        '
        Me.jawabanedit2.Location = New System.Drawing.Point(113, 373)
        Me.jawabanedit2.Name = "jawabanedit2"
        Me.jawabanedit2.Size = New System.Drawing.Size(208, 20)
        Me.jawabanedit2.TabIndex = 12
        '
        'pertanyaanedit1
        '
        Me.pertanyaanedit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pertanyaanedit1.FormattingEnabled = True
        Me.pertanyaanedit1.Location = New System.Drawing.Point(113, 264)
        Me.pertanyaanedit1.Name = "pertanyaanedit1"
        Me.pertanyaanedit1.Size = New System.Drawing.Size(208, 21)
        Me.pertanyaanedit1.TabIndex = 9
        '
        'jawabanedit1
        '
        Me.jawabanedit1.Location = New System.Drawing.Point(113, 301)
        Me.jawabanedit1.Name = "jawabanedit1"
        Me.jawabanedit1.Size = New System.Drawing.Size(208, 20)
        Me.jawabanedit1.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Jawaban #2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Pertanyaan #2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Jawaban #1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Pertanyaan #1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(608, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(288, 377)
        Me.DataGridView1.TabIndex = 37
        '
        'EditAdKar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 410)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pertanyaanedit2)
        Me.Controls.Add(Me.jawabanedit2)
        Me.Controls.Add(Me.pertanyaanedit1)
        Me.Controls.Add(Me.jawabanedit1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tgleditadkar)
        Me.Controls.Add(Me.See3)
        Me.Controls.Add(Me.jabeditadkar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.idmaksud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.canceleditadbar)
        Me.Controls.Add(Me.editadkar2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jkeditadkar)
        Me.Controls.Add(Me.emaileditadkar)
        Me.Controls.Add(Me.noteleditadkar)
        Me.Controls.Add(Me.namaeditadkar)
        Me.Controls.Add(Me.passeditadkar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "EditAdKar"
        Me.Text = "EditAdKar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jkeditadkar As ComboBox
    Friend WithEvents emaileditadkar As TextBox
    Friend WithEvents noteleditadkar As TextBox
    Friend WithEvents namaeditadkar As TextBox
    Friend WithEvents passeditadkar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents editadkar2 As Button
    Friend WithEvents canceleditadbar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents idmaksud As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents jabeditadkar As ComboBox
    Friend WithEvents See3 As CheckBox
    Friend WithEvents tgleditadkar As DateTimePicker
    Friend WithEvents pertanyaanedit2 As ComboBox
    Friend WithEvents jawabanedit2 As TextBox
    Friend WithEvents pertanyaanedit1 As ComboBox
    Friend WithEvents jawabanedit1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
