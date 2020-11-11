<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataPengguna))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxJURUSAN = New System.Windows.Forms.ComboBox()
        Me.TextBoxPASSWORD = New System.Windows.Forms.TextBox()
        Me.TextBoxNIM = New System.Windows.Forms.TextBox()
        Me.TextBoxKELAS = New System.Windows.Forms.TextBox()
        Me.TextBoxNAMA = New System.Windows.Forms.TextBox()
        Me.ButtonPENGGUNA = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabelANGGOTA = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tabelANGGOTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buttoncancel)
        Me.GroupBox1.Controls.Add(Me.LabelID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxJURUSAN)
        Me.GroupBox1.Controls.Add(Me.TextBoxPASSWORD)
        Me.GroupBox1.Controls.Add(Me.TextBoxNIM)
        Me.GroupBox1.Controls.Add(Me.TextBoxKELAS)
        Me.GroupBox1.Controls.Add(Me.TextBoxNAMA)
        Me.GroupBox1.Controls.Add(Me.ButtonPENGGUNA)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 484)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Pengguna"
        '
        'Buttoncancel
        '
        Me.Buttoncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttoncancel.ForeColor = System.Drawing.Color.White
        Me.Buttoncancel.Location = New System.Drawing.Point(56, 419)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jurusan"
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
        'ComboBoxJURUSAN
        '
        Me.ComboBoxJURUSAN.FormattingEnabled = True
        Me.ComboBoxJURUSAN.Items.AddRange(New Object() {"Teknik Informatika"})
        Me.ComboBoxJURUSAN.Location = New System.Drawing.Point(56, 148)
        Me.ComboBoxJURUSAN.Name = "ComboBoxJURUSAN"
        Me.ComboBoxJURUSAN.Size = New System.Drawing.Size(299, 25)
        Me.ComboBoxJURUSAN.TabIndex = 6
        '
        'TextBoxPASSWORD
        '
        Me.TextBoxPASSWORD.Location = New System.Drawing.Point(56, 299)
        Me.TextBoxPASSWORD.Name = "TextBoxPASSWORD"
        Me.TextBoxPASSWORD.Size = New System.Drawing.Size(299, 25)
        Me.TextBoxPASSWORD.TabIndex = 5
        '
        'TextBoxNIM
        '
        Me.TextBoxNIM.ForeColor = System.Drawing.Color.Green
        Me.TextBoxNIM.Location = New System.Drawing.Point(56, 248)
        Me.TextBoxNIM.Name = "TextBoxNIM"
        Me.TextBoxNIM.Size = New System.Drawing.Size(169, 25)
        Me.TextBoxNIM.TabIndex = 4
        '
        'TextBoxKELAS
        '
        Me.TextBoxKELAS.ForeColor = System.Drawing.Color.Navy
        Me.TextBoxKELAS.Location = New System.Drawing.Point(56, 196)
        Me.TextBoxKELAS.Name = "TextBoxKELAS"
        Me.TextBoxKELAS.Size = New System.Drawing.Size(131, 25)
        Me.TextBoxKELAS.TabIndex = 3
        '
        'TextBoxNAMA
        '
        Me.TextBoxNAMA.Location = New System.Drawing.Point(56, 98)
        Me.TextBoxNAMA.Name = "TextBoxNAMA"
        Me.TextBoxNAMA.Size = New System.Drawing.Size(299, 25)
        Me.TextBoxNAMA.TabIndex = 1
        '
        'ButtonPENGGUNA
        '
        Me.ButtonPENGGUNA.BackColor = System.Drawing.Color.Green
        Me.ButtonPENGGUNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPENGGUNA.ForeColor = System.Drawing.Color.White
        Me.ButtonPENGGUNA.Location = New System.Drawing.Point(56, 369)
        Me.ButtonPENGGUNA.Name = "ButtonPENGGUNA"
        Me.ButtonPENGGUNA.Size = New System.Drawing.Size(299, 43)
        Me.ButtonPENGGUNA.TabIndex = 0
        Me.ButtonPENGGUNA.Text = "SIMPAN"
        Me.ButtonPENGGUNA.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 44)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pengguna :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.tabelANGGOTA)
        Me.GroupBox2.Location = New System.Drawing.Point(464, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 503)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Anggota"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 468)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 32)
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
        'tabelANGGOTA
        '
        Me.tabelANGGOTA.AllowUserToAddRows = False
        Me.tabelANGGOTA.AllowUserToDeleteRows = False
        Me.tabelANGGOTA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabelANGGOTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelANGGOTA.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tabelANGGOTA.Location = New System.Drawing.Point(14, 98)
        Me.tabelANGGOTA.Name = "tabelANGGOTA"
        Me.tabelANGGOTA.ReadOnly = True
        Me.tabelANGGOTA.Size = New System.Drawing.Size(365, 364)
        Me.tabelANGGOTA.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITToolStripMenuItem, Me.HAPUSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 48)
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDITToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.EDITToolStripMenuItem.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_save_edit_84875
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.EDITToolStripMenuItem.Text = "EDIT"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "*Ketikkan Nama Anggota Yang Ingin Dicari"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(14, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 25)
        Me.TextBox1.TabIndex = 7
        '
        'DataPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 586)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DataPengguna"
        Me.Text = "DataPengguna"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tabelANGGOTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Buttoncancel As System.Windows.Forms.Button
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxJURUSAN As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNIM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKELAS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNAMA As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPENGGUNA As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tabelANGGOTA As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
