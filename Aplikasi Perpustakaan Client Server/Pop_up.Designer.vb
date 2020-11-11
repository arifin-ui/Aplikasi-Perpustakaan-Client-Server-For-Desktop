<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pop_up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pop_up))
        Me.GroupBoxPengguna = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCariPengguna = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabelPengguna = New System.Windows.Forms.DataGridView()
        Me.GroupBoxBuku = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCariBuku = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabelBuku = New System.Windows.Forms.DataGridView()
        Me.GroupBoxPeminjaman = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBoxPengguna.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TabelPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBuku.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TabelBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPeminjaman.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxPengguna
        '
        Me.GroupBoxPengguna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPengguna.Controls.Add(Me.Label2)
        Me.GroupBoxPengguna.Controls.Add(Me.Label1)
        Me.GroupBoxPengguna.Controls.Add(Me.TextBoxCariPengguna)
        Me.GroupBoxPengguna.Controls.Add(Me.Panel2)
        Me.GroupBoxPengguna.Controls.Add(Me.TabelPengguna)
        Me.GroupBoxPengguna.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPengguna.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxPengguna.Name = "GroupBoxPengguna"
        Me.GroupBoxPengguna.Size = New System.Drawing.Size(413, 499)
        Me.GroupBoxPengguna.TabIndex = 0
        Me.GroupBoxPengguna.TabStop = False
        Me.GroupBoxPengguna.Text = "Data Pengguna"
        Me.GroupBoxPengguna.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "*Ketikkan Nama Pengguna Yang Ingin Dicari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tabel Pengguna"
        '
        'TextBoxCariPengguna
        '
        Me.TextBoxCariPengguna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCariPengguna.Location = New System.Drawing.Point(6, 53)
        Me.TextBoxCariPengguna.Name = "TextBoxCariPengguna"
        Me.TextBoxCariPengguna.Size = New System.Drawing.Size(401, 25)
        Me.TextBoxCariPengguna.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 464)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 32)
        Me.Panel2.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(326, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "NB: Jika ingin MEMILIH silahkan KLIK bari pada tabel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabelPengguna
        '
        Me.TabelPengguna.AllowUserToAddRows = False
        Me.TabelPengguna.AllowUserToDeleteRows = False
        Me.TabelPengguna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabelPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelPengguna.Location = New System.Drawing.Point(6, 102)
        Me.TabelPengguna.Name = "TabelPengguna"
        Me.TabelPengguna.ReadOnly = True
        Me.TabelPengguna.Size = New System.Drawing.Size(401, 361)
        Me.TabelPengguna.TabIndex = 0
        '
        'GroupBoxBuku
        '
        Me.GroupBoxBuku.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxBuku.Controls.Add(Me.Label3)
        Me.GroupBoxBuku.Controls.Add(Me.Label4)
        Me.GroupBoxBuku.Controls.Add(Me.TextBoxCariBuku)
        Me.GroupBoxBuku.Controls.Add(Me.Panel1)
        Me.GroupBoxBuku.Controls.Add(Me.TabelBuku)
        Me.GroupBoxBuku.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBuku.Location = New System.Drawing.Point(9, 12)
        Me.GroupBoxBuku.Name = "GroupBoxBuku"
        Me.GroupBoxBuku.Size = New System.Drawing.Size(413, 499)
        Me.GroupBoxBuku.TabIndex = 6
        Me.GroupBoxBuku.TabStop = False
        Me.GroupBoxBuku.Text = "Data Buku"
        Me.GroupBoxBuku.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*Ketikkan Judul Buku Yang Ingin Dicari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tabel Buku"
        '
        'TextBoxCariBuku
        '
        Me.TextBoxCariBuku.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCariBuku.Location = New System.Drawing.Point(6, 53)
        Me.TextBoxCariBuku.Name = "TextBoxCariBuku"
        Me.TextBoxCariBuku.Size = New System.Drawing.Size(401, 25)
        Me.TextBoxCariBuku.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 464)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 32)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(326, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "NB: Jika ingin MEMILIH silahkan KLIK bari pada tabel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabelBuku
        '
        Me.TabelBuku.AllowUserToAddRows = False
        Me.TabelBuku.AllowUserToDeleteRows = False
        Me.TabelBuku.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabelBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelBuku.Location = New System.Drawing.Point(6, 102)
        Me.TabelBuku.Name = "TabelBuku"
        Me.TabelBuku.ReadOnly = True
        Me.TabelBuku.Size = New System.Drawing.Size(401, 361)
        Me.TabelBuku.TabIndex = 0
        '
        'GroupBoxPeminjaman
        '
        Me.GroupBoxPeminjaman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPeminjaman.Controls.Add(Me.Label7)
        Me.GroupBoxPeminjaman.Controls.Add(Me.Panel3)
        Me.GroupBoxPeminjaman.Controls.Add(Me.DataGridView1)
        Me.GroupBoxPeminjaman.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPeminjaman.Location = New System.Drawing.Point(6, 12)
        Me.GroupBoxPeminjaman.Name = "GroupBoxPeminjaman"
        Me.GroupBoxPeminjaman.Size = New System.Drawing.Size(419, 499)
        Me.GroupBoxPeminjaman.TabIndex = 7
        Me.GroupBoxPeminjaman.TabStop = False
        Me.GroupBoxPeminjaman.Text = "Data Peminjaman"
        Me.GroupBoxPeminjaman.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tabel Peminjaman"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 464)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 32)
        Me.Panel3.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(326, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "NB: Jika ingin MEMILIH silahkan KLIK bari pada tabel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(407, 418)
        Me.DataGridView1.TabIndex = 0
        '
        'Pop_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 523)
        Me.Controls.Add(Me.GroupBoxPeminjaman)
        Me.Controls.Add(Me.GroupBoxBuku)
        Me.Controls.Add(Me.GroupBoxPengguna)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pop_up"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM POP UP"
        Me.GroupBoxPengguna.ResumeLayout(False)
        Me.GroupBoxPengguna.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TabelPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBuku.ResumeLayout(False)
        Me.GroupBoxBuku.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TabelBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPeminjaman.ResumeLayout(False)
        Me.GroupBoxPeminjaman.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxPengguna As System.Windows.Forms.GroupBox
    Friend WithEvents TabelPengguna As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCariPengguna As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxBuku As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCariBuku As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabelBuku As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBoxPeminjaman As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
