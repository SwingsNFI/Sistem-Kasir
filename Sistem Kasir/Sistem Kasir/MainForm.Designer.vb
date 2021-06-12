<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Karyawants = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.barangts = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BuatDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.diskonts = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BuatDataDiskonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDataDiskonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pajakts = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BuatDataPajakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDataPajakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.transaksits = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DataTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportts = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReportTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardReportTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BerdasarkanKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BerdasarkanIDTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.namakamu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Karyawants, Me.barangts, Me.diskonts, Me.pajakts, Me.transaksits, Me.reportts, Me.namakamu})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Karyawants
        '
        Me.Karyawants.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Karyawants.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.Karyawants.Image = CType(resources.GetObject("Karyawants.Image"), System.Drawing.Image)
        Me.Karyawants.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Karyawants.Name = "Karyawants"
        Me.Karyawants.Size = New System.Drawing.Size(71, 22)
        Me.Karyawants.Text = "Karyawan"
        Me.Karyawants.Visible = False
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.InsertToolStripMenuItem.Text = "Buat data karyawan"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EditToolStripMenuItem.Text = "Edit data karyawan"
        '
        'barangts
        '
        Me.barangts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.barangts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatDataBarangToolStripMenuItem, Me.EditDataBarangToolStripMenuItem})
        Me.barangts.Image = CType(resources.GetObject("barangts.Image"), System.Drawing.Image)
        Me.barangts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.barangts.Name = "barangts"
        Me.barangts.Size = New System.Drawing.Size(57, 22)
        Me.barangts.Text = "Barang"
        Me.barangts.Visible = False
        '
        'BuatDataBarangToolStripMenuItem
        '
        Me.BuatDataBarangToolStripMenuItem.Name = "BuatDataBarangToolStripMenuItem"
        Me.BuatDataBarangToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BuatDataBarangToolStripMenuItem.Text = "Buat data barang"
        '
        'EditDataBarangToolStripMenuItem
        '
        Me.EditDataBarangToolStripMenuItem.Name = "EditDataBarangToolStripMenuItem"
        Me.EditDataBarangToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditDataBarangToolStripMenuItem.Text = "Edit data barang"
        '
        'diskonts
        '
        Me.diskonts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.diskonts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatDataDiskonToolStripMenuItem, Me.EditDataDiskonToolStripMenuItem})
        Me.diskonts.Image = CType(resources.GetObject("diskonts.Image"), System.Drawing.Image)
        Me.diskonts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.diskonts.Name = "diskonts"
        Me.diskonts.Size = New System.Drawing.Size(56, 22)
        Me.diskonts.Text = "Diskon"
        Me.diskonts.Visible = False
        '
        'BuatDataDiskonToolStripMenuItem
        '
        Me.BuatDataDiskonToolStripMenuItem.Name = "BuatDataDiskonToolStripMenuItem"
        Me.BuatDataDiskonToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BuatDataDiskonToolStripMenuItem.Text = "Buat data diskon"
        '
        'EditDataDiskonToolStripMenuItem
        '
        Me.EditDataDiskonToolStripMenuItem.Name = "EditDataDiskonToolStripMenuItem"
        Me.EditDataDiskonToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EditDataDiskonToolStripMenuItem.Text = "Edit data diskon"
        '
        'pajakts
        '
        Me.pajakts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.pajakts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatDataPajakToolStripMenuItem, Me.EditDataPajakToolStripMenuItem})
        Me.pajakts.Image = CType(resources.GetObject("pajakts.Image"), System.Drawing.Image)
        Me.pajakts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pajakts.Name = "pajakts"
        Me.pajakts.Size = New System.Drawing.Size(48, 22)
        Me.pajakts.Text = "Pajak"
        Me.pajakts.Visible = False
        '
        'BuatDataPajakToolStripMenuItem
        '
        Me.BuatDataPajakToolStripMenuItem.Name = "BuatDataPajakToolStripMenuItem"
        Me.BuatDataPajakToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BuatDataPajakToolStripMenuItem.Text = "Buat data pajak"
        '
        'EditDataPajakToolStripMenuItem
        '
        Me.EditDataPajakToolStripMenuItem.Name = "EditDataPajakToolStripMenuItem"
        Me.EditDataPajakToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EditDataPajakToolStripMenuItem.Text = "Edit data pajak"
        '
        'transaksits
        '
        Me.transaksits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.transaksits.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataTransaksiToolStripMenuItem})
        Me.transaksits.Image = CType(resources.GetObject("transaksits.Image"), System.Drawing.Image)
        Me.transaksits.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.transaksits.Name = "transaksits"
        Me.transaksits.Size = New System.Drawing.Size(68, 22)
        Me.transaksits.Text = "Transaksi"
        Me.transaksits.Visible = False
        '
        'DataTransaksiToolStripMenuItem
        '
        Me.DataTransaksiToolStripMenuItem.Name = "DataTransaksiToolStripMenuItem"
        Me.DataTransaksiToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DataTransaksiToolStripMenuItem.Text = "Data transaksi"
        '
        'reportts
        '
        Me.reportts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.reportts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportTransaksiToolStripMenuItem, Me.ReportKaryawanToolStripMenuItem, Me.ReportBarangToolStripMenuItem})
        Me.reportts.Image = CType(resources.GetObject("reportts.Image"), System.Drawing.Image)
        Me.reportts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.reportts.Name = "reportts"
        Me.reportts.Size = New System.Drawing.Size(55, 22)
        Me.reportts.Text = "Report"
        Me.reportts.Visible = False
        '
        'ReportTransaksiToolStripMenuItem
        '
        Me.ReportTransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardReportTransaksiToolStripMenuItem, Me.BerdasarkanKasirToolStripMenuItem, Me.BerdasarkanIDTransaksiToolStripMenuItem})
        Me.ReportTransaksiToolStripMenuItem.Name = "ReportTransaksiToolStripMenuItem"
        Me.ReportTransaksiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportTransaksiToolStripMenuItem.Text = "Report transaksi"
        '
        'StandardReportTransaksiToolStripMenuItem
        '
        Me.StandardReportTransaksiToolStripMenuItem.Name = "StandardReportTransaksiToolStripMenuItem"
        Me.StandardReportTransaksiToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.StandardReportTransaksiToolStripMenuItem.Text = "Standard report transaksi"
        '
        'BerdasarkanKasirToolStripMenuItem
        '
        Me.BerdasarkanKasirToolStripMenuItem.Name = "BerdasarkanKasirToolStripMenuItem"
        Me.BerdasarkanKasirToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.BerdasarkanKasirToolStripMenuItem.Text = "Berdasarkan kasir"
        '
        'BerdasarkanIDTransaksiToolStripMenuItem
        '
        Me.BerdasarkanIDTransaksiToolStripMenuItem.Name = "BerdasarkanIDTransaksiToolStripMenuItem"
        Me.BerdasarkanIDTransaksiToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.BerdasarkanIDTransaksiToolStripMenuItem.Text = "Berdasarkan ID transaksi"
        '
        'ReportKaryawanToolStripMenuItem
        '
        Me.ReportKaryawanToolStripMenuItem.Name = "ReportKaryawanToolStripMenuItem"
        Me.ReportKaryawanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportKaryawanToolStripMenuItem.Text = "Report karyawan"
        '
        'ReportBarangToolStripMenuItem
        '
        Me.ReportBarangToolStripMenuItem.Name = "ReportBarangToolStripMenuItem"
        Me.ReportBarangToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportBarangToolStripMenuItem.Text = "Report barang"
        '
        'namakamu
        '
        Me.namakamu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.namakamu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.namakamu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.namakamu.Image = CType(resources.GetObject("namakamu.Image"), System.Drawing.Image)
        Me.namakamu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.namakamu.Name = "namakamu"
        Me.namakamu.Size = New System.Drawing.Size(58, 22)
        Me.namakamu.Text = "(nama)"
        Me.namakamu.Visible = False
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Karyawants As ToolStripDropDownButton
    Friend WithEvents barangts As ToolStripDropDownButton
    Friend WithEvents transaksits As ToolStripDropDownButton
    Friend WithEvents reportts As ToolStripDropDownButton
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StandardReportTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BerdasarkanKasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BerdasarkanIDTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents namakamu As ToolStripDropDownButton
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents diskonts As ToolStripDropDownButton
    Friend WithEvents BuatDataDiskonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDataDiskonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pajakts As ToolStripDropDownButton
    Friend WithEvents BuatDataPajakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDataPajakToolStripMenuItem As ToolStripMenuItem
End Class
