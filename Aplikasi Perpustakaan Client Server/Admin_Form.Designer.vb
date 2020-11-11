<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Labelcopyright = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBoxUSERNAME = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonAbout = New System.Windows.Forms.Button()
        Me.ButtonPengembalian = New System.Windows.Forms.Button()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.ButtonDataPengembalian = New System.Windows.Forms.Button()
        Me.ButtonDataPeminjaman = New System.Windows.Forms.Button()
        Me.ButtonDataPenguna = New System.Windows.Forms.Button()
        Me.ButtonDataBuku = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 42)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 42)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Perpustakaan Client-Server"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(674, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(724, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.Labelcopyright)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 548)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(258, 46)
        Me.Panel3.TabIndex = 12
        '
        'Labelcopyright
        '
        Me.Labelcopyright.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labelcopyright.AutoSize = True
        Me.Labelcopyright.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcopyright.ForeColor = System.Drawing.Color.White
        Me.Labelcopyright.Location = New System.Drawing.Point(3, 14)
        Me.Labelcopyright.Name = "Labelcopyright"
        Me.Labelcopyright.Size = New System.Drawing.Size(67, 17)
        Me.Labelcopyright.TabIndex = 0
        Me.Labelcopyright.Text = "copyright"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.Button4)
        Me.GunaGroupBox1.Controls.Add(Me.TextBoxUSERNAME)
        Me.GunaGroupBox1.Controls.Add(Me.Panel3)
        Me.GunaGroupBox1.Controls.Add(Me.PictureBox1)
        Me.GunaGroupBox1.Controls.Add(Me.Button3)
        Me.GunaGroupBox1.Controls.Add(Me.ButtonAbout)
        Me.GunaGroupBox1.Controls.Add(Me.ButtonPengembalian)
        Me.GunaGroupBox1.Controls.Add(Me.ButtonDashboard)
        Me.GunaGroupBox1.Controls.Add(Me.ButtonDataPengembalian)
        Me.GunaGroupBox1.Controls.Add(Me.ButtonDataPeminjaman)
        Me.GunaGroupBox1.Controls.Add(Me.ButtonDataPenguna)
        Me.GunaGroupBox1.Controls.Add(Me.ButtonDataBuku)
        Me.GunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.LimeGreen
        Me.GunaGroupBox1.Location = New System.Drawing.Point(0, 42)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(258, 594)
        Me.GunaGroupBox1.TabIndex = 13
        Me.GunaGroupBox1.Text = "Admin Panel :"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(0, 426)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(258, 32)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "REFRESH DATA"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBoxUSERNAME
        '
        Me.TextBoxUSERNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxUSERNAME.Enabled = False
        Me.TextBoxUSERNAME.Location = New System.Drawing.Point(0, 108)
        Me.TextBoxUSERNAME.Name = "TextBoxUSERNAME"
        Me.TextBoxUSERNAME.Size = New System.Drawing.Size(258, 29)
        Me.TextBoxUSERNAME.TabIndex = 10
        Me.TextBoxUSERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(0, 463)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(258, 32)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "LOGOUT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ButtonAbout
        '
        Me.ButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAbout.Location = New System.Drawing.Point(0, 390)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(258, 32)
        Me.ButtonAbout.TabIndex = 7
        Me.ButtonAbout.Text = "About"
        Me.ButtonAbout.UseVisualStyleBackColor = True
        '
        'ButtonPengembalian
        '
        Me.ButtonPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPengembalian.Location = New System.Drawing.Point(0, 350)
        Me.ButtonPengembalian.Name = "ButtonPengembalian"
        Me.ButtonPengembalian.Size = New System.Drawing.Size(258, 32)
        Me.ButtonPengembalian.TabIndex = 5
        Me.ButtonPengembalian.Text = "LAPORAN"
        Me.ButtonPengembalian.UseVisualStyleBackColor = True
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDashboard.Location = New System.Drawing.Point(0, 159)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(258, 32)
        Me.ButtonDashboard.TabIndex = 4
        Me.ButtonDashboard.Text = "DASHBOARD"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'ButtonDataPengembalian
        '
        Me.ButtonDataPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDataPengembalian.Location = New System.Drawing.Point(0, 311)
        Me.ButtonDataPengembalian.Name = "ButtonDataPengembalian"
        Me.ButtonDataPengembalian.Size = New System.Drawing.Size(258, 32)
        Me.ButtonDataPengembalian.TabIndex = 3
        Me.ButtonDataPengembalian.Text = "Data Pengembalian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonDataPengembalian.UseVisualStyleBackColor = True
        '
        'ButtonDataPeminjaman
        '
        Me.ButtonDataPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDataPeminjaman.Location = New System.Drawing.Point(0, 273)
        Me.ButtonDataPeminjaman.Name = "ButtonDataPeminjaman"
        Me.ButtonDataPeminjaman.Size = New System.Drawing.Size(258, 32)
        Me.ButtonDataPeminjaman.TabIndex = 2
        Me.ButtonDataPeminjaman.Text = "Data Peminjaman"
        Me.ButtonDataPeminjaman.UseVisualStyleBackColor = True
        '
        'ButtonDataPenguna
        '
        Me.ButtonDataPenguna.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDataPenguna.Location = New System.Drawing.Point(0, 235)
        Me.ButtonDataPenguna.Name = "ButtonDataPenguna"
        Me.ButtonDataPenguna.Size = New System.Drawing.Size(258, 32)
        Me.ButtonDataPenguna.TabIndex = 1
        Me.ButtonDataPenguna.Text = "Data Pengguna"
        Me.ButtonDataPenguna.UseVisualStyleBackColor = True
        '
        'ButtonDataBuku
        '
        Me.ButtonDataBuku.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDataBuku.Location = New System.Drawing.Point(0, 197)
        Me.ButtonDataBuku.Name = "ButtonDataBuku"
        Me.ButtonDataBuku.Size = New System.Drawing.Size(258, 32)
        Me.ButtonDataBuku.TabIndex = 0
        Me.ButtonDataBuku.Text = "Data Buku"
        Me.ButtonDataBuku.UseVisualStyleBackColor = True
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(258, 42)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(513, 594)
        Me.PanelMain.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources.boy
        Me.PictureBox1.Location = New System.Drawing.Point(93, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Admin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 636)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin_Form"
        Me.Text = "Admin_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Labelcopyright As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents ButtonAbout As System.Windows.Forms.Button
    Friend WithEvents ButtonDashboard As System.Windows.Forms.Button
    Friend WithEvents ButtonDataPengembalian As System.Windows.Forms.Button
    Friend WithEvents ButtonDataPeminjaman As System.Windows.Forms.Button
    Friend WithEvents ButtonDataPenguna As System.Windows.Forms.Button
    Friend WithEvents ButtonDataBuku As System.Windows.Forms.Button
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonPengembalian As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxUSERNAME As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
