<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllofReport
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.startpage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(171, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 93)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Karyawan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "All of Report"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 93)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Barang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(282, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 93)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Transaksi"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'startpage
        '
        Me.startpage.Location = New System.Drawing.Point(170, 198)
        Me.startpage.Name = "startpage"
        Me.startpage.Size = New System.Drawing.Size(106, 23)
        Me.startpage.TabIndex = 16
        Me.startpage.Text = "Start Page"
        Me.startpage.UseVisualStyleBackColor = True
        '
        'AllofReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 219)
        Me.Controls.Add(Me.startpage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "AllofReport"
        Me.Text = "AllofReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents startpage As Button
End Class
