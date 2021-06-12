<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.logbut = New System.Windows.Forms.Button()
        Me.See2 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 50.0!)
        Me.Label1.Location = New System.Drawing.Point(595, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(184, 96)
        Me.ID.MaxLength = 10
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(169, 20)
        Me.ID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(184, 131)
        Me.Password.MaxLength = 19
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(150, 20)
        Me.Password.TabIndex = 2
        '
        'logbut
        '
        Me.logbut.Location = New System.Drawing.Point(183, 179)
        Me.logbut.Name = "logbut"
        Me.logbut.Size = New System.Drawing.Size(75, 23)
        Me.logbut.TabIndex = 3
        Me.logbut.Text = "Login"
        Me.logbut.UseVisualStyleBackColor = True
        '
        'See2
        '
        Me.See2.AutoSize = True
        Me.See2.Location = New System.Drawing.Point(340, 134)
        Me.See2.Name = "See2"
        Me.See2.Size = New System.Drawing.Size(15, 14)
        Me.See2.TabIndex = 17
        Me.See2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(269, 154)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 13)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Lupa Password?"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.See2)
        Me.Controls.Add(Me.logbut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents logbut As Button
    Friend WithEvents See2 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
