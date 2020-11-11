<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPeminjaman
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataPeminjaman))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCariBuku = New System.Windows.Forms.Button()
        Me.ButtonCariPengguna = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelIDPENGGUNA = New System.Windows.Forms.Label()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelIDBUKU = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxJUMLAH = New System.Windows.Forms.TextBox()
        Me.TextBoxJUDUl = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.ButtonPEMINJAMAN = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabelDataPeminjaman = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tabelDataPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 44)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Peminjaman :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCariBuku)
        Me.GroupBox1.Controls.Add(Me.ButtonCariPengguna)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.LabelIDPENGGUNA)
        Me.GroupBox1.Controls.Add(Me.Buttoncancel)
        Me.GroupBox1.Controls.Add(Me.LabelID)
        Me.GroupBox1.Controls.Add(Me.LabelIDBUKU)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxJUMLAH)
        Me.GroupBox1.Controls.Add(Me.TextBoxJUDUl)
        Me.GroupBox1.Controls.Add(Me.TextBoxNama)
        Me.GroupBox1.Controls.Add(Me.ButtonPEMINJAMAN)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 429)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Peminjaman"
        '
        'ButtonCariBuku
        '
        Me.ButtonCariBuku.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCariBuku.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCariBuku.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_search_4103
        Me.ButtonCariBuku.Location = New System.Drawing.Point(350, 142)
        Me.ButtonCariBuku.Name = "ButtonCariBuku"
        Me.ButtonCariBuku.Size = New System.Drawing.Size(46, 34)
        Me.ButtonCariBuku.TabIndex = 18
        Me.ButtonCariBuku.UseVisualStyleBackColor = False
        '
        'ButtonCariPengguna
        '
        Me.ButtonCariPengguna.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCariPengguna.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCariPengguna.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_search_4103
        Me.ButtonCariPengguna.Location = New System.Drawing.Point(350, 92)
        Me.ButtonCariPengguna.Name = "ButtonCariPengguna"
        Me.ButtonCariPengguna.Size = New System.Drawing.Size(46, 34)
        Me.ButtonCariPengguna.TabIndex = 17
        Me.ButtonCariPengguna.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(57, 195)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(179, 25)
        Me.DateTimePicker1.TabIndex = 16
        '
        'LabelIDPENGGUNA
        '
        Me.LabelIDPENGGUNA.AutoSize = True
        Me.LabelIDPENGGUNA.Location = New System.Drawing.Point(163, 80)
        Me.LabelIDPENGGUNA.Name = "LabelIDPENGGUNA"
        Me.LabelIDPENGGUNA.Size = New System.Drawing.Size(94, 17)
        Me.LabelIDPENGGUNA.TabIndex = 15
        Me.LabelIDPENGGUNA.Text = "[id_pengguna]"
        Me.LabelIDPENGGUNA.Visible = False
        '
        'Buttoncancel
        '
        Me.Buttoncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttoncancel.ForeColor = System.Drawing.Color.White
        Me.Buttoncancel.Location = New System.Drawing.Point(57, 360)
        Me.Buttoncancel.Name = "Buttoncancel"
        Me.Buttoncancel.Size = New System.Drawing.Size(299, 43)
        Me.Buttoncancel.TabIndex = 14
        Me.Buttoncancel.Text = "CLEAR"
        Me.Buttoncancel.UseVisualStyleBackColor = False
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(54, 51)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(27, 17)
        Me.LabelID.TabIndex = 13
        Me.LabelID.Text = "[id]"
        Me.LabelID.Visible = False
        '
        'LabelIDBUKU
        '
        Me.LabelIDBUKU.AutoSize = True
        Me.LabelIDBUKU.Location = New System.Drawing.Point(134, 128)
        Me.LabelIDBUKU.Name = "LabelIDBUKU"
        Me.LabelIDBUKU.Size = New System.Drawing.Size(63, 17)
        Me.LabelIDBUKU.TabIndex = 11
        Me.LabelIDBUKU.Text = "[id_buku]"
        Me.LabelIDBUKU.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jumlah Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Judul Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Pengguna"
        '
        'TextBoxJUMLAH
        '
        Me.TextBoxJUMLAH.Enabled = False
        Me.TextBoxJUMLAH.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJUMLAH.ForeColor = System.Drawing.Color.Green
        Me.TextBoxJUMLAH.Location = New System.Drawing.Point(56, 248)
        Me.TextBoxJUMLAH.Name = "TextBoxJUMLAH"
        Me.TextBoxJUMLAH.Size = New System.Drawing.Size(94, 33)
        Me.TextBoxJUMLAH.TabIndex = 4
        Me.TextBoxJUMLAH.Text = "1"
        Me.TextBoxJUMLAH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxJUDUl
        '
        Me.TextBoxJUDUl.Enabled = False
        Me.TextBoxJUDUl.Location = New System.Drawing.Point(56, 146)
        Me.TextBoxJUDUl.Name = "TextBoxJUDUl"
        Me.TextBoxJUDUl.Size = New System.Drawing.Size(288, 25)
        Me.TextBoxJUDUl.TabIndex = 2
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Enabled = False
        Me.TextBoxNama.Location = New System.Drawing.Point(56, 98)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(288, 25)
        Me.TextBoxNama.TabIndex = 1
        '
        'ButtonPEMINJAMAN
        '
        Me.ButtonPEMINJAMAN.BackColor = System.Drawing.Color.Green
        Me.ButtonPEMINJAMAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPEMINJAMAN.ForeColor = System.Drawing.Color.White
        Me.ButtonPEMINJAMAN.Location = New System.Drawing.Point(57, 299)
        Me.ButtonPEMINJAMAN.Name = "ButtonPEMINJAMAN"
        Me.ButtonPEMINJAMAN.Size = New System.Drawing.Size(299, 43)
        Me.ButtonPEMINJAMAN.TabIndex = 0
        Me.ButtonPEMINJAMAN.Text = "SIMPAN"
        Me.ButtonPEMINJAMAN.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.tabelDataPeminjaman)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(453, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 428)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Data Peminjaman"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 393)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 32)
        Me.Panel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(381, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "NB: Jika ingin MENGEDIT/MENGHAPUS klik BARIS yang dituju"
        '
        'tabelDataPeminjaman
        '
        Me.tabelDataPeminjaman.AllowUserToAddRows = False
        Me.tabelDataPeminjaman.AllowUserToDeleteRows = False
        Me.tabelDataPeminjaman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabelDataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataPeminjaman.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tabelDataPeminjaman.Location = New System.Drawing.Point(14, 35)
        Me.tabelDataPeminjaman.Name = "tabelDataPeminjaman"
        Me.tabelDataPeminjaman.ReadOnly = True
        Me.tabelDataPeminjaman.Size = New System.Drawing.Size(379, 352)
        Me.tabelDataPeminjaman.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HAPUSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HAPUSToolStripMenuItem.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_save_delete_60017
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'DataPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 503)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataPeminjaman"
        Me.Text = "DataPeminjaman"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tabelDataPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelIDPENGGUNA As System.Windows.Forms.Label
    Friend WithEvents Buttoncancel As System.Windows.Forms.Button
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents LabelIDBUKU As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJUMLAH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJUDUl As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPEMINJAMAN As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tabelDataPeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonCariPengguna As System.Windows.Forms.Button
    Friend WithEvents ButtonCariBuku As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
