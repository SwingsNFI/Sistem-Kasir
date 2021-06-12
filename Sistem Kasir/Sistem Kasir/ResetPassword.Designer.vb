<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResetPassword
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idreset = New System.Windows.Forms.TextBox()
        Me.Pkeamanan = New System.Windows.Forms.GroupBox()
        Me.pertanyaanreset2 = New System.Windows.Forms.TextBox()
        Me.pertanyaanreset1 = New System.Windows.Forms.TextBox()
        Me.jawabanreset2 = New System.Windows.Forms.TextBox()
        Me.jawabanreset1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buka = New System.Windows.Forms.Button()
        Me.resetpass = New System.Windows.Forms.Button()
        Me.cancelreset = New System.Windows.Forms.Button()
        Me.Pkeamanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Reset Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(217, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID"
        '
        'idreset
        '
        Me.idreset.Location = New System.Drawing.Point(120, 113)
        Me.idreset.Name = "idreset"
        Me.idreset.Size = New System.Drawing.Size(208, 20)
        Me.idreset.TabIndex = 1
        Me.idreset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pkeamanan
        '
        Me.Pkeamanan.Controls.Add(Me.pertanyaanreset2)
        Me.Pkeamanan.Controls.Add(Me.pertanyaanreset1)
        Me.Pkeamanan.Controls.Add(Me.jawabanreset2)
        Me.Pkeamanan.Controls.Add(Me.jawabanreset1)
        Me.Pkeamanan.Controls.Add(Me.Label13)
        Me.Pkeamanan.Controls.Add(Me.Label12)
        Me.Pkeamanan.Controls.Add(Me.Label11)
        Me.Pkeamanan.Controls.Add(Me.Label3)
        Me.Pkeamanan.Location = New System.Drawing.Point(12, 186)
        Me.Pkeamanan.Name = "Pkeamanan"
        Me.Pkeamanan.Size = New System.Drawing.Size(428, 176)
        Me.Pkeamanan.TabIndex = 30
        Me.Pkeamanan.TabStop = False
        Me.Pkeamanan.Text = "Pertanyaan Keamanan"
        '
        'pertanyaanreset2
        '
        Me.pertanyaanreset2.Enabled = False
        Me.pertanyaanreset2.Location = New System.Drawing.Point(105, 104)
        Me.pertanyaanreset2.Name = "pertanyaanreset2"
        Me.pertanyaanreset2.Size = New System.Drawing.Size(317, 20)
        Me.pertanyaanreset2.TabIndex = 0
        '
        'pertanyaanreset1
        '
        Me.pertanyaanreset1.Enabled = False
        Me.pertanyaanreset1.Location = New System.Drawing.Point(105, 32)
        Me.pertanyaanreset1.Name = "pertanyaanreset1"
        Me.pertanyaanreset1.Size = New System.Drawing.Size(317, 20)
        Me.pertanyaanreset1.TabIndex = 0
        '
        'jawabanreset2
        '
        Me.jawabanreset2.Location = New System.Drawing.Point(105, 141)
        Me.jawabanreset2.Name = "jawabanreset2"
        Me.jawabanreset2.Size = New System.Drawing.Size(317, 20)
        Me.jawabanreset2.TabIndex = 4
        '
        'jawabanreset1
        '
        Me.jawabanreset1.Location = New System.Drawing.Point(105, 69)
        Me.jawabanreset1.Name = "jawabanreset1"
        Me.jawabanreset1.Size = New System.Drawing.Size(317, 20)
        Me.jawabanreset1.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Jawaban #2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Pertanyaan #2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Jawaban #1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Pertanyaan #1"
        '
        'buka
        '
        Me.buka.Location = New System.Drawing.Point(190, 148)
        Me.buka.Name = "buka"
        Me.buka.Size = New System.Drawing.Size(75, 23)
        Me.buka.TabIndex = 2
        Me.buka.Text = "Buka"
        Me.buka.UseVisualStyleBackColor = True
        '
        'resetpass
        '
        Me.resetpass.Location = New System.Drawing.Point(132, 368)
        Me.resetpass.Name = "resetpass"
        Me.resetpass.Size = New System.Drawing.Size(75, 23)
        Me.resetpass.TabIndex = 5
        Me.resetpass.Text = "Reset"
        Me.resetpass.UseVisualStyleBackColor = True
        '
        'cancelreset
        '
        Me.cancelreset.Location = New System.Drawing.Point(247, 368)
        Me.cancelreset.Name = "cancelreset"
        Me.cancelreset.Size = New System.Drawing.Size(75, 23)
        Me.cancelreset.TabIndex = 6
        Me.cancelreset.Text = "Cancel"
        Me.cancelreset.UseVisualStyleBackColor = True
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 406)
        Me.Controls.Add(Me.cancelreset)
        Me.Controls.Add(Me.resetpass)
        Me.Controls.Add(Me.buka)
        Me.Controls.Add(Me.Pkeamanan)
        Me.Controls.Add(Me.idreset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "ResetPassword"
        Me.Text = "ResetPassword"
        Me.Pkeamanan.ResumeLayout(False)
        Me.Pkeamanan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents idreset As TextBox
    Friend WithEvents Pkeamanan As GroupBox
    Friend WithEvents jawabanreset2 As TextBox
    Friend WithEvents jawabanreset1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents buka As Button
    Friend WithEvents resetpass As Button
    Friend WithEvents cancelreset As Button
    Friend WithEvents pertanyaanreset2 As TextBox
    Friend WithEvents pertanyaanreset1 As TextBox
End Class
