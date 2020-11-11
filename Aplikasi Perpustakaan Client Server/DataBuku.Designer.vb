<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBuku
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxASALBUKU = New System.Windows.Forms.ComboBox()
        Me.TextBoxNAMAPENGARANG = New System.Windows.Forms.TextBox()
        Me.TextBoxSTOK = New System.Windows.Forms.TextBox()
        Me.TextBoxTAHUNTERBIT = New System.Windows.Forms.TextBox()
        Me.TextBoxNAMAPENERBIT = New System.Windows.Forms.TextBox()
        Me.TextBoxJUDUL = New System.Windows.Forms.TextBox()
        Me.ButtonBUKU = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabelBUKU = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tabelBUKU, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Buku :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buttoncancel)
        Me.GroupBox1.Controls.Add(Me.LabelID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxASALBUKU)
        Me.GroupBox1.Controls.Add(Me.TextBoxNAMAPENGARANG)
        Me.GroupBox1.Controls.Add(Me.TextBoxSTOK)
        Me.GroupBox1.Controls.Add(Me.TextBoxTAHUNTERBIT)
        Me.GroupBox1.Controls.Add(Me.TextBoxNAMAPENERBIT)
        Me.GroupBox1.Controls.Add(Me.TextBoxJUDUL)
        Me.GroupBox1.Controls.Add(Me.ButtonBUKU)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 503)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Buku"
        '
        'Buttoncancel
        '
        Me.Buttoncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttoncancel.ForeColor = System.Drawing.Color.White
        Me.Buttoncancel.Location = New System.Drawing.Point(56, 447)
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
        Me.LabelID.Size = New System.Drawing.Size(30, 17)
        Me.LabelID.TabIndex = 13
        Me.LabelID.Text = "[id]"
        Me.LabelID.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Asal Buku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nama Pengarang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "STOK Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tahun Terbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Penerbit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Judul Buku"
        '
        'ComboBoxASALBUKU
        '
        Me.ComboBoxASALBUKU.FormattingEnabled = True
        Me.ComboBoxASALBUKU.Items.AddRange(New Object() {"BELI", "SUMBANGAN"})
        Me.ComboBoxASALBUKU.Location = New System.Drawing.Point(56, 349)
        Me.ComboBoxASALBUKU.Name = "ComboBoxASALBUKU"
        Me.ComboBoxASALBUKU.Size = New System.Drawing.Size(169, 25)
        Me.ComboBoxASALBUKU.TabIndex = 6
        '
        'TextBoxNAMAPENGARANG
        '
        Me.TextBoxNAMAPENGARANG.Location = New System.Drawing.Point(56, 299)
        Me.TextBoxNAMAPENGARANG.Name = "TextBoxNAMAPENGARANG"
        Me.TextBoxNAMAPENGARANG.Size = New System.Drawing.Size(299, 25)
        Me.TextBoxNAMAPENGARANG.TabIndex = 5
        '
        'TextBoxSTOK
        '
        Me.TextBoxSTOK.ForeColor = System.Drawing.Color.Green
        Me.TextBoxSTOK.Location = New System.Drawing.Point(56, 248)
        Me.TextBoxSTOK.Name = "TextBoxSTOK"
        Me.TextBoxSTOK.Size = New System.Drawing.Size(131, 25)
        Me.TextBoxSTOK.TabIndex = 4
        '
        'TextBoxTAHUNTERBIT
        '
        Me.TextBoxTAHUNTERBIT.ForeColor = System.Drawing.Color.Navy
        Me.TextBoxTAHUNTERBIT.Location = New System.Drawing.Point(56, 196)
        Me.TextBoxTAHUNTERBIT.Name = "TextBoxTAHUNTERBIT"
        Me.TextBoxTAHUNTERBIT.Size = New System.Drawing.Size(131, 25)
        Me.TextBoxTAHUNTERBIT.TabIndex = 3
        '
        'TextBoxNAMAPENERBIT
        '
        Me.TextBoxNAMAPENERBIT.Location = New System.Drawing.Point(56, 146)
        Me.TextBoxNAMAPENERBIT.Name = "TextBoxNAMAPENERBIT"
        Me.TextBoxNAMAPENERBIT.Size = New System.Drawing.Size(299, 25)
        Me.TextBoxNAMAPENERBIT.TabIndex = 2
        '
        'TextBoxJUDUL
        '
        Me.TextBoxJUDUL.Location = New System.Drawing.Point(56, 98)
        Me.TextBoxJUDUL.Name = "TextBoxJUDUL"
        Me.TextBoxJUDUL.Size = New System.Drawing.Size(299, 25)
        Me.TextBoxJUDUL.TabIndex = 1
        '
        'ButtonBUKU
        '
        Me.ButtonBUKU.BackColor = System.Drawing.Color.Green
        Me.ButtonBUKU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBUKU.ForeColor = System.Drawing.Color.White
        Me.ButtonBUKU.Location = New System.Drawing.Point(56, 398)
        Me.ButtonBUKU.Name = "ButtonBUKU"
        Me.ButtonBUKU.Size = New System.Drawing.Size(299, 43)
        Me.ButtonBUKU.TabIndex = 0
        Me.ButtonBUKU.Text = "SIMPAN"
        Me.ButtonBUKU.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.tabelBUKU)
        Me.GroupBox2.Location = New System.Drawing.Point(451, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 503)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Buku"
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
        Me.Label8.Size = New System.Drawing.Size(393, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "NB: Jika ingin MENGEDIT/MENGHAPUS klik BARIS yang dituju"
        '
        'tabelBUKU
        '
        Me.tabelBUKU.AllowUserToAddRows = False
        Me.tabelBUKU.AllowUserToDeleteRows = False
        Me.tabelBUKU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabelBUKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelBUKU.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tabelBUKU.Location = New System.Drawing.Point(14, 80)
        Me.tabelBUKU.Name = "tabelBUKU"
        Me.tabelBUKU.ReadOnly = True
        Me.tabelBUKU.Size = New System.Drawing.Size(365, 382)
        Me.tabelBUKU.TabIndex = 0
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
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(14, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 25)
        Me.TextBox1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "*Ketikkan Judul Buku Yang Ingin Dicari"
        '
        'DataBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 578)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DataBuku"
        Me.Text = "DataBuku"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tabelBUKU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonBUKU As System.Windows.Forms.Button
    Friend WithEvents TextBoxJUDUL As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxASALBUKU As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxNAMAPENGARANG As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSTOK As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTAHUNTERBIT As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNAMAPENERBIT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tabelBUKU As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents Buttoncancel As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
