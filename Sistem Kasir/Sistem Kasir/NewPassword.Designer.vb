<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPassword
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
        Me.ganti = New System.Windows.Forms.Button()
        Me.newpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.See4 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 27)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "New Password"
        '
        'ganti
        '
        Me.ganti.Location = New System.Drawing.Point(137, 143)
        Me.ganti.Name = "ganti"
        Me.ganti.Size = New System.Drawing.Size(75, 23)
        Me.ganti.TabIndex = 2
        Me.ganti.Text = "Ganti"
        Me.ganti.UseVisualStyleBackColor = True
        '
        'newpass
        '
        Me.newpass.Location = New System.Drawing.Point(122, 108)
        Me.newpass.Name = "newpass"
        Me.newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpass.Size = New System.Drawing.Size(187, 20)
        Me.newpass.TabIndex = 1
        Me.newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(180, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Password Baru"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'See4
        '
        Me.See4.AutoSize = True
        Me.See4.Location = New System.Drawing.Point(315, 111)
        Me.See4.Name = "See4"
        Me.See4.Size = New System.Drawing.Size(15, 14)
        Me.See4.TabIndex = 0
        Me.See4.UseVisualStyleBackColor = True
        '
        'NewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 185)
        Me.Controls.Add(Me.See4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ganti)
        Me.Controls.Add(Me.newpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "NewPassword"
        Me.Text = "NewPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents ganti As Button
    Friend WithEvents newpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents See4 As CheckBox
End Class
