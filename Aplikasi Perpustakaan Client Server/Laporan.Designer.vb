<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabelBUKU = New System.Windows.Forms.DataGridView()
        Me.ButtonBUKU = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabelPENGGUNA = New System.Windows.Forms.DataGridView()
        Me.ButtonPENGGUNA = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabelPEMINJAMAN = New System.Windows.Forms.DataGridView()
        Me.ButtonPEMINJAMAN = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabelPENGEMBALIAN = New System.Windows.Forms.DataGridView()
        Me.ButtonPENGEMBALIAN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TabelBUKU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TabelPENGGUNA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.TabelPEMINJAMAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.TabelPENGEMBALIAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 44)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(677, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 44)
        Me.Panel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_gtk_refresh_29878
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(37, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "   REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 524)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabelBUKU)
        Me.TabPage1.Controls.Add(Me.ButtonBUKU)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(857, 496)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Laporan Data Buku"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabelBUKU
        '
        Me.TabelBUKU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabelBUKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelBUKU.Location = New System.Drawing.Point(30, 94)
        Me.TabelBUKU.Name = "TabelBUKU"
        Me.TabelBUKU.Size = New System.Drawing.Size(819, 394)
        Me.TabelBUKU.TabIndex = 1
        '
        'ButtonBUKU
        '
        Me.ButtonBUKU.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBUKU.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_export_24_46622
        Me.ButtonBUKU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBUKU.Location = New System.Drawing.Point(30, 18)
        Me.ButtonBUKU.Name = "ButtonBUKU"
        Me.ButtonBUKU.Size = New System.Drawing.Size(225, 59)
        Me.ButtonBUKU.TabIndex = 0
        Me.ButtonBUKU.Text = "EXPORT TO EXCEL"
        Me.ButtonBUKU.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabelPENGGUNA)
        Me.TabPage2.Controls.Add(Me.ButtonPENGGUNA)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(857, 496)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Laporan Data Pengguna"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabelPENGGUNA
        '
        Me.TabelPENGGUNA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabelPENGGUNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelPENGGUNA.Location = New System.Drawing.Point(19, 89)
        Me.TabelPENGGUNA.Name = "TabelPENGGUNA"
        Me.TabelPENGGUNA.Size = New System.Drawing.Size(819, 394)
        Me.TabelPENGGUNA.TabIndex = 3
        '
        'ButtonPENGGUNA
        '
        Me.ButtonPENGGUNA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPENGGUNA.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_export_24_46622
        Me.ButtonPENGGUNA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPENGGUNA.Location = New System.Drawing.Point(19, 13)
        Me.ButtonPENGGUNA.Name = "ButtonPENGGUNA"
        Me.ButtonPENGGUNA.Size = New System.Drawing.Size(225, 59)
        Me.ButtonPENGGUNA.TabIndex = 2
        Me.ButtonPENGGUNA.Text = "EXPORT TO EXCEL"
        Me.ButtonPENGGUNA.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TabelPEMINJAMAN)
        Me.TabPage3.Controls.Add(Me.ButtonPEMINJAMAN)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(857, 496)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Laporan PEMINJAMAN"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabelPEMINJAMAN
        '
        Me.TabelPEMINJAMAN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabelPEMINJAMAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelPEMINJAMAN.Location = New System.Drawing.Point(19, 89)
        Me.TabelPEMINJAMAN.Name = "TabelPEMINJAMAN"
        Me.TabelPEMINJAMAN.Size = New System.Drawing.Size(819, 394)
        Me.TabelPEMINJAMAN.TabIndex = 3
        '
        'ButtonPEMINJAMAN
        '
        Me.ButtonPEMINJAMAN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPEMINJAMAN.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_export_24_46622
        Me.ButtonPEMINJAMAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPEMINJAMAN.Location = New System.Drawing.Point(19, 13)
        Me.ButtonPEMINJAMAN.Name = "ButtonPEMINJAMAN"
        Me.ButtonPEMINJAMAN.Size = New System.Drawing.Size(225, 59)
        Me.ButtonPEMINJAMAN.TabIndex = 2
        Me.ButtonPEMINJAMAN.Text = "EXPORT TO EXCEL"
        Me.ButtonPEMINJAMAN.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TabelPENGEMBALIAN)
        Me.TabPage4.Controls.Add(Me.ButtonPENGEMBALIAN)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(857, 496)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Laporan PENGEMBALIAN"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabelPENGEMBALIAN
        '
        Me.TabelPENGEMBALIAN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabelPENGEMBALIAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelPENGEMBALIAN.Location = New System.Drawing.Point(19, 89)
        Me.TabelPENGEMBALIAN.Name = "TabelPENGEMBALIAN"
        Me.TabelPENGEMBALIAN.Size = New System.Drawing.Size(819, 394)
        Me.TabelPENGEMBALIAN.TabIndex = 3
        '
        'ButtonPENGEMBALIAN
        '
        Me.ButtonPENGEMBALIAN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPENGEMBALIAN.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_export_24_46622
        Me.ButtonPENGEMBALIAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPENGEMBALIAN.Location = New System.Drawing.Point(19, 13)
        Me.ButtonPENGEMBALIAN.Name = "ButtonPENGEMBALIAN"
        Me.ButtonPENGEMBALIAN.Size = New System.Drawing.Size(225, 59)
        Me.ButtonPENGEMBALIAN.TabIndex = 2
        Me.ButtonPENGEMBALIAN.Text = "EXPORT TO EXCEL"
        Me.ButtonPENGEMBALIAN.UseVisualStyleBackColor = True
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 568)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.TabelBUKU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TabelPENGGUNA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.TabelPEMINJAMAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.TabelPENGEMBALIAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonBUKU As System.Windows.Forms.Button
    Friend WithEvents TabelBUKU As System.Windows.Forms.DataGridView
    Friend WithEvents TabelPENGGUNA As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonPENGGUNA As System.Windows.Forms.Button
    Friend WithEvents TabelPEMINJAMAN As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonPEMINJAMAN As System.Windows.Forms.Button
    Friend WithEvents TabelPENGEMBALIAN As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonPENGEMBALIAN As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
