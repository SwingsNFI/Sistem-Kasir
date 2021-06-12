<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportberdasarkankasir
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pilihkasir = New System.Windows.Forms.ComboBox()
        Me.Reportbutt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Berdasarkan Kasir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(210, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 40)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kasir"
        '
        'Pilihkasir
        '
        Me.Pilihkasir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Pilihkasir.FormattingEnabled = True
        Me.Pilihkasir.Location = New System.Drawing.Point(134, 112)
        Me.Pilihkasir.Name = "Pilihkasir"
        Me.Pilihkasir.Size = New System.Drawing.Size(198, 21)
        Me.Pilihkasir.TabIndex = 4
        '
        'Reportbutt
        '
        Me.Reportbutt.Location = New System.Drawing.Point(198, 148)
        Me.Reportbutt.Name = "Reportbutt"
        Me.Reportbutt.Size = New System.Drawing.Size(75, 23)
        Me.Reportbutt.TabIndex = 5
        Me.Reportbutt.Text = "Report"
        Me.Reportbutt.UseVisualStyleBackColor = True
        '
        'Reportberdasarkankasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 199)
        Me.Controls.Add(Me.Reportbutt)
        Me.Controls.Add(Me.Pilihkasir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reportberdasarkankasir"
        Me.Text = "Reportberdasarkankasir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Pilihkasir As ComboBox
    Friend WithEvents Reportbutt As Button
End Class
