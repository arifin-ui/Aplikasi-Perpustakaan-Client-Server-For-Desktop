<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPengembalian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataPengembalian))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Labelidbuku = New System.Windows.Forms.Label()
        Me.Labelidpengguna = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDenda = New System.Windows.Forms.TextBox()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxJUMLAH = New System.Windows.Forms.TextBox()
        Me.TextBoxKeterangan = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.ButtonPENGEMBALIAN = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabelDataPengembalian = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tabelDataPengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(865, 44)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pengembalian :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Labelidbuku)
        Me.GroupBox1.Controls.Add(Me.Labelidpengguna)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxDenda)
        Me.GroupBox1.Controls.Add(Me.ButtonCari)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Buttoncancel)
        Me.GroupBox1.Controls.Add(Me.LabelID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxJUMLAH)
        Me.GroupBox1.Controls.Add(Me.TextBoxKeterangan)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.ButtonPENGEMBALIAN)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 486)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Peminjaman"
        '
        'Labelidbuku
        '
        Me.Labelidbuku.AutoSize = True
        Me.Labelidbuku.Location = New System.Drawing.Point(232, 12)
        Me.Labelidbuku.Name = "Labelidbuku"
        Me.Labelidbuku.Size = New System.Drawing.Size(63, 17)
        Me.Labelidbuku.TabIndex = 22
        Me.Labelidbuku.Text = "[id_buku]"
        Me.Labelidbuku.Visible = False
        '
        'Labelidpengguna
        '
        Me.Labelidpengguna.AutoSize = True
        Me.Labelidpengguna.Location = New System.Drawing.Point(232, 35)
        Me.Labelidpengguna.Name = "Labelidpengguna"
        Me.Labelidpengguna.Size = New System.Drawing.Size(94, 17)
        Me.Labelidpengguna.TabIndex = 21
        Me.Labelidpengguna.Text = "[id_pengguna]"
        Me.Labelidpengguna.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(53, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Denda"
        '
        'TextBoxDenda
        '
        Me.TextBoxDenda.ForeColor = System.Drawing.Color.Green
        Me.TextBoxDenda.Location = New System.Drawing.Point(55, 219)
        Me.TextBoxDenda.Name = "TextBoxDenda"
        Me.TextBoxDenda.Size = New System.Drawing.Size(288, 25)
        Me.TextBoxDenda.TabIndex = 19
        '
        'ButtonCari
        '
        Me.ButtonCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCari.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.iconfinder_search_4103
        Me.ButtonCari.Location = New System.Drawing.Point(350, 92)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(46, 34)
        Me.ButtonCari.TabIndex = 17
        Me.ButtonCari.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 266)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(179, 25)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Buttoncancel
        '
        Me.Buttoncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttoncancel.ForeColor = System.Drawing.Color.White
        Me.Buttoncancel.Location = New System.Drawing.Point(56, 422)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jumlah Kembali"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tanggal Kembali"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "KETERANGAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID PEMINJAMAN"
        '
        'TextBoxJUMLAH
        '
        Me.TextBoxJUMLAH.Enabled = False
        Me.TextBoxJUMLAH.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJUMLAH.ForeColor = System.Drawing.Color.Green
        Me.TextBoxJUMLAH.Location = New System.Drawing.Point(55, 319)
        Me.TextBoxJUMLAH.Name = "TextBoxJUMLAH"
        Me.TextBoxJUMLAH.Size = New System.Drawing.Size(94, 33)
        Me.TextBoxJUMLAH.TabIndex = 4
        Me.TextBoxJUMLAH.Text = "1"
        Me.TextBoxJUMLAH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxKeterangan
        '
        Me.TextBoxKeterangan.Location = New System.Drawing.Point(56, 146)
        Me.TextBoxKeterangan.Multiline = True
        Me.TextBoxKeterangan.Name = "TextBoxKeterangan"
        Me.TextBoxKeterangan.Size = New System.Drawing.Size(288, 52)
        Me.TextBoxKeterangan.TabIndex = 2
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Location = New System.Drawing.Point(56, 98)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(288, 25)
        Me.TextBoxID.TabIndex = 1
        '
        'ButtonPENGEMBALIAN
        '
        Me.ButtonPENGEMBALIAN.BackColor = System.Drawing.Color.Green
        Me.ButtonPENGEMBALIAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPENGEMBALIAN.ForeColor = System.Drawing.Color.White
        Me.ButtonPENGEMBALIAN.Location = New System.Drawing.Point(56, 361)
        Me.ButtonPENGEMBALIAN.Name = "ButtonPENGEMBALIAN"
        Me.ButtonPENGEMBALIAN.Size = New System.Drawing.Size(299, 43)
        Me.ButtonPENGEMBALIAN.TabIndex = 0
        Me.ButtonPENGEMBALIAN.Text = "KEMBALIKAN"
        Me.ButtonPENGEMBALIAN.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.tabelDataPengembalian)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(451, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 489)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Data Peminjaman"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 454)
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
        'tabelDataPengembalian
        '
        Me.tabelDataPengembalian.AllowUserToAddRows = False
        Me.tabelDataPengembalian.AllowUserToDeleteRows = False
        Me.tabelDataPengembalian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabelDataPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataPengembalian.Location = New System.Drawing.Point(14, 35)
        Me.tabelDataPengembalian.Name = "tabelDataPengembalian"
        Me.tabelDataPengembalian.ReadOnly = True
        Me.tabelDataPengembalian.Size = New System.Drawing.Size(379, 413)
        Me.tabelDataPengembalian.TabIndex = 0
        '
        'DataPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 576)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DataPengembalian"
        Me.Text = "DataPengembalian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tabelDataPengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Buttoncancel As System.Windows.Forms.Button
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJUMLAH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPENGEMBALIAN As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tabelDataPengembalian As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDenda As System.Windows.Forms.TextBox
    Friend WithEvents Labelidbuku As System.Windows.Forms.Label
    Friend WithEvents Labelidpengguna As System.Windows.Forms.Label
End Class
