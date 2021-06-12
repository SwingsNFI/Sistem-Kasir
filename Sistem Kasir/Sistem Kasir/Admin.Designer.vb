<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.KarBut = New System.Windows.Forms.Button()
        Me.BarBut = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.reportadmin = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Form"
        '
        'KarBut
        '
        Me.KarBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KarBut.Location = New System.Drawing.Point(130, 104)
        Me.KarBut.Name = "KarBut"
        Me.KarBut.Size = New System.Drawing.Size(136, 112)
        Me.KarBut.TabIndex = 1
        Me.KarBut.Text = "Karyawan"
        Me.KarBut.UseVisualStyleBackColor = True
        '
        'BarBut
        '
        Me.BarBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarBut.Location = New System.Drawing.Point(300, 104)
        Me.BarBut.Name = "BarBut"
        Me.BarBut.Size = New System.Drawing.Size(136, 112)
        Me.BarBut.TabIndex = 2
        Me.BarBut.Text = "Barang"
        Me.BarBut.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(245, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 46)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Transaksi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'reportadmin
        '
        Me.reportadmin.Location = New System.Drawing.Point(287, 245)
        Me.reportadmin.Name = "reportadmin"
        Me.reportadmin.Size = New System.Drawing.Size(75, 46)
        Me.reportadmin.TabIndex = 5
        Me.reportadmin.Text = "Report"
        Me.reportadmin.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(404, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 290)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.reportadmin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BarBut)
        Me.Controls.Add(Me.KarBut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents KarBut As Button
    Friend WithEvents BarBut As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents reportadmin As Button
    Friend WithEvents Button3 As Button
End Class
