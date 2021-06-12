<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportberdasarkanIDtransaksi
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
        Me.Reportbutt = New System.Windows.Forms.Button()
        Me.Pilihidtransaksi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reportbutt
        '
        Me.Reportbutt.Location = New System.Drawing.Point(198, 148)
        Me.Reportbutt.Name = "Reportbutt"
        Me.Reportbutt.Size = New System.Drawing.Size(75, 23)
        Me.Reportbutt.TabIndex = 10
        Me.Reportbutt.Text = "Report"
        Me.Reportbutt.UseVisualStyleBackColor = True
        '
        'Pilihidtransaksi
        '
        Me.Pilihidtransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Pilihidtransaksi.FormattingEnabled = True
        Me.Pilihidtransaksi.Location = New System.Drawing.Point(134, 112)
        Me.Pilihidtransaksi.Name = "Pilihidtransaksi"
        Me.Pilihidtransaksi.Size = New System.Drawing.Size(198, 21)
        Me.Pilihidtransaksi.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(210, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 40)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Berdasarkan IDTransaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Report"
        '
        'ReportberdasarkanIDtransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 199)
        Me.Controls.Add(Me.Reportbutt)
        Me.Controls.Add(Me.Pilihidtransaksi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReportberdasarkanIDtransaksi"
        Me.Text = "ReportberdasarkanIDkasir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Reportbutt As Button
    Friend WithEvents Pilihidtransaksi As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
